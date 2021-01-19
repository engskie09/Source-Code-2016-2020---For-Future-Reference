<?php

class SystemMethods_GeneralSession
{
	private $get_DBServerName = "127.0.0.1";
	private $get_DBUserName = "root";
	private $get_DBPassword = "";
	private $get_DBName = "db_itp_best_in_docu";

	public function set_DBConnection()
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

	public function set_DBTable()
	{
		global
		$get_Table1, 
		$get_Table2, 
		$get_Table3, 
		$get_Table4, 
		$get_Table5, 
		$get_Table6, 
		$get_Table7, 
		$get_Table8, 
		$get_Table9, 
		$get_Table10;

		$get_Table1 	= "account";
		$get_Table2 	= "";
		$get_Table3 	= "";
		$get_Table4 	= "";
		$get_Table5 	= "";		
		$get_Table6 	= "";
		$get_Table7 	= "";
		$get_Table8 	= "";
		$get_Table9 	= "";
		$get_Table10 	= "";
	}

	public function get_user_information($set_UserName, $set_UserPassword, $set_userSessionID, $set_LoginAction)
	{
		global $get_MySqliConnection, $get_Table1;
		
		$query_Select;
		
		if ($set_LoginAction == 'user_Input')
			$query_Select = "SELECT * FROM $get_Table1 WHERE username = '$set_UserName' AND password = '$set_UserPassword';";

		else if ($set_LoginAction == 'user_Cookie')
			$query_Select = "SELECT * FROM $get_Table1 WHERE user_SessionID = '$set_userSessionID';";			
	

		if ($query_Execute = mysqli_query($get_MySqliConnection, $query_Select))
		{
			$query_RowCount =  mysqli_num_rows($query_Execute);

			if ($query_RowCount == 1)
			{
				$query_Row = mysqli_fetch_array($query_Execute);

				//setcookie('user_Name', $query_Row['user_Name'], time() + (86400 * 30), '/');
				//setcookie('user_Password', $query_Row['user_Password'], time() + (86400 * 30), '/');
				setcookie('user_SessionID', $query_Row['user_SessionID'], time() + (86400 * 30), '/');
				$get_Output = new stdClass();
				$get_Output->message = 'Login Successfully';
				$get_Output->username = $query_Row['username'];
				$get_Output->password = $query_Row['password'];

				echo json_encode($get_Output);

			}

			else
			{
				setcookie('user_SessionID', null, time() + (86400 * 30), '/');

				echo "Please try again";		 
			}
		}

		else
			echo "Failed to execute Query";
	}

}

	$SystemMethods_GeneralSession = new SystemMethods_GeneralSession();

	$SystemMethods_GeneralSession->set_DBConnection();

	$SystemMethods_GeneralSession->set_DBTable();	

	if (isset($_POST['Customer']))
	{
		if ($_POST['Customer'] = "get_user_information")
		{
			$get_LoginAction = $_POST['get_LoginAction'];

			if ($get_LoginAction == 'user_Input')
			{	

				$get_UserName = $_POST['get_UserName'];
				$get_UserPassword = $_POST['get_UserPassword'];

				$SystemMethods_GeneralSession->get_user_information($get_UserName, $get_UserPassword, '', $get_LoginAction);
			}

			if ($get_LoginAction == 'user_Cookie')
			{		

				$get_userSessionID = $_POST['get_userSessionID'];
				$SystemMethods_GeneralSession->get_user_information('', '', $get_userSessionID, $get_LoginAction);
			}
			
		}
	}
?>