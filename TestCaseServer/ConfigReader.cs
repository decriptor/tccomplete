using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestCaseServer
{
    class ConfigClass
    {
        #region Variables

        string WindowsConfigLocation = @"c:\Program Files\tccomplete\server.conf";  //Windows Config File Location
        string LinuxConfigLocation = @"/etc/tccomplete/server.conf";                //Linux Config File Location
        string ActiveConfigFile = string.Empty;
        List<string> settings;
        #endregion

        public ConfigClass()
        {
            //FileStream file = new FileStream("path.txt", FileMode, FileAccess);
            settings = new List<string>();

            int p = (int)Environment.OSVersion.Platform;
            if ((p == 4) || (p == 128))
            {
                ActiveConfigFile = LinuxConfigLocation;

            }
            else
            {
                ActiveConfigFile = WindowsConfigLocation;
            }
            FileStream configFile = new FileStream(ActiveConfigFile, FileMode.Open, FileAccess.Read);
        }

        public ConfigClass(string fileLocation)
        {
            ActiveConfigFile = fileLocation;
            FileStream configFile = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);

        }

        protected void ConfigReader()
        {


        }

        protected void ConfigReader(string fileLocation)
        {


        }

    }
}