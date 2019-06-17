using DevExpress.XtraEditors;
using Email_Sorter_Tool.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Sorter_Tool.Static
{
    public class SettingStatic
    {
        private static SettingStatic _instance;
        public static SettingStatic Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SettingStatic();
                }
                return _instance;
            }
        }
        public static readonly string sshFolder = Application.StartupPath + "\\SshFolder\\";
        public static readonly string sshFilePath = sshFolder + "ssh.txt";

        public void CheckFolderAndFileIfNotExist()
        {
            while(!Directory.Exists(sshFolder))
            {
                Directory.CreateDirectory(sshFolder);
            }
            while (!File.Exists(sshFilePath))
            {
                File.Create(sshFilePath).Close();
            }
        }

        public IEnumerable<SshDetail> LoadSshFromFileSelectedAndSave(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var listSsh = new List<SshDetail>();
            foreach (var item in lines)
            {
                var ssh = new SshDetail();
                var split = item.Split('|');
                if (split.Length < 2 || split.Contains("")) continue;
                ssh.Host = split[0];
                ssh.Username = split[1];
                ssh.Password = split[2];
                listSsh.Add(ssh);
                yield return ssh;
            }
            if (listSsh.Count > 0) SaveSshToFile(listSsh);
        }

        public void SaveSshToFile(List<SshDetail> listSsh)
        {
            TextWriter tw = new StreamWriter(sshFilePath, false);
            foreach (var item in listSsh)
                tw.WriteLine($"{item.Host}|{item.Username}|{item.Password}");
            tw.Close();
        }

        public List<SshDetail> LoadSshFromFileSource()
        {
            var lines = File.ReadAllLines(sshFilePath);
            var listSsh = new List<SshDetail>();
            foreach (var item in lines)
            {
                var ssh = new SshDetail();
                var split = item.Split('|');
                if (split.Length < 3 || split.Contains("")) continue;
                ssh.Host = split[0];
                ssh.Username = split[1];
                ssh.Password = split[2];
                listSsh.Add(ssh);
            }
            return listSsh;
        }


    }
}
