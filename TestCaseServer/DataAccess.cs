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

        #region Users
        public DataSet UserLogin(string userName, string userPassword)
        {
            return _database.UserLogin(userName, userPassword);
        }

        public void UserInsert(string userName, string userPassword, int userAdmin, int administrator, string realName,
            int projectAdmin, int buildAdmin, int testCaseAdmin, int readWriteAccess)
        {
            _database.UserInsert(userName, userPassword, userAdmin, administrator, realName, projectAdmin, buildAdmin, testCaseAdmin, readWriteAccess);
        }

        public void UserUpdate(string oldUserName, string newUserName, int userAdmin, int admin, string realName, int projectAdmin,
            int buildAdmin, int testCaseAdmin, int readWriteAccess)
        {
            _database.UserUpdate(oldUserName, newUserName, userAdmin, admin, realName, projectAdmin, buildAdmin, testCaseAdmin, readWriteAccess);
        }

        public void UserDelete(int userID)
        {
            _database.UserDelete(userID);
        }
        #endregion

        #region Builds
        public DataSet BuildRetrieve(int? buildID, int? projectID, string buildName)
        {
            return _database.BuildRetrieve(buildID, projectID, buildName);
        }

        public void BuildInsert(int projectID, string buildName, string buildDescription, int buildDisplay)
        {
            _database.BuildInsert(projectID, buildName, buildDescription, buildDisplay);
        }

        public void BuildUpdate(int buildID, int projectID, string buildName, string buildDescription, int buildDisplay)
        {
            _database.BuildUpdate(buildID, projectID, buildName, buildDescription, buildDisplay);
        }

        public void BuildDelete(int buildID)
        {
            _database.BuildDelete(buildID);
        }
        #endregion

        #region Test Case
        public DataSet TestCaseRetrieve(int? testCaseID, int? projectID)
        {
            return _database.TestCaseRetrieve(testCaseID, projectID);
        }

        public void TestCaseInsert(int projectID, string testCaseOwner, int defaultPriority, string shortDescription, int setupTime, int runTime,
            int cleanTime, string userID, string defectID, string passFailDescription, string setupSteps, string runSteps, string cleanSteps)
        {
            _database.TestCaseInsert(projectID, testCaseOwner, defaultPriority, shortDescription, setupTime, runTime, cleanTime, userID, defectID,
                passFailDescription, setupSteps, runSteps, cleanSteps);
        }

        public void TestCaseUpdate(int testCaseID, int projectID, string testCaseOwner, int defaultPriority, string shortDescription, int setupTime, int runTime,
            int cleanTime, string userID, string defectID, string passFailDescription, string setupSteps, string runSteps, string cleanSteps)
        {
            _database.TestCaseUpdate(testCaseID, projectID, testCaseOwner, defaultPriority, shortDescription, setupTime, runTime, cleanTime, userID,
                defectID, passFailDescription, setupSteps, runSteps, cleanSteps);
        }

        public void TestCaseDelete(int testCaseID)
        {
            _database.TestCaseDelete(testCaseID);
        }
        #endregion

        #region Projects
        public DataSet ProjectRetrieve(int? projectID, string projectName)
        {
            return _database.ProjectRetrieve(projectID, projectName);
        }        

        public void ProjectInsert(string projectName, string projectDescription)
        {
            _database.ProjectInsert(projectName, projectDescription);
        }

        public void ProjectUpdate(int projectID, string projectName, string projectDescription)
        {
            _database.ProjectUpdate(projectID, projectName, projectDescription);
        }

        public void ProjectDelete(int projectID)
        {
            _database.ProjectDelete(projectID);
        }
        #endregion        

        #region Results
        public void ResultsInsert(int testCaseID, int buildID, string resultStatus, string updatedBy, string updateNotes, string bugID)
        {
            _database.ResultsInsert(testCaseID, buildID, resultStatus, updatedBy, updateNotes, bugID);
        }

        public DataSet ResultsRetrieve(int? resultID, int? testCaseID, int? buildID, string resultStatus, string updatedBy, string updateNotes, string bugID, DateTime? checkOutTime)
        {
            return _database.ResultsRetrieve(resultID, testCaseID, buildID, resultStatus, updatedBy, updateNotes, bugID, checkOutTime);
        }
        
        public void ResultsCheckIn(int resultID, int newStatus, string updatedBy, string updateNotes)
        {
            _database.ResultsCheckIn(resultID, newStatus, updatedBy, updateNotes);
        }
        
        public void ResultsCheckOut(int testCaseID, int buildID)
        {
            _database.ResultsCheckOut(testCaseID, buildID);
        }
        
        public void ResultsUpdate(int testCaseID, int buildID, string resultStatus, string updatedBy, string updateNotes)
        {
            _database.ResultsUpdate(testCaseID, buildID, resultStatus, updatedBy, updateNotes);
        }

        public void ResultsDelete(int testCaseID, int buildID)
        {
            _database.ResultsDelete(testCaseID, buildID);
        }
        #endregion

        #region Work List
        public DataSet WorkListRetrieve(string updatedBy)
        {
            return _database.WorkListRetrieve(updatedBy);
        }
        #endregion

    }
} 