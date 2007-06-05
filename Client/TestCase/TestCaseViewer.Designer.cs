namespace TestCaseComplete
{
	partial class Form_TestCaseViewer
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
			this.ch_ShortDescription = new System.Windows.Forms.ColumnHeader();
			this.ch_Assigned = new System.Windows.Forms.ColumnHeader();
			this.ch_TestCasePriority = new System.Windows.Forms.ColumnHeader();
			this.lsv_TCWindow = new System.Windows.Forms.ListView();
			this.cb_Project = new System.Windows.Forms.ComboBox();
			this.lbl_project = new System.Windows.Forms.Label();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Edit = new System.Windows.Forms.Button();
			this.ch_Priority = new System.Windows.Forms.ColumnHeader();
			this.ch_Description = new System.Windows.Forms.ColumnHeader();
			this.ch_BugID = new System.Windows.Forms.ColumnHeader();
			this.ch_TotalRunTime = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
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
			// lsv_TCWindow
			// 
			this.lsv_TCWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lsv_TCWindow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Priority,
            this.ch_Description,
            this.ch_BugID,
            this.ch_TotalRunTime});
			this.lsv_TCWindow.FullRowSelect = true;
			this.lsv_TCWindow.GridLines = true;
			this.lsv_TCWindow.Location = new System.Drawing.Point(14, 51);
			this.lsv_TCWindow.Name = "lsv_TCWindow";
			this.lsv_TCWindow.ShowItemToolTips = true;
			this.lsv_TCWindow.Size = new System.Drawing.Size(458, 567);
			this.lsv_TCWindow.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lsv_TCWindow.TabIndex = 16;
			this.lsv_TCWindow.UseCompatibleStateImageBehavior = false;
			this.lsv_TCWindow.View = System.Windows.Forms.View.Details;
			// 
			// cb_Project
			// 
			this.cb_Project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Project.FormattingEnabled = true;
			this.cb_Project.Location = new System.Drawing.Point(60, 11);
			this.cb_Project.Name = "cb_Project";
			this.cb_Project.Size = new System.Drawing.Size(121, 21);
			this.cb_Project.TabIndex = 15;
			this.cb_Project.SelectedIndexChanged += new System.EventHandler(this.cb_Project_SelectedIndexChanged);
			// 
			// lbl_project
			// 
			this.lbl_project.AutoSize = true;
			this.lbl_project.Location = new System.Drawing.Point(11, 14);
			this.lbl_project.Name = "lbl_project";
			this.lbl_project.Size = new System.Drawing.Size(43, 13);
			this.lbl_project.TabIndex = 12;
			this.lbl_project.Text = "Project:";
			// 
			// btn_Close
			// 
			this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Close.Location = new System.Drawing.Point(397, 624);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(75, 23);
			this.btn_Close.TabIndex = 11;
			this.btn_Close.Text = "Close";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_Edit
			// 
			this.btn_Edit.Location = new System.Drawing.Point(316, 624);
			this.btn_Edit.Name = "btn_Edit";
			this.btn_Edit.Size = new System.Drawing.Size(75, 23);
			this.btn_Edit.TabIndex = 10;
			this.btn_Edit.Text = "Edit";
			this.btn_Edit.UseVisualStyleBackColor = true;
			this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
			// 
			// ch_Priority
			// 
			this.ch_Priority.Text = "Priority";
			// 
			// ch_Description
			// 
			this.ch_Description.Text = "Short Description";
			this.ch_Description.Width = 234;
			// 
			// ch_BugID
			// 
			this.ch_BugID.Text = "Defect ID";
			this.ch_BugID.Width = 69;
			// 
			// ch_TotalRunTime
			// 
			this.ch_TotalRunTime.Text = "Total Run Time";
			this.ch_TotalRunTime.Width = 89;
			// 
			// Form_TestCaseViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 658);
			this.Controls.Add(this.lsv_TCWindow);
			this.Controls.Add(this.cb_Project);
			this.Controls.Add(this.lbl_project);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.btn_Edit);
			this.Name = "Form_TestCaseViewer";
			this.Text = "TestCaseViewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ColumnHeader ch_ShortDescription;
		private System.Windows.Forms.ColumnHeader ch_Assigned;
		private System.Windows.Forms.ColumnHeader ch_TestCasePriority;
		private System.Windows.Forms.ListView lsv_TCWindow;
		private System.Windows.Forms.ComboBox cb_Project;
		private System.Windows.Forms.Label lbl_project;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.Button btn_Edit;
		private System.Windows.Forms.ColumnHeader ch_Priority;
		private System.Windows.Forms.ColumnHeader ch_Description;
		private System.Windows.Forms.ColumnHeader ch_BugID;
		private System.Windows.Forms.ColumnHeader ch_TotalRunTime;

	}
}