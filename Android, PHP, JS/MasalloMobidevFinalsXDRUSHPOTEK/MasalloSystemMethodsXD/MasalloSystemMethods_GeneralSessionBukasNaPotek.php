<?php

class SystemMethods_GeneralSession
{
	/*
	private $getdbServername = "192.168.1.106";
	private $getdbUsername = "masallo";
	private $getdbPassword = "rafael";
	private $getdbName = "db_masalloRafael";
	*/
	private $getdbServername = "127.0.0.1";
	private $getdbUsername = "root";
	private $getdbPassword = "";
	private $getdbName = "db_mobidevfinals";	

	//Set table Names.
	public function set_Table_Name()
	{
		global $tblName1, $tblName2, $tblName3, $tblName4, $tblName5;

		$tblName1 = "tbl_product_information";
		$tblName2 = "tbl_user_information";
		$tblName3 = "tbl_customer_information";
		$tblName4 = "tbl_product_information_report";
		$tblName5 = "tbl_product_order_information";
		
	}

	//Check if have a connection;
	public function checkDBconnection()
	{
		global $MySqliConnection;

		$MySqliConnection =  mysqli_connect($this->getdbServername, $this->getdbUsername, $this->getdbPassword, $this->getdbName);

		if(mysqli_connect_errno())
		{
			//echo "<script>alert ('Connection Error');</script>".mysqli_connect_error();
			echo "Error Connection".mysqli_connect_error();
		}
		
		else
		{
		    //echo "<script>alert ('Connection Successsss!!');</script>";
		}
	}
}


$SystemMethods_GeneralSession = new SystemMethods_GeneralSession;

$SystemMethods_GeneralSession->checkDBconnection();
$SystemMethods_GeneralSession->set_Table_Name();

class SystemMethods_AdminSession
{
	public function get_product_information()
	{
		global $MySqliConnection, $tblName1;

		$querySelect = "SELECT * FROM $tblName1";

		$queryExecute = mysqli_query($MySqliConnection, $querySelect);

		while ($row = mysqli_fetch_array($queryExecute))
		{			

			echo "<tr>
				      <td class='word-wrap' style='vertical-align: middle;'>". $row['product_ID'] ."</td>
				      <td class='word-wrap' style='vertical-align: middle;'>". $row['product_Name'] ."</td>
				      <td class='word-wrap' style='vertical-align: middle;'>". $row['product_Price'] ."</td>	
				      <td class='word-wrap' style='vertical-align: middle;'>". $row['product_Quantity'] ."</td>	
				      <td class='word-wrap' style='vertical-align: middle;'>". $row['product_Description'] ."</td>
				      <td class='word-wrap'><img src =\"".$row['product_Image'].'?'.mt_rand(100000,999999)."\" style='width: 80px; height: 80px;'>	</td>			
				      <td class='word-wrap' style='vertical-align: middle;'>
				     
				      <button type='button' class='btn btn-danger' id = \"". $row['product_ID'] ."\" value = 'Delete'
				      onclick=\"get_currentButton(this, 'btn_deleteProduct');\">Delete</button>
				      </td>
				      

				  </tr>";
		}					
	}


	public function insert_product_information($setProduct_ID, $setProduct_Name, $setProduct_Price, $setProduct_Quantity, $setProduct_Description, $setProduct_Image)
	{
		global $MySqliConnection, $tblName1;			

		$set_ImagePath = "db_FilePath/db_ProductImagePath/".$setProduct_Name.".jpeg";

		

		$queryColumns = "(product_ID, product_Name, product_Price, product_Quantity, product_Description, product_Image)";
		
		$queryValues = "('$setProduct_ID', '$setProduct_Name', '$setProduct_Price', '$setProduct_Quantity', '$setProduct_Description', '$set_ImagePath')";

		$queryInsert = "INSERT INTO $tblName1 $queryColumns VALUES $queryValues;";

		$set_ImagePath = "../db_FilePath/db_ProductImagePath/".$setProduct_Name.".jpeg";

		if ($queryExecute = mysqli_query($MySqliConnection, $queryInsert))
		{
			move_uploaded_file($setProduct_Image, $set_ImagePath);
			echo "Success";
		}		
		
	}

	public function delete_product_information($setProduct_ID)
		{
		    global $MySqliConnection, $tblName1;
		  
			$queryDelete = "DELETE FROM $tblName1 WHERE product_ID = '$setProduct_ID';";

			$queryExecute = mysqli_query($MySqliConnection, $queryDelete);
			
			echo "Success";
		}

	public function get_product_order_information($set_Status)
	{
		global $MySqliConnection, $tblName5;

		if ($set_Status == "Pending")
			$querySelect = "SELECT order_ID, product_ID, product_Quantity FROM $tblName5 WHERE order_Status = '$set_Status'";
		else
			$querySelect = "SELECT order_ID, product_ID, product_Quantity, order_Status FROM $tblName5 WHERE order_Status != 'Pending'";



		$queryExecute = mysqli_query($MySqliConnection, $querySelect);

		while ($row = mysqli_fetch_array($queryExecute))
		{			

			echo "<tr>
				      <td class='word-wrap' style='vertical-align: middle;'>". $row['order_ID'] ."</td>
				      <td class='word-wrap' style='vertical-align: middle;'>". $row['product_ID'] ."</td>
				      <td class='word-wrap' style='vertical-align: middle;'>". $row['product_Quantity'] ."</td>	      

				  ";

			if ($set_Status == "Pending")
			{
				echo "<td>
				      <button type='button' class='btn btn-primary' id = ". $row['order_ID'] ."
				      onclick=\"get_currentButton(this, 'btn_acceptOrder');\">Accept</button>

				      <button type='button' class='btn btn-danger' id = \"". $row['order_ID'] ."\"
				      onclick=\"get_currentButton(this, 'btn_declineOrder');\">Decline</button>
				      </td>";
			}

			else
			{
				echo "<td>" .  $row['order_Status']  . " </td>";
			}

			echo "</tr>";
		}					
	}

