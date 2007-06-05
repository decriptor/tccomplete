namespace TestCaseComplete
{
    partial class Form_TestCaseDialog
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
			this.lbl_TCPriority = new System.Windows.Forms.Label();
			this.lbl_BugzillaID = new System.Windows.Forms.Label();
			this.lbl_Cleanup = new System.Windows.Forms.Label();
			this.lbl_Run = new System.Windows.Forms.Label();
			this.lbl_SetupInstructions = new System.Windows.Forms.Label();
			this.cb_TCPriority = new System.Windows.Forms.ComboBox();
			this.rtb_SetupInstructions = new System.Windows.Forms.RichTextBox();
			this.rtb_RunInstructions = new System.Windows.Forms.RichTextBox();
			this.rtb_CleanupInstructions = new System.Windows.Forms.RichTextBox();
			this.mtb_CleanupTime = new System.Windows.Forms.MaskedTextBox();
			this.mtb_RunTime = new System.Windows.Forms.MaskedTextBox();
			this.mtb_SetupTime = new System.Windows.Forms.MaskedTextBox();
			this.txt_BugzillaID = new System.Windows.Forms.TextBox();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.lbl_TCShortDescription = new System.Windows.Forms.Label();
			this.rtb_ShortDescription = new System.Windows.Forms.RichTextBox();
			this.lbl_Instructions = new System.Windows.Forms.Label();
			this.lbl_SetupTime = new System.Windows.Forms.Label();
			this.lbl_CleanupTime = new System.Windows.Forms.Label();
			this.lbl_RunTime = new System.Windows.Forms.Label();
			this.lbl_TotalEstTime = new System.Windows.Forms.Label();
			this.txt_TotalEstTime = new System.Windows.Forms.TextBox();
			this.lbl_Project = new System.Windows.Forms.Label();
			this.cb_ProjectList = new System.Windows.Forms.ComboBox();
			this.lbl_PassFailDescription = new System.Windows.Forms.Label();
			this.rtb_PassFailDescription = new System.Windows.Forms.RichTextBox();
			this.cb_TestCase = new System.Windows.Forms.ComboBox();
			this.lbl_TestCase = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_TCPriority
			// 
			this.lbl_TCPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_TCPriority.AutoSize = true;
			this.lbl_TCPriority.Location = new System.Drawing.Point(677, 18);
			this.lbl_TCPriority.Name = "lbl_TCPriority";
			this.lbl_TCPriority.Size = new System.Drawing.Size(58, 13);
			this.lbl_TCPriority.TabIndex = 0;
			this.lbl_TCPriority.Text = "TC Priority:";
			// 
			// lbl_BugzillaID
			// 
			this.lbl_BugzillaID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_BugzillaID.AutoSize = true;
			this.lbl_BugzillaID.Location = new System.Drawing.Point(677, 45);
			this.lbl_BugzillaID.Name = "lbl_BugzillaID";
			this.lbl_BugzillaID.Size = new System.Drawing.Size(60, 13);
			this.lbl_BugzillaID.TabIndex = 2;
			this.lbl_BugzillaID.Text = "Bugzilla ID:";
			// 
			// lbl_Cleanup
			// 
			this.lbl_Cleanup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Cleanup.AutoSize = true;
			this.lbl_Cleanup.Location = new System.Drawing.Point(435, 100);
			this.lbl_Cleanup.Name = "lbl_Cleanup";
			this.lbl_Cleanup.Size = new System.Drawing.Size(46, 13);
			this.lbl_Cleanup.TabIndex = 3;
			this.lbl_Cleanup.Text = "Cleanup";
			// 
			// lbl_Run
			// 
			this.lbl_Run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Run.AutoSize = true;
			this.lbl_Run.Location = new System.Drawing.Point(222, 100);
			this.lbl_Run.Name = "lbl_Run";
			this.lbl_Run.Size = new System.Drawing.Size(27, 13);
			this.lbl_Run.TabIndex = 4;
			this.lbl_Run.Text = "Run";
			// 
			// lbl_SetupInstructions
			// 
			this.lbl_SetupInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_SetupInstructions.AutoSize = true;
			this.lbl_SetupInstructions.Location = new System.Drawing.Point(9, 100);
			this.lbl_SetupInstructions.Name = "lbl_SetupInstructions";
			this.lbl_SetupInstructions.Size = new System.Drawing.Size(35, 13);
			this.lbl_SetupInstructions.TabIndex = 5;
			this.lbl_SetupInstructions.Text = "Setup";
			// 
			// cb_TCPriority
			// 
			this.cb_TCPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_TCPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_TCPriority.FormattingEnabled = true;
			this.cb_TCPriority.Location = new System.Drawing.Point(743, 15);
			this.cb_TCPriority.Name = "cb_TCPriority";
			this.cb_TCPriority.Size = new System.Drawing.Size(73, 21);
			this.cb_TCPriority.TabIndex = 2;
			// 
			// rtb_SetupInstructions
			// 
			this.rtb_SetupInstructions.Location = new System.Drawing.Point(12, 116);
			this.rtb_SetupInstructions.Name = "rtb_SetupInstructions";
			this.rtb_SetupInstructions.Size = new System.Drawing.Size(207, 139);
			this.rtb_SetupInstructions.TabIndex = 3;
			this.rtb_SetupInstructions.Text = "";
			// 
			// rtb_RunInstructions
			// 
			this.rtb_RunInstructions.Location = new System.Drawing.Point(225, 116);
			this.rtb_RunInstructions.Name = "rtb_RunInstructions";
			this.rtb_RunInstructions.Size = new System.Drawing.Size(207, 139);
			this.rtb_RunInstructions.TabIndex = 4;
			this.rtb_RunInstructions.Text = "";
			// 
			// rtb_CleanupInstructions
			// 
			this.rtb_CleanupInstructions.Location = new System.Drawing.Point(438, 116);
			this.rtb_CleanupInstructions.Name = "rtb_CleanupInstructions";
			this.rtb_CleanupInstructions.Size = new System.Drawing.Size(207, 139);
			this.rtb_CleanupInstructions.TabIndex = 5;
			this.rtb_CleanupInstructions.Text = "";
			// 
			// mtb_CleanupTime
			// 
			this.mtb_CleanupTime.Location = new System.Drawing.Point(579, 261);
			this.mtb_CleanupTime.Name = "mtb_CleanupTime";
			this.mtb_CleanupTime.Size = new System.Drawing.Size(66, 20);
			this.mtb_CleanupTime.TabIndex = 8;
			// 
			// mtb_RunTime
			// 
			this.mtb_RunTime.Location = new System.Drawing.Point(366, 261);
			this.mtb_RunTime.Name = "mtb_RunTime";
			this.mtb_RunTime.Size = new System.Drawing.Size(66, 20);
			this.mtb_RunTime.TabIndex = 7;
			// 
			// mtb_SetupTime
			// 
			this.mtb_SetupTime.Location = new System.Drawing.Point(153, 261);
			this.mtb_SetupTime.Name = "mtb_SetupTime";
			this.mtb_SetupTime.Size = new System.Drawing.Size(66, 20);
			this.mtb_SetupTime.TabIndex = 6;
			// 
			// txt_BugzillaID
			// 
			this.txt_BugzillaID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_BugzillaID.Location = new System.Drawing.Point(743, 42);
			this.txt_BugzillaID.Name = "txt_BugzillaID";
			this.txt_BugzillaID.Size = new System.Drawing.Size(73, 20);
			this.txt_BugzillaID.TabIndex = 10;
			// 
			// btn_Save
			// 
			this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Save.Location = new System.Drawing.Point(660, 285);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 12;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(741, 285);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 13;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// lbl_TCShortDescription
			// 
			this.lbl_TCShortDescription.AutoSize = true;
			this.lbl_TCShortDescription.Location = new System.Drawing.Point(9, 42);
			this.lbl_TCShortDescription.Name = "lbl_TCShortDescription";
			this.lbl_TCShortDescription.Size = new System.Drawing.Size(63, 13);
			this.lbl_TCShortDescription.TabIndex = 22;
			this.lbl_TCShortDescription.Text = "Description:";
			// 
			// rtb_ShortDescription
			// 
			this.rtb_ShortDescription.Location = new System.Drawing.Point(78, 39);
			this.rtb_ShortDescription.Name = "rtb_ShortDescription";
			this.rtb_ShortDescription.Size = new System.Drawing.Size(348, 38);
			this.rtb_ShortDescription.TabIndex = 1;
			this.rtb_ShortDescription.Text = "";
			// 
			// lbl_Instructions
			// 
			this.lbl_Instructions.AutoSize = true;
			this.lbl_Instructions.Location = new System.Drawing.Point(9, 87);
			this.lbl_Instructions.Name = "lbl_Instructions";
			this.lbl_Instructions.Size = new System.Drawing.Size(64, 13);
			this.lbl_Instructions.TabIndex = 24;
			this.lbl_Instructions.Text = "Instructions:";
			// 
			// lbl_SetupTime
			// 
			this.lbl_SetupTime.AutoSize = true;
			this.lbl_SetupTime.Location = new System.Drawing.Point(114, 264);
			this.lbl_SetupTime.Name = "lbl_SetupTime";
			this.lbl_SetupTime.Size = new System.Drawing.Size(33, 13);
			this.lbl_SetupTime.TabIndex = 25;
			this.lbl_SetupTime.Text = "Time:";
			// 
			// lbl_CleanupTime
			// 
			this.lbl_CleanupTime.AutoSize = true;
			this.lbl_CleanupTime.Location = new System.Drawing.Point(540, 264);
			this.lbl_CleanupTime.Name = "lbl_CleanupTime";
			this.lbl_CleanupTime.Size = new System.Drawing.Size(33, 13);
			this.lbl_CleanupTime.TabIndex = 28;
			this.lbl_CleanupTime.Text = "Time:";
			// 
			// lbl_RunTime
			// 
			this.lbl_RunTime.AutoSize = true;
			this.lbl_RunTime.Location = new System.Drawing.Point(327, 264);
			this.lbl_RunTime.Name = "lbl_RunTime";
			this.lbl_RunTime.Size = new System.Drawing.Size(33, 13);
			this.lbl_RunTime.TabIndex = 29;
			this.lbl_RunTime.Text = "Time:";
			// 
			// lbl_TotalEstTime
			// 
			this.lbl_TotalEstTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_TotalEstTime.AutoSize = true;
			this.lbl_TotalEstTime.Location = new System.Drawing.Point(492, 290);
			this.lbl_TotalEstTime.Name = "lbl_TotalEstTime";
			this.lbl_TotalEstTime.Size = new System.Drawing.Size(81, 13);
			this.lbl_TotalEstTime.TabIndex = 30;
			this.lbl_TotalEstTime.Text = "Total Est. Time:";
			// 
			// txt_TotalEstTime
			// 
			this.txt_TotalEstTime.Location = new System.Drawing.Point(579, 287);
			this.txt_TotalEstTime.Name = "txt_TotalEstTime";
			this.txt_TotalEstTime.ReadOnly = true;
			this.txt_TotalEstTime.Size = new System.Drawing.Size(66, 20);
			this.txt_TotalEstTime.TabIndex = 9;
			// 
			// lbl_Project
			// 
			this.lbl_Project.AutoSize = true;
			this.lbl_Project.Location = new System.Drawing.Point(9, 15);
			this.lbl_Project.Name = "lbl_Project";
			this.lbl_Project.Size = new System.Drawing.Size(43, 13);
			this.lbl_Project.TabIndex = 31;
			this.lbl_Project.Text = "Project:";
			// 
			// cb_ProjectList
			// 
			this.cb_ProjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_ProjectList.FormattingEnabled = true;
			this.cb_ProjectList.Location = new System.Drawing.Point(82, 12);
			this.cb_ProjectList.Name = "cb_ProjectList";
			this.cb_ProjectList.Size = new System.Drawing.Size(137, 21);
			this.cb_ProjectList.TabIndex = 0;
			// 
			// lbl_PassFailDescription
			// 
			this.lbl_PassFailDescription.AutoSize = true;
			this.lbl_PassFailDescription.Location = new System.Drawing.Point(648, 100);
			this.lbl_PassFailDescription.Name = "lbl_PassFailDescription";
			this.lbl_PassFailDescription.Size = new System.Drawing.Size(108, 13);
			this.lbl_PassFailDescription.TabIndex = 32;
			this.lbl_PassFailDescription.Text = "Pass Fail Description:";
			// 
			// rtb_PassFailDescription
			// 
			this.rtb_PassFailDescription.Location = new System.Drawing.Point(651, 116);
			this.rtb_PassFailDescription.Name = "rtb_PassFailDescription";
			this.rtb_PassFailDescription.Size = new System.Drawing.Size(165, 139);
			this.rtb_PassFailDescription.TabIndex = 33;
			this.rtb_PassFailDescription.Text = "";
			// 
			// cb_TestCase
			// 
			this.cb_TestCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_TestCase.FormattingEnabled = true;
			this.cb_TestCase.Location = new System.Drawing.Point(289, 10);
			this.cb_TestCase.Name = "cb_TestCase";
			this.cb_TestCase.Size = new System.Drawing.Size(137, 21);
			this.cb_TestCase.TabIndex = 34;
			// 
			// lbl_TestCase
			// 
			this.lbl_TestCase.AutoSize = true;
			this.lbl_TestCase.Location = new System.Drawing.Point(225, 15);
			this.lbl_TestCase.Name = "lbl_TestCase";
			this.lbl_TestCase.Size = new System.Drawing.Size(58, 13);
			this.lbl_TestCase.TabIndex = 35;
			this.lbl_TestCase.Text = "Test Case:";
			// 
			// Form_TestCaseDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 320);
			this.Controls.Add(this.cb_TestCase);
			this.Controls.Add(this.lbl_TestCase);
			this.Controls.Add(this.rtb_PassFailDescription);
			this.Controls.Add(this.lbl_PassFailDescription);
			this.Controls.Add(this.cb_ProjectList);
			this.Controls.Add(this.lbl_Project);
			this.Controls.Add(this.txt_TotalEstTime);
			this.Controls.Add(this.lbl_TotalEstTime);
			this.Controls.Add(this.lbl_RunTime);
			this.Controls.Add(this.lbl_CleanupTime);
			this.Controls.Add(this.lbl_SetupTime);
			this.Controls.Add(this.lbl_Instructions);
			this.Controls.Add(this.rtb_ShortDescription);
			this.Controls.Add(this.lbl_TCShortDescription);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.txt_BugzillaID);
			this.Controls.Add(this.mtb_SetupTime);
			this.Controls.Add(this.mtb_RunTime);
			this.Controls.Add(this.mtb_CleanupTime);
			this.Controls.Add(this.rtb_CleanupInstructions);
			this.Controls.Add(this.rtb_RunInstructions);
			this.Controls.Add(this.rtb_SetupInstructions);
			this.Controls.Add(this.cb_TCPriority);
			this.Controls.Add(this.lbl_SetupInstructions);
			this.Controls.Add(this.lbl_Run);
			this.Controls.Add(this.lbl_Cleanup);
			this.Controls.Add(this.lbl_BugzillaID);
			this.Controls.Add(this.lbl_TCPriority);
			this.Name = "Form_TestCaseDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Test Case Details - ";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Label lbl_TCPriority;
        private System.Windows.Forms.Label lbl_BugzillaID;
        private System.Windows.Forms.Label lbl_Cleanup;
        private System.Windows.Forms.Label lbl_Run;
        private System.Windows.Forms.Label lbl_SetupInstructions;
        private System.Windows.Forms.ComboBox cb_TCPriority;
        private System.Windows.Forms.RichTextBox rtb_SetupInstructions;
        private System.Windows.Forms.RichTextBox rtb_RunInstructions;
        private System.Windows.Forms.RichTextBox rtb_CleanupInstructions;
        private System.Windows.Forms.MaskedTextBox mtb_CleanupTime;
        private System.Windows.Forms.MaskedTextBox mtb_RunTime;
        private System.Windows.Forms.MaskedTextBox mtb_SetupTime;
		private System.Windows.Forms.TextBox txt_BugzillaID;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_TCShortDescription;
        private System.Windows.Forms.RichTextBox rtb_ShortDescription;
        private System.Windows.Forms.Label lbl_Instructions;
        private System.Windows.Forms.Label lbl_SetupTime;
        private System.Windows.Forms.Label lbl_CleanupTime;
        private System.Windows.Forms.Label lbl_RunTime;
        private System.Windows.Forms.Label lbl_TotalEstTime;
        private System.Windows.Forms.TextBox txt_TotalEstTime;
		private System.Windows.Forms.Label lbl_Project;
		private System.Windows.Forms.ComboBox cb_ProjectList;
		private System.Windows.Forms.Label lbl_PassFailDescription;
		private System.Windows.Forms.RichTextBox rtb_PassFailDescription;
		private System.Windows.Forms.ComboBox cb_TestCase;
		private System.Windows.Forms.Label lbl_TestCase;
    }
}