using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TestCaseComplete
{

    public class UserCredentials
    {
        String userName, realName;
        bool admin;
        bool isValidUser = false;
        int build, project, testCase, userAdmin, readWrite;
        public UserCredentials(DataRow dr)
        {
            if (dr != null)
            {
                userName = dr[0].ToString();
                userAdmin = Convert.ToInt32(dr[1]);
                admin = Convert.ToBoolean(dr[2]);
                realName = dr[3].ToString();
                project = Convert.ToInt32(dr[4]);
                build = Convert.ToInt32(dr[5]);
                testCase = Convert.ToInt32(dr[6]);
                readWrite = Convert.ToInt32(dr[7]);
                isValidUser = true;
            }
            else
            {
                isValidUser = false;
            }
        }
        public string UserName
        {
            get { return userName; }
        }
        public string RealName
        {
            get { return realName; }
        }
        public bool Admin
        {
            get { return admin; }
        }
        public int Build
        {
            get { return build; }
        }        
        public int Project
        {
            get { return project; }
        }
        public int TestCase
        {
            get { return testCase; }
        }

        public int UserAdmin
        {
            get { return userAdmin; }
        }

        public int ReadWrite
        {
            get { return readWrite; }        }
        public bool isUserValid
        {
            get { return isValidUser; }
        }
    }
}
