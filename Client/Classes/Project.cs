using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TestCaseComplete
{
    class Project
    {
        #region Variables
        int _projectID = -1;
        string _projectName = string.Empty;
        #endregion
        public Project(DataRow dr)
        {
            if (dr != null)
            {
                _projectID = Convert.ToInt32(dr["uid"]);
                _projectName = dr["name"].ToString();
            }
        }
		public int ID
		{
			get { return _projectID; }
		}
		public string Name
		{
			get { return _projectName; }
		}
        public override string ToString()
        {
            return _projectName;
        }    }

    /// <summary>
    /// Generates a Project Tree Node from a DataRow
    /// </summary>
	class ProjectTreeNode : TreeNode
	{
		#region Variables
		int _projectID = -1;
		string _projectName = string.Empty;
		string _projectDescription = string.Empty;
		#endregion        
		public ProjectTreeNode(DataRow ProjectRow)
		{
			if (ProjectRow != null)
			{
				_projectID = Convert.ToInt32(ProjectRow["uid"]);
				_projectName = ProjectRow["name"].ToString();
				_projectDescription = ProjectRow["description"].ToString();
			}        }
		public int ID
		{
			get { return _projectID; }
		}
		public string ProjectName
		{
			get { return _projectName; }
		}
		public string Description
		{
			get { return _projectDescription; }
		}                public override string ToString()        {
			return _projectName;
		}
	}
}