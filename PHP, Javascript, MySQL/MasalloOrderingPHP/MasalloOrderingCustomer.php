
<?php

	include 'MasalloOrderingConnection.php';
	session_start();
?>
<!DOCTYPE html>
<html>
<head>
	<title>Tindahan ni Paeng</title>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">	
	<link rel="stylesheet" type="text/css" href="assets/MasalloOrdering.css">
	<script src="assets/jquery-3.3.1.min.js"></script>  
  	<script src="js/bootstrap.min.js"></script>
</head>
<body class="MainBackground">

<div style="padding: 100px 50px 50px 50px;">
	<div class="navigationbar"></div>
</div>

<div style="padding: 100px 0px 0px 1500px">
<a style=" background-color: #CCB79B; color: black;" class="btn btn-brown waves-effect waves-light"href="MasalloOrderingAdmin.php">Go to As Admin</a>
<button type="submit" name ="submit"  onclick="addtoCartJava()" style=" background-color: #CCB79B; " class="btn btn-brown waves-effect waves-light" data-toggle="modal" data-target="#myModal">Cart</button>
</div>


 <form action="MasalloOrderingCustomer.php" method="POST">

<div style="padding: 0px 30px 30px 200px;">
	<div class="itemlistcontainer">			
	

			<div style="padding-top: 50px;">
				<?php loadFood(); ?>
			</div>

		

	</div>
</div>
</form>

<script type="text/javascript">
	


</script>

<!-- modaal xDD-->
<form action="MasalloOrderingCustomer.php" method="POST">	 

	<div> 
	  <!-- Trigger the modal with a button -->
	   <!-- Modal -->
	  <div class="modal fade" id="myModal" role="dialog">
	    <div class="modal-dialog">
	    
	      <!-- Modal content-->
	      <div class="modal-content">
	        <div class="modal-header" style ="background-color: #CCB79B;">
	 
	          <h4 class="modal-title">Your Order</h4>
	        </div>
	        <div id = "wewXD" class="modal-body" style ="background-color: #CCB79B;">
	          <p>Hello!</p>
	          <?php        						
			
			if (isset($_POST["submit"]))
			{			
					

					if ($_POST["submit"] == "Buy")
					{
						updateProductQuantity();
						viewCart();	
						
					}		

					else 
					{
						addtoCart();		
						viewCart();	
					}	
			} 			
			else 
			{
				viewCart();	

			}     	
	          
	          ?>
	          
	                
	          

	        </div>
	        <div class="modal-footer" style ="background-color: #CCB79B; opacity: 0.7;">
	        	<div>Total: <?php getTotal(); ?> </div>
	        	<input type="Text" placeholder="Cash" name="txt_customerMoney" required="">
	        	<button type="submit" name="submit" value="Buy" class="btn btn-default">Buy</button>
	          	<button type="submit" class="btn btn-default" data-dismiss="modal" >Close</button>

	        </div>
	      </div>
	      
	    </div>
	    </form>
	  </div>
	  
	</div>
<script>
	function viewCars(){
		var result = " <?php viewCart(); ?> ";
	//	document.getElementById('wewXD').innerHTML += result;
    

	$(document).ready(function(){
		function fetch_data()	
		{
		
			jQuery.ajax(
			{
				url:"MasalloOrderingCustomer.php",
				method:"POST",
				data-dismissta:{action:action},
				success:function(data)
				{
					$('#wewXD').html(data);
				}
			})
		}
	})
				}			


