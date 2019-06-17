using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Email_Sorter_Tool.HomeModule;
using Email_Sorter_Tool.HomeModule.Sub_Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Sorter_Tool.Static
{
    public partial class HomeStatic
    {
        private static HomeStatic _instance;
        public static HomeStatic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HomeStatic();
                }
                return _instance;
            }
        }
        public static readonly string settingsFilePath = Application.StartupPath + "\\st.st";
        public static readonly string saveFolderPath = Application.StartupPath + "\\Save\\";

        public void CheckFileExist(List<CheckEdit> listCke)
        {
            while (!File.Exists(settingsFilePath))
            {
                File.Create(settingsFilePath).Close();
                var emails = new List<KeyValuePair<string, bool>>();
                for (int i = 0; i < listCke.Count; i++)
                {
                    emails.Add(new KeyValuePair<string, bool>(listCke[i].Tag.ToString(), false));
                }
                var jsonConvert = JsonConvert.SerializeObject(emails);
                HomeStatic.Instance.SaveSettingsToFile(jsonConvert);
            }
        }

        public void SaveSettingsToFile(string jsonSettings)
        {
            TextWriter tw = new StreamWriter(settingsFilePath, false);
            tw.WriteLine(jsonSettings);
            tw.Close();
        }

        public void LoadSettingsFromFile(List<CheckEdit> listCke)
        {
            var lines = File.ReadAllText(settingsFilePath);
            var json = JsonConvert.DeserializeObject<List<EmailDetails>>(lines);
            for (int i = 0; i < json.Count; i++)
            {
                listCke[i].Checked = json[i].IsSaved == true ? true : false;
            }
        }

        public List<EmailDetails> DefaultEmailInfo()
        {
            var emails = new List<EmailDetails>();
            var lines = File.ReadAllText(settingsFilePath);
            var json = JsonConvert.DeserializeObject<List<EmailDetails>>(lines).Where(x => x.IsSaved == true).ToList();

            json.ForEach(x => emails.Add(new EmailDetails() { EmailType = x.EmailType, FileName = x.FileName, Percentage = x.Percentage, ResultCount = x.ResultCount }));
            return emails;
        }

        public List<EmailDetails> CheckSaveDetails()
        {
            var listEmailType = new List<EmailDetails>();
            var lines = File.ReadAllText(settingsFilePath);
            var jsonList = JsonConvert.DeserializeObject<List<EmailDetails>>(lines);
            foreach (var item in jsonList)
            {
                var name = item.EmailType;
            }
            return jsonList;
        }

        public void CheckFolderIfNotExist()
        {
            while (Directory.Exists(saveFolderPath))
            {
                try
                {
                    Directory.Delete(saveFolderPath, true);
                }
                catch
                {
                }
            }
            while (!Directory.Exists(saveFolderPath))
            {
                Directory.CreateDirectory(saveFolderPath);
            }
        }

        public void CheckFileExist(string filePath)
        {
            while (!File.Exists(saveFolderPath + filePath))
            {
                File.Create(saveFolderPath + filePath).Close();
            }
        }

        public void SaveEmailsToFile(string email, string filePath)
        {
            if (!File.Exists(filePath)) { CheckFileExist(filePath); }
            try
            {
                FileStream fs = new FileStream(saveFolderPath + filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                var temEmail = email;
                sw.Write(temEmail + Environment.NewLine);
                sw.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        public void KillProcessByName(string name)
        {
            var processes = Process.GetProcessesByName(name);
            foreach (var item in processes)
            {
                try
                {
                    item.Kill();
                }
                catch
                {
                }

            }
        }

        public void SshAutoControlIfNostExist()
        {
            var oldControl = Process.GetProcessesByName("autocontrol");
            if (oldControl.Length == 0)
            {
                Process.Start(Application.StartupPath + "\\autocontrol.exe");
            }
        }

        public object o = new object();
        public void ChangeImages(BarStaticItem item)
        {
            try
            {
                item.Caption = " Running...";
                item.ImageOptions.Image = Properties.Resources.r1;
                Thread.Sleep(150);

                item.ImageOptions.Image = Properties.Resources.r2;
                Thread.Sleep(150);

                item.ImageOptions.Image = Properties.Resources.r3;
                Thread.Sleep(150);

                item.ImageOptions.Image = Properties.Resources.r4;
                Thread.Sleep(150);

                item.ImageOptions.Image = Properties.Resources.r5;
                Thread.Sleep(150);

                item.ImageOptions.Image = Properties.Resources.r6;
                Thread.Sleep(150);

                item.ImageOptions.Image = Properties.Resources.r7;
                Thread.Sleep(150);

                item.ImageOptions.Image = Properties.Resources.r8;
                Thread.Sleep(150);

                item.ImageOptions.Image = Properties.Resources.r9;
                Thread.Sleep(150);
            }
            catch
            {
            }
        }
    }
}
