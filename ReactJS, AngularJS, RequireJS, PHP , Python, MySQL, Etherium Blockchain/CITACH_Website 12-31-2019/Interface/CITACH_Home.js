define('CITACH_Client_Home', function()
{
	class Slideshow extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : Slideshow Class')
			
			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : Slideshow Class')

			this.Slideshow_Function()
		}

		render()
		{
			return	<section id='slide-show'>
						<div className='sl-slider-wrapper' id='slider'>
							<div className='sl-slider'>

								<div className='sl-slide item1' data-orientation='horizontal' data-slice1-rotation='-25' data-slice2-rotation='-25' data-slice1-scale='2' data-slice2-scale='2'>
									<div className='sl-slide-inner'>
										<div className='container'>
											<img className='pull-right' src='Data/Home/Image/Image_1.jpg'/>

											<a className='btn btn-large btn-transparent' href='#'>View More</a>
										</div>
									</div>
								</div>

								<div className='sl-slide item2' data-orientation='vertical' data-slice1-rotation='10' data-slice2-rotation='-15' data-slice1-scale='1.5' data-slice2-scale='1.5'>
									<div className='sl-slide-inner'>
										<div className='container'>
										<img className='pull-right' src='Data/Home/Image/Image_2.jpg'/>

											<a className='btn btn-large btn-transparent' href='#'>View More</a>
										</div>
									</div>
								</div>

								<div className='sl-slide item3' data-orientation='horizontal' data-slice1-rotation='3' data-slice2-rotation='3' data-slice1-scale='2' data-slice2-scale='1'>
									<div className='sl-slide-inner'>
										<div className='container'>
											<img className='pull-right' src='Data/Home/Image/Image_3.jpg' />
											<h3 id='v3'>LOVE GOD, LOVE OTHERS, MAKE DISCIPLES, PLANT CHURCHES<br/></h3>
											<h3 className='gap'></h3>-->
											<a className='btn btn-large btn-transparent' href='#'>View More</a>
										</div>
									</div>
								</div>
							</div>

							<nav id='nav-arrows' className='nav-arrows'>
								<span className='nav-arrow-prev'><i className='icon-angle-left'></i></span>
								<span className='nav-arrow-next'><i className='icon-angle-right'></i></span>
							</nav>
						</div>
					</section>
		}

		Slideshow_Function()
		{
			$(function()
			{
				var Page = (function()
				{				
					var $navArrows = $('#nav-arrows'),
					slitslider = $('#slider').slitslider
					({
						autoplay : true
					}),

					init = function(){
						initEvents()
					},

					initEvents = function()
					{
						$navArrows.children( ':last' ).on( 'click', function()
						{
							slitslider.next()
							return false
						})
						$navArrows.children( ':first' ).on( 'click', function()
						{
							slitslider.previous()
							return false
						})
					}
					return { init : init }
				})()

				Page.init()
			})

		}
	}

	let JSON_Object = JSON.parse(JSON_String_Church)

	var arr = []
	Object.keys(JSON_Object).forEach(function(key) {
		arr.push(JSON_Object[key])
	})

	const Asd = (Church_Daughter) => 
	{	
		console.log(Church_Daughter)

		//alert(Church_Daughter.data['Church_Identity'])

		return <div className='span3'>
					<div className='box' >
						<p><a href='#'><img src='hr1_template/images/sample/team1.jpg' className='img'/></a></p>
						<center><h5>{'Name'}<br/>{'Position Displayed'}</h5>
							<h4 style = {{'color' : '#0eb8ce'}} >Christ is the Answer Niugan</h4>
									16. F. Nicolas St. Niugan, Malabon City
						</center>
					</div>
				</div>
	}

	class Church_Daughter extends Component
	{
		constructor()
		{
			super()

			console.log('Succesfully Loaded : CITACH_Client_Home Class')
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : Church_Daughter Class')
		}

		render()
		{
			return	<section>
						<h1 className='center'>DAUGHTER CHURCHES</h1>
						<br/>
						<div className="container">
							<div className='row'>
							{
								arr.map(Data =>
								{
									return <Asd key = { Data.Church_Identity } data = { Data }/>
								})
							}
							</div>
						</div>
					</section>
		}
	}

	return class extends Component
	{
		constructor()
		{
			super()

			console.log('Succesfully Loaded : CITACH_Client_Home Class')
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Client_Home Class')
		}

		render()
		{
			return	<div>
						<Slideshow/>
						<Church_Daughter/>
					</div>
		}
	}
})