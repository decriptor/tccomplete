using System;
using System.Collections.Generic;
using System.Text;
using tccomplete.Interfaces;

namespace TestCaseComplete
{
	static class Client
	{
		//static internal string hostName = "localhost";
		static String URL = @"tcp://localhost:8080/DataAccess";
	    static internal IDataAccess dataAccess = (IDataAccess)Activator.GetObject(typeof(IDataAccess), URL);
	}
}
