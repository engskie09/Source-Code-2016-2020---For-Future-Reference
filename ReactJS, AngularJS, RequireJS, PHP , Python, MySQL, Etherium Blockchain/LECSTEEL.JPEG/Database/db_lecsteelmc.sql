-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 13, 2019 at 11:45 PM
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
-- Database: `db_lecsteelmc`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_client_information`
--

CREATE TABLE `tbl_client_information` (
  `Client_Identity` varchar(255) NOT NULL,
  `Client_FullName` varchar(255) DEFAULT NULL,
  `Client_Position` varchar(255) DEFAULT NULL,
  `Client_Address_List` text DEFAULT NULL,
  `Client_Contact_LandlineNumber` varchar(255) DEFAULT NULL,
  `Client_Contact_MobileNumber` varchar(255) DEFAULT NULL,
  `Client_Contact_EmailAddress` varchar(255) DEFAULT NULL,
  `Client_Contact_FaxNumber` varchar(255) DEFAULT NULL,
  `Client_Remark` varchar(255) DEFAULT NULL,
  `Client_Status` varchar(255) DEFAULT NULL,
  `Client_Image_Path` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_client_information`
--

INSERT INTO `tbl_client_information` (`Client_Identity`, `Client_FullName`, `Client_Position`, `Client_Address_List`, `Client_Contact_LandlineNumber`, `Client_Contact_MobileNumber`, `Client_Contact_EmailAddress`, `Client_Contact_FaxNumber`, `Client_Remark`, `Client_Status`, `Client_Image_Path`) VALUES
('CLT-0001-0004', 'Betty Boop', 'Manager sa MCDO', '123 Quezon City', '2312-312312', '09123456789', 'boop@yahoo.com', '233-332', 'Sobrang tibay ng mga Bakal sa LecSteel', 'Enable', 'Data/Image/Client/CLT-0001-0004.jpeg');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_counter_information`
--

CREATE TABLE `tbl_counter_information` (
  `Counter_Identity` varchar(255) NOT NULL,
  `Counter_Code` varchar(255) DEFAULT NULL,
  `Counter_Count` int(10) DEFAULT NULL,
  `Counter_Description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_counter_information`
--

INSERT INTO `tbl_counter_information` (`Counter_Identity`, `Counter_Code`, `Counter_Count`, `Counter_Description`) VALUES
('CLT-0001-0001', 'CLT', 7, 'For Counting Client Identity'),
('EMP-0001-0001', 'EMP', 5, 'For Counting Employee Identity'),
('MATL-0001-0001', 'MATL', 191, 'For Counting Material Identity'),
('MATL-CAT-0001-0001', 'MATL-CAT', 14, 'For Counting Material Category Identity'),
('MATL-TYP-0001-0002', 'MATL-TYP', 12, 'For Counting Material Type Identity'),
('PO-0001-0001', 'PO', 136, 'For Counting Purchase Order Identity'),
('RR-0001-0001', 'RR', 1, 'For Counting Receiving Report Identity'),
('SPLR-0001-0001', 'SPLR', 10, 'For Counting Supplier Identity'),
('SPLR-CAT-0001-0001', 'SPLR-CAT', 6, 'For Counting Supplier Category Identity');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_employee_information`
--

