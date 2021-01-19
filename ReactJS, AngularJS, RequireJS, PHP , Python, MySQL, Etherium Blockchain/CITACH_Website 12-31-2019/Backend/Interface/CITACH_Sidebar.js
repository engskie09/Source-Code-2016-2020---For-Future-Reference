define('CITACH_Server_Sidebar', function()
{
	class CITACH_Server_Sidebar extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Server_Sidebar Class')

			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Server_Sidebar Class')

			$('#side-menu').metisMenu()
		}

		render()
		{
			return	<div>
						<div className = 'navbar-default sidebar' role = 'navigation'>
							<div className = 'sidebar-nav navbar-collapse'>
								<ul className = 'nav' id = 'side-menu'>

									<li className = 'sidebar-search'>
										<div className = 'input-group custom-search-form'>
											<input type = 'text' className = 'form-control' placeholder = 'Search...'/>
											<span className = 'input-group-btn'>
												<button className = 'btn btn-primary' type = 'button'>
												<i className = 'fa fa-search'></i>
												</button>
											</span>
										</div>
									</li>
									<li>
										<Link to = '/Dashboard'><i className = 'fa fa-dashboard fa-fw'></i>Dashboard</Link>
									</li>
									<li>
										<Link to = '/Church'><i className = 'fa fa-dashboard fa-fw'></i>Daughter Church</Link>
									</li>
									<li>
										<Link to = '/Member'><i className = 'fa fa-dashboard fa-fw'></i>Member</Link>
									</li>
								</ul>
							</div>
						</div>
					</div>
		}
	}

	window.CITACH_Server_Sidebar = CITACH_Server_Sidebar
})