using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.Types;
using MySql.Data.MySqlClient;
using tccomplete.Interfaces;

namespace TestCaseServer.Databases
{
    class MySQL
    {
        #region Variables
        const string ConnectStringFormat = "server={0};user id={1};password={2};database=tccomplete;pooling=true";
        static string ConnectString;
        Logger LOGGER = new Logger();
        #endregion

        #region Constructors
        static MySQL()
        {
            ConnectString = string.Format(ConnectStringFormat, "localhost", "tcdbuser", "tcdbuser001!");
        }

        public MySQL()
        {

        }
        #endregion

        #region Users
        /// <summary>
        /// Login Method for user auth
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPassword"></param>
        /// <returns></returns>
        public DataSet UserLogin(string userName, string userPassword)
        {
            DataSet userDS = new DataSet();
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_UserLogin", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("LoginUser", userName);
                    cmd.Parameters.AddWithValue("LoginPass", userPassword);
                    DA.Fill(userDS, "users");
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, "Login Failed: user " + userName);
                throw ex;
            }
            return userDS;
        }
        
        /// <summary>
        /// Add a new user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPassword"></param>
        /// <param name="userAdmin"></param>
        /// <param name="administrator"></param>
        /// <param name="realName"></param>
        /// <param name="projectAdmin"></param>
        /// <param name="buildAdmin"></param>
        /// <param name="testCaseAdmin"></param>
        /// <param name="readWriteAccess"></param>
        public void UserInsert(string userName, string userPassword, int userAdmin, int administrator, string realName, 
            int projectAdmin, int buildAdmin, int testCaseAdmin, int readWriteAccess)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_UserInsert", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userName", userName);
                    cmd.Parameters.AddWithValue("userPassword", userPassword);
                    cmd.Parameters.AddWithValue("userAdmin", userAdmin);
                    cmd.Parameters.AddWithValue("administrator", administrator);
                    cmd.Parameters.AddWithValue("realName", realName);
                    cmd.Parameters.AddWithValue("projectAdmin", projectAdmin);
                    cmd.Parameters.AddWithValue("buildAdmin", buildAdmin);
                    cmd.Parameters.AddWithValue("testCaseAdmin", testCaseAdmin);
                    cmd.Parameters.AddWithValue("readWriteAccess", readWriteAccess);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Update an existing user
        /// </summary>
        /// <param name="oldUserName"></param>
        /// <param name="newUserName"></param>
        /// <param name="userAdmin"></param>
        /// <param name="admin"></param>
        /// <param name="realName"></param>
        /// <param name="projectAdmin"></param>
        /// <param name="buildAdmin"></param>
        /// <param name="testCaseAdmin"></param>
        /// <param name="readWriteAccess"></param>
        public void UserUpdate(string oldUserName, string newUserName, int userAdmin, int admin, string realName, int projectAdmin, 
            int buildAdmin, int testCaseAdmin, int readWriteAccess)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_UserUpdate", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("oldUserName", oldUserName);
                    cmd.Parameters.AddWithValue("newUserName", newUserName);
                    cmd.Parameters.AddWithValue("userAdmin", userAdmin);
                    cmd.Parameters.AddWithValue("administrator", admin);
                    cmd.Parameters.AddWithValue("realName", realName);
                    cmd.Parameters.AddWithValue("projectAdmin", projectAdmin);
                    cmd.Parameters.AddWithValue("buildAdmin", buildAdmin);
                    cmd.Parameters.AddWithValue("testCaseAdmin", testCaseAdmin);
                    cmd.Parameters.AddWithValue("readWriteAccess", readWriteAccess);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Delete an user
        /// </summary>
        /// <param name="userID"></param>
        public void UserDelete(int userID)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_UserUpdate", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("userName", userID);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }
        #endregion

        #region Builds
        /// <summary>
        /// Create a new build
        /// </summary>
        /// <param name="projectUID"></param>
        /// <param name="buildName"></param>
        /// <param name="buildDescription"></param>
        /// <param name="buildDisplay"></param>
        public void BuildInsert(int projectID, string buildName, string buildDescription, int buildDisplay)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_BuildInsert", mySQLConnection))
                { 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("?projectID", projectID);
                    cmd.Parameters.AddWithValue("?buildName", buildName);
                    cmd.Parameters.AddWithValue("?buildDescription", buildDescription);
                    DateTime buildDate = DateTime.Now;
                    cmd.Parameters.AddWithValue("?buildDate", buildDate);
                    cmd.Parameters.AddWithValue("?buildDisplay", buildDisplay);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Retrieve all builds(null) or one specific build(build uid)
        /// </summary>
        /// <param name="buildID"></param>
        /// <returns></returns>
        public DataSet BuildRetrieve(int? buildID, int? projectID, string buildName)
        {
            DataSet userDS = new DataSet();
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_BuildRetrieve", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("?buildID", buildID);
                    cmd.Parameters.AddWithValue("?projectID", projectID);
                    cmd.Parameters.AddWithValue("?buildName", buildName);
                    //BuildID int(11), ProjectID int(11), BuildName tinytext)
                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    DA.Fill(userDS, "builds");
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
            return userDS;
        }
        
        /// <summary>
        /// Update an existing build
        /// </summary>
        /// <param name="buildID"></param>
        /// <param name="projectID"></param>
        /// <param name="buildName"></param>
        /// <param name="buildDescription"></param>
        /// <param name="buildDisplay"></param>
        public void BuildUpdate(int buildID, int projectID, string buildName, string buildDescription, int buildDisplay)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_BuildUpdate", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("buildID", buildID);
                    cmd.Parameters.AddWithValue("projectID", projectID);
                    cmd.Parameters.AddWithValue("buildName", buildName);
                    cmd.Parameters.AddWithValue("buildDescription", buildDescription);
                    DateTime buildDate = DateTime.Now;
                    cmd.Parameters.AddWithValue("buildDate", buildDate);
                    cmd.Parameters.AddWithValue("buildDisplay", buildDisplay);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Delete a build
        /// </summary>
        /// <param name="buildID"></param>
        public void BuildDelete(int buildID)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_BuildDelete", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("buildID", buildID);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }
        #endregion

        #region Test Cases
        /// <summary>
        /// Create and Insert a new Test Case
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="testCaseOwner"></param>
        /// <param name="defaultPriority"></param>
        /// <param name="shortDescription"></param>
        /// <param name="setupTime"></param>
        /// <param name="runTime"></param>
        /// <param name="cleanTime"></param>
        /// <param name="userID"></param>
        /// <param name="defectID"></param>
        /// <param name="passFailDescription"></param>
        /// <param name="setupSteps"></param>
        /// <param name="runSteps"></param>
        /// <param name="cleanSteps"></param>
        public void TestCaseInsert(int projectID, string testCaseOwner, int defaultPriority, string shortDescription, int setupTime, int runTime,
            int cleanTime, string userID, string defectID, string passFailDescription, string setupSteps, string runSteps, string cleanSteps)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_TestCaseInsert", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("?projectID", projectID);
                    cmd.Parameters.AddWithValue("?testCaseOwner", testCaseOwner);
                    cmd.Parameters.AddWithValue("?defaultPriority", defaultPriority);
                    cmd.Parameters.AddWithValue("?shortDescription", shortDescription);
                    cmd.Parameters.AddWithValue("?setupTime", setupTime);
                    cmd.Parameters.AddWithValue("?runTime", runTime);
                    cmd.Parameters.AddWithValue("?cleanTime", cleanTime);
                    cmd.Parameters.AddWithValue("?userID", userID);
                    cmd.Parameters.AddWithValue("?defectID", defectID);
                    cmd.Parameters.AddWithValue("?statusDescription", passFailDescription);
                    cmd.Parameters.AddWithValue("?setupSteps", setupSteps);
                    cmd.Parameters.AddWithValue("?runSteps", runSteps);
                    cmd.Parameters.AddWithValue("?cleanSteps", cleanSteps);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Retrieve all Test Cases(null) or one specific Test Case(Test Case uid)
        /// </summary>
        /// <param name="tcuid"></param>
        /// <returns></returns>
        public DataSet TestCaseRetrieve(int? testCaseID, int? projectID)
        {
            DataSet userDS = new DataSet();
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_TestCaseRetrieve", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("?testCaseID", testCaseID);
                    cmd.Parameters.AddWithValue("?projectID", projectID);
                    DA.Fill(userDS, "testcases");
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
            return userDS;
        }
        
        /// <summary>
        /// Update a test case
        /// </summary>
        /// <param name="testCaseID"></param>
        /// <param name="projectID"></param>
        /// <param name="testCaseOwner"></param>
        /// <param name="defaultPriority"></param>
        /// <param name="shortDescription"></param>
        /// <param name="setupTime"></param>
        /// <param name="runTime"></param>
        /// <param name="cleanTime"></param>
        /// <param name="userID"></param>
        /// <param name="defectID"></param>
        /// <param name="passFailDescription"></param>
        /// <param name="setupSteps"></param>
        /// <param name="runSteps"></param>
        /// <param name="cleanSteps"></param>
        public void TestCaseUpdate(int testCaseID, int projectID, string testCaseOwner, int defaultPriority, string shortDescription, int setupTime, int runTime,
            int cleanTime, string userID, string defectID, string passFailDescription, string setupSteps, string runSteps, string cleanSteps)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_TestCaseUpdate", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("testCaseID", testCaseID);
                    cmd.Parameters.AddWithValue("projectID", projectID);
                    cmd.Parameters.AddWithValue("testCaseOwner", testCaseOwner);
                    cmd.Parameters.AddWithValue("defaultPriority", defaultPriority);
                    cmd.Parameters.AddWithValue("shortDescription", shortDescription);
                    cmd.Parameters.AddWithValue("setupTime", setupTime);
                    cmd.Parameters.AddWithValue("runTime", runTime);
                    cmd.Parameters.AddWithValue("cleanTime", cleanTime);
                    cmd.Parameters.AddWithValue("userID", userID);
                    cmd.Parameters.AddWithValue("defectID", defectID);
                    cmd.Parameters.AddWithValue("statusDescription", passFailDescription);
                    cmd.Parameters.AddWithValue("setupSteps", setupSteps);
                    cmd.Parameters.AddWithValue("runSteps", runSteps);
                    cmd.Parameters.AddWithValue("cleanSteps", cleanSteps);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Delete a test case
        /// </summary>
        /// <param name="testCaseID"></param>
        public void TestCaseDelete(int testCaseID)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_TestCaseDelete", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("testCaseID", testCaseID);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }
        #endregion

        #region Projects
        /// <summary>
        /// Create a new project
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="projectDescription"></param>
        public void ProjectInsert(string projectName, string projectDescription)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_ProjectInsert", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("?projectName", projectName);
                    cmd.Parameters.AddWithValue("?projectDescription", projectDescription);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Retrieve all projects(null) or one specific project(project id)
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="projectName"></param>
        /// <returns>userDS</returns>
        public DataSet ProjectRetrieve(int? projectID, string projectName)
        {
            DataSet userDS = new DataSet();
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_ProjectRetrieve", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("?projectID", projectID);
                    cmd.Parameters.AddWithValue("?projectName", projectName);
                    DA.Fill(userDS, "projects");
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
            return userDS;
        }

        /// <summary>
        /// Update an existing Project
        /// </summary>
        /// <param name="projectID"></param>
        /// <param name="projectName"></param>
        /// <param name="projectDescription"></param>
        public void ProjectUpdate(int projectID, string projectName, string projectDescription)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_ProjectUpdate", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("projectID", projectID);
                    cmd.Parameters.AddWithValue("projectName", projectName);
                    cmd.Parameters.AddWithValue("projectDescription", projectDescription);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Delete a project
        /// </summary>
        /// <param name="projectID"></param>
        public void ProjectDelete(int projectID)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_ProjectDelete", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("projectID", projectID);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }
        #endregion

        #region Results
        /// <summary>
        /// Create a new result
        /// </summary>
        /// <param name="testCaseID"></param>
        /// <param name="buildID"></param>
        /// <param name="resultStatus"></param>
        /// <param name="updatedBy"></param>
        /// <param name="updateNotes"></param>
        /// <param name="bugID"></param>
        public void ResultsInsert(int testCaseID, int buildID, string resultStatus, string updatedBy, string updateNotes, string bugID)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_ResultInsert", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("testCaseID", testCaseID);
                    cmd.Parameters.AddWithValue("buildID", buildID);
                    cmd.Parameters.AddWithValue("resultStatus", resultStatus);
                    cmd.Parameters.AddWithValue("updatedBy", updatedBy);
                    cmd.Parameters.AddWithValue("updateNotes", updateNotes);
                    cmd.Parameters.AddWithValue("bugID", bugID);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }
        
        /// <summary>
        /// Retrieve results
        /// </summary>
        /// <param name="resultID"></param>
        /// <param name="testCaseID"></param>
        /// <param name="buildID"></param>
        /// <param name="resultStatus"></param>
        /// <param name="updatedBy"></param>
        /// <param name="updateNotes"></param>
        /// <param name="bugID"></param>
        /// <param name="checkOutTime"></param>
        /// <returns></returns>
        public DataSet ResultsRetrieve(int? resultID, int? testCaseID, int? buildID, string resultStatus, string updatedBy, string updateNotes, string bugID, DateTime? checkOutTime)
        {
            DataSet resultsDS = new DataSet();
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_ResultRetrieve", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("?resultID", resultID);
                    cmd.Parameters.AddWithValue("?testCaseID", testCaseID);
                    cmd.Parameters.AddWithValue("?buildID", buildID);
                    cmd.Parameters.AddWithValue("?resultStatus", resultStatus);
                    cmd.Parameters.AddWithValue("?updatedBy", updatedBy);
                    cmd.Parameters.AddWithValue("?updateNotes", updateNotes);
                    cmd.Parameters.AddWithValue("?bugID", bugID);
                    cmd.Parameters.AddWithValue("?checkout", checkOutTime);
                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    DA.Fill(resultsDS, "results");
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
            return resultsDS;
        }

        /// <summary>
        /// Check in a result
        /// </summary>
        /// <param name="resultID"></param>
        /// <param name="newStatus"></param>
        /// <param name="updatedBy"></param>
        /// <param name="updateNotes"></param>
        public void ResultsCheckIn(int resultID, int newStatus, string updatedBy, string updateNotes)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_ResultCheckIn", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("resultID", resultID);
                    cmd.Parameters.AddWithValue("newStatus", newStatus);
                    cmd.Parameters.AddWithValue("updatedBy", updatedBy);
                    cmd.Parameters.AddWithValue("updateNotes", updateNotes);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Check out a result
        /// </summary>
        /// <param name="testCaseID"></param>
        /// <param name="buildID"></param>
        public void ResultsCheckOut(int testCaseID, int buildID)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_ResultCheckOut", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("testCaseID", testCaseID);
                    cmd.Parameters.AddWithValue("buildID", buildID);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Update a result
        /// </summary>
        /// <param name="testCaseID"></param>
        /// <param name="buildID"></param>
        /// <param name="resultStatus"></param>
        /// <param name="updatedBy"></param>
        /// <param name="updateNotes"></param>
        public void ResultsUpdate(int testCaseID, int buildID, string resultStatus, string updatedBy, string updateNotes)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_ResultUpdate", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("testCaseID", testCaseID);
                    cmd.Parameters.AddWithValue("buildID", buildID);
                    cmd.Parameters.AddWithValue("resultStatus", resultStatus);
                    cmd.Parameters.AddWithValue("updatedBy", updatedBy);
                    cmd.Parameters.AddWithValue("updateNotes", updateNotes);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Delete a result
        /// </summary>
        /// <param name="testCaseID"></param>
        /// <param name="buildID"></param>
        public void ResultsDelete(int testCaseID, int buildID)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_ResultDelete", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("testCaseID", testCaseID);
                    cmd.Parameters.AddWithValue("buildID", buildID);
                    mySQLConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }
        #endregion

        #region Work List
        /// <summary>
        /// Work List Retrieve
        /// </summary>
        /// <param name="updatedBy"></param>
        /// <returns></returns>
        public DataSet WorkListRetrieve(string updatedBy)
        {
            DataSet workListDS = new DataSet();
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_WorkListRetrieve", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("?updatedBy", updatedBy);
                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    DA.Fill(workListDS, "results");
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
            return workListDS;
        }
        #endregion

        public DataSet HistoryRetrieve(int? resultID, DateTime? historyTime, string userName, int? status, string defectID)
        {
            DataSet historyDS = new DataSet();
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_historyRetrieve", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
					cmd.Parameters.AddWithValue("?ResultID", resultID);
                    cmd.Parameters.AddWithValue("?HistoryTime", historyTime);
                    cmd.Parameters.AddWithValue("?HistoryUserName", userName);
                    cmd.Parameters.AddWithValue("?HistoryStatus", status);
                    cmd.Parameters.AddWithValue("?HistoryDefectID", defectID);
					DA.Fill(historyDS, "history");
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
            }
			return historyDS;
        }
    }
}
