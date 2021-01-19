/* Purchase_Order_Information */

export class Purchase_Order_Information
{
	constructor()
	{
		console.log("Class Purchase_Order_Information has been initialized.")
	}

	Select_Purchase_Order_Information_Parent(set_Action, callback)
	{
		var get_Data = null

		console.log(set_Action)
		
		/*	alert(set_Action)
			'Select : All'
			'Select : Specific'
		*/
		
		get_Data = JSON.stringify(set_Action)

		if (get_Data == null)
		{
			console.log('Invalid Action at Purchase_Order_Information Class (Select_Purchase_Order_Information_Parent()): ' + set_Action)
			
			return false
		}

		var get_URL = 'Function/LECSteelMC_Purchase_Order_Information.py/Select_Purchase_Order_Information_Parent'
		
        $.ajax(
		{
			url : get_URL,		
			type : 'POST',
			data : get_Data,
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

				console.log('Ajax Error: Function/LECSteelMC_Purchase_Order_Information.py/Select_Purchase_Order_Information_Parent ' + set_errorThrown)
			}
		})
	}

	Manage_Purchase_Order_Information_Parent(set_Action, set_Data, callback)
	{
		for (var set_KeyValue of set_Data.entries())
        {           
            console.log(set_KeyValue[0]); 
            console.log(set_KeyValue[1]);
        }        

		/*var object = {};
		set_Data.forEach(function(value, key){
		    object[key] = value;
		});
		var json = JSON.stringify(object);

		console.log(json)*/

        var get_URL = 'Function/LECSteelMC_Purchase_Order_Information.py/' + set_Action

        $.ajax(
		{
			url : get_URL,		
			type : 'POST',
			data : set_Data,
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
				
				console.log('Ajax Error: Function/LECSteelMC_Purchase_Order_Information.py/ ' + set_errorThrown)
			}
		})				
	}

}
