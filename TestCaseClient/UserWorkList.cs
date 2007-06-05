using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestCaseComplete
{
	public partial class Form_UserWorkList : Form
	{
		#region Variables
		List<ResultListViewItem> buildResults;

		#endregion

		public Form_UserWorkList()
		{
			InitializeComponent();
		}

		private void UserWorkList_Load(object sender, EventArgs e)
		{
			RefreshResultsView();
		}

		private void RefreshResultsView()
		{
			buildResults = new List<ResultListViewItem>();
			DataSet workListDS;
			try
			{
				workListDS = Client.dataAccess.WorkListRetrieve(MFController._loggedInUser.UserName);
				if ((workListDS.Tables.Count > 0) && (workListDS.Tables["results"].Rows.Count > 0))
				{
					for (int i = 0; i < workListDS.Tables["results"].Rows.Count; i++)
					{
						DataRow resultsDR = workListDS.Tables["results"].Rows[i];
						buildResults.Add(new ResultListViewItem(resultsDR));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			BuildListView();
		}

		private void BuildListView()
		{
			lsv_WorkListWindow.Items.Clear();
			lsv_WorkListWindow.Items.AddRange(buildResults.ToArray());
		}

		private void SMI_UpdateResult_Click(object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection results = lsv_WorkListWindow.SelectedItems;

			if ((results != null) && (results.Count == 1))
			{
				foreach (ResultListViewItem result in results)
				{
					Form_UpdateResultDialog URD = new Form_UpdateResultDialog(result);
					if (URD.ShowDialog() == DialogResult.OK)
					{
						MessageBox.Show("Result updated successfully");
						RefreshResultsView();
					}
				}
			}			
		}

		private void SMI_RemoveResult_Click(object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection results = lsv_WorkListWindow.SelectedItems;

			if ((results != null) && (results.Count > 0))
			{
				foreach (ResultListViewItem result in results)
				{
					Client.dataAccess.ResultsCheckIn(result.ID, result.iStatus, MFController._loggedInUser.UserName, result.UpdatedNotes);
					RefreshResultsView();
				}
			}
		}

	}
}