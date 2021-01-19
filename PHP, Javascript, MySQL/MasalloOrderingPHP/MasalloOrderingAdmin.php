<?php

	include 'MasalloOrderingConnection.php';
	
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

<div style="padding: 100px 0px 0px 1400px">
<a style=" background-color: #CCB79B; color: black; " class="btn btn-brown waves-effect waves-light"href="MasalloOrderingCustomer.php">Go to As Customer</a>
<button type="button" style=" background-color: #CCB79B; " class="btn btn-brown waves-effect waves-light" data-toggle="modal" data-target="#myModal">Add</button>
<button type="button" style=" background-color: #CCB79B; " class="btn btn-brown waves-effect waves-light" data-toggle="modal" data-target="#myModalXD">Update</button>
</div>

<form action="MasalloOrderingAdmin.php" method="POST">
<div style="padding: 0px 30px 30px 200px;">
	<div class="itemlistcontainer">		

			<div id = "image_data" style="padding-top: 50px;">

				<?php loadall(); ?>

			</div>
	</div>
</div>
</form>


	<!-- modaal xDD-->
	<div> 
	  <!-- Trigger the modal with a button -->
	   <!-- Modal -->
	  <div class="modal fade" id="myModal" role="dialog">
	    <div class="modal-dialog">
	    
	      <!-- Modal content-->
	      <div class="modal-content">
	        <div class="modal-header" style ="background-color: #CCB79B;">
	 
	          <h4 class="modal-title">Add Product</h4>
	        </div>
	        <div class="modal-body" style ="background-color: #CCB79B;">
	          <p>Add new Product</p>
	          
	          <form action="MasalloOrderingAdmin.php" method="POST" enctype="multipart/form-data">
	          <table>

	          	<tr>
	          		<td>Product ID </td>
					<td><input type="Text" placeholder="Product ID" name="txt_productId" ></td>
				</tr>

				<tr>
	          		<td>Product Name </td>
					<td><input type="Text" placeholder="Product Name" name="txt_productName" ></td>
				</tr>

				<tr>
	          		<td>Product Quantity </td>
					<td><input type="Text" placeholder="Product Quantity" name="txt_productQuantity" ></td>
				</tr>

				<tr>
	          		<td>Product Price </td>
					<td><input type="Text" placeholder="Product Price" name="txt_productPrice" ></td>
				</tr>

				<tr>
					<td><input type="file" name="file_productImage"></td>
				</tr>


	          </table>
	          

	        </div>
	        <div class="modal-footer" style ="background-color: #CCB79B; opacity: 0.7;">
	        		
	        	<button type="submit" name="submit" value="Add" class="btn btn-default">Add</button>
	          	<button type="submit" class="btn btn-default" data-dismiss="modal" >Close</button>

	        </div>
	      </div>
	      
	    </div>
	    </form>
	  </div>
	  
	</div>


		<!-- modaal xDD-->
	<div> 
	  <!-- Trigger the modal with a button -->
	   <!-- Modal -->
	  <div class="modal fade" id="myModalXD" role="dialog">
	    <div class="modal-dialog">
	    
	      <!-- Modal content-->
	      <div class="modal-content">
	        <div class="modal-header" style ="background-color: #CCB79B;">
	 
	          <h4 class="modal-title">Update Product</h4>
	        </div>
	        <div class="modal-body" style ="background-color: #CCB79B;">
	          <p>Update Product</p>
	          
	          <form action="MasalloOrderingAdmin.php" method="POST" enctype="multipart/form-data">
	          <table>

	          	<tr>
	          		<td>Product ID </td>
					<td><input type="Text" placeholder="Product ID" name="txt_productId" ></td>
				</tr>

				<tr>
	          		<td>Product Name </td>
					<td><input type="Text" placeholder="Product Name" name="txt_productName" ></td>
				</tr>

				<tr>
	          		<td>Product Quantity </td>
					<td><input type="Text" placeholder="Product Quantity" name="txt_productQuantity" ></td>
				</tr>

				<tr>
	          		<td>Product Price </td>
					<td><input type="Text" placeholder="Product Price" name="txt_productPrice" ></td>
				</tr>

				<tr>
					<td><input type="file" name="file_productImage"></td>
				</tr>


	          </table>
	          

	        </div>
	        <div class="modal-footer" style ="background-color: #CCB79B; opacity: 0.7;">
	        		
	        	<button type="submit" name="submit" value="Update" class="btn btn-default">Update</button>
	          	<button type="submit" class="btn btn-default" data-dismiss="modal" >Close</button>

	        </div>
	      </div>
	      
	    </div>
	    </form>
	  </div>
	  
	</div>


