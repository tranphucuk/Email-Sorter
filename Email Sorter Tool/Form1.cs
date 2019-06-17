using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Email_Sorter_Tool.About_Modules;
using Email_Sorter_Tool.HomeModule;
using Email_Sorter_Tool.License;
using Email_Sorter_Tool.Settings;
using Email_Sorter_Tool.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Email_Sorter_Tool
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            CheckLicense();
        }

        private void CheckLicense()
        {
            var license = LicenseInfoController.Instance.GetLicense();
            switch (license.Type)
            {
                case LicenseType.Invalid:
                    {
                        var frm = new FrmLicense() { Text = "Invalid Key" };
                        frm.ShowDialog();
                        this.Close();
                        break;
                    }
                case LicenseType.Valid:
                    break;
                case LicenseType.Expired:
                    {
                        var frm = new FrmLicense() { Text = "Key has Expired" };
                        frm.ShowDialog();
                        this.Close();
                        break;
                    }
                default:
                    break;
            }
        }

        private void ChangeModuleTo<T>() where T : XtraUserControl
        {
            SplashScreenManager.ShowForm(FindForm(), typeof(WaitForm1), true, true, false);
            panelControl1.Controls.Clear();
            var newModule = Activator.CreateInstance<T>();
            newModule.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(newModule);
            SplashScreenManager.CloseForm();
        }

        private void tlsHome_Click(object sender, EventArgs e)
        {
            ChangeModuleTo<Home>();
        }

        private void tlsSettings_Click(object sender, EventArgs e)
        {
            ChangeModuleTo<SettingsModule>();
        }

        private void tlsAbout_Click(object sender, EventArgs e)
        {
            ChangeModuleTo<AboutModule>();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var closeConfirm = XtraMessageBox.Show("Quit ???", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (closeConfirm == DialogResult.Cancel) e.Cancel = true;
            else
            {
                HomeStatic.Instance.KillProcessByName("BvSsh");
                HomeStatic.Instance.KillProcessByName("autocontrol");
            }

        }
    }
}
