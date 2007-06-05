namespace TestCaseComplete
{
	partial class BuildEditDialog
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
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.chb_BuildHide = new System.Windows.Forms.CheckBox();
			this.rtb_BuildDesc = new System.Windows.Forms.RichTextBox();
			this.lbl_description = new System.Windows.Forms.Label();
			this.txt_NewBuild = new System.Windows.Forms.TextBox();
			this.lbl_buildNumber = new System.Windows.Forms.Label();
			this.cb_ProjectList = new System.Windows.Forms.ComboBox();
			this.lbl_Project = new System.Windows.Forms.Label();
			this.lbl_oldBuild = new System.Windows.Forms.Label();
			this.cb_oldBuild = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(265, 205);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 6;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(184, 205);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 5;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			// 
			// chb_BuildHide
			// 
			this.chb_BuildHide.AutoSize = true;
			this.chb_BuildHide.Location = new System.Drawing.Point(15, 205);
			this.chb_BuildHide.Name = "chb_BuildHide";
			this.chb_BuildHide.Size = new System.Drawing.Size(48, 17);
			this.chb_BuildHide.TabIndex = 4;
			this.chb_BuildHide.Text = "Hide";
			this.chb_BuildHide.UseVisualStyleBackColor = true;
			// 
			// rtb_BuildDesc
			// 
			this.rtb_BuildDesc.Location = new System.Drawing.Point(15, 108);
			this.rtb_BuildDesc.Name = "rtb_BuildDesc";
			this.rtb_BuildDesc.Size = new System.Drawing.Size(325, 91);
			this.rtb_BuildDesc.TabIndex = 3;
			this.rtb_BuildDesc.Text = "";
			// 
			// lbl_description
			// 
			this.lbl_description.AutoSize = true;
			this.lbl_description.Location = new System.Drawing.Point(12, 92);
			this.lbl_description.Name = "lbl_description";
			this.lbl_description.Size = new System.Drawing.Size(63, 13);
			this.lbl_description.TabIndex = 13;
			this.lbl_description.Text = "Description:";
			// 
			// txt_NewBuild
			// 
			this.txt_NewBuild.Location = new System.Drawing.Point(76, 69);
			this.txt_NewBuild.Name = "txt_NewBuild";
			this.txt_NewBuild.Size = new System.Drawing.Size(135, 20);
			this.txt_NewBuild.TabIndex = 2;
			// 
			// lbl_buildNumber
			// 
			this.lbl_buildNumber.AutoSize = true;
			this.lbl_buildNumber.Location = new System.Drawing.Point(12, 72);
			this.lbl_buildNumber.Name = "lbl_buildNumber";
			this.lbl_buildNumber.Size = new System.Drawing.Size(58, 13);
			this.lbl_buildNumber.TabIndex = 9;
			this.lbl_buildNumber.Text = "New Build:";
			// 
			// cb_ProjectList
			// 
			this.cb_ProjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_ProjectList.FormattingEnabled = true;
			this.cb_ProjectList.Location = new System.Drawing.Point(76, 39);
			this.cb_ProjectList.Name = "cb_ProjectList";
			this.cb_ProjectList.Size = new System.Drawing.Size(135, 21);
			this.cb_ProjectList.TabIndex = 1;
			// 
			// lbl_Project
			// 
			this.lbl_Project.AutoSize = true;
			this.lbl_Project.Location = new System.Drawing.Point(12, 42);
			this.lbl_Project.Name = "lbl_Project";
			this.lbl_Project.Size = new System.Drawing.Size(43, 13);
			this.lbl_Project.TabIndex = 7;
			this.lbl_Project.Text = "Project:";
			// 
			// lbl_oldBuild
			// 
			this.lbl_oldBuild.AutoSize = true;
			this.lbl_oldBuild.Location = new System.Drawing.Point(12, 15);
			this.lbl_oldBuild.Name = "lbl_oldBuild";
			this.lbl_oldBuild.Size = new System.Drawing.Size(52, 13);
			this.lbl_oldBuild.TabIndex = 15;
			this.lbl_oldBuild.Text = "Old Build:";
			// 
			// cb_oldBuild
			// 
			this.cb_oldBuild.FormattingEnabled = true;
			this.cb_oldBuild.Location = new System.Drawing.Point(76, 12);
			this.cb_oldBuild.Name = "cb_oldBuild";
			this.cb_oldBuild.Size = new System.Drawing.Size(135, 21);
			this.cb_oldBuild.TabIndex = 0;
			// 
			// BuildEditDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 241);
			this.Controls.Add(this.cb_oldBuild);
			this.Controls.Add(this.lbl_oldBuild);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.chb_BuildHide);
			this.Controls.Add(this.rtb_BuildDesc);
			this.Controls.Add(this.lbl_description);
			this.Controls.Add(this.txt_NewBuild);
			this.Controls.Add(this.lbl_buildNumber);
			this.Controls.Add(this.cb_ProjectList);
			this.Controls.Add(this.lbl_Project);
			this.Name = "BuildEditDialog";
			this.Text = "Build Edit Window";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.CheckBox chb_BuildHide;
		private System.Windows.Forms.RichTextBox rtb_BuildDesc;
		private System.Windows.Forms.Label lbl_description;
		private System.Windows.Forms.TextBox txt_NewBuild;
		private System.Windows.Forms.Label lbl_buildNumber;
		private System.Windows.Forms.ComboBox cb_ProjectList;
		private System.Windows.Forms.Label lbl_Project;
		private System.Windows.Forms.Label lbl_oldBuild;
		private System.Windows.Forms.ComboBox cb_oldBuild;
	}
}