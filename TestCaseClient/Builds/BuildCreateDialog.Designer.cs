namespace TestCaseComplete
{
    partial class Form_BuildDialog
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
			this.lbl_Project = new System.Windows.Forms.Label();
			this.cb_ProjectList = new System.Windows.Forms.ComboBox();
			this.lbl_buildNumber = new System.Windows.Forms.Label();
			this.txt_BuildNumber = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.rtb_BuildDesc = new System.Windows.Forms.RichTextBox();
			this.chb_BuildHide = new System.Windows.Forms.CheckBox();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_Project
			// 
			this.lbl_Project.AutoSize = true;
			this.lbl_Project.Location = new System.Drawing.Point(9, 15);
			this.lbl_Project.Name = "lbl_Project";
			this.lbl_Project.Size = new System.Drawing.Size(43, 13);
			this.lbl_Project.TabIndex = 0;
			this.lbl_Project.Text = "Project:";
			// 
			// cb_ProjectList
			// 
			this.cb_ProjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_ProjectList.FormattingEnabled = true;
			this.cb_ProjectList.Location = new System.Drawing.Point(58, 12);
			this.cb_ProjectList.Name = "cb_ProjectList";
			this.cb_ProjectList.Size = new System.Drawing.Size(100, 21);
			this.cb_ProjectList.TabIndex = 0;
			// 
			// lbl_buildNumber
			// 
			this.lbl_buildNumber.AutoSize = true;
			this.lbl_buildNumber.Location = new System.Drawing.Point(9, 45);
			this.lbl_buildNumber.Name = "lbl_buildNumber";
			this.lbl_buildNumber.Size = new System.Drawing.Size(43, 13);
			this.lbl_buildNumber.TabIndex = 2;
			this.lbl_buildNumber.Text = "Build #:";
			// 
			// txt_BuildNumber
			// 
			this.txt_BuildNumber.Location = new System.Drawing.Point(58, 42);
			this.txt_BuildNumber.Name = "txt_BuildNumber";
			this.txt_BuildNumber.Size = new System.Drawing.Size(100, 20);
			this.txt_BuildNumber.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Description:";
			// 
			// rtb_BuildDesc
			// 
			this.rtb_BuildDesc.Location = new System.Drawing.Point(12, 100);
			this.rtb_BuildDesc.Name = "rtb_BuildDesc";
			this.rtb_BuildDesc.Size = new System.Drawing.Size(325, 91);
			this.rtb_BuildDesc.TabIndex = 2;
			this.rtb_BuildDesc.Text = "";
			// 
			// chb_BuildHide
			// 
			this.chb_BuildHide.AutoSize = true;
			this.chb_BuildHide.Location = new System.Drawing.Point(12, 197);
			this.chb_BuildHide.Name = "chb_BuildHide";
			this.chb_BuildHide.Size = new System.Drawing.Size(48, 17);
			this.chb_BuildHide.TabIndex = 3;
			this.chb_BuildHide.Text = "Hide";
			this.chb_BuildHide.UseVisualStyleBackColor = true;
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(181, 197);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 4;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(262, 197);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 5;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// Form_BuildDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_Cancel;
			this.ClientSize = new System.Drawing.Size(349, 227);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.chb_BuildHide);
			this.Controls.Add(this.rtb_BuildDesc);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_BuildNumber);
			this.Controls.Add(this.lbl_buildNumber);
			this.Controls.Add(this.cb_ProjectList);
			this.Controls.Add(this.lbl_Project);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_BuildDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Create New Build ";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Project;
        private System.Windows.Forms.ComboBox cb_ProjectList;
        private System.Windows.Forms.Label lbl_buildNumber;
        private System.Windows.Forms.TextBox txt_BuildNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_BuildDesc;
        private System.Windows.Forms.CheckBox chb_BuildHide;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}