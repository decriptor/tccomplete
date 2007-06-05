using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using tccomplete.Interfaces;

namespace TestCaseComplete
{
	class MFController
	{
		#region Variables
		public static UserCredentials _loggedInUser;
		#endregion

		#region Delegates
		public delegate void ProjectRefreshHandler(ProjectTreeNode[] projects);
		public event ProjectRefreshHandler ProjectRefresh;
		public delegate void BuildRefreshHandler(BuildTreeNode[] builds);
		public event BuildRefreshHandler BuildRefresh;
		public delegate void TestCaseRefreshHandler(ResultListViewItem[] testCases);
		public event TestCaseRefreshHandler TestCaseRefresh;
		public delegate void LoadTestCaseDetailsHandler(TestCase[] testCase);
		public event LoadTestCaseDetailsHandler TestCaseDetails;
		#endregion

		public MFController(UserCredentials LoggedInUser)
		{
			_loggedInUser = LoggedInUser;
		}

		public void RefreshProjects()
		{
			List<ProjectTreeNode> projects = new List<ProjectTreeNode>();
			DataSet ds;
			try
			{
                ds = Client.dataAccess.ProjectRetrieve(null, null);
				if ((ds.Tables.Count > 0) && (ds.Tables["projects"].Rows.Count > 0))
				{
					for (int i = 0; i < ds.Tables["projects"].Rows.Count; i++)
					{
						DataRow projectDR = ds.Tables["projects"].Rows[i];
						projects.Add(new ProjectTreeNode(projectDR));
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			if (ProjectRefresh != null)
			{
				ProjectRefresh(projects.ToArray());
			}
		}

		internal void RefreshBuilds()
		{

			List<BuildTreeNode> builds = new List<BuildTreeNode>();
			DataSet ds;
			try
			{
				ds = Client.dataAccess.BuildRetrieve(null, null, null);
				if ((ds.Tables.Count > 0) && (ds.Tables["builds"].Rows.Count > 0))
				{
					for (int i = 0; i < ds.Tables["builds"].Rows.Count; i++)
					{
						DataRow buildDR = ds.Tables["builds"].Rows[i];
						builds.Add(new BuildTreeNode(buildDR));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			if (BuildRefresh != null)
			{
				BuildRefresh(builds.ToArray());
			}
		}

		internal void RefreshTestCases(int buildID, int projectID)
		{
			List<ResultListViewItem> buildTestCases = new List<ResultListViewItem>();
			DataSet resultsDS;
			try
			{
				resultsDS = Client.dataAccess.ResultsRetrieve(null, null, buildID, null, null, null, null, null);
				if ((resultsDS.Tables.Count > 0) && (resultsDS.Tables["results"].Rows.Count > 0))
				{
					for (int i = 0; i < resultsDS.Tables["results"].Rows.Count; i++)
					{
						DataRow resultsDR = resultsDS.Tables["results"].Rows[i];
						if (resultsDR["checkout_time"].ToString() == "")
						{
							buildTestCases.Add(new ResultListViewItem(resultsDR, projectID));
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			if (TestCaseRefresh != null)
			{
				TestCaseRefresh(buildTestCases.ToArray());
			}
		}

		internal void LoadTestCaseDetails(int testCaseID)
		{
			List<TestCase> TC = new List<TestCase>();
			DataSet testCaseDS;
			try
			{
				testCaseDS = Client.dataAccess.TestCaseRetrieve(testCaseID, null);
				if ((testCaseDS.Tables.Count > 0) && (testCaseDS.Tables["testcases"].Rows.Count > 0))
				{
					DataRow testCaseDR = testCaseDS.Tables["testcases"].Rows[0];
					TC.Add(new TestCase(testCaseDR));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			if (TestCaseDetails != null)
			{
				TestCaseDetails(TC.ToArray());
			}		
		}

		internal void LaunchBuildDialog()
		{
			Form_BuildDialog BD = new Form_BuildDialog();
			if (BD.ShowDialog() == DialogResult.OK)
			{
				//Update Builds View  //RefreshBuilds();
			}
		}
		        
		internal void LaunchTestCaseCreateDialog()
		{
			Form_TestCaseDialog TCD = new Form_TestCaseDialog();
			if (TCD.ShowDialog() == DialogResult.OK)
			{
				//Update Test Case View  //RefreshTestCases();
			}
		}

		internal void LaunchProjectCreateDialog()
		{
			Form_CreateProject CEP = new Form_CreateProject();
			if (CEP.ShowDialog() == DialogResult.OK)
			{
				//Update Project View RefreshProjects();
			}
		}

		internal void LaunchTestCaseAssignerDialog()
		{
			Form_BuildTCAssigner BTCA = new Form_BuildTCAssigner();
			if (BTCA.ShowDialog() == DialogResult.OK)
			{
				//Update Test Case View
			}
		}

		internal void LaunchHistoryViewer()
		{
			Form_HistoryViewer HV = new Form_HistoryViewer();
			HV.ShowDialog();
		}

		internal bool CheckResultAvailability(int _currentTestCase, int _currentBuild)
		{
			DataSet resultsDS = Client.dataAccess.ResultsRetrieve(null, _currentTestCase, _currentBuild, null, null, null, null, null);
			if (resultsDS != null)
			{
				if ((resultsDS.Tables.Count > 0) && (resultsDS.Tables["results"].Rows.Count > 0))
				{
					DataRow resultsDR = resultsDS.Tables["results"].Rows[0];
					if (resultsDR["checkout_time"].ToString() == "")
					{
						return true;
					}
				}
			}
			return false;
		}

		internal void CheckOutResult(int _currentTestCase, int _currentBuild)
		{
			Client.dataAccess.ResultsCheckOut(_currentTestCase, _currentBuild);
		}

		internal void EditTestCases()
		{
			Form_TestCaseViewer TCV = new Form_TestCaseViewer();
			if (TCV.ShowDialog() == DialogResult.OK)
			{
				//Update Test Case View
			}
		}
	}
}
