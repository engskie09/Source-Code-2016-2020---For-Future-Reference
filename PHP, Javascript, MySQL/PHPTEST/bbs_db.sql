-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 19, 2019 at 03:02 AM
-- Server version: 10.3.15-MariaDB
-- PHP Version: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bbs_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_blogger_information`
--

CREATE TABLE `tbl_blogger_information` (
  `blogger_UserID` varchar(50) NOT NULL,
  `blogger_UserName` text DEFAULT NULL,
  `blogger_UserPassword` text DEFAULT NULL,
  `blogger_UserRole` text DEFAULT NULL,
  `blogger_UserEmailAddress` text DEFAULT NULL,
  `blogger_FirstName` text DEFAULT NULL,
  `blogger_LastName` text DEFAULT NULL,
  `blogger_DateRegistered` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_blogger_information`
--

INSERT INTO `tbl_blogger_information` (`blogger_UserID`, `blogger_UserName`, `blogger_UserPassword`, `blogger_UserRole`, `blogger_UserEmailAddress`, `blogger_FirstName`, `blogger_LastName`, `blogger_DateRegistered`) VALUES
('blggr-27628', 'q', 'cFFudEtTZWQ5R0JneUg5UU02VEd4UT09', 'Blogger', 'q@q', 'q', 'q', 'June 19, 2019 5:54:am  ');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_blog_information`
--

CREATE TABLE `tbl_blog_information` (
  `blog_ID` varchar(50) NOT NULL,
  `blog_Title` text DEFAULT 'NULL',
  `blog_Content` text DEFAULT NULL,
  `blog_PostedBy` text DEFAULT 'NULL',
  `blog_DatePosted` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_blogger_information`
--
ALTER TABLE `tbl_blogger_information`
  ADD PRIMARY KEY (`blogger_UserID`);

--
-- Indexes for table `tbl_blog_information`
--
ALTER TABLE `tbl_blog_information`
  ADD PRIMARY KEY (`blog_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
