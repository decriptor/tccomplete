SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

-- Database: `tccomplete`
-- --------------------------------------------------------
-- Table structure for table `login`

CREATE TABLE `login` (
  `Username` varchar(100) NOT NULL default '',
  `Password` varchar(100) NOT NULL default '',
  `dhcp_rights` tinyint(1) NOT NULL default '0',
  `user_rights` tinyint(1) NOT NULL default '0',
  `administrator` tinyint(1) NOT NULL default '0',
  `maintableorder` mediumtext NOT NULL,
  `realname` varchar(100) NOT NULL default '',
  `assettagdisplayorder` mediumtext NOT NULL,
  `tcdb_filter` tinyint(1) NOT NULL,
  `tcdb_build` tinyint(1) NOT NULL default '0',
  `tcdb_build_rights` tinyint(1) NOT NULL default '0',
  `tcdb_tc_rights` tinyint(1) NOT NULL default '0',
  `tcdb_os_rights` tinyint(1) NOT NULL default '0',
  `tcdb_pass_rights` tinyint(1) NOT NULL default '1',
  PRIMARY KEY  (`Username`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------
-- Table structure for table `tcdb_builds`

CREATE TABLE `tcdb_builds` (
  `uid` int(11) NOT NULL auto_increment,
  `project_uid` int(11) NOT NULL default '0',
  `name` tinytext NOT NULL,
  `description` mediumtext NOT NULL,
  `date` timestamp NOT NULL default CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP,
  `display` int(11) default '1',
  PRIMARY KEY  (`uid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------
-- Table structure for table `tcdb_history`

CREATE TABLE `tcdb_history` (
  `results_uid` int(11) NOT NULL default '0',
  `time` timestamp NULL default CURRENT_TIMESTAMP,
  `username` tinytext NOT NULL,
  `status` int(11) NOT NULL default '0',
  `defect_id` tinytext
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------
-- Table structure for table `tcdb_platforms`

CREATE TABLE `tcdb_platforms` (
  `uid` int(11) NOT NULL auto_increment,
  `project_uid` int(11) NOT NULL default '0',
  `name` tinytext NOT NULL,
  `description` mediumtext,
  PRIMARY KEY  (`uid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------
-- Table structure for table `tcdb_projects`

CREATE TABLE `tcdb_projects` (
  `uid` int(11) NOT NULL auto_increment,
  `name` tinytext NOT NULL,
  `description` mediumtext,
  PRIMARY KEY  (`uid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------
-- Table structure for table `tcdb_results`

CREATE TABLE `tcdb_results` (
  `uid` int(11) NOT NULL auto_increment,
  `testcase_uid` int(11) NOT NULL default '0',
  `build_uid` int(11) NOT NULL default '0',
  `status` int(11) NOT NULL default '0',
  `updated_by` tinytext,
  `update_time` timestamp NOT NULL default CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP,
  `update_notes` mediumtext,
  `bug_id` tinytext,
  `checkout_time` timestamp NULL default '0000-00-00 00:00:00',
  PRIMARY KEY  (`uid`),
  UNIQUE KEY `id` (`testcase_uid`,`build_uid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------
-- Table structure for table `tcdb_testcases`

CREATE TABLE `tcdb_testcases` (
  `uid` int(11) NOT NULL auto_increment,
  `project_uid` int(11) NOT NULL default '0',
  `owner` tinytext NOT NULL,
  `default_priority` int(11) NOT NULL default '0',
  `short_desc` tinytext NOT NULL,
  `etc_setup` int(11) NOT NULL default '0',
  `etc_run` int(11) NOT NULL default '0',
  `etc_clean` int(11) default '0',
  `you_id` varchar(64) default NULL,
  `defect_id` varchar(15) default NULL,
  `pass_fail_desc` mediumtext,
  `setup_steps` mediumtext,
  `run_steps` mediumtext,
  `clean_steps` mediumtext,
  PRIMARY KEY  (`uid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

