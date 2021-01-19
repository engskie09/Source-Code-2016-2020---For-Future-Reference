-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 05, 2019 at 02:53 AM
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
-- Database: `db_mythicalcafe_icms`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_counter_information`
--

CREATE TABLE `tbl_counter_information` (
  `Counter_Identity` int(3) NOT NULL,
  `Counter_Code` varchar(10) DEFAULT NULL,
  `Counter_Count` int(5) DEFAULT NULL,
  `Counter_Description` varchar(100) DEFAULT NULL,
  `Branch_ID` varchar(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_counter_information`
--

INSERT INTO `tbl_counter_information` (`Counter_Identity`, `Counter_Code`, `Counter_Count`, `Counter_Description`, `Branch_ID`) VALUES
(1, 'CSTMR', 15, 'For Counting Customer ID', '0001'),
(2, 'SSSN', 244, 'For Counting Session ID', '0001'),
(3, 'GST', 197, 'For Counting Guest ID', '0001'),
(4, 'PRDCT', 11, 'For Counting Product ID', '0001'),
(5, 'CTGRY', 3, 'For Counting Product Category ID', '0001'),
(6, 'RDR', 10, 'For Counting Product Order ID', '0001'),
(7, 'LG', 122, 'For Counting Log ID', '0001'),
(8, 'STFF', 4, 'For Counting Staff ID', '0001'),
(9, 'RPRT', 13, 'For Counting Report ID', '0001'),
(10, 'TTNDNC', 34, 'For Counting Attendance ID', '0001'),
(20, 'CSTMR', 15, 'For Counting Customer ID', '0002'),
(21, 'SSSN', 244, 'For Counting Session ID', '0002'),
(22, 'GST', 197, 'For Counting Guest ID', '0002'),
(23, 'PRDCT', 11, 'For Counting Product ID', '0002'),
(24, 'CTGRY', 3, 'For Counting Product Category ID', '0002'),
(25, 'RDR', 10, 'For Counting Product Order ID', '0002'),
(26, 'LG', 122, 'For Counting Log ID', '0002'),
(27, 'STFF', 4, 'For Counting Staff ID', '0002'),
(28, 'RPRT', 13, 'For Counting Report ID', '0002'),
(29, 'TTNDNC', 34, 'For Counting Attendance ID', '0002');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer_credential_information`
--

CREATE TABLE `tbl_customer_credential_information` (
  `Customer_Identity` varchar(255) NOT NULL,
  `Customer_UserName` varchar(255) DEFAULT NULL,
  `Customer_Password` varchar(255) DEFAULT NULL,
  `Customer_RadioFrequency_Identification` varchar(255) DEFAULT NULL,
  `Customer_RadioFrequency_Identification_Status` varchar(255) DEFAULT NULL,
  `Customer_Status` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_customer_credential_information`
--

INSERT INTO `tbl_customer_credential_information` (`Customer_Identity`, `Customer_UserName`, `Customer_Password`, `Customer_RadioFrequency_Identification`, `Customer_RadioFrequency_Identification_Status`, `Customer_Status`) VALUES
('CSTMR-0001-1002', 'eng', 'engss', '0003897677', 'Active', 'Active : Offline'),
('CSTMR-0001-1011', 'zzz', 'aaa', '---------', 'Active', 'Active : Offline'),
('CSTMR-0001-1012', 'Username', 'Password', '---------', 'Active', 'Active : Offline'),
('CSTMR-0001-1014', 'werw', 'fdg45g34', '---------', 'Active', 'Active : Offline');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer_personal_information`
--

CREATE TABLE `tbl_customer_personal_information` (
  `Customer_Identity` varchar(255) NOT NULL,
  `Customer_FirstName` varchar(255) DEFAULT NULL,
  `Customer_MiddleName` varchar(255) DEFAULT NULL,
  `Customer_LastName` varchar(255) DEFAULT NULL,
  `Customer_EmailAddress` varchar(255) DEFAULT NULL,
  `Customer_ContactNumber` varchar(255) DEFAULT NULL,
  `Customer_HomeAddress` varchar(255) DEFAULT NULL,
  `Customer_Gender` varchar(255) DEFAULT NULL,
  `Customer_BirthDate` date DEFAULT NULL,
  `Customer_Description` varchar(255) DEFAULT NULL,
  `Customer_Image_Path` varchar(255) DEFAULT NULL,
  `Customer_Registration_DateTime` datetime DEFAULT NULL,
  `Customer_LastUsed_DateTime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_customer_personal_information`
--

INSERT INTO `tbl_customer_personal_information` (`Customer_Identity`, `Customer_FirstName`, `Customer_MiddleName`, `Customer_LastName`, `Customer_EmailAddress`, `Customer_ContactNumber`, `Customer_HomeAddress`, `Customer_Gender`, `Customer_BirthDate`, `Customer_Description`, `Customer_Image_Path`, `Customer_Registration_DateTime`, `Customer_LastUsed_DateTime`) VALUES
('CSTMR-0001-1002', 'Rafael', 'Nobleza', 'Masallo', 'asdasd@yahoo.com', '09331798798', '123 STI Caloocan', 'Male', '1998-09-23', 'Adik sa LoL', 'Images/CSTMR-0001-1002.png', '2019-11-05 07:27:31', '0000-00-00 00:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer_property_information`
--

