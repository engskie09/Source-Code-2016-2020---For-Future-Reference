define('CITACH_Client_Gallery', function()
{


	let JSON_Object = JSON.parse(JSON_String_Gallery_Image)

	var arr = []
	Object.keys(JSON_Object).forEach(function(key) {
		arr.push(JSON_Object[key])
	})

	const Image = (Gallery_Image) =>
	{	
		console.log(Gallery_Image)	
		return	<div>
					<ul className = 'gallery col-4'>
						<li>
							<div className = 'preview' style = {{ 'height' : '250px', 'width' : '250px' }}>
								<img src = { Gallery_Image.data.Gallery_Image_Path } style = {{ 'height' : '250px', 'width' : '250px' }}/>
								<div className = 'overlay'></div>
								<div className = 'links'>
								<a data-toggle = 'modal' href = { '#' + Gallery_Image.data.Gallery_Image_Identity }><i className = 'icon-eye-open'></i></a><a href = '#'><i className = 'icon-link'></i></a>
								</div>
							</div>

							<div className = 'desc text-center'>
								<h5>Images</h5>
								<small>Portfolio item short description</small>
							</div>

							<div id = { Gallery_Image.data.Gallery_Image_Identity } className = 'modal hide fade'>
								<a className = 'close-modal' data-dismiss = 'modal' aria-hidden = 'true'><i className = 'icon-remove'></i></a>
								<div className = 'modal-body'>
									<img src = { Gallery_Image.data.Gallery_Image_Path } width = '100%' style = {{ 'maxHeight' : '400px' }}/>
								</div>
							</div>
						</li>
					</ul>
				</div>
		
	}

``

	return class extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Client_Gallery Class')

			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Client_Gallery Class')
		}

		render()
		{
			return	<div>
						<section className = 'title'>
							<div className = 'container'>
								<div className = 'row-fluid'>
									<div className = 'span6'>
										<h1>Gallery</h1>
									</div>
									<div className = 'span6'>
										<ul className = 'breadcrumb pull-right'>
											<li><Link to = '/Home'>Home</Link><span className = 'divider'>/</span></li>
											<li className = 'active'>Gallery</li>
										</ul>
									</div>
								</div>
							</div>
						</section>

						<br/>

						<section id = 'portfolio' className = 'container main'>
						{
							arr.map(Data =>
							{
								return <Image key = { Data.Gallery_Image_Identity } data = { Data }/>
							})
						}
						</section>

					</div>
		}
	}
})