namespace TestCaseComplete
{
    partial class Form_BuildEditor
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
        {            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_project = new System.Windows.Forms.Label();
            this.lbl_build = new System.Windows.Forms.Label();
            this.cb_Build = new System.Windows.Forms.ComboBox();
            this.cb_Project = new System.Windows.Forms.ComboBox();
            this.lsv_TCWindow = new System.Windows.Forms.ListView();
            this.Test_Case_Name = new System.Windows.Forms.ColumnHeader();
            this.Assigned = new System.Windows.Forms.ColumnHeader();
            this.btn_Edit = new System.Windows.Forms.Button();            this.SuspendLayout();
            //             // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(319, 653);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(400, 653);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
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
            this.cb_Build.FormattingEnabled = true;
            this.cb_Build.Location = new System.Drawing.Point(239, 12);
            this.cb_Build.Name = "cb_Build";
            this.cb_Build.Size = new System.Drawing.Size(121, 21);
            this.cb_Build.TabIndex = 4;
            // 
            // cb_Project
            // 
            this.cb_Project.FormattingEnabled = true;
            this.cb_Project.Location = new System.Drawing.Point(61, 12);
            this.cb_Project.Name = "cb_Project";
            this.cb_Project.Size = new System.Drawing.Size(121, 21);
            this.cb_Project.TabIndex = 5;
            // 
            // lsv_TCWindow
            // 
            this.lsv_TCWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsv_TCWindow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Test_Case_Name,
            this.Assigned});
            this.lsv_TCWindow.GridLines = true;
            this.lsv_TCWindow.Location = new System.Drawing.Point(15, 52);
            this.lsv_TCWindow.MultiSelect = false;
            this.lsv_TCWindow.Name = "lsv_TCWindow";
            this.lsv_TCWindow.ShowItemToolTips = true;
            this.lsv_TCWindow.Size = new System.Drawing.Size(458, 566);
            this.lsv_TCWindow.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsv_TCWindow.TabIndex = 6;
            this.lsv_TCWindow.UseCompatibleStateImageBehavior = false;
            this.lsv_TCWindow.View = System.Windows.Forms.View.Details;
            // 
            // Test_Case_Name
            // 
            this.Test_Case_Name.Text = "Test Case Name";
            this.Test_Case_Name.Width = 394;
            // 
            // Assigned
            // 
            this.Assigned.Text = "Assigned";
            this.Assigned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(400, 624);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 7;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // Form_BuildTCEditor
            //             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 681);
            this.Controls.Add(this.btn_Edit);            this.Controls.Add(this.lsv_TCWindow);
            this.Controls.Add(this.cb_Project);
            this.Controls.Add(this.cb_Build);
            this.Controls.Add(this.lbl_build);
            this.Controls.Add(this.lbl_project);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_BuildTCEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Build TC Editor";
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
        private System.Windows.Forms.ListView lsv_TCWindow;        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.ColumnHeader Test_Case_Name;
        private System.Windows.Forms.ColumnHeader Assigned;
    }
}