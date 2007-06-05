using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TestCaseComplete
{
	class Build
	{
		#region Variables
		int _buildID = -1;
		int _projectID = -1;
		string _buildName = string.Empty;
		#endregion

		public Build(DataRow BuildRow)
		{
			if (BuildRow != null)
			{
				_buildID = Convert.ToInt32(BuildRow["id"]);
				_projectID = Convert.ToInt32(BuildRow["project_id"]);
				_buildName = BuildRow["name"].ToString();
			}
		}

		public int ID
		{
			get { return _buildID; }
		}

		public int ProjectID
		{
			get { return _projectID; }
		}

		public string Name
		{
			get { return _buildName; }
		}

		public override string ToString()
		{
			return _buildName;
		}
	}


    /// <summary>
    /// Generates a Build Tree Node from a DataRow
    /// </summary>
	class BuildTreeNode : TreeNode
	{
		#region Variables
		int _buildID = -1;
		int _projectID = -1;
		string _buildName = string.Empty;
		string _buildDescription = string.Empty;
		string _buildDate = string.Empty;
		int _buildDisplay = 0;
		#endregion
		
		public BuildTreeNode(DataRow BuildRow)
		{
			if (BuildRow != null)
			{
				_buildID = Convert.ToInt32(BuildRow["id"]);
				_projectID = Convert.ToInt32(BuildRow["project_id"]);
				_buildName = BuildRow["name"].ToString();
				_buildDescription = BuildRow["description"].ToString();
				_buildDate = BuildRow["date"].ToString();
				_buildDisplay = Convert.ToInt32(BuildRow["display"]);
				SetOptions();
			}
		}

		private void SetOptions()
		{
			this.Text = _buildName;
			this.ToolTipText = _buildDescription;
		}

		public int ID
		{
			get { return _buildID; }
		}

		public int ProjectID
		{
			get { return _projectID; }
		}

		public string BuildName
		{
			get { return _buildName; }
		}

		public string Description
		{
			get { return _buildDescription; }
		}

		public string Date
		{
			get { return _buildDate; }
		}

		public int Display
		{
			get { return _buildDisplay; }
		}

		public override string ToString()
		{
			return _buildName;
		}

	}
}
