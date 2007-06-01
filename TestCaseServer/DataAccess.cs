using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Collections;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using TestCaseServer.Databases;
using tccomplete.Interfaces;

namespace TestCaseServer
{
    public sealed class DataAccess : MarshalByRefObject, IDataAccess
    {
        private MySQL _database;
        Logger LOGGER = new Logger();

        DataAccess()
        {
            try
            {
                _database = new MySQL();
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
            }
            
        }

        public DataSet UserLogin(string UserName, string UserPassword)
        {
            return _database.UserLogin(UserName, UserPassword);
        }        

        public void UserInsert()
        {
            _database.UserInsert();
        }

        public void UserUpdate()
        {
            _database.UserUpdate();
        }

        public void UserDelete(int userID)
        {
            _database.UserDelete(userID);
        }

        public DataSet ProjectRetrieve(int? projectUID, string projectName)
        {
            return _database.ProjectRetrieve(projectUID, projectName);
        }        

        public void ProjectInsert(string projectName, string projectDescription)
        {
            _database.ProjectInsert(projectName, projectDescription);
        }

        public void ProjectUpdate()
        {
            _database.ProjectUpdate();
        }

        public void ProjectDelete()
        {
            _database.ProjectDelete();
        }

        public DataSet BuildRetrieve(int? buildID, int? projectID, string buildName)
        {
            return _database.BuildRetrieve(buildID, projectID, buildName);
        }

        public void BuildInsert(int projectUID, string buildName, string buildDescription, int buildDisplay)
        {
            _database.BuildInsert(projectUID, buildName, buildDescription, buildDisplay);
        }

        public void BuildUpdate()
        {
            _database.BuildUpdate();
        }

        public void BuildDelete()
        {
            _database.BuildDelete();
        }

        public DataSet TestCaseRetrieve(int? tcuid)
        {
            return _database.TestCaseRetrieve(tcuid);
        }

        public void TestCaseInsert(int ProjectUID, string TCOwner, int TCDefaultPriority, string TCShortDesc, int TCEtcSetup, int TCEtcRun,
            int TCEtcClean, string TCYouID, string TCDefectID, string TCPassFailDesc, string TCSetupSteps, string TCRunSteps, string TCCleanSteps)
        {
            _database.TestCaseInsert(ProjectUID, TCOwner, TCDefaultPriority, TCShortDesc, TCEtcSetup, TCEtcRun, TCEtcClean, TCYouID, TCDefectID, TCPassFailDesc,
                TCSetupSteps, TCRunSteps, TCCleanSteps);
        }        

        public void TestCaseUpdate()
        {
            _database.TestCaseUpdate();
        }

        public void TestCaseDelete()
        {
            _database.TestCaseDelete();
        }        

        public void HistoryInsert(int resultsID, string userName, int status, string defectID)
        {
            _database.HistoryInsert(resultsID, userName, status, defectID);
        }

    }
}