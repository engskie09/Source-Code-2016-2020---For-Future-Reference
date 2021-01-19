-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 08, 2019 at 06:07 PM
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
-- Database: `just_orderingdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer_order_current`
--

CREATE TABLE `tbl_customer_order_current` (
  `product_id` varchar(50) NOT NULL,
  `product_name` varchar(50) DEFAULT NULL,
  `product_quantity` varchar(50) DEFAULT NULL,
  `product_price` varchar(50) DEFAULT NULL,
  `product_description` varchar(50) DEFAULT NULL,
  `product_category` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product_information`
--

CREATE TABLE `tbl_product_information` (
  `product_id` varchar(50) NOT NULL,
  `product_name` varchar(50) DEFAULT NULL,
  `product_quantity` varchar(50) DEFAULT NULL,
  `product_price` varchar(50) DEFAULT NULL,
  `product_description` varchar(50) DEFAULT NULL,
  `product_category` varchar(50) DEFAULT NULL,
  `product_picture` longblob
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_report_customer_order`
--

CREATE TABLE `tbl_report_customer_order` (
  `report_ID` varchar(50) DEFAULT NULL,
  `customer_ID` varchar(50) DEFAULT NULL,
  `customer_firstname` varchar(50) DEFAULT NULL,
  `customer_middlename` varchar(50) DEFAULT NULL,
  `customer_lastname` varchar(50) NOT NULL,
  `customer_product_id` varchar(50) NOT NULL,
  `customer_product_name` varchar(50) NOT NULL,
  `customer_product_quantity` varchar(50) NOT NULL,
  `customer_product_cost` varchar(50) NOT NULL,
  `customer_datebuy` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_customer_order_current`
--
ALTER TABLE `tbl_customer_order_current`
  ADD PRIMARY KEY (`product_id`);

--
-- Indexes for table `tbl_product_information`
--
ALTER TABLE `tbl_product_information`
  ADD PRIMARY KEY (`product_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
