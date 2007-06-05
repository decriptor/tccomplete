using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using tccomplete.Interfaces;

namespace TestCaseComplete
{
	class TestCase
	{
		#region Variables
		int _tcID = -1;
		int _projectID = -1;
		string _owner = string.Empty;
		string _description = string.Empty;
		string _tcPriority = string.Empty;
		string _setupDescription = string.Empty;
		string _runDescription = string.Empty;
		string _cleanupDescription = string.Empty;
		int _setupTime = -1;
		int _runTime = -1;
		int _cleanupTime = -1;
		int _totalRunTime = -1;
        string _userID = string.Empty;
		string _bugID = string.Empty;
		string _status = string.Empty;
		#endregion

		public TestCase(DataRow testCaseDR)
		{
			try
			{
				_tcID = Convert.ToInt32(testCaseDR["id"]);
				_projectID = Convert.ToInt32(testCaseDR["project_id"]);
				_owner = testCaseDR["owner"].ToString();
				_tcPriority = testCaseDR["default_priority"].ToString();
				_description = testCaseDR["short_description"].ToString();
				_setupTime = Convert.ToInt32(testCaseDR["setup_time"]);
				_runTime = Convert.ToInt32(testCaseDR["run_time"]);
				_cleanupTime = Convert.ToInt32(testCaseDR["clean_time"]);
				_bugID = testCaseDR["defect_id"].ToString();
                _userID = testCaseDR["user_id"].ToString();
				_status = testCaseDR["status_description"].ToString();
				_setupDescription = testCaseDR["setup_steps"].ToString();
				_runDescription = testCaseDR["run_steps"].ToString();
				_cleanupDescription = testCaseDR["clean_steps"].ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			CalcTotalRunTime(_setupTime, _runTime, _cleanupTime);
		}

		private void CalcTotalRunTime(int Setup, int Run, int Clean)
		{
			_totalRunTime = Setup + Run + Clean;
		}

		#region GETS/SETS
		public int TestCaseID
		{
			get { return _tcID; }
		}

		public int ProjectID
		{
			get { return _projectID; }
		}

		public string Owner
		{
			get { return _owner; }
		}

		public string Priority
		{
			get { return _tcPriority; }
		}

		public string Description
		{
			get { return _description; }
		}

		public string SetupDescription
		{
			get { return _setupDescription; }
		}

		public string RunDescription
		{
			get { return _runDescription; }
		}

		public string CleanDescription
		{
			get { return _cleanupDescription; }
		}

		public string SetupTime
		{
			get { return _setupTime.ToString(); }
		}

		public string RunTime
		{
			get { return _runTime.ToString(); }
		}

		public string CleanTime
		{
			get { return _cleanupTime.ToString(); }
		}

        public string UserID
        {
            get { return _userID; }
        }

		public string DefectID
		{
			get { return _bugID.ToString(); }
		}

		public string Status
		{
			get { return _status; }
		}

		public string TotalRunTime
		{
			get { return _totalRunTime.ToString(); }
		}
		#endregion
	}

	class TestCaseListViewItem : ListViewItem
	{
		#region Variables
		bool _checkBoxes = false;
		int _tcID = -1;
		int _projectID = -1;
		string _owner = string.Empty;
		string _description = string.Empty;
		string _tcPriority = string.Empty;
		string _setupDescription = string.Empty;
		string _runDescription = string.Empty;
		string _cleanupDescription = string.Empty;
		int _setupTime = -1;
		int _runTime = -1;
		int _cleanupTime = -1;
		int _totalRunTime = -1;
        string _userID = string.Empty;
		string _bugID = string.Empty;
		string _status = string.Empty;
		#endregion

		public TestCaseListViewItem(DataRow testCaseDR, bool CheckBoxes)
		{
			_checkBoxes = CheckBoxes;
			try
			{
				if (testCaseDR != null)
				{
                    _tcID = Convert.ToInt32(testCaseDR["id"]);
                    _projectID = Convert.ToInt32(testCaseDR["project_id"]);
                    _owner = testCaseDR["owner"].ToString();
                    _tcPriority = testCaseDR["default_priority"].ToString();
                    _description = testCaseDR["short_description"].ToString();
                    _setupTime = Convert.ToInt32(testCaseDR["setup_time"]);
                    _runTime = Convert.ToInt32(testCaseDR["run_time"]);
                    _cleanupTime = Convert.ToInt32(testCaseDR["clean_time"]);
                    _bugID = testCaseDR["defect_id"].ToString();
                    _userID = testCaseDR["user_id"].ToString();
                    _status = testCaseDR["status_description"].ToString();
                    _setupDescription = testCaseDR["setup_steps"].ToString();
                    _runDescription = testCaseDR["run_steps"].ToString();
                    _cleanupDescription = testCaseDR["clean_steps"].ToString();
					CalcTotalRunTime(_setupTime, _runTime, _cleanupTime);

					SetOption();
					BuildSubItems();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void BuildSubItems()
		{
			this.SubItems.Add(_description);
			this.SubItems.Add(_bugID);
			this.SubItems.Add(_totalRunTime.ToString());
		}

		private void SetOption()
		{
			if (_checkBoxes)
			{
				this.Text = "";
				this.SubItems.Add(_tcPriority.ToString());
			}
			else
			{
				this.Text = _tcPriority.ToString();
			}
		}

		private void CalcTotalRunTime(int Setup, int Run, int Clean)
		{
			_totalRunTime = Setup + Run + Clean;
		}

		#region GETS
		public int TestCaseID
		{
			get { return _tcID; }
		}

		public int ProjectID
		{
			get { return _projectID; }
		}

		public string Owner
		{
			get { return _owner; }
		}

		public string Priority
		{
			get { return _tcPriority; }
		}

		public string Description
		{
			get { return _description; }
		}

		public string SetupDescription
		{
			get { return _setupDescription; }
		}

		public string RunDescription
		{
			get { return _runDescription; }
		}
		
		public string CleanDescription
		{
			get { return _cleanupDescription; }
		}

		public string SetupTime
		{
			get { return _setupTime.ToString(); }
		}

		public string RunTime
		{
			get { return _runTime.ToString(); }
		}

		public string CleanTime
		{
			get { return _cleanupTime.ToString(); }
		}

        public string UserID
        {
            get { return _userID; }
        }

		public string DefectID
		{
			get { return _bugID.ToString(); }
		}

		public string Status
		{
			get { return _status; }
		}

		public string TotalRunTime
		{
			get { return _totalRunTime.ToString(); }
		}
		#endregion
	}
}
