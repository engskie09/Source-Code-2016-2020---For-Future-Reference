<?php

	include 'MasalloOrderingConnection.php';
	include 'MasalloOrderingAdmin.php';
?>
<!DOCTYPE html>
<html>
<head>
	<title>Tindahan ni Paeng</title>
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	<script src="assets/jquery-3.3.1.min.js"></script>
	<link rel="stylesheet" type="text/css" href="assets/MasalloOrdering.css">

</head>
<body class="MainBackground">

<div style="padding: 100px 50px 50px 50px;">
	<div class="navigationbar"></div>
</div>

<div style="padding: 100px 30px 30px 200px;">
	<div class="itemlistcontainer">			
	

			<div id = "image_data" style="padding-top: 50px;">
				
			</div>



		

	</div>
</div>


<script type="text/javascript">
	
	
fetch_data();


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
	})

</script>

<?php
		
	
	





?>

</body >
</html>