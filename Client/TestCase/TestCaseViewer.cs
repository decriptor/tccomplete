using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestCaseComplete
{
	public partial class Form_TestCaseViewer : Form
	{
		#region Variables
		int _projectID = -1;
		int _selectTestCaseID = -1;
		#endregion
		public Form_TestCaseViewer()
		{
			InitializeComponent();
			FillProjectBox();
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
			cb_Project.SelectedIndex = 0;
		}
		
		private void cb_Project_SelectedIndexChanged(object sender, EventArgs e)
		{
			_projectID = (cb_Project.SelectedItem as Project).ID;
			RefreshListView();
		}

		private void RefreshListView()
		{
			lsv_TCWindow.Items.Clear();
			try
			{
				DataSet testCaseDS = Client.dataAccess.TestCaseRetrieve(null, _projectID);
				if ((testCaseDS.Tables.Count > 0) && (testCaseDS.Tables["testcases"].Rows.Count > 0))
				{
					lsv_TCWindow.Items.Clear();
					for (int i = 0; i < testCaseDS.Tables["testcases"].Rows.Count; i++)
					{
						lsv_TCWindow.Items.Add(new TestCaseListViewItem(testCaseDS.Tables["testcases"].Rows[i], false));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_Edit_Click(object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection testCases = lsv_TCWindow.SelectedItems;
			if ((testCases != null) && (testCases.Count == 1))
			{
				foreach (TestCaseListViewItem testCase in testCases)
				{
					_selectTestCaseID = (testCase as TestCaseListViewItem).TestCaseID;
				}
				Form_TestCaseDialog TCD = new Form_TestCaseDialog(_selectTestCaseID, _projectID);
				if (TCD.ShowDialog() == DialogResult.OK)
				{
					RefreshListView();
				}
			}
			else
			{
				MessageBox.Show("A testcase must be selected first");
			}
		}
		
		private void btn_Close_Click(object sender, EventArgs e)
		{
			this.Close();		
		}

	}
}