namespace TestCaseComplete
{
    partial class Form_BuildTCAssigner
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
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.lbl_project = new System.Windows.Forms.Label();
			this.lbl_build = new System.Windows.Forms.Label();
			this.cb_Build = new System.Windows.Forms.ComboBox();
			this.cb_Project = new System.Windows.Forms.ComboBox();
			this.lsv_TCWindow = new System.Windows.Forms.ListView();
			this.btn_SelectAll = new System.Windows.Forms.Button();
			this.btn_SelectNone = new System.Windows.Forms.Button();
			this.ch_ShortDescription = new System.Windows.Forms.ColumnHeader();
			this.ch_Assigned = new System.Windows.Forms.ColumnHeader();
			this.ch_TestCasePriority = new System.Windows.Forms.ColumnHeader();
			this.ch_Priority = new System.Windows.Forms.ColumnHeader();
			this.ch_Description = new System.Windows.Forms.ColumnHeader();
			this.ch_CheckBoxes = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(317, 625);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 0;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(398, 625);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// lbl_project
			// 
			this.lbl_project.AutoSize = true;
			this.lbl_project.Location = new System.Drawing.Point(12, 15);
			this.lbl_project.Name = "lbl_project";
			this.lbl_project.Size = new System.Drawing.Size(43, 13);
			this.lbl_project.TabIndex = 2;
			this.lbl_project.Text = "Project:";
			// 
			// lbl_build
			// 
			this.lbl_build.AutoSize = true;
			this.lbl_build.Location = new System.Drawing.Point(203, 15);
			this.lbl_build.Name = "lbl_build";
			this.lbl_build.Size = new System.Drawing.Size(30, 13);
			this.lbl_build.TabIndex = 3;
			this.lbl_build.Text = "Build";
			// 
			// cb_Build
			// 
			this.cb_Build.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Build.FormattingEnabled = true;
			this.cb_Build.Location = new System.Drawing.Point(239, 12);
			this.cb_Build.Name = "cb_Build";
			this.cb_Build.Size = new System.Drawing.Size(121, 21);
			this.cb_Build.TabIndex = 4;
			this.cb_Build.SelectedIndexChanged += new System.EventHandler(this.cb_Build_SelectedIndexChanged);
			// 
			// cb_Project
			// 
			this.cb_Project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Project.FormattingEnabled = true;
			this.cb_Project.Location = new System.Drawing.Point(61, 12);
			this.cb_Project.Name = "cb_Project";
			this.cb_Project.Size = new System.Drawing.Size(121, 21);
			this.cb_Project.TabIndex = 5;
			this.cb_Project.SelectedIndexChanged += new System.EventHandler(this.cb_Project_SelectedIndexChanged);
			// 
			// lsv_TCWindow
			// 
			this.lsv_TCWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lsv_TCWindow.CheckBoxes = true;
			this.lsv_TCWindow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_CheckBoxes,
            this.ch_Priority,
            this.ch_Description});
			this.lsv_TCWindow.FullRowSelect = true;
			this.lsv_TCWindow.GridLines = true;
			this.lsv_TCWindow.Location = new System.Drawing.Point(15, 52);
			this.lsv_TCWindow.Name = "lsv_TCWindow";
			this.lsv_TCWindow.ShowItemToolTips = true;
			this.lsv_TCWindow.Size = new System.Drawing.Size(458, 567);
			this.lsv_TCWindow.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lsv_TCWindow.TabIndex = 6;
			this.lsv_TCWindow.UseCompatibleStateImageBehavior = false;
			this.lsv_TCWindow.View = System.Windows.Forms.View.Details;
			// 
			// btn_SelectAll
			// 
			this.btn_SelectAll.Location = new System.Drawing.Point(15, 625);
			this.btn_SelectAll.Name = "btn_SelectAll";
			this.btn_SelectAll.Size = new System.Drawing.Size(75, 23);
			this.btn_SelectAll.TabIndex = 8;
			this.btn_SelectAll.Text = "Select All";
			this.btn_SelectAll.UseVisualStyleBackColor = true;
			this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
			// 
			// btn_SelectNone
			// 
			this.btn_SelectNone.Location = new System.Drawing.Point(96, 625);
			this.btn_SelectNone.Name = "btn_SelectNone";
			this.btn_SelectNone.Size = new System.Drawing.Size(75, 23);
			this.btn_SelectNone.TabIndex = 9;
			this.btn_SelectNone.Text = "Select None";
			this.btn_SelectNone.UseVisualStyleBackColor = true;
			this.btn_SelectNone.Click += new System.EventHandler(this.btn_SelectNone_Click);
			// 
			// ch_ShortDescription
			// 
			this.ch_ShortDescription.Text = "Short Description";
			this.ch_ShortDescription.Width = 322;
			// 
			// ch_Assigned
			// 
			this.ch_Assigned.Text = "Assigned";
			// 
			// ch_TestCasePriority
			// 
			this.ch_TestCasePriority.Text = "Priority";
			this.ch_TestCasePriority.Width = 71;
			// 
			// ch_Priority
			// 
			this.ch_Priority.Text = "Priority";
			// 
			// ch_Description
			// 
			this.ch_Description.Text = "Short Description";
			this.ch_Description.Width = 388;
			// 
			// ch_CheckBoxes
			// 
			this.ch_CheckBoxes.Text = "Assigned";
			// 
			// Form_BuildTCAssigner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_Cancel;
			this.ClientSize = new System.Drawing.Size(485, 660);
			this.Controls.Add(this.btn_SelectNone);
			this.Controls.Add(this.btn_SelectAll);
			this.Controls.Add(this.lsv_TCWindow);
			this.Controls.Add(this.cb_Project);
			this.Controls.Add(this.cb_Build);
			this.Controls.Add(this.lbl_build);
			this.Controls.Add(this.lbl_project);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form_BuildTCAssigner";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Build TC Assigner";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Label lbl_project;
		private System.Windows.Forms.Label lbl_build;
		private System.Windows.Forms.ComboBox cb_Build;
		private System.Windows.Forms.ComboBox cb_Project;
		private System.Windows.Forms.ListView lsv_TCWindow;
		private System.Windows.Forms.Button btn_SelectAll;
		private System.Windows.Forms.Button btn_SelectNone;
		private System.Windows.Forms.ColumnHeader ch_ShortDescription;
		private System.Windows.Forms.ColumnHeader ch_Assigned;
		private System.Windows.Forms.ColumnHeader ch_TestCasePriority;
		private System.Windows.Forms.ColumnHeader ch_Priority;
		private System.Windows.Forms.ColumnHeader ch_Description;
		private System.Windows.Forms.ColumnHeader ch_CheckBoxes;

	}
}