CREATE TABLE `tbl_employee_information` (
  `Employee_Identity` varchar(255) NOT NULL,
  `Employee_Username` varchar(255) DEFAULT NULL,
  `Employee_Password` varchar(255) DEFAULT NULL,
  `Employee_FirstName` varchar(255) DEFAULT 'NULL',
  `Employee_MiddleName` varchar(255) DEFAULT 'NULL',
  `Employee_LastName` varchar(255) DEFAULT 'NULL',
  `Employee_Position` varchar(255) DEFAULT 'NULL',
  `Employee_Image_Path` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_employee_information`
--

INSERT INTO `tbl_employee_information` (`Employee_Identity`, `Employee_Username`, `Employee_Password`, `Employee_FirstName`, `Employee_MiddleName`, `Employee_LastName`, `Employee_Position`, `Employee_Image_Path`) VALUES
('EMP-0001', 'engskie', '123456', 'Rafael', 'Nobleza', 'Masallo', 'Admin', 'Data/Image/Employee/EMP-0001.jpeg'),
('EMP-0001-0002', 'bean', 'bean', 'Rowan Sebastian ', 'Sebastian ', 'Atkinson', 'Staff', 'Data/Image/Employee/EMP-0001-0002.jpeg');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_material_category_information`
--

CREATE TABLE `tbl_material_category_information` (
  `Category_Identity` varchar(255) NOT NULL,
  `Category_Name` varchar(255) DEFAULT NULL,
  `Category_Description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_material_category_information`
--

INSERT INTO `tbl_material_category_information` (`Category_Identity`, `Category_Name`, `Category_Description`) VALUES
('MATL-CAT-0001-0009', 'Bakal', 'Iron na matitibay'),
('MATL-CAT-0001-0010', 'Kahoy', 'Brown yung mga kahoy namin');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_material_information`
--

CREATE TABLE `tbl_material_information` (
  `Material_Identity` varchar(255) NOT NULL,
  `Material_Part_Number` varchar(255) DEFAULT NULL,
  `Material_Description` text DEFAULT NULL,
  `Material_Unit` varchar(255) DEFAULT NULL,
  `Material_Size` varchar(255) DEFAULT NULL,
  `Material_Category_Identity` varchar(255) DEFAULT NULL,
  `Material_Type_Identity` varchar(255) DEFAULT NULL,
  `Material_Remark` varchar(255) DEFAULT NULL,
  `Material_Quantity` int(10) DEFAULT NULL,
  `Material_Reorder_Point` varchar(255) DEFAULT NULL,
  `Material_Order_Minimum` int(10) DEFAULT NULL,
  `Material_Price_Expensive` decimal(10,2) DEFAULT NULL,
  `Material_Price_Least` varchar(255) DEFAULT NULL,
  `Material_Order_Identity_Expensive` varchar(255) DEFAULT NULL,
  `Material_Order_Identity_Least` varchar(255) DEFAULT NULL,
  `Material_Price_Current` decimal(10,2) DEFAULT NULL,
  `Material_Image_Path` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_material_information`
--

INSERT INTO `tbl_material_information` (`Material_Identity`, `Material_Part_Number`, `Material_Description`, `Material_Unit`, `Material_Size`, `Material_Category_Identity`, `Material_Type_Identity`, `Material_Remark`, `Material_Quantity`, `Material_Reorder_Point`, `Material_Order_Minimum`, `Material_Price_Expensive`, `Material_Price_Least`, `Material_Order_Identity_Expensive`, `Material_Order_Identity_Least`, `Material_Price_Current`, `Material_Image_Path`) VALUES
('MATL-0001-0156', 'vcv', 'z', 'z', 'z', 'Category_2', 'Type_1', '123', 123, NULL, 123, NULL, NULL, NULL, NULL, '123.00', 'Data/Image/Material/MATL-0001-0156.jpeg'),
('MATL-0001-0164', '21312', '123', '312', '13', 'Category_1', 'Type_2', '123', 23, NULL, 123, NULL, NULL, NULL, NULL, '123.00', 'Data/Image/Material/MATL-0001-0164.jpeg'),
('MATL-0001-0188', '666-333-4444', 'Matibay na kahoy ito Pre', '20', '5 Meters', 'MATL-CAT-0001-0010', 'MATL-TYP-0001-0003', 'Hindi inaanay', 200, NULL, 20, NULL, NULL, NULL, NULL, '200.00', 'Data/Image/Material/MATL-0001-0188.jpeg'),
('MATL-0001-0189', '333-444-5555', 'Hindi kinakalawang', '20', '20 Meters', 'MATL-CAT-0001-0009', 'MATL-TYP-0001-0002', '123', 200, NULL, 20, NULL, NULL, NULL, NULL, '200.00', 'Data/Image/Material/MATL-0001-0189.jpeg');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_material_type_information`
--

CREATE TABLE `tbl_material_type_information` (
  `Type_Identity` varchar(255) NOT NULL,
  `Type_Name` varchar(255) DEFAULT NULL,
  `Type_Description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_material_type_information`
--

INSERT INTO `tbl_material_type_information` (`Type_Identity`, `Type_Name`, `Type_Description`) VALUES
('MATL-TYP-0001-0002', 'High-Carbon Steel.', 'Carbon steel is a steel with carbon content up to 2.1% by weight.'),
('MATL-TYP-0001-0003', 'Softwoods', 'Softwoods are not weaker than hardwoods. ');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_purchase_order_information_child`
--

CREATE TABLE `tbl_purchase_order_information_child` (
  `Purchase_Order_Count` int(10) NOT NULL,
  `Purchase_Order_Identity` varchar(255) DEFAULT NULL,
  `Purchase_Order_Number_Child` varchar(255) DEFAULT NULL,
  `Purchase_Order_Material_Identity` varchar(255) DEFAULT NULL,
  `Purchase_Order_Quantity_Issued` int(10) DEFAULT NULL,
  `Purchase_Order_Quantity_Served` int(10) DEFAULT NULL,
  `Purchase_Order_Quantity_Balance` int(10) DEFAULT NULL,
  `Purchase_Order_Employee_Identity` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_purchase_order_information_child`
--

INSERT INTO `tbl_purchase_order_information_child` (`Purchase_Order_Count`, `Purchase_Order_Identity`, `Purchase_Order_Number_Child`, `Purchase_Order_Material_Identity`, `Purchase_Order_Quantity_Issued`, `Purchase_Order_Quantity_Served`, `Purchase_Order_Quantity_Balance`, `Purchase_Order_Employee_Identity`) VALUES
(19, 'PO-0001-0134', '1', 'MATL-0001-0188', 5, 2, 3, 'EMP-0001'),
(20, 'PO-0001-0134', '1', 'MATL-0001-0189', 4, 2, 2, 'EMP-0001'),
(21, 'PO-0001-0135', '2', 'MATL-0001-0189', 5, 1, 4, 'EMP-0001');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_purchase_order_information_parent`
--

CREATE TABLE `tbl_purchase_order_information_parent` (
  `Purchase_Order_Identity` varchar(255) NOT NULL,
  `Purchase_Order_Number_Parent` varchar(255) NOT NULL,
  `Purchase_Order_Supplier_Identity` varchar(255) DEFAULT NULL,
  `Purchase_Order_Remarks` varchar(255) DEFAULT NULL,
  `Purchase_Order_Amount` decimal(10,2) DEFAULT NULL,
  `Purchase_Order_Amount_Paid` decimal(10,2) DEFAULT NULL,
  `Purchase_Order_DateTime_Issue` datetime DEFAULT NULL,
  `Purchase_Order_DateTime_Due` datetime DEFAULT NULL,
  `Purchase_Order_DateTime_Posted` datetime DEFAULT NULL,
  `Purchase_Order_DateTime_Unposted` datetime DEFAULT NULL,
  `Purchase_Order_Status` varchar(255) DEFAULT 'NULL',
  `Purchase_Order_Image_Path` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_purchase_order_information_parent`
--

INSERT INTO `tbl_purchase_order_information_parent` (`Purchase_Order_Identity`, `Purchase_Order_Number_Parent`, `Purchase_Order_Supplier_Identity`, `Purchase_Order_Remarks`, `Purchase_Order_Amount`, `Purchase_Order_Amount_Paid`, `Purchase_Order_DateTime_Issue`, `Purchase_Order_DateTime_Due`, `Purchase_Order_DateTime_Posted`, `Purchase_Order_DateTime_Unposted`, `Purchase_Order_Status`, `Purchase_Order_Image_Path`) VALUES
('PO-0001-0134', '1', 'SPLR-0001-0009', 'rewr', '1000.00', '0.00', '2019-12-13 00:00:00', '2019-12-16 00:00:00', '2019-12-13 00:00:00', '2019-12-11 00:00:00', 'Posted', 'Data/Image/Purchase_Order/PO-0001-0134.jpeg'),
('PO-0001-0135', '2', 'SPLR-0001-0009', 'rwer23r', '1000.00', '0.00', '2019-12-13 00:00:00', '2019-12-16 00:00:00', '1900-12-30 00:00:00', '2019-12-13 00:00:00', 'Unposted', 'Data/Image/Purchase_Order/PO-0001-0135.jpeg');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_receiving_report_information_child`
--

CREATE TABLE `tbl_receiving_report_information_child` (
  `Receiving_Report_Count` varchar(255) NOT NULL,
  `Receiving_Report_Identity` varchar(255) DEFAULT NULL,
  `Receiving_Report_Number_Child` varchar(255) DEFAULT NULL,
  `Receiving_Report_Material_Identity` varchar(255) DEFAULT NULL,
  `Receiving_Report_Quantity_Issued` varchar(255) DEFAULT NULL,
  `Receiving_Report_Quantity_Balance` varchar(255) DEFAULT NULL,
  `Purchase_Order_Employee_Identity` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_receiving_report_information_parent`
--

CREATE TABLE `tbl_receiving_report_information_parent` (
  `Receiving_Report_Identity` varchar(255) DEFAULT NULL,
  `Receiving_Report_Number_Parent` varchar(255) DEFAULT NULL,
  `Receiving_Report_Purchase_Order_Identity` varchar(255) DEFAULT NULL,
  `Receiving_Report_DateTime` datetime DEFAULT NULL,
  `Receiving_Report_Remarks` varchar(255) DEFAULT NULL,
  `Receiving_Report_Status` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supplier_category_information`
--

CREATE TABLE `tbl_supplier_category_information` (
  `Category_Identity` varchar(255) NOT NULL,
  `Category_Name` varchar(255) DEFAULT NULL,
  `Category_Description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_supplier_category_information`
--

INSERT INTO `tbl_supplier_category_information` (`Category_Identity`, `Category_Name`, `Category_Description`) VALUES
('SPLR-CAT-0001-0001', 'Bakal', 'Matitibay mga bakal nito');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_supplier_information`
--

CREATE TABLE `tbl_supplier_information` (
  `Supplier_Identity` varchar(255) NOT NULL,
  `Supplier_Code` varchar(255) NOT NULL,
  `Supplier_Category_Identity_List` text DEFAULT NULL,
  `Supplier_Name` varchar(255) DEFAULT NULL,
  `Supplier_Contact_FullName` varchar(255) DEFAULT NULL,
  `Supplier_Contact_LandlineNumber` varchar(255) DEFAULT NULL,
  `Supplier_Contact_MobileNumber` varchar(255) DEFAULT NULL,
  `Supplier_Contact_EmailAddress` varchar(255) DEFAULT NULL,
  `Supplier_Contact_FaxNumber` varchar(255) DEFAULT NULL,
  `Supplier_Contact_BusinessAddress` varchar(255) DEFAULT NULL,
  `Supplier_Term` varchar(255) DEFAULT NULL,
  `Supplier_Status` varchar(255) DEFAULT NULL,
  `Supplier_Image_Path` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_supplier_information`
--

INSERT INTO `tbl_supplier_information` (`Supplier_Identity`, `Supplier_Code`, `Supplier_Category_Identity_List`, `Supplier_Name`, `Supplier_Contact_FullName`, `Supplier_Contact_LandlineNumber`, `Supplier_Contact_MobileNumber`, `Supplier_Contact_EmailAddress`, `Supplier_Contact_FaxNumber`, `Supplier_Contact_BusinessAddress`, `Supplier_Term`, `Supplier_Status`, `Supplier_Image_Path`) VALUES
('SPLR-0001-0003', '011144', 'SPLR-CAT-0001-0001', 'Alibabaass', 'Scooby Doo', '143-4444-555', '09123456789', 'Alibaba@google.com', '444-5555', '123 Caloocan City', '1', 'Disable', 'Data/Image/Supplier/SPLR-0001-0003.jpeg'),
('SPLR-0001-0006', '011145', 'SPLR-CAT-0001-0001', 'asd', 'asdasd', '3122', '123', 'asda', '123', 'asd', 'sd12d', 'Enable', ''),
('SPLR-0001-0009', '23192', 'SPLR-CAT-0001-0001', '123', '23', '3123', '231', '123s', '312', '1231', '123', 'Enable', 'Data/Image/Supplier/SPLR-0001-0009.jpeg');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_client_information`
--
ALTER TABLE `tbl_client_information`
  ADD PRIMARY KEY (`Client_Identity`);

--
-- Indexes for table `tbl_counter_information`
--
ALTER TABLE `tbl_counter_information`
  ADD PRIMARY KEY (`Counter_Identity`);

--
-- Indexes for table `tbl_employee_information`
--
ALTER TABLE `tbl_employee_information`
  ADD PRIMARY KEY (`Employee_Identity`);

--
-- Indexes for table `tbl_material_category_information`
--
ALTER TABLE `tbl_material_category_information`
  ADD PRIMARY KEY (`Category_Identity`);

--
-- Indexes for table `tbl_material_information`
--
ALTER TABLE `tbl_material_information`
  ADD PRIMARY KEY (`Material_Identity`);

--
-- Indexes for table `tbl_material_type_information`
--
ALTER TABLE `tbl_material_type_information`
  ADD PRIMARY KEY (`Type_Identity`);

--
-- Indexes for table `tbl_purchase_order_information_child`
--
ALTER TABLE `tbl_purchase_order_information_child`
  ADD PRIMARY KEY (`Purchase_Order_Count`);

--
-- Indexes for table `tbl_purchase_order_information_parent`
--
ALTER TABLE `tbl_purchase_order_information_parent`
  ADD PRIMARY KEY (`Purchase_Order_Identity`,`Purchase_Order_Number_Parent`);

--
-- Indexes for table `tbl_receiving_report_information_child`
--
ALTER TABLE `tbl_receiving_report_information_child`
  ADD PRIMARY KEY (`Receiving_Report_Count`);

--
-- Indexes for table `tbl_supplier_category_information`
--
ALTER TABLE `tbl_supplier_category_information`
  ADD PRIMARY KEY (`Category_Identity`);

--
-- Indexes for table `tbl_supplier_information`
--
ALTER TABLE `tbl_supplier_information`
  ADD PRIMARY KEY (`Supplier_Identity`,`Supplier_Code`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_purchase_order_information_child`
--
ALTER TABLE `tbl_purchase_order_information_child`
  MODIFY `Purchase_Order_Count` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
