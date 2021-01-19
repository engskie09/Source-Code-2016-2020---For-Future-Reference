-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 12, 2019 at 02:30 PM
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
-- Database: `db_payroll`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_attendance_information_current`
--

CREATE TABLE `tbl_attendance_information_current` (
  `attendance_ID` varchar(50) NOT NULL,
  `attendance_TimeIn` text DEFAULT NULL,
  `attendance_TimeOut` text DEFAULT NULL,
  `attendance_Date` text DEFAULT NULL,
  `user_ID` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_attendance_information_current`
--

INSERT INTO `tbl_attendance_information_current` (`attendance_ID`, `attendance_TimeIn`, `attendance_TimeOut`, `attendance_Date`, `user_ID`) VALUES
('ATDC-2019-07-12-950119', '12:38:41', '12:38:42', '2019-07-12', 'USER-2019-07-03-849970');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_attendance_information_report`
--

CREATE TABLE `tbl_attendance_information_report` (
  `attendance_ID` varchar(50) NOT NULL,
  `attendance_TimeIn` text DEFAULT NULL,
  `attendance_TimeOut` text DEFAULT NULL,
  `attendance_Date` text DEFAULT NULL,
  `user_ID` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_attendance_information_report`
--

INSERT INTO `tbl_attendance_information_report` (`attendance_ID`, `attendance_TimeIn`, `attendance_TimeOut`, `attendance_Date`, `user_ID`) VALUES
('ATDC-2019-07-12-950119', '12:38:41', '12:38:42', '2019-07-12', 'USER-2019-07-03-849970');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_position_information`
--

CREATE TABLE `tbl_position_information` (
  `position_ID` varchar(50) NOT NULL,
  `position_Name` text NOT NULL,
  `position_Description` text NOT NULL,
  `rate_ID` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_position_information`
--

INSERT INTO `tbl_position_information` (`position_ID`, `position_Name`, `position_Description`, `rate_ID`) VALUES
('PSTN-2019-07-12-819622', '123', 'asdasd', NULL),
('PSTN-2019-07-12-826740', 'asd', 'ads', 'RT-01'),
('PSTN-2019-07-12-983440', 'qwe', 'qwe', 'RT-01');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_rate_information`
--

CREATE TABLE `tbl_rate_information` (
  `rate_ID` varchar(50) NOT NULL,
  `rate_Value` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user_information_credential`
--

CREATE TABLE `tbl_user_information_credential` (
  `user_ID` varchar(50) NOT NULL,
  `user_Name` text DEFAULT NULL,
  `user_Password` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_user_information_credential`
--

INSERT INTO `tbl_user_information_credential` (`user_ID`, `user_Name`, `user_Password`) VALUES
('USER-2019-07-03-849970', 'rafael', '123');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user_information_personal`
--

CREATE TABLE `tbl_user_information_personal` (
  `user_ID` varchar(50) NOT NULL,
  `user_FirstName` text DEFAULT NULL,
  `user_MiddleName` text DEFAULT NULL,
  `user_LastName` text DEFAULT NULL,
  `user_Position` text DEFAULT NULL,
  `user_ContactNumber` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_user_information_personal`
--

INSERT INTO `tbl_user_information_personal` (`user_ID`, `user_FirstName`, `user_MiddleName`, `user_LastName`, `user_Position`, `user_ContactNumber`) VALUES
('USER-2019-07-03-849970', 'Rafael', 'Nobleza', 'Masallo', 'Admin', '091234567890');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_attendance_information_current`
--
ALTER TABLE `tbl_attendance_information_current`
  ADD PRIMARY KEY (`attendance_ID`);

--
-- Indexes for table `tbl_attendance_information_report`
--
ALTER TABLE `tbl_attendance_information_report`
  ADD PRIMARY KEY (`attendance_ID`);

--
-- Indexes for table `tbl_position_information`
--
ALTER TABLE `tbl_position_information`
  ADD PRIMARY KEY (`position_ID`);

--
-- Indexes for table `tbl_rate_information`
--
ALTER TABLE `tbl_rate_information`
  ADD PRIMARY KEY (`rate_ID`);

--
-- Indexes for table `tbl_user_information_credential`
--
ALTER TABLE `tbl_user_information_credential`
  ADD PRIMARY KEY (`user_ID`);

--
-- Indexes for table `tbl_user_information_personal`
--
ALTER TABLE `tbl_user_information_personal`
  ADD PRIMARY KEY (`user_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
