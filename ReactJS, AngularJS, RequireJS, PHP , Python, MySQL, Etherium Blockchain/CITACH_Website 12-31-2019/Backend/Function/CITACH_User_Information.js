define('CITACH_User_Information', function()
{
	class CITACH_User_Information
	{
		constructor()
		{
			console.log("Succesfully Loaded : User_Information Class")
		}

		static test()
		{
			alert('wew?XD');
		}

		static Select_User_Information(set_Data, callback)
		{
			$.ajax(
			{
				'url'	:	window.URL_Base + 'Function/CITACH_User_Information.php',
				'type'	:	'POST',
				'data'	:	set_Data,

				success	: function(set_Response)
				{
					callback(set_Response)
				},

				error: function(set_jqXHR, set_textStatus, set_errorThrown)
				{
					callback(false)

					console.log('Ajax Error: Function/CITACH_User_Information.php/' + set_errorThrown)
				}
			})
		}

		static Manage_User_Information(set_Data, callback)
		{
			//For testing input Data
			for (var set_KeyValue of set_Data.entries())
			{
				console.log(set_KeyValue[0]); 
				console.log(set_KeyValue[1]);
			}

			$.ajax(
			{
				url			:	window.URL_Base + 'Function/CITACH_User_Information.php',
				type		:	'POST',
				data		:	set_Data,
				contentType :	false,
				cache		:	false,
				processData :	false, 

				success: function(set_Response)
				{	
					alert(set_Response)
					if (set_Response == 'Insert Succeeded' || set_Response == 'Update Succeeded' || set_Response == 'Delete Succeeded')
						callback(true)

					else
						callback(false)
				},

				error: function(set_jqXHR, set_textStatus, set_errorThrown)
				{
					callback(false)

					console.log('Ajax Error: Function/CITACH_User_Information.php/ ' + set_errorThrown)
				}
			})
		}
	}

	window.CITACH_User_Information = CITACH_User_Information
})