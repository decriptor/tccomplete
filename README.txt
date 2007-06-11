********* Required packages *********

Minimum MySQL version 5.x.x  (I'm using 5.0.26)
Minimum .NET connector 5.x (I'm using 5.1, http://dev.mysql.com/downloads/connector/net/5.1.html)

*Notes
MySQL has to be at least 5 since I'm using stored procedures and soon triggers
At one point I was using 1.0.7 connector, but no idea if that still works

********* Setup Notes *********

**Must be MySQL.  Its structed for other, just haven't written the class for them
**Permission mean nothing as of right now!!!

Database Setup
  mysql -u root -p < tccomplete_db_install.sql

  admin account that gets generated:
  user: admin
  pass: admin001
  
  For additional users:
  from mysql> run, call tccomplete.sp_userInsert("user","password",1,1,"User Name",1,1,1,1);
  again for any additional users

Compile application and it should kind of work.  STILL VERY ALPHA.


To run and debug the Test Case Server

	As a process, start it with some bogus argument.
		ie. testcaseserver.exe 1 (you can set that in VS 2005 debug settings for the project)

	As a service, don't supply an argument.  You will need to install it using the util/install.bat file
		and the util/uninstall to remove it.
		ie. testcaseserver.exe



