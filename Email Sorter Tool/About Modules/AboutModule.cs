using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace Email_Sorter_Tool.About_Modules
{
    public partial class AboutModule : DevExpress.XtraEditors.XtraUserControl
    {
        public AboutModule()
        {
            InitializeComponent();
            DisplayFileInfo();
        }

        private readonly string saveFolder = Application.StartupPath + "\\Save\\";
        private readonly string sshFolder = Application.StartupPath + "\\SshFolder\\";
        private void DisplayFileInfo()
        {
            teEmailSaveFolder.Text = saveFolder;
            teSshFolder.Text = sshFolder;
        }

        private void sbOpenFolderSsh_Click(object sender, EventArgs e)
        {
            Process.Start(sshFolder);
        }

        private void sbOpenEmailFolder_Click(object sender, EventArgs e)
        {
            Process.Start(saveFolder);
        }

        private void hplFileRequired_Click(object sender, EventArgs e)
        {
            Process.Start(hplFileRequired.Text);
        }
    }
}
