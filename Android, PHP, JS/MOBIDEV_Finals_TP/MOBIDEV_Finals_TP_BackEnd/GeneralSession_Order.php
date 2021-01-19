<?php
	

	class justMethods
	{
		public $getdbServername = "localhost";
		public $getdbUsername = "root";
		public $getdbPassword = "";
		public $getdbName = "just_orderingdb";

		function checkDBconnection()
		{
			global $MySqliConnection;

			$MySqliConnection =  mysqli_connect($this->getdbServername, $this->getdbUsername, $this->getdbPassword, $this->getdbName);

			if(mysqli_connect_errno())
			{
				echo "<script>alert ('Connection Error');</script>";
			}
		}

		public $tblName1 = "tbl_product_information";
		public $tblName2 = "tbl_customer_order_current";
		public $tblName3 = "tbl_report_customer_order";


		public function insert_product_information($set_productID, $set_productName, $set_productQuantity, $set_productPrice, 
									 $set_productDescription, $set_productCategory)
		{
			global $MySqliConnection;

			$queryColumnName = "(product_id, product_name, product_quantity, product_price, product_description, product_category)";
			$queryColumnValue = "('$set_productID','$set_productName','$set_productQuantity','$set_productPrice','$set_productDescription','$set_productCategory')";

			$queryInsert = "INSERT INTO $this->tblName1 $queryColumnName VALUES $queryColumnValue;";

			$queryExecute = mysqli_query($MySqliConnection, $queryInsert);
			
		}

		public function insert_customer_order_current($set_productID, $set_productName, $set_productQuantity, $set_productPrice, 
									 $set_productDescription, $set_productCategory)
		{
			global $MySqliConnection;

			$queryColumnName = "(product_id, product_name, product_quantity, product_price, product_description, product_category)";
			$queryColumnValue = "('$set_productID','$set_productName','$set_productQuantity','$set_productPrice',
			'$set_productDescription','$set_productCategory')";

			$queryInsert = "INSERT INTO $this->tblName2 $queryColumnName VALUES $queryColumnValue;";

			$queryExecute = mysqli_query($MySqliConnection, $queryInsert);
			
		}

		public function insert_report_customer_order($set_reportID, $set_Customerid, $set_CustomerFirstname, $set_CustomerMiddlename, 
			$set_CustomerLastname, $set_productID, $set_productName, $set_productQuantity, $set_productCost, $set_customerDatebuy)
		{
			global $MySqliConnection;

			$queryColumnName = "(report_id, customer_id, customer_firstname, customer_middlename, customer_lastname, customer_product_id, customer_product_name, customer_product_quantity, customer_product_cost, customer_datebuy)";
			
			$queryColumnValue = "('$set_reportID', '$set_Customerid' ,'$set_CustomerFirstname' ,'$set_CustomerMiddlename' ,
			'$set_CustomerLastname' ,'$set_productID' ,'$set_productName', '$set_productQuantity', '$set_productCost', 
			'$set_customerDatebuy')";

			$queryInsert = "INSERT INTO $this->tblName3 $queryColumnName VALUES $queryColumnValue;";

			$queryExecute = mysqli_query($MySqliConnection, $queryInsert);
			
		}

		public function get_product_information()
		{
			global $MySqliConnection;

			

			$querySelect = "SELECT * FROM $this->tblName1";

			$queryExecute = $MySqliConnection->prepare($querySelect);

			$queryExecute->execute();

			

			$queryExecute->bind_result($set_productID, $set_productName, $set_productQuantity, 
							   		   $set_productPrice, $set_productDescription, $set_productCategory,
									   $set_productPicture);			
 
 			$products = array(); 
			
			while($queryExecute->fetch())
			{
				$tempArray = array();
				$tempArray['product_id'] 				= $set_productID;
				$tempArray['product_name'] 				= $set_productName;
				$tempArray['product_quantity']			= $set_productQuantity;
				$tempArray['product_price'] 			= $set_productPrice;
				$tempArray['product_description'] 		= $set_productDescription;
				$tempArray['product_category'] 			= $set_productCategory;
				$tempArray['product_picture'] 			= base64_encode($set_productPicture);

				array_push($products, $tempArray);		
			}			
			
			echo json_encode(array('Products'=>$products));


		}


	}

	$justMethods = new justMethods;

	$justMethods->checkDBconnection();

	$justMethods->get_product_information();
	/*$justMethods->insert_product_information("1","2","3","4","5","6");
	$justMethods->insert_customer_order_current("1","2","3","4","5","6");
	$justMethods->insert_report_customer_order("1","2","3","4","5","6","7","8","9","10");*/




?>