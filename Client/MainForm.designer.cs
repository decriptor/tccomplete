namespace TestCaseComplete
{
    partial class MainForm
    {
        /// <summary>        /// Required designer variable.
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
            this.TSM_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSM_Exit = new System.Windows.Forms.ToolStripMenuItem();
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
            this.TSM_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_ConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lsv_TestCaseWindow = new System.Windows.Forms.ListView();
            this.lsv_Status = new System.Windows.Forms.ListView();
            this.tv_ProjectBuild = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_File,
            this.TSM_AdminTools,
            this.TSM_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSM_File
            // 
            this.TSM_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Logout,
            this.toolStripSeparator1,
            this.TSM_Exit});
            this.TSM_File.Name = "TSM_File";
            this.TSM_File.Size = new System.Drawing.Size(35, 20);
            this.TSM_File.Text = "&File";
            // 
            // TSM_Logout
            // 
            this.TSM_Logout.Name = "TSM_Logout";
            this.TSM_Logout.Size = new System.Drawing.Size(137, 22);
            this.TSM_Logout.Text = "L&ogout";
            this.TSM_Logout.Click += new System.EventHandler(this.TSM_Logout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // TSM_Exit
            // 
            this.TSM_Exit.Name = "TSM_Exit";
            this.TSM_Exit.ShortcutKeyDisplayString = "";
            this.TSM_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.TSM_Exit.Size = new System.Drawing.Size(137, 22);
            this.TSM_Exit.Text = "E&xit";
            this.TSM_Exit.Click += new System.EventHandler(this.TSM_Exit_Click);
            // 
            // TSM_AdminTools
            // 
            this.TSM_AdminTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Project,
            this.TSM_Builds,
            this.TSM_TestCase});
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
            this.TSM_Project.Size = new System.Drawing.Size(133, 22);
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
            this.TSM_Builds.Size = new System.Drawing.Size(133, 22);
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
            this.TSM_TestCaseEdit});
            this.TSM_TestCase.Name = "TSM_TestCase";
            this.TSM_TestCase.Size = new System.Drawing.Size(133, 22);
            this.TSM_TestCase.Text = "Test Case";
            // 
            // TSM_TestCaseCreate
            // 
            this.TSM_TestCaseCreate.Name = "TSM_TestCaseCreate";
            this.TSM_TestCaseCreate.Size = new System.Drawing.Size(118, 22);
            this.TSM_TestCaseCreate.Text = "Create";
            this.TSM_TestCaseCreate.Click += new System.EventHandler(this.TSM_TestCaseCreate_Click);
            // 
            // TSM_TestCaseEdit
            // 
            this.TSM_TestCaseEdit.Name = "TSM_TestCaseEdit";
            this.TSM_TestCaseEdit.Size = new System.Drawing.Size(118, 22);
            this.TSM_TestCaseEdit.Text = "Edit";
            this.TSM_TestCaseEdit.Click += new System.EventHandler(this.TSM_TestCaseEdit_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(923, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_ConnectionStatus
            // 
            this.TSSL_ConnectionStatus.Name = "TSSL_ConnectionStatus";
            this.TSSL_ConnectionStatus.Size = new System.Drawing.Size(71, 17);
            this.TSSL_ConnectionStatus.Text = "Disconnected";
            // 
            // lsv_TestCaseWindow
            // 
            this.lsv_TestCaseWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_TestCaseWindow.Location = new System.Drawing.Point(174, 24);
            this.lsv_TestCaseWindow.Name = "lsv_TestCaseWindow";
            this.lsv_TestCaseWindow.Size = new System.Drawing.Size(599, 595);
            this.lsv_TestCaseWindow.TabIndex = 7;
            this.lsv_TestCaseWindow.UseCompatibleStateImageBehavior = false;
            // 
            // lsv_Status
            // 
            this.lsv_Status.Dock = System.Windows.Forms.DockStyle.Right;
            this.lsv_Status.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsv_Status.Location = new System.Drawing.Point(773, 24);
            this.lsv_Status.MultiSelect = false;
            this.lsv_Status.Name = "lsv_Status";
            this.lsv_Status.Scrollable = false;
            this.lsv_Status.ShowItemToolTips = true;
            this.lsv_Status.Size = new System.Drawing.Size(150, 595);
            this.lsv_Status.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsv_Status.TabIndex = 8;
            this.lsv_Status.UseCompatibleStateImageBehavior = false;
            this.lsv_Status.View = System.Windows.Forms.View.Details;
            // 
            // tv_ProjectBuild
            // 
            this.tv_ProjectBuild.Dock = System.Windows.Forms.DockStyle.Left;
            this.tv_ProjectBuild.Location = new System.Drawing.Point(0, 24);
            this.tv_ProjectBuild.Name = "tv_ProjectBuild";
            this.tv_ProjectBuild.ShowNodeToolTips = true;
            this.tv_ProjectBuild.Size = new System.Drawing.Size(174, 595);
            this.tv_ProjectBuild.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 641);
            this.Controls.Add(this.lsv_TestCaseWindow);
            this.Controls.Add(this.lsv_Status);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSM_File;
        private System.Windows.Forms.ToolStripMenuItem TSM_Exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSM_Help;
        private System.Windows.Forms.ToolStripMenuItem TSM_About;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_ConnectionStatus;
        private System.Windows.Forms.ToolStripMenuItem TSM_AdminTools;
        private System.Windows.Forms.ToolStripMenuItem TSM_Builds;
        private System.Windows.Forms.ToolStripMenuItem TSM_TestCase;
        private System.Windows.Forms.ToolStripMenuItem TSM_Project;        private System.Windows.Forms.ToolStripMenuItem TSM_BuildCreate;
		private System.Windows.Forms.ToolStripMenuItem TSM_BuildEdit;
        private System.Windows.Forms.ToolStripMenuItem TSM_Logout;
        private System.Windows.Forms.ToolStripMenuItem TSM_TestCaseCreate;
        private System.Windows.Forms.ToolStripMenuItem TSM_TestCaseEdit;
        private System.Windows.Forms.ToolStripMenuItem TSM_ProjectCreate;        private System.Windows.Forms.ToolStripMenuItem TSM_ProjectEdit;
		private System.Windows.Forms.ListView lsv_TestCaseWindow;
		private System.Windows.Forms.ListView lsv_Status;
		private System.Windows.Forms.TreeView tv_ProjectBuild;
    }
}

