define('CITACH_Server_Header_Sidebar', function()
{
	class CITACH_Server_Header_Sidebar extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Server_Header_Sidebar Class')

			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Server_Header_Sidebar Class')
		}

		render()
		{
			return	<div>
						<nav className = 'navbar navbar-inverse navbar-fixed-top' role='navigation'>
							<CITACH_Server_Header/>
							<CITACH_Server_Sidebar/>
						</nav>				
					</div>
		}
	}

	window.CITACH_Server_Header_Sidebar = CITACH_Server_Header_Sidebar
})