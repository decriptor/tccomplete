namespace TestCaseComplete
{
    partial class MainInterface
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tv_ProjectBuild = new System.Windows.Forms.TreeView();
            this.lsv_TestCaseWindow = new System.Windows.Forms.ListView();
            this.lsv_Status = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tv_ProjectBuild
            // 
            this.tv_ProjectBuild.Dock = System.Windows.Forms.DockStyle.Left;
            this.tv_ProjectBuild.Location = new System.Drawing.Point(0, 0);
            this.tv_ProjectBuild.Name = "tv_ProjectBuild";
            this.tv_ProjectBuild.Size = new System.Drawing.Size(174, 620);
            this.tv_ProjectBuild.TabIndex = 0;
            // 
            // lsv_TestCaseWindow
            // 
            this.lsv_TestCaseWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_TestCaseWindow.Location = new System.Drawing.Point(174, 0);
            this.lsv_TestCaseWindow.Name = "lsv_TestCaseWindow";
            this.lsv_TestCaseWindow.Size = new System.Drawing.Size(627, 620);
            this.lsv_TestCaseWindow.TabIndex = 1;
            this.lsv_TestCaseWindow.UseCompatibleStateImageBehavior = false;
            // 
            // lsv_Status
            // 
            this.lsv_Status.Dock = System.Windows.Forms.DockStyle.Right;
            this.lsv_Status.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsv_Status.Location = new System.Drawing.Point(801, 0);
            this.lsv_Status.MultiSelect = false;
            this.lsv_Status.Name = "lsv_Status";
            this.lsv_Status.Scrollable = false;
            this.lsv_Status.ShowItemToolTips = true;
            this.lsv_Status.Size = new System.Drawing.Size(150, 620);
            this.lsv_Status.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsv_Status.TabIndex = 2;
            this.lsv_Status.UseCompatibleStateImageBehavior = false;
            this.lsv_Status.View = System.Windows.Forms.View.Details;
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lsv_TestCaseWindow);
            this.Controls.Add(this.lsv_Status);
            this.Controls.Add(this.tv_ProjectBuild);
            this.Name = "MainInterface";
            this.Size = new System.Drawing.Size(951, 620);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv_ProjectBuild;
        private System.Windows.Forms.ListView lsv_TestCaseWindow;
        private System.Windows.Forms.ListView lsv_Status;
    }
}
