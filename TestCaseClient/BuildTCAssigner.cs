using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestCaseComplete
{
    public partial class Form_BuildTCAssigner : Form
	{
		#region Variables
		int _projectID = -1;
		int _buildID = -1;
		bool _editMode = false;
		DataSet testCaseDS;
		#endregion

		public Form_BuildTCAssigner()
		{
			_editMode = true;
			InitializeComponent();
			FillProjectBox();
		}

		public Form_BuildTCAssigner(int ProjectID, int BuildID)
		{
			_projectID = ProjectID;
			_buildID = BuildID;
			InitializeComponent();
			FillWindows(ProjectID, BuildID);
		}

		private void FillProjectBox()
		{
			DataSet projectDS = Client.dataAccess.ProjectRetrieve(null, null);
			if ((projectDS.Tables.Count > 0) && (projectDS.Tables["projects"].Rows.Count > 0))
			{
				for (int i = 0; i < projectDS.Tables["projects"].Rows.Count; i++)
				{
					DataRow projectDR = projectDS.Tables["projects"].Rows[i];
					cb_Project.Items.Add(new Project(projectDR));
				}
			}
		}

		private void FillWindows()
		{
			_projectID = (cb_Project.SelectedItem as Project).ID;
			_buildID = (cb_Build.SelectedItem as Build).ID;

			try
			{
				testCaseDS = Client.dataAccess.TestCaseRetrieve(null, _projectID);
				if ((testCaseDS.Tables.Count > 0) && (testCaseDS.Tables["testcases"].Rows.Count > 0))
				{
					lsv_TCWindow.Items.Clear();
					for (int i = 0; i < testCaseDS.Tables["testcases"].Rows.Count; i++)
					{
						lsv_TCWindow.Items.Add(new TestCaseListViewItem(testCaseDS.Tables["testcases"].Rows[i], true));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			CheckForResult();
		}

		private void CheckForResult()
		{
			foreach (TestCaseListViewItem item in lsv_TCWindow.Items)
			{
				DataSet resultDS = Client.dataAccess.ResultsRetrieve(null, item.TestCaseID, _buildID, null, null, null, null, null);
				if ((resultDS.Tables.Count > 0) && (resultDS.Tables["results"].Rows.Count > 0))
				{
					item.Checked = true;
				}
			}
		}

		private void FillWindows(int ProjectID, int BuildID)
		{
			try
			{
				DataSet projectDS = Client.dataAccess.ProjectRetrieve(ProjectID, null);
				if (projectDS != null)
				{
					DataRow projectDR = projectDS.Tables["projects"].Rows[0];
					cb_Project.Text = projectDR["name"].ToString();
				}
				DataSet buildDS = Client.dataAccess.BuildRetrieve(BuildID, ProjectID, null);
				if (buildDS != null)
				{
					DataRow buildDR = buildDS.Tables["builds"].Rows[0];
					cb_Build.Text = buildDR["name"].ToString();
				}
				testCaseDS = Client.dataAccess.TestCaseRetrieve(null, ProjectID);
				if ((testCaseDS.Tables.Count > 0) && (testCaseDS.Tables["testcases"].Rows.Count > 0))
				{
					lsv_TCWindow.Items.Clear();
					for (int i = 0; i < testCaseDS.Tables["testcases"].Rows.Count; i++)
					{
						lsv_TCWindow.Items.Add(new TestCaseListViewItem(testCaseDS.Tables["testcases"].Rows[i], true));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			cb_Project.Enabled = false;
			cb_Build.Enabled = false;
		}

		private void btn_SelectAll_Click(object sender, EventArgs e)
		{
			foreach (TestCaseListViewItem lvi in lsv_TCWindow.Items)
			{
				lvi.Checked = true;
			}
		}

		private void btn_SelectNone_Click(object sender, EventArgs e)
		{
			foreach (TestCaseListViewItem lvi in lsv_TCWindow.Items)
			{
				lvi.Checked = false;
			}
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			if (!_editMode)
			{
				int i = 0;
				foreach (TestCaseListViewItem lvi in lsv_TCWindow.Items)
				{
					if (lvi.Checked == true)
					{
						try
						{
							Client.dataAccess.ResultsInsert(lvi.TestCaseID, _buildID, "0", MFController._loggedInUser.UserName, "", lvi.DefectID);
							i++;
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message);
						}
					}
				}
				MessageBox.Show(i + " Test Cases added to results table");
			}
			this.Close();
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("All Changes will be lost/nAre you sure you want to exit?", "Unsaved Data",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void cb_Project_SelectedIndexChanged(object sender, EventArgs e)
		{
			cb_Build.Items.Clear();
			lsv_TCWindow.Items.Clear();
			Project selectedProject = cb_Project.SelectedItem as Project;
			DataSet buildDS = Client.dataAccess.BuildRetrieve(null, selectedProject.ID, null);
			if ((buildDS.Tables.Count > 0) && (buildDS.Tables["builds"].Rows.Count > 0))
			{
				for (int i = 0; i < buildDS.Tables["builds"].Rows.Count; i++)
				{
					DataRow buildsDR = buildDS.Tables["builds"].Rows[i];
					cb_Build.Items.Add(new Build(buildsDR));
				}
			}
			cb_Build.SelectedIndex = 0;
			CheckStateEventUnregister();
			FillWindows();
			CheckStateEventRegister();
		}

		private void cb_Build_SelectedIndexChanged(object sender, EventArgs e)
		{
			CheckStateEventUnregister();
			FillWindows();
			CheckStateEventRegister();
		}

		private void lsv_TCWindow_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			int junk = _buildID;
			TestCaseListViewItem TCLVI = e.Item as TestCaseListViewItem;
			if (TCLVI.Checked == true)
			{
				Client.dataAccess.ResultsInsert(TCLVI.TestCaseID, _buildID, "0", MFController._loggedInUser.UserName, "", TCLVI.DefectID);
			}
			else if (TCLVI.Checked == false)
			{
				Client.dataAccess.ResultsDelete(TCLVI.TestCaseID, _buildID);
			}
			else
			{
				MessageBox.Show("It appears that something has gone horribly wrong");
			}
		}

		internal void CheckStateEventRegister()
		{
			this.lsv_TCWindow.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lsv_TCWindow_ItemChecked);
		}

		internal void CheckStateEventUnregister()
		{
			this.lsv_TCWindow.ItemChecked -= new System.Windows.Forms.ItemCheckedEventHandler(this.lsv_TCWindow_ItemChecked);
		}
    }
}