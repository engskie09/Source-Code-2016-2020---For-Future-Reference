<?php

	include 'MasalloOrderingConnection.php';
?>

<?php
	$orderListName = array();
	$orderListQuantity = array();
	$orderListPrice = array();

	if(isset($_POST["action"]))
	{
		

		if($_POST["action"] == "fetch")
		{
			
			global $con;
			$query = "SELECT * FROM tbl_productlist";
			$result = mysqli_query($con, $query);
			$output = '

			<table class = "table table-bordered table-striped">
			<tr>
				<th width = "10% ">ID</th>
				<th width = "10% >Name</th>
				<th width = "10% >Quantity</th>
				<th width = "10% >Price</th>
				<th width = "60% >Image</th>
			</tr>

			';

			while($row = mysqli_fetch_array($result))
			{
				$output .= '

					<tr>
					<td>'.$row["id"].'</td>
					<td><img src =data:image/jpeg;base64,'.base64_encode($row['product_picture']).' style="width: 200px; height: 200px;"></td>
					<td></td>
					</tr>




				';
			}

			$output .= '</table>';
			echo $output;

		}

	}


?>