function set_ButtonClick()
{
	$('#btn_SignIn').click(function()
	{
		get_user_information('user_Input');
	});

	$('.btn_SignOut').click(function()
	{
		set_UserSignOut();
	});

	$('.btn_DashBoard').click(function()
	{
		alert('DashBoard');
		window.location = get_DomainName + 'SystemSession_Admin/AdminSession_Dashboard.html';
	});

}

function get_currentButton(control, set_CurrentControl)
{	
	if (set_CurrentControl == 'btn_SignInRetry')
	{
		set_ModalShowHide('modal_MessageBox', 'modal_SignIn');
	}	
}

function get_user_information(set_LoginAction)
{
	var get_Form = $('#form_SignIn');
	var get_FormData = get_Form.serialize();

	var get_Data;
	var get_IntervalSequence;

	if (set_LoginAction == 'user_Input')
	{
		get_Data = get_FormData + '&get_LoginAction=' + set_LoginAction +  '&Customer=get_user_information';
		get_IntervalSequence = 1500;
		set_Loading('modal_SignIn');
	}

	else if (set_LoginAction == 'user_Cookie')
	{		
		get_Data = 'get_userSessionID=' + $.cookie('user_SessionID') + '&get_LoginAction=' + set_LoginAction + '&Customer=get_user_information';
		get_IntervalSequence = 100;		
	}

	else
		return false;	

	var get_Interval = setInterval(function()
	{		
		$.ajax({

			url: 'GeneralSession_SystemMethods_PHP,JS/SystemMethods_GeneralSession.php',
			type: 'POST',
			data: get_Data,

			success: function(response)
			{								
				if (response.includes('Login Successfully'))
				{		

					if (set_LoginAction == 'user_Input')
					{
						set_MessageBox('', response, '', '');
						window.location = window.location.pathname;
					}

					var get_JSON = JSON.parse(response);

					set_Controls('Active', get_JSON.username);

						
				}

				else if (response.includes('Please try again'))
				{
					set_MessageBox('', response, 'btn_SignInRetry', 'get_currentButton(this, this.id);');					
				}

				else if (response.includes('Failed to execute Query'))
				{
					set_MessageBox('', response, 'btn_SignInRetry', 'get_currentButton(this, this.id);');					
				}

				else
					set_MessageBox('', 'Error: get_user_information();', 'btn_SignInRetry', 'get_currentButton(this, this.id);');	
					

				clearInterval(get_Interval);				
				
			},

			error: function()
			{				
				set_MessageBox('', 'Cannot connect to the server!!!', '', '');
				clearInterval(get_Interval);
			}
		
		});	

	}, get_IntervalSequence);	
}

function set_UserSignOut()
{
	set_Loading('');

	var get_Timeout = setTimeout(function()
	{
		$.cookie('user_SessionID', null, {path: '/'});
		window.location = window.location.pathname;

	}, 1500);
	
}