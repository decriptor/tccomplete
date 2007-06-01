using System;
using System.Collections.Generic;
using System.Text;

namespace TestCaseServer
{
    class ConfigReader
    {
        #region Variables
        string WindowsConfigLocation = string.Empty;     //Windows Config File Location        string LinuxConfigLocation = string.Empty;     //Linux Config File Location
        string ActiveConfigFile = string.Empty;

        #endregion

        public ConfigReader()
        {
            //if(Environment.OSVersion == 
            int p = (int)Environment.OSVersion.Platform;
            if ((p == 4) || (p == 128))
            {
                //EventLog.WriteEntry("Server", message);
                //Mono.Unix.Native.Syscall.syslog(Mono.Unix.Native.SyslogLevel.LOG_INFO, message);
            }
            else
            {
                //EventLog.WriteEntry("Server", message);
            }
        }   



    }
}