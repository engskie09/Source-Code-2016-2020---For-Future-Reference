-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 31, 2018 at 04:35 AM
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
-- Database: `engskie09apartmentsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `adminsession_myaccount`
--

CREATE TABLE `adminsession_myaccount` (
  `AdminFirstname` varchar(10) DEFAULT NULL,
  `AdminMiddlename` varchar(10) DEFAULT NULL,
  `AdminLastname` varchar(10) DEFAULT NULL,
  `AdminBirthday` varchar(10) DEFAULT NULL,
  `AdminGender` varchar(10) DEFAULT NULL,
  `AdminID` varchar(10) DEFAULT NULL,
  `AdminUsername` varchar(10) DEFAULT NULL,
  `AdminPassword` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `adminsession_myaccount`
--

INSERT INTO `adminsession_myaccount` (`AdminFirstname`, `AdminMiddlename`, `AdminLastname`, `AdminBirthday`, `AdminGender`, `AdminID`, `AdminUsername`, `AdminPassword`) VALUES
('Rafael', 'Nobleza', 'Masallo', '2/1/1992', 'Male', '300-1000', 'paengskie', 'panot');

-- --------------------------------------------------------

--
-- Table structure for table `adminsession_reports`
--

CREATE TABLE `adminsession_reports` (
  `CustomerFirstname` varchar(10) DEFAULT NULL,
  `CustomerMiddlename` varchar(10) DEFAULT NULL,
  `CustomerLastname` varchar(10) DEFAULT NULL,
  `CustomerID` varchar(10) DEFAULT NULL,
  `CustomerGender` varchar(10) DEFAULT NULL,
  `CustomerCheckinDate` varchar(10) DEFAULT NULL,
  `CustomerCheckoutDate` varchar(10) DEFAULT NULL,
  `CustomerLengthofstay` varchar(10) DEFAULT NULL,
  `CustomerRoomNo` varchar(10) DEFAULT NULL,
  `CustomerRoomType` varchar(10) DEFAULT NULL,
  `CustomerFloorNo` varchar(10) DEFAULT NULL,
  `CustomerRoomAmount` int(10) DEFAULT NULL,
  `CustomerTotalAmount` int(10) DEFAULT NULL,
  `CustomerAction` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `adminsession_reports`
--

INSERT INTO `adminsession_reports` (`CustomerFirstname`, `CustomerMiddlename`, `CustomerLastname`, `CustomerID`, `CustomerGender`, `CustomerCheckinDate`, `CustomerCheckoutDate`, `CustomerLengthofstay`, `CustomerRoomNo`, `CustomerRoomType`, `CustomerFloorNo`, `CustomerRoomAmount`, `CustomerTotalAmount`, `CustomerAction`) VALUES
('Qwe', 'Qwe', 'Qwe', '100-1017', 'Male', '10/31/2018', '10/31/2019', '12', '105', 'Large', '1st', 5500, 66000, 'Check In'),
('Qwe', 'Qwe', 'Qwe', '100-1017', 'Male', '10/31/2018', '10/31/2019', '12', '105', 'Large', '1st', 5500, 66000, 'Check Out');

-- --------------------------------------------------------

--
-- Table structure for table `customersession_checkin`
--

CREATE TABLE `customersession_checkin` (
  `CustomerFirstname` varchar(10) DEFAULT NULL,
  `CustomerMiddlename` varchar(10) DEFAULT NULL,
  `CustomerLastname` varchar(10) DEFAULT NULL,
  `CustomerID` varchar(10) DEFAULT NULL,
  `CustomerGender` varchar(10) DEFAULT NULL,
  `CustomerCheckinDate` varchar(10) DEFAULT NULL,
  `CustomerCheckoutDate` varchar(10) DEFAULT NULL,
  `CustomerLengthofstay` varchar(10) DEFAULT NULL,
  `CustomerRoomNo` varchar(10) DEFAULT NULL,
  `CustomerRoomType` varchar(10) DEFAULT NULL,
  `CustomerFloorNo` varchar(10) DEFAULT NULL,
  `CustomerRoomAmount` int(10) DEFAULT NULL,
  `CustomerTotalAmount` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `customersession_myaccount`
--

CREATE TABLE `customersession_myaccount` (
  `CustomerFirstname` varchar(10) DEFAULT NULL,
  `CustomerMiddlename` varchar(10) DEFAULT NULL,
  `CustomerLastname` varchar(10) DEFAULT NULL,
  `CustomerBirthday` varchar(10) DEFAULT NULL,
  `CustomerGender` varchar(10) DEFAULT NULL,
  `CustomerID` varchar(10) DEFAULT NULL,
  `CustomerUsername` varchar(10) DEFAULT NULL,
  `CustomerPassword` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `customersession_myaccount`
--

INSERT INTO `customersession_myaccount` (`CustomerFirstname`, `CustomerMiddlename`, `CustomerLastname`, `CustomerBirthday`, `CustomerGender`, `CustomerID`, `CustomerUsername`, `CustomerPassword`) VALUES
('Pedro', 'Juan', 'Santiago', '2/1/1992', 'Male', '100-1016', 'Pedro', 'Juan'),
('Qwe', 'Qwe', 'Qwe', '1/1/1990', 'Male', '100-1017', 'Qwe', 'Qwe'),
('Asd', 'Asd', 'Asd', '1/1/1990', 'Male', '100-1018', 'Asd', 'Asd');

-- --------------------------------------------------------

--
-- Table structure for table `generalsessions_id_autoincrement`
--

CREATE TABLE `generalsessions_id_autoincrement` (
  `increment_name` varchar(15) DEFAULT NULL,
  `increment_current` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `generalsessions_id_autoincrement`
--

INSERT INTO `generalsessions_id_autoincrement` (`increment_name`, `increment_current`) VALUES
('user_customer', 1018),
('user_staff', 1001);

-- --------------------------------------------------------

--
-- Table structure for table `generalsessions_userinformation`
--

CREATE TABLE `generalsessions_userinformation` (
  `User_ID` varchar(10) DEFAULT NULL,
  `User_Name` varchar(10) DEFAULT NULL,
  `User_Password` varchar(10) DEFAULT NULL,
  `User_Type` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `generalsessions_userinformation`
--

INSERT INTO `generalsessions_userinformation` (`User_ID`, `User_Name`, `User_Password`, `User_Type`) VALUES
('100-1016', 'Pedro', 'Juan', 'Customer'),
('300-1000', 'paengskie', 'panot', 'Admin'),
('100-1001', 'Panot', 'Panot', 'Staff'),
('100-1017', 'Qwe', 'Qwe', 'Customer'),
('100-1018', 'Asd', 'Asd', 'Customer');

-- --------------------------------------------------------

--
-- Table structure for table `generalsessions_viewrooms`
--

CREATE TABLE `generalsessions_viewrooms` (
  `RoomNo` int(10) DEFAULT NULL,
  `FloorNo` varchar(10) DEFAULT NULL,
  `RoomType` varchar(10) DEFAULT NULL,
  `RoomAmount` int(10) DEFAULT NULL,
  `RoomAvailability` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `generalsessions_viewrooms`
--

INSERT INTO `generalsessions_viewrooms` (`RoomNo`, `FloorNo`, `RoomType`, `RoomAmount`, `RoomAvailability`) VALUES
(101, '1st', 'Small', 3500, '0'),
(102, '1st', 'Medium', 4500, '0'),
(103, '1st', 'Medium', 4500, '0'),
(104, '1st', 'Small', 3500, '0'),
(105, '1st', 'Large', 5500, '0'),
(106, '1st', 'Small', 3500, '0'),
(107, '1st', 'Small', 3500, '0'),
(201, '2nd', 'Small', 3500, '0'),
(202, '2nd', 'Small', 3500, '0'),
(203, '2nd', 'Large', 5500, '0'),
(204, '2nd', 'Small', 3500, '0'),
(205, '2nd', 'Medium', 4500, '0'),
(206, '2nd', 'Small', 3500, '0'),
(207, '2nd', 'Medium', 4500, '0'),
(301, '3rd', 'Small', 3500, '0'),
(302, '3rd', 'Small', 3500, '0'),
(303, '3rd', 'Large', 5500, '0'),
(304, '3rd', 'Small', 3500, '0'),
(305, '3rd', 'Medium', 4500, '0'),
(306, '3rd', 'Medium', 4500, '0'),
(307, '3rd', 'Small', 3500, '0'),
(401, '4th', 'Small', 3500, '0'),
(402, '4th', 'Small', 3500, '0'),
(403, '4th', 'Medium', 4500, '0'),
(404, '4th', 'Medium', 4500, '0'),
(405, '4th', 'Large', 5500, '0'),
(406, '4th', 'Large', 5500, '0'),
(407, '4th', 'Small', 3500, '0'),
(501, '5th', 'Large', 5500, '0'),
(502, '5th', 'Small', 3500, '0'),
(503, '5th', 'Small', 3500, '0'),
(504, '5th', 'Medium', 4500, '0'),
(505, '5th', 'Small', 3500, '0'),
(506, '5th', 'Large', 5500, '0'),
(507, '5th', 'Large', 5500, '0'),
(601, '6th', 'Small', 3500, '0'),
(602, '6th', 'Medium', 4500, '0'),
(603, '6th', 'Medium', 4500, '0'),
(604, '6th', 'Small', 3500, '0'),
(605, '6th', 'Large', 5500, '0'),
(606, '6th', 'Large', 5500, '0'),
(607, '6th', 'Small', 3500, '0'),
(701, '7th', 'Large', 5500, '0'),
(702, '7th', 'Large', 5500, '0'),
(703, '7th', 'Large', 5500, '0'),
(704, '7th', 'Medium', 4500, '0'),
(705, '7th', 'Large', 5500, '0'),
(706, '7th', 'Medium', 4500, '0'),
(707, '7th', 'Large', 5500, '0');

-- --------------------------------------------------------

--
-- Table structure for table `staffsession_myaccount`
--

CREATE TABLE `staffsession_myaccount` (
  `StaffFirstname` varchar(10) DEFAULT NULL,
  `StaffMiddlename` varchar(10) DEFAULT NULL,
  `StaffLastname` varchar(10) DEFAULT NULL,
  `StaffBirthday` varchar(10) DEFAULT NULL,
  `StaffGender` varchar(10) DEFAULT NULL,
  `StaffID` varchar(10) DEFAULT NULL,
  `StaffUsername` varchar(10) DEFAULT NULL,
  `StaffPassword` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `staffsession_myaccount`
--

INSERT INTO `staffsession_myaccount` (`StaffFirstname`, `StaffMiddlename`, `StaffLastname`, `StaffBirthday`, `StaffGender`, `StaffID`, `StaffUsername`, `StaffPassword`) VALUES
('Panotchi', 'Panotskie', 'Banos', '1/1/1995', 'Female', '100-1001', 'Panot', 'Panot');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
