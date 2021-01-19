

<!DOCTYPE html>
<html>
<head>
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title></title>	
	<link rel= "stylesheet" href="XB\style.css">
	<link rel= "stylesheet" href="XB\style1.css">

</head>

	<div class= "scrollXD">
		<header class="header-1">	
	<nav>		
		<h1 class="h1-1">Rafael Music</h1>
		<ul>			
			<li><a class="GTabHover"href="RafaelNoblezaMasalloHomePage.php">Home</a></li>
			<li><a class="GTabHover"href="#">Learn Music</a></li>
			<li><a class="GTab"href="RafaelNoblezaMasalloGuitarTablature.php">Guitar Tablature</a></li>
			<li><a class="GTabHover"href="#">About me</a></li>
		</ul>
	</nav>
</header>

	<div class="divider"></div>
	</div>

<div class="blank"></div>





	<div class = "registerForm" >

		<form action = "RafaelNoblezaMasalloGuitarTablature.php" method="post">
			<table>

				<tr>
					<td>First Name:</td>
					<td><input type="Text" placeholder="First Name" name="txtFirstName" ></td>
				</tr>
				<tr>
					<td>Middle Name:</td>
					<td><input type="Text" placeholder="Middle Name" name="txtMiddleName"></td>
				</tr>
				<tr>
					<td>Last Name:</td>
					<td><input type="Text" placeholder="Last Name" name="txtLastName"></td>
				</tr>

				<tr>
					<td>Age:</td>
					<td style="text-align: left;"><input type="Text" placeholder="Age" name="txtAge" style="width: 30px;"></td>
				</tr>	

					<tr>
					<td>Female</td>
					<td style="text-align: left;"><input type="radio" name="gender" value="Female"></td>
					<td>Male</td>
					<td style="text-align: left;"><input type="radio" name="gender" value="Male"></td>
					</tr>


				<tr>
					<td>Email-Adress:</td>
					<td><input type="Text" placeholder="Email@*****.com" name="txtEmail"></td>
				</tr>	

				<tr>
					<td>User Name:</td>
					<td><input type="Text" placeholder="Username" name="txtUsername"></td>
				</tr>	

				<tr>
					<td>Password:</td>
					<td><input type="Password" placeholder="Password" name="txtPassword"></td>
				</tr>
		
				<tr>
						<td>Genre</td>
					<td style="text-align:  left;">
						
						<select name="Genre">
						
						<option value=""></option>
						<option value="Classical">Classical</option>
						<option value="Metal/Rock">Metal/Rock</option>
						<option value="Religion">Religion</option>
						<option value="Norms">Norms</option>
						

							</select>
					</td>

				</tr>


				<tr >

					<td><input type="submit" name="submit" value="Go"></td>
				</tr>					
						

			</table>
				
			
		</form>

	</div>

	<script>
		
		

	</script>


<?php

$getFname 	 = "";
$getMname 	 = "";
$getLname 	 = "";
$getAge  	 = "";
$getEmail 	 = "";
$getUsername = "";
$getPassword = "";

$getGender	 = "";
$getGenre    = "";




$dbName = "Engskie";
$tbName = "Users";

$SqlcmdCreateDatabase = "Create Database if not exists $dbName";
$SqlcmdNavigate = "use $dbName";
$SqlcmdCreateTable = "Create table $tbName(No int NOT NULL Auto_increment PRIMARY KEY, First_name varchar(50) NOT NULL,
Middle_Name varchar(50) NOT NULL,
Last_Name varchar(50) NOT NULL,
Age int NOT NULL, Gender varchar(50) not null ,
Email varchar(50) NOT NULL,
Username varchar(50) NOT NULL,
Password varchar(50) NOT NULL, Genre varchar(50) not null)";


$host = "localhost";
$user = "root";
$con = new mysqli($host,$user);


$con->query($SqlcmdCreateDatabase);
$con->query($SqlcmdNavigate);
$con->query($SqlcmdCreateTable);

$Trixie = False;

if(isset($_POST["txtFirstName"])){
	$getFname = $_POST["txtFirstName"];
}


if(isset($_POST["txtMiddleName"])){
	$getMname 	 = $_POST["txtMiddleName"];
}

if(isset($_POST["txtLastName"])){
	$getLname = $_POST["txtLastName"];
}


if(isset($_POST["txtAge"])){
	$getAge = (int)$_POST["txtAge"];
}
if(isset($_POST["txtEmail"])){
$getEmail 	 = $_POST["txtEmail"];
}
if(isset($_POST["txtUsername"])){
	$Trixie = True;
	$getUsername = $_POST["txtUsername"];}


if(isset($_POST["txtPassword"])){
	$Trixie = True;
$getPassword = $_POST["txtPassword"];
}


if(isset($_POST["gender"])){
$getGender = $_POST["gender"];
}


if(isset($_POST["Genre"])){
$getGenre  = $_POST["Genre"];
}




if($getUsername != null && $getPassword != null ){
$SqlcmdInsert = "insert into $tbName(First_name,Middle_Name,Last_Name,Age,Gender,Email,Username,Password,Genre) 
					values('$getFname','$getMname','$getLname','$getAge ','$getGender','$getEmail','$getUsername','$getPassword','$getGenre')";
$con->query($SqlcmdInsert)
}


else if ($getUsername == null || $getPassword == null && $Trixie) 
{
	echo "<script type='text/javascript'>alert('Paaaaaaaaaaaaaaaaaaaaaat!')</script>";
}



/*
echo $getFname;
echo $getMname;
echo $getLname;
echo $getAge;
echo $getEmail;
echo $getUsername;

echo $getPassword;*/


?>
<body>



</body>
</html>