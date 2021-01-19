define('CITACH_Client_Contact', function()
{
	return class extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Client_Contact Class')

			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Client_Contact Class')
		}

		render()
		{	
			return	<section id = 'contact-page' className = 'container'>
			<hr/><hr/><hr/>
    <div className = 'row-fluid'>
        <div className = 'span8'>
            <form id = 'main-contact-form' className = 'contact-form' name = 'contact-form' method = 'post' action = 'contact-us.send.php'>
                <div className = 'row-fluid'>
                    <div className = 'span5'>
                        <label>Full Name</label>
                        <input type = 'text' className = 'input-block-level' required = 'required' placeholder = 'Your Full Name' id = 'name' name = 'name'/>
                        <label>Email Address</label>
                        <input type = 'text' className = 'input-block-level' required = 'required' placeholder = 'Your Email Address' id = 'email' name = 'email'/>
                        <label>Telephone</label>
                        <input type = 'text' className = 'input-block-level' required = 'required' placeholder = 'Your Telephone' id = 'phone' name = 'phone'/>
                    </div>
                    <div className = 'span7'>
                        <label>Message</label>
                        <textarea name = 'message' id = 'message' required = 'required' className = 'input-block-level' rows = '8'></textarea>
                    </div>
                </div>
                <button type = 'submit' className = 'btn btn-primary btn-large pull-right'>Send Message</button>
            </form>
        </div>

        <div className = 'span3'>
                <div style = {{'height' : '60px'}}></div>
                <h4>Christ is the Answer Church</h4>
                <p>Love God | Love Others | Make Disciples | Plant Churches</p>
                <p>
                    <i className = 'icon-map-marker pull-left'></i> 16F Nicolas St.<br/>
                    Niugan, Malabon City Philippines
                </p>
                <p>
                    <i className = 'icon-envelope'></i> &nbsp;<a href = 'mailto:company@domain.com'>citamalabon@gmail.com</a>
                </p>
                <p>
                    <i className = 'icon-phone'></i> &nbsp;09750484476
                </p>
                <p>
                    <i className = 'icon-globe'></i> &nbsp;<a href = 'http://www.domain.com'>www.christistheanswer.com</a>
                </p>
            </div>
    </div>
</section>
		}
	}
})