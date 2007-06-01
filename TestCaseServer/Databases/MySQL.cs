using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
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

        static MySQL()
        {
            ConnectString = string.Format(ConnectStringFormat, "localhost", "tcdbuser", "tcdbuser001!");
        }

        public MySQL()
        {

        }

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
                    //cmd.Parameters.Add("LoginUser", userName);
                    //cmd.Parameters.Add("LoginPass", userPassword);
                    cmd.Parameters.AddWithValue("LoginUser", userName);
                    cmd.Parameters.AddWithValue("LoginPass", userPassword);
                    DA.Fill(userDS, "login");
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, "Login Failed: user " + userName);
            }
            return userDS;
        }

        public void UserInsert()
        {

        }

        public void UserUpdate()
        {

        }

        public void UserDelete(int userID)
        {

        }

        /// <summary>
        /// Create a new build
        /// </summary>
        /// <param name="projectUID"></param>
        /// <param name="buildName"></param>
        /// <param name="buildDescription"></param>
        /// <param name="buildDisplay"></param>
        public void BuildInsert(int projectUID, string buildName, string buildDescription, int buildDisplay)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_BuildInsert", mySQLConnection))
                { 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("?ProjectUID", projectUID);
                    cmd.Parameters.AddWithValue("?BuildName", buildName);
                    cmd.Parameters.AddWithValue("?BuildDescription", buildDescription);
                    DateTime buildDate = DateTime.Now;
                    cmd.Parameters.AddWithValue("?BuildDate", buildDate);
                    cmd.Parameters.AddWithValue("?BuildDisplay", buildDisplay);
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
        /// Retrieve all builds(null) or one specific build(build uid)
        /// </summary>
        /// <param name="buildID"></param>
        /// <returns></returns>
        public DataSet BuildRetrieve(int? buildID, int? ProjectID, string BuildName)
        {
            DataSet userDS = new DataSet();
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_BuildRetrieve", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("?BuildID", buildID);
                    cmd.Parameters.AddWithValue("?ProjectID", ProjectID);
                    cmd.Parameters.AddWithValue("?BuildName", BuildName);
                    
                    //BuildID int(11), ProjectID int(11), BuildName tinytext)
                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    DA.Fill(userDS, "tcdb_builds");
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
            }
            return userDS;
        }

        public void BuildUpdate()
        {

        }

        public void BuildDelete()
        {
        }

        /// <summary>
        /// Create and Insert a new Test Case
        /// </summary>
        /// <param name="ProjectUID"></param>
        /// <param name="TCOwner"></param>
        /// <param name="TCDefaultPriority"></param>
        /// <param name="TCShortDesc"></param>
        /// <param name="TCEtcSetup"></param>
        /// <param name="TCEtcRun"></param>
        /// <param name="TCEtcClean"></param>
        /// <param name="TCYouID"></param>
        /// <param name="TCDefectID"></param>
        /// <param name="TCPassFailDesc"></param>
        /// <param name="TCSetupSteps"></param>
        /// <param name="TCRunSteps"></param>
        /// <param name="TCCleanSteps"></param>
        public void TestCaseInsert(int ProjectUID, string TCOwner, int TCDefaultPriority, string TCShortDesc, int TCEtcSetup, int TCEtcRun,
            int TCEtcClean, string TCYouID, string TCDefectID, string TCPassFailDesc, string TCSetupSteps, string TCRunSteps, string TCCleanSteps)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_TestCaseInsert", mySQLConnection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("?ProjectUID", ProjectUID);
                    cmd.Parameters.AddWithValue("?TCOwner", TCOwner);
                    cmd.Parameters.AddWithValue("?TCDefaultPriority", TCDefaultPriority);
                    cmd.Parameters.AddWithValue("?TCShortDesc", TCShortDesc);
                    cmd.Parameters.AddWithValue("?TCEtcSetup", TCEtcSetup);
                    cmd.Parameters.AddWithValue("?TCEtcRun", TCEtcRun);
                    cmd.Parameters.AddWithValue("?TCEtcClean", TCEtcClean);
                    cmd.Parameters.AddWithValue("?TCYouID", TCYouID);
                    cmd.Parameters.AddWithValue("?TCDefectID", TCDefectID);
                    cmd.Parameters.AddWithValue("?TCPassFailDesc", TCPassFailDesc);
                    cmd.Parameters.AddWithValue("?TCSetupSteps", TCSetupSteps);
                    cmd.Parameters.AddWithValue("?TCRunSteps", TCRunSteps);
                    cmd.Parameters.AddWithValue("?TCCleanSteps", TCCleanSteps);

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
        public DataSet TestCaseRetrieve(int? tcuid)
        {
            DataSet userDS = new DataSet();
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_TestCaseRetrieve", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("?uid", tcuid);
                    DA.Fill(userDS, "tcdb_testcases");
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
            }
            return userDS;
        }

        public void TestCaseUpdate()
        {
        }

        public void TestCaseDelete()
        {
        }

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
                    cmd.Parameters.AddWithValue("?ProjectName", projectName);
                    cmd.Parameters.AddWithValue("?ProjectDescription", projectDescription);
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
        /// Retrieve all projects(null) or one specific project(project uid)
        /// </summary>
        /// <param name="projectUID"></param>
        /// <param name="projectName"></param>
        /// <returns></returns>
        public DataSet ProjectRetrieve(int? projectUID, string projectName)
        {
            DataSet userDS = new DataSet();
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_ProjectRetrieve", mySQLConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("?ProjectUID", projectUID);
                    cmd.Parameters.AddWithValue("?ProjectName", projectName);
                    DA.Fill(userDS, "tcdb_projects");
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
            }
            return userDS;
        }

        public void ProjectUpdate()
        {
        }

        public void ProjectDelete()
        {
        }

        /// <summary>
        /// Insert into History
        /// </summary>
        /// <param name="resultsID"></param>
        /// <param name="userName"></param>
        /// <param name="status"></param>
        /// <param name="defectID"></param>
        public void HistoryInsert(int resultsID, string userName, int status, string defectID)
        {
            try
            {
                using (MySqlConnection mySQLConnection = new MySqlConnection(ConnectString))
                using (MySqlCommand cmd = new MySqlCommand("tccomplete.sp_HistoryInsert", mySQLConnection)) 
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("?ResultUID", resultsID);
                    //cmd.Parameters.AddWithValue("?HistoryTime", );
                    cmd.Parameters.AddWithValue("?HistoryUserName", userName);
                    cmd.Parameters.AddWithValue("?HistoryStatus", status);
                    cmd.Parameters.AddWithValue("?HistoryDefectID", defectID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.MYSQL, ex.Message);
                throw ex;
            }
        }

    }
}