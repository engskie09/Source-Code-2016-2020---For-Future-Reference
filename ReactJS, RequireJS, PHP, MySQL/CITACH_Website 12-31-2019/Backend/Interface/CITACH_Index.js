define('CITACH_Server_Index', function()
{
	class CITACH_Server_Index extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Server_Index Class')

			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Server_Index Class')
			//<Redirect to = '/'/>
		}

		render()
		{
			return	<div id = 'wrapper'>
						<BrowserRouter>

							<CITACH_Server_Header_Sidebar/>

							<Switch>								
								<Route exact path = '/Dashboard' component = { CITACH_Server_Dashboard }/>
								<Route exact path = '/Church' component = { CITACH_Server_Church }/>
								<Route exact path = '/Member' component = { CITACH_Server_Member }/>								
								<Redirect to = '/Dashboard'/>
							</Switch>

							<CITACH_Server_Footer/>
						</BrowserRouter>
					</div>
		}

		static test()
		{
			alert('wewe')
		}

		static set_Image_Upload_Preview(set_Input_Identity, set_Image_Identity)
		{
			$('#' + set_Input_Identity).change(function()
			{
				var get_Image = document.querySelector('#' + set_Image_Identity)
				var get_Input    = document.querySelector('#' + set_Input_Identity).files[0]
				var get_FileReader  = new FileReader();

				get_FileReader.onloadend = function(Show_Dialog_Image)
				{
					get_Image.src = get_FileReader.result
				}

				if(get_Input != undefined)
					get_FileReader.readAsDataURL(get_Input)

				else
					get_Image.src = URL_No_Image

			})
		}
	}

	window.URL_Base = 'Backend/'
	window.URL_No_Image = 'Data/System/Image/No_Image.png'

	window.CITACH_Server_Index = CITACH_Server_Index

	ReactDOM.render(<CITACH_Server_Index/>, $('#main')[0])
})