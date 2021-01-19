-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 13, 2020 at 01:11 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ub_ecims`
--

-- --------------------------------------------------------

--
-- Table structure for table `cooperative`
--

CREATE TABLE `cooperative` (
  `Cooperative_Identity` varchar(10) NOT NULL,
  `Cooperative_Name` varchar(200) DEFAULT NULL,
  `Cooperative_Parent` varchar(10) DEFAULT NULL,
  `Cooperative_Background` varchar(2000) DEFAULT NULL,
  `Cooperative_Rationale` varchar(2000) DEFAULT NULL,
  `Cooperative_Type` varchar(20) DEFAULT NULL,
  `Cooperative_Category` varchar(20) DEFAULT NULL,
  `Cooperative_Region` varchar(20) DEFAULT NULL,
  `Cooperative_Province` varchar(20) DEFAULT NULL,
  `Cooperative_Locality` varchar(30) DEFAULT NULL,
  `Cooperative_Office_Address` varchar(100) DEFAULT NULL,
  `Cooperative_Operation_Area` varchar(10) DEFAULT NULL,
  `Cooperative_Common_Bond` varchar(20) DEFAULT NULL,
  `Cooperative_Member_Composition` varchar(500) DEFAULT NULL,
  `Cooperative_Founder` varchar(10) DEFAULT NULL,
  `Cooperative_Member_Projected_Growth` varchar(500) DEFAULT NULL,
  `Cooperative_Organization_Registration` varchar(500) DEFAULT NULL,
  `Cooperative_State` varchar(10) DEFAULT NULL,
  `Cooperative_Inserted_By` varchar(10) DEFAULT NULL,
  `Cooperative_Inserted_DateTime` datetime DEFAULT NULL,
  `Cooperative_Updated_By` varchar(10) DEFAULT NULL,
  `Cooperative_Updated_DateTime` datetime DEFAULT NULL,
  `Cooperative_Deleted_By` varchar(10) DEFAULT NULL,
  `Cooperative_Deleted_DateTime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cooperative`
--

INSERT INTO `cooperative` (`Cooperative_Identity`, `Cooperative_Name`, `Cooperative_Parent`, `Cooperative_Background`, `Cooperative_Rationale`, `Cooperative_Type`, `Cooperative_Category`, `Cooperative_Region`, `Cooperative_Province`, `Cooperative_Locality`, `Cooperative_Office_Address`, `Cooperative_Operation_Area`, `Cooperative_Common_Bond`, `Cooperative_Member_Composition`, `Cooperative_Founder`, `Cooperative_Member_Projected_Growth`, `Cooperative_Organization_Registration`, `Cooperative_State`, `Cooperative_Inserted_By`, `Cooperative_Inserted_DateTime`, `Cooperative_Updated_By`, `Cooperative_Updated_DateTime`, `Cooperative_Deleted_By`, `Cooperative_Deleted_DateTime`) VALUES
('COOP-1', 'asd', NULL, NULL, NULL, 'Type 4', 'Secondary', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_category`
--

