using System;
using System.Data;

namespace tccomplete.Interfaces
{
    public interface IDataAccess
    {
        DataSet UserLogin(string UserName, string UserPassword);

        void UserInsert();

        void UserUpdate();

        void UserDelete(int userID);

        DataSet ProjectRetrieve(int? projectUID, string projectName);

        void ProjectInsert(string projectName, string projectDescription);

        void ProjectUpdate();

        void ProjectDelete();

        DataSet BuildRetrieve(int? buildID, int? projectID, string buildName);

        void BuildInsert(int projectUID, string buildName, string buildDescription, int buildDisplay);

        void BuildUpdate();

        void BuildDelete();

        DataSet TestCaseRetrieve(int? tcuid);

        void TestCaseInsert(int ProjectUID, string TCOwner, int TCDefaultPriority, string TCShortDesc, int TCEtcSetup, int TCEtcRun,

            int TCEtcClean, string TCYouID, string TCDefectID, string TCPassFailDesc, string TCSetupSteps, string TCRunSteps, string TCCleanSteps);

        void TestCaseUpdate();

        void TestCaseDelete();

        void HistoryInsert(int resultsID, string userName, int status, string defectID);    

    }

}

