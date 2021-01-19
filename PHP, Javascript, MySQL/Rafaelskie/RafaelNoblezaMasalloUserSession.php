<?php session_start();  ?>
<!DOCTYPE html>
<html>
<head>
	
	<meta name="viewport" content="width=device-width, initial-scale=1">

	<title>Music | Rafael Nobleza Masallo</title>
	<link rel="stylesheet" href="XB\style.css">
	<link rel="stylesheet" href="XB\style1.css">
</head>
	
	<div class= "scrollXD">
		<header class="header-1">	
	<nav>		
		<h1 class="h1-1">Rafael Music</h1>
		<ul>			
			<li><a class="HomeHover" href="RafaelNoblezaMasalloHomePage.php">Home</a></li>
			<li><a class="HomeHover"href="#">Learn Music</a></li>
			<li><a class="HomeHover"href="RafaelNoblezaMasalloGuitarTablature.php">Guitar Tablature</a></li>
			<li><a class="HomeHover"href="#">About me</a></li>
			<li><a class="Home"href="#">My Account</a></li>
		</ul>
	</nav>
</header>


<body>

<div class="divider"></div>
	</div>

	<div class="divider1"></div>

	<div class="blank"></div>


<div class = "registerForm" >

		<form action = "RafaelNoblezaMasalloUserSession.php" method="post">
			<table>

				<tr>
					<td>First Name:</td>
					<td><input type="Text" placeholder="Rafael" name="txtFirstName" Value=<?php echo $_SESSION['Patricia'];?>></td>
				</tr>
				<tr>
					<td>Middle Name:</td>
					<td><input type="Text" placeholder="Nobleza" name="txtMiddleName" Value=<?php echo $_SESSION['Mae'];?> ></td>
				</tr>
				<tr>
					<td>Last Name:</td>
					<td><input type="Text" placeholder="Masallo" name="txtLastName" Value=<?php echo $_SESSION['Valdes'];?> ></td>
				</tr>

				<tr>
					<td>Age:</td>
					<td style="text-align: left;"><input type="Text" placeholder="19" value="<?php echo $_SESSION['Ng'];?>" name="txtAge" style="width: 30px;"></td>
				</tr>	

					<tr>
					<td>Female</td>
					<td style="text-align: left;"><input type="radio" name="gender" id="Female" value="Female"></td>
					<td>Male</td>
					<td style="text-align: left;"><input type="radio" name="gender" id="Male" value="Male"></td>
					</tr>


				<tr>
					<td>Email-Adress:</td>
					<td><input type="Text" placeholder="Paengskie@yahoo.com" name="txtEmail" value="<?php echo $_SESSION['KoXD'];?>"></td>
				</tr>	

				<tr>
					<td>User Name:</td>
					<td><input type="Text" placeholder="Username" name="txtUsername" value="<?php echo $_SESSION['Share'];?>"></td>
				</tr>	

				<tr>
					<td>Password:</td>
					<td><input type="Password" placeholder="Password" name="txtPassword" value="<?php echo $_SESSION['Ko'];?>"></td>
				</tr>
		
				<tr>
						<td>Genre</td>
					<td style="text-align:  left;">
						
						<select name="Genre">
						
						
						<option value="Classical" id="Classical">Classical</option>
						<option value="Metal/Rock" id="Metal/Rock">Metal/Rock</option>
						<option value="Religion" id="Religion">Religion</option>
						<option value="Norms" id="Norms">Norms</option>
						

							</select>
					</td>

				</tr>


				<tr >

					<td><input type="submit" name="submit" value="GustoKita" style="font-size: 1px;padding: 20px 10px 10px 10px;">Update</td>
					<td><input type="submit" name="submit" value="Kaso" style="font-size: 1px;padding: 20px 10px 10px 10px;" >Delete</td>
				</tr>					
						

			</table>
				
			
		</form>

	</div>

<?php 



/*
//DummyDataXDD
echo	$_SESSION['Patricia']; 	
echo	$_SESSION['Mae']; 	
echo	$_SESSION['Valdes'];	
echo	$_SESSION['Ng']; 
echo	$_SESSION['Buhay']; 	
echo	$_SESSION['Ko']; 	
echo	$_SESSION['Share'];	
echo	$_SESSION['Ko'];
echo	$_SESSION['Lang'];*/




$dbName = "Engskie";
$tbName = "Users";
$host = "localhost";
$user = "root";
$con = mysqli_connect($host,$user);
$SqlcmdNavigate = "use $dbName";



PatriciaaaaHuehue();

