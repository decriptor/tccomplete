using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tccomplete.Interfaces;

namespace TestCaseComplete
{
	public partial class Form_BuildDialog : Form
	{
		#region Variables
		IDataAccess DataAccess;
		DataSet projectDS;
		#endregion        
		public Form_BuildDialog(IDataAccess DataAccess)
		{
			this.DataAccess = DataAccess;
			InitializeComponent();
			InitializeFields();
		}
		private void InitializeFields()
		{
			projectDS = DataAccess.ProjectRetrieve(null, null);
			if ((projectDS.Tables.Count > 0) && (projectDS.Tables["projects"].Rows.Count > 0))
			{
				for (int i = 0; i < projectDS.Tables["projects"].Rows.Count; i++)
				{
					DataRow projectDR = projectDS.Tables["projects"].Rows[i];
					cb_ProjectList.Items.Add(new Project(projectDR));
				}
			}
		}
		private void btn_Save_Click(object sender, EventArgs e)
        {
            Project selectedProject = cb_ProjectList.SelectedItem as Project;
            if(selectedProject == null)
            {
				MessageBox.Show("All fields must be filled in", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int buildhide = (chb_BuildHide.Checked == true ? 0 : 1);
			DataAccess.BuildInsert(selectedProject.ID, txt_BuildNumber.Text.Trim(), rtb_BuildDesc.Text.Trim(), buildhide);
            DialogResult = DialogResult.OK;
            this.Close();
        }
		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}