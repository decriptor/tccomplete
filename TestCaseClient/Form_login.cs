using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using tccomplete.Interfaces;

namespace TestCaseComplete
{
    public partial class Form_login : Form
    {
        #region Variables
        internal UserCredentials loggedInUser;
        String URL = @"tcp://localhost:8080/DataAccess";
        IDataAccess dataAccess;
        DataSet userDS;
        #endregion

        public Form_login()
        {
            try
            {
                dataAccess = (IDataAccess)Activator.GetObject(typeof(IDataAccess), URL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            InitializeComponent();			
        }

        private void bLoginCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if ((tbLoginName.Text != "") && (tbLoginPwd.Text != ""))
            {
                CheckUserCredentials();
            }
            else
            {
                MessageBox.Show("User Name or Password is blank", "Invalid User Name or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckUserCredentials()
        {
            string sName = tbLoginName.Text.Trim();
            string sPwd = tbLoginPwd.Text.Trim();

            try
            {
                userDS = dataAccess.UserLogin(sName, sPwd);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            if ((userDS != null) && (userDS.Tables.Count > 0) && (userDS.Tables["users"].Rows.Count > 0))
            {
                DataRow userRow = userDS.Tables["users"].Rows[0];
                loggedInUser = new UserCredentials(userRow);
                if (loggedInUser.isUserValid)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed: Invalid User", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}