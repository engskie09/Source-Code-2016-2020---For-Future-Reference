-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 29, 2019 at 03:48 AM
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
-- Database: `db_mobidevfinals`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer_information`
--

CREATE TABLE `tbl_customer_information` (
  `customer_ID` varchar(50) NOT NULL,
  `customer_NickName` varchar(50) DEFAULT NULL,
  `customer_Birthday` varchar(50) DEFAULT NULL,
  `customer_HomeAddress` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product_information`
--

CREATE TABLE `tbl_product_information` (
  `product_ID` varchar(50) NOT NULL,
  `product_Name` varchar(50) DEFAULT NULL,
  `product_Price` varchar(50) DEFAULT NULL,
  `product_Quantity` varchar(50) DEFAULT NULL,
  `product_Description` varchar(50) DEFAULT NULL,
  `product_Image` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product_information_report`
--

CREATE TABLE `tbl_product_information_report` (
  `report_ID` varchar(50) NOT NULL,
  `product_IDList` varchar(50) DEFAULT NULL,
  `product_NameList` varchar(50) DEFAULT NULL,
  `product_QuantityList` varchar(50) DEFAULT NULL,
  `product_PriceList` varchar(50) DEFAULT NULL,
  `product_Total` varchar(50) DEFAULT NULL,
  `user_ID` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product_order_information`
--

CREATE TABLE `tbl_product_order_information` (
  `order_ID` varchar(50) NOT NULL,
  `product_ID` varchar(50) DEFAULT NULL,
  `product_Quantity` varchar(50) DEFAULT NULL,
  `order_Status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user_information`
--

CREATE TABLE `tbl_user_information` (
  `user_ID` varchar(50) NOT NULL,
  `user_Name` varchar(50) DEFAULT NULL,
  `user_Password` varchar(50) DEFAULT NULL,
  `user_Role` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_customer_information`
--
ALTER TABLE `tbl_customer_information`
  ADD PRIMARY KEY (`customer_ID`);

--
-- Indexes for table `tbl_product_information`
--
ALTER TABLE `tbl_product_information`
  ADD PRIMARY KEY (`product_ID`);

--
-- Indexes for table `tbl_product_information_report`
--
ALTER TABLE `tbl_product_information_report`
  ADD PRIMARY KEY (`report_ID`);

--
-- Indexes for table `tbl_product_order_information`
--
ALTER TABLE `tbl_product_order_information`
  ADD PRIMARY KEY (`order_ID`);

--
-- Indexes for table `tbl_user_information`
--
ALTER TABLE `tbl_user_information`
  ADD PRIMARY KEY (`user_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
