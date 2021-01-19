
window.JSON_String_Church = '[ '
+ '{ "Church_Identity" : "1", "Church_Address" : "16. F. Nicolas St. Niugan, Malabon City", "Church_Name" : "Christ is the Answer Niugan" , "Member_FullName" : [{"Member_FullName" : "Rev. Tomas P. Dulatas"}], "Member_Position" : [{ "Member_Position" : ["Senior Pastor", "Reverend"]}], "Church_Image_Path" : "Data/Church/Image/Image_1.jpg" },'

+ '{ "Church_Identity" : "2", "Church_Address" : "16. F. Nicolas St. Niugan, Malabon City", "Church_Name" : "Christ is the Answer Perez" , "Member_FullName" : [{"Member_FullName" : "Rev. Benjo Gaddi"}, {"Member_FullName" : "Ptr. Christina Gaddi"}], "Member_Position" : [{ "Member_Position" : ["Reverend"]}, { "Member_Position" : ["Pastor"]}], "Church_Image_Path" : "Data/Church/Image/Image_1.jpg"},'

+ '{ "Church_Identity" : "3", "Church_Address" : "16. F. Nicolas St. Niugan, Malabon City", "Church_Name" : "Christ is the Answer Gulayan" , "Member_FullName" : [{"Member_FullName" : "Ptra. Melecia David"}], "Member_Position" : [{ "Member_Position" : ["Pastor"]}], "Church_Image_Path" : "Data/Church/Image/Image_1.jpg" },'

+ '{ "Church_Identity" : "4", "Church_Address" : "16. F. Nicolas St. Niugan, Malabon City", "Church_Name" : "Christ is the Answer Valenzuela" , "Member_FullName" : [{"Member_FullName" : "Rev. Romulo Sabang"}], "Member_Position" : [{ "Member_Position" : ["Reverend"]}], "Church_Image_Path" : "Data/Church/Image/Image_1.jpg" }'

+ ']'

window.JSON_String_Gallery_Image = '[ '
+ '{ "Gallery_Image_Identity" : "1", "Gallery_Image_Path" : "Data/Gallery/Image/sample1.png" },'

+ '{ "Gallery_Image_Identity" : "2", "Gallery_Image_Path" : "Data/Gallery/Image/sample2.png" },'

+ '{ "Gallery_Image_Identity" : "3", "Gallery_Image_Path" : "Data/Gallery/Image/sample3.png" },'

+ '{ "Gallery_Image_Identity" : "4", "Gallery_Image_Path" : "Data/Gallery/Image/sample4.png" }'

+ ']'

require.config(
{
	'paths'	:
	{
		'babel'						:	'Library/Babel-Standalone_6.26.0/babel.min',
		'jsx'						:	'Library/RequireJS-Babel-JSX/jsx',
		'react'						:	'Library/React/React_16.12.0/umd/react.development',
		'react-dom'					:	'Library/React/React-DOM_16.11.0/umd/react-dom.development',
		'react-router-dom'			:	'Library/React/React-Router-DOM_5.1.2/react-router-dom',
		'jquery'					:	'Library/JQuery_3.4.1/jquery.min',
		'jquery.slitslider'			:	'Library/SlitSlider-Master/jquery.slitslider',
		'jquery.ba-cond'			:	'Library/SlitSlider-Master/jquery.ba-cond.min',
		'modernizr.custom.79639'	:	'Library/SlitSlider-Master/modernizr.custom.79639',
		'bootstrap'			:			'Library/Template_Client/js/bootstrap.min'
	},

	'shim'	:
	{
		'jquery.slitslider'	:	{ 'deps'	:	['jquery', 'modernizr.custom.79639'] },
		'jquery.ba-cond'	:	{ 'deps'	:	['jquery'] },
		'bootstrap'			:	{ 'deps'	:	['jquery'] }
	}
})


require
(
	[	'react',	'react-dom',	'react-router-dom', 'jquery', 	'jquery.slitslider',	'jquery.ba-cond', 	'bootstrap'], function
	(	React,		ReactDOM,		ReactRouterDOM,		JQuery, 	JQuerySlitslider,		JQueryBaCond, 		Bootstrap)
{
		//React Library
		window.React = React
		window.Component = React.Component

		window.ReactDOM = ReactDOM

		window.ReactRouterDOM = ReactRouterDOM
		window.BrowserRouter = ReactRouterDOM.BrowserRouter
		window.Link  = ReactRouterDOM.Link
		window.Route  = ReactRouterDOM.Route
		window.Switch  = ReactRouterDOM.Switch


		require
		([
			'jsx!Interface/CITACH_Header',
			'jsx!Interface/CITACH_Footer',
			'jsx!Interface/CITACH_Home',
			'jsx!Interface/CITACH_About',
			'jsx!Interface/CITACH_Ministry',
			'jsx!Interface/CITACH_Gallery',
			'jsx!Interface/CITACH_Contact'
		],
		function()
		{
			require(
			[
				'CITACH_Client_Header',
				'CITACH_Client_Footer',
				'CITACH_Client_Home',
				'CITACH_Client_About',
				'CITACH_Client_Ministry',
				'CITACH_Client_Gallery',
				'CITACH_Client_Contact'
			],

			function (CITACH_Client_Header, CITACH_Client_Footer, CITACH_Client_Home, CITACH_Client_About, CITACH_Client_Ministry, CITACH_Client_Gallery, CITACH_Client_Contact)
			{
				window.CITACH_Client_Header = CITACH_Client_Header
				window.CITACH_Client_Footer = CITACH_Client_Footer
				window.CITACH_Client_Home  = CITACH_Client_Home
				window.CITACH_Client_About = CITACH_Client_About
				window.CITACH_Client_Ministry = CITACH_Client_Ministry
				window.CITACH_Client_Gallery = CITACH_Client_Gallery
				window.CITACH_Client_Contact = CITACH_Client_Contact

				require(['jsx!Interface/CITACH_Index'], function()
				{
					require(['CITACH_Client_Index'], function (CITACH_Client_Index)
					{

					})
				})
			})
		})
})


define('Asset_Load', ['jquery'], function(JQuery)
{
	return function(set_Type, set_Rel, set_URL)
	{
		JQuery('<link>',
		{
			'type'	:	set_Type,
			'rel'	:	set_Rel,
			'href'	:	set_URL
		}).appendTo('head')
	}
})

require(['Asset_Load'], function(Asset_Load)
{
	Asset_Load('text/css', 'stylesheet', 'Library/Template_Client/css/bootstrap.min.css')
	Asset_Load('text/css', 'stylesheet', 'Library/Template_Client/css/bootstrap-responsive.min.css')
	Asset_Load('text/css', 'stylesheet', 'Library/Template_Client/css/font-awesome.min.css')
	Asset_Load('text/css', 'stylesheet', 'Library/Template_Client/css/main.css')
	Asset_Load('text/css', 'stylesheet', 'Library/Template_Client/css/sl-slide.css')
})

/*require(['jsx!Interface/Client/test1', 'jsx!Interface/Client/test2', 'jsx!Interface/Client/test3'], function()
{
	require(['Test1', 'Test2', 'Test3'], function (Test1, Test2, Test3)
	{
		window.Test1 = Test1
		window.Test2 = Test2
		window.Test3 = Test3
	})
})*/