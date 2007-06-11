-- Build Test Case Complete DataBase --

-- Create Database
create database tccomplete;

-- Create Test Case DataBase User Grant Permissions
create USER 'tcdbuser'@'10.1.1.%' IDENTIFIED BY 'tcdbuser001!';
GRANT ALL PRIVILEGES ON `tccomplete` . * TO 'tcdbuser'@'10.1.1.%' WITH GRANT OPTION;
GRANT SELECT ON `mysql`.`proc` TO 'tcdbuser'@'10.1.1.%';
create USER 'tcdbuser'@'localhost' IDENTIFIED BY 'tcdbuser001!';
GRANT ALL PRIVILEGES ON `tccomplete` . * TO 'tcdbuser'@'localhost' WITH GRANT OPTION;
flush privileges;

-- Select Database
use tccomplete;

-- Create the tables;
--
-- Host: localhost    Database: tccomplete
-- ------------------------------------------------------
-- Server version       5.0.26

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `builds`
--

DROP TABLE IF EXISTS `builds`;
CREATE TABLE `builds` (
  `id` int(11) NOT NULL auto_increment,
  `project_id` int(11) NOT NULL default '0',
  `name` tinytext NOT NULL,
  `description` mediumtext NOT NULL,
  `date` timestamp NOT NULL default CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP,
  `display` int(11) default '1',
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `builds`
--

LOCK TABLES `builds` WRITE;
/*!40000 ALTER TABLE `builds` DISABLE KEYS */;
/*!40000 ALTER TABLE `builds` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `history`
--

DROP TABLE IF EXISTS `history`;
CREATE TABLE `history` (
  `results_id` int(11) NOT NULL default '0',
  `time` timestamp NULL default CURRENT_TIMESTAMP,
  `username` tinytext NOT NULL,
  `status` int(11) NOT NULL default '0',
  `defect_id` tinytext
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `history`
--

LOCK TABLES `history` WRITE;
/*!40000 ALTER TABLE `history` DISABLE KEYS */;
/*!40000 ALTER TABLE `history` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `platforms`
--

DROP TABLE IF EXISTS `platforms`;
CREATE TABLE `platforms` (
  `id` int(11) NOT NULL auto_increment,
  `project_id` int(11) NOT NULL default '0',
  `name` tinytext NOT NULL,
  `description` mediumtext,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `platforms`
--

LOCK TABLES `platforms` WRITE;
/*!40000 ALTER TABLE `platforms` DISABLE KEYS */;
/*!40000 ALTER TABLE `platforms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `projects`
--

DROP TABLE IF EXISTS `projects`;
CREATE TABLE `projects` (
  `id` int(11) NOT NULL auto_increment,
  `name` tinytext NOT NULL,
  `description` mediumtext,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `projects`
--

LOCK TABLES `projects` WRITE;
/*!40000 ALTER TABLE `projects` DISABLE KEYS */;
/*!40000 ALTER TABLE `projects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `results`
--

DROP TABLE IF EXISTS `results`;
CREATE TABLE `results` (
  `id` int(11) NOT NULL auto_increment,
  `testcase_id` int(11) NOT NULL default '0',
  `build_id` int(11) NOT NULL default '0',
  `status` int(11) NOT NULL default '0',
  `updated_by` tinytext,
  `update_time` timestamp NOT NULL default CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP,
  `update_notes` mediumtext,
  `bug_id` tinytext,
  `checkout_time` datetime NULL default NULL,
  PRIMARY KEY  (`id`),
  UNIQUE KEY `id` (`testcase_id`,`build_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `results`
--

LOCK TABLES `results` WRITE;
/*!40000 ALTER TABLE `results` DISABLE KEYS */;
/*!40000 ALTER TABLE `results` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `testcases`
--

DROP TABLE IF EXISTS `testcases`;
CREATE TABLE `testcases` (
  `id` int(11) NOT NULL auto_increment,
  `project_id` int(11) NOT NULL default '0',
  `owner` tinytext NOT NULL,
  `default_priority` int(11) NOT NULL default '0',
  `short_description` tinytext NOT NULL,
  `setup_time` int(11) NOT NULL default '0',
  `run_time` int(11) NOT NULL default '0',
  `clean_time` int(11) default '0',
  `user_id` varchar(64) default NULL,
  `defect_id` varchar(15) default NULL,
  `status_description` mediumtext,
  `setup_steps` mediumtext,
  `run_steps` mediumtext,
  `clean_steps` mediumtext,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `testcases`
--

LOCK TABLES `testcases` WRITE;
/*!40000 ALTER TABLE `testcases` DISABLE KEYS */;
/*!40000 ALTER TABLE `testcases` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `Username` varchar(100) NOT NULL default '',
  `Password` varchar(100) NOT NULL default '',
  `user_admin` tinyint(1) NOT NULL default '0',
  `administrator` tinyint(1) NOT NULL default '0',
  `realname` varchar(100) NOT NULL default '',
  `tc_project` tinyint(1) NOT NULL default '0',
  `tc_build` tinyint(1) NOT NULL default '0',
  `tc_testcase` tinyint(1) NOT NULL default '0',
  `readwrite` tinyint(1) NOT NULL default '1',
  PRIMARY KEY  (`Username`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('admin','*A65C936CD4D76DC12FA3E50AB5F1C5026F66B729',1,1,'Administrator',1,1,1,1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2007-06-02  9:20:34

delimiter |
-- Creating Stored Procedures
-- ################### Builds ###################
-- ####Build Delete####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_BuildDelete`(buildID int(11))
BEGIN
DELETE FROM builds
WHERE (id = buildID);
END|
-- ####Build Insert####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_BuildInsert`(IN projectID int(11), IN buildName tinytext, IN buildDescription mediumtext, IN buildDate timestamp, IN buildDisplay int(11))
BEGIN
INSERT INTO builds(project_id, name, description, date, display)
VALUES (projectID, buildName, buildDescription, buildDate, buildDisplay);
END|
-- ####Build Retrieve####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_BuildRetrieve`(buildID int(11), projectID int(11), buildName tinytext)
BEGIN
SELECT *
FROM builds
WHERE ((buildID IS NULL) OR (id = buildID)) AND (( projectID IS NULL) OR ( project_id = projectID)) AND (( buildName IS NULL)OR ( name = buildName))
ORDER BY name ASC;
END|
-- ####Build Update####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_BuildUpdate`(buildID int(11), IN projectID int(11), IN buildName tinytext, IN buildDescription mediumtext, IN buildDate timestamp, IN buildDisplay int(11))
BEGIN
UPDATE builds
SET project_id = projectID, name = buildName, description = buildDescription, date = buildDate, display = buildDisplay
WHERE (id = buildID);
END|
-- ################### Projects ###################
-- ####Project Delete####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_ProjectDelete`(projectID tinyint(11))
BEGIN
DELETE FROM projects
WHERE id = projectID;
END|
-- ####Project Insert####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_ProjectInsert`(IN projectName tinytext, IN projectDescription mediumtext)
BEGIN
INSERT INTO projects(name, description)
VALUES (projectName, projectDescription);
END|
-- ####Project Retrieve####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_ProjectRetrieve`(projectID int(11), projectName tinytext)
BEGIN
SELECT *
FROM projects
WHERE ((projectID IS NULL) OR (id = projectID)) AND ((projectName IS NULL) OR ( name = projectName));
END|
-- ####Project Update####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_ProjectUpdate`(projectID int(11), IN projectName tinytext, IN projectDescription mediumtext)
BEGIN
UPDATE projects
SET name = projectName, description = projectDescription
WHERE id = projectID;
END|
-- ################### Results ###################
-- ####Results Checkin####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_ResultCheckIn`(resultID int(11), IN newStatus int(11), IN updatedBy tinytext, IN updateNotes mediumtext)
BEGIN
UPDATE results
SET status = newStatus, updated_by = updatedBy, update_time = CURRENT_TIMESTAMP, update_notes = updateNotes, checkout_time = NULL
WHERE (id = resultID);
END|
-- ####Results Checkout####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_ResultCheckOut`(testCaseID int(11), buildID int(11))
BEGIN
UPDATE results
SET checkout_time = CURRENT_TIMESTAMP
WHERE (testcase_id = testCaseID) AND (build_id = buildID);
END|
-- ####Results Delete####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_ResultDelete`(testCaseID int(11), buildID int(11))
BEGIN
DELETE FROM results
WHERE (testcase_id = testCaseID) AND (build_id = buildID);
END|
-- ####Results Insert####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_ResultInsert`(IN testCaseID int(11), IN buildID int(11), IN resultStatus mediumtext, IN updatedBy tinytext, IN updateNotes mediumtext, IN bugID tinytext)
BEGIN
INSERT INTO results(testcase_id, build_id, status, updated_by, update_notes, bug_id)
VALUES (testCaseID, buildID, resultStatus, updatedBy, updateNotes, bugID);
END|
-- ####Results Retrieve####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_ResultRetrieve`(resultID int(11), testCaseID int(11), buildID int(11), resultStatus mediumtext, updatedBy tinytext, updateNotes mediumtext, bugID tinytext, checkout timestamp)
BEGIN
SELECT *
FROM results
WHERE ((resultID IS NULL) OR ( id = resultID)) AND ((testCaseID IS NULL) OR ( testcase_id = testCaseID)) AND ((buildID IS NULL) OR (build_id = buildID)) AND ((resultStatus IS NULL) OR ( status = resultStatus)) AND ((updatedBy IS NULL) OR (updated_by = updatedBy)) AND ((updateNotes IS NULL) OR (update_notes = updateNotes)) AND ((bugID IS NULL) OR (bug_id = bugID)) AND ((checkout IS NULL) OR (checkout_time = checkout));
END|
-- ####Results Update####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_ResultUpdate`(testCaseID int(11), buildID int(11), IN resultStatus mediumtext, IN updatedBy tinytext, IN updateNotes mediumtext)
BEGIN
UPDATE results
SET status = resultStatus, updated_by = updatedby, update_notes = updateNotes
WHERE (testcase_id = testCaseID) AND (build_id = buildID);
END|
-- ################### Test Cases ###################
-- ####Test Case Delete####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_TestCaseDelete`(testCaseID int(11))
BEGIN
DELETE FROM testcases
WHERE (id = testCaseID);
END|
-- ####Test Case Insert####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_TestCaseInsert`(IN projectID int(11), IN testCaseOwner tinytext, IN defaultPriority int(11), IN shortDescription tinytext, IN setupTime int(11), IN runTime int(11), IN cleanTime int(11), IN userID varchar(64), IN defectID varchar(15), IN statusDescription mediumtext, IN setupSteps mediumtext, IN runSteps mediumtext, IN cleanSteps mediumtext)
BEGIN
INSERT INTO testcases(project_id, owner, default_priority, short_description, setup_time, run_time, clean_time, user_id, defect_id, status_description, setup_steps, run_steps, clean_steps)
VALUES (projectID, testCaseOwner, defaultPriority, shortDescription, setupTime, runTime, cleanTime, userID, defectID, statusDescription, setupSteps, runSteps, cleanSteps);
END|
-- ####Test Case Retrieve####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_TestCaseRetrieve`(testCaseID int(11), projectID int(11))
BEGIN
SELECT *
FROM testcases
WHERE ((testCaseID IS NULL) OR (id = testCaseID)) AND ((projectID IS NULL) OR (project_id = projectID));
END|
-- ####Test Case Update####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_TestCaseUpdate`(testCaseID int(11), IN projectID int(11), IN testCaseOwner tinytext, IN defaultPriority int(11), IN shortDescription tinytext, IN setupTime int(11), IN runTime int(11), IN cleanTime int(11), IN userID varchar(64), IN defectID varchar(15), IN statusDescription mediumtext, IN setupSteps mediumtext, IN runSteps mediumtext, IN cleanSteps mediumtext)
BEGIN
UPDATE testcases
SET project_id = projectID, owner = testCaseOwner, default_priority = defaultPriority, short_description = shortDescription, setup_time = setupTime, run_time = runTime, clean_time = cleanTime, user_id = userID, defect_id = defectID, status_description = statusDescription, setup_steps = setupSteps, run_steps = runSteps, clean_steps = cleanSteps
WHERE (id = testCaseID);
END|
-- ################### Users ###################
-- ####Users Change Password####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_UserChangePassword`(loginUser varchar(100), oldPassword varchar(100), IN newPassword varchar(100))
BEGIN
UPDATE users
SET Password = PASSWORD(newPassword)
WHERE (Username = loginUser) AND (Password = PASSWORD(oldPassword));
END|

-- ####Users Delete####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_UserDelete`(userName varchar(100))
BEGIN
DELETE FROM users
WHERE Username = userName;
END|
-- ####Users Insert####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_UserInsert`(IN userName varchar(100), IN userPass varchar(100), IN userAdmin tinyint(1), IN admin tinyint(1), IN realName varchar(100), IN projectAdmin tinyint(1), IN buildAdmin tinyint(1), IN testCaseAdmin tinyint(1), IN readWriteAccess tinyint(1))
BEGIN
INSERT INTO users(Username, Password, user_admin, administrator, realname, tc_project, tc_build, tc_testcase, readwrite)
VALUES (userName, PASSWORD(userPass), userAdmin, admin, realName, projectAdmin, buildAdmin, testCaseAdmin, readWriteAccess);
END|
-- ####Users Login####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_UserLogin`(LoginUser varchar(100), LoginPass varchar(100))
BEGIN
SELECT Username, user_admin, administrator, realname, tc_project, tc_build, tc_testcase, readwrite
FROM users
WHERE (Username = LoginUser) AND (Password = PASSWORD(LoginPass));
END|
-- ####Users Retrieve####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_UserRetrieve`(users varchar(100))
BEGIN
SELECT *
FROM users
WHERE (users IS NULL) OR (Username = users);
END|
-- ####Users Update####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_UserUpdate`(oldUserName varchar(100), IN newUserName varchar(100), IN userAdmin tinyint(1), IN admin tinyint(1), IN realName varchar(100), IN projectAdmin tinyint(1), IN buildAdmin tinyint(1), IN testCaseAdmin tinyint(1), IN readWriteAccess tinyint(1))
BEGIN
UPDATE users
SET Username = newUserName, user_admin = userAdmin, administrator = admin, realname = realName, tc_project = projectAdmin, tc_build = buildAdmin, tc_testcase = testCaseAdmin, readwrite = readWriteAccess
WHERE Username = oldUserName;
END|
-- ################### Work List ###################
-- ####Work List Retrieve####
CREATE DEFINER=`tcdbuser`@`10.1.1.%` PROCEDURE `sp_WorkListRetrieve`(updatedBy tinytext)
BEGIN
SELECT *
FROM results
WHERE (updated_by = updatedBy) AND (checkout_time IS NOT NULL);
END|
delimiter ;

