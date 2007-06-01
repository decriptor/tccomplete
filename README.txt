********* 5/25/2007 *********

Cleaned up some of the stored procedure, logging in should work now.


********* Setup Notes *********

**Must be MySQL.  Its structed for other, just haven't written the class for them
**Permission mean nothing as of right now!!!

Database Setup
  Create database tccomplete
  run tccomplete.sql
  run tccomplete_procs.sql
  create user tcdbuser
  update pass tcdbuser001!
  grant on database tccomplete
  select privs on mysql.procs (otherwise it can't run the stored procedures if server is not on localhost)
  from mysql> run, call tccomplete.sp_userInsert("admin","admin",1,1,"Stephen Shaw",1,1,1,1,1,1);
  again for any additional users

Compile application and it should kind of work.  STILL very alpha.


To run and debug the Test Case Server

	As a process, start it with some bogus argument.
		ie. testcaseserver.exe 1 (you can set that in VS 2005 debug settings for the project)

	As a service, don't supply an argument.  You will need to install it using the util/install.bat file
		and the util/uninstall to remove it.
		ie. testcaseserver.exe



