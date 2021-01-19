define('CITACH_Client_Index', function()
{
	class CITACH_Client_Index extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Client_Index Class')

			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Client_Index Class')
		}

		render()
		{
			return	<div>
						<BrowserRouter>

							<CITACH_Client_Header/>

							<Switch>
								<Route exact path='/' component = { CITACH_Client_Home }/>
								<Route exact path='/Home' component = { CITACH_Client_Home }/>
								<Route exact path='/About' component = { CITACH_Client_About }/>
								<Route exact path='/Ministry' component = { CITACH_Client_Ministry }/>
								<Route exact path='/Gallery' component = { CITACH_Client_Gallery }/>
								<Route exact path='/Sermon' component = {() => <div>Sermon</div>}/>
								<Route exact path='/Give' component = {() => <div>Give</div>}/>
								<Route exact path='/Contact' component = { CITACH_Client_Contact }/>
								<Route exact path='/Other' component = {() => {return <div>Other</div>}}/>
							</Switch>

							<CITACH_Client_Footer/>
						</BrowserRouter>
					</div>
		}
	}

	ReactDOM.render(<CITACH_Client_Index/>, $('#main')[0])
})