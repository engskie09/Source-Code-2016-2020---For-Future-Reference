<?php	

	/* Code By Rafael Nobleza Masallo :> */

	date_default_timezone_set('Asia/Manila');

	$SystemMethods_GeneralSession = new SystemMethods_GeneralSession;

	$SystemMethods_GeneralSession->set_Database_Connection();
	$SystemMethods_GeneralSession->set_Table_Name();

	if (isset($_POST['get_Current_DateTime']))
	{	
		if ($_POST['get_Current_DateTime'] == 'get_Current_DateTime')
			$SystemMethods_GeneralSession->get_Current_DateTime();
	}

	if (isset($_POST['set_user_session']))
	{
		session_start();	

		if (isset($_POST['get_Action']))
		{
			if ($_POST['get_Action'] == 'SignOut')
			{
				session_destroy();
				echo 'Success : SignOut';
				exit();
			}
		}			


		else if (isset($_SESSION['get_UserID']))
		{
			$get_UserInformation = new stdClass();
			$get_UserInformation->get_UserID = $_SESSION['get_UserID'];
			$get_UserInformation->get_UserName = $_SESSION['get_UserName'];

			echo json_encode($get_UserInformation);	
		}

		else
			echo 'No Session';

	}

	class SystemMethods_GeneralSession
	{
		private $get_DBServerName = "127.0.0.1";
		private $get_DBUserName = "root";
		private $get_DBPassword = "";
		private $get_DBName = "db_payroll";

		public function set_Database_Connection()
		{
			global $get_MySqliConnection;

			$get_MySqliConnection = mysqli_connect($this->get_DBServerName, $this->get_DBUserName, $this->get_DBPassword, $this->get_DBName);

			if (mysqli_connect_errno())
			{
				/*echo "<script>alert ('Cannot connect to " . $this->get_DBServerName . "') </script>";*/
				/*echo mysqli_connect_error();*/
				exit();
			}

			else
			{
				/*echo "<script>alert ('Successfully Connected to " . $this->get_DBServerName . "') </script>";*/
			}
		}

		public function set_Table_Name()
		{
			global $tbl_Name1, $tbl_Name2, $tbl_Name3, $tbl_Name4, $tbl_Name5, $tbl_Name6;

			$tbl_Name1 = 'tbl_user_information_credential';
			$tbl_Name2 = 'tbl_user_information_personal';
			$tbl_Name3 = 'tbl_attendance_information_current';
			$tbl_Name4 = 'tbl_attendance_information_report';
			$tbl_Name5 = 'tbl_position_information';
			$tbl_Name6 = 'tbl_rate_information';
		}

		public function get_Current_DateTime()
		{		
			$get_DateTime = new stdClass();
			$get_DateTime->set_CurrentDate = date('Y-m-d');
			$get_DateTime->set_CurrentTime = date('H:i:s');

			echo json_encode($get_DateTime);
		}

		public function select_user_information($set_Action, $set_UserID, $set_UserName, $set_UserPassword)
		{
			global $get_MySqliConnection, $tbl_Name1, $tbl_Name2;

			if ($set_Action == 'Sign In')
			{
				$query_Select = "SELECT * FROM $tbl_Name1 WHERE user_Name = '$set_UserName' AND user_Password = '$set_UserPassword';";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				if ($query_Execute)
				{
					$query_Rows = mysqli_num_rows($query_Execute);

					if ($query_Rows == 1)
					{
						$query_Row = mysqli_fetch_array($query_Execute);

						session_start();

						$_SESSION['get_UserID'] = $query_Row['user_ID'];
						$_SESSION['get_UserName'] = $query_Row['user_Name'];

						echo 'Success : Log In';					
					}

					else
					{
						echo 'Failure : Log In';
						exit();
					}
				}
				else
					echo mysqli_error($query_Execute);
			}

			else if ($set_Action == 'Select All')
			{					
				$query_Select = "SELECT user_ID, CONCAT(user_FirstName, ' ', user_MiddleName, ' ', user_LastName) AS user_FullName , user_Position, user_ContactNumber FROM $tbl_Name2;";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				$query_Array = array();

				while ($query_Row = mysqli_fetch_array($query_Execute))
				{
					
					$get_Button = "
					<div class='form-group center'>					
						<button type='button' class='btn btn-dark' style=' width: 10em;' ng-click='Show_frm_EmployeeInformation_update(\"".$query_Row['user_ID']."\")'>View/Update</button>
						<button type='button' class='btn btn-dark' style=' width: 5em;' ng-click='delete_user_information(\"".$query_Row['user_ID']."\")'>Delete</button>
					</div>";
										
					$query_Array[] = $query_Row + ['user_Action' => $get_Button];
						

				}

				echo json_encode($query_Array);
			}

			else if ($set_Action == 'Select Specific')
			{
				$query_Select = "SELECT * FROM $tbl_Name1 INNER JOIN $tbl_Name2 ON $tbl_Name1.user_ID = $tbl_Name2.user_ID WHERE $tbl_Name1.user_ID = '$set_UserID';";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				$query_Array = array();
				
				if ($query_Row = mysqli_fetch_array($query_Execute))
				{
					$query_Array[] = $query_Row;
					echo json_encode($query_Array);
				}

				else
					echo mysqli_error($query_Execute);
							
			}

			else if ($set_Action == 'Select Count')
			{
				$query_Select = "SELECT COUNT(*) FROM $tbl_Name1;";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				if ($query_Row = mysqli_fetch_array($query_Execute))
				{
					$query_Array[] = $query_Row;
					echo json_encode($query_Array);
				}

				else
					echo mysqli_error($query_Execute);
			}			
		}

		public function select_attendance_information($set_Action, $set_UserID)
		{
			global $get_MySqliConnection, $tbl_Name1, $tbl_Name2, $tbl_Name3;			
			
			if ($set_Action == 'check_UserPresence')
			{
				$query_Select = "SELECT * FROM $tbl_Name3 WHERE user_ID = '$set_UserID' AND attendance_Date = '" . date('Y-m-d') . "';";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				if ($query_Execute)
				{
					$query_Rows = mysqli_num_rows($query_Execute);

					$get_CurrentDate = date('Y-m-d');
					$get_CurrentTime = date('H:i:s');

					if ($query_Rows == 0)
					{
						$get_AttendanceID = 'ATDC-'. date('Y-m-d') . '-' . mt_rand(100000, 999999);

						$query_Select = "SELECT attendance_ID FROM $tbl_Name3 WHERE attendance_ID = '$get_AttendanceID';";

						$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);
						
						$query_Rows = mysqli_num_rows($query_Execute);

						while ($query_Rows == 1)
						{
							$this->get_AttendanceID;
							$this->query_Select;
							$this->query_Execute;
							$this->query_Rows;		
							
							if ($query_Rows == 0)
							{								
								break;			
							}
						}

						$this->insert_attendance_information('Check In', $get_AttendanceID, $get_CurrentTime, $get_CurrentDate, $set_UserID);						

					}

					else
					{
						$this->insert_attendance_information('Check Out', '', $get_CurrentTime, $get_CurrentDate, $set_UserID);	
					}
				}

				else
					echo mysqli_error($query_Execute);
			}
			
			else if ($set_Action == 'Select All')
			{
				$query_Column = "$tbl_Name3.attendance_TimeIn, $tbl_Name3.attendance_TimeOut, CONCAT($tbl_Name2.user_FirstName, ' ', $tbl_Name2.user_MiddleName, ' ',$tbl_Name2.user_LastName) AS 'user_FullName', SUBSTRING(SUBTIME(TIMEDIFF($tbl_Name3.attendance_TimeOut, $tbl_Name3.attendance_TimeIn), '08:00:00'), 1, 8) AS 'attendance_OverTime'";			

				$query_Select = "SELECT $query_Column FROM $tbl_Name3 INNER JOIN $tbl_Name2 ON $tbl_Name3.user_ID = $tbl_Name2.user_ID;" ;	

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				$query_Array = array();

				while ($query_Row = mysqli_fetch_array($query_Execute))
				{
					$query_Array[] = $query_Row;
				}

				echo json_encode($query_Array);
			}

			else if ($set_Action == "Select Count")
			{
				$query_Select = "SELECT * FROM $tbl_Name3";	

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				if ($query_Execute)
				{
					$query_Rows = mysqli_num_rows($query_Execute);

					$query_Output = new stdClass();
					$query_Output->get_TotalEmployee_PresentWork = $query_Rows;

					echo json_encode($query_Output);
				}

				else
					echo mysqli_error($query_Execute);			


			}

			

		}

		public function insert_attendance_information($set_Action, $set_AttendanceID, $set_CurrentTime, $set_CurrentDate, $set_UserID)
		{
			global $get_MySqliConnection, $tbl_Name3, $tbl_Name4;
			
			if ($set_Action == 'Check In')
			{
				$query_Column = "(attendance_ID, attendance_TimeIn, attendance_TimeOut, attendance_Date, user_ID)";

				$query_Value = "('$set_AttendanceID', '$set_CurrentTime', NULL, '$set_CurrentDate', '$set_UserID')";

				$query_Insert = "INSERT INTO $tbl_Name3 $query_Column VALUES $query_Value;"
							.	"INSERT INTO $tbl_Name4 $query_Column VALUES $query_Value;";

				$query_Execute = mysqli_multi_query($get_MySqliConnection, $query_Insert);

				if ($query_Execute)									
					echo "Success : Check In";

				else
					echo mysqli_error($query_Execute);
			}

			else
			{
				$query_Select = "SELECT * FROM $tbl_Name3 WHERE attendance_TimeOut IS NULL AND user_ID = '$set_UserID'";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				if ($query_Execute)	
				{
					$query_Rows = mysqli_num_rows($query_Execute);
				
					if ($query_Rows == 0)
					{
						echo "Failure : Check Out";

						session_destroy();
					
						exit();
					}

					$query_Update = "UPDATE $tbl_Name3 SET attendance_TimeOut = '$set_CurrentTime' WHERE user_ID = '$set_UserID';"
								.	"UPDATE $tbl_Name4 SET attendance_TimeOut = '$set_CurrentTime' WHERE user_ID = '$set_UserID';";	

					$query_Execute = mysqli_multi_query($get_MySqliConnection, $query_Update);

					if ($query_Execute)				
						echo "Success : Check Out";

					else
						echo mysqli_error($query_Execute);
				}	

				else
					echo mysqli_error($query_Execute);		

				
			}
		}

		public function select_position_information($set_Action, $set_PositionID)
		{
			global $get_MySqliConnection, $tbl_Name5;

			if ($set_Action == 'Select All')
			{
				$query_Select = "SELECT * FROM $tbl_Name5;";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				$query_Array = array();

				while ($query_Row = mysqli_fetch_array($query_Execute))
				{
					
					$get_Button = "
					<div class='form-group center'>					
						<button type='button' class='btn btn-dark' style=' width: 10em;' ng-click='Show_frm_PositionInformation_update(\"".$query_Row['position_ID']."\")'>View/Update</button>
						<button type='button' class='btn btn-dark' style=' width: 5em;' ng-click='delete_position_information(\"".$query_Row['position_ID']."\")'>Delete</button>
					</div>";
										
					$query_Array[] = $query_Row + ['position_Action' => $get_Button];
						

				}

				echo json_encode($query_Array);
			}

			else if ($set_Action == 'Select Specific')
			{
				$query_Select = "SELECT * FROM $tbl_Name5 WHERE position_ID = '$set_PositionID';";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				$query_Array = array();
				
				if ($query_Row = mysqli_fetch_array($query_Execute))
				{
					$query_Array[] = $query_Row;
					echo json_encode($query_Array);
				}

				else
					echo mysqli_error($query_Execute);
							
			}
		}


		public function select_rate_information($set_Action, $set_RateID)
		{
			global $get_MySqliConnection, $tbl_Name6;

			if ($set_Action == 'Select All')
			{
				$query_Select = "SELECT * FROM $tbl_Name6;";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				$query_Array = array();

				while ($query_Row = mysqli_fetch_array($query_Execute))
				{
					
					$get_Button = "
					<div class='form-group center'>					
						<button type='button' class='btn btn-dark' style=' width: 10em;' ng-click='Show_frm_RateInformation_update(\"".$query_Row['rate_ID']."\")'>View/Update</button>
						<button type='button' class='btn btn-dark' style=' width: 5em;' ng-click='delete_rate_information(\"".$query_Row['rate_ID']."\")'>Delete</button>
					</div>";
										
					$query_Array[] = $query_Row + ['rate_Action' => $get_Button];
						

				}

				echo json_encode($query_Array);
			}

			else if ($set_Action == 'Select Specific')
			{
				$query_Select = "SELECT * FROM $tbl_Name6 WHERE rate_ID = '$set_RateID';";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);

				$query_Array = array();
				
				if ($query_Row = mysqli_fetch_array($query_Execute))
				{
					$query_Array[] = $query_Row;
					echo json_encode($query_Array);
				}

				else
					echo mysqli_error($query_Execute);
							
			}
		}

		

	}

	

	if (isset($_POST['select_user_information']))
	{
		$get_Action = $_POST['get_Action'];

		if ($get_Action == 'Sign In')
		{
			$get_UserName = $_POST['get_UserName'];
			$get_UserPassword = $_POST['get_UserPassword'];

			$SystemMethods_GeneralSession->select_user_information($get_Action, '', $get_UserName, $get_UserPassword);
		}

		else if ($get_Action == 'Select All')
		{
			$SystemMethods_GeneralSession->select_user_information($get_Action, '', '', '');			
		}

		else if ($get_Action == 'Select Specific')
		{
			$get_UserID = $_POST['get_UserID'];
			$SystemMethods_GeneralSession->select_user_information($get_Action, $get_UserID, '', '');			
		}

		else if ($get_Action == 'Select Count')
		{	

			$SystemMethods_GeneralSession->select_user_information($get_Action, '', '', '');			
		}
		
	}

	if (isset($_POST['select_attendance_information']))
	{		

		$get_Action = $_POST['get_Action'];

		if ($_POST['get_Action'] == 'check_UserPresence')
		{
			$get_Action = 'Sign In';

			$get_UserName = $_POST['get_UserName'];
			$get_UserPassword = $_POST['get_UserPassword'];

			$SystemMethods_GeneralSession->select_user_information($get_Action, '', $get_UserName, $get_UserPassword);

			$get_UserID = $_SESSION['get_UserID'];
			$get_Action = $_POST['get_Action'];		

			$SystemMethods_GeneralSession->select_attendance_information($get_Action, $get_UserID);

			session_destroy();
		}

		else if ($_POST['get_Action'] == 'Select Count')
		{
			$SystemMethods_GeneralSession->select_attendance_information($get_Action, '');
		}
	}	

	if (isset($_POST['select_position_information']))
	{
		$get_Action = $_POST['get_Action'];
		$get_PositionID = $_POST['get_PositionID'];

		$SystemMethods_GeneralSession->select_position_information($get_Action, $get_PositionID);
	}

	if (isset($_POST['select_rate_information']))
	{
		$get_Action = $_POST['get_Action'];
		$get_RateID = $_POST['get_RateID'];

		$SystemMethods_GeneralSession->select_rate_information($get_Action, $get_RateID);
	}


	

	if (isset($_GET['select_attendance_information']))
	{	
		if ($_GET['select_attendance_information'] == 'select_attendance_information')
			$SystemMethods_GeneralSession->select_attendance_information('Select All', '');
	}

	if (isset($_GET['select_user_information']))
	{	
		if ($_GET['select_user_information'] == 'select_user_information')
			$SystemMethods_GeneralSession->select_user_information('Select All', '', '', '');
	}

	if (isset($_GET['select_position_information']))
	{	
		if ($_GET['select_position_information'] == 'select_position_information')
			$SystemMethods_GeneralSession->select_position_information('Select All', '');
	}

	if (isset($_GET['select_rate_information']))
	{	
		if ($_GET['select_rate_information'] == 'select_rate_information')
			$SystemMethods_GeneralSession->select_rate_information('Select All', '');
	}

	
		
?>					