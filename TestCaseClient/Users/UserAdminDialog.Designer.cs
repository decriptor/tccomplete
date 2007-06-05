namespace TestCaseComplete
{
	partial class Form_UserAdminDialog
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
			this.lsb_CurrentUsers = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lsb_CurrentUsers
			// 
			this.lsb_CurrentUsers.FormattingEnabled = true;
			this.lsb_CurrentUsers.Location = new System.Drawing.Point(12, 25);
			this.lsb_CurrentUsers.Name = "lsb_CurrentUsers";
			this.lsb_CurrentUsers.Size = new System.Drawing.Size(118, 225);
			this.lsb_CurrentUsers.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Current Users:";
			// 
			// Form_UserAdminDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 349);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lsb_CurrentUsers);
			this.Name = "Form_UserAdminDialog";
			this.Text = "User Admin Console";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lsb_CurrentUsers;
		private System.Windows.Forms.Label label1;
	}
}