define('CITACH_Client_Header', function()
{
	return class extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Client_Header Class')

			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Client_Header Class')
		}

		render()
		{	
			return	<header className = 'navbar navbar-fixed-top'>
						<div className = 'navbar-inner'>
							<div className = 'container'>
								<a className = 'btn btn-navbar' data-toggle = 'collapse' data-target = '.nav-collapse'>
									<span className = 'icon-bar'></span>
									<span className = 'icon-bar'></span>
									<span className = 'icon-bar'></span>
								</a>
								<a className = 'pull-left' id = 'logo' to = ''></a>
								<div className = 'nav-collapse collapse pull-right'>
									<ul className = 'nav'>
										<li><Link to = '/Home'>Home</Link></li>
										<li><Link to = '/About'>About Us</Link></li>
										<li><Link to = '/Ministry'>Ministries</Link></li>
										<li><Link to = '/Gallery'>Gallery</Link></li>
										<li className = 'dropdown'>
										<Link to = '' className = 'dropdown-toggle' data-toggle = 'dropdown'>Resources<i className = 'icon-angle-down'></i></Link>
										<ul className = 'dropdown-menu'>
										<li><Link to = '/Sermon'>SERMON</Link></li>
										<li><Link to = '/Other'>OTHERS</Link></li>
										</ul>
										</li>
										<li><Link to = '/Give'>Give</Link></li>
										<li><Link to = '/Contact'>Contact</Link></li>
										<li><Link to = '/Login'>Login</Link></li>
									</ul>
								</div>
							</div>
						</div>
					</header>
		}
	}
})