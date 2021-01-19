-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 01, 2020 at 05:17 AM
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
-- Database: `db_citach`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_announcement_information`
--

CREATE TABLE `tbl_announcement_information` (
  `Announcement_Identity` varchar(10) NOT NULL,
  `Announcement_Name` varchar(20) DEFAULT NULL,
  `Announcement_Description` varchar(5000) DEFAULT NULL,
  `Announcement_Image_Path` varchar(20) DEFAULT NULL,
  `Announcement_User_Identity` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_church_information`
--

CREATE TABLE `tbl_church_information` (
  `Church_Identity` varchar(10) NOT NULL,
  `Church_Name` varchar(20) DEFAULT NULL,
  `Church_Address` varchar(30) DEFAULT NULL,
  `Church_Leader` varchar(200) DEFAULT NULL,
  `Church_Image_Path` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_counter_information`
--

CREATE TABLE `tbl_counter_information` (
  `Counter_Identity` varchar(10) NOT NULL,
  `Counter_Code` varchar(10) DEFAULT NULL,
  `Counter_Count` int(10) DEFAULT NULL,
  `Counter_Description` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_counter_information`
--

INSERT INTO `tbl_counter_information` (`Counter_Identity`, `Counter_Code`, `Counter_Count`, `Counter_Description`) VALUES
('CNTR-0001', 'USR', 23, 'For Counting User Identity');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_log_information`
--

CREATE TABLE `tbl_log_information` (
  `Log_Identity` varchar(20) NOT NULL,
  `Log_Name` varchar(20) DEFAULT NULL,
  `Log_Description` varchar(255) DEFAULT NULL,
  `User_Identity` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user_credential_information`
--

CREATE TABLE `tbl_user_credential_information` (
  `User_Identity` varchar(10) NOT NULL,
  `User_Name` varchar(20) DEFAULT NULL,
  `User_Password` varchar(20) DEFAULT NULL,
  `User_Privilege` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user_personal_information`
--

CREATE TABLE `tbl_user_personal_information` (
  `User_Identity` varchar(10) NOT NULL,
  `User_Firstname` varchar(30) DEFAULT NULL,
  `User_Middlename` varchar(30) DEFAULT NULL,
  `User_Lastname` varchar(30) DEFAULT NULL,
  `User_Position` varchar(20) DEFAULT NULL,
  `User_Image_Path` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `test`
--

CREATE TABLE `test` (
  `test` varchar(16383) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `test4`
--

CREATE TABLE `test4` (
  `test` varchar(16383) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `test5`
--

CREATE TABLE `test5` (
  `test` varchar(16383) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_announcement_information`
--
ALTER TABLE `tbl_announcement_information`
  ADD PRIMARY KEY (`Announcement_Identity`);

--
-- Indexes for table `tbl_church_information`
--
ALTER TABLE `tbl_church_information`
  ADD PRIMARY KEY (`Church_Identity`);

--
-- Indexes for table `tbl_counter_information`
--
ALTER TABLE `tbl_counter_information`
  ADD PRIMARY KEY (`Counter_Identity`);

--
-- Indexes for table `tbl_log_information`
--
ALTER TABLE `tbl_log_information`
  ADD PRIMARY KEY (`Log_Identity`);

--
-- Indexes for table `tbl_user_credential_information`
--
ALTER TABLE `tbl_user_credential_information`
  ADD PRIMARY KEY (`User_Identity`);

--
-- Indexes for table `tbl_user_personal_information`
--
ALTER TABLE `tbl_user_personal_information`
  ADD PRIMARY KEY (`User_Identity`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
