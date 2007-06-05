namespace TestCaseComplete
{
	partial class Form_UpdateResultDialog
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
			this.btn_Update = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.rtb_UpdateNotes = new System.Windows.Forms.RichTextBox();
			this.cb_Status = new System.Windows.Forms.ComboBox();
			this.lbl_Status = new System.Windows.Forms.Label();
			this.lbl_UpdateNotes = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Update
			// 
			this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Update.Location = new System.Drawing.Point(257, 275);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(75, 23);
			this.btn_Update.TabIndex = 0;
			this.btn_Update.Text = "Update";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(338, 275);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// rtb_UpdateNotes
			// 
			this.rtb_UpdateNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.rtb_UpdateNotes.Location = new System.Drawing.Point(12, 31);
			this.rtb_UpdateNotes.Name = "rtb_UpdateNotes";
			this.rtb_UpdateNotes.Size = new System.Drawing.Size(401, 225);
			this.rtb_UpdateNotes.TabIndex = 2;
			this.rtb_UpdateNotes.Text = "";
			// 
			// cb_Status
			// 
			this.cb_Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cb_Status.FormattingEnabled = true;
			this.cb_Status.Location = new System.Drawing.Point(12, 275);
			this.cb_Status.Name = "cb_Status";
			this.cb_Status.Size = new System.Drawing.Size(121, 21);
			this.cb_Status.TabIndex = 3;
			// 
			// lbl_Status
			// 
			this.lbl_Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Status.AutoSize = true;
			this.lbl_Status.Location = new System.Drawing.Point(9, 259);
			this.lbl_Status.Name = "lbl_Status";
			this.lbl_Status.Size = new System.Drawing.Size(40, 13);
			this.lbl_Status.TabIndex = 4;
			this.lbl_Status.Text = "Status:";
			// 
			// lbl_UpdateNotes
			// 
			this.lbl_UpdateNotes.AutoSize = true;
			this.lbl_UpdateNotes.Location = new System.Drawing.Point(9, 15);
			this.lbl_UpdateNotes.Name = "lbl_UpdateNotes";
			this.lbl_UpdateNotes.Size = new System.Drawing.Size(76, 13);
			this.lbl_UpdateNotes.TabIndex = 5;
			this.lbl_UpdateNotes.Text = "Update Notes:";
			// 
			// Form_UpdateResultDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_Cancel;
			this.ClientSize = new System.Drawing.Size(425, 310);
			this.Controls.Add(this.lbl_UpdateNotes);
			this.Controls.Add(this.lbl_Status);
			this.Controls.Add(this.cb_Status);
			this.Controls.Add(this.rtb_UpdateNotes);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Update);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_UpdateResultDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Update Result Window";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.RichTextBox rtb_UpdateNotes;
		private System.Windows.Forms.ComboBox cb_Status;
		private System.Windows.Forms.Label lbl_Status;
		private System.Windows.Forms.Label lbl_UpdateNotes;
	}
}