if(isset($_POST["submit"]))
{
	if($_POST["submit"] == "GustoKita"){
Patriciaaaaawhwahwahawh();
parangTangaSiAko();
echo "<meta http-equiv='refresh' content='0'>";	
}

else if($_POST["submit"] == "Kaso"){
kasoKASIiiiiiiBASTAgustokitaXD();

}
}










function PatriciaaaaHuehue()
{

$getFname 	 = "";
$getMname 	 = "";
$getLname 	 = "";
$getAge  	 = "";
$getEmail 	 = "";
$getUsername = "";
$getPassword = "";

$getGender	 = "";
$getGenre    = "";
//setDataXDDD
if( $_SESSION['Buhay'] == "Male"){
	echo "<script type='text/javascript'>document.getElementById('Male').checked = true;</script>";
}
else
{
	echo "<script type='text/javascript'>document.getElementById('Female').checked = true;</script>";
}


if($_SESSION['Lang'] == "Classical"){
echo "<script type='text/javascript'>document.getElementById('Classical').selected = true;</script>";
}
else if($_SESSION['Lang'] == "Metal/Rock"){
echo "<script type='text/javascript'>document.getElementById('Metal/Rock').selected = true;</script>";
}
else if($_SESSION['Lang'] == "Religion"){
echo "<script type='text/javascript'>document.getElementById('Religion').selected = true;</script>";
}
else if($_SESSION['Lang'] == "Norms"){
echo "<script type='text/javascript'>document.getElementById('Norms').selected = true;</script>";
}

}

function Patriciaaaaawhwahwahawh()
{
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

$dbName = "Engskie";
$tbName = "Users";
$host = "localhost";
$user = "root";
$con = mysqli_connect($host,$user);
$SqlcmdNavigate = "use $dbName";	
$con->query($SqlcmdNavigate);



$piliinSiTricia = $_SESSION['Si'];


$statement = "update $tbName set First_name = '.$getFname.',Middle_Name = '$getMname',Last_Name = '$getLname',Age = '$getAge',Gender = '$getGender',Email = '$getEmail',
					Username = '$getUsername',Password = '$getPassword',Genre = '$getGenre' where No ='$piliinSiTricia'";

$con->query($statement);

}

function kasoKASIiiiiiiBASTAgustokitaXD()
{

$dbName = "Engskie";
$tbName = "Users";
$host = "localhost";
$user = "root";
$con = mysqli_connect($host,$user);
$SqlcmdNavigate = "use $dbName";
$con->query($SqlcmdNavigate);



$piliinSiTricia = $_SESSION['Si'];



$statement = "delete  from users where No ='$piliinSiTricia'";

$con->query($statement);

session_destroy();

header('Location: RafaelNoblezaMasalloHomePage.php');
}





function parangTangaSiAko()
{


$dbName = "Engskie";
$tbName = "Users";
$host = "localhost";
$user = "root";
$con = mysqli_connect($host,$user);
$SqlcmdNavigate = "use $dbName";
$con->query($SqlcmdNavigate);

$piliinSiTricia = $_SESSION['Si'];

$Patricia = "SELECT * from $tbName WHERE no = '$piliinSiTricia'";
$NgBuhay = mysqli_query($con,$Patricia);
$ko = mysqli_num_rows($NgBuhay);
$MsSTingBuhayko = $NgBuhay->fetch_assoc();	 //huehuehueuheuheheuehu WHHWAWHAWHAWHAWHAWHWAHWAH! 
if($ko == 1){
	//echo "<script type='text/javascript'>alert('Welcome $getUsername!')</script>";

	session_destroy();
	session_start();


	
	//
	$_SESSION['Si'] 		= $MsSTingBuhayko["No"];
	$_SESSION['Patricia'] 	= $MsSTingBuhayko["First_name"]; 
	$_SESSION['Mae'] 		= $MsSTingBuhayko["Middle_Name"];
	$_SESSION['Valdes']		= $MsSTingBuhayko["Last_Name"];
	$_SESSION['Ng'] 		= $MsSTingBuhayko["Age"];
	$_SESSION['Buhay'] 		= $MsSTingBuhayko["Gender"];
	$_SESSION['KoXD'] 		= $MsSTingBuhayko["Email"];
	$_SESSION['Share']		= $MsSTingBuhayko["Username"];
	$_SESSION['Ko'] 		= $MsSTingBuhayko["Password"];
	$_SESSION['Lang'] 		= $MsSTingBuhayko["Genre"];
	
}

}

 ?>




</body>
</html>