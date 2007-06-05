using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestCaseComplete
{
	public partial class Form_HistoryViewer : Form
	{
		#region Variables
		List<HistoryListViewItem> history;
		#endregion

		public Form_HistoryViewer()
		{
			InitializeComponent();
			RefreshHistoryView();
		}

		private void RefreshHistoryView()
		{
			history = new List<HistoryListViewItem>();
			DataSet HistoryDS;
			try
			{
				HistoryDS = Client.dataAccess.HistoryRetrieve(null, null, null, null, null);
			    if ((HistoryDS.Tables.Count > 0) && (HistoryDS.Tables["history"].Rows.Count > 0))
			    {
			        for (int i = 0; i < HistoryDS.Tables["history"].Rows.Count; i++)
			        {
			            //DataRow historyDR = HistoryDS.Tables["tcdb_history"].Rows[i];
						history.Add(new HistoryListViewItem(HistoryDS.Tables["history"].Rows[i]));
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
			lsv_HistoryWindow.Items.Clear();
			lsv_HistoryWindow.Items.AddRange(history.ToArray());
		}

		private void lsv_HistoryWindow_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			//e.Column;
			//lsv_HistoryWindow.Columns.
		}

	}
}