<script type="text/javascript">
	
	
/*fetch_data();


	$(document).ready(function(){
		function fetch_data()	
		{
			var action = "fetch";
			$.ajax(
			{
				url:"action.php",
				method:"POST",
				data:{action:action},
				success:function(data)
				{
					$('#image_data').html(data);
				}
			})
		}
	})*/

</script>

<?php
		

$get_productId 	 = "";
$get_productName 	 = "";
$get_productQuantity 	 = "";		
$get_productPrice 	 = "";
$get_productImage 	 = "";

if(isset($_POST["submit"]))
{
	if($_POST["submit"] == "Add")
	{	
		addProduct();
		echo "<meta http-equiv='refresh' content='0'>";	
	}

	else if($_POST["submit"] == "Update")
	{	
		updateProduct();
		echo "<meta http-equiv='refresh' content='0'>";	
	}

	else 
	{
		deleteProduct();
		echo "<meta http-equiv='refresh' content='0'>";	
	}
}

function addProduct()
{
	global $con, $get_productId, $get_productName, $get_productQuantity, $get_productPrice, $get_productImage;

	if(isset($_POST["txt_productId"]))
	{
		$get_productId = $_POST["txt_productId"];
	}

	if(isset($_POST["txt_productName"]))
	{
		$get_productName = $_POST["txt_productName"];
	}

	if(isset($_POST["txt_productQuantity"]))
	{
		$get_productQuantity = $_POST["txt_productQuantity"];
	}

	if(isset($_POST["txt_productPrice"]))
	{
		$get_productPrice = $_POST["txt_productPrice"];
	}


	if(isset($_POST["txt_productPrice"]))
	{
		$get_productPrice = $_POST["txt_productPrice"];
	}

	$get_productImage = addslashes(file_get_contents($_FILES['file_productImage']['tmp_name'])); 
	
	if($get_productId != null && $get_productName != null && $get_productQuantity != null && $get_productPrice != null && $get_productImage != null )
	{
		$queryInsert = "INSERT INTO tbl_productlist(product_id, product_name, product_quantity, product_price, product_picture) 
					VALUES('$get_productId','$get_productName','$get_productQuantity','$get_productPrice ','$get_productImage')";
		$con->query($queryInsert);
	}

}

	
	
function loadall()
{
	global $con;
			$query = "SELECT * FROM tbl_productlist";
			$result = mysqli_query($con, $query);
			$output = '

			<table class = "table table-bordered table-striped">
			<tr>
				<th width = "10%">ID</th>
				<th width = "10%">Name</th>
				<th width = "10%">Quantity</th>
				<th width = "10%">Price</th>
				<th width = "40%">Image</th>
				<th width = "20%"></th>
			</tr>

			';

			while($row = mysqli_fetch_array($result))
			{
				$output .= '

					<tr>
					<td>'.$row["product_id"].'</td>
					<td>'.$row["product_name"].'</td>
					<td>'.$row["product_quantity"].'</td>
					<td>'.$row["product_price"].'</td>
					<td><img src =data:image/jpeg;base64,'.base64_encode($row['product_picture']).' style="width: 200px; height: 200px;"></td>
					<td><button name="submit" value='.$row["product_name"].' class="btn btn-default" style="background-color: #CCB79B">Delete</button></td>

					</tr>
				';
			}

			$output .= '</table>';
			echo $output;
}



function deleteProduct()
{
		global $con;

		$queryDelete = "DELETE FROM tbl_productlist WHERE product_name = '".$_POST["submit"]."'";
		$result = mysqli_query($con, $queryDelete);
}


function updateProduct()
{

	global $con, $get_productId, $get_productName, $get_productQuantity, $get_productPrice, $get_productImage;

	if(isset($_POST["txt_productId"]))
	{
		$get_productId = $_POST["txt_productId"];
	}

	if(isset($_POST["txt_productName"]))
	{
		$get_productName = $_POST["txt_productName"];
	}

	if(isset($_POST["txt_productQuantity"]))
	{
		$get_productQuantity = $_POST["txt_productQuantity"];
	}

	if(isset($_POST["txt_productPrice"]))
	{
		$get_productPrice = $_POST["txt_productPrice"];
	}


	if(isset($_POST["txt_productPrice"]))
	{
		$get_productPrice = $_POST["txt_productPrice"];
	}

	
		$get_productImage = addslashes(file_get_contents($_FILES['file_productImage']['tmp_name'])); 
	
	

		
	

	if($get_productId != null && $get_productName != null && $get_productQuantity != null && $get_productPrice != null && $get_productImage != null )
	{
		$queryUpdate = "UPDATE tbl_productlist SET product_id = '$get_productId', product_name = '$get_productName' , product_quantity = '$get_productQuantity' , product_price = '$get_productPrice' , product_picture = '$get_productImage' WHERE product_id = '$get_productId'";

		$result = mysqli_query($con, $queryUpdate);
		
	}

}



?>





</body >
</html>