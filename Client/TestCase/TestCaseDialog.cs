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
		DataSet projectDS;
		bool _editMode = false;
		int _projectID = -1;
		int _testCaseID = -1;
		object[] _tcPriority = new object[] { 1, 2, 3, 4 };
		#endregion

		public Form_TestCaseDialog()
		{
			InitializeComponent();
			this.Text = "Create Test Case Dialog";
			lbl_TestCase.Visible = false;
			cb_TestCase.Visible = false;
			FillComboBoxes();
		}

		public Form_TestCaseDialog(int TestCaseID, int ProjectID)
		{
			_testCaseID = TestCaseID;
			_projectID = ProjectID;
			_editMode = true;
			InitializeComponent();
			this.Text = "Edit Test Case Dialog";
			cb_ProjectList.Items.Add(_projectID.ToString());
			cb_TestCase.Items.Add(_testCaseID.ToString());
			FillTestCaseDialog();
		}

		private void FillTestCaseDialog()
		{
			cb_ProjectList.SelectedIndex = 0;
			cb_TestCase.SelectedIndex = 0;
			cb_TCPriority.Items.AddRange(_tcPriority);
			try
			{
				DataSet testCaseDS = Client.dataAccess.TestCaseRetrieve(_testCaseID, null);
				if ((testCaseDS.Tables.Count > 0) && (testCaseDS.Tables["testcases"].Rows.Count > 0))
				{
					for (int i = 0; i < testCaseDS.Tables["testcases"].Rows.Count; i++)
					{
						DataRow testCaseDR = testCaseDS.Tables["testcases"].Rows[i];

						cb_TCPriority.SelectedIndex = (Convert.ToInt32(testCaseDR["default_priority"]) - 1);
						txt_BugzillaID.Text = testCaseDR["defect_id"].ToString();
						rtb_ShortDescription.Text = testCaseDR["short_description"].ToString();
						rtb_SetupInstructions.Text = testCaseDR["setup_steps"].ToString();
						rtb_RunInstructions.Text = testCaseDR["run_steps"].ToString();
						rtb_CleanupInstructions.Text = testCaseDR["clean_steps"].ToString();
						mtb_SetupTime.Text = testCaseDR["setup_time"].ToString();
						mtb_RunTime.Text = testCaseDR["run_time"].ToString();
						mtb_CleanupTime.Text = testCaseDR["clean_time"].ToString();
						rtb_PassFailDescription.Text = testCaseDR["status_description"].ToString();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void FillComboBoxes()
		{
			cb_TCPriority.Items.AddRange(_tcPriority);
			cb_TCPriority.SelectedIndex = 2;

			projectDS = Client.dataAccess.ProjectRetrieve(null, null);
			if ((projectDS.Tables.Count > 0) && (projectDS.Tables["projects"].Rows.Count > 0))
			{
				for (int i = 0; i < projectDS.Tables["projects"].Rows.Count; i++)
				{
					DataRow projectDR = projectDS.Tables["projects"].Rows[i];
					cb_ProjectList.Items.Add(new Project(projectDR));
				}
			}
			if (_projectID > -1)
			{
				int i = 0;
				foreach (Project proj in cb_ProjectList.Items)
				{
					if (proj.ID == _projectID)
					{
						cb_ProjectList.SelectedIndex = i;
					}
					i++;
				}
			}
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			if (CheckFields())
			{
				if (!_editMode)
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
				string status = rtb_PassFailDescription.Text.Trim();

				try
				{
					if (_editMode)
					{
						Client.dataAccess.TestCaseUpdate(_testCaseID, _projectID, MFController._loggedInUser.UserName, Convert.ToInt32(cb_TCPriority.Text),
							shortDescription, setupTime, runTime, cleanupTime, "", defectID, status, setupDescription, runDescription,
							cleanupDescription);
					}
					else
					{
						Client.dataAccess.TestCaseInsert(_projectID, MFController._loggedInUser.UserName, tcPriority, shortDescription,
							setupTime, runTime, cleanupTime, "", defectID, status, setupDescription, runDescription, cleanupDescription);
					}
					DialogResult = DialogResult.OK;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
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