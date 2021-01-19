<?php

require_once 'CITACH_Main_Information.php';

class CITACH_User_Information
{
	function Select_User_Information($set_Action, $set_Data)
	{
		global $MySqliConnection, $Table_Name_4, $Table_Name_5;

		if ($set_Data != null)
			$get_Data = json_decode($set_Data, true);

		if ($set_Action == 'Select : All')
			$Query_Select = "SELECT * FROM $Table_Name_4 INNER JOIN $Table_Name_5 ON $Table_Name_4.User_Identity = $Table_Name_5.User_Identity";

		$Query_Row_Array_Value_Total = array();

		if($Query_Execute = mysqli_query($MySqliConnection, $Query_Select))
			while ($Query_Row_Array_Value = mysqli_fetch_array($Query_Execute))
				$Query_Row_Array_Value_Total[] = $Query_Row_Array_Value;

		return json_encode($Query_Row_Array_Value_Total);
	}

	function Insert_User_Credential_Information()
	{
		global $MySqliConnection, $Table_Name_4;

		$Query_Column = '(User_Identity, User_Name, User_Password, User_Privilege)';
		$Query_Value = '("' . $_POST['User_Identity'] . '", "' . $_POST['User_Name'] . '", "' . $_POST['User_Password'] . '", "' . $_POST['User_Privilege'] . '")';

		$Query_Insert = "INSERT INTO $Table_Name_4 $Query_Column VALUES $Query_Value" ;

		if($Query_Execute = mysqli_query($MySqliConnection, $Query_Insert))
			return true;

		else
			return false;
	}

	function Insert_User_Personal_Information()
	{
		global $MySqliConnection, $Table_Name_5;

		$_POST['User_Image_Path'] = '../../Data/User/Image/Image_' . $_POST['User_Identity'] . '.jpeg';

		$Query_Column = '(User_Identity, User_Firstname, User_Middlename, User_Lastname, User_Position, User_Image_Path)';
		$Query_Value = '("' . $_POST['User_Identity'] . '", "' . $_POST['User_Firstname'] . '", "' . $_POST['User_Middlename'] . '", "' . $_POST['User_Lastname'] . '", "' . $_POST['User_Position'] . '", "' . $_POST['User_Image_Path'] . '")';

		$Query_Insert = "INSERT INTO $Table_Name_5 $Query_Column VALUES $Query_Value" ;

		if($Query_Execute = mysqli_query($MySqliConnection, $Query_Insert))
		{
			move_uploaded_file($_FILES['User_Image_Path']['tmp_name'], $_POST['User_Image_Path']);

			return true;
		}

		else
			return false;
	}

	function Update_User_Information()
	{
		echo 'Update_User_Information';
	}

	function Delete_User_Information()
	{
		echo 'Delete_User_Information';
	}
}

$CITACH_User_Information = new CITACH_User_Information();

if(isset($_POST['Action']))
{
	$get_Action = $_POST['Action'];

	if ($get_Action == 'Select_User_Information')
		echo $CITACH_User_Information->Select_User_Information('Select : All', null);

	else if ($get_Action == 'Insert_User_Information')
	{
		$_POST['User_Identity'] = $User_Code . '-' . json_decode($CITACH_Main_Information->Select_Counter_Information('Select : Specific { Counter_Count } : Counter_Code', '{"Counter_Code":"' . $User_Code . '"}'), true)[0]['Counter_Count'];

		$_POST['User_Name'] = '';
		$_POST['User_Password'] = '';
		$_POST['User_Privilege'] = '';

		if($CITACH_User_Information->Insert_User_Credential_Information() && $CITACH_User_Information->Insert_User_Personal_Information())
		{
			$CITACH_Main_Information->Update_Counter_Information('Update : Specific { Counter_Count } : Counter_Code', '{"Counter_Code":"' . $User_Code . '"}');

			echo 'Insert Succeeded';
		}

		else
			echo 'Insert Failed';
	}

	else if ($get_Action == 'Update_User_Information')
		$CITACH_User_Information->Update_User_Information();

	else if ($get_Action == 'Delete_User_Information')
		$CITACH_User_Information->Delete_User_Information();
}
?>