namespace TestCaseComplete
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.lLoginName = new System.Windows.Forms.Label();
            this.tbLoginName = new System.Windows.Forms.TextBox();
            this.lLoginPwd = new System.Windows.Forms.Label();
            this.bLogin = new System.Windows.Forms.Button();
            this.tbLoginPwd = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lLoginName
            // 
            this.lLoginName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lLoginName.AutoSize = true;
            this.lLoginName.BackColor = System.Drawing.Color.Transparent;
            this.lLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLoginName.ForeColor = System.Drawing.SystemColors.Window;
            this.lLoginName.Location = new System.Drawing.Point(195, 225);
            this.lLoginName.Name = "lLoginName";
            this.lLoginName.Size = new System.Drawing.Size(95, 16);
            this.lLoginName.TabIndex = 0;
            this.lLoginName.Text = "Login Name:";
            // 
            // tbLoginName
            // 
            this.tbLoginName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoginName.Location = new System.Drawing.Point(296, 224);
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.Size = new System.Drawing.Size(146, 20);
            this.tbLoginName.TabIndex = 1;
            // 
            // lLoginPwd
            // 
            this.lLoginPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lLoginPwd.AutoSize = true;
            this.lLoginPwd.BackColor = System.Drawing.Color.Transparent;
            this.lLoginPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLoginPwd.ForeColor = System.Drawing.SystemColors.Window;
            this.lLoginPwd.Location = new System.Drawing.Point(195, 251);
            this.lLoginPwd.Name = "lLoginPwd";
            this.lLoginPwd.Size = new System.Drawing.Size(80, 16);
            this.lLoginPwd.TabIndex = 2;
            this.lLoginPwd.Text = "Password:";
            // 
            // bLogin
            // 
            this.bLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bLogin.BackColor = System.Drawing.Color.Transparent;
            this.bLogin.Location = new System.Drawing.Point(312, 276);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(62, 31);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "L&ogin";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tbLoginPwd
            // 
            this.tbLoginPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoginPwd.Location = new System.Drawing.Point(296, 250);
            this.tbLoginPwd.Name = "tbLoginPwd";
            this.tbLoginPwd.PasswordChar = '*';
            this.tbLoginPwd.Size = new System.Drawing.Size(146, 20);
            this.tbLoginPwd.TabIndex = 3;
            this.tbLoginPwd.UseSystemPasswordChar = true;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.BackColor = System.Drawing.Color.Transparent;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(380, 276);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(62, 31);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "&Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bLoginCancel_Click);
            // 
            // form_login
            // 
            this.AcceptButton = this.bLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(454, 319);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tbLoginPwd);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.lLoginPwd);
            this.Controls.Add(this.tbLoginName);
            this.Controls.Add(this.lLoginName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "login";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLoginName;
        private System.Windows.Forms.TextBox tbLoginName;
        private System.Windows.Forms.Label lLoginPwd;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox tbLoginPwd;
        private System.Windows.Forms.Button bCancel;
    }
}