using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using tccomplete.Interfaces;


namespace TestCaseComplete
{
	public partial class MainForm : Form
	{
		#region Variables
		MFController MFC;
		int _currentProject = -1;
		int _currentBuild = -1;
		int _currentTestCase = -1;
		#endregion

		public MainForm(UserCredentials loggedInUser)
		{
			MFC = new MFController(loggedInUser);
			InitializeComponent();
			TSSL_ConnectionStatus.Text = "Connected";
			RegisterEvents();
			BuildTreeView();
		}

		private void RegisterEvents()
		{
			MFC.ProjectRefresh += new MFController.ProjectRefreshHandler(MFC_ProjectRefresh);
			MFC.BuildRefresh += new MFController.BuildRefreshHandler(MFC_BuildRefresh);
			MFC.TestCaseRefresh += new MFController.TestCaseRefreshHandler(MFC_TestCaseRefresh);
			MFC.TestCaseDetails += new MFController.LoadTestCaseDetailsHandler(MFC_TestCaseDetails);
		}

		void MFC_ProjectRefresh(ProjectTreeNode[] projects)
		{
			tv_ProjectBuild.Nodes.AddRange(projects);
		}

		void MFC_BuildRefresh(BuildTreeNode[] builds)
		{
			foreach (BuildTreeNode BTN in builds)
			{
				int i = 0;
				foreach (ProjectTreeNode PTN in tv_ProjectBuild.Nodes)
				{
					if (PTN.ID == BTN.ProjectID)
					{
						PTN.Nodes.Add(BTN);
					}
					i++;
				}
			}
		}

		void MFC_TestCaseRefresh(ResultListViewItem[] testCases)
		{
			lsv_TestCaseWindow.Items.Clear();
			lsv_TestCaseWindow.Items.AddRange(testCases);
		}

		void MFC_TestCaseDetails(TestCase[] testCase)
		{
			ClearDetailsFields();
			rtb_SetupInstructions.Text = testCase[0].SetupDescription;
			rtb_RunInstructions.Text = testCase[0].RunDescription;
			rtb_CleanupInstructions.Text = testCase[0].CleanDescription;
			mtb_SetupTime.Text = testCase[0].SetupTime;
			mtb_RunTime.Text = testCase[0].RunTime;
			mtb_CleanupTime.Text = testCase[0].CleanTime;
			txt_TotalEstTime.Text = testCase[0].TotalRunTime;
			txt_BugzillaID.Text = testCase[0].DefectID;
			rtb_StatusCriteria.Text = testCase[0].Status;
		}

		private void ClearDetailsFields()
		{
			rtb_CleanupInstructions.Text = rtb_RunInstructions.Text = rtb_SetupInstructions.Text = "";
			mtb_CleanupTime.Text = mtb_RunTime.Text = mtb_SetupTime.Text = txt_TotalEstTime.Text = "";
			txt_BugzillaID.Text = rtb_StatusCriteria.Text = "";
		}

		#region TSM_File

		private void TSM_Logout_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region User Tools

		private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_UserWorkList UWL = new Form_UserWorkList();
			UWL.ShowDialog();
		}

		#endregion

		#region TSM_AdminTools
		private void TSM_ProjectCreate_Click(object sender, EventArgs e)
		{
			MFC.LaunchProjectCreateDialog();
			BuildTreeView();
		}

		private void TSM_ProjectEdit_Click(object sender, EventArgs e)
		{

		}

		private void TSM_BuildCreate_Click(object sender, EventArgs e)
		{
			MFC.LaunchBuildDialog();
			BuildTreeView();
		}

		private void TSM_BuildEdit_Click(object sender, EventArgs e)
		{

		}

		private void TSM_TestCaseCreate_Click(object sender, EventArgs e)
		{
			MFC.LaunchTestCaseCreateDialog();
		}

		private void historyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MFC.LaunchHistoryViewer();
		}

		private void buildAssignerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MFC.LaunchTestCaseAssignerDialog();
		}
		#endregion

		#region TSM_About


		private void TSM_About_Click(object sender, EventArgs e)
		{
			AboutBox AB = new AboutBox();
			AB.ShowDialog();
		}

		#endregion

		#region Views
		private void BuildTreeView()
		{
			tv_ProjectBuild.Nodes.Clear();
			MFC.RefreshProjects();
			MFC.RefreshBuilds();
		}

		private void tv_ProjectBuild_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeView TV = sender as TreeView;
			Type x = TV.SelectedNode.GetType();
			if (x.Name == "ProjectTreeNode")
			{
				lsv_TestCaseWindow.Items.Clear();
			}
			if (x.Name == "BuildTreeNode")
			{
				BuildTreeNode BTN = TV.SelectedNode as BuildTreeNode;
				_currentProject = BTN.ProjectID;
				_currentBuild = BTN.ID;
				MFC.RefreshTestCases(_currentBuild, _currentProject);
			}
		}

		private void lsv_TestCaseWindow_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListView.SelectedListViewItemCollection testCases = lsv_TestCaseWindow.SelectedItems;

			if ((testCases != null) && (testCases.Count == 1))
			{
				foreach (ResultListViewItem testCase in testCases)
				{
					_currentTestCase = (testCase as ResultListViewItem).TestCaseID;
					MFC.LoadTestCaseDetails((testCase as ResultListViewItem).TestCaseID);
				}
			}
		}
		#endregion

		private void btn_CheckOut_Click(object sender, EventArgs e)
		{
			if (MFC.CheckResultAvailability(_currentTestCase, _currentBuild))
			{
				MFC.CheckOutResult(_currentTestCase, _currentBuild);
				MFC.RefreshTestCases(_currentBuild, _currentProject);
				ClearDetailsFields();
			}
		}

		private void TSM_TestCaseEdit_Click(object sender, EventArgs e)
		{
			MFC.EditTestCases();
		}

	}
}