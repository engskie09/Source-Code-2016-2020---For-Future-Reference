var get_URL = 'GeneralSession_SystemMethods_JS-PHP';


function select_user_information(set_Action, set_UserID)
{
	var get_Data;

	if (set_Action == 'Sign In')
		get_Data = $('#frm_SignIn').serialize() + '&select_user_information=select_user_information' + '&get_Action=' + set_Action;

	else if (set_Action == 'Select Specific')
		get_Data = 'select_user_information=select_user_information' + '&get_Action=' + set_Action + '&get_UserID=' + set_UserID;

	else if (set_Action == 'Select Count')
		get_Data = 'select_user_information=select_user_information' + '&get_Action=' + set_Action;

	$.ajax({

		url: get_URL + '/SystemMethods_GeneralSession.php',
		type: 'post',
		data: get_Data,
		async: false,

		success: function(set_response)
		{
			if (set_Action == 'Sign In')
			{
				if(set_response.includes('Success : Log In'))
				{	
					window.location.href = "index.html";							
				}

				else if(set_response.includes('Failure : Log In'))
					alert('Try Again');	

				else
					alert(set_response);
			}

			else if (set_Action == 'Select Specific')
			{
				get_Data = set_response;
			}

			else if (set_Action == 'Select Count')
			{
				get_Data = set_response;
			}						
		},

		error: function(set_response)
		{
			alert('Ajax Error!!!');
		}
	});

	return get_Data;
}

function select_attendance_information(set_Action)
{
	var get_Data = $('#frm_SignIn').serialize() + '&select_attendance_information=select_attendance_information' + '&get_Action=' + set_Action;

	$.ajax({

		url: get_URL + '/SystemMethods_GeneralSession.php',
		type: 'post',
		data: get_Data,
		async: false,

		success: function(set_response)
		{		
			if (set_Action == 'check_UserPresence')
			{
				if(set_response.includes('Success : Check In'))
				{	
					alert('You`ve been Check In');						
				}

				else if(set_response.includes('Success : Check Out'))
				{	
					alert('You`ve been Check Out');						
				}

				else if(set_response.includes('Failure : Check Out'))
				{
					alert('You`ve already been Check Out');
				}

				else
					alert('Try Again');
			}

			else if (set_Action == 'Select Count')
			{
				get_Data = set_response
			}	
			
		},

		error: function(set_response)
		{
			alert('Ajax Error!!!');
		}
	});

	return get_Data;
}




function manage_user_information(set_Action)
{
	var get_Data = '';

	if (set_Action == 'insert_user_information')
		get_Data = $('#frm_EmployeeInformation').serialize() + '&insert_user_information=insert_user_information';

	else if (set_Action == 'update_user_information')
		get_Data = $('#frm_EmployeeInformation').serialize() + '&update_user_information=update_user_information';	

	$.ajax({

		url: get_URL + '/SystemMethods_AdminSession.php',
		type: 'post',
		data: get_Data,

		success: function(set_response)
		{		

			if(set_Action == 'insert_user_information')
			{				
				if (set_response.includes('Success : Insert'))
					location.reload();
			}

			else if(set_Action == 'update_user_information')
			{
				if (set_response.includes('Success : Update'))
				{					
					location.reload();
				}
			}			

			
		},

		error: function(set_response)
		{
			alert('Ajax Error!!!');
		}
	});
}


function manage_position_information(set_Action)
{
	var get_Data = '';

		alert(set_Action);
	if (set_Action == 'insert_position_information')
		get_Data = $('#frm_PositionInformation').serialize() + '&insert_position_information=insert_position_information';

	else if (set_Action == 'update_position_information')
		get_Data = $('#frm_PositionInformation').serialize() + '&update_position_information=update_position_information';	

	$.ajax({

		url: get_URL + '/SystemMethods_AdminSession.php',
		type: 'post',
		data: get_Data,

		success: function(set_response)
		{		
			alert(set_response);

			if(set_Action == 'insert_position_information')
			{				
				if (set_response.includes('Success : Insert'))
					location.reload();
			}

			else if(set_Action == 'update_position_information')
			{
				if (set_response.includes('Success : Update'))
				{					
					location.reload();
				}
			}			

			
		},

		error: function(set_response)
		{
			alert('Ajax Error!!!');
		}
	});
}


function manage_rate_information(set_Action)
{
	var get_Data = '';

		alert(set_Action);
	if (set_Action == 'insert_rate_information')
		get_Data = $('#frm_RateInformation').serialize() + '&insert_rate_information=insert_rate_information';

	else if (set_Action == 'update_rate_information')
		get_Data = $('#frm_RateInformation').serialize() + '&update_rate_information=update_rate_information';	

	$.ajax({

		url: get_URL + '/SystemMethods_AdminSession.php',
		type: 'post',
		data: get_Data,

		success: function(set_response)
		{		
			alert(set_response);

			if(set_Action == 'insert_rate_information')
			{				
				if (set_response.includes('Success : Insert'))
					location.reload();
			}

			else if(set_Action == 'update_rate_information')
			{
				if (set_response.includes('Success : Update'))
				{
					location.reload();
				}
			}			

			
		},

		error: function(set_response)
		{
			alert('Ajax Error!!!');
		}
	});
}