<?php

require_once 'MasalloSystemMethods_GeneralSessionBukasNaPotek.php';

class SystemMethods_CustomerSession
{
	public function get_product_information()
	{
			global $MySqliConnection, $tblName1;

			$querySelect = "SELECT * FROM $tblName1";

			$queryExecute = mysqli_query($MySqliConnection, $querySelect);

			$rows = array();

			while ($row = mysqli_fetch_array($queryExecute))
			{
				$rows['Products'][] = $row;	
			}

			echo json_encode($rows);					
	}

	public function insert_product_order_information($setOrder_ID, $setProduct_ID, $setProduct_Quantity)
	{
		global $MySqliConnection, $tblName5;

		$queryColumns = "(order_ID, product_ID, product_Quantity, order_Status)";
		
		$queryValues = "('$setOrder_ID', '$setProduct_ID', '$setProduct_Quantity' , 'Pending')";

		$queryInsert = "INSERT INTO tbl_product_order_information $queryColumns VALUES $queryValues;";
		

		if ($queryExecute = mysqli_query($MySqliConnection, $queryInsert))
		{		
			echo "Success";
		}		
		
	}
}

$SystemMethods_CustomerSession = new SystemMethods_CustomerSession();

if (isset($_POST["Customer"]))
{
	if ($_POST["Customer"] == "get_product_information")
	{
		$SystemMethods_CustomerSession->get_product_information();
	}

	if ($_POST["Customer"] == "insert_product_order_information")
	{
		$get_OrderID 				= "Order-".mt_rand(10000, 99990);
		$get_ProductID 				= $_POST["set_ProductID"];
		$get_OrderProductQuantity 	= $_POST["set_OrderProductQuantity"];

		$SystemMethods_CustomerSession->insert_product_order_information($get_OrderID, $get_ProductID, $get_OrderProductQuantity);
	}
}

?>