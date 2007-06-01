using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;using System.Windows.Forms;using MySql.Data;using MySql.Data.MySqlClient;using tccomplete.Interfaces;

namespace TestCaseComplete
{
	public partial class MainForm : Form
	{
		#region Variables
		MFController MFC;   //Main Form Controller
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
		}
		void MFC_ProjectRefresh(ProjectTreeNode[] projects)
		{
			tv_ProjectBuild.Nodes.AddRange(projects);        }
		void MFC_BuildRefresh(BuildTreeNode[] builds)
		{
			foreach(BuildTreeNode BTN in builds)
			{
                //Not a good way to do this.  Need to fix this!
				tv_ProjectBuild.Nodes[BTN.ProjectID - 1].Nodes.Add(BTN);
			}
		}

        //ToolStripeMenu - File
		#region TSM_File
		private void TSM_Logout_Click(object sender, EventArgs e)
		{
			this.Close();
		}
        
		private void TSM_Exit_Click(object sender, EventArgs e)
		{
			this.Close();        }
		#endregion
        //ToolStripMenu - Admin Tools
		#region TSM_AdminTools

		private void TSM_BuildCreate_Click(object sender, EventArgs e)
		{
			MFC.LauchBuildDialog();
		}
		private void TSM_BuildEdit_Click(object sender, EventArgs e)
		{
		}
		private void TSM_TestCaseCreate_Click(object sender, EventArgs e)
		{
			MFC.LauchTestCaseCreateDialog();
		}
		private void TSM_TestCaseEdit_Click(object sender, EventArgs e)
		{
		}
		private void TSM_ProjectCreate_Click(object sender, EventArgs e)
		{
			MFC.LauchProjectCreateDialog();
		}
		private void TSM_ProjectEdit_Click(object sender, EventArgs e)
		{		
		}
		#endregion

        //ToolStripMenu - About
		#region TSM_About
		private void TSM_About_Click(object sender, EventArgs e)
		{
			AboutBox AB = new AboutBox();
			AB.ShowDialog();
		}
		#endregion
		#region Views        private void BuildTreeView()
		{
			MFC.RefreshProjects();
			MFC.RefreshBuilds();
		}
		#endregion
	}
}

//public MainInterface()
//        {
//            InitializeComponent();
//            BuildStatusListView();
//        }
//        private void BuildStatusListView()
//        {
//            ListViewGroup StatusGroup = new ListViewGroup("Status", HorizontalAlignment.Center);
//            lsv_Status.Groups.Add(StatusGroup);
//            foreach( string statusName in _statuses)
//            {
//                ListViewItem LVI = new ListViewItem(statusName, StatusGroup);
//                lsv_Status.Items.Add(LVI);
//            }
//        }

//        private void ChangeMe()
//        {
//            projectDS = DataAccess.ProjectRetrieve(null, null);
//            if ((projectDS.Tables.Count > 0) && (projectDS.Tables["tcdb_projects"].Rows.Count > 0))
//            {
//                for (int i = 0; i < projectDS.Tables["tcdb_projects"].Rows.Count; i++)
//                {
//                    DataRow projectDR = projectDS.Tables["tcdb_projects"].Rows[i];
//                    cb_ProjectList.Items.Add(new Project(projectDR));
//                }
//            }
//        }


//        #region Variables//        string[] _statuses = new string[] { "Passed", "Failed", "Not Run" };
//        #endregion