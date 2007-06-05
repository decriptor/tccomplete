using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TestCaseComplete
{
	class Results
	{

	}

	public class ResultListViewItem : ListViewItem
	{
		#region Variables
		DataSet testCaseDS;
		int _projectID = -1;
		int _defaultPriority = -1;
		int _testCaseID = -1;
		int _buildID = -1;
		string _shortDescription = string.Empty;
		string _owner = string.Empty;
		int _totalRunTime = -1;
		int _resultID = -1;
		string _defectID = string.Empty;
		int _status = 0;
		string _statusDescription = string.Empty;
		string _updatedBy = string.Empty;
		string _updateTime = string.Empty;
		string _updateNotes = string.Empty;
		string _checkOutTime = string.Empty;
		#endregion

		public ResultListViewItem(DataRow resultsRow)
		{
			if (resultsRow != null)
			{
				_testCaseID = Convert.ToInt32(resultsRow["testcase_id"]);
				try
				{
					testCaseDS = Client.dataAccess.TestCaseRetrieve(_testCaseID, null);
					if ((testCaseDS.Tables.Count > 0) && (testCaseDS.Tables["testcases"].Rows.Count > 0))
					{
						DataRow testCaseRow = testCaseDS.Tables["testcases"].Rows[0];
                        //Test Case Row
                        _owner = testCaseRow["owner"].ToString();
                        _defaultPriority = Convert.ToInt32(testCaseRow["default_priority"]);
						_shortDescription = testCaseRow["short_description"].ToString();
						_statusDescription = testCaseRow["status_description"].ToString();
						CalcTotalRunTime(Convert.ToInt32(testCaseRow["stup_time"]), Convert.ToInt32(testCaseRow["run_time"]),
							Convert.ToInt32(testCaseRow["clean_time"]));
						//Results Row
                        _resultID = Convert.ToInt32(resultsRow["id"]);
						_buildID = Convert.ToInt32(resultsRow["build_id"]);
                        _status = Convert.ToInt32(resultsRow["status"]);
                        _updatedBy = resultsRow["updated_by"].ToString();
                        _updateTime = resultsRow["update_time"].ToString();
                        _updateNotes = resultsRow["update_notes"].ToString();
                        _defectID = resultsRow["bug_id"].ToString();
						_checkOutTime = resultsRow["checkout_time"].ToString();
						SetOption();
						BuildSubItems();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
                    throw ex;
				}

			}
		}


		public ResultListViewItem(DataRow resultsRow, int ProjectID)
		{
			_projectID = ProjectID;
			if (resultsRow != null)
			{
				try
				{
					testCaseDS = Client.dataAccess.TestCaseRetrieve(Convert.ToInt32(resultsRow["testcase_id"]), ProjectID);
					if ((testCaseDS.Tables.Count > 0) && (testCaseDS.Tables["testcases"].Rows.Count > 0))
					{
						DataRow testCaseRow = testCaseDS.Tables["testcases"].Rows[0];
                        //Test Case Row
                        _testCaseID = Convert.ToInt32(testCaseRow["id"]);
                        _owner = testCaseRow["owner"].ToString();
						_defaultPriority = Convert.ToInt32(testCaseRow["default_priority"]);
						_shortDescription = testCaseRow["short_description"].ToString();
						CalcTotalRunTime(Convert.ToInt32(testCaseRow["setup_time"]), Convert.ToInt32(testCaseRow["run_time"]),
							Convert.ToInt32(testCaseRow["clean_time"]));
                        //Results Row
                        _resultID = Convert.ToInt32(resultsRow["id"]);
						_buildID = Convert.ToInt32(resultsRow["build_id"]);
						_status = Convert.ToInt32(resultsRow["status"].ToString());
						_updatedBy = resultsRow["updated_by"].ToString();
						_updateTime = resultsRow["update_time"].ToString();
						_updateNotes = resultsRow["update_notes"].ToString();
                        _defectID = resultsRow["bug_id"].ToString();
						_checkOutTime = resultsRow["checkout_time"].ToString();
						SetOption();
						BuildSubItems();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void BuildSubItems()
		{
			this.SubItems.Add(_shortDescription);
			this.SubItems.Add(_totalRunTime.ToString());
			this.SubItems.Add(_defectID.ToString());
			this.SubItems.Add(this.CheckedOut);
			this.SubItems.Add(_updatedBy);
			this.SubItems.Add(_updateTime);
			this.SubItems.Add(_updateNotes);
			this.SubItems.Add(this.sStatus);
		}

		private void SetOption()
		{
			//string toolTip = 
			this.Text = _defaultPriority.ToString();
			//this.ToolTipText = 
		}

		private void CalcTotalRunTime(int Setup, int Run, int Clean)
		{
			_totalRunTime = Setup + Run + Clean;
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

		public int TestCaseID
		{
			get { return _testCaseID; }
		}

		public int ProjectID
		{
			get { return _projectID; }
		}

		public string Owner
		{
			get { return _owner; }
		}

		public string PassFailDescription
		{
			get { return _statusDescription; }
		}

		public int Priority
		{
			get { return _defaultPriority; }
		}

		public string Description
		{
			get { return _shortDescription; }
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
				return "Not Run";
			}
		}

		public int TotalRunTime
		{
			get { return _totalRunTime; }
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
		
		public string CheckedOut
		{
			get
			{
				if (_checkOutTime == "")
				{
					return "Checked In";
				}
				else
				{
					return _updatedBy;
				}
			}
		}
		#endregion
	}
}
