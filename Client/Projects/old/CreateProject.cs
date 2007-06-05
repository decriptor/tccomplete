using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tccomplete.Interfaces;

namespace TestCaseComplete
{
    public partial class Form_CreateProject : Form
    {
        IDataAccess DataAccess;
        public Form_CreateProject(IDataAccess DataAccess)
            InitializeComponent();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if ((txt_ProjectName.Text != "") && (rtb_ProjectDescription.Text != ""))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
             }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}