using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Email_Sorter_Tool.Static;
using System.IO;
using Newtonsoft.Json;

namespace Email_Sorter_Tool.HomeModule.Sub_Settings
{
    public partial class FrmSettings : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler<EmailDetailsEventArg> EmailChecked;
        protected virtual void OnEmailChecked(EmailDetailsEventArg e)
        {
            EmailChecked?.Invoke(this, e);
        }
        public List<EmailDetails> listTask = new List<EmailDetails>();
        public FrmSettings()
        {
            InitializeComponent();
            LoadSettingsToForm();
        }

        private void LoadSettingsToForm()
        {
            List<CheckEdit> ckes = new List<CheckEdit>() { ckeGmail, ckeYahoo, ckeOutLook, ckeMail, ckeGoDaddy, ckeRackSpace, ckeNwSolutions, ckeProofPoint, ckeOthers };
            if (!File.Exists(HomeStatic.settingsFilePath))
            {
                HomeStatic.Instance.CheckFileExist(ckes);
            }
            else
            {
                HomeStatic.Instance.LoadSettingsFromFile(ckes);
            }
        }

        private void sbSave_Click(object sender, System.EventArgs e)
        {
            List<CheckEdit> ckes = new List<CheckEdit>() { ckeGmail, ckeYahoo, ckeOutLook, ckeMail, ckeGoDaddy, ckeRackSpace, ckeNwSolutions, ckeProofPoint, ckeOthers };
            var emails = new List<EmailDetails>();
            for (int i = 0; i < ckes.Count; i++)
            {
                emails.Add(new EmailDetails()
                {
                    EmailType = ckes[i].Tag.ToString(),
                    FileName = $"{ckes[i].Tag.ToString()}.txt",
                    IsSaved = ckes[i].Checked ? true : false,
                    Percentage = "0%",
                    ResultCount = 0,
                });
            }
            var jsonConvert = JsonConvert.SerializeObject(emails);
            HomeStatic.Instance.SaveSettingsToFile(jsonConvert);
            this.Close();

            listTask = emails.Where(x => x.IsSaved == true).ToList();
            OnEmailChecked(new EmailDetailsEventArg()
            {
                EmailChecked = listTask
            });
        }

        private void svCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}