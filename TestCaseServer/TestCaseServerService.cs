using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.ServiceProcess;
using System.Threading;

namespace TestCaseServer
{
    class TestCaseServerService : ServiceBase
    {
		static volatile TestCaseServerState state = TestCaseServerState.Stopped;
		Logger LOGGER = new Logger();
        TcpChannel channel;
        int portNumber = -1;

		enum TestCaseServerState: byte 
		{ 
			Stopped,	// Default state - not running 
			Run, 		// Command thread to start
			Running, 	// Thread reports as started and operating
			Stop, 		// Command thread to halt
			Stopping	// Thread reports as halting (goes to Stopped when finished)
		}

		public void TestCaseServer()
		{
			this.ServiceName = "TestCaseServer";
			this.CanStop = true;
			this.CanPauseAndContinue = true;
			this.AutoLog = true;
            LOGGER.LogEvent(Logger.LOGTYPE.NOTICE, Logger.APPTYPE.SERVER, "New Test Case Server Service Created");
		}

        public static void Main(string[] args)
        {
            //if (args.Length > 0)
            //{
            //    ServiceBase[] ServicesToRun;
            //    ServicesToRun = new ServiceBase[] { new TestCaseServerService() };
            //    ServiceBase.Run(ServicesToRun);

                int i = 0;
                while(args.Length >= 0)
                {
                    switch(args[i].ToLower())
                    {
                        case "usage":
                            PrintUsage();
                            break;
                        case "service":
                            ServiceBase[] ServicesToRun;
                            ServicesToRun = new ServiceBase[] { new TestCaseServerService() };
                            ServiceBase.Run(ServicesToRun);
                            break;
                        case "standalone":
                            TestCaseServerService ips = new TestCaseServerService();
                            ips.OnStart(null);
                            Thread.Sleep(Timeout.Infinite);
                            break;                    
                        case "ip":
                            break;
                        default:
                            PrintUsage();
                            break;
                    }
                }
            //}
            //else
            //{
            //    ServiceBase[] ServicesToRun;
            //    ServicesToRun = new ServiceBase[] { new TestCaseServerService() };
            //    ServiceBase.Run(ServicesToRun);
            //}
        }

		protected override void OnStart (string[] args)
		{
            LOGGER.LogEvent(Logger.LOGTYPE.NOTICE, Logger.APPTYPE.SERVER, "Test Case Server starting...");
			state = TestCaseServerState.Run;

            try
            {
                portNumber = 8080; //temp solution
                channel = new TcpChannel(portNumber);
                ChannelServices.RegisterChannel(channel, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(DataAccess), "DataAccess", WellKnownObjectMode.SingleCall);
                state = TestCaseServerState.Running;
                LOGGER.LogEvent(Logger.LOGTYPE.NOTICE, Logger.APPTYPE.SERVER, "Test Case Server started successfully!");
            }
            catch (Exception ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.CRIT, Logger.APPTYPE.SERVER, ex.Message);
                LOGGER.LogEvent(Logger.LOGTYPE.ERR, Logger.APPTYPE.SERVER,
                    (String.Format("Test Case Server is currently in the {0} state instead of the Running state.  Aborting.", state.ToString())));
                OnStop();
            }
		}
		
		protected override void OnStop ()
		{
			if (state != TestCaseServerState.Stopped)
            {
				state = TestCaseServerState.Stop;
                ChannelServices.UnregisterChannel(channel);
			}
            LOGGER.LogEvent(Logger.LOGTYPE.NOTICE, Logger.APPTYPE.SERVER, "Test Case Server stopped.");
		}

        protected override void OnContinue()
        {
            try
            {
                channel.StartListening(channel);
                LOGGER.LogEvent(Logger.LOGTYPE.NOTICE, Logger.APPTYPE.SERVER, "Test Case Server Continued...");
            }
            catch (Exception ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.NOTICE, Logger.APPTYPE.SERVER, ex.Message);
            }
        }

        protected override void OnPause()
        {
            try
            {
                channel.StopListening(channel);
                LOGGER.LogEvent(Logger.LOGTYPE.NOTICE, Logger.APPTYPE.SERVER, "Test Case Server Paused...");
            }
            catch (Exception ex)
            {
                LOGGER.LogEvent(Logger.LOGTYPE.NOTICE, Logger.APPTYPE.SERVER, ex.Message);
            }
        }

        private static void PrintUsage()
        {
            Console.WriteLine("HELP ME!!!");
        }
    }
}