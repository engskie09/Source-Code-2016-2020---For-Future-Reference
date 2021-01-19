<?php
	
	date_default_timezone_set('Asia/Manila');

	class SystemMethods_GeneralSession
	{

		//Set Hosting IP Address.
		private $get_DBServerName = "127.0.0.1";

		//Credentials for Database.
		private $get_DBUserName = "root";
		private $get_DBPassword = "";

		//Database Name.
		private $get_DBName = "bbs_db";

		function set_database_connection()
		{
			global $get_MySqliConnection;

			$get_MySqliConnection = mysqli_connect($this->get_DBServerName, $this->get_DBUserName, $this->get_DBPassword, $this->get_DBName);

			if (mysqli_connect_errno())
			{
				//echo "<script>alert ('Cannot connect to " . $this->get_DBServerName . "') </script>";
				//echo mysqli_connect_error();
				exit();
			}

			else
			{
				//echo "<script>alert ('Successfully Connected to " . $this->get_DBServerName . "') </script>";
			}
		}

		//Set Database Table name.
		function set_database_table()
		{
			global $get_Table1, $get_Table2;

			$get_Table1 = 'tbl_blogger_information';
			$get_Table2 = 'tbl_blog_information';					

		}



		//Insert Blogger Information to Database.
		function insert_blogger_information($set_BloggerUserName, $set_BloggerUserPassword, $set_BloggerEmailAddress, $set_BloggerFirstName, $set_BloggerLastName)
		{
			global $get_MySqliConnection, $get_Table1;			

			$set_BloggerUserID = 'blggr-' . mt_rand(10000, 99999);

			$query_Select = "SELECT blogger_UserName FROM $get_Table1 WHERE blogger_UserName = '$set_BloggerUserName'";

			if($query_Execute = mysqli_query($get_MySqliConnection, $query_Select))
			{
				$query_Rows = mysqli_num_rows($query_Execute);

				if ($query_Rows != 0)
				{
					echo 'Username Already Taken.';
					exit();
				}

			}

			else
				echo mysqli_error($get_MySqliConnection);		


			$query_Column = '(blogger_UserID, blogger_UserName, blogger_UserPassword, blogger_UserRole, blogger_UserEmailAddress, blogger_FirstName, blogger_LastName, blogger_DateRegistered)';

			$query_Value = "('$set_BloggerUserID', '$set_BloggerUserName', '".$this->my_simple_crypt($set_BloggerUserPassword)."', 'Blogger', '$set_BloggerEmailAddress', '$set_BloggerFirstName', '$set_BloggerLastName', '" . date('F j, Y g:i:a  ') . "');";


			$query_Insert = "INSERT INTO $get_Table1 $query_Column VALUES $query_Value";
			
			if ($query_Execute = mysqli_query($get_MySqliConnection, $query_Insert))
			{
				echo 'Success.';
			}

			else
				echo mysqli_error($get_MySqliConnection);

			
		}

		function get_blogger_information($set_Action, $set_UserName, $set_UserPassword)
		{
			global $get_MySqliConnection, $get_Table1;

			if ($set_Action == 'Login')
			{
				$set_UserPassword = $this->my_simple_crypt($set_UserPassword);

				$query_Select = "SELECT * FROM $get_Table1 WHERE blogger_UserName = '$set_UserName' AND blogger_UserPassword = '$set_UserPassword';";

				if($query_Execute = mysqli_query($get_MySqliConnection, $query_Select))
				{
					$query_Rows = mysqli_num_rows($query_Execute);

					if ($query_Rows == 1)
					{
						$query_Row = mysqli_fetch_array($query_Execute);						

						session_start();						

						$_SESSION['blogger_UserName'] = $query_Row['blogger_UserName'];
						$_SESSION['blogger_UserID'] = $query_Row['blogger_UserID'];
						
						echo 'Success.';				
					}

					else
						echo "Please Try Again.";
				}

				else
					echo mysqli_error($get_MySqliConnection);
			}

			else if ($set_Action == 'Select-All')
			{
				$query_Select = "SELECT * FROM $get_Table1 WHERE blogger_UserName = '$set_UserName';";

				if($query_Execute = mysqli_query($get_MySqliConnection, $query_Select))
				{					
					$query_Row = mysqli_fetch_array($query_Execute);

					$get_Output = new stdClass();
				
					$get_Output->get_BloggerUserID = $query_Row['blogger_UserID'];
					$get_Output->get_BloggerUserName = $query_Row['blogger_UserName'];
					$get_Output->get_BloggerUserPassword = $this->my_simple_crypt($query_Row['blogger_UserPassword'], 'd');
					$get_Output->get_BloggerUserRole = $query_Row['blogger_UserRole'];
					$get_Output->get_BloggerUserEmailAddress = $query_Row['blogger_UserEmailAddress'];
					$get_Output->get_BloggerFirstName = $query_Row['blogger_FirstName'];
					$get_Output->get_BloggerLastName = $query_Row['blogger_LastName'];
					$get_Output->get_BloggerDateRegistered = $query_Row['blogger_DateRegistered'];

					echo json_encode($get_Output);					

				}
			}
		}

		function update_blogger_information($set_BloggerUserName, $set_BloggerUserPassword, $set_BloggerEmailAddress, $set_BloggerFirstName, $set_BloggerLastName)
		{

			global $get_MySqliConnection, $get_Table1;

			$set_BloggerUserPassword = $this->my_simple_crypt($set_BloggerUserPassword);
			
			$query_Update = "UPDATE $get_Table1 SET blogger_UserPassword = '$set_BloggerUserPassword', blogger_UserEmailAddress = '$set_BloggerEmailAddress', blogger_FirstName = '$set_BloggerFirstName', blogger_LastName = '$set_BloggerLastName' WHERE blogger_UserName = '$set_BloggerUserName';";

			if ($query_Execute = mysqli_query($get_MySqliConnection, $query_Update))
			{
				echo 'Success.';
			}

			else
			echo mysqli_error($get_MySqliConnection); 
		}

		function set_blog_information($set_BlogTitle, $set_BlogContent)
		{
			global $get_MySqliConnection, $get_Table2;

			session_start();

			$set_BlogID = 'blg-' . mt_rand(10000, 99999);
			$set_BlogPostedBy = $_SESSION['blogger_UserID'];

			$query_Column = '(blog_ID, blog_Title, blog_Content, blog_PostedBy, blog_DatePosted)';

			$query_Value = "('$set_BlogID', '$set_BlogTitle', '$set_BlogContent', '$set_BlogPostedBy', '" . date('Y-m-d H:i:s') . "' );";

			$query_Insert = "INSERT INTO $get_Table2 $query_Column VALUES $query_Value";

			if ($query_Execute = mysqli_query($get_MySqliConnection, $query_Insert))
			{
				echo 'Success.';
			}

			else
				echo mysqli_error($get_MySqliConnection);
		}

		function get_blog_information($set_Action, $set_SelectedPage, $set_BlogID)
		{

			global $get_MySqliConnection, $get_Table1, $get_Table2;

			if($set_Action == 'Select-Specify-Paging')
			{				
				$query_Select = "SELECT * FROM $get_Table2;";
				
				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				$query_Row_Total = mysqli_num_rows($query_Execute);		

				$get_TotalPageNumber = (int) $query_Row_Total / 3;
				
				$get_Counter = 0;
				
				while($get_TotalPageNumber > $get_Counter)
				{
			
					$get_Counter ++;

					$query_Output = "<li class='page-item'><a class='page-link' style='color: black'  href='#'  onclick='$(&quot;#div_Blog_Display&quot;).html(get_blog_information(&quot;Select-Specify-Page&quot;, $get_Counter))'>" . $get_Counter  . "</a></li>";

					echo $query_Output;

				
				}				
			}

			if($set_Action == 'Select-Blog')
			{
				

				$query_Select = "SELECT * FROM $get_Table2 WHERE blog_ID = '$set_BlogID' ;";
				
				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				if($query_Row = mysqli_fetch_array($query_Execute))
				{

					$query_Output = "";

					echo $query_Output;
				}

				else
					echo mysqli_error($get_MySqliConnection);

			}

			else if($set_Action == 'Select-Specify-Page')
			{
				
				$get_SelectedPage = 0;

				if ($set_SelectedPage == 1)
					$get_SelectedPage = $set_SelectedPage - 1;

				else
					$get_SelectedPage = ($set_SelectedPage * 3) - 3;

				

				$query_Select = "SELECT * FROM $get_Table2  LEFT JOIN $get_Table1 ON $get_Table2.blog_PostedBy = $get_Table1.blogger_UserID  ORDER BY $get_Table2.blog_DatePosted DESC LIMIT 3 OFFSET $get_SelectedPage";
				
				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				while($query_Row = mysqli_fetch_array($query_Execute))
				{

					$query_Output = "<div class='card mb-4'>
										<div class='card-body'>
											<h2 class='card-title'>" . $query_Row['blog_Title'] . "</h2>
											<p class='card-text'>" . $query_Row['blog_Content'] . "</p>
											<a href='#' class='btn btn-dark' id='" . $query_Row['blog_ID'] . "'>Read More &rarr;</a>
										</div>
										<div class='card-footer text-muted'>
										Date Posted  " . $query_Row['blog_DatePosted'] . "
											<a href='#'> by " . $query_Row['blogger_UserName'] . "</a>
										</div>
									</div>";

					echo $query_Output;
				}	

			}

		}

		function get_blog_information_summary()
		{
			global $get_MySqliConnection, $get_Table1, $get_Table2;
			
			$get_Blogger_TotalRow;
			$get_Blog_TotalRow;


			$query_Select = "SELECT * FROM $get_Table1;";

			$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

			$query_Row_Total = mysqli_num_rows($query_Execute);

			$get_Blogger_TotalRow = $query_Row_Total;

			$query_Select = "SELECT * FROM $get_Table2;";

			$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

			$query_Row_Total = mysqli_num_rows($query_Execute);

			$get_Blog_TotalRow = $query_Row_Total;

			$get_Output = new stdClass();
				
			$get_Output->get_Blog_TotalRow = $get_Blog_TotalRow;

			$get_Output->get_Blogger_TotalRow = $get_Blogger_TotalRow;

			echo json_encode($get_Output);

		}

		function my_simple_crypt($string, $action = 'e' ) 
		{
		
			$secret_key = 'my_simple_secret_key';
			$secret_iv = 'my_simple_secret_iv';

			$output = false;
			$encrypt_method = "AES-256-CBC";
			$key = hash( 'sha256', $secret_key );
			$iv = substr( hash( 'sha256', $secret_iv ), 0, 16 );

			if( $action == 'e' ) 
			{
				$output = base64_encode( openssl_encrypt( $string, $encrypt_method, $key, 0, $iv ) );
			}
			else if( $action == 'd' )
			{
				$output = openssl_decrypt( base64_decode( $string ), $encrypt_method, $key, 0, $iv );
			}

			return $output;
		}
	}

	//Set Variable for Class/Object SystemMethods_GeneralSession.
	$SystemMethods_GeneralSession = new SystemMethods_GeneralSession();

	//Call the set_database_connection function.
	$SystemMethods_GeneralSession->set_database_connection();

	//Call the set_database_table.
	$SystemMethods_GeneralSession->set_database_table();


	//Get the Post value from Call of AJAX.
	if(isset($_POST['set_blogger_information']))
	{
		$get_BloggerUserName 		= $_POST['blogger_UserName'];
		$get_BloggerUserPassword 	= $_POST['blogger_UserPassword'];
		$get_BloggerEmailAddress 	= $_POST['blogger_EmailAddress'];
		$get_BloggerFirstName 		= $_POST['blogger_FirstName'];
		$get_BloggerLastName 		= $_POST['blogger_LastName'];

		//Set Post valu from Call of AJAX to insert_blogger_information function.
		$SystemMethods_GeneralSession->insert_blogger_information($get_BloggerUserName, $get_BloggerUserPassword, $get_BloggerEmailAddress, $get_BloggerFirstName, $get_BloggerLastName);
	}

	if(isset($_POST['get_blogger_information']))
	{		

		if($_POST['get_blogger_information'] == 'Login')
		{
			$get_BloggerUserName 	 = $_POST['blogger_UserName'];
			$get_BloggerUserPassword = $_POST['blogger_UserPassword'];

			$SystemMethods_GeneralSession->get_blogger_information('Login', $get_BloggerUserName, $get_BloggerUserPassword);
		}

		if($_POST['get_blogger_information'] == 'Select-All')
		{	
			session_start();
			$get_BloggerUserName = $_SESSION['blogger_UserName'];
			$SystemMethods_GeneralSession->get_blogger_information('Select-All', $get_BloggerUserName, '');
		}
	}

	if(isset($_POST['update_blogger_information']))
	{
		$get_BloggerUserName 		= $_POST['blogger_UserName'];
		$get_BloggerUserPassword 	= $_POST['blogger_UserPassword'];
		$get_BloggerEmailAddress 	= $_POST['blogger_EmailAddress'];
		$get_BloggerFirstName 		= $_POST['blogger_FirstName'];
		$get_BloggerLastName 		= $_POST['blogger_LastName'];

		$SystemMethods_GeneralSession->update_blogger_information($get_BloggerUserName, $get_BloggerUserPassword, $get_BloggerEmailAddress, $get_BloggerFirstName, $get_BloggerLastName);
	
	}

	if(isset($_POST['set_session']))
	{
		session_start();

		if(isset($_SESSION['blogger_UserName']))
		{
			echo $_SESSION['blogger_UserName'];		
		}

		if($_POST['set_session'] == 'SignOut')
		{
			session_destroy();
			echo '';
		}
	}

	if(isset($_POST['set_blog_information']))
	{
		$get_BlogTitle = $_POST['blog_Title'];
		$get_BlogContent = $_POST['blog_Content'];

		$SystemMethods_GeneralSession->set_blog_information($get_BlogTitle, $get_BlogContent);
	}

	if(isset($_POST['get_blog_information']))
	{

		$get_SelectedPage = $_POST['get_SelectedPage'];
		$get_Action = $_POST['get_Action'];

		if ($get_Action == 'Select-Specify-Page')
			$SystemMethods_GeneralSession->get_blog_information($get_Action, $get_SelectedPage, '');

		else if ($get_Action == 'Select-Specify-Paging')
			$SystemMethods_GeneralSession->get_blog_information($get_Action, $get_SelectedPage, '');
		
	}

	if(isset($_POST['get_blog_information_summary']))
	{
		$SystemMethods_GeneralSession->get_blog_information_summary();
	}
	
?>