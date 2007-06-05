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
    public partial class Form_TestCaseDialog : Form
	{
		#region Variables
		IDataAccess DataAccess;
		DataSet projectDS;
		TestCase TC = new TestCase();
		int _projectID = -1;
		object[] _status = new object[] { "Passed", "Failed", "Not Run" };
		object[] _tcPriority = new object[] { 1, 2, 3, 4 };
		#endregion
		public Form_TestCaseDialog(IDataAccess DataAccess, string formTitle)
		{
			this.DataAccess = DataAccess;            InitializeComponent();
			this.Text = formTitle;
			FillComboBoxes();
		}

		public Form_TestCaseDialog(IDataAccess DataAccess, string formTitle, int ProjectID)
        {
			this.DataAccess = DataAccess;
			_projectID = ProjectID;
            InitializeComponent();
			this.Text = formTitle;
			FillComboBoxes();        }
		private void FillComboBoxes()
		{
			cb_TCPriority.Items.AddRange(_tcPriority);
			cb_TCPriority.SelectedIndex = 2;
			cb_TCStatus.Items.AddRange(_status);
			cb_TCStatus.SelectedIndex = 2;
			projectDS = DataAccess.ProjectRetrieve(null, null);

			if ((projectDS.Tables.Count > 0) && (projectDS.Tables["tcdb_projects"].Rows.Count > 0))
			{
				for (int i = 0; i < projectDS.Tables["tcdb_projects"].Rows.Count; i++)                {
					DataRow projectDR = projectDS.Tables["tcdb_projects"].Rows[i];
					cb_ProjectList.Items.Add(new Project(projectDR));
				}
			}

			if (_projectID > -1)
			{
				int i = 0;

				foreach (Project proj in cb_ProjectList.Items)
				{
					if (proj.ID == _projectID)
					{                        cb_ProjectList.SelectedIndex = i;
					}
					i++;
				}
			}
		}
		private void btn_Save_Click(object sender, EventArgs e)
		{            if (CheckFields())
			{
				try
				{
					Project proj = cb_ProjectList.SelectedItem as Project;
					if ((_projectID > -1) && (_projectID != proj.ID))
					{
						if (MessageBox.Show("Did you mean to change the project?", "Project Changed", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.OK)
						{
							_projectID = proj.ID;
						}
					}
					else
					{
						_projectID = proj.ID;
					}

					int tcPriority = Convert.ToInt32(cb_TCPriority.SelectedItem.ToString());
					string shortDescription = rtb_ShortDescription.Text.Trim();
					string setupDescription = rtb_SetupInstructions.Text.Trim();
					string runDescription = rtb_RunInstructions.Text.Trim();
					string cleanupDescription = rtb_CleanupInstructions.Text.Trim();
					int setupTime = Convert.ToInt32(mtb_SetupTime.Text.ToString());
					int runTime = Convert.ToInt32(mtb_RunTime.Text.ToString());
					int cleanupTime = Convert.ToInt32(mtb_CleanupTime.Text.ToString());
					string defectID = txt_BugzillaID.Text.Trim().ToString();
					string status = cb_TCStatus.SelectedItem as string;
					DataAccess.TestCaseInsert(_projectID, MFController._loggedInUser.UserName, tcPriority, shortDescription, setupTime, runTime, cleanupTime, "", defectID, status,
						setupDescription, runDescription, cleanupDescription);
					DialogResult = DialogResult.OK;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}            }
		}
		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private bool CheckFields()
		{
			if (rtb_ShortDescription.Text != "")
			{
				return true;
			}
			MessageBox.Show("Description field is empty", "Invalid Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
    }
}