namespace TestCaseComplete
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSM_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSM_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedOutItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_AdminTools = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Project = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_ProjectCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_ProjectEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Builds = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_BuildCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_BuildEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_TestCase = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_TestCaseCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_TestCaseEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.buildAssignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_ConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tv_ProjectBuild = new System.Windows.Forms.TreeView();
            this.sc_TestCases = new System.Windows.Forms.SplitContainer();
            this.lsv_TestCaseWindow = new System.Windows.Forms.ListView();
            this.ch_priority = new System.Windows.Forms.ColumnHeader();
            this.ch_shortDescription = new System.Windows.Forms.ColumnHeader();
            this.ch_totalRunTime = new System.Windows.Forms.ColumnHeader();
            this.ch_BugID = new System.Windows.Forms.ColumnHeader();
            this.ch_CheckedOut = new System.Windows.Forms.ColumnHeader();
            this.ch_UpdatedBy = new System.Windows.Forms.ColumnHeader();
            this.ch_UpdateTime = new System.Windows.Forms.ColumnHeader();
            this.ch_UpdateNotes = new System.Windows.Forms.ColumnHeader();
            this.ch_status = new System.Windows.Forms.ColumnHeader();
            this.pnl_results = new System.Windows.Forms.Panel();
            this.rtb_StatusCriteria = new System.Windows.Forms.RichTextBox();
            this.txt_TotalEstTime = new System.Windows.Forms.TextBox();
            this.lbl_TotalEstTime = new System.Windows.Forms.Label();
            this.lbl_RunTime = new System.Windows.Forms.Label();
            this.lbl_CleanupTime = new System.Windows.Forms.Label();
            this.lbl_SetupTime = new System.Windows.Forms.Label();
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.txt_BugzillaID = new System.Windows.Forms.TextBox();
            this.mtb_SetupTime = new System.Windows.Forms.MaskedTextBox();
            this.mtb_RunTime = new System.Windows.Forms.MaskedTextBox();
            this.mtb_CleanupTime = new System.Windows.Forms.MaskedTextBox();
            this.rtb_CleanupInstructions = new System.Windows.Forms.RichTextBox();
            this.rtb_RunInstructions = new System.Windows.Forms.RichTextBox();
            this.rtb_SetupInstructions = new System.Windows.Forms.RichTextBox();
            this.lbl_SetupInstructions = new System.Windows.Forms.Label();
            this.lbl_Run = new System.Windows.Forms.Label();
            this.lbl_Cleanup = new System.Windows.Forms.Label();
            this.lbl_BugzillaID = new System.Windows.Forms.Label();
            this.lbl_TCStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.sc_TestCases.Panel1.SuspendLayout();
            this.sc_TestCases.Panel2.SuspendLayout();
            this.sc_TestCases.SuspendLayout();
            this.pnl_results.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_File,
            this.userToolsToolStripMenuItem,
            this.TSM_AdminTools,
            this.TSM_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1057, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSM_File
            // 
            this.TSM_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.TSM_Logout});
            this.TSM_File.Name = "TSM_File";
            this.TSM_File.Size = new System.Drawing.Size(35, 20);
            this.TSM_File.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // TSM_Logout
            // 
            this.TSM_Logout.Name = "TSM_Logout";
            this.TSM_Logout.Size = new System.Drawing.Size(118, 22);
            this.TSM_Logout.Text = "L&ogout";
            this.TSM_Logout.Click += new System.EventHandler(this.TSM_Logout_Click);
            // 
            // userToolsToolStripMenuItem
            // 
            this.userToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkedOutItemsToolStripMenuItem});
            this.userToolsToolStripMenuItem.Name = "userToolsToolStripMenuItem";
            this.userToolsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.userToolsToolStripMenuItem.Text = "User Tools";
            // 
            // checkedOutItemsToolStripMenuItem
            // 
            this.checkedOutItemsToolStripMenuItem.Name = "checkedOutItemsToolStripMenuItem";
            this.checkedOutItemsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.checkedOutItemsToolStripMenuItem.Text = "Checked Out Items";
            this.checkedOutItemsToolStripMenuItem.Click += new System.EventHandler(this.checkedOutItemsToolStripMenuItem_Click);
            // 
            // TSM_AdminTools
            // 
            this.TSM_AdminTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Project,
            this.TSM_Builds,
            this.TSM_TestCase,
            this.historyToolStripMenuItem});
            this.TSM_AdminTools.Name = "TSM_AdminTools";
            this.TSM_AdminTools.Size = new System.Drawing.Size(76, 20);
            this.TSM_AdminTools.Text = "Admin Tools";
            // 
            // TSM_Project
            // 
            this.TSM_Project.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_ProjectCreate,
            this.TSM_ProjectEdit});
            this.TSM_Project.Name = "TSM_Project";
            this.TSM_Project.Size = new System.Drawing.Size(154, 22);
            this.TSM_Project.Text = "Project";
            // 
            // TSM_ProjectCreate
            // 
            this.TSM_ProjectCreate.Name = "TSM_ProjectCreate";
            this.TSM_ProjectCreate.Size = new System.Drawing.Size(118, 22);
            this.TSM_ProjectCreate.Text = "Create";
            this.TSM_ProjectCreate.Click += new System.EventHandler(this.TSM_ProjectCreate_Click);
            // 
            // TSM_ProjectEdit
            // 
            this.TSM_ProjectEdit.Name = "TSM_ProjectEdit";
            this.TSM_ProjectEdit.Size = new System.Drawing.Size(118, 22);
            this.TSM_ProjectEdit.Text = "Edit";
            this.TSM_ProjectEdit.Click += new System.EventHandler(this.TSM_ProjectEdit_Click);
            // 
            // TSM_Builds
            // 
            this.TSM_Builds.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_BuildCreate,
            this.TSM_BuildEdit});
            this.TSM_Builds.Name = "TSM_Builds";
            this.TSM_Builds.Size = new System.Drawing.Size(154, 22);
            this.TSM_Builds.Text = "Builds";
            // 
            // TSM_BuildCreate
            // 
            this.TSM_BuildCreate.Name = "TSM_BuildCreate";
            this.TSM_BuildCreate.Size = new System.Drawing.Size(118, 22);
            this.TSM_BuildCreate.Text = "Create";
            this.TSM_BuildCreate.Click += new System.EventHandler(this.TSM_BuildCreate_Click);
            // 
            // TSM_BuildEdit
            // 
            this.TSM_BuildEdit.Name = "TSM_BuildEdit";
            this.TSM_BuildEdit.Size = new System.Drawing.Size(118, 22);
            this.TSM_BuildEdit.Text = "Edit";
            this.TSM_BuildEdit.Click += new System.EventHandler(this.TSM_BuildEdit_Click);
            // 
            // TSM_TestCase
            // 
            this.TSM_TestCase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_TestCaseCreate,
            this.TSM_TestCaseEdit,
            this.buildAssignerToolStripMenuItem});
            this.TSM_TestCase.Name = "TSM_TestCase";
            this.TSM_TestCase.Size = new System.Drawing.Size(154, 22);
            this.TSM_TestCase.Text = "Test Case";
            // 
            // TSM_TestCaseCreate
            // 
            this.TSM_TestCaseCreate.Name = "TSM_TestCaseCreate";
            this.TSM_TestCaseCreate.Size = new System.Drawing.Size(151, 22);
            this.TSM_TestCaseCreate.Text = "Create";
            this.TSM_TestCaseCreate.Click += new System.EventHandler(this.TSM_TestCaseCreate_Click);
            // 
            // TSM_TestCaseEdit
            // 
            this.TSM_TestCaseEdit.Name = "TSM_TestCaseEdit";
            this.TSM_TestCaseEdit.Size = new System.Drawing.Size(151, 22);
            this.TSM_TestCaseEdit.Text = "Edit";
            this.TSM_TestCaseEdit.Click += new System.EventHandler(this.TSM_TestCaseEdit_Click);
            // 
            // buildAssignerToolStripMenuItem
            // 
            this.buildAssignerToolStripMenuItem.Name = "buildAssignerToolStripMenuItem";
            this.buildAssignerToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.buildAssignerToolStripMenuItem.Text = "Build Assigner";
            this.buildAssignerToolStripMenuItem.Click += new System.EventHandler(this.buildAssignerToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.historyToolStripMenuItem.Text = "History Viewer";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // TSM_Help
            // 
            this.TSM_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_About});
            this.TSM_Help.Name = "TSM_Help";
            this.TSM_Help.Size = new System.Drawing.Size(40, 20);
            this.TSM_Help.Text = "He&lp";
            // 
            // TSM_About
            // 
            this.TSM_About.Name = "TSM_About";
            this.TSM_About.Size = new System.Drawing.Size(114, 22);
            this.TSM_About.Text = "A&bout";
            this.TSM_About.Click += new System.EventHandler(this.TSM_About_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_ConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1057, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_ConnectionStatus
            // 
            this.TSSL_ConnectionStatus.Name = "TSSL_ConnectionStatus";
            this.TSSL_ConnectionStatus.Size = new System.Drawing.Size(71, 17);
            this.TSSL_ConnectionStatus.Text = "Disconnected";
            // 
            // tv_ProjectBuild
            // 
            this.tv_ProjectBuild.Dock = System.Windows.Forms.DockStyle.Left;
            this.tv_ProjectBuild.Location = new System.Drawing.Point(0, 24);
            this.tv_ProjectBuild.Name = "tv_ProjectBuild";
            this.tv_ProjectBuild.ShowNodeToolTips = true;
            this.tv_ProjectBuild.Size = new System.Drawing.Size(174, 616);
            this.tv_ProjectBuild.TabIndex = 0;
            this.tv_ProjectBuild.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_ProjectBuild_AfterSelect);
            // 
            // sc_TestCases
            // 
            this.sc_TestCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_TestCases.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.sc_TestCases.IsSplitterFixed = true;
            this.sc_TestCases.Location = new System.Drawing.Point(174, 24);
            this.sc_TestCases.Name = "sc_TestCases";
            this.sc_TestCases.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_TestCases.Panel1
            // 
            this.sc_TestCases.Panel1.Controls.Add(this.lsv_TestCaseWindow);
            // 
            // sc_TestCases.Panel2
            // 
            this.sc_TestCases.Panel2.Controls.Add(this.pnl_results);
            this.sc_TestCases.Size = new System.Drawing.Size(883, 616);
            this.sc_TestCases.SplitterDistance = 348;
            this.sc_TestCases.TabIndex = 8;
            // 
            // lsv_TestCaseWindow
            // 
            this.lsv_TestCaseWindow.AllowColumnReorder = true;
            this.lsv_TestCaseWindow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_priority,
            this.ch_shortDescription,
            this.ch_totalRunTime,
            this.ch_BugID,
            this.ch_CheckedOut,
            this.ch_UpdatedBy,
            this.ch_UpdateTime,
            this.ch_UpdateNotes,
            this.ch_status});
            this.lsv_TestCaseWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_TestCaseWindow.FullRowSelect = true;
            this.lsv_TestCaseWindow.GridLines = true;
            this.lsv_TestCaseWindow.Location = new System.Drawing.Point(0, 0);
            this.lsv_TestCaseWindow.MultiSelect = false;
            this.lsv_TestCaseWindow.Name = "lsv_TestCaseWindow";
            this.lsv_TestCaseWindow.ShowItemToolTips = true;
            this.lsv_TestCaseWindow.Size = new System.Drawing.Size(883, 348);
            this.lsv_TestCaseWindow.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsv_TestCaseWindow.TabIndex = 0;
            this.lsv_TestCaseWindow.UseCompatibleStateImageBehavior = false;
            this.lsv_TestCaseWindow.View = System.Windows.Forms.View.Details;
            this.lsv_TestCaseWindow.SelectedIndexChanged += new System.EventHandler(this.lsv_TestCaseWindow_SelectedIndexChanged);
            // 
            // ch_priority
            // 
            this.ch_priority.Text = "Priority";
            this.ch_priority.Width = 47;
            // 
            // ch_shortDescription
            // 
            this.ch_shortDescription.Text = "Short Description";
            this.ch_shortDescription.Width = 141;
            // 
            // ch_totalRunTime
            // 
            this.ch_totalRunTime.Text = "Total Run Time";
            this.ch_totalRunTime.Width = 88;
            // 
            // ch_BugID
            // 
            this.ch_BugID.Text = "Defect ID";
            this.ch_BugID.Width = 69;
            // 
            // ch_CheckedOut
            // 
            this.ch_CheckedOut.Text = "Check Out By";
            this.ch_CheckedOut.Width = 81;
            // 
            // ch_UpdatedBy
            // 
            this.ch_UpdatedBy.Text = "Updated By";
            this.ch_UpdatedBy.Width = 71;
            // 
            // ch_UpdateTime
            // 
            this.ch_UpdateTime.Text = "Updated Time";
            this.ch_UpdateTime.Width = 88;
            // 
            // ch_UpdateNotes
            // 
            this.ch_UpdateNotes.Text = "Update Notes";
            this.ch_UpdateNotes.Width = 231;
            // 
            // ch_status
            // 
            this.ch_status.Text = "Status";
            // 
            // pnl_results
            // 
            this.pnl_results.Controls.Add(this.rtb_StatusCriteria);
            this.pnl_results.Controls.Add(this.txt_TotalEstTime);
            this.pnl_results.Controls.Add(this.lbl_TotalEstTime);
            this.pnl_results.Controls.Add(this.lbl_RunTime);
            this.pnl_results.Controls.Add(this.lbl_CleanupTime);
            this.pnl_results.Controls.Add(this.lbl_SetupTime);
            this.pnl_results.Controls.Add(this.lbl_Instructions);
            this.pnl_results.Controls.Add(this.btn_CheckOut);
            this.pnl_results.Controls.Add(this.txt_BugzillaID);
            this.pnl_results.Controls.Add(this.mtb_SetupTime);
            this.pnl_results.Controls.Add(this.mtb_RunTime);
            this.pnl_results.Controls.Add(this.mtb_CleanupTime);
            this.pnl_results.Controls.Add(this.rtb_CleanupInstructions);
            this.pnl_results.Controls.Add(this.rtb_RunInstructions);
            this.pnl_results.Controls.Add(this.rtb_SetupInstructions);
            this.pnl_results.Controls.Add(this.lbl_SetupInstructions);
            this.pnl_results.Controls.Add(this.lbl_Run);
            this.pnl_results.Controls.Add(this.lbl_Cleanup);
            this.pnl_results.Controls.Add(this.lbl_BugzillaID);
            this.pnl_results.Controls.Add(this.lbl_TCStatus);
            this.pnl_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_results.Location = new System.Drawing.Point(0, 0);
            this.pnl_results.Name = "pnl_results";
            this.pnl_results.Size = new System.Drawing.Size(883, 264);
            this.pnl_results.TabIndex = 0;
            // 
            // rtb_StatusCriteria
            // 
            this.rtb_StatusCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_StatusCriteria.Location = new System.Drawing.Point(696, 32);
            this.rtb_StatusCriteria.Name = "rtb_StatusCriteria";
            this.rtb_StatusCriteria.ReadOnly = true;
            this.rtb_StatusCriteria.Size = new System.Drawing.Size(175, 138);
            this.rtb_StatusCriteria.TabIndex = 3;
            this.rtb_StatusCriteria.Text = "";
            // 
            // txt_TotalEstTime
            // 
            this.txt_TotalEstTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TotalEstTime.Location = new System.Drawing.Point(633, 202);
            this.txt_TotalEstTime.Name = "txt_TotalEstTime";
            this.txt_TotalEstTime.ReadOnly = true;
            this.txt_TotalEstTime.Size = new System.Drawing.Size(57, 20);
            this.txt_TotalEstTime.TabIndex = 7;
            // 
            // lbl_TotalEstTime
            // 
            this.lbl_TotalEstTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalEstTime.AutoSize = true;
            this.lbl_TotalEstTime.Location = new System.Drawing.Point(546, 205);
            this.lbl_TotalEstTime.Name = "lbl_TotalEstTime";
            this.lbl_TotalEstTime.Size = new System.Drawing.Size(81, 13);
            this.lbl_TotalEstTime.TabIndex = 57;
            this.lbl_TotalEstTime.Text = "Total Est. Time:";
            // 
            // lbl_RunTime
            // 
            this.lbl_RunTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_RunTime.AutoSize = true;
            this.lbl_RunTime.Location = new System.Drawing.Point(365, 179);
            this.lbl_RunTime.Name = "lbl_RunTime";
            this.lbl_RunTime.Size = new System.Drawing.Size(33, 13);
            this.lbl_RunTime.TabIndex = 56;
            this.lbl_RunTime.Text = "Time:";
            // 
            // lbl_CleanupTime
            // 
            this.lbl_CleanupTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CleanupTime.AutoSize = true;
            this.lbl_CleanupTime.Location = new System.Drawing.Point(594, 179);
            this.lbl_CleanupTime.Name = "lbl_CleanupTime";
            this.lbl_CleanupTime.Size = new System.Drawing.Size(33, 13);
            this.lbl_CleanupTime.TabIndex = 55;
            this.lbl_CleanupTime.Text = "Time:";
            // 
            // lbl_SetupTime
            // 
            this.lbl_SetupTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SetupTime.AutoSize = true;
            this.lbl_SetupTime.Location = new System.Drawing.Point(136, 179);
            this.lbl_SetupTime.Name = "lbl_SetupTime";
            this.lbl_SetupTime.Size = new System.Drawing.Size(33, 13);
            this.lbl_SetupTime.TabIndex = 54;
            this.lbl_SetupTime.Text = "Time:";
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.Location = new System.Drawing.Point(6, 3);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(64, 13);
            this.lbl_Instructions.TabIndex = 53;
            this.lbl_Instructions.Text = "Instructions:";
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CheckOut.Location = new System.Drawing.Point(796, 225);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(75, 23);
            this.btn_CheckOut.TabIndex = 9;
            this.btn_CheckOut.Text = "Check Out";
            this.btn_CheckOut.UseVisualStyleBackColor = true;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // txt_BugzillaID
            // 
            this.txt_BugzillaID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_BugzillaID.Location = new System.Drawing.Point(810, 176);
            this.txt_BugzillaID.Name = "txt_BugzillaID";
            this.txt_BugzillaID.ReadOnly = true;
            this.txt_BugzillaID.Size = new System.Drawing.Size(61, 20);
            this.txt_BugzillaID.TabIndex = 8;
            // 
            // mtb_SetupTime
            // 
            this.mtb_SetupTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mtb_SetupTime.Location = new System.Drawing.Point(175, 176);
            this.mtb_SetupTime.Name = "mtb_SetupTime";
            this.mtb_SetupTime.ReadOnly = true;
            this.mtb_SetupTime.Size = new System.Drawing.Size(57, 20);
            this.mtb_SetupTime.TabIndex = 4;
            // 
            // mtb_RunTime
            // 
            this.mtb_RunTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mtb_RunTime.Location = new System.Drawing.Point(404, 176);
            this.mtb_RunTime.Name = "mtb_RunTime";
            this.mtb_RunTime.ReadOnly = true;
            this.mtb_RunTime.Size = new System.Drawing.Size(57, 20);
            this.mtb_RunTime.TabIndex = 5;
            // 
            // mtb_CleanupTime
            // 
            this.mtb_CleanupTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mtb_CleanupTime.Location = new System.Drawing.Point(633, 176);
            this.mtb_CleanupTime.Name = "mtb_CleanupTime";
            this.mtb_CleanupTime.ReadOnly = true;
            this.mtb_CleanupTime.Size = new System.Drawing.Size(57, 20);
            this.mtb_CleanupTime.TabIndex = 6;
            // 
            // rtb_CleanupInstructions
            // 
            this.rtb_CleanupInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_CleanupInstructions.Location = new System.Drawing.Point(467, 31);
            this.rtb_CleanupInstructions.Name = "rtb_CleanupInstructions";
            this.rtb_CleanupInstructions.ReadOnly = true;
            this.rtb_CleanupInstructions.Size = new System.Drawing.Size(223, 139);
            this.rtb_CleanupInstructions.TabIndex = 2;
            this.rtb_CleanupInstructions.Text = "";
            // 
            // rtb_RunInstructions
            // 
            this.rtb_RunInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_RunInstructions.Location = new System.Drawing.Point(238, 32);
            this.rtb_RunInstructions.Name = "rtb_RunInstructions";
            this.rtb_RunInstructions.ReadOnly = true;
            this.rtb_RunInstructions.Size = new System.Drawing.Size(223, 138);
            this.rtb_RunInstructions.TabIndex = 1;
            this.rtb_RunInstructions.Text = "";
            // 
            // rtb_SetupInstructions
            // 
            this.rtb_SetupInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_SetupInstructions.Location = new System.Drawing.Point(9, 32);
            this.rtb_SetupInstructions.Name = "rtb_SetupInstructions";
            this.rtb_SetupInstructions.ReadOnly = true;
            this.rtb_SetupInstructions.Size = new System.Drawing.Size(223, 138);
            this.rtb_SetupInstructions.TabIndex = 0;
            this.rtb_SetupInstructions.Text = "";
            // 
            // lbl_SetupInstructions
            // 
            this.lbl_SetupInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SetupInstructions.AutoSize = true;
            this.lbl_SetupInstructions.Location = new System.Drawing.Point(6, 16);
            this.lbl_SetupInstructions.Name = "lbl_SetupInstructions";
            this.lbl_SetupInstructions.Size = new System.Drawing.Size(35, 13);
            this.lbl_SetupInstructions.TabIndex = 43;
            this.lbl_SetupInstructions.Text = "Setup";
            // 
            // lbl_Run
            // 
            this.lbl_Run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Run.AutoSize = true;
            this.lbl_Run.Location = new System.Drawing.Point(235, 16);
            this.lbl_Run.Name = "lbl_Run";
            this.lbl_Run.Size = new System.Drawing.Size(27, 13);
            this.lbl_Run.TabIndex = 40;
            this.lbl_Run.Text = "Run";
            // 
            // lbl_Cleanup
            // 
            this.lbl_Cleanup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Cleanup.AutoSize = true;
            this.lbl_Cleanup.Location = new System.Drawing.Point(464, 16);
            this.lbl_Cleanup.Name = "lbl_Cleanup";
            this.lbl_Cleanup.Size = new System.Drawing.Size(46, 13);
            this.lbl_Cleanup.TabIndex = 39;
            this.lbl_Cleanup.Text = "Cleanup";
            // 
            // lbl_BugzillaID
            // 
            this.lbl_BugzillaID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_BugzillaID.AutoSize = true;
            this.lbl_BugzillaID.Location = new System.Drawing.Point(744, 179);
            this.lbl_BugzillaID.Name = "lbl_BugzillaID";
            this.lbl_BugzillaID.Size = new System.Drawing.Size(60, 13);
            this.lbl_BugzillaID.TabIndex = 37;
            this.lbl_BugzillaID.Text = "Bugzilla ID:";
            // 
            // lbl_TCStatus
            // 
            this.lbl_TCStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_TCStatus.AutoSize = true;
            this.lbl_TCStatus.Location = new System.Drawing.Point(696, 16);
            this.lbl_TCStatus.Name = "lbl_TCStatus";
            this.lbl_TCStatus.Size = new System.Drawing.Size(40, 13);
            this.lbl_TCStatus.TabIndex = 35;
            this.lbl_TCStatus.Text = "Status:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 662);
            this.Controls.Add(this.sc_TestCases);
            this.Controls.Add(this.tv_ProjectBuild);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Case Complete";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.sc_TestCases.Panel1.ResumeLayout(false);
            this.sc_TestCases.Panel2.ResumeLayout(false);
            this.sc_TestCases.ResumeLayout(false);
            this.pnl_results.ResumeLayout(false);
            this.pnl_results.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem TSM_File;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSM_Help;
        private System.Windows.Forms.ToolStripMenuItem TSM_About;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_ConnectionStatus;
        private System.Windows.Forms.ToolStripMenuItem TSM_AdminTools;
        private System.Windows.Forms.ToolStripMenuItem TSM_Builds;
        private System.Windows.Forms.ToolStripMenuItem TSM_TestCase;
        private System.Windows.Forms.ToolStripMenuItem TSM_Project;
        private System.Windows.Forms.ToolStripMenuItem TSM_BuildCreate;
		private System.Windows.Forms.ToolStripMenuItem TSM_BuildEdit;
        private System.Windows.Forms.ToolStripMenuItem TSM_Logout;
        private System.Windows.Forms.ToolStripMenuItem TSM_TestCaseCreate;
        private System.Windows.Forms.ToolStripMenuItem TSM_TestCaseEdit;
        private System.Windows.Forms.ToolStripMenuItem TSM_ProjectCreate;
		private System.Windows.Forms.ToolStripMenuItem TSM_ProjectEdit;
		private System.Windows.Forms.TreeView tv_ProjectBuild;
		private System.Windows.Forms.SplitContainer sc_TestCases;
		private System.Windows.Forms.ListView lsv_TestCaseWindow;
		private System.Windows.Forms.ColumnHeader ch_priority;
		private System.Windows.Forms.ColumnHeader ch_shortDescription;
		private System.Windows.Forms.ColumnHeader ch_totalRunTime;
		private System.Windows.Forms.ColumnHeader ch_BugID;
		private System.Windows.Forms.ColumnHeader ch_CheckedOut;
		private System.Windows.Forms.ColumnHeader ch_UpdatedBy;
		private System.Windows.Forms.ColumnHeader ch_UpdateTime;
		private System.Windows.Forms.ColumnHeader ch_UpdateNotes;
		private System.Windows.Forms.ColumnHeader ch_status;
		private System.Windows.Forms.Panel pnl_results;
		private System.Windows.Forms.TextBox txt_TotalEstTime;
		private System.Windows.Forms.Label lbl_TotalEstTime;
		private System.Windows.Forms.Label lbl_RunTime;
		private System.Windows.Forms.Label lbl_CleanupTime;
		private System.Windows.Forms.Label lbl_SetupTime;
		private System.Windows.Forms.Label lbl_Instructions;
		private System.Windows.Forms.Button btn_CheckOut;
		private System.Windows.Forms.TextBox txt_BugzillaID;
		private System.Windows.Forms.MaskedTextBox mtb_SetupTime;
		private System.Windows.Forms.MaskedTextBox mtb_RunTime;
		private System.Windows.Forms.MaskedTextBox mtb_CleanupTime;
		private System.Windows.Forms.RichTextBox rtb_CleanupInstructions;
		private System.Windows.Forms.RichTextBox rtb_RunInstructions;
		private System.Windows.Forms.RichTextBox rtb_SetupInstructions;
		private System.Windows.Forms.Label lbl_SetupInstructions;
		private System.Windows.Forms.Label lbl_Run;
		private System.Windows.Forms.Label lbl_Cleanup;
		private System.Windows.Forms.Label lbl_BugzillaID;
		private System.Windows.Forms.Label lbl_TCStatus;
		private System.Windows.Forms.ToolStripMenuItem userToolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem checkedOutItemsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buildAssignerToolStripMenuItem;
		private System.Windows.Forms.RichTextBox rtb_StatusCriteria;
    }
}

