using System;
using System.Collections.Generic;
using System.Text;
using tccomplete.Interfaces;

namespace TestCaseComplete
{
	class TestCase
	{
		#region Variables
		IDataAccess _DataAccess;
		int _tcID = -1;
		int _projectID = -1;
		string _description = string.Empty;
		int _tcPriority = -1;
		string _setupDescription = string.Empty;
		string _runDescription = string.Empty;
		string _cleanupDescription = string.Empty;
        int _setupTime = -1;
        int _runTime = -1;
        int _cleanupTime = -1;
        int _totalTime = -1;
		int _bugzillaID = -1;
		#endregion

        public TestCase()
		{

		}

		public TestCase(IDataAccess DataAccess)
		{
            _DataAccess = DataAccess;

		}

		#region GETS/SETS

		#endregion
        
	}

}