	public function update_product_order_information($set_OrderID, $set_OrderStatus)
	{
	    global $MySqliConnection, $tblName1, $tblName5;

	    if ($set_OrderStatus == "Delete")
	    {
	    	$querySelect = "DELETE FROM $tblName5 WHERE order_ID = '$set_OrderID'";

			$queryExecute = mysqli_query($MySqliConnection, $querySelect);
			exit();
	    }
		
		$queryUpdate = "UPDATE $tblName5 SET order_Status = '$set_OrderStatus' WHERE order_ID = '$set_OrderID';";
		

		if ($queryExecute = mysqli_query($MySqliConnection, $queryUpdate))
		{
			if ($set_OrderStatus == "Decline")
				exit();

			$querySelect = "SELECT product_ID, product_Quantity FROM $tblName5 WHERE order_ID = '$set_OrderID'";

			$queryExecute = mysqli_query($MySqliConnection, $querySelect);

			while ($row1 = mysqli_fetch_array($queryExecute))
			{
				$querySelect = "SELECT  product_Quantity FROM $tblName1 WHERE product_ID = '".$row1['product_ID']."'";
				
				$queryExecute = mysqli_query($MySqliConnection, $querySelect);
				while ($row2 = mysqli_fetch_array($queryExecute))
				{

					$seT_TotalQuantity = $row2['product_Quantity'] - $row1['product_Quantity'];
					
					$queryUpdate = "UPDATE $tblName1 SET product_Quantity = '$seT_TotalQuantity' WHERE product_ID = '".$row1['product_ID']."';";

					$queryExecute = mysqli_query($MySqliConnection, $queryUpdate);
				}
			}
		}			
			
			
	}

	public function get_product_order_information_mobile()
	{
			global $MySqliConnection, $tblName1, $tblName5;

			$querySelect = "SELECT $tblName5.order_ID, $tblName5.product_Quantity, $tblName1.product_Image, $tblName1.product_Name FROM $tblName5
			INNER JOIN $tblName1 ON $tblName5.product_ID = $tblName1.product_ID
			WHERE order_Status = 'Pending'";

			$queryExecute = mysqli_query($MySqliConnection, $querySelect);

			$rows = array();

			while ($row = mysqli_fetch_array($queryExecute))
			{
				$rows['Products'][] = $row;	
			}

			echo json_encode($rows);					
	}


}

$SystemMethods_AdminSession = new SystemMethods_AdminSession;

//require "../db_FilePath/db_ProductImagePath/";

if (isset($_POST["Admin"]))
{
	if ($_POST["Admin"] == "insert_product_information")
	{
		//echo "Hello XD";		
		$get_ProductID 			= "Product-".mt_rand(10000, 99990);		
		$get_ProductName 		= $_POST["get_ProductName"];
		$get_ProductPrice 		= $_POST["get_ProductPrice"];
		$get_ProductQuantity 	= $_POST["get_ProductQuantity"];
		$get_ProductDescription = $_POST["get_ProductDescription"];
		$get_productImage 		= $_FILES["get_productImage"]["tmp_name"];			


		$SystemMethods_AdminSession->insert_product_information($get_ProductID, $get_ProductName, $get_ProductPrice, $get_ProductQuantity, $get_ProductDescription, $get_productImage);		
	}	

	if ($_POST["Admin"] == "delete_product_information")
	{
		$get_ProductID = $_POST["set_ProductID"];
		$SystemMethods_AdminSession->delete_product_information($get_ProductID);		
	}

	if ($_POST["Admin"] == "get_product_information")
	{
		$SystemMethods_AdminSession->get_product_information();		
	}

	if ($_POST["Admin"] == "get_product_order_information")
	{	
		
		$get_Status = $_POST["get_Status"];
		$SystemMethods_AdminSession->get_product_order_information("$get_Status");		
	}

	if ($_POST["Admin"] == "accept_product_order_information")
	{	
		$get_OrderID = $_POST["set_OrderID"];
		$SystemMethods_AdminSession->update_product_order_information($get_OrderID, "Accept");		
	}

	if ($_POST["Admin"] == "decline_product_order_information")
	{
		$get_OrderID = $_POST["set_OrderID"];
		$SystemMethods_AdminSession->update_product_order_information($get_OrderID, "Decline");	
	}

	if ($_POST["Admin"] == "delete_product_order_information")
	{
		$get_OrderID = $_POST["set_OrderID"];
		$SystemMethods_AdminSession->update_product_order_information($get_OrderID, "Delete");	
	}

	if ($_POST["Admin"] == "get_product_order_information_mobile")
	{
		$SystemMethods_AdminSession->get_product_order_information_mobile();		
	}




}

	
?>