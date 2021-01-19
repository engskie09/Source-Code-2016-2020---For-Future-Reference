<?php  

	$dbServername = "localhost";
	$dbUsername = "root";
	$dbPassword = "";
	$dbName = "db_ordering";

	$con = mysqli_connect($dbServername, $dbUsername, $dbPassword, $dbName);
	$orderListName = array();
	$orderListQuantity = array();
	$orderListPrice = array();

?>