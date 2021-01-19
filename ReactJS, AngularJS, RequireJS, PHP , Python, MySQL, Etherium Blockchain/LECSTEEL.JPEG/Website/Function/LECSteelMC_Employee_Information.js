/* Employee_Information */

export class User_Information
{	
	constructor()
	{		
		this.get_User_Information = this.get_User_Information.bind(this)

		console.log("Class User_Information has been initialized.")
	}

	set_Library($set_Scope, $set_Cookies)
	{		
		this.$cookies = $set_Cookies
		this.$scope = $set_Scope
	}

	check_User_Session()
	{
		this.Identity = this.$cookies.get('Identity')
		this.Username = this.$cookies.get('Username')
		this.Password = this.$cookies.get('Password')

        if (this.Identity == null || this.Username == null || this.Password == null)
        {
        	console.log('Null Cookies: Identity, Username, Password');
        	return false
        }

        else
        	return true
	}

	set_User_Cookie(set_User_Information)
	{
		this.$cookies.put('Identity', set_User_Information['Employee_Identity'])
		this.$cookies.put('Username', set_User_Information['Employee_Username'])
		this.$cookies.put('Password', set_User_Information['Employee_Password'])	

		//console.log(set_User_Information)
		
		console.log('Session has been updated.')
	}

	get_User_Information(set_Action, set_Dialog, set_Data, callback)
	{			

		var get_URL = 'Function/LECSteelMC_Employee_Information.py/'

		var get_Return_Value = null

		if (set_Action == 'Select : Specific : { Employee_Username, Employee_Username }')
		{		
			get_URL = get_URL + 'get_User_Information/Select/Specific/(Employee_Username,Employee_Password)'

			if (set_Data.has('Username') && set_Data.has('Password'))
			{
				this.Username = set_Data.get('Username')
				this.Password = set_Data.get('Password')				
			}
		}

		else if (set_Action == 'Select : Specific : { Employee_Identity }')		
			get_URL = get_URL + 'get_User_Information/Select/Specific/(Employee_Identity)'

		if (get_URL == 'Function/LECSteelMC_Employee_Information.py/')
		{
			console.log('Invalid Action at User_Information Class (get_User_Information()): ' + set_Action)

			return false
		}

		this.$scope.set_Login_Session('Display Loading')

		setTimeout(function()
		{				
			$.ajax(
			{
				url : get_URL,		
				type : "POST",
				data : set_Data,				
				async : true,
				contentType : false,       
				cache : false,             
				processData : false, 

				success: function(set_Response)
				{		
					if (set_Action == 'Select : Specific : { Employee_Username, Employee_Username }')
					{
						this.$scope.set_Login_Session(set_Response)						
					}

					else if (set_Action == 'Select : Specific : { Employee_Identity }')
					{				
						
						if (set_Response != 'No Data')
							callback(set_Response)

						else
							callback(false)
					}
					

				}.bind(this),

				error: function(set_jqXHR, set_textStatus, set_errorThrown)
				{				
					if (set_Action == 'Select : Specific : { Employee_Username, Employee_Username }')
					{
						callback(false)						
					}				

					console.log('Ajax Error: Function/LECSteelMC_Employee_Information.py/ ' + set_errorThrown)
				}
			})
		}.bind(this), 2000)
			
	}

	get_Username()
	{
		return this.Username
	}

	set_Username(set_Username)
	{
		this.Username = set_Username;
	}


}




/* Employee_Information */

export class Employee_Information
{
	constructor()
	{
		console.log("Class Employee_Information has been initialized.")
	}

	set_Library($set_Scope, $set_Cookies)
	{		
		this.$cookies = $set_Cookies
		this.$scope = $set_Scope
	}

	Select_Employee_Information(set_Action, callback)
	{
		var get_Data = null
		
		get_Data = JSON.stringify(set_Action)

		if (get_Data == null)
		{
			console.log('Invalid Action at Employee_Information Class (Select_Employee_Information()): ' + set_Action)
			
			return false
		}

		var get_URL = 'Function/LECSteelMC_Employee_Information.py/Select_Employee_Information'

        $.ajax(
		{
			url : get_URL,		
			type : 'POST',
			data : get_Data,			
			async : false,
			contentType : false,       
			cache : false,             
			processData : false, 

			success: function(set_Response)
			{
				if (set_Response == 'No Action' || set_Response == 'No Data')
					callback(false)
				
				else
					callback(set_Response)
			},

			error: function(set_jqXHR, set_textStatus, set_errorThrown)
			{
				callback(false)							

				console.log('Ajax Error: Function/LECSteelMC_Employee_Information.py/Select_Employee_Information ' + set_errorThrown)
			}
		})
	}

	Manage_Employee_Information(set_Action, set_Data, callback)
	{
		var get_URL = 'Function/LECSteelMC_Employee_Information.py/' + set_Action

		// For testing input Data.
		/*for (var set_KeyValue of set_Data.entries())
        {           
            console.log(set_KeyValue[0]); 
            console.log(set_KeyValue[1]);
        }*/

        $.ajax(
		{
			url : get_URL,		
			type : 'POST',
			data : set_Data,
			async : false,
			contentType : false,       
			cache : false,             
			processData : false, 

			success: function(set_Response)
			{
				if (set_Response == 'Insert Succeeded' || set_Response == 'Update Succeeded' || set_Response == 'Delete Succeeded')
					callback(true)

				else
					callback(false)
			},

			error: function(set_jqXHR, set_textStatus, set_errorThrown)
			{
				callback(false)							

				console.log('Ajax Error: Function/LECSteelMC_Employee_Information.py/ ' + set_errorThrown)
			}
		})				
	}
}
