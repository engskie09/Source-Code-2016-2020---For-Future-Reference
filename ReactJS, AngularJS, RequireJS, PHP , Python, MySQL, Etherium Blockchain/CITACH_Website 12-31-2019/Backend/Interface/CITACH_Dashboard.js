define('CITACH_Server_Dashboard', function()
{
	class CITACH_Server_Dashboard extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Server_Dashboard Class')

			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Server_Dashboard Class')
		}

		render()
		{
			return	<div>
						<div id='page-wrapper'>
							<div className = 'container-fluid'>

								<hr/>

								<div className = 'row'>
									<div className = 'col-lg-12'>
										<h1 className = 'page-header'>LAB U JUSHLYN {'<3'}</h1>
									</div>
								</div>

							</div>
						</div>
					</div>
		}
	}

	window.CITACH_Server_Dashboard = CITACH_Server_Dashboard
})