using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestCaseComplete
{
	public partial class Form_BuildDialog : Form
	{
		#region Variables
		DataSet projectDS;
		#endregion

		public Form_BuildDialog()
		{
			InitializeComponent();
			InitializeFields();
		}

		private void InitializeFields()
		{
			projectDS = Client.dataAccess.ProjectRetrieve(null, null);
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
			if (!CheckIfBuildExists())
			{
				Client.dataAccess.BuildInsert(selectedProject.ID, txt_BuildNumber.Text.Trim(), rtb_BuildDesc.Text.Trim(), buildhide);
				int buildID = GetBuildID(selectedProject.ID);
				AddTestCasesToBuild(selectedProject.ID, buildID);
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("This build already exists");
			}
        }

		private void AddTestCasesToBuild(int projectID, int buildID)
		{
			Form_BuildTCAssigner BTCE = new Form_BuildTCAssigner(projectID, buildID);
			BTCE.ShowDialog();
		}

		private int GetBuildID(int projectID)
		{
			DataSet buildDS = Client.dataAccess.BuildRetrieve(null, projectID, txt_BuildNumber.Text.Trim());
			DataRow buildIDRow = buildDS.Tables["builds"].Rows[0];
			return Convert.ToInt32(buildIDRow[0]);
		}

		private bool CheckIfBuildExists()
		{
			DataSet buildDS = Client.dataAccess.BuildRetrieve(null, null, txt_BuildNumber.Text.Trim());
			if ((buildDS.Tables.Count > 0) && (buildDS.Tables["builds"].Rows.Count > 0))
			{
				return true;
			}
			return false;
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}