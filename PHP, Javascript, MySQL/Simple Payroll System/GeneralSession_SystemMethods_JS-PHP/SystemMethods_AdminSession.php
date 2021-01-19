<?php

	require 'SystemMethods_GeneralSession.php';
	$SystemMethods_AdminSession = new SystemMethods_AdminSession;
	
	class SystemMethods_AdminSession
	{
		public function insert_user_information($set_UserName, $set_UserPassword, $set_UserFirstName, $set_UserMiddleName, $set_UserLastName, $set_UserPosition, $set_UserContactNumber)
		{
			global $get_MySqliConnection, $tbl_Name1, $tbl_Name2;

			$get_UserID = 'USER-'. date('Y-m-d') . '-' . mt_rand(100000, 999999);

			$query_Select = "SELECT user_ID FROM $tbl_Name1 WHERE user_ID = '$get_UserID';";

			$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);
			
			$query_Rows = mysqli_num_rows($query_Execute);

			while ($query_Rows == 1)
			{
				$this->get_UserID;
				$this->query_Select;
				$this->query_Execute;
				$this->query_Rows;		
				
				if ($query_Rows == 0)
				{								
					break;			
				}
			}

			$query_Column = "(user_ID, user_Name, user_Password)";

			$query_Value = "('$get_UserID', '$set_UserName', '$set_UserPassword')";

			$query_Insert = "INSERT INTO $tbl_Name1 $query_Column VALUES $query_Value;";

			$query_Execute = mysqli_query($get_MySqliConnection, $query_Insert);

			if ($query_Execute)
			{
				$query_Column = "(user_ID, user_FirstName, user_MiddleName, user_LastName, user_Position, user_ContactNumber)";

				$query_Value = "('$get_UserID', '$set_UserFirstName', '$set_UserMiddleName', '$set_UserLastName', '$set_UserPosition', '$set_UserContactNumber')";

				$query_Insert = "INSERT INTO $tbl_Name2 $query_Column VALUES $query_Value;";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Insert);

				if ($query_Execute)
				{
					echo "Success : Insert";
				}

				else
					echo mysqli_error($query_Execute);

			}

			else
				echo mysqli_error($query_Execute);
		}

		public function update_user_information($set_userID, $set_UserPassword, $set_UserFirstName, $set_UserMiddleName, $set_UserLastName, $set_UserPosition, $set_UserContactNumber)
		{
			global $get_MySqliConnection, $tbl_Name1, $tbl_Name2;

			$query_Update = "UPDATE $tbl_Name1 SET user_Password = '$set_UserPassword' WHERE user_ID = '$set_userID';";

			$query_Execute = mysqli_query($get_MySqliConnection, $query_Update);

			if ($query_Execute)
			{
				$query_Update = "UPDATE $tbl_Name2 SET user_FirstName = '$set_UserFirstName', user_MiddleName = '$set_UserMiddleName', user_LastName = '$set_UserLastName',  user_Position = '$set_UserPosition', user_ContactNumber = '$set_UserContactNumber' WHERE user_ID = '$set_userID';";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Update);

				if ($query_Execute)
				{
					echo "Success : Update";
				}

				else
					echo mysqli_error($query_Execute);

			}

			else
				echo mysqli_error($query_Execute);
		}

		public function delete_user_information($set_userID)
		{
			global $get_MySqliConnection, $tbl_Name1, $tbl_Name2;

			$query_Delete = "DELETE FROM $tbl_Name1 WHERE user_ID = '$set_userID';";

			$query_Execute = mysqli_query($get_MySqliConnection, $query_Delete);

			if ($query_Execute)
			{
				$query_Delete = "DELETE FROM $tbl_Name2 WHERE user_ID = '$set_userID';";

				$query_Execute = mysqli_query($get_MySqliConnection, $query_Delete);

				if ($query_Execute)
				{
					echo "Success : Delete";
				}

				else
					echo mysqli_error($query_Execute);
			}

			else
				echo mysqli_error($query_Execute);

		}

		public function delete_attendance_information()
		{
			global $get_MySqliConnection, $tbl_Name3;

			$query_Delete = "DELETE FROM $tbl_Name3";
			$query_Execute = mysqli_query($get_MySqliConnection, $query_Delete);

			if ($query_Execute)
				echo "Success : Reset Daily Attendance";

			else
				echo mysqli_error($query_Execute);
		}

		public function insert_position_information($set_PositionName, $set_PositionDescription, $set_RateID)
		{
			global $get_MySqliConnection, $tbl_Name5;

			$get_PositionID = 'PSTN-'. date('Y-m-d') . '-' . mt_rand(100000, 999999);

			$query_Select = "SELECT position_ID FROM $tbl_Name5 WHERE position_ID = '$get_PositionID';";

			$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);
			
			$query_Rows = mysqli_num_rows($query_Execute);

			while ($query_Rows == 1)
			{
				$this->get_PositionID;
				$this->query_Select;
				$this->query_Execute;
				$this->query_Rows;		
				
				if ($query_Rows == 0)
				{								
					break;			
				}
			}

			$query_Column = "(position_ID, position_Name, position_Description, rate_ID)";

			$query_Value = "('$get_PositionID', '$set_PositionName', '$set_PositionDescription', '$set_RateID')";

			$query_Insert = "INSERT INTO $tbl_Name5 $query_Column VALUES $query_Value;";

			$query_Execute = mysqli_query($get_MySqliConnection, $query_Insert);

			if ($query_Execute)
			{
				echo "Success : Insert";
			}

			else
				echo mysqli_error($query_Execute);
		}

		public function update_position_information($set_PositionID, $set_PositionName, $set_PositionDescription, $set_RateID)
		{
			global $get_MySqliConnection, $tbl_Name5;
		
			$query_Update = "UPDATE $tbl_Name5 SET position_Name = '$set_PositionName', position_Description = '$set_PositionDescription', rate_ID = '$set_RateID' WHERE position_ID = '$set_PositionID';";

			$query_Execute = mysqli_query($get_MySqliConnection, $query_Update);

			if ($query_Execute)
			{
				echo "Success : Update";
			}

			else
				echo mysqli_error($query_Execute);			
		}

		public function delete_position_information($set_PositionID)
		{
			global $get_MySqliConnection, $tbl_Name5;

			$query_Delete = "DELETE FROM $tbl_Name5 WHERE position_ID = '$set_PositionID'";
			$query_Execute = mysqli_query($get_MySqliConnection, $query_Delete);

			if ($query_Execute)
				echo "Success : Delete";

			else
				echo mysqli_error($query_Execute);
		}

		public function insert_rate_information($set_RateValue)
		{
			global $get_MySqliConnection, $tbl_Name6;

			$get_RateID = 'RT-'. date('Y-m-d') . '-' . mt_rand(100000, 999999);

			$query_Select = "SELECT rate_ID FROM $tbl_Name6 WHERE rate_ID = '$get_RateID';";

			$query_Execute = mysqli_query($get_MySqliConnection, $query_Select);
			
			$query_Rows = mysqli_num_rows($query_Execute);

			while ($query_Rows == 1)
			{
				$this->get_RateID;
				$this->query_Select;
				$this->query_Execute;
				$this->query_Rows;		
				
				if ($query_Rows == 0)
				{								
					break;			
				}
			}

			$query_Column = "(rate_ID, rate_Value)";

			$query_Value = "('$get_RateID', '$set_RateValue')";

			$query_Insert = "INSERT INTO $tbl_Name6 $query_Column VALUES $query_Value;";

			$query_Execute = mysqli_query($get_MySqliConnection, $query_Insert);

			if ($query_Execute)
			{
				echo "Success : Insert";
			}

			else
				echo mysqli_error($query_Execute);
		}

		public function update_rate_information($set_RateID, $set_RateValue)
		{
			global $get_MySqliConnection, $tbl_Name6;
			
			$query_Update = "UPDATE $tbl_Name6 SET rate_Value = '$set_RateValue' WHERE rate_ID = '$set_RateID';";

			$query_Execute = mysqli_query($get_MySqliConnection, $query_Update);

			if ($query_Execute)
			{
				echo "Success : Update";
			}

			else
				echo mysqli_error($query_Execute);			
		}

		public function delete_rate_information($set_RateID)
		{
			global $get_MySqliConnection, $tbl_Name6;

			$query_Delete = "DELETE FROM $tbl_Name6 WHERE rate_ID = '$set_RateID'";
			$query_Execute = mysqli_query($get_MySqliConnection, $query_Delete);

			if ($query_Execute)
				echo "Success : Delete";

			else
				echo mysqli_error($query_Execute);
		}
	}

	if (isset($_POST['insert_user_information']))
	{
		$get_UserName 			= $_POST['get_UserName'];
		$get_UserPassword 		= $_POST['get_UserPassword'];
		$get_UserFirstName 		= $_POST['get_UserFirstName'];
		$get_UserMiddleName 	= $_POST['get_UserMiddleName'];
		$get_UserLastName 		= $_POST['get_UserLastName'];
		$get_UserPosition 		= $_POST['get_UserPosition'];
		$get_UserContactNumber 	= $_POST['get_UserContactNumber'];

		$SystemMethods_AdminSession->insert_user_information($get_UserName, $get_UserPassword, $get_UserFirstName, $get_UserMiddleName, $get_UserLastName, $get_UserPosition, $get_UserContactNumber);
	}

	if (isset($_POST['update_user_information']))
	{
		$get_UserID 			= $_POST['get_UserID'];
		$get_UserPassword 		= $_POST['get_UserPassword'];
		$get_UserFirstName 		= $_POST['get_UserFirstName'];
		$get_UserMiddleName 	= $_POST['get_UserMiddleName'];
		$get_UserLastName 		= $_POST['get_UserLastName'];
		$get_UserPosition 		= $_POST['get_UserPosition'];
		$get_UserContactNumber 	= $_POST['get_UserContactNumber'];

		$SystemMethods_AdminSession->update_user_information($get_UserID, $get_UserPassword, $get_UserFirstName, $get_UserMiddleName, $get_UserLastName, $get_UserPosition, $get_UserContactNumber);
	}

	if (isset($_POST['delete_user_information']))
	{
		$get_UserID = $_POST['get_UserID'];
		$SystemMethods_AdminSession->delete_user_information($get_UserID);
	}

	if (isset($_POST['delete_attendance_information']))
	{	
		$SystemMethods_AdminSession->delete_attendance_information();
	}

	/* POSITION */

	if (isset($_POST['insert_position_information']))
	{		 
		$get_PositionName = $_POST['get_PositionName']; 
		$get_PositionDescription = $_POST['get_PositionDescription'];
		$get_RateID = $_POST['get_RateID_position'];

		$SystemMethods_AdminSession->insert_position_information($get_PositionName, $get_PositionDescription, $get_RateID);
	}

	if (isset($_POST['update_position_information']))
	{	
		$get_PositionID = $_POST['get_PositionID']; 
		$get_PositionName = $_POST['get_PositionName']; 
		$get_PositionDescription = $_POST['get_PositionDescription'];
		$get_RateID = $_POST['get_RateID_position'];

		$SystemMethods_AdminSession->update_position_information($get_PositionID, $get_PositionName, $get_PositionDescription, $get_RateID);
	}

	if (isset($_POST['delete_position_information']))
	{	
		$get_PositionID = $_POST['get_PositionID'];
		
		$SystemMethods_AdminSession->delete_position_information($get_PositionID);
	}

	/* RATE */

	if (isset($_POST['insert_rate_information']))
	{
		
		$get_RateValue = $_POST['get_RateValue'];

		$SystemMethods_AdminSession->insert_rate_information($get_RateValue);
	}

	if (isset($_POST['update_rate_information']))
	{	
		$get_RateID = $_POST['get_RateID'];
		$get_RateValue = $_POST['get_RateValue'];
		
		$SystemMethods_AdminSession->update_rate_information($get_RateID, $get_RateValue);
	}

	if (isset($_POST['delete_rate_information']))
	{
		$get_RateID = $_POST['get_RateID'];
		$SystemMethods_AdminSession->delete_rate_information($get_RateID);
	}

	



?>