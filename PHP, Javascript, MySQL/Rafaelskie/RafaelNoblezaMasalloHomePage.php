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
			<li><a class="Home" href="RafaelNoblezaMasalloHomePage.php">Home</a></li>
			<li><a class="HomeHover"href="#">Learn Music</a></li>
			<li><a class="HomeHover"href="RafaelNoblezaMasalloGuitarTablature.php">Guitar Tablature</a></li>
			<li><a class="HomeHover"href="#">About me</a></li>			
		</ul>
	</nav>
</header>

	<div class="divider"></div>
	</div>

	<div class="divider1"></div>



<div class = "slideXD">
	<h1 class="want">Want to learn music?</h1>
<div class="container1">
	

<img class="mySlides" src="XB/backgroundkoXD.png">
<img class="mySlides" src="XB/NotesssXD.png">

<button class="button1" onclick="plusDivs(-1)">&#10094;</button>
<button class="button2" onclick="plusDivs(-1)">&#10095;</button>

</div>
</div>

<div style="padding-bottom: 50px"></div>


<div class="loginForm">


</div>



<div class = "registerForm" >

	<form action="RafaelNoblezaMasalloHomePage.php" method="post">
	
<table>
	
	<tr>		
		<td>Username</td>
		<td><input type="Text" placeholder="Username" name="txtUsername"></td>
	</tr>
	<tr>
		<td>Password</td>
		<td><input type="Password" placeholder="Password" name="txtPassword"></td>
	</tr>

	<tr>
		<td><input type="submit" name="submit" value="Go"></td>
	</tr>

</table>

</form>

	</div>



<?php 


$getUsername = "";
$getPassword = "";

$dbName = "Engskie";
$tbName = "Users";
$host = "localhost";
$user = "root";
$con = mysqli_connect($host,$user);
$SqlcmdNavigate = "use $dbName";
$con->query($SqlcmdNavigate);

if(isset($_POST["txtUsername"])){
	$getUsername = $_POST["txtUsername"];
}


if(isset($_POST["txtPassword"])){
$getPassword = $_POST["txtPassword"];
}

if($getUsername != null && $getPassword != null){

$Patricia = "SELECT * from $tbName WHERE Username = '$getUsername' and Password = '$getPassword'";
$NgBuhay = mysqli_query($con,$Patricia);
$ko = mysqli_num_rows($NgBuhay);
$MsSTingBuhayko = $NgBuhay->fetch_assoc();	 //huehuehueuheuheheuehu WHHWAWHAWHAWHAWHAWHWAHWAH! 
if($ko == 1){
	//echo "<script type='text/javascript'>alert('Welcome $getUsername!')</script>";

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

	header('Location: RafaelNoblezaMasalloUserSession.php');



}
else{

				

}

}



 ?>





<div style=" padding-top:500px">
<h3></h3>	
	<p class="introXD" >


		&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;"As a musician, you know how much work and love is invested in creating music. For all who don’t take music for granted, cherishing it as a hobby and passion, the process of creation is only a halfway to the ultimate goal - sharing music with the world. Luckily, in the age of the internet we live in, reaching out to people who share similar music tastes is easier than ever before."

	</p>

	<br>

	<P class="introXD">
		
		&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Obviously, one of the most effective ways to get your music out nowadays is to create a music website, which will enable you to:

	</P>

	<ul class="tipsxD" style="padding-left: 130px">
		
		

		&nbsp;<li>Share your music; </li>
		&nbsp;<li>Raise awareness about your band;</li>
		&nbsp;<li>Keep in touch with fans;</li>
		&nbsp;<li>Update audience on the latest news, releases, and events;</li>
		&nbsp;<li>Announce concerts and tour dates;</li>
		&nbsp;<li>Promote merchandise.</li>

	</ul>
</div>







<script>
	var slideIndex = 1;
	showDivs(slideIndex);
	

function plusDivs(n) {
  showDivs(slideIndex += n);
}

function showDivs(n) {
  var i;
  var x = document.getElementsByClassName("mySlides");
  if (n > x.length) {slideIndex = 1}    
  if (n < 1) {slideIndex = x.length}
  for (i = 0; i < x.length; i++) {
     x[i].style.display = "none";  
  }
  x[slideIndex-1].style.display = "block";  
}
</script>





<body>

</body>
</html>