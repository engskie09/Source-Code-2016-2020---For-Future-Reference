define('CITACH_Server_Footer', function()
{
	class CITACH_Server_Footer extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Server_Footer Class')

			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Server_Footer Class')
		}

		render()
		{
			return <div>CITACH_Server_Footer</div>
		}
	}

	window.CITACH_Server_Footer = CITACH_Server_Footer
})