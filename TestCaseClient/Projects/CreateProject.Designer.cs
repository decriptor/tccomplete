namespace TestCaseComplete
{
    partial class Form_CreateProject
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
            this.lbl_ProjectName = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_ProjectName = new System.Windows.Forms.TextBox();
            this.rtb_ProjectDescription = new System.Windows.Forms.RichTextBox();
            this.lbl_ProjectDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.AutoSize = true;
            this.lbl_ProjectName.Location = new System.Drawing.Point(12, 15);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(74, 13);
            this.lbl_ProjectName.TabIndex = 0;
            this.lbl_ProjectName.Text = "Project Name:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(245, 146);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(326, 146);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_ProjectName
            // 
            this.txt_ProjectName.Location = new System.Drawing.Point(92, 12);
            this.txt_ProjectName.Name = "txt_ProjectName";
            this.txt_ProjectName.Size = new System.Drawing.Size(306, 20);
            this.txt_ProjectName.TabIndex = 4;
            // 
            // rtb_ProjectDescription
            // 
            this.rtb_ProjectDescription.Location = new System.Drawing.Point(92, 44);
            this.rtb_ProjectDescription.Name = "rtb_ProjectDescription";
            this.rtb_ProjectDescription.Size = new System.Drawing.Size(306, 96);
            this.rtb_ProjectDescription.TabIndex = 5;
            this.rtb_ProjectDescription.Text = "";
            // 
            // lbl_ProjectDescription
            // 
            this.lbl_ProjectDescription.AutoSize = true;
            this.lbl_ProjectDescription.Location = new System.Drawing.Point(12, 47);
            this.lbl_ProjectDescription.Name = "lbl_ProjectDescription";
            this.lbl_ProjectDescription.Size = new System.Drawing.Size(63, 13);
            this.lbl_ProjectDescription.TabIndex = 6;
            this.lbl_ProjectDescription.Text = "Description:";
            // 
            // Form_CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(413, 181);
            this.Controls.Add(this.rtb_ProjectDescription);
            this.Controls.Add(this.lbl_ProjectDescription);
            this.Controls.Add(this.txt_ProjectName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_ProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CreateProject";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Project";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProjectName;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_ProjectName;
        private System.Windows.Forms.RichTextBox rtb_ProjectDescription;
        private System.Windows.Forms.Label lbl_ProjectDescription;
    }
}