CREATE TABLE `cooperative_category` (
  `Category_Identity` varchar(20) NOT NULL,
  `Category_Name` varchar(20) DEFAULT NULL,
  `Category_Description` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cooperative_category`
--

INSERT INTO `cooperative_category` (`Category_Identity`, `Category_Name`, `Category_Description`) VALUES
('COOP-CAT-1', 'Primary', 'Primary'),
('COOP-CAT-3', 'Secondary', 'Secondary'),
('COOP-CAT-5', 'Tertiary', 'Tertiary');

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_commonbond`
--

CREATE TABLE `cooperative_commonbond` (
  `CommonBond_Identity` varchar(20) NOT NULL,
  `CommonBond_Name` varchar(20) DEFAULT NULL,
  `CommonBond_Description` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cooperative_commonbond`
--

INSERT INTO `cooperative_commonbond` (`CommonBond_Identity`, `CommonBond_Name`, `CommonBond_Description`) VALUES
('COOP-CB-1', 'Residential', 'Residential'),
('COOP-CB-2', 'Institutional', 'Institutional'),
('COOP-CB-3', 'Occupational', 'Occupational'),
('COOP-CB-4', 'Associational', 'Associational');

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_economicaspect`
--

CREATE TABLE `cooperative_economicaspect` (
  `Cooperative_Identity` varchar(10) NOT NULL,
  `EconomicAspect_Identical_Cooperative_Plan` varchar(100) DEFAULT NULL,
  `EconomicAspect_Strategy` varchar(500) DEFAULT NULL,
  `EconomicAspect_Target_Market` varchar(10) DEFAULT NULL,
  `EconomicAspect_Activity` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cooperative_economicaspect`
--

INSERT INTO `cooperative_economicaspect` (`Cooperative_Identity`, `EconomicAspect_Identical_Cooperative_Plan`, `EconomicAspect_Strategy`, `EconomicAspect_Target_Market`, `EconomicAspect_Activity`) VALUES
('COOP-1', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_economicsurvey`
--

CREATE TABLE `cooperative_economicsurvey` (
  `Cooperative_Identity` varchar(10) NOT NULL,
  `EconomicSurvey_Description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cooperative_economicsurvey`
--

INSERT INTO `cooperative_economicsurvey` (`Cooperative_Identity`, `EconomicSurvey_Description`) VALUES
('COOP-1', '{\"Cooperative_1\":{\"Cooperative_Name\":\"asd\",\"Cooperative_Background\":\"asda\",\"Cooperative_Rationale\":\"asd\"},\"Cooperative_2\":{\"Cooperative_Type\":\"Type 4\",\"Cooperative_Category\":\"Secondary\",\"Cooperative_Region\":\"Region 1\",\"Cooperative_Province\":\"Cebu\",\"Cooperative_Locality\":\"Malabon\",\"Cooperative_Office_Address\":\"qwe\",\"Cooperative_Operation_Area\":\"Regional\",\"Cooperative_Common_Bond\":\"Associational\",\"Cooperative_Founder\":\"56456\",\"Cooperative_Member_Composition\":[\"Men\",\"Women\",\"Students\",\"Teachers\",\"Farmer\",\"Worker\",\"Single Parents\",\"Over Age People\"],\"Cooperative_Organization_Registration\":[\"Department of Labor and Employment\",\"Department of Trade and Industry\"],\"Cooperative_Member_Projected_Growth\":[{\"Growth_Key\":\"Growth-0\",\"Growth_Year\":2020,\"Growth_Value\":0},{\"Growth_Key\":\"Growth-1\",\"Growth_Year\":2021,\"Growth_Value\":0},{\"Growth_Key\":\"Growth-2\",\"Growth_Year\":2022,\"Growth_Value\":0}]},\"Cooperative_ShareCapital\":{\"ShareCapital_Authorized\":\"0\",\"ShareCapital_Issued\":\"0\",\"ShareCapital_Unissued\":\"0\",\"ShareCapital_Subscribed\":\"0\",\"ShareCapital_Unsubscribed\":\"0\",\"ShareCapital_Called-Up\":\"0\",\"ShareCapital_Uncalled\":\"0\",\"ShareCapital_Paid-Up\":\"0\",\"ShareCapital_Unpaid\":\"0\",\"ShareCapital_Reserve\":\"0\",\"ShareCapital_Par_Value\":\"0\",\"ShareCapital_Share_Sold\":\"0\"},\"Cooperative_EconomicAspect\":{\"EconomicAspect_Identical_Cooperative_Plan\":[\"(ARC) MAT-I FARMERS MULTI-PURPOSE COOPERATIVE (ARC-MAFAMPCO)\"],\"EconomicAspect_Target_Market\":[\"Member\"],\"EconomicAspect_Strategy\":[{\"Strategy_Key\":\"Strategy-0\",\"Strategy_Description\":\"Collective purchases\"},{\"Strategy_Key\":\"Strategy-1\",\"Strategy_Description\":\"Commitment on lending policies\"},{\"Strategy_Key\":\"Strategy-2\",\"Strategy_Description\":\"Active participation in cooperative affairs\"}],\"EconomicAspect_Activity\":[{\"Activity_Key\":\"Activity-0\",\"Activity_Year\":2020,\"Activity_Description\":\"Recruit\"},{\"Activity_Key\":\"Activity-1\",\"Activity_Year\":2021,\"Activity_Description\":\"Free Education\"},{\"Activity_Key\":\"Activity-2\",\"Activity_Year\":2022,\"Activity_Description\":\"Accumulate Donations\"}]},\"Cooperative_FinancialAspect\":{\"FinancialAspect_Capitalization_Initial_Capital\":\"\",\"FinancialAspect_Organization_Investment\":[\"Cooperative Bank\",\"Federation\",\"Joint Ventures\",\"Mutual\",\"Insurance\"],\"FinancialAspect_Capitalization_Generate_Capital\":[],\"FinancialAspect_Capitalization_Internal_Capital_Strategy\":[{\"Strategy_Key\":\"Strategy-0\",\"Strategy_Description\":\"Member Capitalization\"},{\"Strategy_Key\":\"Strategy-1\",\"Strategy_Description\":\"Member Loans\"},{\"Strategy_Key\":\"Strategy-2\",\"Strategy_Description\":\"Bank debt\"},{\"Strategy_Key\":\"Strategy-3\",\"Strategy_Description\":\"Expansion\"},{\"Strategy_Key\":\"Strategy-4\",\"Strategy_Description\":\"Start-ups\"},{\"Strategy_Key\":\"Strategy-5\",\"Strategy_Description\":\"Summing up the grubstake\"}],\"FinancialAspect_Revenue_Projected\":[{\"Revenue_Key\":\"Revenue-0\",\"Revenue_Year\":2021,\"Revenue_Value\":0},{\"Revenue_Key\":\"Revenue-1\",\"Revenue_Year\":2022,\"Revenue_Value\":0},{\"Revenue_Key\":\"Revenue-2\",\"Revenue_Year\":2023,\"Revenue_Value\":0}],\"FinancialAspect_Expense_Estimated\":[{\"Expense_Key\":\"Expense-0\",\"Expense_Year\":2021,\"Expense_Value\":0},{\"Expense_Key\":\"Expense-1\",\"Expense_Year\":2022,\"Expense_Value\":0},{\"Expense_Key\":\"Expense-2\",\"Expense_Year\":2023,\"Expense_Value\":0}]},\"Cooperative_TechnicalAspect\":{\"TechnicalAspect_Equipment\":[\"Typewriter\",\"Computer\",\"Table\",\"Chair\",\"Calculator\",\"Vault/Safe\",\"Filing Cabinet\",\"Medical Instrument\",\"Farm Equipment\",\"Post Harvest Equipment\",\"Solar Dryer\",\"Fishing Equipment\",\"Printer\",\"Desk\",\"Telephone\"],\"TechnicalAspect_Machinery\":[\"Milling\",\"Xerox Machine\",\"Bulldozer\",\"Backhoe\",\"Road Grader\",\"Textile\",\"Semiconductor\",\"Plastic\",\"Elevator\",\"Escalator\",\"Conveyor\",\"Stacker\",\"Tractor\",\"Combine\",\"Plow\"],\"TechnicalAspect_Facility\":[\"Warehouse\",\"Manufacturing Facility\",\"Conference Centre\",\"Meeting Room\"],\"TechnicalAspect_Procurement_Mode\":[\"Cash Purchase\",\"Loans\",\"Donations\"],\"TechnicalAspect_Operator_Background\":[]},\"Cooperative_OrganizationalStructure\":{\"OrganizationalStructure_Member_Eligibility\":[{\"Eligibility_Key\":\"Eligibility-0\",\"Eligibility_Description\":\"Honesty and integrity.\"},{\"Eligibility_Key\":\"Eligibility-1\",\"Eligibility_Description\":\"Confidence.\"},{\"Eligibility_Key\":\"Eligibility-2\",\"Eligibility_Description\":\"Inspire Others.\"},{\"Eligibility_Key\":\"Eligibility-3\",\"Eligibility_Description\":\"Commitment and Passion.\"},{\"Eligibility_Key\":\"Eligibility-4\",\"Eligibility_Description\":\"Good Communicator.\"}],\"OrganizationalStructure_Program\":[{\"Program_Key\":\"Program-0\",\"Program_Educatee\":\"Members\",\"Program_Description\":\"\"},{\"Program_Key\":\"Program-1\",\"Program_Educatee\":\"Officers\",\"Program_Description\":\"\"},{\"Program_Key\":\"Program-2\",\"Program_Educatee\":\"Staffs\",\"Program_Description\":\"\"}],\"OrganizationalStructure_Member\":[{\"Position_Name\":\"Manager\",\"Member_Fullname\":\"\",\"Member_Appointment_Status\":\"\",\"Member_Eligibility\":\"\",\"Member_Compensation\":\"0\"},{\"Position_Name\":\"Accountant\",\"Member_Fullname\":\"\",\"Member_Appointment_Status\":\"\",\"Member_Eligibility\":\"\",\"Member_Compensation\":\"0\"},{\"Position_Name\":\"Bookkeeper\",\"Member_Fullname\":\"\",\"Member_Appointment_Status\":\"\",\"Member_Eligibility\":\"\",\"Member_Compensation\":\"0\"},{\"Position_Name\":\"Cashier\",\"Member_Fullname\":\"\",\"Member_Appointment_Status\":\"\",\"Member_Eligibility\":\"\",\"Member_Compensation\":\"0\"},{\"Position_Name\":\"Collector\",\"Member_Fullname\":\"\",\"Member_Appointment_Status\":\"\",\"Member_Eligibility\":\"\",\"Member_Compensation\":\"0\"},{\"Position_Name\":\"Sales Clerk\",\"Member_Fullname\":\"\",\"Member_Appointment_Status\":\"\",\"Member_Eligibility\":\"\",\"Member_Compensation\":\"0\"}],\"OrganizationalStructure_Committee\":[{\"Committee_Name\":\"Audit\",\"Committee_Chairman\":[],\"Committee_Member\":[],\"Committee_Description\":\"\"},{\"Committee_Name\":\"Credit\",\"Committee_Chairman\":[],\"Committee_Member\":[],\"Committee_Description\":\"\"},{\"Committee_Name\":\"Election\",\"Committee_Chairman\":[],\"Committee_Member\":[],\"Committee_Description\":\"\"},{\"Committee_Name\":\"Education & Training\",\"Committee_Chairman\":[],\"Committee_Member\":[],\"Committee_Description\":\"\"},{\"Committee_Name\":\"Mediation/Conciliation\",\"Committee_Chairman\":[],\"Committee_Member\":[],\"Committee_Description\":\"\"}]},\"Cooperative_OrganizationalStructure_Member_Chart\":[{\"Identity\":\"USR-0\",\"Identity_Parent\":\"\",\"Title\":\"Chairman\",\"Description\":\"Name 0\",\"Image\":\"http://localhost/Data/System/Image/Person_Image.png\"},{\"Identity\":\"USR-1\",\"Identity_Parent\":\"USR-0\",\"Title\":\"BOD Member\",\"Description\":\"Name 1\",\"Image\":\"http://localhost/Data/System/Image/Person_Image.png\"},{\"Identity\":\"USR-2\",\"Identity_Parent\":\"USR-0\",\"Title\":\"BOD Member\",\"Description\":\"Name 2\",\"Image\":\"http://localhost/Data/System/Image/Person_Image.png\"}],\"Cooperative_OrganizationalStructure_Remark\":{\"Cooperative_OrganizationalStructure_Remark_Member\":[{\"OrganizationalStructure_Remark_Member\":\"\",\"OrganizationalStructure_Remark_Proof\":\"\",\"OrganizationalStructure_Remark_Address\":\"\"},{\"OrganizationalStructure_Remark_Member\":\"\",\"OrganizationalStructure_Remark_Proof\":\"\",\"OrganizationalStructure_Remark_Address\":\"\"},{\"OrganizationalStructure_Remark_Member\":\"\",\"OrganizationalStructure_Remark_Proof\":\"\",\"OrganizationalStructure_Remark_Address\":\"\"},{\"OrganizationalStructure_Remark_Member\":\"\",\"OrganizationalStructure_Remark_Proof\":\"\",\"OrganizationalStructure_Remark_Address\":\"\"},{\"OrganizationalStructure_Remark_Member\":\"\",\"OrganizationalStructure_Remark_Proof\":\"\",\"OrganizationalStructure_Remark_Address\":\"\"}],\"OrganizationalStructure_Remark_Day\":\"\",\"OrganizationalStructure_Remark_Month\":\"\",\"OrganizationalStructure_Remark_Year\":\"\",\"OrganizationalStructure_Remark_Address\":\"\"}}');

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_financialaspect`
--

CREATE TABLE `cooperative_financialaspect` (
  `Cooperative_Identity` varchar(10) NOT NULL,
  `FinancialAspect_Capitalization_Generate_Capital` varchar(500) DEFAULT NULL,
  `FinancialAspect_Capitalization_Initial_Capital` varchar(10) DEFAULT NULL,
  `FinancialAspect_Capitalization_Internal_Capital_Strategy` varchar(1000) DEFAULT NULL,
  `FinancialAspect_Revenue_Projected` varchar(500) DEFAULT NULL,
  `FinancialAspect_Expense_Estimated` varchar(500) DEFAULT NULL,
  `FinancialAspect_Organization_Investment` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cooperative_financialaspect`
--

INSERT INTO `cooperative_financialaspect` (`Cooperative_Identity`, `FinancialAspect_Capitalization_Generate_Capital`, `FinancialAspect_Capitalization_Initial_Capital`, `FinancialAspect_Capitalization_Internal_Capital_Strategy`, `FinancialAspect_Revenue_Projected`, `FinancialAspect_Expense_Estimated`, `FinancialAspect_Organization_Investment`) VALUES
('COOP-1', NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_operationarea`
--

CREATE TABLE `cooperative_operationarea` (
  `OperationArea_Identity` varchar(10) NOT NULL,
  `OperationArea_Name` varchar(20) DEFAULT NULL,
  `OperationArea_Description` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cooperative_operationarea`
--

INSERT INTO `cooperative_operationarea` (`OperationArea_Identity`, `OperationArea_Name`, `OperationArea_Description`) VALUES
('COOP-OA-1', 'Barangay', 'Barangay'),
('COOP-OA-2', 'Municipal/City', 'Municipal/City'),
('COOP-OA-3', 'Provincial', 'Provincial'),
('COOP-OA-4', 'Regional', 'Regional'),
('COOP-OA-5', 'National', 'National');

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_organizationalstructure`
--

CREATE TABLE `cooperative_organizationalstructure` (
  `Cooperative_Identity` varchar(10) NOT NULL,
  `OrganizationalStructure_Member_Eligibility` varchar(1000) DEFAULT NULL,
  `OrganizationalStructure_Program` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cooperative_organizationalstructure`
--

INSERT INTO `cooperative_organizationalstructure` (`Cooperative_Identity`, `OrganizationalStructure_Member_Eligibility`, `OrganizationalStructure_Program`) VALUES
('COOP-1', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_organizationalstructure_committee`
--

CREATE TABLE `cooperative_organizationalstructure_committee` (
  `Cooperative_Identity` varchar(10) NOT NULL,
  `Committee_Identity` varchar(30) NOT NULL,
  `Committee_Name` varchar(50) DEFAULT NULL,
  `Committee_Description` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_organizationalstructure_committee_member`
--

CREATE TABLE `cooperative_organizationalstructure_committee_member` (
  `Committee_Identity` varchar(30) NOT NULL,
  `Member_Identity` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_organizationalstructure_member`
--

CREATE TABLE `cooperative_organizationalstructure_member` (
  `Cooperative_Identity` varchar(10) NOT NULL,
  `Member_Identity` varchar(10) NOT NULL,
  `Member_Position` varchar(20) DEFAULT NULL,
  `Member_Appointment_Status` varchar(10) DEFAULT NULL,
  `Member_Eligibility` varchar(500) DEFAULT NULL,
  `Member_Compensation` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_organizationalstructure_member_chart`
--

CREATE TABLE `cooperative_organizationalstructure_member_chart` (
  `Cooperative_Identity` varchar(10) NOT NULL,
  `User_Identity` varchar(10) DEFAULT NULL,
  `User_Identity_Parent` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_organizationalstructure_member_position`
--

CREATE TABLE `cooperative_organizationalstructure_member_position` (
  `Cooperative_Identity` varchar(10) NOT NULL,
  `Position_Identity` varchar(20) NOT NULL,
  `Position_Name` varchar(20) DEFAULT NULL,
  `Position_Description` varchar(100) DEFAULT NULL,
  `Position_Compensation` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_sharecapital`
--

CREATE TABLE `cooperative_sharecapital` (
  `Cooperative_Identity` varchar(10) NOT NULL,
  `ShareCapital_Authorized` varchar(10) DEFAULT NULL,
  `ShareCapital_Issued` varchar(10) DEFAULT NULL,
  `ShareCapital_Unissued` varchar(10) DEFAULT NULL,
  `ShareCapital_Subscribed` varchar(10) DEFAULT NULL,
  `ShareCapital_Unsubscribed` varchar(10) DEFAULT NULL,
  `ShareCapital_Called-Up` varchar(10) DEFAULT NULL,
  `ShareCapital_Uncalled` varchar(10) DEFAULT NULL,
  `ShareCapital_Paid-Up` varchar(10) DEFAULT NULL,
  `ShareCapital_Unpaid` varchar(10) DEFAULT NULL,
  `ShareCapital_Reserve` varchar(10) DEFAULT NULL,
  `ShareCapital_Par_Value` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cooperative_sharecapital`
--

INSERT INTO `cooperative_sharecapital` (`Cooperative_Identity`, `ShareCapital_Authorized`, `ShareCapital_Issued`, `ShareCapital_Unissued`, `ShareCapital_Subscribed`, `ShareCapital_Unsubscribed`, `ShareCapital_Called-Up`, `ShareCapital_Uncalled`, `ShareCapital_Paid-Up`, `ShareCapital_Unpaid`, `ShareCapital_Reserve`, `ShareCapital_Par_Value`) VALUES
('COOP-1', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_technicalaspect`
--

CREATE TABLE `cooperative_technicalaspect` (
  `Cooperative_Identity` varchar(10) NOT NULL,
  `TechnicalAspect_Equipment` varchar(1000) DEFAULT NULL,
  `TechnicalAspect_Machinery` varchar(1000) DEFAULT NULL,
  `TechnicalAspect_Facility` varchar(1000) DEFAULT NULL,
  `TechnicalAspect_Procurement_Mode` varchar(10) DEFAULT NULL,
  `TechnicalAspect_Operator_Background` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cooperative_technicalaspect`
--

INSERT INTO `cooperative_technicalaspect` (`Cooperative_Identity`, `TechnicalAspect_Equipment`, `TechnicalAspect_Machinery`, `TechnicalAspect_Facility`, `TechnicalAspect_Procurement_Mode`, `TechnicalAspect_Operator_Background`) VALUES
('COOP-1', NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `cooperative_type`
--

CREATE TABLE `cooperative_type` (
  `Type_Identity` varchar(20) NOT NULL,
  `Type_Name` varchar(20) DEFAULT NULL,
  `Type_Description` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cooperative_type`
--

INSERT INTO `cooperative_type` (`Type_Identity`, `Type_Name`, `Type_Description`) VALUES
('COOP-TYP-1', 'Advocacy', 'Advocacy'),
('COOP-TYP-11', 'Credit', 'Credit'),
('COOP-TYP-13', 'Credit Surety Fund', 'Credit Surety Fund'),
('COOP-TYP-15', 'Dairy', 'Dairy'),
('COOP-TYP-17', 'Education', 'Education'),
('COOP-TYP-19', 'Electric', 'Electric'),
('COOP-TYP-21', 'Federation', 'Federation'),
('COOP-TYP-23', 'Financial Service', 'Financial Service'),
('COOP-TYP-25', 'Fishermen', 'Fishermen'),
('COOP-TYP-27', 'Health Service', 'Health Service'),
('COOP-TYP-29', 'Housing', 'Housing'),
('COOP-TYP-3', 'Agrarian Reform', 'Agrarian Reform'),
('COOP-TYP-31', 'Insurance', 'Insurance'),
('COOP-TYP-33', 'Labor Service', 'Labor Service'),
('COOP-TYP-35', 'Marketing', 'Marketing'),
('COOP-TYP-37', 'Producers', 'Producers'),
('COOP-TYP-39', 'Professional', 'Professional'),
('COOP-TYP-41', 'Service', 'Service'),
('COOP-TYP-43', 'Small Scale Mining', 'Small Scale Mining'),
('COOP-TYP-45', 'Transport', 'Transport'),
('COOP-TYP-47', 'Union', 'Union'),
('COOP-TYP-49', 'Water Service', 'Water Service'),
('COOP-TYP-5', 'Agriculture', 'Agriculture'),
('COOP-TYP-51', 'Workers', 'Workers'),
('COOP-TYP-7', 'Consumers', 'Consumers'),
('COOP-TYP-9', 'Cooperative Bank', 'Cooperative Bank');

-- --------------------------------------------------------

--
-- Table structure for table `counter`
--

CREATE TABLE `counter` (
  `Counter_Identity` varchar(30) NOT NULL,
  `Counter_Code` varchar(30) DEFAULT NULL,
  `Counter_Count` varchar(10) DEFAULT NULL,
  `Counter_Description` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `counter`
--

INSERT INTO `counter` (`Counter_Identity`, `Counter_Code`, `Counter_Count`, `Counter_Description`) VALUES
('CNTR-COOP', 'COOP', '2', 'Counter for Cooperative Identity'),
('CNTR-COOP-CAT', 'COOP-CAT', '7', 'Counter for Cooperative Category Identity'),
('CNTR-COOP-CB', 'COOP-CB', '5', 'Counter for Cooperative Common Bond Identity'),
('CNTR-COOP-OA', 'COOP-OA', '6', 'Counter for Cooperative Operation Area Identity'),
('CNTR-COOP-TYP', 'COOP-TYP', '53', 'Counter for Cooperative Type Identity'),
('CNTR-GNDR', 'USR-GNDR', '3', 'Counter for User Identity'),
('CNTR-PH-ORG', 'PH-ORG', '1', 'Counter for Philippines Organization Identity'),
('CNTR-PH-RGN', 'PH-RGN', '3', 'Counter for Philippines Region Identity'),
('CNTR-PH-RGN-PROV', 'PH-RGN-PROV', '3', 'Counter for Philippines Region Province Identity'),
('CNTR-PH-RGN-PROV-LOC', 'PH-RGN-PROV-LOC', '42', 'Counter for Philippines Region Province Locality Identity'),
('CNTR-USR', 'USR', '5', 'Counter for User Identity'),
('CNTR-USR-CFMTN', 'USR-CFMTN', '4', 'Counter for User Confirmation Identity'),
('CNTR-USR-LG', 'USR-LG', '52', 'Counter for User Log Identity');

-- --------------------------------------------------------

--
-- Table structure for table `philippines_organization`
--

CREATE TABLE `philippines_organization` (
  `Organization_Identity` varchar(10) NOT NULL,
  `Organization_Name` varchar(50) DEFAULT NULL,
  `Organization_Abbreviation` varchar(10) DEFAULT NULL,
  `Organization_Description` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `philippines_region`
--

CREATE TABLE `philippines_region` (
  `Region_Identity` varchar(20) NOT NULL,
  `Region_Name` varchar(30) DEFAULT NULL,
  `Region_Description` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `philippines_region`
--

INSERT INTO `philippines_region` (`Region_Identity`, `Region_Name`, `Region_Description`) VALUES
('PH-RGN-1', 'National Capital Region (NCR)', NULL),
('PH-RGN-2', 'Ilocos Region (Region I)', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `philippines_region_province`
--

CREATE TABLE `philippines_region_province` (
  `Province_Identity` varchar(20) NOT NULL,
  `Province_Name` varchar(30) DEFAULT NULL,
  `Province_Region` varchar(20) DEFAULT NULL,
  `Province_Description` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `philippines_region_province`
--

INSERT INTO `philippines_region_province` (`Province_Identity`, `Province_Name`, `Province_Region`, `Province_Description`) VALUES
('PH-RGN-PROV-1', 'Ilocos Norte', 'PH-RGN-2', NULL),
('PH-RGN-PROV-2', 'Ilocos Sur', 'PH-RGN-2', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `philippines_region_province_locality`
--

CREATE TABLE `philippines_region_province_locality` (
  `Locality_Identity` varchar(30) NOT NULL,
  `Locality_Name` varchar(30) DEFAULT NULL,
  `Locality_Region` varchar(20) DEFAULT NULL,
  `Locality_Province` varchar(20) DEFAULT NULL,
  `Locality_Description` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `philippines_region_province_locality`
--

INSERT INTO `philippines_region_province_locality` (`Locality_Identity`, `Locality_Name`, `Locality_Region`, `Locality_Province`, `Locality_Description`) VALUES
('PH-RGN-PROV-LOC-1', 'Manila', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-10', 'Valenzuela', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-11', 'Las Piñas', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-12', 'Makati', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-13', 'Muntinlupa', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-14', 'Parañaque', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-15', 'Pasay', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-16', 'Pateros', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-17', 'Taguig', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-18', 'Adams', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-19', 'Bacarra', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-2', 'Mandaluyong', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-20', 'Badoc', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-21', 'Bangui', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-22', 'Banna', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-23', 'Batac', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-24', 'Burgos', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-25', 'Carasi', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-26', 'Currimao', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-27', 'Dingras', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-28', 'Dumalneg', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-29', 'Laoag', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-3', 'Marikina', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-30', 'Marcos', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-31', 'Nueva Era', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-32', 'Pagudpud', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-33', 'Paoay', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-34', 'Pasuquin', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-35', 'Piddig', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-36', 'Pinili', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-37', 'San Nicolas', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-38', 'Sarrat', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-39', 'Solsona', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-4', 'Pasig', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-40', 'Vintar', 'PH-RGN-2', 'PH-RGN-PROV-1', NULL),
('PH-RGN-PROV-LOC-41', 'Alilem', 'PH-RGN-2', 'PH-RGN-PROV-2', NULL),
('PH-RGN-PROV-LOC-5', 'Quezon City', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-6', 'San Juan', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-7', 'Caloocan', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-8', 'Malabon', 'PH-RGN-1', '', NULL),
('PH-RGN-PROV-LOC-9', 'Navotas', 'PH-RGN-1', '', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `user_confirmation`
--

CREATE TABLE `user_confirmation` (
  `User_Identity` varchar(10) NOT NULL,
  `Confirmation_Identity` varchar(20) NOT NULL,
  `Confirmation_Code` varchar(20) NOT NULL,
  `Confirmation_Status` varchar(10) DEFAULT NULL,
  `Confirmation_Inserted_DateTime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_confirmation`
--

INSERT INTO `user_confirmation` (`User_Identity`, `Confirmation_Identity`, `Confirmation_Code`, `Confirmation_Status`, `Confirmation_Inserted_DateTime`) VALUES
('USR-1', 'USR-CFMTN-1', 'RQARMX4YVE', 'Used', '2020-07-07 00:31:16'),
('USR-2', 'USR-CFMTN-2', '3OK6DYRJNP', 'Used', '2020-07-13 14:10:10'),
('USR-4', 'USR-CFMTN-3', 'V5YLAVJ9PB', 'Pending', '2020-07-13 14:43:48');

-- --------------------------------------------------------

--
-- Table structure for table `user_credential`
--

CREATE TABLE `user_credential` (
  `User_Identity` varchar(20) NOT NULL,
  `User_Name` varchar(20) DEFAULT NULL,
  `User_Password` varchar(20) DEFAULT NULL,
  `User_Type` varchar(20) DEFAULT NULL,
  `User_Privilege` varchar(100) DEFAULT NULL,
  `User_State` varchar(20) DEFAULT NULL,
  `User_Ethereum_Address` varchar(100) DEFAULT NULL,
  `User_Ethereum_Key` varchar(100) DEFAULT NULL,
  `User_Inserted_By` varchar(20) DEFAULT NULL,
  `User_Inserted_DateTime` datetime DEFAULT NULL,
  `User_Updated_By` varchar(20) DEFAULT NULL,
  `User_Updated_DateTime` datetime DEFAULT NULL,
  `User_Deleted_By` varchar(20) DEFAULT NULL,
  `User_Deleted_DateTime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_credential`
--

INSERT INTO `user_credential` (`User_Identity`, `User_Name`, `User_Password`, `User_Type`, `User_Privilege`, `User_State`, `User_Ethereum_Address`, `User_Ethereum_Key`, `User_Inserted_By`, `User_Inserted_DateTime`, `User_Updated_By`, `User_Updated_DateTime`, `User_Deleted_By`, `User_Deleted_DateTime`) VALUES
('USR-1', 'qwe', 'qwe', 'Cooperator', '[\"Cooperator\"]', 'Confirmed', '0x9B89395941Bd700bBFCb64ED010Ef8b2d79B9C42', '0x1ba9d542812c70d80d4dac0983c165cb75c09fc74b893ba17ef165448977d2aa', 'USR-1', '2020-07-07 00:30:39', 'USR-1', '2020-07-07 00:31:37', NULL, NULL),
('USR-2', 'asd', 'asd', 'Cooperator', '[\"Cooperator\"]', 'Confirmed', '0xE9b3f38b04255F8508715e74ff72E2242889Fd75', '0x6fdd4967269cb1112bbe1a898d795d01a7d681c8805a241beee4881c30561d70', 'USR-2', '2020-07-13 14:10:03', 'USR-2', '2020-07-13 14:10:33', NULL, NULL),
('USR-3', 'asd', 'dqwd', 'Cooperator', '[\"Cooperator\"]', 'Unconfirmed', '0xcD7404599cA7D0F4B3eB199d8bce0f156BdE6460', '0xdf5bd17e394825549fc1591ea6eaf9f4c7cd4fef2fbfb4b0c622f0920513c75a', 'USR-3', '2020-07-13 14:43:10', NULL, NULL, NULL, NULL),
('USR-4', 'zzza', 'zzza', 'Cooperator', '[\"Cooperator\"]', 'Unconfirmed', '0x34AbEFdDe8f8152064526B339feA46F0cCe7d5BA', '0x98a98cc73a157b78859159c5d985b0f50805efdc55f490e1d4b14aef7e60ec45', 'USR-4', '2020-07-13 14:43:33', NULL, NULL, NULL, NULL),
('USR-Admin', 'admin', 'admin', 'Admin', '[\"Admin\"]', 'Confirmed', '0xBD81E6Cffeb07Ff83B06C09d6d6A7c55daE4e5Cb', '0x97bcd47c9ac46bc8ee3f8bd498bd1f828216121f1337b2e6395cc4f5e2001d4d', 'USR-Admin', '2020-07-06 23:47:30', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `user_log`
--

CREATE TABLE `user_log` (
  `User_Identity` varchar(10) NOT NULL,
  `Log_Identity` varchar(10) NOT NULL,
  `Log_Action` varchar(50) DEFAULT NULL,
  `Log_Type` varchar(50) DEFAULT NULL,
  `Log_Information` varchar(3000) DEFAULT NULL,
  `Log_Inserted_By` varchar(20) DEFAULT NULL,
  `Log_Inserted_DateTime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_log`
--

INSERT INTO `user_log` (`User_Identity`, `Log_Identity`, `Log_Action`, `Log_Type`, `Log_Information`, `Log_Inserted_By`, `Log_Inserted_DateTime`) VALUES
('USR-2', 'USR-LG-50', 'Purchased Etherium', 'Etherium : Add', '{\"create_time\":\"2020-07-13T08:39:18Z\",\"update_time\":\"2020-07-13T08:41:05Z\",\"id\":\"5L188821W13453331\",\"intent\":\"CAPTURE\",\"status\":\"COMPLETED\",\"payer\":{\"email_address\":\"COOP_Business_1@ub.ecims.com\",\"payer_id\":\"E9GXTK6B4N4Z2\",\"address\":{\"country_code\":\"US\"},\"name\":{\"given_name\":\"Cooperative\",\"surname\":\"Cooperative\"}},\"purchase_units\":[{\"reference_id\":\"default\",\"amount\":{\"value\":\"11769.43\",\"currency_code\":\"PHP\"},\"payee\":{\"email_address\":\"UB_ECIMS@ub.ecims.com\",\"merchant_id\":\"854Q259768BG2\"},\"shipping\":{\"name\":{\"full_name\":\"Cooperative Cooperative\"},\"address\":{\"address_line_1\":\"1 Main St\",\"admin_area_2\":\"San Jose\",\"admin_area_1\":\"CA\",\"postal_code\":\"95131\",\"country_code\":\"US\"}},\"payments\":{\"captures\":[{\"status\":\"PENDING\",\"id\":\"34N67674CX684231D\",\"final_capture\":true,\"create_time\":\"2020-07-13T08:41:05Z\",\"update_time\":\"2020-07-13T08:41:05Z\",\"amount\":{\"value\":\"11769.43\",\"currency_code\":\"PHP\"},\"seller_protection\":{\"status\":\"NOT_ELIGIBLE\"},\"status_details\":{\"reason\":\"PENDING_REVIEW\"},\"links\":[{\"href\":\"https://api.sandbox.paypal.com/v2/payments/captures/34N67674CX684231D\",\"rel\":\"self\",\"method\":\"GET\",\"title\":\"GET\"},{\"href\":\"https://api.sandbox.paypal.com/v2/payments/captures/34N67674CX684231D/refund\",\"rel\":\"refund\",\"method\":\"POST\",\"title\":\"POST\"},{\"href\":\"https://api.sandbox.paypal.com/v2/checkout/orders/5L188821W13453331\",\"rel\":\"up\",\"method\":\"GET\",\"title\":\"GET\"}]}]}}],\"links\":[{\"href\":\"https://api.sandbox.paypal.com/v2/checkout/orders/5L188821W13453331\",\"rel\":\"self\",\"method\":\"GET\",\"title\":\"GET\"}]}', 'USR-2', '2020-07-13 16:41:06'),
('USR-2', 'USR-LG-51', 'Withdrew Etherium', 'Etherium : Remove', '{\"batch_header\":{\"payout_batch_id\":\"U7L6R5LJP6AA8\",\"batch_status\":\"PENDING\",\"time_created\":\"2020-07-13T08:42:24Z\",\"sender_batch_header\":{\"sender_batch_id\":\"wtPccUfRFj\",\"email_subject\":\"You have a payout!\",\"email_message\":\"You have received a payout! Thanks for using our service!\"},\"funding_source\":\"BALANCE\",\"amount\":{\"currency\":\"PHP\",\"value\":\"23538.86\"},\"fees\":{\"currency\":\"PHP\",\"value\":\"12.50\"}},\"items\":[{\"payout_item_id\":\"PUY5P7THKN5ZJ\",\"transaction_status\":\"PENDING\",\"payout_item_fee\":{\"currency\":\"PHP\",\"value\":\"12.50\"},\"payout_batch_id\":\"U7L6R5LJP6AA8\",\"payout_item\":{\"recipient_type\":\"EMAIL\",\"amount\":{\"currency\":\"PHP\",\"value\":\"23538.86\"},\"note\":\"Thank You!!!\",\"receiver\":\"COOP_Business_1@ub.ecims.com\",\"recipient_wallet\":\"PAYPAL\"},\"links\":[{\"href\":\"https://api.sandbox.paypal.com/v1/payments/payouts-item/PUY5P7THKN5ZJ\",\"rel\":\"item\",\"method\":\"GET\",\"encType\":\"application/json\"}]}],\"links\":[{\"href\":\"https://api.sandbox.paypal.com/v1/payments/payouts/U7L6R5LJP6AA8?page_size=1000&page=1\",\"rel\":\"self\",\"method\":\"GET\",\"encType\":\"application/json\"}]}', 'USR-2', '2020-07-13 16:42:24');

-- --------------------------------------------------------

--
-- Table structure for table `user_personal`
--

CREATE TABLE `user_personal` (
  `User_Identity` varchar(20) NOT NULL,
  `User_Firstname` varchar(20) DEFAULT NULL,
  `User_Middlename` varchar(20) DEFAULT NULL,
  `User_Lastname` varchar(20) DEFAULT NULL,
  `User_Gender` varchar(20) DEFAULT NULL,
  `User_Citizenship` varchar(20) DEFAULT NULL,
  `User_Birth_Place` varchar(30) DEFAULT NULL,
  `User_Birth_DateTime` datetime DEFAULT NULL,
  `User_Address_Email` varchar(50) DEFAULT NULL,
  `User_Address_Home` varchar(100) DEFAULT NULL,
  `User_Contact_TelephoneNumber_Mobile` varchar(20) DEFAULT NULL,
  `User_Contact_TelephoneNumber_Landline` varchar(20) DEFAULT NULL,
  `User_Image_Path` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_personal`
--

INSERT INTO `user_personal` (`User_Identity`, `User_Firstname`, `User_Middlename`, `User_Lastname`, `User_Gender`, `User_Citizenship`, `User_Birth_Place`, `User_Birth_DateTime`, `User_Address_Email`, `User_Address_Home`, `User_Contact_TelephoneNumber_Mobile`, `User_Contact_TelephoneNumber_Landline`, `User_Image_Path`) VALUES
('USR-1', 'qwe', 'qwe', 'qwe', '', '', '', '0000-00-00 00:00:00', 'qwe', '', 'qwe', 'qwe', 'Data/User/Image/USR-1.jpeg'),
('USR-2', 'asd', 'asd', 'asd', '', '', '', '0000-00-00 00:00:00', 'asdasd', '', 'asdasda', 'sdasdasdad', 'Data/User/Image/USR-2.jpeg'),
('USR-3', 'qwdq', 'wdqw', 'dqwd', '', '', '', '0000-00-00 00:00:00', 'qwdqw', '', 'dqwd', 'qwd', ''),
('USR-4', 'zzza', 'zzza', 'zzza', '', '', '', '0000-00-00 00:00:00', 'zzza', '', 'zzza', 'zzza', ''),
('USR-Admin', 'Rafael', 'Nobleza', 'Masallo', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `user_personal_employment`
--

CREATE TABLE `user_personal_employment` (
  `User_Identity` varchar(20) NOT NULL,
  `Employment_Company_Name` varchar(50) DEFAULT NULL,
  `Employment_Business_Type` varchar(20) DEFAULT NULL,
  `Employment_Business_Form` varchar(20) DEFAULT NULL,
  `Employment_Business_Address` varchar(100) DEFAULT NULL,
  `Employment_Employer_Firstname` varchar(20) DEFAULT NULL,
  `Employment_Employer_Middlename` varchar(20) DEFAULT NULL,
  `Employment_Employer_Lastname` varchar(20) DEFAULT NULL,
  `Employment_Business_Contact_Number` varchar(20) DEFAULT NULL,
  `Employment_Business_Contact_Number_Local` varchar(20) DEFAULT NULL,
  `Employment_Tenure_Year` varchar(10) DEFAULT NULL,
  `Employment_Appointment_Status` varchar(20) DEFAULT NULL,
  `Employment_Position_Title` varchar(20) DEFAULT NULL,
  `Employment_Position_Level` varchar(20) DEFAULT NULL,
  `Employment_Pay_Period` varchar(20) DEFAULT NULL,
  `Employment_Hired_DateTime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_personal_employment`
--

INSERT INTO `user_personal_employment` (`User_Identity`, `Employment_Company_Name`, `Employment_Business_Type`, `Employment_Business_Form`, `Employment_Business_Address`, `Employment_Employer_Firstname`, `Employment_Employer_Middlename`, `Employment_Employer_Lastname`, `Employment_Business_Contact_Number`, `Employment_Business_Contact_Number_Local`, `Employment_Tenure_Year`, `Employment_Appointment_Status`, `Employment_Position_Title`, `Employment_Position_Level`, `Employment_Pay_Period`, `Employment_Hired_DateTime`) VALUES
('USR-1', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '0000-00-00 00:00:00'),
('USR-2', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '0000-00-00 00:00:00'),
('USR-3', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '0000-00-00 00:00:00'),
('USR-4', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '0000-00-00 00:00:00'),
('USR-Admin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `user_personal_gender`
--

CREATE TABLE `user_personal_gender` (
  `Gender_Identity` varchar(10) DEFAULT NULL,
  `Gender_Name` varchar(20) DEFAULT NULL,
  `Gender_Description` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_personal_gender`
--

INSERT INTO `user_personal_gender` (`Gender_Identity`, `Gender_Name`, `Gender_Description`) VALUES
('USR-GNDR-1', 'Male', 'Male'),
('USR-GNDR-2', 'Female', 'Female');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cooperative`
--
ALTER TABLE `cooperative`
  ADD PRIMARY KEY (`Cooperative_Identity`);

--
-- Indexes for table `cooperative_category`
--
ALTER TABLE `cooperative_category`
  ADD PRIMARY KEY (`Category_Identity`);

--
-- Indexes for table `cooperative_commonbond`
--
ALTER TABLE `cooperative_commonbond`
  ADD PRIMARY KEY (`CommonBond_Identity`);

--
-- Indexes for table `cooperative_economicaspect`
--
ALTER TABLE `cooperative_economicaspect`
  ADD PRIMARY KEY (`Cooperative_Identity`);

--
-- Indexes for table `cooperative_economicsurvey`
--
ALTER TABLE `cooperative_economicsurvey`
  ADD PRIMARY KEY (`Cooperative_Identity`);

--
-- Indexes for table `cooperative_financialaspect`
--
ALTER TABLE `cooperative_financialaspect`
  ADD PRIMARY KEY (`Cooperative_Identity`);

--
-- Indexes for table `cooperative_operationarea`
--
ALTER TABLE `cooperative_operationarea`
  ADD PRIMARY KEY (`OperationArea_Identity`);

--
-- Indexes for table `cooperative_organizationalstructure`
--
ALTER TABLE `cooperative_organizationalstructure`
  ADD PRIMARY KEY (`Cooperative_Identity`);

--
-- Indexes for table `cooperative_organizationalstructure_committee`
--
ALTER TABLE `cooperative_organizationalstructure_committee`
  ADD PRIMARY KEY (`Cooperative_Identity`,`Committee_Identity`);

--
-- Indexes for table `cooperative_organizationalstructure_committee_member`
--
ALTER TABLE `cooperative_organizationalstructure_committee_member`
  ADD PRIMARY KEY (`Committee_Identity`,`Member_Identity`);

--
-- Indexes for table `cooperative_organizationalstructure_member`
--
ALTER TABLE `cooperative_organizationalstructure_member`
  ADD PRIMARY KEY (`Cooperative_Identity`,`Member_Identity`);

--
-- Indexes for table `cooperative_organizationalstructure_member_chart`
--
ALTER TABLE `cooperative_organizationalstructure_member_chart`
  ADD PRIMARY KEY (`Cooperative_Identity`);

--
-- Indexes for table `cooperative_organizationalstructure_member_position`
--
ALTER TABLE `cooperative_organizationalstructure_member_position`
  ADD PRIMARY KEY (`Cooperative_Identity`,`Position_Identity`);

--
-- Indexes for table `cooperative_sharecapital`
--
ALTER TABLE `cooperative_sharecapital`
  ADD PRIMARY KEY (`Cooperative_Identity`);

--
-- Indexes for table `cooperative_technicalaspect`
--
ALTER TABLE `cooperative_technicalaspect`
  ADD PRIMARY KEY (`Cooperative_Identity`);

--
-- Indexes for table `cooperative_type`
--
ALTER TABLE `cooperative_type`
  ADD PRIMARY KEY (`Type_Identity`);

--
-- Indexes for table `counter`
--
ALTER TABLE `counter`
  ADD PRIMARY KEY (`Counter_Identity`);

--
-- Indexes for table `philippines_organization`
--
ALTER TABLE `philippines_organization`
  ADD PRIMARY KEY (`Organization_Identity`);

--
-- Indexes for table `philippines_region`
--
ALTER TABLE `philippines_region`
  ADD PRIMARY KEY (`Region_Identity`);

--
-- Indexes for table `philippines_region_province`
--
ALTER TABLE `philippines_region_province`
  ADD PRIMARY KEY (`Province_Identity`);

--
-- Indexes for table `philippines_region_province_locality`
--
ALTER TABLE `philippines_region_province_locality`
  ADD PRIMARY KEY (`Locality_Identity`);

--
-- Indexes for table `user_confirmation`
--
ALTER TABLE `user_confirmation`
  ADD PRIMARY KEY (`User_Identity`,`Confirmation_Identity`,`Confirmation_Code`);

--
-- Indexes for table `user_credential`
--
ALTER TABLE `user_credential`
  ADD PRIMARY KEY (`User_Identity`);

--
-- Indexes for table `user_log`
--
ALTER TABLE `user_log`
  ADD PRIMARY KEY (`User_Identity`,`Log_Identity`);

--
-- Indexes for table `user_personal`
--
ALTER TABLE `user_personal`
  ADD PRIMARY KEY (`User_Identity`);

--
-- Indexes for table `user_personal_employment`
--
ALTER TABLE `user_personal_employment`
  ADD PRIMARY KEY (`User_Identity`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
