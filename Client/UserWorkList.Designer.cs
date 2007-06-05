namespace TestCaseComplete
{
	partial class Form_UserWorkList
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
			this.components = new System.ComponentModel.Container();
			this.lsv_WorkListWindow = new System.Windows.Forms.ListView();
			this.ch_priority = new System.Windows.Forms.ColumnHeader();
			this.ch_shortDescription = new System.Windows.Forms.ColumnHeader();
			this.ch_totalRunTime = new System.Windows.Forms.ColumnHeader();
			this.ch_BugID = new System.Windows.Forms.ColumnHeader();
			this.ch_CheckedOut = new System.Windows.Forms.ColumnHeader();
			this.ch_UpdatedBy = new System.Windows.Forms.ColumnHeader();
			this.ch_UpdateTime = new System.Windows.Forms.ColumnHeader();
			this.ch_UpdateNotes = new System.Windows.Forms.ColumnHeader();
			this.ch_status = new System.Windows.Forms.ColumnHeader();
			this.CMS_WorkList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SMI_UpdateResult = new System.Windows.Forms.ToolStripMenuItem();
			this.SMI_RemoveResult = new System.Windows.Forms.ToolStripMenuItem();
			this.CMS_WorkList.SuspendLayout();
			this.SuspendLayout();
			// 
			// lsv_WorkListWindow
			// 
			this.lsv_WorkListWindow.AllowColumnReorder = true;
			this.lsv_WorkListWindow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_priority,
            this.ch_shortDescription,
            this.ch_totalRunTime,
            this.ch_BugID,
            this.ch_CheckedOut,
            this.ch_UpdatedBy,
            this.ch_UpdateTime,
            this.ch_UpdateNotes,
            this.ch_status});
			this.lsv_WorkListWindow.ContextMenuStrip = this.CMS_WorkList;
			this.lsv_WorkListWindow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsv_WorkListWindow.FullRowSelect = true;
			this.lsv_WorkListWindow.GridLines = true;
			this.lsv_WorkListWindow.Location = new System.Drawing.Point(0, 0);
			this.lsv_WorkListWindow.MultiSelect = false;
			this.lsv_WorkListWindow.Name = "lsv_WorkListWindow";
			this.lsv_WorkListWindow.ShowItemToolTips = true;
			this.lsv_WorkListWindow.Size = new System.Drawing.Size(880, 300);
			this.lsv_WorkListWindow.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lsv_WorkListWindow.TabIndex = 1;
			this.lsv_WorkListWindow.UseCompatibleStateImageBehavior = false;
			this.lsv_WorkListWindow.View = System.Windows.Forms.View.Details;
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
			// CMS_WorkList
			// 
			this.CMS_WorkList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMI_UpdateResult,
            this.SMI_RemoveResult});
			this.CMS_WorkList.Name = "contextMenuStrip1";
			this.CMS_WorkList.Size = new System.Drawing.Size(158, 48);
			// 
			// SMI_UpdateResult
			// 
			this.SMI_UpdateResult.Name = "SMI_UpdateResult";
			this.SMI_UpdateResult.Size = new System.Drawing.Size(157, 22);
			this.SMI_UpdateResult.Text = "Update Result";
			this.SMI_UpdateResult.Click += new System.EventHandler(this.SMI_UpdateResult_Click);
			// 
			// SMI_RemoveResult
			// 
			this.SMI_RemoveResult.Name = "SMI_RemoveResult";
			this.SMI_RemoveResult.Size = new System.Drawing.Size(157, 22);
			this.SMI_RemoveResult.Text = "Remove Result";
			this.SMI_RemoveResult.Click += new System.EventHandler(this.SMI_RemoveResult_Click);
			// 
			// Form_UserWorkList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 300);
			this.Controls.Add(this.lsv_WorkListWindow);
			this.Name = "Form_UserWorkList";
			this.Text = "UserWorkList";
			this.Load += new System.EventHandler(this.UserWorkList_Load);
			this.CMS_WorkList.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lsv_WorkListWindow;
		private System.Windows.Forms.ColumnHeader ch_priority;
		private System.Windows.Forms.ColumnHeader ch_shortDescription;
		private System.Windows.Forms.ColumnHeader ch_totalRunTime;
		private System.Windows.Forms.ColumnHeader ch_BugID;
		private System.Windows.Forms.ColumnHeader ch_CheckedOut;
		private System.Windows.Forms.ColumnHeader ch_UpdatedBy;
		private System.Windows.Forms.ColumnHeader ch_UpdateTime;
		private System.Windows.Forms.ColumnHeader ch_UpdateNotes;
		private System.Windows.Forms.ColumnHeader ch_status;
		private System.Windows.Forms.ContextMenuStrip CMS_WorkList;
		private System.Windows.Forms.ToolStripMenuItem SMI_UpdateResult;
		private System.Windows.Forms.ToolStripMenuItem SMI_RemoveResult;
	}
}