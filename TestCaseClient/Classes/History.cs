using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TestCaseComplete
{
	class History
	{


	}
	
	class HistoryListViewItem : ListViewItem
	{
		#region Variables
		int _resultID = -1;
		string _time = null;
		string _userName = string.Empty;
		int _status = 0;
		string _defectID = string.Empty;

		DataSet resultsDS;
		int _buildID = -1;
		string _updatedBy = string.Empty;
		string _updateTime = string.Empty;
		string _updateNotes = string.Empty;
		#endregion

		public HistoryListViewItem(DataRow historyRow)
		{
			if (historyRow != null)
			{
				try
				{
					_resultID = Convert.ToInt32(historyRow["results_id"]);
					_time = historyRow["time"].ToString();
					_userName = historyRow["username"].ToString();
					_status = Convert.ToInt32(historyRow["status"]);
					_defectID = historyRow["defect_id"].ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				if (_status == 2)
				{
					try
					{
						resultsDS = Client.dataAccess.ResultsRetrieve(_resultID, null, null, null, null, null, null, null);
						if ((resultsDS.Tables.Count > 0) && (resultsDS.Tables["results"].Rows.Count > 0))
						{
							DataRow resultsRow = resultsDS.Tables["results"].Rows[0];
							_buildID = Convert.ToInt32(resultsRow["build_id"]);
							_updatedBy = resultsRow["updated_by"].ToString();
							_updateTime = resultsRow["update_time"].ToString();
							_updateNotes = resultsRow["update_notes"].ToString();
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
				SetOption();
				BuildSubItems();
			}
		}

		private void BuildSubItems()
		{
			this.SubItems.Add(_userName);
			this.SubItems.Add(this.sStatus);
			this.SubItems.Add(_defectID);
			this.SubItems.Add(_time);
		}

		private void SetOption()
		{
			this.Text = _resultID.ToString();
		}

		#region GETS
		public int ID
		{
			get { return _resultID; }
		}

		public int BuildID
		{
			get { return _buildID; }
		}

		public string DefectID
		{
			get { return _defectID; }
		}

		public int iStatus
		{
			get { return _status; }
		}

		public string sStatus
		{
			get
			{
				if (_status == 1)
				{
					return "Passes";
				}
				else if (_status == -1)
				{
					return "Failed";
				}
				else if (_status == 2)
				{
					return "Deleted";
				}
				return "Not Run";
			}
		}

		public string UpdatedBy
		{
			get { return _updatedBy; }
		}

		public string UpdateTime
		{
			get { return _updateTime; }
		}

		public string UpdatedNotes
		{
			get { return _updateNotes; }
		}

		public string HistoryTime
		{
			get { return _time; }
		}

		public string UserName
		{
			get { return _userName; }
		}

		#endregion
	}
}
