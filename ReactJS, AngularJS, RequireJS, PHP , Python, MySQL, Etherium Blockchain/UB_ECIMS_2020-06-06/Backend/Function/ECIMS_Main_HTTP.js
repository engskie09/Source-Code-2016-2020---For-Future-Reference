define('ECIMS_Main_HTTP', function()
{
	class ECIMS_Main_HTTP
	{
		constructor()
		{
			if (System_Mode == 'Development')
				console.log("Succesfully Loaded : ECIMS_Main_HTTP Class")
		}

		static Select(set_Data, set_Callback)
		{
			if (!set_Data)
			{
				console.log('Invalid Data')

				return
			}

			$.ajax
			({
				'url'			:	URL_Function + 'ECIMS_Main_HTTP.py',
				'type'			:	'POST',
				'data'			:	set_Data,
				'contentType'	:	false,
				'processData'	:	false,
				'cache'			:	false,
				'dataType'		:	'json',

				'beforeSend'	:	set_jQueryXMLHttpRequest =>
				{
					set_jQueryXMLHttpRequest.setRequestHeader('Accept', 'application/json')
				},

				'success'		:	set_Response =>
				{
					try
					{
						console.log(set_Response)

						set_Callback(set_Response)
					}

					catch(set_Exception)
					{
						console.log(set_Exception)
						console.log(set_Response)
						set_Callback(set_Response)
					}
				},

				'error'			:	(set_jQueryXMLHttpRequest, set_TextStatus, set_ErrorThrown) =>
				{
					console.log('jQueryXMLHttpRequest Error:')
					console.log(set_jQueryXMLHttpRequest)
					console.log('TextStatus Error: '			+	set_TextStatus)
					console.log('ErrorThrown Error: '			+	set_ErrorThrown)

					//alert(set_jQueryXMLHttpRequest['responseText'])

					set_Callback(false)
				}
			})
		}

		static Manage(set_Data, set_Callback)
		{
			if (!(set_Data instanceof FormData))
			{
				console.log('Invalid Data')

				return
			}

			$.ajax(
			{
				'url'			:	URL_Function + 'ECIMS_Main_HTTP.py',
				'type'			:	'POST',
				'data'			:	set_Data,
				'contentType'	:	false,
				'processData'	:	false,
				'cache'			:	false,
				'dataType'		:	'json',

				'beforeSend'	:	set_jQueryXMLHttpRequest =>
				{
					set_jQueryXMLHttpRequest.setRequestHeader('Accept', 'application/json')
				},

				'success'		:	set_Response =>
				{
					try
					{

						alert(set_Response['Output'])
						console.log(set_Response['Output'])

						if (set_Response['Output'] == 'Insert Succeeded' || set_Response['Output'] == 'Update Succeeded' || set_Response['Output'] == 'Delete Succeeded')
							set_Callback(true)

						else
							set_Callback(false)
					}

					catch(set_Exception)
					{
						console.log(set_Exception)
						console.log(set_Response['Output'])

						if (set_Response['Output'] == 'Insert Succeeded' || set_Response['Output'] == 'Update Succeeded' || set_Response['Output'] == 'Delete Succeeded')
							set_Callback(true)

						else
							set_Callback(false)
					}
				},

				'error'			:	(set_jQueryXMLHttpRequest, set_TextStatus, set_ErrorThrown) =>
				{
					console.log('jQueryXMLHttpRequest Error:')
					console.log(set_jQueryXMLHttpRequest)
					console.log('TextStatus Error: '			+	set_TextStatus)
					console.log('ErrorThrown Error: '			+	set_ErrorThrown)

					//alert(set_jQueryXMLHttpRequest['responseText'])

					set_Callback(false)
				}
			})
		}
	}

	window.ECIMS_Main_HTTP = ECIMS_Main_HTTP
})