CREATE TABLE `tbl_customer_property_information` (
  `Customer_Identity` varchar(255) NOT NULL,
  `Time_Remaining` decimal(10,0) DEFAULT NULL,
  `Time_Bonus` decimal(10,0) DEFAULT NULL,
  `Time_Spent` decimal(10,0) DEFAULT NULL,
  `Cash_Remaining` decimal(10,2) DEFAULT NULL,
  `Cash_Spent` decimal(10,2) DEFAULT NULL,
  `Point_Remaining` decimal(10,2) DEFAULT NULL,
  `Point_Spent` decimal(10,2) DEFAULT NULL,
  `Debt_Remaining` decimal(10,2) DEFAULT NULL,
  `Debt_Maximum` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_customer_property_information`
--

INSERT INTO `tbl_customer_property_information` (`Customer_Identity`, `Time_Remaining`, `Time_Bonus`, `Time_Spent`, `Cash_Remaining`, `Cash_Spent`, `Point_Remaining`, `Point_Spent`, `Debt_Remaining`, `Debt_Maximum`) VALUES
('CSTMR-0001-1002', '18438', '0', '5562', '4645.00', '120.00', '15.00', '10.00', '36.67', '20.00'),
('CSTMR-0001-1011', '0', '0', '0', '20.00', '180.00', '0.00', '0.00', '0.00', '0.00'),
('CSTMR-0001-1012', '0', '0', '0', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00'),
('CSTMR-0001-1014', '0', '0', '0', '0.00', '0.00', '0.00', '0.00', '0.00', '0.00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer_report_information`
--

CREATE TABLE `tbl_customer_report_information` (
  `Report_Identity` varchar(255) NOT NULL,
  `Customer_Identity` varchar(255) DEFAULT NULL,
  `Cash_Spent` decimal(10,2) DEFAULT NULL,
  `Report_DateTime` datetime(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_customer_report_information`
--

INSERT INTO `tbl_customer_report_information` (`Report_Identity`, `Customer_Identity`, `Cash_Spent`, `Report_DateTime`) VALUES
('RPRT-0001-1008', 'CSTMR-0001-1002', '2145.00', '2019-11-05 06:15:55.000000'),
('RPRT-0001-1009', 'CSTMR-0001-1002', '1500.00', '2019-11-05 06:28:25.000000'),
('RPRT-0001-1011', 'CSTMR-0001-1002', '1000.00', '2019-11-05 07:27:31.000000');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product_category_information`
--

CREATE TABLE `tbl_product_category_information` (
  `Category_Identity` varchar(255) NOT NULL,
  `Category_Name` varchar(255) DEFAULT NULL,
  `Category_Description` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_product_category_information`
--

INSERT INTO `tbl_product_category_information` (`Category_Identity`, `Category_Name`, `Category_Description`) VALUES
('CTGRY-0001-1001', 'Noodles', 'Masarap Noodles Namin Syempre <3');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product_information`
--

CREATE TABLE `tbl_product_information` (
  `Product_Identity` varchar(255) NOT NULL,
  `Product_Name` varchar(255) DEFAULT NULL,
  `Product_Quantity` int(255) DEFAULT NULL,
  `Product_Price_Cash` decimal(10,2) DEFAULT NULL,
  `Product_Price_Point` decimal(10,2) DEFAULT NULL,
  `Category_Identity` varchar(255) DEFAULT NULL,
  `Product_Description` varchar(255) DEFAULT NULL,
  `Product_Status` varchar(255) DEFAULT NULL,
  `Product_Image_Path` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_product_information`
--

INSERT INTO `tbl_product_information` (`Product_Identity`, `Product_Name`, `Product_Quantity`, `Product_Price_Cash`, `Product_Price_Point`, `Category_Identity`, `Product_Description`, `Product_Status`, `Product_Image_Path`) VALUES
('PRDCT-0001-1003', 'Lucky Me Pancit Canton (Calamansi)', 4, '20.00', '5.00', 'CTGRY-0001-1001', 'Lulutuin namin para sa`yo yieee <3', 'Active', 'Images/PRDCT-0001-1003.png'),
('PRDCT-0001-1004', 'Lucky Me Pancit Canton (Sweet and Spicy)', 20, '20.00', '5.00', 'CTGRY-0001-1001', 'Sobrang anghang nito Pramis...', 'Active', 'Images/PRDCT-0001-1004.png');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product_order_information`
--

CREATE TABLE `tbl_product_order_information` (
  `Order_Identity` varchar(255) NOT NULL,
  `Customer_Identity` varchar(255) DEFAULT NULL,
  `Order_List` text DEFAULT NULL,
  `Order_Status` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_product_order_information`
--

INSERT INTO `tbl_product_order_information` (`Order_Identity`, `Customer_Identity`, `Order_List`, `Order_Status`) VALUES
('RDR-0001-1005', 'CSTMR-0001-1002', '[{ \'Product_Identity\' : \'PRDCT-0001-1003\', \'Product_Order_Quantity_Cash\' : \'5\', \'Product_Order_Quantity_Point\' : \'0\' }]', 'Declined'),
('RDR-0001-1006', 'CSTMR-0001-1002', '[{ \'Product_Identity\' : \'PRDCT-0001-1003\', \'Product_Order_Quantity_Cash\' : \'1\', \'Product_Order_Quantity_Point\' : \'1\' }]', 'Accepted'),
('RDR-0001-1007', 'CSTMR-0001-1011', '[{ \'Product_Identity\' : \'PRDCT-0001-1003\', \'Product_Order_Quantity_Cash\' : \'5\', \'Product_Order_Quantity_Point\' : \'0\' }]', 'Accepted'),
('RDR-0001-1008', 'CSTMR-0001-1011', '[{ \'Product_Identity\' : \'PRDCT-0001-1003\', \'Product_Order_Quantity_Cash\' : \'5\', \'Product_Order_Quantity_Point\' : \'0\' }]', 'Accepted'),
('RDR-0001-1009', 'CSTMR-0001-1002', '[{ \'Product_Identity\' : \'PRDCT-0001-1003\', \'Product_Order_Quantity_Cash\' : \'1\', \'Product_Order_Quantity_Point\' : \'0\' }]', 'Accepted');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product_report_information`
--

CREATE TABLE `tbl_product_report_information` (
  `Report_ID` varchar(255) CHARACTER SET utf8mb4 NOT NULL,
  `Product_Sold_Name` text CHARACTER SET utf8mb4 DEFAULT NULL,
  `Product_Sold_Quantity` varchar(255) CHARACTER SET utf8mb4 DEFAULT NULL,
  `Product_Sold_Total` decimal(10,2) DEFAULT NULL,
  `Report_DateTime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_product_report_information`
--

INSERT INTO `tbl_product_report_information` (`Report_ID`, `Product_Sold_Name`, `Product_Sold_Quantity`, `Product_Sold_Total`, `Report_DateTime`) VALUES
('RPRT-0001-1002', 'Lucky Me Pancit Canton (Calamansi)', '1', '20.00', '2019-10-26 05:54:26'),
('RPRT-0001-1003', 'Lucky Me Pancit Canton (Calamansi)', '5', '100.00', '2019-11-05 00:25:18'),
('RPRT-0001-1004', 'Lucky Me Pancit Canton (Calamansi)', '1', '20.00', '2019-11-05 04:29:46');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_staff_attendance_information`
--

CREATE TABLE `tbl_staff_attendance_information` (
  `Attendance_Identity` varchar(255) NOT NULL,
  `Staff_Identity` varchar(255) DEFAULT NULL,
  `Attendance_DateTime_In` datetime DEFAULT NULL,
  `Attendance_DateTime_Out` datetime DEFAULT NULL,
  `Attendance_Status` varchar(255) DEFAULT NULL,
  `Staff_Salary_Amount` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_staff_attendance_information`
--

INSERT INTO `tbl_staff_attendance_information` (`Attendance_Identity`, `Staff_Identity`, `Attendance_DateTime_In`, `Attendance_DateTime_Out`, `Attendance_Status`, `Staff_Salary_Amount`) VALUES
('TTNDNC-0001-1022', 'STFF-0001-1003', '2019-10-15 00:26:30', '2019-10-16 00:00:00', 'Time Out', '1200.14'),
('TTNDNC-0001-1023', 'STFF-0001-1003', '2019-10-17 00:00:00', '2019-10-18 08:28:32', 'Time Out', '401.08'),
('TTNDNC-0001-1024', 'STFF-0001-1003', '2019-11-18 01:15:14', '2019-10-20 13:35:22', 'Time Out', '2216.79'),
('TTNDNC-0001-1025', 'STFF-0001-1003', '2019-10-21 13:35:33', '2019-10-21 21:37:43', 'Time Out', '401.81'),
('TTNDNC-0001-1026', 'STFF-0001-1003', '2019-10-22 13:39:30', '2019-10-22 21:39:30', 'Time Out', '400.39'),
('TTNDNC-0001-1027', 'STFF-0001-1003', '2019-10-23 13:41:25', '2019-10-24 21:41:25', 'Time Out', '401.74'),
('TTNDNC-0001-1028', 'STFF-0001-1003', '2019-10-25 13:00:00', '2019-10-24 21:00:00', 'Time Out', '400.00'),
('TTNDNC-0001-1033', 'Owner-0001-eng', '2019-11-05 03:32:16', '2019-11-05 03:33:57', 'Time In', '0.00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_staff_information`
--

CREATE TABLE `tbl_staff_information` (
  `Staff_Identity` varchar(255) NOT NULL,
  `Staff_UserName` varchar(255) DEFAULT NULL,
  `Staff_Password` varchar(255) DEFAULT NULL,
  `Staff_FirstName` varchar(255) DEFAULT NULL,
  `Staff_MiddleName` varchar(255) DEFAULT NULL,
  `Staff_LastName` varchar(255) DEFAULT NULL,
  `Staff_Position` varchar(255) DEFAULT NULL,
  `Staff_Privilege_Extra` text DEFAULT NULL,
  `Staff_Status` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_staff_information`
--

INSERT INTO `tbl_staff_information` (`Staff_Identity`, `Staff_UserName`, `Staff_Password`, `Staff_FirstName`, `Staff_MiddleName`, `Staff_LastName`, `Staff_Position`, `Staff_Privilege_Extra`, `Staff_Status`) VALUES
('Owner-0001-eng', 'eng', 'eng', 'Rafel', 'haha', 'Mas', 'Super Admin', '', 'Enable'),
('STFF-0001-1003', 'juan', 'juan', 'Juan', 'Carlo', 'Dizon', 'Staff', '', 'Disable');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user_log_information`
--

CREATE TABLE `tbl_user_log_information` (
  `Log_Identity` varchar(255) NOT NULL,
  `Log_Type` varchar(255) DEFAULT NULL,
  `Log_DateTime` datetime DEFAULT NULL,
  `User_Identity` varchar(255) DEFAULT NULL,
  `Log_Description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_user_log_information`
--

INSERT INTO `tbl_user_log_information` (`Log_Identity`, `Log_Type`, `Log_DateTime`, `User_Identity`, `Log_Description`) VALUES
('LG-0001-1022', 'Account', '2019-11-04 14:02:12', 'Owner-0001-eng', 'Time In'),
('LG-0001-1023', 'Account', '2019-11-04 14:02:13', 'Owner-0001-eng', 'Login'),
('LG-0001-1024', 'Account', '2019-11-04 18:11:33', 'Owner-0001-eng', 'Logout'),
('LG-0001-1025', 'Account', '2019-11-04 18:11:33', 'Owner-0001-eng', 'Change Account'),
('LG-0001-1026', 'Account', '2019-11-04 18:11:35', 'Owner-0001-eng', 'Login'),
('LG-0001-1027', 'Account', '2019-11-04 18:11:39', 'Owner-0001-eng', 'Logout'),
('LG-0001-1028', 'Account', '2019-11-04 18:11:39', 'Owner-0001-eng', 'Change Account'),
('LG-0001-1029', 'Account', '2019-11-04 18:11:43', 'Owner-0001-eng', 'Login'),
('LG-0001-1030', 'Account', '2019-11-04 18:11:47', 'Owner-0001-eng', 'Logout'),
('LG-0001-1031', 'Account', '2019-11-04 18:11:47', 'Owner-0001-eng', 'Change Account'),
('LG-0001-1032', 'Account', '2019-11-04 18:12:01', 'Owner-0001-eng', 'Login'),
('LG-0001-1033', 'Account', '2019-11-04 23:39:10', 'Owner-0001-eng', 'Inserted Product *PRDCT-0001-1008*'),
('LG-0001-1034', 'Product', '2019-11-04 23:39:10', 'PRDCT-0001-1008', 'Product has inserted by *Owner-0001-eng*'),
('LG-0001-1035', 'Account', '2019-11-04 23:40:38', 'Owner-0001-eng', 'Updated Product *PRDCT-0001-1008*'),
('LG-0001-1036', 'Product', '2019-11-04 23:40:38', 'PRDCT-0001-1008', 'Product has updated by *Owner-0001-eng*'),
('LG-0001-1037', 'Account', '2019-11-04 23:42:47', 'Owner-0001-eng', 'Inserted Product *PRDCT-0001-1009*'),
('LG-0001-1038', 'Product', '2019-11-04 23:42:48', 'PRDCT-0001-1009', 'Product has inserted by *Owner-0001-eng*'),
('LG-0001-1039', 'Account', '2019-11-04 23:42:59', 'Owner-0001-eng', 'Inserted Product *PRDCT-0001-1010*'),
('LG-0001-1040', 'Product', '2019-11-04 23:42:59', 'PRDCT-0001-1010', 'Product has inserted by *Owner-0001-eng*'),
('LG-0001-1041', 'Account', '2019-11-04 23:44:02', 'Owner-0001-eng', 'Deleted Product *PRDCT-0001-1005*'),
('LG-0001-1042', 'Product', '2019-11-04 23:44:02', 'PRDCT-0001-1005', 'Product has deleted by *Owner-0001-eng*'),
('LG-0001-1043', 'Account', '2019-11-04 23:44:05', 'Owner-0001-eng', 'Deleted Product *PRDCT-0001-1009*'),
('LG-0001-1044', 'Product', '2019-11-04 23:44:06', 'PRDCT-0001-1009', 'Product has deleted by *Owner-0001-eng*'),
('LG-0001-1045', 'Account', '2019-11-04 23:44:07', 'Owner-0001-eng', 'Deleted Product *PRDCT-0001-1010*'),
('LG-0001-1046', 'Product', '2019-11-04 23:44:07', 'PRDCT-0001-1010', 'Product has deleted by *Owner-0001-eng*'),
('LG-0001-1047', 'Account', '2019-11-04 23:49:12', 'Owner-0001-eng', 'Inserted Category *CTGRY-0001-1002*'),
('LG-0001-1048', 'Product', '2019-11-04 23:49:13', 'CTGRY-0001-1002', 'Category has inserted by *Owner-0001-eng*'),
('LG-0001-1049', 'Account', '2019-11-04 23:49:17', 'Owner-0001-eng', 'Updated Category *CTGRY-0001-1002*'),
('LG-0001-1050', 'Product', '2019-11-04 23:49:18', 'CTGRY-0001-1002', 'Category has updated by *Owner-0001-eng*'),
('LG-0001-1051', 'Account', '2019-11-04 23:49:21', 'Owner-0001-eng', 'Deleted Category *CTGRY-0001-1002*'),
('LG-0001-1052', 'Product', '2019-11-04 23:49:21', 'CTGRY-0001-1002', 'Category has deleted by *Owner-0001-eng*'),
('LG-0001-1053', 'Account', '2019-11-05 00:23:02', 'Owner-0001-eng', 'Declined Order *RDR-0001-1008*'),
('LG-0001-1054', 'Product', '2019-11-05 00:23:02', 'RDR-0001-1008', 'Order has declined by *Owner-0001-eng*'),
('LG-0001-1055', 'Account', '2019-11-05 00:23:29', 'Owner-0001-eng', 'Declined Order *RDR-0001-1008*'),
('LG-0001-1056', 'Product', '2019-11-05 00:23:29', 'RDR-0001-1008', 'Order has declined by *Owner-0001-eng*'),
('LG-0001-1057', 'Account', '2019-11-05 00:24:32', 'Owner-0001-eng', 'Declined Order *RDR-0001-1008*'),
('LG-0001-1058', 'Product', '2019-11-05 00:24:32', 'RDR-0001-1008', 'Order has declined by *Owner-0001-eng*'),
('LG-0001-1059', 'Account', '2019-11-05 00:25:26', 'Owner-0001-eng', 'Accepted Order *RDR-0001-1008*'),
('LG-0001-1060', 'Product', '2019-11-05 00:25:26', 'RDR-0001-1008', 'Order has accepted by *Owner-0001-eng*'),
('LG-0001-1061', 'Account', '2019-11-05 02:58:53', 'CSTMR-0001-1002', 'Make an Order *RDR-0001-1009*'),
('LG-0001-1062', 'Product', '2019-11-05 02:58:53', 'RDR-0001-1009', 'Order has made by *CSTMR-0001-1002*'),
('LG-0001-1063', 'Account', '2019-11-05 03:18:16', 'Owner-0001-eng', 'Logout'),
('LG-0001-1064', 'Account', '2019-11-05 03:18:17', 'Owner-0001-eng', 'Change Account'),
('LG-0001-1065', 'Account', '2019-11-05 03:18:20', 'STFF-0001-1003', 'Time In'),
('LG-0001-1066', 'Account', '2019-11-05 03:18:21', 'STFF-0001-1003', 'Login'),
('LG-0001-1067', 'Account', '2019-11-05 03:18:37', 'STFF-0001-1003', 'Logout'),
('LG-0001-1068', 'Account', '2019-11-05 03:18:37', 'STFF-0001-1003', 'Change Account'),
('LG-0001-1069', 'Account', '2019-11-05 03:18:41', 'Owner-0001-eng', 'Time In'),
('LG-0001-1070', 'Account', '2019-11-05 03:18:58', 'Owner-0001-eng', 'Login'),
('LG-0001-1071', 'Account', '2019-11-05 03:19:12', 'Owner-0001-eng', 'Logout'),
('LG-0001-1072', 'Account', '2019-11-05 03:19:12', 'Owner-0001-eng', 'Change Account'),
('LG-0001-1073', 'Account', '2019-11-05 03:19:14', 'Owner-0001-eng', 'Login'),
('LG-0001-1074', 'Account', '2019-11-05 03:19:28', 'Owner-0001-eng', 'Login'),
('LG-0001-1075', 'Account', '2019-11-05 03:19:46', 'STFF-0001-1003', 'Login'),
('LG-0001-1076', 'Account', '2019-11-05 03:19:48', 'STFF-0001-1003', 'Time Out'),
('LG-0001-1077', 'Account', '2019-11-05 03:19:48', 'STFF-0001-1003', 'Logout'),
('LG-0001-1078', 'Account', '2019-11-05 03:20:38', 'Owner-0001-eng', 'Login'),
('LG-0001-1079', 'Account', '2019-11-05 03:20:40', 'Owner-0001-eng', 'Time Out'),
('LG-0001-1080', 'Account', '2019-11-05 03:20:40', 'Owner-0001-eng', 'Logout'),
('LG-0001-1081', 'Account', '2019-11-05 03:21:13', 'STFF-0001-1003', 'Time In'),
('LG-0001-1082', 'Account', '2019-11-05 03:21:16', 'STFF-0001-1003', 'Login'),
('LG-0001-1083', 'Account', '2019-11-05 03:21:28', 'STFF-0001-1003', 'Time Out'),
('LG-0001-1084', 'Account', '2019-11-05 03:21:28', 'STFF-0001-1003', 'Logout'),
('LG-0001-1085', 'Account', '2019-11-05 03:21:32', 'STFF-0001-1003', 'Time In'),
('LG-0001-1086', 'Account', '2019-11-05 03:21:33', 'STFF-0001-1003', 'Login'),
('LG-0001-1087', 'Account', '2019-11-05 03:31:20', 'STFF-0001-1003', 'Logout'),
('LG-0001-1088', 'Account', '2019-11-05 03:31:20', 'STFF-0001-1003', 'Change Account'),
('LG-0001-1089', 'Account', '2019-11-05 03:32:16', 'Owner-0001-eng', 'Time In'),
('LG-0001-1090', 'Account', '2019-11-05 03:32:17', 'Owner-0001-eng', 'Login'),
('LG-0001-1091', 'Account', '2019-11-05 03:32:21', 'Owner-0001-eng', 'Logout'),
('LG-0001-1092', 'Account', '2019-11-05 03:32:21', 'Owner-0001-eng', 'Change Account'),
('LG-0001-1093', 'Account', '2019-11-05 03:32:23', 'Owner-0001-eng', 'Login'),
('LG-0001-1094', 'Account', '2019-11-05 03:32:26', 'Owner-0001-eng', 'Time Out'),
('LG-0001-1095', 'Account', '2019-11-05 03:32:26', 'Owner-0001-eng', 'Logout'),
('LG-0001-1096', 'Account', '2019-11-05 03:33:55', 'Owner-0001-eng', 'Login'),
('LG-0001-1097', 'Account', '2019-11-05 03:33:57', 'Owner-0001-eng', 'Time Out'),
('LG-0001-1098', 'Account', '2019-11-05 03:33:57', 'Owner-0001-eng', 'Logout'),
('LG-0001-1099', 'Account', '2019-11-05 03:34:07', 'Owner-0001-eng', 'Login'),
('LG-0001-1100', 'Account', '2019-11-05 03:46:31', 'Owner-0001-eng', 'Deleted Workstation *Workstation_5368*'),
('LG-0001-1101', 'Workstation', '2019-11-05 03:46:31', 'Workstation_5368', 'Workstation has deleted by *Owner-0001-eng*'),
('LG-0001-1102', 'Account', '2019-11-05 03:46:34', 'Owner-0001-eng', 'Deleted Workstation *Workstation_5695*'),
('LG-0001-1103', 'Workstation', '2019-11-05 03:46:35', 'Workstation_5695', 'Workstation has deleted by *Owner-0001-eng*'),
('LG-0001-1104', 'Account', '2019-11-05 03:46:37', 'Owner-0001-eng', 'Deleted Workstation *Workstation_7491*'),
('LG-0001-1105', 'Workstation', '2019-11-05 03:46:37', 'Workstation_7491', 'Workstation has deleted by *Owner-0001-eng*'),
('LG-0001-1106', 'Account', '2019-11-05 03:46:41', 'Owner-0001-eng', 'Deleted Workstation *Workstation_4254*'),
('LG-0001-1107', 'Workstation', '2019-11-05 03:46:41', 'Workstation_4254', 'Workstation has deleted by *Owner-0001-eng*'),
('LG-0001-1108', 'Account', '2019-11-05 03:47:11', 'Owner-0001-eng', 'Inserted Workstation *Workstation_6632*'),
('LG-0001-1109', 'Workstation', '2019-11-05 03:47:11', 'Workstation_6632', 'Workstation has inserted by *Owner-0001-eng*'),
('LG-0001-1110', 'Account', '2019-11-05 03:47:20', 'Owner-0001-eng', 'Updated Workstation *Workstation_6632*'),
('LG-0001-1111', 'Workstation', '2019-11-05 03:47:20', 'Workstation_6632', 'Workstation has updated by *Owner-0001-eng*'),
('LG-0001-1112', 'Account', '2019-11-05 03:48:13', 'Owner-0001-eng', 'Updated Workstation *Workstation_6632*'),
('LG-0001-1113', 'Workstation', '2019-11-05 03:48:13', 'Workstation_6632', 'Workstation has updated by *Owner-0001-eng*'),
('LG-0001-1114', 'Account', '2019-11-05 03:54:11', 'Owner-0001-eng', 'Deleted Workstation *Workstation_6632*'),
('LG-0001-1115', 'Workstation', '2019-11-05 03:54:11', 'Workstation_6632', 'Workstation has deleted by *Owner-0001-eng*'),
('LG-0001-1116', 'Account', '2019-11-05 03:54:36', 'Owner-0001-eng', 'Inserted Workstation *Workstation_6646*'),
('LG-0001-1117', 'Workstation', '2019-11-05 03:54:36', 'Workstation_6646', 'Workstation has inserted by *Owner-0001-eng*'),
('LG-0001-1118', 'Account', '2019-11-05 04:29:31', 'Owner-0001-eng', 'Updated Product *PRDCT-0001-1003*'),
('LG-0001-1119', 'Product', '2019-11-05 04:29:31', 'PRDCT-0001-1003', 'Product has updated by *Owner-0001-eng*'),
('LG-0001-1120', 'Account', '2019-11-05 04:29:46', 'Owner-0001-eng', 'Accepted Order *RDR-0001-1009*'),
('LG-0001-1121', 'Product', '2019-11-05 04:29:46', 'RDR-0001-1009', 'Order has accepted by *Owner-0001-eng*');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_workstation_session_information`
--

CREATE TABLE `tbl_workstation_session_information` (
  `Session_Identity` varchar(255) NOT NULL,
  `Workstation_Identity` varchar(255) DEFAULT NULL,
  `User_Identity` varchar(255) DEFAULT NULL,
  `Session_Started_DateTime` datetime DEFAULT NULL,
  `Session_Ended_DateTime` datetime DEFAULT NULL,
  `Session_LastPaused_DateTime` datetime DEFAULT NULL,
  `Time_Spent` decimal(10,0) DEFAULT NULL,
  `Cash_Spent` decimal(10,2) DEFAULT NULL,
  `Session_Status` varchar(255) DEFAULT NULL,
  `Session_Action_Last` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_workstation_session_information`
--

INSERT INTO `tbl_workstation_session_information` (`Session_Identity`, `Workstation_Identity`, `User_Identity`, `Session_Started_DateTime`, `Session_Ended_DateTime`, `Session_LastPaused_DateTime`, `Time_Spent`, `Cash_Spent`, `Session_Status`, `Session_Action_Last`) VALUES
('SSSN-0001-1153', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 12:46:18', '2019-10-10 13:59:18', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Account Use'),
('SSSN-0001-1154', 'Workstation_7846', 'GST-0001-1150', '2019-10-10 12:46:57', '2019-10-10 16:46:57', '0000-00-00 00:00:00', '5', '80.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1155', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 13:43:39', '2060-07-18 17:43:03', '2019-10-10 14:43:01', '5', '7148220.00', 'Inactive', 'Account Use'),
('SSSN-0001-1156', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 14:45:36', '2046-04-11 18:58:36', '0000-00-00 00:00:00', '5', '4646480.00', 'Inactive', 'Account Use'),
('SSSN-0001-1157', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 14:52:04', '2019-10-10 16:05:04', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Account Use'),
('SSSN-0001-1158', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 14:52:37', '2019-10-10 16:05:37', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Account Use'),
('SSSN-0001-1159', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 14:55:01', '2019-10-10 16:08:01', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Account Use'),
('SSSN-0001-1160', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 14:57:07', '2019-10-10 16:10:07', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Account Use'),
('SSSN-0001-1161', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 15:01:20', '2019-10-10 16:02:20', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1162', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 15:01:50', '2019-10-10 16:02:50', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1163', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 15:03:12', '2019-10-10 17:07:12', '0000-00-00 00:00:00', '5', '40.00', 'Inactive', 'Account Use'),
('SSSN-0001-1164', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 15:04:19', '2019-10-10 17:05:22', '2019-10-10 15:04:35', '5', '20.00', 'Inactive', 'Time Unpause'),
('SSSN-0001-1165', 'Workstation_7846', 'GST-0001-1151', '2019-10-10 15:06:14', '2019-10-10 16:06:17', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Session Start'),
('SSSN-0001-1166', 'Workstation_7846', 'GST-0001-1152', '2019-10-10 15:09:03', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1167', 'Workstation_7846', 'GST-0001-1153', '2019-10-10 15:10:00', '2019-10-10 17:10:00', '0000-00-00 00:00:00', '5', '40.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1168', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 15:10:27', '2019-10-10 16:11:27', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1169', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 15:10:46', '2019-10-10 16:11:46', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1170', 'Workstation_7846', 'GST-0001-1154', '2019-10-10 15:10:58', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1171', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 15:13:52', '2019-10-10 16:14:52', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1172', 'Workstation_7846', 'GST-0001-1155', '2019-10-10 15:15:52', '2019-10-10 16:15:52', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1173', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 15:16:29', '2019-10-10 15:17:29', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1174', 'Workstation_7846', 'GST-0001-1156', '2019-10-10 15:16:38', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1175', 'Workstation_7846', 'GST-0001-1157', '2019-10-10 15:16:44', '2019-10-10 16:16:44', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1176', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 15:16:48', '2019-10-10 15:17:48', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1177', 'Workstation_7846', 'GST-0001-1158', '2019-10-10 15:17:18', '2019-10-10 16:17:18', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1178', 'Workstation_7846', 'GST-0001-1159', '2019-10-10 15:17:40', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1179', 'Workstation_7846', 'GST-0001-1160', '2019-10-10 15:17:48', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1180', 'Workstation_7846', 'GST-0001-1161', '2019-10-10 15:18:22', '2019-10-10 16:18:22', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1181', 'Workstation_7846', 'GST-0001-1162', '2019-10-10 15:18:25', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1182', 'Workstation_7846', 'GST-0001-1163', '2019-10-10 15:18:29', '2019-10-10 16:18:29', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1183', 'Workstation_7846', 'GST-0001-1164', '2019-10-10 15:22:29', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1184', 'Workstation_7846', 'GST-0001-1165', '2019-10-10 15:39:47', '2019-10-10 16:39:47', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1185', 'Workstation_7846', 'GST-0001-1166', '2019-10-10 15:40:07', '2019-10-10 16:40:07', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1186', 'Workstation_7846', 'GST-0001-1167', '2019-10-10 15:40:12', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1187', 'Workstation_7846', 'GST-0001-1168', '2019-10-10 15:42:04', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1188', 'Workstation_7846', 'GST-0001-1169', '2019-10-10 15:42:08', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1189', 'Workstation_7846', 'GST-0001-1170', '2019-10-10 15:42:15', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1190', 'Workstation_7846', 'GST-0001-1171', '2019-10-10 15:42:28', '2019-10-10 16:42:28', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1191', 'Workstation_7846', 'GST-0001-1172', '2019-10-10 15:42:35', '2019-10-10 16:42:35', '0000-00-00 00:00:00', '5', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1192', 'Workstation_7846', 'GST-0001-1173', '2019-10-10 15:42:40', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1193', 'Workstation_7846', 'GST-0001-1174', '2019-10-10 15:42:48', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '5', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1194', 'Workstation_7846', 'GST-0001-1175', '2019-10-10 15:43:02', '2019-10-10 17:43:02', '0000-00-00 00:00:00', '5', '40.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1195', 'Workstation_7846', 'GST-0001-1176', '2019-10-10 15:58:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '6', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1196', 'Workstation_7846', 'GST-0001-1177', '2019-10-10 15:58:11', '2019-10-10 17:58:11', '0000-00-00 00:00:00', '1392', '40.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1197', 'Workstation_7846', 'GST-0001-1178', '2019-10-10 16:21:25', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '3', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1198', 'Workstation_7846', 'GST-0001-1179', '2019-10-10 16:21:30', '2019-10-10 17:21:30', '0000-00-00 00:00:00', '2', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1199', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 16:21:34', '2019-10-10 16:22:34', '2019-10-10 16:22:33', '60', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1200', 'Workstation_7846', 'GST-0001-1180', '2019-10-10 16:30:09', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '6', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1201', 'Workstation_7846', 'GST-0001-1181', '2019-10-10 16:30:21', '2019-10-10 17:30:21', '0000-00-00 00:00:00', '8', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1202', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 16:30:32', '2019-10-10 16:31:32', '0000-00-00 00:00:00', '3', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1203', 'Workstation_7846', 'GST-0001-1182', '2019-10-10 16:32:19', '2019-10-10 17:32:19', '0000-00-00 00:00:00', '15', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1204', 'Workstation_7846', 'GST-0001-1183', '2019-10-10 16:32:36', '2019-10-10 18:32:36', '0000-00-00 00:00:00', '4', '40.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1205', 'Workstation_7846', 'GST-0001-1184', '2019-10-10 16:32:41', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '21', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1206', 'Workstation_7846', 'GST-0001-1185', '2019-10-10 16:33:22', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '20', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1207', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 16:33:43', '2019-10-10 18:32:04', '2019-10-10 17:29:12', '3591', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1208', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 17:33:38', '2019-10-10 19:33:38', '0000-00-00 00:00:00', '84', '20.00', 'Inactive', 'Account Use'),
('SSSN-0001-1209', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 17:35:48', '2019-10-10 19:35:48', '0000-00-00 00:00:00', '3', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1210', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 17:50:02', '2019-10-10 19:52:02', '0000-00-00 00:00:00', '71', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1211', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 17:51:15', '2019-10-10 22:53:15', '0000-00-00 00:00:00', '241', '80.00', 'Inactive', 'Account Use'),
('SSSN-0001-1212', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 17:57:00', '2019-10-11 00:44:00', '0000-00-00 00:00:00', '471', '15.00', 'Inactive', 'Account Use'),
('SSSN-0001-1213', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 18:04:53', '2019-10-11 00:51:53', '0000-00-00 00:00:00', '33', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1214', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 18:05:32', '2019-10-10 22:07:32', '0000-00-00 00:00:00', '2000', '70.00', 'Inactive', 'Account Use'),
('SSSN-0001-1215', 'Workstation_7846', 'CSTMR-0001-1002', '2019-10-10 18:39:21', '2019-10-11 10:54:21', '0000-00-00 00:00:00', '0', '321.67', 'Inactive', 'Account Use'),
('SSSN-0001-1216', 'Workstation_4254', 'GST-0001-1186', '2019-11-01 17:38:14', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '4', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1217', 'Workstation_6632', 'GST-0001-1187', '2019-11-05 03:53:00', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '10', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1218', 'Workstation_6646', 'GST-0001-1188', '2019-11-05 03:54:45', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '1', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1219', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 03:54:59', '2019-11-05 09:04:59', '0000-00-00 00:00:00', '1', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1220', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 03:57:52', '2019-11-05 09:05:16', '0000-00-00 00:00:00', '1', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1221', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 03:58:21', '2019-11-05 09:05:39', '0000-00-00 00:00:00', '1', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1222', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 03:58:28', '2019-11-05 09:05:43', '0000-00-00 00:00:00', '1', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1223', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 04:05:37', '2019-11-05 10:05:57', '0000-00-00 00:00:00', '1', '20.00', 'Inactive', 'Account Use'),
('SSSN-0001-1224', 'Workstation_6646', 'GST-0001-1189', '2019-11-05 04:22:48', '0000-00-00 00:00:00', '0000-00-00 00:00:00', '3', '0.00', 'Inactive', 'Session Start'),
('SSSN-0001-1225', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 04:23:26', '2019-11-05 10:15:39', '2019-11-05 04:24:09', '695', '0.00', 'Inactive', 'Computer Unlock'),
('SSSN-0001-1226', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 05:11:51', '2019-11-05 10:52:24', '0000-00-00 00:00:00', '71', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1227', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 05:13:48', '2019-11-05 10:53:10', '0000-00-00 00:00:00', '27', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1228', 'Workstation_6646', 'GST-0001-1190', '2019-11-05 05:29:51', '2019-11-05 06:29:51', '0000-00-00 00:00:00', '19', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1229', 'Workstation_6646', 'GST-0001-1191', '2019-11-05 05:31:35', '2019-11-05 06:31:35', '0000-00-00 00:00:00', '8', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1230', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 05:32:25', '2019-11-05 11:11:20', '0000-00-00 00:00:00', '10', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1231', 'Workstation_6646', 'GST-0001-1192', '2019-11-05 05:33:02', '2019-11-05 06:33:02', '0000-00-00 00:00:00', '3', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1232', 'Workstation_6646', 'GST-0001-1193', '2019-11-05 05:48:12', '2019-11-05 05:53:12', '0000-00-00 00:00:00', '12', '1.67', 'Inactive', 'Time Custom'),
('SSSN-0001-1233', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 05:50:01', '2019-11-05 11:28:38', '0000-00-00 00:00:00', '6', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1234', 'Workstation_6646', 'GST-0001-1194', '2019-11-05 05:50:31', '2019-11-05 06:50:31', '0000-00-00 00:00:00', '3', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1235', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 05:53:27', '2019-11-05 11:31:58', '0000-00-00 00:00:00', '11', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1236', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 05:54:29', '2019-11-05 11:32:38', '0000-00-00 00:00:00', '2', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1237', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 05:55:06', '2019-11-05 11:33:13', '0000-00-00 00:00:00', '13', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1238', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 05:55:54', '2019-11-05 11:33:39', '0000-00-00 00:00:00', '7', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1239', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 05:56:56', '2019-11-05 11:34:29', '0000-00-00 00:00:00', '8', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1240', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 05:57:09', '2019-11-05 11:34:34', '0000-00-00 00:00:00', '4', '0.00', 'Inactive', 'Account Use'),
('SSSN-0001-1241', 'Workstation_6646', 'GST-0001-1195', '2019-11-05 05:57:23', '2019-11-05 06:57:23', '0000-00-00 00:00:00', '4', '20.00', 'Inactive', 'Time Custom'),
('SSSN-0001-1242', 'Workstation_6646', 'CSTMR-0001-1002', '2019-11-05 06:24:58', '2019-11-05 12:32:19', '0000-00-00 00:00:00', '3603', '10.00', 'Inactive', 'Account Use'),
('SSSN-0001-1243', 'Workstation_6646', 'GST-0001-1196', '2019-11-05 07:30:58', '2019-11-05 08:30:58', '0000-00-00 00:00:00', '4', '20.00', 'Inactive', 'Time Custom');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_workstation_session_report_information`
--

CREATE TABLE `tbl_workstation_session_report_information` (
  `Report_Identity` varchar(255) NOT NULL,
  `Session_Identity` varchar(255) DEFAULT NULL,
  `Customer_Identity` varchar(255) DEFAULT NULL,
  `Cash_Spent` decimal(10,2) DEFAULT NULL,
  `Report_DateTime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_workstation_session_report_information`
--

INSERT INTO `tbl_workstation_session_report_information` (`Report_Identity`, `Session_Identity`, `Customer_Identity`, `Cash_Spent`, `Report_DateTime`) VALUES
('RPRT-0001-1005', 'SSSN-0001-1239', 'CSTMR-0001-1002', '0.00', '2019-11-05 05:57:03'),
('RPRT-0001-1006', 'SSSN-0001-1240', 'CSTMR-0001-1002', '0.00', '2019-11-05 05:57:13'),
('RPRT-0001-1007', 'SSSN-0001-1241', 'GST-0001-1195', '20.00', '2019-11-05 05:57:27'),
('RPRT-0001-1010', 'SSSN-0001-1242', 'CSTMR-0001-1002', '10.00', '2019-11-05 07:25:01'),
('RPRT-0001-1012', 'SSSN-0001-1243', 'GST-0001-1196', '20.00', '2019-11-05 07:31:02');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_counter_information`
--
ALTER TABLE `tbl_counter_information`
  ADD PRIMARY KEY (`Counter_Identity`);

--
-- Indexes for table `tbl_customer_credential_information`
--
ALTER TABLE `tbl_customer_credential_information`
  ADD PRIMARY KEY (`Customer_Identity`);

--
-- Indexes for table `tbl_customer_personal_information`
--
ALTER TABLE `tbl_customer_personal_information`
  ADD PRIMARY KEY (`Customer_Identity`);

--
-- Indexes for table `tbl_customer_property_information`
--
ALTER TABLE `tbl_customer_property_information`
  ADD PRIMARY KEY (`Customer_Identity`);

--
-- Indexes for table `tbl_customer_report_information`
--
ALTER TABLE `tbl_customer_report_information`
  ADD PRIMARY KEY (`Report_Identity`);

--
-- Indexes for table `tbl_product_category_information`
--
ALTER TABLE `tbl_product_category_information`
  ADD PRIMARY KEY (`Category_Identity`);

--
-- Indexes for table `tbl_product_information`
--
ALTER TABLE `tbl_product_information`
  ADD PRIMARY KEY (`Product_Identity`);

--
-- Indexes for table `tbl_product_order_information`
--
ALTER TABLE `tbl_product_order_information`
  ADD PRIMARY KEY (`Order_Identity`);

--
-- Indexes for table `tbl_product_report_information`
--
ALTER TABLE `tbl_product_report_information`
  ADD PRIMARY KEY (`Report_ID`);

--
-- Indexes for table `tbl_staff_attendance_information`
--
ALTER TABLE `tbl_staff_attendance_information`
  ADD PRIMARY KEY (`Attendance_Identity`);

--
-- Indexes for table `tbl_staff_information`
--
ALTER TABLE `tbl_staff_information`
  ADD PRIMARY KEY (`Staff_Identity`);

--
-- Indexes for table `tbl_user_log_information`
--
ALTER TABLE `tbl_user_log_information`
  ADD PRIMARY KEY (`Log_Identity`);

--
-- Indexes for table `tbl_workstation_session_information`
--
ALTER TABLE `tbl_workstation_session_information`
  ADD PRIMARY KEY (`Session_Identity`);

--
-- Indexes for table `tbl_workstation_session_report_information`
--
ALTER TABLE `tbl_workstation_session_report_information`
  ADD PRIMARY KEY (`Report_Identity`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_counter_information`
--
ALTER TABLE `tbl_counter_information`
  MODIFY `Counter_Identity` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
