define('CITACH_Client_Ministry', function()
{
	return class extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Client_Ministry Class')

			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Client_Ministry Class')
		}

		render()
		{
			return	<div>
						<section className = 'title'>
							<div className = 'container'>
								<div className = 'row-fluid'>
									<div className = 'span6'>
										<h1>Ministries</h1>
										<hr width="203%"/>
									</div>
									<div className = 'span6'>
										<ul className = 'breadcrumb pull-right'>
											<li><Link to = '/Home'>Home</Link><span className = 'divider'>/</span></li>
											<li className = 'active'>Ministries</li>
										</ul>
									</div>
								</div>
							</div>
						</section>

						<section className = "ministry">
							<div className = "container">
								<div className = "row" style = {{ 'color' : '#FFFF' }}>

									<div className = 'span4'>
										<div className = 'center'>
											<i style = {{ 'fontSize' : '48px' }} className = 'icon-circle icon-large'></i>
											<a href = '#' style = {{ 'color' : '#FFFF' }}><h4>Praise and Worship</h4></a>
											<p style = {{ 'color' : '#FFFF' }}>Message Here Message Here Message Here Message Here Message Here Message Here </p>
										</div>
									</div>

									<div className = 'span4'>
										<div className = 'center'>
											<i style = {{ 'fontSize' : '48px' }} className = 'icon-food icon-large'></i>
											<a href = '#' style = {{ 'color' : '#FFFF' }}><h4>Kids Ministry</h4></a>
											<p style = {{ 'color' : '#FFFF' }}>Message Here Message Here Message Here Message Here Message Here Message Here </p>
										</div>
									</div>

									<div className = 'span4'>
										<div className = 'center'>
											<i style = {{ 'fontSize' : '48px' }} className = 'icon-gamepad icon-large'></i>
											<a href = '#' style = {{ 'color' : '#FFFF' }}><h4>Youth Ministry</h4></a>
											<p style = {{ 'color' : '#FFFF' }}>Message Here Message Here Message Here Message Here Message Here Message Here </p>
										</div>
									</div>

									<div className = 'span4'>
										<div className = 'center'>
											<i style = {{ 'fontSize' : '48px' }} className = 'icon-magic icon-large'></i>
											<a href = '#' style = {{ 'color' : '#FFFF' }}><h4>Evangelism and Mission</h4></a>
											<p style = {{ 'color' : '#FFFF' }}>Message Here Message Here Message Here Message Here Message Here Message Here </p>
										</div>
									</div>

									<div className = 'span4'>
										<div className = 'center'>
											<i style = {{ 'fontSize' : '48px' }} className = 'icon-puzzle-piece icon-large'></i>
											<a href = '#' style = {{ 'color' : '#FFFF' }}><h4>Men's Ministry</h4></a>
											<p style = {{ 'color' : '#FFFF' }}>Message Here Message Here Message Here Message Here Message Here Message Here </p>
										</div>
									</div>

									<div className = 'span4'>
										<div className = 'center'>
											<i style = {{ 'fontSize' : '48px' }} className = 'icon-shopping-cart icon-large'></i>
											<a href = '#' style = {{ 'color' : '#FFFF' }}><h4>Women's Ministry</h4></a>
											<p style = {{ 'color' : '#FFFF' }}>Message Here Message Here Message Here Message Here Message Here Message Here </p>
										</div>
									</div>

								</div>
							</div>
						</section>
					</div>
		}
	}
})