</script>
<?php		


	function loadFood()
	{
		global $con;

		$sql = "SELECT * FROM tbl_productlist";
		$result = mysqli_query($con,$sql);


		while($row = mysqli_fetch_assoc($result))
		{	
			echo "<div class ='contentFood' style='text-align: center;' >
			<img src =data:image/jpeg;base64,".base64_encode($row['product_picture'])." style='width: 200px; height: 200px;'>

											 <div>".$row['product_name']."</div>
										     <div><input name = 'txt_productName[]' id =".$row['product_name']."type='text' class='form-control' style = 'width: 300px' ></div>
										     <div>Price: ".$row['product_price']."</div>
										     <div><button name='submit' value='".$row['product_name']."' class='btn btn-default' style='background-color: #CCB79B'>Add to Cart</button></div></div>" ;		

			
		}
	}

	function addtoCart()
	{
		global $con;
		
		if (isset($_POST["txt_productName"]))
		{

			if ($_SERVER['REQUEST_METHOD'] == 'POST')
				
				foreach ($_POST['txt_productName'] as $key => $value)
				{
					if ($value != "")
					{
						
						$sql = "SELECT * FROM tbl_productlist WHERE product_name = '".$_POST["submit"]."' ";
						$result = mysqli_query($con,$sql);
						$row = mysqli_fetch_assoc($result);

						$get_productId = $row['product_id'];
						$get_productName = $row['product_name'];	
						$get_productQuantity = $value;					
						$get_productPrice = $row['product_price'] * $get_productQuantity;
						$queryInsert = "insert into tbl_currentorder(product_id, product_name, product_quantity, product_price) 
						values('$get_productId','$get_productName','$get_productQuantity','$get_productPrice ')";
						$con->query($queryInsert);
					}
				}			
			
				//echo "<script type='text/javascript'>alert(".$_POST["txt_productName"].");</script>";
		}

		else 
		{
		
		}

		

		
			

		//global $orderListName, $orderListQuantity, $orderListPrice;
         	      	
        //echo $orderListName[0];
        //echo count($orderListName);


	}



	function viewCart()
	{
				

	
		global $con;
			$query = "SELECT * FROM tbl_currentorder";
			$result = mysqli_query($con, $query);
			$output = '

			<table class = "table table-bordered table-striped">
			<tr>
				<th width = "10%">Name</th>
				<th width = "10%">Quantity</th>
				<th width = "10%">Price</th>				
				
			</tr>

			';
		
   				while($row = mysqli_fetch_array($result))
			{
				$output .= '

					<tr>					
					<td>'.$row["product_name"].'</td>
					<td>'.$row["product_quantity"].'</td>
					<td>'.$row["product_price"].'</td>	
								
					
					</tr>
				';
			}
		

				$output .= '</table>';
				echo $output;
        

	}

	function updateProductQuantity()
	{
		$getProductName = array();		
		$getProductQuantityToReduce = array();

		global $con;

		$sql = "SELECT * FROM tbl_currentorder";
		$result = mysqli_query($con,$sql);
		$wew = 0;
		while($row = mysqli_fetch_assoc($result))
		{
			array_push($getProductName, $row['product_name']);
			array_push($getProductQuantityToReduce, $row['product_quantity']);

			//echo ($getProductName[$wew] . " " . $getProductQuantityToReduce[$wew]);

			$wew ++;				

		}



		
		$count = count($getProductName);
		for ($wew = 0; $wew < $count; $wew++)
		{
			$sql = "SELECT product_quantity FROM tbl_productlist WHERE product_name = '$getProductName[$wew]'";
			$result = mysqli_query($con,$sql);
			$row = mysqli_fetch_assoc($result);

			echo $row['product_quantity'];

			$getProductCurrentQuantity = $row['product_quantity'];
			$setProductFinalQuantity = $getProductCurrentQuantity - $getProductQuantityToReduce[$wew];

			//echo $setProductFinalQuantity;

			$sql = "UPDATE tbl_productlist SET product_quantity = '$setProductFinalQuantity' WHERE product_name = '$getProductName[$wew]'";
			$result = mysqli_query($con,$sql);
		
			


				
		}
			
			$sql = "DELETE FROM tbl_currentorder ";
			$result = mysqli_query($con,$sql);
		
	}

	function getTotal()
	{
		global $con;

		$sql = "SELECT * FROM tbl_currentorder";
		$result = mysqli_query($con,$sql);
		$total = 0;
		while($row = mysqli_fetch_assoc($result))
		{
			$total += (int)$row['product_price'];
			
		}

		echo $total;
	}
?>

</body >
</html>