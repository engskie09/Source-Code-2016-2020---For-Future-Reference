<?php

date_default_timezone_set('Asia/Manila');

$User_Code = 'USR';

class CITACH_Main_Information
{
	function set_MySQLConnection()
	{
		global $MySqliConnection;

		$MySqliConnection =  mysqli_connect('localhost', 'root', '', 'db_citach');

		if(mysqli_connect_errno())
		{
			//echo '<script>alert ('Connection Error');</script>'.mysqli_connect_error();
			echo 'Error Connection'.mysqli_connect_error();
		}

		else
		{
			//echo '<script>alert ('Connection Successsss!!');</script>';
			//echo 'Successful Connection';
		}
	}

	function set_Table_Name()
	{
		global
		$Table_Name_1,
		$Table_Name_2,
		$Table_Name_3,
		$Table_Name_4,
		$Table_Name_5;

		$Table_Name_1 = 'tbl_counter_information';
		$Table_Name_2 = 'tbl_church_information';
		$Table_Name_3 = 'tbl_announcement_information';
		$Table_Name_4 = 'tbl_user_credential_information';
		$Table_Name_5 = 'tbl_user_personal_information';
	}

	function Select_Counter_Information($set_Action, $set_Data)
	{
		global $MySqliConnection, $Table_Name_1;

		$get_Data = json_decode($set_Data, true);

		if ($set_Action == 'Select : All')
			$Query_Select = "SELECT * FROM $Table_Name_1";

		else if ($set_Action == 'Select : Specific { Counter_Count } : Counter_Code')
			$Query_Select = "SELECT Counter_Count FROM $Table_Name_1 WHERE Counter_Code = '" . $get_Data["Counter_Code"] . "'";

		if($Query_Execute = mysqli_query($MySqliConnection, $Query_Select))
		{
			if ($set_Action == 'Select : All')
				while ($Query_Row_Array_Value = mysqli_fetch_array($Query_Execute))
					$Query_Row_Array_Value_Total[] = $Query_Row_Array_Value;
			
			else if ($set_Action == 'Select : Specific { Counter_Count } : Counter_Code')
				$Query_Row_Array_Value_Total[] = mysqli_fetch_array($Query_Execute);

			return json_encode($Query_Row_Array_Value_Total);
		}

		else
			return  'Failed Query Execution';
	}

	function Update_Counter_Information($set_Action, $set_Data)
	{
		global $MySqliConnection, $Table_Name_1;

		if ($set_Data != null)
			$get_Data = json_decode($set_Data, true);

		if ($set_Action == 'Update : Specific { Counter_Count } : Counter_Code')
			$Query_Update = "UPDATE $Table_Name_1 SET Counter_Count  = Counter_Count + 1 WHERE Counter_Code = '" . $get_Data['Counter_Code'] . "'";

		if($Query_Execute = mysqli_query($MySqliConnection, $Query_Update))
			return true;
	}
}

$CITACH_Main_Information = new CITACH_Main_Information();

$CITACH_Main_Information->set_MySQLConnection();
$CITACH_Main_Information->set_Table_Name();

//$CITACH_Main_Information->Select_Counter_Information('Select : Specific { Counter_Count } : Counter_Code', $User_Code);

//$CITACH_Main_Information->Update_Counter_Information($User_Code);
?>