namespace Email_Sorter_Tool.HomeModule
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bstRunning = new DevExpress.XtraBars.BarStaticItem();
            this.bstElapsedTime = new DevExpress.XtraBars.BarStaticItem();
            this.bstStatusUpdate = new DevExpress.XtraBars.BarStaticItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiLoadEmail = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbiStart = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbiPause = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbiStop = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lblSettings = new DevExpress.XtraEditors.LabelControl();
            this.seThread = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.teErrorEmails = new DevExpress.XtraEditors.TextEdit();
            this.teSshUsed = new DevExpress.XtraEditors.TextEdit();
            this.teSshCount = new DevExpress.XtraEditors.TextEdit();
            this.teSavedEmail = new DevExpress.XtraEditors.TextEdit();
            this.teQueueMail = new DevExpress.XtraEditors.TextEdit();
            this.teLoadedMail = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trmRunTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seThread.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teErrorEmails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSshUsed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSshCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSavedEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQueueMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLoadedMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bstRunning,
            this.bstElapsedTime,
            this.barLargeButtonItem1,
            this.bbiLoadEmail,
            this.bbiStart,
            this.bbiPause,
            this.bbiStop,
            this.bstStatusUpdate});
            this.barManager1.MaxItemId = 18;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bstRunning, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bstElapsedTime, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bstStatusUpdate)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bstRunning
            // 
            this.bstRunning.Caption = "Ready...";
            this.bstRunning.Id = 0;
            this.bstRunning.ImageOptions.Image = global::Email_Sorter_Tool.Properties.Resources.loading;
            this.bstRunning.Name = "bstRunning";
            // 
            // bstElapsedTime
            // 
            this.bstElapsedTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bstElapsedTime.Caption = "00:00:00";
            this.bstElapsedTime.Id = 1;
            this.bstElapsedTime.ImageOptions.Image = global::Email_Sorter_Tool.Properties.Resources.alarm_clock__2_;
            this.bstElapsedTime.Name = "bstElapsedTime";
            this.bstElapsedTime.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bstElapsedTime_ItemClick);
            // 
            // bstStatusUpdate
            // 
            this.bstStatusUpdate.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.bstStatusUpdate.Id = 17;
            this.bstStatusUpdate.Name = "bstStatusUpdate";
            this.bstStatusUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 4";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiLoadEmail),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStart),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiPause, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStop)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 4";
            // 
            // bbiLoadEmail
            // 
            this.bbiLoadEmail.Caption = "Load E-mail";
            this.bbiLoadEmail.Id = 7;
            this.bbiLoadEmail.ImageOptions.Image = global::Email_Sorter_Tool.Properties.Resources.plus_sign_in_a_black_circle1;
            this.bbiLoadEmail.Name = "bbiLoadEmail";
            this.bbiLoadEmail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiLoadEmail_ItemClick);
            // 
            // bbiStart
            // 
            this.bbiStart.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiStart.Caption = "Start";
            this.bbiStart.Id = 8;
            this.bbiStart.ImageOptions.Image = global::Email_Sorter_Tool.Properties.Resources.play_button;
            this.bbiStart.Name = "bbiStart";
            this.bbiStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiStart_ItemClick);
            // 
            // bbiPause
            // 
            this.bbiPause.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiPause.Caption = "Pause";
            this.bbiPause.Id = 9;
            this.bbiPause.ImageOptions.Image = global::Email_Sorter_Tool.Properties.Resources.pause_button;
            this.bbiPause.Name = "bbiPause";
            this.bbiPause.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPause_ItemClick);
            // 
            // bbiStop
            // 
            this.bbiStop.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiStop.Caption = "Stop";
            this.bbiStop.Id = 10;
            this.bbiStop.ImageOptions.Image = global::Email_Sorter_Tool.Properties.Resources.stop;
            this.bbiStop.Name = "bbiStop";
            this.bbiStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiStop_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(667, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 392);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(667, 35);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 333);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(667, 59);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 333);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "barLargeButtonItem1";
            this.barLargeButtonItem1.Id = 2;
            this.barLargeButtonItem1.ImageOptions.Image = global::Email_Sorter_Tool.Properties.Resources.play_button;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Location = new System.Drawing.Point(215, 71);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(440, 292);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showListToolStripMenuItem,
            this.openFileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 56);
            // 
            // showListToolStripMenuItem
            // 
            this.showListToolStripMenuItem.Image = global::Email_Sorter_Tool.Properties.Resources.preview;
            this.showListToolStripMenuItem.Name = "showListToolStripMenuItem";
            this.showListToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.showListToolStripMenuItem.Text = "Show List View";
            this.showListToolStripMenuItem.Click += new System.EventHandler(this.showListToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = global::Email_Sorter_Tool.Properties.Resources.list;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lblSettings);
            this.layoutControl1.Controls.Add(this.seThread);
            this.layoutControl1.Location = new System.Drawing.Point(-3, 59);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(218, 63);
            this.layoutControl1.TabIndex = 13;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lblSettings
            // 
            this.lblSettings.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Appearance.Image = global::Email_Sorter_Tool.Properties.Resources.settings__2_;
            this.lblSettings.Appearance.Options.UseFont = true;
            this.lblSettings.Appearance.Options.UseImage = true;
            this.lblSettings.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSettings.Location = new System.Drawing.Point(178, 16);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(24, 24);
            this.lblSettings.StyleController = this.layoutControl1;
            this.lblSettings.TabIndex = 5;
            this.lblSettings.Click += new System.EventHandler(this.lblSettings_Click);
            // 
            // seThread
            // 
            this.seThread.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seThread.Location = new System.Drawing.Point(67, 16);
            this.seThread.MenuManager = this.barManager1;
            this.seThread.Name = "seThread";
            this.seThread.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seThread.Properties.Appearance.Options.UseFont = true;
            this.seThread.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seThread.Properties.Mask.EditMask = "n0";
            this.seThread.Properties.MaxValue = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.seThread.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seThread.Size = new System.Drawing.Size(105, 24);
            this.seThread.StyleController = this.layoutControl1;
            this.seThread.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem8});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(218, 63);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.seThread;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(162, 37);
            this.layoutControlItem1.Text = "Thread";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(47, 18);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.lblSettings;
            this.layoutControlItem8.Location = new System.Drawing.Point(162, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(30, 37);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.teErrorEmails);
            this.layoutControl2.Controls.Add(this.teSshUsed);
            this.layoutControl2.Controls.Add(this.teSshCount);
            this.layoutControl2.Controls.Add(this.teSavedEmail);
            this.layoutControl2.Controls.Add(this.teQueueMail);
            this.layoutControl2.Controls.Add(this.teLoadedMail);
            this.layoutControl2.Location = new System.Drawing.Point(6, 12);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(181, 206);
            this.layoutControl2.TabIndex = 14;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // teErrorEmails
            // 
            this.teErrorEmails.EditValue = "0";
            this.teErrorEmails.Location = new System.Drawing.Point(82, 106);
            this.teErrorEmails.MenuManager = this.barManager1;
            this.teErrorEmails.Name = "teErrorEmails";
            this.teErrorEmails.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.teErrorEmails.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teErrorEmails.Properties.Appearance.Options.UseBackColor = true;
            this.teErrorEmails.Properties.Appearance.Options.UseFont = true;
            this.teErrorEmails.Properties.ReadOnly = true;
            this.teErrorEmails.Size = new System.Drawing.Size(83, 24);
            this.teErrorEmails.StyleController = this.layoutControl2;
            this.teErrorEmails.TabIndex = 9;
            // 
            // teSshUsed
            // 
            this.teSshUsed.EditValue = "0";
            this.teSshUsed.Location = new System.Drawing.Point(82, 166);
            this.teSshUsed.MenuManager = this.barManager1;
            this.teSshUsed.Name = "teSshUsed";
            this.teSshUsed.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.teSshUsed.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teSshUsed.Properties.Appearance.Options.UseBackColor = true;
            this.teSshUsed.Properties.Appearance.Options.UseFont = true;
            this.teSshUsed.Properties.ReadOnly = true;
            this.teSshUsed.Size = new System.Drawing.Size(83, 24);
            this.teSshUsed.StyleController = this.layoutControl2;
            this.teSshUsed.TabIndex = 8;
            // 
            // teSshCount
            // 
            this.teSshCount.EditValue = "0";
            this.teSshCount.Location = new System.Drawing.Point(82, 136);
            this.teSshCount.MenuManager = this.barManager1;
            this.teSshCount.Name = "teSshCount";
            this.teSshCount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.teSshCount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teSshCount.Properties.Appearance.Options.UseBackColor = true;
            this.teSshCount.Properties.Appearance.Options.UseFont = true;
            this.teSshCount.Properties.ReadOnly = true;
            this.teSshCount.Size = new System.Drawing.Size(83, 24);
            this.teSshCount.StyleController = this.layoutControl2;
            this.teSshCount.TabIndex = 7;
            // 
            // teSavedEmail
            // 
            this.teSavedEmail.EditValue = "0";
            this.teSavedEmail.Location = new System.Drawing.Point(82, 76);
            this.teSavedEmail.MenuManager = this.barManager1;
            this.teSavedEmail.Name = "teSavedEmail";
            this.teSavedEmail.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.teSavedEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teSavedEmail.Properties.Appearance.Options.UseBackColor = true;
            this.teSavedEmail.Properties.Appearance.Options.UseFont = true;
            this.teSavedEmail.Properties.ReadOnly = true;
            this.teSavedEmail.Size = new System.Drawing.Size(83, 24);
            this.teSavedEmail.StyleController = this.layoutControl2;
            this.teSavedEmail.TabIndex = 6;
            // 
            // teQueueMail
            // 
            this.teQueueMail.EditValue = "0";
            this.teQueueMail.Location = new System.Drawing.Point(82, 46);
            this.teQueueMail.MenuManager = this.barManager1;
            this.teQueueMail.Name = "teQueueMail";
            this.teQueueMail.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.teQueueMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teQueueMail.Properties.Appearance.Options.UseBackColor = true;
            this.teQueueMail.Properties.Appearance.Options.UseFont = true;
            this.teQueueMail.Properties.ReadOnly = true;
            this.teQueueMail.Size = new System.Drawing.Size(83, 24);
            this.teQueueMail.StyleController = this.layoutControl2;
            this.teQueueMail.TabIndex = 5;
            // 
            // teLoadedMail
            // 
            this.teLoadedMail.EditValue = "0";
            this.teLoadedMail.Location = new System.Drawing.Point(82, 16);
            this.teLoadedMail.MenuManager = this.barManager1;
            this.teLoadedMail.Name = "teLoadedMail";
            this.teLoadedMail.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.teLoadedMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teLoadedMail.Properties.Appearance.Options.UseBackColor = true;
            this.teLoadedMail.Properties.Appearance.Options.UseFont = true;
            this.teLoadedMail.Properties.ReadOnly = true;
            this.teLoadedMail.Size = new System.Drawing.Size(83, 24);
            this.teLoadedMail.StyleController = this.layoutControl2;
            this.teLoadedMail.TabIndex = 4;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(181, 206);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.teLoadedMail;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(155, 30);
            this.layoutControlItem2.Text = "Loaded:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(62, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.teQueueMail;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(155, 30);
            this.layoutControlItem3.Text = "Cached:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(62, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.teSavedEmail;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(155, 30);
            this.layoutControlItem4.Text = "Saved:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(62, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.teSshCount;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(155, 30);
            this.layoutControlItem5.Text = "IP Count:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(62, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.teSshUsed;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 150);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(155, 30);
            this.layoutControlItem6.Text = "IP Used:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(62, 18);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.teErrorEmails;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(155, 30);
            this.layoutControlItem7.Text = "Error:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(62, 18);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl2);
            this.groupBox1.Location = new System.Drawing.Point(9, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 223);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // trmRunTime
            // 
            this.trmRunTime.Interval = 1000;
            this.trmRunTime.Tick += new System.EventHandler(this.trmRunTime_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(667, 427);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seThread.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teErrorEmails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSshUsed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSshCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSavedEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQueueMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLoadedMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem bstRunning;
        private DevExpress.XtraBars.BarStaticItem bstElapsedTime;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem bbiLoadEmail;
        private DevExpress.XtraBars.BarLargeButtonItem bbiStart;
        private DevExpress.XtraBars.BarLargeButtonItem bbiPause;
        private DevExpress.XtraBars.BarLargeButtonItem bbiStop;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SpinEdit seThread;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit teSshUsed;
        private DevExpress.XtraEditors.TextEdit teSshCount;
        private DevExpress.XtraEditors.TextEdit teSavedEmail;
        private DevExpress.XtraEditors.TextEdit teQueueMail;
        private DevExpress.XtraEditors.TextEdit teLoadedMail;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit teErrorEmails;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LabelControl lblSettings;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Timer trmRunTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private DevExpress.XtraBars.BarStaticItem bstStatusUpdate;
    }
}
