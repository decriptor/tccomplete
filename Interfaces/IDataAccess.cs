using System;
using System.Data;

namespace tccomplete.Interfaces
{
    public interface IDataAccess
    {
        #region Users
        DataSet UserLogin(string UserName, string UserPassword);

        void UserInsert(string userName, string userPassword, int userAdmin, int administrator, string realName,
            int projectAdmin, int buildAdmin, int testCaseAdmin, int readWriteAccess);

        void UserUpdate(string oldUserName, string newUserName, int userAdmin, int admin, string realName, int projectAdmin,
            int buildAdmin, int testCaseAdmin, int readWriteAccess);

        void UserDelete(int userID);
        #endregion

        #region Project
        DataSet ProjectRetrieve(int? projectID, string projectName);

        void ProjectInsert(string projectName, string projectDescription);

        void ProjectUpdate(int projectID, string projectName, string projectDescription);

        void ProjectDelete(int projectID);
        #endregion

        #region Builds
        DataSet BuildRetrieve(int? buildID, int? projectID, string buildName);

        void BuildInsert(int projectID, string buildName, string buildDescription, int buildDisplay);

        void BuildUpdate(int buildID, int projectID, string buildName, string buildDescription, int buildDisplay);

        void BuildDelete(int buildID);
        #endregion

        #region Results
        void ResultsInsert(int testCaseID, int buildID, string resultStatus, string updatedBy, string updateNotes, string bugID);

        DataSet ResultsRetrieve(int? resultID, int? testCaseID, int? buildID, string resultStatus, string updatedBy, string updateNotes, string bugID, DateTime? checkOutTime);

        void ResultsCheckIn(int resultID, int newStatus, string updatedBy, string updateNotes);
        
        void ResultsCheckOut(int testCaseID, int buildID);
        
        void ResultsUpdate(int testCaseID, int buildID, string resultStatus, string updatedBy, string updateNotes);

        void ResultsDelete(int testCaseID, int buildID);
        #endregion

        #region Test Case
        DataSet TestCaseRetrieve(int? testCaseID, int? projectID);

        void TestCaseInsert(int projectID, string testCaseOwner, int defaultPriority, string shortDescription, int setupTime, int runTime,
            int cleanTime, string userID, string defectID, string passFailDescription, string setupSteps, string runSteps, string cleanSteps);

        void TestCaseUpdate(int testCaseID, int projectID, string testCaseOwner, int defaultPriority, string shortDescription, int setupTime, int runTime,
            int cleanTime, string userID, string defectID, string passFailDescription, string setupSteps, string runSteps, string cleanSteps);

        void TestCaseDelete(int testCaseID);
        #endregion

        #region Work List
        DataSet WorkListRetrieve(string updatedBy);
        #endregion

        #region History
        DataSet HistoryRetrieve(int? resultID, DateTime? historyTime, string userName, int? status, string defectID);
        #endregion
    }
}

