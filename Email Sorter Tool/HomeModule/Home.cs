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
using System.IO;
using Email_Sorter_Tool.Static;
using Email_Sorter_Tool.HomeModule.Sub_Settings;
using Email_Sorter_Tool.HomeModule.Context_Menu_Strip;
using System.Diagnostics;
using System.Threading;

namespace Email_Sorter_Tool.HomeModule
{
    public partial class Home : DevExpress.XtraEditors.XtraUserControl
    {
        public SortEmailAsync sortEmail = new SortEmailAsync();
        FrmSettings frm = new FrmSettings();
        private List<string> emails;
        public Home()
        {
            InitializeComponent();
            LoadDefaultInfo();
            frm.EmailChecked += Frm_EmailChecked;
            sortEmail.UpdateStatus += SortEmail_UpdateStatus;
            sortEmail.EmailsQueue += SortEmail_EmailsQueue;
            sortEmail.EmailSaved += SortEmail_EmailSaved;
            sortEmail.ErrorEmail += SortEmail_ErrorEmail;
            sortEmail.SshUsed += SortEmail_SshUsed;
            sortEmail.StatusEvent += SortEmail_StatusEvent;
        }

        private void SortEmail_StatusEvent(object sender, EventArgs.StatusUpdateEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                bstStatusUpdate.Caption = e.Status;
            }));
        }

        private void SortEmail_ErrorEmail(object sender, EventArgs.ErrorEmailEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                teErrorEmails.Text = e.ErrorEmail.ToString();
            }));
        }

        private void SortEmail_SshUsed(object sender, EventArgs.TotalSshUsedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                teSshUsed.Text = e.TotalSshUsed.ToString();
            }));
        }

        private void SortEmail_EmailSaved(object sender, EventArgs.EmailSavedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                teSavedEmail.Text = e.TotalEmailSaved.ToString();
            }));
        }

        private void SortEmail_EmailsQueue(object sender, EventArgs.EmailQueueEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                teQueueMail.Text = e.EmailQueue.ToString();
            }));
        }

        private void Frm_EmailChecked(object sender, EmailDetailsEventArg e)
        {
            var tasks = gridControl1.DataSource as List<EmailDetails>;
            tasks.Clear();
            foreach (var item in e.EmailChecked)
            {
                tasks.Add(new EmailDetails()
                {
                    EmailType = item.EmailType,
                    ResultCount = item.ResultCount,
                    Percentage = item.Percentage,
                    FileName = item.FileName,
                });
            }
            gridControl1.RefreshDataSource();
        }

        private void SortEmail_UpdateStatus(object sender, StatusUpdateEventArg e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                var tasks = gridControl1.DataSource as List<EmailDetails>;
                var targetTask = tasks.FirstOrDefault(t => t.EmailType == e.Status.EmailType);
                if (targetTask != null)
                {
                    targetTask.EmailType = e.Status.EmailType;
                    targetTask.FileName = e.Status.FileName;
                    targetTask.Percentage = e.Status.Percentage;
                    targetTask.ResultCount = e.Status.ResultCount;
                }
                gridControl1.RefreshDataSource();
            }));
        }

        private void LoadDefaultInfo()
        {
            gridControl1.DataSource = HomeStatic.Instance.DefaultEmailInfo();
            gridView1.Columns["IsSaved"].Visible = false;
            gridView1.Columns[1].Width = 55;
            gridView1.Columns[1].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[1].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;

            gridView1.Columns[2].Width = 40;
            gridView1.Columns[2].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns[2].AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            teSshCount.Text = SettingStatic.Instance.LoadSshFromFileSource().Count.ToString();
        }

        private void bbiLoadEmail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "File E-Mail";
            ofd.Filter = "File E-Mail|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                emails = new List<string>();
                var lines = File.ReadAllLines(ofd.FileName);
                var emailCount = lines.Length;
                teLoadedMail.Text = emailCount.ToString();
                emails = lines.ToList();
            }
        }

        private void lblSettings_Click(object sender, System.EventArgs e)
        {
            frm.ShowDialog();
        }

        private async void bbiStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (teLoadedMail.Text == "0") { XtraMessageBox.Show("Emails are Empty.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            DisableFunctions();
            await sortEmail.SortAsync(new ScanInfo()
            {
                Emails = emails,
                Thread = Convert.ToInt32(seThread.Value),
            });
            EnableFunctions();
            XtraMessageBox.Show("DONE !!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EnableFunctions()
        {
            trmRunTime.Stop();
            bstRunning.Caption = "Stopped...";
            bbiStart.Enabled = bbiLoadEmail.Enabled = true;
            (this.FindForm() as Form1).tlsHome.Enabled = true;
            (this.FindForm() as Form1).tlsSettings.Enabled = true;
            (this.FindForm() as Form1).tlsAbout.Enabled = true;
        }

        private void DisableFunctions()
        {
            trmRunTime.Start();
            lockTaken = false;
            bbiStart.Enabled = bbiLoadEmail.Enabled = false;
            (this.FindForm() as Form1).tlsHome.Enabled = false;
            (this.FindForm() as Form1).tlsSettings.Enabled = false;
            (this.FindForm() as Form1).tlsAbout.Enabled = false;
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show();
            }
        }

        private void showListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var rowSelected = gridView1.GetFocusedRow() as EmailDetails;
            if (!File.Exists(HomeStatic.saveFolderPath + rowSelected.FileName)) { XtraMessageBox.Show("Empty Results", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            var gridViewResults = new FrmShowResults(rowSelected.FileName);
            gridViewResults.Show();
        }

        private void openFileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var rowSelected = gridView1.GetFocusedRow() as EmailDetails;
            if (File.Exists(HomeStatic.saveFolderPath + rowSelected.FileName)) { Process.Start(HomeStatic.saveFolderPath + rowSelected.FileName); }
            else { XtraMessageBox.Show("Not Found.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bbiPause_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sortEmail.isPaused = !sortEmail.isPaused;
        }

        private void bbiStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sortEmail.StopScan();
            lockTaken = true;
        }

        private int ElapsedTime;
        public object o = new object();
        public bool lockTaken = false;
        private void trmRunTime_Tick(object sender, System.EventArgs e)
        {
            new Thread(() =>
            {
                while (true) { lock (o) { if (lockTaken) { break; } HomeStatic.Instance.ChangeImages(bstRunning); } }
            })
            { IsBackground = true }.Start();
            ElapsedTime++;
            var timeToDisplay = TimeSpan.FromSeconds(ElapsedTime).ToString("hh\\:mm\\:ss");
            bstElapsedTime.Caption = timeToDisplay;
        }

        private void bstElapsedTime_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
