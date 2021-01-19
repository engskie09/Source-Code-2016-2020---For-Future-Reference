//Set a Validation Function for #blog_SignUp Form.
$('#blog_SignUp').validate({
	rules: 
	{
		blogger_UserConfirmPassword:
		{
			equalTo: '#blogger_UserPassword'
		}
	},

	submitHandler: function()
	{
		set_blogger_information();
	}
});

//Set a Validation Function for #blog_SignIn Form.
$('#blog_SignIn').validate({
	rules: 
	{
		blogger_UserConfirmPassword:
		{
			equalTo: '#blogger_UserPassword'
		}
	},

	submitHandler: function()
	{
		get_blogger_information('Login');
	}
});

//Set a Validation Function for #blog_MyAccount Form.
$('#blog_MyAccount').validate({
	rules: 
	{
		blogger_UserConfirmPassword:
		{
			equalTo: '#blogger_UserPassword'
		}
	},

	submitHandler: function()
	{
		update_blogger_information();
	}
});


//Set a Validation Function for #blog_Add Form.
$('#blog_Add').validate({

	submitHandler: function()
	{
		set_blog_information();
	}
});

function SignOut(){

	$.ajax({

		url: 'GeneralSession_SystemAssets_JS-PHP/SystemMethods_GeneralSession.php',
		type: 'POST',
		data: 'set_session=SignOut',

		success: function(response)
		{			
			window.location = 'blog_home.html'
		},

		error: function(response)
		{
			alert('Ajax Error!!!');
		}
	});

};


//Get the value from Client Side #blog_SignUp Form, then Set the value to Server Side using AJAX.
function set_blogger_information()
{

	var get_FormData = $('#blog_SignUp').serialize() + '&set_blogger_information=set_blogger_information';
	
	$.ajax({

		url: 'GeneralSession_SystemAssets_JS-PHP/SystemMethods_GeneralSession.php',
		type: 'POST',
		data: get_FormData,

		success: function(response)
		{
			alert(response);

			if (response == 'Success.')
			{				
				window.location.href = 'blog_home.html';				
			}
			
		},

		error: function(response)
		{
			alert('Ajax Error!!!');
		}
	});
	

}

//Get Blogger information to login.
function get_blogger_information(set_Action)
{	
	var get_FormData;

	if (set_Action == 'Login')
	{
		get_FormData = $('#blog_SignIn').serialize() + '&get_blogger_information=' + set_Action;
			
		$.ajax({

			url: 'GeneralSession_SystemAssets_JS-PHP/SystemMethods_GeneralSession.php',
			type: 'POST',
			data: get_FormData,

			success: function(response)
			{
				alert(response);

				if (response == 'Success.')
				{				
					window.location.href = 'blog_home.html';				
				}				
			},

			error: function(response)
			{
				alert('Ajax Error!!!');
			}
		});		
	}

	else if (set_Action == 'Select-All')
	{

		var get_Data = 'get_blogger_information=' + set_Action;

		$.ajax({

			url: 'GeneralSession_SystemAssets_JS-PHP/SystemMethods_GeneralSession.php',
			type: 'POST',
			data: get_Data,	
			async: false,		

			success: function(response)
			{						
				get_Data = response;						
			},

			error: function(response)
			{
				alert('Ajax Error!!!');				
			}
		});	

		return get_Data;
	}	
}

function update_blogger_information()
{
	var get_FormData = $('#blog_MyAccount').serialize() + '&update_blogger_information=update_blogger_information';
			
		$.ajax({

			url: 'GeneralSession_SystemAssets_JS-PHP/SystemMethods_GeneralSession.php',
			type: 'POST',
			data: get_FormData,

			success: function(response)
			{
				alert(response);

				if (response == 'Success.')
				{				
					window.location.href = 'blog_home.html';				
				}				
			},

			error: function(response)
			{
				alert('Ajax Error!!!');
			}
		});	
}


function set_blog_information()
{

	var get_FormData = $('#blog_Add').serialize() + '&set_blog_information=set_blog_information';
	
	$.ajax({

		url: 'GeneralSession_SystemAssets_JS-PHP/SystemMethods_GeneralSession.php',
		type: 'POST',
		data: get_FormData,

		success: function(response)
		{
			alert(response);

			if (response == 'Success.')
			{				
				window.location.href = 'blog_home.html';				
			}
			
		},

		error: function(response)
		{
			alert('Ajax Error!!!');
		}
	});

}

function get_blog_information(set_Action, set_SelectedPage)
{
	var get_Data = "get_blog_information=get_blog_information" + "&get_Action=" + set_Action + "&get_SelectedPage=" + set_SelectedPage;

	$.ajax({

		url: 'GeneralSession_SystemAssets_JS-PHP/SystemMethods_GeneralSession.php',
		type: 'POST',
		data: get_Data,
		async: false,

		success: function(response)
		{
			//alert(response);
			get_Data = response;									
		},

		error: function(response)
		{
			alert('Ajax Error!!!');
		}
	});
	
	return get_Data;
}

function get_blog_information_summary()
{
	var get_Data = "get_blog_information_summary=get_blog_information_summary";

	$.ajax({

		url: 'GeneralSession_SystemAssets_JS-PHP/SystemMethods_GeneralSession.php',
		type: 'POST',
		data: get_Data,
		async: false,

		success: function(response)
		{			
			get_Data = response;									
		},

		error: function(response)
		{
			alert('Ajax Error!!!');
		}
	});	

	return get_Data;
}

function update_blog_information(set_ControlID)
{	
	var get_FormData = $('#blog_Add').serialize() + '&update_blog_information=update_blog_information';

	$.ajax({

		url: 'GeneralSession_SystemAssets_JS-PHP/SystemMethods_GeneralSession.php',
		type: 'POST',
		data: get_Data,

		success: function(response)
		{			
			alert('Success.');								
		},

		error: function(response)
		{
			alert('Ajax Error!!!');
		}
	});	

}

function get_current_page(set_ControlID)
{
	var get_Data = "get_current_page=get_current_page";

	$.ajax({

		url: 'GeneralSession_SystemAssets_JS-PHP/SystemMethods_GeneralSession.php',
		type: 'POST',
		data: get_Data,
		async: false,

		success: function(response)
		{			
			get_Data = response;									
		},

		error: function(response)
		{
			alert('Ajax Error!!!');
		}
	});	

	return get_Data;
}