require.config(
{
	'paths'	:
	{
		'babel'					:	'../Library/Babel-Standalone_6.26.0/babel.min',
		'jsx'					:	'../Library/RequireJS-Babel-JSX/jsx',
		'react'					:	'../Library/React/React_16.12.0/umd/react.development',
		'react-dom'				:	'../Library/React/React-DOM_16.11.0/umd/react-dom.development',
		'react-router-dom'		:	'../Library/React/React-Router-DOM_5.1.2/react-router-dom',
		'jquery'				:	'../Library/Template_Server/js/jquery.min',
		'bootstrap'				:	'../Library/Template_Server/js/bootstrap.min',
		'metisMenu'				:	'../Library/Template_Server/js/metisMenu.min',
		'startmin'				:	'../Library/Template_Server/js/startmin',
		'semantic'				:	'../Library/Semantic-UI-Master_2.4.2/semantic',
		'semantic.form'			:	'../Library/Semantic-UI-Master_2.4.2/components/form',
		'jquery.dataTables'		:	'../Library/Template_Server/js/dataTables/jquery.dataTables.min',
		'dataTables.bootstrap'	:	'../Library/Template_Server/js/dataTables/dataTables.bootstrap.min'
	},

	'shim'	:
	{
		'bootstrap'				:	{ 'deps'	:	['jquery'] },
		'metisMenu'				:	{ 'deps'	:	['jquery', 'bootstrap'] },
		'startmin'				:	{ 'deps'	:	['jquery', 'bootstrap'] },
		'semantic'				:	{ 'deps'	:	['jquery'] },
		'semantic.form'			:	{ 'deps'	:	['semantic'] },
		'jquery.dataTables'		:	{ 'deps'	:	['jquery', 'bootstrap'] },
		'dataTables.bootstrap'	:	{ 'deps'	:	['jquery.dataTables'] }
	},

	'map'	:
	{
		'*'	:
		{
			'datatables.net'	:	'jquery.dataTables'
		}
	}
})

require
(
	[	'react',	'react-dom',	'react-router-dom', 'jquery',	'bootstrap',	'metisMenu',	'startmin',	'semantic',	'semantic.form',	'jquery.dataTables', 	'dataTables.bootstrap'], function
	(	React,		ReactDOM,		ReactRouterDOM,		JQuery,		Bootstrap,		MetisMenu,		Startmin, 	Semantic,	SemanticForm,		JqueryDataTables, 		DataTablesBootstrap)
{
		//React Library
		window.React 			=	React
		window.Component 		=	React.Component

		window.ReactDOM 		=	ReactDOM
		window.findDOMNode		=	ReactDOM.findDOMNode

		window.ReactRouterDOM 	=	ReactRouterDOM
		window.BrowserRouter 	=	ReactRouterDOM.BrowserRouter
		window.Link  			=	ReactRouterDOM.Link
		window.Redirect 		=	ReactRouterDOM.Redirect
		window.Route  			=	ReactRouterDOM.Route
		window.Switch  			=	ReactRouterDOM.Switch

		require
		([
			'Function/CITACH_User_Information',
			'jsx!Interface/CITACH_Header_Sidebar',
			'jsx!Interface/CITACH_Header',
			'jsx!Interface/CITACH_Sidebar',
			'jsx!Interface/CITACH_Footer',	
			'jsx!Interface/CITACH_Dashboard',
			'jsx!Interface/CITACH_Church',
			'jsx!Interface/CITACH_Member'
		],
		function()
		{
			require
			(
				[
					'CITACH_User_Information',
					'CITACH_Server_Header_Sidebar',
					'CITACH_Server_Header',
					'CITACH_Server_Sidebar',
					'CITACH_Server_Footer',
					'CITACH_Server_Dashboard',
					'CITACH_Server_Church',
					'CITACH_Server_Member'
				],

				function()
				{
					require(['jsx!Interface/CITACH_Index'], function()
					{
						require(['CITACH_Server_Index'], function (CITACH_Server_Index)
						{

						})
					})
				}
			)
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
	Asset_Load('text/css', 'stylesheet', '../Library/Template_Server/css/bootstrap.min.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Template_Server/css/metisMenu.min.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Template_Server/css/timeline.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Template_Server/css/startmin.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Template_Server/css/morris.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Template_Server/css/font-awesome.min.css')	
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/semantic.css')

	Asset_Load('text/css', 'stylesheet', '../Library/Template_Server/css/dataTables/dataTables.bootstrap.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Template_Server/css/dataTables/dataTables.responsive.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Template_Server/css/main.css')

	/*Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/reset.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/site.css')

	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/container.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/grid.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/header.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/image.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/menu.css')

	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/divider.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/segment.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/form.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/input.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/button.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/list.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/message.css')
	Asset_Load('text/css', 'stylesheet', '../Library/Semantic-UI-Master_2.4.2/components/icon.css')*/

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