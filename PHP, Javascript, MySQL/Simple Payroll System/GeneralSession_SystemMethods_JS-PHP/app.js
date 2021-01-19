
const app = angular.module('app', ['ngRoute']);


app.config(function($routeProvider)
{
	$routeProvider
	.when('/Dashboard', 
		{
			templateUrl: 'views/Dashboard.html', 
			controller: 'app_Controller' 
		})

	.when('/Manage_Attendance', 
		{
			templateUrl: 'views/Manage_Attendance.html', 
			controller: 'app_Controller' 
		})

	.when('/Manage_Employee', 
		{
			templateUrl: 'views/Manage_Employee.html', 
			controller: 'app_Controller' 
		})

	.when('/Manage_PositionRate', 
		{
			templateUrl: 'views/Manage_PositionRate.html', 
			controller: 'app_Controller' 
		})

	.when('/Manage_MyAccount', 
		{ 
			templateUrl: 'views/Manage_MyAccount.html', 
			controller: 'app_Controller' 
		})

	.when('/view_base', 
		{ 
			templateUrl: 'views/view_base.html', 
			controller: 'app_Controller' 
		})

	.otherwise(
		{
			redirectTo: '/Dashboard'
		});

});

app.controller('app_Controller', ['$scope', '$compile', function($scope, $compile)
{
	/*----------------------------Manage General------------------------------------------*/
	/*----------------------------Manage General------------------------------------------*/
	/*----------------------------Manage General------------------------------------------*/
	/*----------------------------Manage General------------------------------------------*/
	/*----------------------------Manage General------------------------------------------*/

	$scope.set_Current_DateTime = function()
	{
		get_Current_DateTime();

		var get_Interval = setInterval(function()
		{
			get_Current_DateTime();
		
		}, 1000);
	}	

	$scope.set_user_session = function()
	{
		set_user_session("SignOut");		
	}

	/*----------------------------Manage General------------------------------------------*/
	/*----------------------------Manage General------------------------------------------*/
	/*----------------------------Manage General------------------------------------------*/
	/*----------------------------Manage General------------------------------------------*/
	/*----------------------------Manage General------------------------------------------*/

	/*---------------------------Manage Attendance----------------------------------------*/
	/*---------------------------Manage Attendance----------------------------------------*/
	/*---------------------------Manage Attendance----------------------------------------*/
	/*---------------------------Manage Attendance----------------------------------------*/
	/*---------------------------Manage Attendance----------------------------------------*/


	$scope.set_ManageAttendance = function()
	{
		this.set_tbl_DailyAttendanceinformation();				
		this.set_TotalEmployee_PresentWork();
		this.set_Current_DateTime();
		
	};

	$scope.set_tbl_DailyAttendanceinformation = function()
	{
		$('#tbl_DailyAttendance').DataTable({  
		
	    	ajax :{
	    		
	    		url : get_URL + '/SystemMethods_GeneralSession.php?select_attendance_information=select_attendance_information',
	    		dataSrc : ""
	    	},

	    	columns : [

	    		{ data : 'user_FullName' },
	    		{ data : 'attendance_TimeIn' },
	    		{ data : 'attendance_TimeOut' },
	    		{ data : 'attendance_OverTime' }
	    	],

	    	createdRow: function(row, data, index)
	    	{
	    		$compile(row)($scope);
	    	}
	    });
	}

	$scope.set_TotalEmployee_PresentWork = function ()
	{
		var get_JSON = JSON.parse(select_attendance_information('Select Count'));

		$('#get_TotalEmployee_PresentWork').text('Todays Present: ' + get_JSON.get_TotalEmployee_PresentWork);
	}

	$scope.delete_attendance_information = function()
	{		

		var get_Data = 'delete_attendance_information=delete_attendance_information';
		$.ajax({

			url: get_URL + '/SystemMethods_AdminSession.php',
			type: 'post',
			data: get_Data,

			success: function(set_response)
			{
				alert(set_response);
			},

			error: function(set_response)
			{
				alert(set_response);
			}
		});

		$('#tbl_DailyAttendance').DataTable().ajax.reload();

		this.set_TotalEmployee_PresentWork();
	};

	/*---------------------------Manage Attendance----------------------------------------*/
	/*---------------------------Manage Attendance----------------------------------------*/
	/*---------------------------Manage Attendance----------------------------------------*/
	/*---------------------------Manage Attendance----------------------------------------*/
	/*---------------------------Manage Attendance----------------------------------------*/

	/*----------------------------Manage Employee-----------------------------------------*/
	/*----------------------------Manage Employee-----------------------------------------*/
	/*----------------------------Manage Employee-----------------------------------------*/
	/*----------------------------Manage Employee-----------------------------------------*/
	/*----------------------------Manage Employee-----------------------------------------*/

	$scope.set_ManageEmployee = function()
	{
		

		set_TotalEmployee();

		$('#dv_EmployeeInformation').hide();

		$('#frm_EmployeeInformation').validate(
		{
			rules: 
			{
				'get_UserConfirmPassword':
				{
					equalTo: '#get_UserPassword'
				}
			},

			submitHandler: function()
			{			
				if ($('#btn_Action').val() == 'Add')
					manage_user_information('insert_user_information');

				else if ($('#btn_Action').val() == 'Update')
					manage_user_information('update_user_information');
			}
		});

		this.set_tbl_Employeeinformation();
		this.set_Current_DateTime();
	}

	$scope.set_tbl_Employeeinformation = function()
	{
		$('#tbl_EmployeeInformation').DataTable({  
		
	    	ajax :{
	    		
	    		url : get_URL + '/SystemMethods_GeneralSession.php?select_user_information=select_user_information&get_Action=Select All',
	    		dataSrc : ""
	    	},

	    	columns : [

	    		{ data : 'user_ID' },
	    		{ data : 'user_FullName' },
	    		{ data : 'user_Position' },
	    		{ data : 'user_ContactNumber' },
	    		{ data : 'user_Action' }
	    	],

	    	createdRow: function(row, data, index)
	    	{
	    		$compile(row)($scope);
	    	}
	    });
	}

	$scope.Show_frm_EmployeeInformation_insert = function()
	{
		$('#dv_EmployeeInformation').show();
		$('#dv_EmployeeList').hide();
		
		$('#btn_Action').val('Add');
		$('#btn_Action').text('Add Employee');

		$('#get_UserFirstName').val(null);
		$('#get_UserMiddleName').val(null);
		$('#get_UserLastName').val(null);
		$('#get_UserPosition').val('Select Position').change();
		$('#get_UserContactNumber').val(null);
		$('#get_UserName').val(null);
		$('#get_UserPassword').val(null);
		$('#get_UserConfirmPassword').val(null);
	}

	$scope.Show_frm_EmployeeInformation_update = function(set_UserID)
	{	
		
		$('#dv_EmployeeInformation').show();
		$('#dv_EmployeeList').hide();
		
		var get_JSON = JSON.parse(select_user_information('Select Specific', set_UserID));	
	
		$('#get_UserID').val(get_JSON[0]['user_ID']);
		$('#get_UserFirstName').val(get_JSON[0]['user_FirstName']);
		$('#get_UserMiddleName').val(get_JSON[0]['user_MiddleName']);
		$('#get_UserLastName').val(get_JSON[0]['user_LastName']);
		$('#get_UserPosition').val(get_JSON[0]['user_Position']);
		$('#get_UserContactNumber').val(get_JSON[0]['user_ContactNumber']);
		$('#get_UserName').val(get_JSON[0]['user_Name']);
		$('#get_UserPassword').val(get_JSON[0]['user_Password']);
		$('#get_UserConfirmPassword').val(get_JSON[0]['user_Password']);
		$('#btn_Action').val('Update');
		$('#btn_Action').text('Update Employee');
	}

	$scope.delete_user_information = function(set_UserID)
	{
		if(!confirm('Do you want to Delete?'))
		{
			return false;
		}

		$.ajax({

			url: get_URL + '/SystemMethods_AdminSession.php',
			type: 'post',
			data: 'delete_user_information=delete_user_information' + '&get_UserID=' + set_UserID,

			success: function(set_response)
			{				
				if (set_response.includes('Success : Delete'))
					location.reload();			
			},

			error: function()
			{
				alert('Ajax Error!!!');
			}
		});									
	}


	$scope.Show_EmployeeList = function ()
	{
		$('#dv_EmployeeList').show();
		$('#dv_EmployeeInformation').hide();
	}

	/*----------------------------Manage Employee-----------------------------------------*/
	/*----------------------------Manage Employee-----------------------------------------*/
	/*----------------------------Manage Employee-----------------------------------------*/
	/*----------------------------Manage Employee-----------------------------------------*/
	/*----------------------------Manage Employee-----------------------------------------*/

	/*--------------------------Manage Position/Rate--------------------------------------*/
	/*--------------------------Manage Position/Rate--------------------------------------*/
	/*--------------------------Manage Position/Rate--------------------------------------*/
	/*--------------------------Manage Position/Rate--------------------------------------*/
	/*--------------------------Manage Position/Rate--------------------------------------*/

	$scope.set_Manage_PositionRate = function()
	{
		$('#dv_PositionList').show();		
		$('#dv_PositionInformation').hide();	

		$('#dv_RateList').hide();
		$('#dv_RateInformation').hide();

		$('#frm_PositionInformation').validate(
		{
			submitHandler: function()
			{	

				if ($('#btn_Action').val() == 'Add')
					manage_position_information('insert_position_information');

				else if ($('#btn_Action').val() == 'Update')
					manage_position_information('update_position_information');		
			}
		});

		$('#frm_RateInformation').validate(
		{
			submitHandler: function()
			{	

				if ($('#btn_Action').val() == 'Add')
					manage_rate_information('insert_rate_information');

				else if ($('#btn_Action').val() == 'Update')
					manage_rate_information('update_rate_information');		
			}
		});

		this.set_tbl_PositionInformation();
		this.set_tbl_RateInformation();
		this.set_Current_DateTime();
	}

	$scope.set_tbl_PositionInformation = function()
	{
		$('#tbl_PositionInformation').DataTable({  
		
	    	ajax :{
	    		
	    		url : get_URL + '/SystemMethods_GeneralSession.php?select_position_information=select_position_information&get_Action=Select All',
	    		dataSrc : ""
	    	},

	    	columns : [

	    		{ data : 'position_ID' },
	    		{ data : 'position_Name' },
	    		{ data : 'position_Description' },
	    		{ data : 'rate_ID' },
	    		{ data : 'position_Action' }

	    	],

	    	createdRow: function(row, data, index)
	    	{
	    		$compile(row)($scope);
	    	}
	    });
	}	

	$scope.Show_PositionList = function ()
	{
		$('#dv_PositionList').show();		
		$('#dv_PositionInformation').hide();

		$('#dv_RateList').hide();
		$('#dv_RateInformation').hide();
	}

	$scope.Show_frm_PositionInformation_insert = function ()
	{
		$('#dv_PositionInformation').show();
		$('#dv_PositionList').hide();

		$('#dv_RateList').hide();
		$('#dv_RateInformation').hide();

		$('#btn_Action').val('Add');
		$('#btn_Action').text('Add Position');	
		
		$('#get_PositionName').val(null);
		$('#get_PositionDescription').val(null);
		$('#get_RateID_position').val('Select Position').change();
		
	}

	$scope.Show_frm_PositionInformation_update = function (set_PositionID)
	{

		$('#dv_PositionInformation').show();
		$('#dv_PositionList').hide();	

		$('#btn_Action').val('Update');
		$('#btn_Action').text('Update Position');	

		var get_JSON = JSON.parse(this.select_position_information('Select Specific', set_PositionID));	
	
		$('#get_PositionName').val(get_JSON[0]['position_Name']);
		$('#get_PositionDescription').val(get_JSON[0]['position_Description']);
		$('#get_PositionID').val(get_JSON[0]['position_ID']);
		
	}


	$scope.select_position_information = function(set_Action, set_PositionID)
	{
		var get_Data = '';

		$.ajax({

			url: get_URL + '/SystemMethods_AdminSession.php',
			type: 'post',
			data: 'select_position_information=select_position_information' + '&get_Action=' + set_Action + '&get_PositionID=' + set_PositionID,
			async: false,

			success: function(set_response)
			{				
				get_Data = set_response;					
			},

			error: function()
			{
				alert('Ajax Error!!!');
			}
		});

		return get_Data;
	}

	$scope.delete_position_information = function(set_PositionID)
	{
		alert(set_PositionID);

		if(!confirm('Do you want to Delete?'))
		{
			return false;
		}

		$.ajax({

			url: get_URL + '/SystemMethods_AdminSession.php',
			type: 'post',
			data: 'delete_position_information=delete_position_information' + '&get_PositionID=' + set_PositionID,

			success: function(set_response)
			{				
				if (set_response.includes('Success : Delete'))
					location.reload();			
			},

			error: function()
			{
				alert('Ajax Error!!!');
			}
		});
	}

	$scope.set_tbl_RateInformation = function()
	{
			$('#tbl_RateInformation').DataTable({  
		
	    	ajax :{
	    		
	    		url : get_URL + '/SystemMethods_GeneralSession.php?select_rate_information=select_rate_information&get_Action=Select All',
	    		dataSrc : ""
	    	},

	    	columns : [

	    		{ data : 'rate_ID' },
	    		{ data : 'rate_Value' },
	    		{ data : 'rate_Action' }

	    	],

	    	createdRow: function(row, data, index)
	    	{
	    		$compile(row)($scope);
	    	}
	    });	   
	}

	$scope.Show_RateList = function ()
	{
		$('#dv_RateList').show();
		$('#dv_RateInformation').hide();

		$('#dv_PositionList').hide();		
		$('#dv_PositionInformation').hide();
	}

	$scope.Show_frm_RateInformation_insert = function ()
	{
		$('#dv_RateInformation').show();
		$('#dv_RateList').hide();

		$('#dv_PositionList').hide();		
		$('#dv_PositionInformation').hide();

		$('#btn_Action').val('Add');
		$('#btn_Action').text('Add Rate');	
		
		$('#get_RateValue').val(null);
	}

	$scope.Show_frm_RateInformation_update = function (set_RateID)
	{
		$('#dv_RateInformation').show();
		$('#dv_RateList').hide();	

		$('#btn_Action').val('Update');
		$('#btn_Action').text('Update Rate');	

		var get_JSON = JSON.parse(this.select_rate_information('Select Specific', set_RateID));	
		alert(set_RateID);
		$('#get_RateID').val(get_JSON[0]['rate_ID']);
		$('#get_RateValue').val(get_JSON[0]['rate_Value']);
		
	}

	$scope.select_rate_information = function(set_Action, set_RateID)
	{
		var get_Data = '';

		$.ajax({

			url: get_URL + '/SystemMethods_AdminSession.php',
			type: 'post',
			data: 'select_rate_information=select_rate_information' + '&get_Action=' + set_Action + '&get_RateID=' + set_RateID,
			async: false,

			success: function(set_response)
			{				
				get_Data = set_response;								
			},

			error: function()
			{
				alert('Ajax Error!!!');
			}
		});
		
		return get_Data;
	}


	$scope.delete_rate_information = function(set_RateID)
	{		

		if(!confirm('Do you want to Delete?'))
		{
			return false;
		}

		$.ajax({

			url: get_URL + '/SystemMethods_AdminSession.php',
			type: 'post',
			data: 'delete_rate_information=delete_rate_information' + '&get_RateID=' + set_RateID,

			success: function(set_response)
			{				
				if (set_response.includes('Success : Delete'))
					location.reload();			
			},

			error: function()
			{
				alert('Ajax Error!!!');
			}
		});
	}

	

	/*--------------------------Manage Position/Rate--------------------------------------*/
	/*--------------------------Manage Position/Rate--------------------------------------*/
	/*--------------------------Manage Position/Rate--------------------------------------*/
	/*--------------------------Manage Position/Rate--------------------------------------*/
	/*--------------------------Manage Position/Rate--------------------------------------*/

	/*---------------------------Manage My Account----------------------------------------*/
	/*---------------------------Manage My Account----------------------------------------*/
	/*---------------------------Manage My Account----------------------------------------*/
	/*---------------------------Manage My Account----------------------------------------*/
	/*---------------------------Manage My Account----------------------------------------*/
	

	$scope.set_ManageMyAccount = function()
	{
		$('#frm_MyInformation').validate(
		{
			rules: 
			{
				'get_UserConfirmPassword':
				{
					equalTo: '#get_UserPassword'
				}
			},

			submitHandler: function()
			{				
				manage_user_information('update_user_information');
			}
		});

		this.set_Current_DateTime();
	}

	$scope.set_frm_MyInformation = function()
	{		
		var get_JSON = JSON.parse(select_user_information('Select Specific', get_UserSessionID));	
	
		$('#get_UserID').val(get_JSON[0]['user_ID']);
		$('#get_UserFirstName').val(get_JSON[0]['user_FirstName']);
		$('#get_UserMiddleName').val(get_JSON[0]['user_MiddleName']);
		$('#get_UserLastName').val(get_JSON[0]['user_LastName']);
		$('#get_UserPosition').val(get_JSON[0]['user_Position']);
		$('#get_UserContactNumber').val(get_JSON[0]['user_ContactNumber']);
		$('#get_UserName').val(get_JSON[0]['user_Name']);
		$('#get_UserPassword').val(get_JSON[0]['user_Password']);
		$('#get_UserConfirmPassword').val(get_JSON[0]['user_Password']);
		$('#btn_Action').val('Update');
		$('#btn_Action').text('Update Employee');
	}

	/*---------------------------Manage My Account----------------------------------------*/
	/*---------------------------Manage My Account----------------------------------------*/
	/*---------------------------Manage My Account----------------------------------------*/
	/*---------------------------Manage My Account----------------------------------------*/
	/*---------------------------Manage My Account----------------------------------------*/
	
}]);