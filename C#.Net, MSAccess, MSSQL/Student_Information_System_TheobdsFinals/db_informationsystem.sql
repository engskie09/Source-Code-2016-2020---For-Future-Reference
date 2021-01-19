-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 24, 2019 at 05:14 PM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_informationsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_counter_id`
--

CREATE TABLE `tbl_counter_id` (
  `counter_Name` varchar(50) NOT NULL,
  `counter_Count` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_counter_id`
--

INSERT INTO `tbl_counter_id` (`counter_Name`, `counter_Count`) VALUES
('course_ID', '1000'),
('grade_ID', '1000'),
('student_ID', '1000'),
('teacher_ID', '1000');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_course_information`
--

CREATE TABLE `tbl_course_information` (
  `course_ID` varchar(50) NOT NULL,
  `course_Name` varchar(50) DEFAULT NULL,
  `course_Description` varchar(50) DEFAULT NULL,
  `course_YearLevel` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_student_grade_information`
--

CREATE TABLE `tbl_student_grade_information` (
  `grade_ID` varchar(50) NOT NULL,
  `student_ID` varchar(50) DEFAULT NULL,
  `grade_Description` varchar(50) DEFAULT NULL,
  `grade_Remarks` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_student_information`
--

CREATE TABLE `tbl_student_information` (
  `student_ID` varchar(50) NOT NULL,
  `student_FirstName` varchar(50) DEFAULT NULL,
  `student_LastName` varchar(50) DEFAULT NULL,
  `student_BirthDate` varchar(50) DEFAULT NULL,
  `student_Gender` varchar(50) DEFAULT NULL,
  `student_PhoneNo` varchar(50) DEFAULT NULL,
  `student_YearLevel` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_teacher_information`
--

CREATE TABLE `tbl_teacher_information` (
  `teacher_ID` varchar(50) NOT NULL,
  `teacher_FirstName` varchar(50) DEFAULT NULL,
  `teacher_LastName` varchar(50) DEFAULT NULL,
  `teacher_BirthDate` varchar(50) DEFAULT NULL,
  `teacher_Gender` varchar(50) DEFAULT NULL,
  `teacher_PhoneNo` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user_information`
--

CREATE TABLE `tbl_user_information` (
  `user_ID` varchar(50) NOT NULL,
  `user_Name` varchar(50) DEFAULT NULL,
  `user_Password` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_user_information`
--

INSERT INTO `tbl_user_information` (`user_ID`, `user_Name`, `user_Password`) VALUES
('1', 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_counter_id`
--
ALTER TABLE `tbl_counter_id`
  ADD PRIMARY KEY (`counter_Name`);

--
-- Indexes for table `tbl_course_information`
--
ALTER TABLE `tbl_course_information`
  ADD PRIMARY KEY (`course_ID`);

--
-- Indexes for table `tbl_student_grade_information`
--
ALTER TABLE `tbl_student_grade_information`
  ADD PRIMARY KEY (`grade_ID`);

--
-- Indexes for table `tbl_student_information`
--
ALTER TABLE `tbl_student_information`
  ADD PRIMARY KEY (`student_ID`);

--
-- Indexes for table `tbl_teacher_information`
--
ALTER TABLE `tbl_teacher_information`
  ADD PRIMARY KEY (`teacher_ID`);

--
-- Indexes for table `tbl_user_information`
--
ALTER TABLE `tbl_user_information`
  ADD PRIMARY KEY (`user_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
