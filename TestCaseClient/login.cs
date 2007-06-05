using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestCaseComplete
{
    public partial class login : Form
    {
        public String sLoginName, sLoginPwd;

        public login()
        {
            sLoginName = "";
            sLoginPwd = "";
            InitializeComponent();
        }

        private void bLoginCancel_Click(object sender, EventArgs e)
        {
            sLoginName = sLoginPwd = "";
            this.Close();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if ((tbLoginName.Text != "") && (tbLoginPwd.Text != ""))
            {
                sLoginName = tbLoginName.Text.Trim();
                sLoginPwd = tbLoginPwd.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("User Name or Password is blank", "Invalid User Name or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}