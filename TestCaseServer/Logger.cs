using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TestCaseServer
{
    class Logger
    {
        #region Variables
        string _sFileLocation = string.Empty;

        #endregion        
        public enum LOGTYPE
        {
            NOTICE,
            WARN,
            ERR,
            CRIT,
            ALERT
        }
        public enum APPTYPE
        {
            CLIENT,
            MYSQL,
            SERVER
        }
        public Logger()
        {
        }
        public void LogEvent(LOGTYPE logType, APPTYPE appType, string message)
        {
            LogEvent(logType + " " + appType + " " + message);
            //if (logType == LOGTYPE.ALERT)
            //{
            //}
        }
        
        private void LogEvent(string message)
		{
			int p = (int) Environment.OSVersion.Platform;
			if ((p == 4) || (p == 128))
            {
                EventLog.WriteEntry("Server", message);
				//Mono.Unix.Native.Syscall.syslog(Mono.Unix.Native.SyslogLevel.LOG_INFO, message);
			}
            else
            {
                EventLog.WriteEntry("Server", message);
			}
		}

    }
}
