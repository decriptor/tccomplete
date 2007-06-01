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
		IDataAccess _dataAccess;
		String URL = @"tcp://localhost:8080/DataAccess";
		public static UserCredentials _loggedInUser;
		#endregion
        
		#region Delegates
		public delegate void ProjectRefreshHandler(ProjectTreeNode[] projects);
		public event ProjectRefreshHandler ProjectRefresh;
		public delegate void BuildRefreshHandler(BuildTreeNode[] builds);
		public event BuildRefreshHandler BuildRefresh;
		public delegate void TestCaseRefreshHandler(Array testCase);
		public event TestCaseRefreshHandler TestCaseRefresh;
		#endregion

		public MFController(UserCredentials LoggedInUser)
		{
			_loggedInUser = LoggedInUser;
			_dataAccess = (IDataAccess)Activator.GetObject(typeof(IDataAccess), URL);
		}

		public void RefreshProjects()
		{
			List<ProjectTreeNode> projects = new List<ProjectTreeNode>();
            DataSet ds;
			try
			{
				ds = _dataAccess.ProjectRetrieve(null, null);
				if ((ds.Tables.Count > 0) && (ds.Tables["tcdb_projects"].Rows.Count > 0))
				{
					for (int i = 0; i < ds.Tables["tcdb_projects"].Rows.Count; i++)
					{
						DataRow projectDR = ds.Tables["tcdb_projects"].Rows[i];
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
				ds = _dataAccess.BuildRetrieve(null, null, null);
				if ((ds.Tables.Count > 0) && (ds.Tables["tcdb_builds"].Rows.Count > 0))
				{
					for (int i = 0; i < ds.Tables["tcdb_builds"].Rows.Count; i++)
					{
						DataRow buildDR = ds.Tables["tcdb_builds"].Rows[i];
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

		internal void RefreshTestCases()
		{

		}
        
		internal void LauchBuildDialog()
		{
			Form_BuildDialog BD = new Form_BuildDialog(_dataAccess);
			if (BD.ShowDialog() == DialogResult.OK)
			{
                RefreshBuilds();
            }
		}
        
		internal void LauchTestCaseCreateDialog()
		{
			Form_TestCaseDialog TCD = new Form_TestCaseDialog(_dataAccess, "Create Test Case");
			if (TCD.ShowDialog() == DialogResult.OK)
			{
                RefreshTestCases();
			}
		}

        internal void LauchProjectCreateDialog()
		{
			Form_CreateProject CEP = new Form_CreateProject(_dataAccess);
			if (CEP.ShowDialog() == DialogResult.OK)
			{
                RefreshProjects();
			}
		}
	}
}