<?php

	include 'MasalloOrderingConnection.php';
?>
<!DOCTYPE html>
<html>
<head>
	<title>Tindahan ni Paeng</title>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="assets/MasalloOrdering.css">

</head>
<body class="MainBackground">

<div style="padding: 100px 50px 50px 50px;">
	<div class="navigationbar"></div>
</div>

<div style="padding: 100px 30px 30px 200px;">
	<div class="itemlistcontainer">			
	

			<div style="padding-top: 50px;">
				<?php echo loadFood(); ?>
			</div>

		

	</div>
</div>


<script type="text/javascript">
	
	function loadData()
	{
		$.ajax({url: "test.php"}).done(function( html ) {
    $("#results").append(html);
		});
	}

</script>

<?php
	
	$sql = "SELECT * FROM tbl_productlist";
	$result = mysqli_query($con, $sql);
	$resultCheck = mysqli_num_rows($result);	

	function loadFood()
	{
		global $con;
		$sql = "SELECT * FROM tbl_productlist";
		$result = mysqli_query($con,$sql);


		while($row = mysqli_fetch_assoc($result))
		{	
			echo "<div class ='contentFood' >
			<img src =data:image/jpeg;base64,".base64_encode($row['product_picture'])." style='width: 200px; height: 200px;'>
											 <div>".$row['product_name']."</div>
										     <div>".$row['product_quantity']."</div>
										     <div>".$row['product_price']."</div>											     
										     </div>";
									

			
		}
	}





?>

</body >
</html>