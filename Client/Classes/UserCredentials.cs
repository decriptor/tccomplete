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
        int filter, build, buildRights, userRights, tcRights, osRights, passRights;
        public UserCredentials(DataRow dr)
        {
            if (dr != null)
            {
                userName = dr[0].ToString();
                realName = dr[3].ToString();
                admin = Convert.ToBoolean(dr[2]);
                filter = Convert.ToInt32(dr[4]);
                build = Convert.ToInt32(dr[5]);
                buildRights = Convert.ToInt32(dr[6]);
                userRights = Convert.ToInt32(dr[1]);
                tcRights = Convert.ToInt32(dr[7]);
                osRights = Convert.ToInt32(dr[8]);
                passRights = Convert.ToInt32(dr[9]);
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
        public int Filter
        {
            get { return filter; }
        }        
        public int Build
        {
            get { return build; }
        }
        public int BuildRights
        {
            get { return buildRights; }
        }
        public int UserRights
        {
            get { return userRights; }
        }
        public int TCRights
        {
            get { return tcRights; }        }
        public int OSRights
        {
            get { return osRights; }
        }
        public int PassRights
        {
            get { return passRights; }
        }

        public bool isUserValid
        {
            get { return isValidUser; }
        }
    }
}
