
/* Client_Information */

export class Client_Information
{
	constructor()
	{
		console.log("Class Client_Information has been initialized.")
	}

	Select_Client_Information(set_Action, callback)
	{
		var get_Data = null
		
		get_Data = JSON.stringify(set_Action)

		if (get_Data == null)
		{
			console.log('Invalid Action at Client_Information Class (Select_Client_Information()): ' + set_Action)
			
			return false
		}

		var get_URL = 'Function/LECSteelMC_Client_Information.py/Select_Client_Information'

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

				console.log('Ajax Error: Function/LECSteelMC_Client_Information.py/Select_Client_Information ' + set_errorThrown)
			}
		})
	}

	Manage_Client_Information(set_Action, set_Data, callback)
	{
		var get_URL = 'Function/LECSteelMC_Client_Information.py/' + set_Action

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

				console.log('Ajax Error: Function/LECSteelMC_Client_Information.py/ ' + set_errorThrown)
			}
		})				
	}
}