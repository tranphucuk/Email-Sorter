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
using Email_Sorter_Tool.Static;
using System.IO;

namespace Email_Sorter_Tool.Settings
{
    public partial class SettingsModule : DevExpress.XtraEditors.XtraUserControl
    {
        public SettingsModule()
        {
            InitializeComponent();
            SettingStatic.Instance.CheckFolderAndFileIfNotExist();
            gridControl1.DataSource = SettingStatic.Instance.LoadSshFromFileSource();
            lblTotalSsh.Text = $"Total: {gridView1.RowCount.ToString()} SSH";
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {
                case "add":
                    LoadListSshToGridview();
                    break;
                case "remove":
                    RemoveSelectedSsh();
                    break;
                default:
                    break;
            }
        }

        private void RemoveSelectedSsh()
        {
            var tempSshCount = gridView1.RowCount;
            var removeConfirm = XtraMessageBox.Show($"Delete {gridView1.SelectedRowsCount} SSH ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (removeConfirm == DialogResult.Cancel) return;
            while (gridView1.RowCount == tempSshCount)
            {
                try { gridView1.DeleteSelectedRows(); }
                catch { }
            }
            var listSshRemain = gridView1.DataSource as List<SshDetail>;
            SettingStatic.Instance.SaveSshToFile(listSshRemain);
            XtraMessageBox.Show($"Delete Success !\nSSH remaining: {gridView1.RowCount.ToString()} SSH", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTotalSsh.Text = $"Total: {gridView1.RowCount.ToString()} SSH";

            gridControl1.RefreshDataSource();
        }

        private void LoadListSshToGridview()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "SSH File|*.txt";
            ofd.Title = "SSH File";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                gridControl1.DataSource = SettingStatic.Instance.LoadSshFromFileSelectedAndSave(ofd.FileName);
                lblTotalSsh.Text = $"Total: {gridView1.RowCount.ToString()} SSH";
            }
        }

        private void SettingsModule_Load(object sender, EventArgs e)
        {
        }
    }
}
