-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 11, 2018 at 11:03 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbpetron2`
--
CREATE DATABASE IF NOT EXISTS `dbpetron2` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `dbpetron2`;

-- --------------------------------------------------------

--
-- Table structure for table `tblcategory`
--

CREATE TABLE `tblcategory` (
  `category_id` int(99) NOT NULL,
  `category_name` varchar(99) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcategory`
--

INSERT INTO `tblcategory` (`category_id`, `category_name`) VALUES
(1, 'Ultron Gasoline Engine Oils'),
(2, 'REV-X DIESEL ENGINE OILS'),
(3, 'PETRON SPRINT 4T MOTORCYCLE OILS');

-- --------------------------------------------------------

--
-- Table structure for table `tblcustomer`
--

CREATE TABLE `tblcustomer` (
  `customerid` varchar(99) NOT NULL,
  `customer_name` varchar(99) NOT NULL,
  `address` text NOT NULL,
  `contact_number` varchar(99) NOT NULL,
  `company_affiliation` varchar(99) NOT NULL,
  `company_position` varchar(99) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcustomer`
--

INSERT INTO `tblcustomer` (`customerid`, `customer_name`, `address`, `contact_number`, `company_affiliation`, `company_position`) VALUES
('CUS-180302021622', 'Andro Luna', 'Villanueva, Misamis Oriental', '0919823734', 'n/a', 'Manager'),
('CUS-180317123620', 'Bryan Roxell Balistoy', 'Macasandig, Cagayan de Oro City', '092362478237', 'n/a', 'Product Manager'),
('CUS-180317123742', 'Gerald Ua-o', 'Bugo Trinitas, Cagayan de Oro City', '0983765472', 'n/a', 'Chairman'),
('CUS-180317123902', 'Ryan Christopher Malalay', 'Buena Oro, Cagayan de Oro City', '0983654762', 'n/a', 'Project Manager');

-- --------------------------------------------------------

--
-- Table structure for table `tbldownpaymentorder`
--

CREATE TABLE `tbldownpaymentorder` (
  `transid` varchar(99) NOT NULL,
  `customerid` varchar(99) NOT NULL,
  `totalamount` double NOT NULL,
  `balance` double NOT NULL,
  `date_order` varchar(99) NOT NULL,
  `bill_remark` varchar(99) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbldownpaymentorder`
--

INSERT INTO `tbldownpaymentorder` (`transid`, `customerid`, `totalamount`, `balance`, `date_order`, `bill_remark`) VALUES
('TRANS020402180322', 'CUS-180317123620', 7270, 0, '2018-03-22', 'Paid'),
('TRANS231811180406', 'CUS-180302021622', 11100, 8600, '2018-04-06', 'Unpaid'),
('TRANS325512180322', 'CUS-180317123620', 11765, 0, '2018-03-22', 'Paid'),
('TRANS350802180320', 'CUS-180302021622', 10155, 0, '2018-03-20', 'Paid'),
('TRANS415001180320', 'CUS-180317123742', 12930, 0, '2018-03-20', 'Paid'),
('TRANS472101180322', 'CUS-180302021622', 17645, 12500, '2018-03-22', 'Unpaid'),
('TRANS545912180322', 'CUS-180317123742', 20310, 0, '2018-03-22', 'Paid');

-- --------------------------------------------------------

--
-- Table structure for table `tblfullpaymentorder`
--

CREATE TABLE `tblfullpaymentorder` (
  `transid` varchar(99) NOT NULL,
  `customerid` varchar(99) NOT NULL,
  `totalamount` double NOT NULL,
  `amt_rcvd` double NOT NULL,
  `amt_change` double NOT NULL,
  `date_order` varchar(99) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblfullpaymentorder`
--

INSERT INTO `tblfullpaymentorder` (`transid`, `customerid`, `totalamount`, `amt_rcvd`, `amt_change`, `date_order`) VALUES
('TRANS001601180320', 'CUS-180302021622', 7270, 7300, 30, '2018-03-20'),
('TRANS120909180319', 'CUS-180317123902', 2775, 3000, 225, '2018-03-19'),
('TRANS254408180319', 'CUS-180317123620', 5726, 5726, 0, '2018-03-19'),
('TRANS454308180319', 'CUS-180302021622', 2697, 3000, 303, '2018-03-19');

-- --------------------------------------------------------

--
-- Table structure for table `tblorderlogs`
--

CREATE TABLE `tblorderlogs` (
  `transid` varchar(99) NOT NULL,
  `customerid` varchar(99) NOT NULL,
  `productid` varchar(99) NOT NULL,
  `quantity` int(5) NOT NULL,
  `unit_price` double NOT NULL,
  `total_price` double NOT NULL,
  `date_order` varchar(99) NOT NULL,
  `tracecode` varchar(99) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblorderlogs`
--

INSERT INTO `tblorderlogs` (`transid`, `customerid`, `productid`, `quantity`, `unit_price`, `total_price`, `date_order`, `tracecode`) VALUES
('TRANS454308180319', 'CUS-180302021622', 'PR-1519942677', 3, 899, 2697, '2018-03-19', 'TRACE180319084345'),
('TRANS254408180319', 'CUS-180317123620', 'PR-1519939468', 2, 555, 1110, '2018-03-19', 'TRACE180319084425'),
('TRANS254408180319', 'CUS-180317123620', 'PR-1519955594', 8, 577, 4616, '2018-03-19', 'TRACE180319084709'),
('TRANS120909180319', 'CUS-180317123902', 'PR-1519939468', 5, 555, 2775, '2018-03-19', 'TRACE180319090912'),
('TRANS001601180320', 'CUS-180302021622', 'PR-1519939468', 5, 555, 2775, '2018-03-20', 'TRACE180320011600'),
('TRANS001601180320', 'CUS-180302021622', 'PR-1519942677', 5, 899, 4495, '2018-03-20', 'TRACE180320011622'),
('TRANS415001180320', 'CUS-180317123742', 'PR-1519942677', 5, 899, 4495, '2018-03-20', 'TRACE180320015041'),
('TRANS415001180320', 'CUS-180317123742', 'PR-1519955594', 5, 577, 2885, '2018-03-20', 'TRACE180320015100'),
('TRANS415001180320', 'CUS-180317123742', 'PR-1519939468', 10, 555, 5550, '2018-03-20', 'TRACE180320015114'),
('TRANS350802180320', 'CUS-180302021622', 'PR-1519942677', 5, 899, 4495, '2018-03-20', 'TRACE180320020835'),
('TRANS350802180320', 'CUS-180302021622', 'PR-1519939468', 5, 555, 2775, '2018-03-20', 'TRACE180320021025'),
('TRANS350802180320', 'CUS-180302021622', 'PR-1519955594', 5, 577, 2885, '2018-03-20', 'TRACE180320021034'),
('TRANS545912180322', 'CUS-180317123742', 'PR-1519939468', 10, 555, 5550, '2018-03-22', 'TRACE180322010004'),
('TRANS545912180322', 'CUS-180317123742', 'PR-1519955594', 10, 577, 5770, '2018-03-22', 'TRACE180322010012'),
('TRANS472101180322', 'CUS-180302021622', 'PR-1519942677', 10, 899, 8990, '2018-03-22', 'TRACE180322012147'),
('TRANS472101180322', 'CUS-180302021622', 'PR-1519955594', 15, 577, 8655, '2018-03-22', 'TRACE180322012157'),
('TRANS020402180322', 'CUS-180317123620', 'PR-1519942677', 5, 899, 4495, '2018-03-22', 'TRACE180322020402'),
('TRANS020402180322', 'CUS-180317123620', 'PR-1519939468', 5, 555, 2775, '2018-03-22', 'TRACE180322020414'),
('TRANS325512180322', 'CUS-180317123620', 'PR-1519942677', 10, 899, 8990, '2018-03-22', 'TRACE180322125532'),
('TRANS325512180322', 'CUS-180317123620', 'PR-1519939468', 5, 555, 2775, '2018-03-22', 'TRACE180322125544'),
('TRANS545912180322', 'CUS-180317123742', 'PR-1519942677', 10, 899, 8990, '2018-03-22', 'TRACE180322125954'),
('TRANS231811180406', 'CUS-180302021622', 'PR-1519939468', 20, 555, 11100, '2018-04-06', 'TRACE180406111823');

-- --------------------------------------------------------

--
-- Table structure for table `tblpayments`
--

CREATE TABLE `tblpayments` (
  `or_no` varchar(99) NOT NULL,
  `transid` varchar(99) NOT NULL,
  `totalamount` double NOT NULL,
  `payment` double NOT NULL,
  `balance` double NOT NULL,
  `date_payment` varchar(99) NOT NULL,
  `payment_remark` varchar(99) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblpayments`
--

INSERT INTO `tblpayments` (`or_no`, `transid`, `totalamount`, `payment`, `balance`, `date_payment`, `payment_remark`) VALUES
('182318110604', 'TRANS231811180406', 11100, 2000, 9100, '2018-04-06 11:18:59', 'Unpaid'),
('191418110604', 'TRANS231811180406', 11100, 500, 8600, '2018-04-06 11:19:39', 'Unpaid'),
('OR030218012203', 'TRANS545912180322', 20310, 1000, 19000, '2018-03-22', 'Unpaid'),
('OR040318022203DP', 'TRANS020402180322', 7270, 5000, 2270, '2018-03-22', 'Unpaid'),
('OR074918110604', 'TRANS472101180322', 17645, 400, 12500, '2018-04-06 11:09:10', 'Unpaid'),
('OR083518022003DP', 'TRANS350802180320', 10155, 500, 9655, '2018-03-20', 'Unpaid'),
('OR115018012203', 'TRANS545912180322', 20310, 1000, 18000, '2018-03-22', 'Unpaid'),
('OR122618012203', 'TRANS545912180322', 20310, 1000, 17000, '2018-03-22', 'Unpaid'),
('OR135818012203', 'TRANS545912180322', 20310, 1000, 16000, '2018-03-22', 'Unpaid'),
('OR165118012203', 'TRANS545912180322', 20310, 16000, 0, '2018-03-22', 'Paid'),
('OR175318012203', 'TRANS350802180320', 10155, 7845, 0, '2018-03-22', 'Paid'),
('OR195518082903', 'TRANS472101180322', 17645, 100, 12900, '2018-03-29 20:20:05', 'Unpaid'),
('OR214718012203DP', 'TRANS472101180322', 17645, 645, 17000, '2018-03-22 13:22:16', 'Unpaid'),
('OR222418012203', 'TRANS472101180322', 17645, 1000, 16000, '2018-03-22 13:22:39', 'Unpaid'),
('OR230518012203', 'TRANS472101180322', 17645, 1000, 15000, '2018-03-22 13:23:24', 'Unpaid'),
('OR232518012203', 'TRANS472101180322', 17645, 500, 14500, '2018-03-22 13:25:50', 'Unpaid'),
('OR255118012203', 'TRANS472101180322', 17645, 500, 14000, '2018-03-22 13:25:57', 'Unpaid'),
('OR264818012203', 'TRANS472101180322', 17645, 1000, 13000, '2018-03-22 13:27:09', 'Unpaid'),
('OR331618122203', 'TRANS350802180320', 10155, 55, 9600, '2018-03-22', 'Unpaid'),
('OR342718122203', 'TRANS350802180320', 10155, 600, 9000, '2018-03-22', 'Unpaid'),
('OR375318122203', 'TRANS350802180320', 10155, 100, 8900, '2018-03-22', 'Unpaid'),
('OR400618122203', 'TRANS350802180320', 10155, 500, 8400, '2018-03-22', 'Unpaid'),
('OR454918122203', 'TRANS350802180320', 10155, 200, 8200, '2018-03-22', 'Unpaid'),
('OR460518122203', 'TRANS020402180322', 7270, 2270, 0, '2018-03-22', 'Paid'),
('OR504118012003DP', 'TRANS415001180320', 12930, 1000, 11930, '2018-03-20', 'Unpaid'),
('OR523218122203', 'TRANS415001180320', 12930, 11930, 0, '2018-03-22', 'Paid'),
('OR530418122203', 'TRANS350802180320', 10155, 200, 8000, '2018-03-22', 'Unpaid'),
('OR553218122203DP', 'TRANS325512180322', 11765, 11000, 765, '2018-03-22', 'Unpaid'),
('OR564018122203', 'TRANS325512180322', 11765, 765, 0, '2018-03-22', 'Paid'),
('OR585818122203', 'TRANS350802180320', 10155, 155, 7845, '2018-03-22', 'Unpaid'),
('OR595418122203DP', 'TRANS545912180322', 20310, 310, 20000, '2018-03-22', 'Unpaid');

-- --------------------------------------------------------

--
-- Table structure for table `tblproduct`
--

CREATE TABLE `tblproduct` (
  `productid` varchar(99) NOT NULL,
  `product_name` varchar(99) NOT NULL,
  `description` text NOT NULL,
  `category_id` varchar(99) NOT NULL,
  `type_id` varchar(99) NOT NULL,
  `viscosity_id` varchar(99) NOT NULL,
  `volume` double NOT NULL,
  `unit_price` double NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblproduct`
--

INSERT INTO `tblproduct` (`productid`, `product_name`, `description`, `category_id`, `type_id`, `viscosity_id`, `volume`, `unit_price`) VALUES
('PR-1519939468', 'Ultron Fully Synthetic', 'n/a', '1', '1', '1', 250, 555),
('PR-1519942677', 'Ultron Synthetic Blend', 'n/a', '1', '2', '2', 305, 899),
('PR-1519955594', 'Ultron Multi-Grade', 'n/a', '1', '5', '3', 280, 577);

-- --------------------------------------------------------

--
-- Table structure for table `tblproduct_inv`
--

CREATE TABLE `tblproduct_inv` (
  `productid` varchar(99) NOT NULL,
  `no_of_stocks` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblproduct_inv`
--

INSERT INTO `tblproduct_inv` (`productid`, `no_of_stocks`) VALUES
('PR-1519942677', 84),
('PR-1519939468', 33),
('PR-1519955594', 55);

-- --------------------------------------------------------

--
-- Table structure for table `tblstockentry`
--

CREATE TABLE `tblstockentry` (
  `stock_entry_id` varchar(99) NOT NULL,
  `supplierid` varchar(99) NOT NULL,
  `date_stock_in` varchar(99) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstockentry`
--

INSERT INTO `tblstockentry` (`stock_entry_id`, `supplierid`, `date_stock_in`) VALUES
('SE-180304085841', 'SUP-594518302', '2018-03-04'),
('SE-180304090128', 'SUP-124618302', '2018-03-04'),
('SE-180304092307', 'SUP-594518302', '2018-03-04'),
('SE-180305122529', 'SUP-325418302', '2018-03-05'),
('SE-180305011831', 'SUP-124618302', '2018-03-05'),
('SE-180311105422', 'SUP-515318302', '2018-03-11'),
('SE-180317121051', 'SUP-325418302', '2018-03-17');

-- --------------------------------------------------------

--
-- Table structure for table `tblstockentrylogs`
--

CREATE TABLE `tblstockentrylogs` (
  `stock_entry_id` varchar(99) NOT NULL,
  `productid` varchar(99) NOT NULL,
  `stock_added` int(11) NOT NULL,
  `date_stock_logs` varchar(99) NOT NULL,
  `tracecode` varchar(99) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstockentrylogs`
--

INSERT INTO `tblstockentrylogs` (`stock_entry_id`, `productid`, `stock_added`, `date_stock_logs`, `tracecode`) VALUES
('SE-180311105422', 'PR-1519942677', 55, '2018-03-11', 'TR-542218031110'),
('SE-180305011831', 'PR-1519942677', 10, '2018-03-05', 'TR-183118030501'),
('SE-180304085841', 'PR-1519939468', 15, '2018-03-04', 'TR-584118030408'),
('SE-180304085841', 'PR-1519942677', 18, '2018-03-04', 'TR-585018030408'),
('SE-180304090128', 'PR-1519955594', 32, '2018-03-04', 'TR-012818030409'),
('SE-180304090128', 'PR-1519942677', 5, '2018-03-04', 'TR-014818030409'),
('SE-180304092307', 'PR-1519939468', 12, '2018-03-04', 'TR-232118030409'),
('SE-180305122529', 'PR-1519939468', 5, '2018-03-05', 'TR-252918030512'),
('SE-180305122529', 'PR-1519942677', 5, '2018-03-05', 'TR-254318030512'),
('SE-180305122529', 'PR-1519955594', 6, '2018-03-05', 'TR-255218030512'),
('SE-180311105422', 'PR-1519955594', 20, '2018-03-11', 'TR-544818031110'),
('SE-180311105422', 'PR-1519939468', 20, '2018-03-11', 'TR-550018031110'),
('SE-180317121051', 'PR-1519939468', 40, '2018-03-17', 'TR-105018031712'),
('SE-180317121051', 'PR-1519942677', 40, '2018-03-17', 'TR-110318031712'),
('SE-180317121051', 'PR-1519955594', 40, '2018-03-17', 'TR-111618031712'),
('SE-180324022040', 'PR-1519939468', 2, '2018-03-24', 'TR-204018032402'),
('SE-180324022040', 'PR-1519942677', 2, '2018-03-24', 'TR-205518032402'),
('SE-180324031129', 'PR-1519939468', 6, '2018-03-24', 'TR-112918032403'),
('SE-180324031129', 'PR-1519942677', 2, '2018-03-24', 'TR-114518032403');

-- --------------------------------------------------------

--
-- Table structure for table `tblsupplier`
--

CREATE TABLE `tblsupplier` (
  `supplierid` varchar(99) NOT NULL,
  `supplier_name` varchar(99) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsupplier`
--

INSERT INTO `tblsupplier` (`supplierid`, `supplier_name`) VALUES
('SUP-594518302', 'XYZ Oil Corp'),
('SUP-124618302', 'Andro Oil Products Manuf.'),
('SUP-515318302', 'Amiel Oil Manuf. Corp'),
('SUP-325418302', 'Ryan Corporation');

-- --------------------------------------------------------

--
-- Table structure for table `tbltype`
--

CREATE TABLE `tbltype` (
  `type_id` int(99) NOT NULL,
  `category_id` varchar(99) NOT NULL,
  `type_name` varchar(99) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbltype`
--

INSERT INTO `tbltype` (`type_id`, `category_id`, `type_name`) VALUES
(1, '1', 'Fully Synthetic'),
(2, '1', 'Semi-Synthetic'),
(3, '1', 'Mineral Multi-Grade'),
(5, '2', 'MINERAL Multi-Grade'),
(7, '2', 'Mineral MONO-GRADE');

-- --------------------------------------------------------

--
-- Table structure for table `tblviscosity`
--

CREATE TABLE `tblviscosity` (
  `viscosity_id` int(99) NOT NULL,
  `viscosity_name` varchar(99) NOT NULL,
  `type_id` varchar(99) NOT NULL,
  `category_id` varchar(99) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblviscosity`
--

INSERT INTO `tblviscosity` (`viscosity_id`, `viscosity_name`, `type_id`, `category_id`) VALUES
(1, 'SAE 5W-40', '1', '1'),
(2, 'SAE 10W-40', '2', '1'),
(3, 'SAE 20W-40', '5', '1'),
(4, '10W-40', '4', '3'),
(5, '20W-50', '5', '3'),
(6, '20W-40', '5', '3'),
(0, 'none', '0', '0');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblcategory`
--
ALTER TABLE `tblcategory`
  ADD PRIMARY KEY (`category_id`);

--
-- Indexes for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  ADD PRIMARY KEY (`customerid`);

--
-- Indexes for table `tbldownpaymentorder`
--
ALTER TABLE `tbldownpaymentorder`
  ADD PRIMARY KEY (`transid`);

--
-- Indexes for table `tblfullpaymentorder`
--
ALTER TABLE `tblfullpaymentorder`
  ADD PRIMARY KEY (`transid`);

--
-- Indexes for table `tblorderlogs`
--
ALTER TABLE `tblorderlogs`
  ADD UNIQUE KEY `tracecode` (`tracecode`);

--
-- Indexes for table `tblpayments`
--
ALTER TABLE `tblpayments`
  ADD PRIMARY KEY (`or_no`);

--
-- Indexes for table `tblproduct`
--
ALTER TABLE `tblproduct`
  ADD PRIMARY KEY (`productid`);

--
-- Indexes for table `tblproduct_inv`
--
ALTER TABLE `tblproduct_inv`
  ADD PRIMARY KEY (`productid`);

--
-- Indexes for table `tblstockentry`
--
ALTER TABLE `tblstockentry`
  ADD PRIMARY KEY (`stock_entry_id`);

--
-- Indexes for table `tblsupplier`
--
ALTER TABLE `tblsupplier`
  ADD PRIMARY KEY (`supplierid`);

--
-- Indexes for table `tbltype`
--
ALTER TABLE `tbltype`
  ADD PRIMARY KEY (`type_id`);

--
-- Indexes for table `tblviscosity`
--
ALTER TABLE `tblviscosity`
  ADD PRIMARY KEY (`viscosity_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbltype`
--
ALTER TABLE `tbltype`
  MODIFY `type_id` int(99) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `tblviscosity`
--
ALTER TABLE `tblviscosity`
  MODIFY `viscosity_id` int(99) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
