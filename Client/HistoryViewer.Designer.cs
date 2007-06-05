namespace TestCaseComplete
{
	partial class Form_HistoryViewer
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
			this.lsv_HistoryWindow = new System.Windows.Forms.ListView();
			this.ch_ResultID = new System.Windows.Forms.ColumnHeader();
			this.ch_UserName = new System.Windows.Forms.ColumnHeader();
			this.ch_Status = new System.Windows.Forms.ColumnHeader();
			this.ch_BugID = new System.Windows.Forms.ColumnHeader();
			this.ch_Time = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// lsv_HistoryWindow
			// 
			this.lsv_HistoryWindow.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.lsv_HistoryWindow.AllowColumnReorder = true;
			this.lsv_HistoryWindow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_ResultID,
            this.ch_UserName,
            this.ch_Status,
            this.ch_BugID,
            this.ch_Time});
			this.lsv_HistoryWindow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsv_HistoryWindow.FullRowSelect = true;
			this.lsv_HistoryWindow.GridLines = true;
			this.lsv_HistoryWindow.Location = new System.Drawing.Point(0, 0);
			this.lsv_HistoryWindow.MultiSelect = false;
			this.lsv_HistoryWindow.Name = "lsv_HistoryWindow";
			this.lsv_HistoryWindow.ShowItemToolTips = true;
			this.lsv_HistoryWindow.Size = new System.Drawing.Size(432, 627);
			this.lsv_HistoryWindow.TabIndex = 2;
			this.lsv_HistoryWindow.UseCompatibleStateImageBehavior = false;
			this.lsv_HistoryWindow.View = System.Windows.Forms.View.Details;
			this.lsv_HistoryWindow.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lsv_HistoryWindow_ColumnClick);
			// 
			// ch_ResultID
			// 
			this.ch_ResultID.Text = "Result ID";
			// 
			// ch_UserName
			// 
			this.ch_UserName.Text = "User";
			this.ch_UserName.Width = 103;
			// 
			// ch_Status
			// 
			this.ch_Status.Text = "Status";
			this.ch_Status.Width = 68;
			// 
			// ch_BugID
			// 
			this.ch_BugID.Text = "Defect ID";
			this.ch_BugID.Width = 74;
			// 
			// ch_Time
			// 
			this.ch_Time.Text = "Time";
			this.ch_Time.Width = 123;
			// 
			// Form_HistoryViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 627);
			this.Controls.Add(this.lsv_HistoryWindow);
			this.Name = "Form_HistoryViewer";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "History Viewer";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lsv_HistoryWindow;
		private System.Windows.Forms.ColumnHeader ch_ResultID;
		private System.Windows.Forms.ColumnHeader ch_UserName;
		private System.Windows.Forms.ColumnHeader ch_Status;
		private System.Windows.Forms.ColumnHeader ch_BugID;
		private System.Windows.Forms.ColumnHeader ch_Time;
	}
}