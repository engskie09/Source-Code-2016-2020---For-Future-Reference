define('ECIMS_Cooperative', () =>
{
	class ECIMS_Cooperative extends Component
	{
		constructor()
		{
			if (System_Mode == 'Development')
				console.log('Succesfully Loaded : ECIMS_Cooperative Class')

			super()

			this.state =
			{
				'Action'																:	'',
				'Interface'																:	<div></div>,
				'Card_State'															:	'Minimize',

				'Cooperative_Member_Composition'										:	[],
				'Cooperative_Member_Projected_Growth'									:	[],
				'Cooperative_Member_Projected_Growth_Key_Counter'						:	0,

				'EconomicAspect_Strategy'												:	[],
				'EconomicAspect_Strategy_Key_Counter'									:	0,
				'EconomicAspect_Activity'												:	[],
				'EconomicAspect_Activity_Key_Counter'									:	0,

				'FinancialAspect_Capitalization_Generate_Capital'						:	[],
				'FinancialAspect_Capitalization_Internal_Capital_Strategy'				:	[],
				'FinancialAspect_Capitalization_Internal_Capital_Strategy_Key_Counter'	:	0,
				'FinancialAspect_Revenue_Projected'										:	[],
				'FinancialAspect_Revenue_Projected_Key_Counter'							:	0,
				'FinancialAspect_Expense_Estimated'										:	[],
				'FinancialAspect_Expense_Estimated_Key_Counter'							:	0,
				'FinancialAspect_Organization_Investment'								:	[],

				'TechnicalAspect_Equipment'												:	[],
				'TechnicalAspect_Machinery'												:	[],
				'TechnicalAspect_Facility'												:	[],
				'TechnicalAspect_Procurement_Mode'										:	[],
				'TechnicalAspect_Operator_Background'									:	[],
				'TechnicalAspect_Operator_Background_Key_Counter'						:	0,

				'OrganizationalStructure_Member_Eligibility'							:	[],
				'OrganizationalStructure_Member_Eligibility_Key_Counter'				:	0,
				'OrganizationalStructure_Program'										:	[],
				'OrganizationalStructure_Program_Key_Counter'							:	0,

				'OrganizationalStructure_Member'										:	[],
				'OrganizationalStructure_Member_Chart'									:	[],
				'OrganizationalStructure_Committee'										:	[],
				'OrganizationalStructure_Committee_Member'								:	[],

				'Cooperative'															:	[],
				'Cooperative_Type'														:	[],
				'Cooperative_Category'													:	[],
				'Cooperative_OperationArea'												:	[],
				'Cooperative_CommonBond'												:	[],
				'Cooperative_Capitalization'											:	[],
				'Philippines_Organization'												:	[],
				'Philippines_Region'													:	[],
				'Philippines_Region_Province'											:	[],
				'Philippines_Region_Province_Locality'									:	[],

				'Cooperative_Pending'													:	[],
				'Cooperative_Confirmed'													:	[],
				'Cooperative_Declined'													:	[],
				'Cooperative_Associated'												:	[],
				'Cooperative_Dissociated'												:	[],
				'Cooperative_Requested'													:	[],
				'Cooperative_Cancelled'													:	[],

				'User_Member_Information'												:	[],

				'Cooperative_Applicant'													:	[],
				'Cooperative_Member'													:	[]
			}

			this.Element =
			{
				'Cooperative_Identity'								:	React.createRef(),
				'Cooperative_Name'									:	React.createRef(),
				'Cooperative_Background'							:	React.createRef(),
				'Cooperative_Rationale'								:	React.createRef(),
				'Cooperative_Type'									:	React.createRef(),
				'Cooperative_Category'								:	React.createRef(),
				'Cooperative_Region'								:	React.createRef(),
				'Cooperative_Province'								:	React.createRef(),
				'Cooperative_Locality'								:	React.createRef(),
				'Cooperative_Office_Address'						:	React.createRef(),
				'Cooperative_Operation_Area'						:	React.createRef(),
				'Cooperative_Common_Bond'							:	React.createRef(),
				'Cooperative_Member_Composition'					:	React.createRef(),
				'Cooperative_Founder'								:	React.createRef(),
				'Cooperative_Organization_Registration'				:	React.createRef(),
				'ShareCapital_Authorized'							:	React.createRef(),
				'ShareCapital_Issued'								:	React.createRef(),
				'ShareCapital_Unissued'								:	React.createRef(),
				'ShareCapital_Subscribed'							:	React.createRef(),
				'ShareCapital_Unsubscribed'							:	React.createRef(),
				'ShareCapital_Called-Up'							:	React.createRef(),
				'ShareCapital_Uncalled'								:	React.createRef(),
				'ShareCapital_Paid-Up'								:	React.createRef(),
				'ShareCapital_Unpaid'								:	React.createRef(),
				'ShareCapital_Reserve'								:	React.createRef(),
				'ShareCapital_Par_Value'							:	React.createRef(),
				'ShareCapital_Share_Sold'							:	React.createRef(),
				'ShareCapital_Authorized_Summary'					:	React.createRef(),
				'ShareCapital_Subscribed_Summary'					:	React.createRef(),
				'ShareCapital_Paid-Up_Summary'						:	React.createRef(),
				'ShareCapital_Par_Value_Summary'					:	React.createRef(),
				'EconomicAspect_Identical_Cooperative_Plan'			:	React.createRef(),
				'EconomicAspect_Target_Market'						:	React.createRef(),
				'FinancialAspect_Capitalization_Generate_Capital'	:	React.createRef(),
				'FinancialAspect_Capitalization_Initial_Capital'	:	React.createRef(),
				'FinancialAspect_Organization_Investment'			:	React.createRef(),
				'TechnicalAspect_Equipment'							:	React.createRef(),
				'TechnicalAspect_Machinery'							:	React.createRef(),
				'TechnicalAspect_Facility'							:	React.createRef(),
				'TechnicalAspect_Procurement_Mode'					:	React.createRef(),
				'OrganizationalStructure_Member_Chart'				:	React.createRef(),

				'Form_Cooperative_1'								:	React.createRef(),
				'Form_Cooperative_2'								:	React.createRef(),
				'Form_Cooperative_ShareCapital'						:	React.createRef(),
				'Form_Cooperative_EconomicAspect'					:	React.createRef(),
				'Form_Cooperative_FinancialAspect'					:	React.createRef(),
				'Form_Cooperative_TechnicalAspect'					:	React.createRef(),
				'Form_Cooperative_OrganizationalStructure'			:	React.createRef(),
				'Form_Cooperative_OrganizationalStructure_Remark'	:	React.createRef(),
				'Table_OrganizationalStructure_Member'				:	React.createRef(),
				'Table_OrganizationalStructure_Committee'			:	React.createRef(),
				'Table_Cooperative_OrganizationalStructure_Remark'	:	React.createRef(),
				'Table_Cooperative_Requested'						:	React.createRef(),

				'Table_Cooperative_Pending'							:	React.createRef(),
				'Table_Cooperative_Confirmed'						:	React.createRef(),
				'Table_Cooperative_Declined'						:	React.createRef(),
				'Table_Cooperative_Cancelled'						:	React.createRef(),
				'Table_Cooperative_Associated'						:	React.createRef(),
				'Table_Cooperative_Dissociated'						:	React.createRef(),
				'Dialog_Cooperative_EconomicSurvey'					:	React.createRef(),

				'Tab_Cooperative_List'								:	React.createRef(),
				'Tab_Cooperative_Manage'							:	React.createRef(),
				'Table_Cooperative_Applicant'						:	React.createRef(),
				'Table_Cooperative_Member'							:	React.createRef(),
				'Table_Cooperative_Contribution'					:	React.createRef(),
				'Table_Cooperative_Loan'							:	React.createRef(),
				'Dialog_Cooperative_Member_Information'				:	React.createRef(),
				'Cooperator_Account'								:	React.createRef()
			}
		}

		check_Component_Mutablity(set_Component_Name)
		{
			if (this.state[set_Component_Name + '_Mutable'] == undefined)
				return false

			else
				return this.state[set_Component_Name + '_Mutable']
		}

		set_Component_Mutablity(set_Component_Name, set_Data)
		{
			this.state[set_Component_Name + '_Mutable'] = set_Data
		}

		ShareCapital_Manage()
		{
			let
			get_Element_A = $(this.Element['ShareCapital_Authorized'].current),
			get_Element_B = $(this.Element['ShareCapital_Issued'].current),
			get_Element_C = $(this.Element['ShareCapital_Unissued'].current),
			get_Element_D = $(this.Element['ShareCapital_Subscribed'].current),
			get_Element_E = $(this.Element['ShareCapital_Unsubscribed'].current),
			get_Element_F = $(this.Element['ShareCapital_Called-Up'].current),
			get_Element_G = $(this.Element['ShareCapital_Uncalled'].current),
			get_Element_H = $(this.Element['ShareCapital_Paid-Up'].current),
			get_Element_I = $(this.Element['ShareCapital_Unpaid'].current),
			get_Element_J = $(this.Element['ShareCapital_Reserve'].current),
			get_Element_K = $(this.Element['ShareCapital_Par_Value'].current),
			get_Element_L = $(this.Element['ShareCapital_Share_Sold'].current)

			let
			A = get_Element_A.val(),
			B = get_Element_B.val(),
			C = get_Element_C.val(),
			D = get_Element_D.val(),
			E = get_Element_E.val(),
			F = get_Element_F.val(),
			G = get_Element_G.val(),
			H = get_Element_H.val(),
			I = get_Element_I.val(),
			J = get_Element_J.val(),
			K = get_Element_K.val(),
			L = get_Element_L.val()

			B = K * L
			C = A - B
			E = B - D
			G = D - F
			I = F - H
			J = D - F

			get_Element_B.val(B)
			get_Element_C.val(C)
			get_Element_E.val(E)
			get_Element_G.val(G)
			get_Element_I.val(I)
			get_Element_J.val(J)

			$(this.Element['ShareCapital_Authorized_Summary'].current).val(A)
			$(this.Element['ShareCapital_Subscribed_Summary'].current).val(D)
			$(this.Element['ShareCapital_Paid-Up_Summary'].current).val(H)
			$(this.Element['ShareCapital_Par_Value_Summary'].current).val(K)

			console.log(A), console.log(B), console.log(C), console.log(D),
			console.log(E), console.log(F), console.log(G), console.log(H),
			console.log(I), console.log(J), console.log(K), console.log(L)
		}

		Update_Interface()
		{
			if (location.pathname == '/Cooperative/Add' || location.pathname == '/Cooperative/Create')
			{
				this.setState({ 'Interface' : this.get_Cooperative_EconomicSurvey_Interface() })
			}

			else if (location.pathname == '/Cooperative/List' || location.pathname == '/Cooperative/Associated' || location.pathname == '/Cooperative/Join')
			{
				this.setState({ 'Interface' : this.get_Cooperative_List_Interface() })
			}
		}

		async componentDidMount()
		{
			if (System_Mode == 'Development')
				console.log('Succesfully Executed componentDidMount() : ECIMS_Cooperative Class')

			this.Mounted = true

			if (location.pathname == '/Cooperative/Add' || location.pathname == '/Cooperative/Create')
			{
				System_Preloader.Show()

				let get_Cooperative_EconomicSurvey = System_Manipulator.System_Promise((set_Resolve) =>
				{
					let get_FormData = new FormData()
					get_FormData.append('Action', 'Cooperative_EconomicSurvey')
					get_FormData.append('User_Identity', Session_User_Identity())

					ECIMS_Main_HTTP.Select(get_FormData, set_Callback_Data =>
					{
						this.state['Cooperative']							=	JSON.parse(set_Callback_Data['Cooperative'])
						this.state['Cooperative_Requested']					=	JSON.parse(set_Callback_Data['Cooperative_Requested'])
						this.state['Cooperative_Type']						=	JSON.parse(set_Callback_Data['Cooperative_Type'])
						this.state['Cooperative_Category']					=	JSON.parse(set_Callback_Data['Cooperative_Category'])
						this.state['Cooperative_OperationArea']				=	JSON.parse(set_Callback_Data['Cooperative_OperationArea'])
						this.state['Cooperative_CommonBond']				=	JSON.parse(set_Callback_Data['Cooperative_CommonBond'])
						this.state['Cooperative_Capitalization']			=	JSON.parse(set_Callback_Data['Cooperative_Capitalization'])

						this.state['Philippines_Organization']				=	JSON.parse(set_Callback_Data['Philippines_Organization'])
						this.state['Philippines_Region']					=	JSON.parse(set_Callback_Data['Philippines_Region'])
						this.state['Philippines_Region_Province']			=	JSON.parse(set_Callback_Data['Philippines_Region_Province'])
						this.state['Philippines_Region_Province_Locality']	=	JSON.parse(set_Callback_Data['Philippines_Region_Province_Locality'])

						this.state['User_Member_Information']				=	JSON.parse(set_Callback_Data['User_Member_Information'])

						set_Resolve(true)
					})
				})

				if (this.Mounted && await get_Cooperative_EconomicSurvey)
					System_Preloader.Load(1e2, this, this.get_Cooperative_EconomicSurvey_Interface(), () =>
					{
						this.Initialize_Cooperative_EconomicSurvey()

						System_Preloader.Hide()
					})
			}

			else if (location.pathname == '/Cooperative/List' || location.pathname == '/Cooperative/Associated' || location.pathname == '/Cooperative/Join')
			{
				System_Preloader.Show()

				let get_Cooperative

				if (location.pathname == '/Cooperative/List')
					get_Cooperative = System_Manipulator.System_Promise((set_Resolve) =>
					{
						let get_FormData = new FormData()
						get_FormData.append('Action', 'Cooperative_List')

						ECIMS_Main_HTTP.Select(get_FormData, set_Callback_Data =>
						{
							this.state['Cooperative'] = JSON.parse(set_Callback_Data['Cooperative'])
							this.state['Cooperative_Type'] = JSON.parse(set_Callback_Data['Cooperative_Type'])
							this.state['Cooperative_Category'] = JSON.parse(set_Callback_Data['Cooperative_Category'])
							this.state['Cooperative_OperationArea'] = JSON.parse(set_Callback_Data['Cooperative_OperationArea'])
							this.state['Cooperative_CommonBond'] = JSON.parse(set_Callback_Data['Cooperative_CommonBond'])
							this.state['Cooperative_Capitalization'] = JSON.parse(set_Callback_Data['Cooperative_Capitalization'])

							this.state['Cooperative_Pending'] = JSON.parse(set_Callback_Data['Cooperative_Pending'])
							this.state['Cooperative_Confirmed'] = JSON.parse(set_Callback_Data['Cooperative_Confirmed'])
							this.state['Cooperative_Declined'] = JSON.parse(set_Callback_Data['Cooperative_Declined'])
							this.state['Cooperative_Cancelled'] = JSON.parse(set_Callback_Data['Cooperative_Cancelled'])

							this.state['Philippines_Organization'] = JSON.parse(set_Callback_Data['Philippines_Organization'])
							this.state['Philippines_Region'] = JSON.parse(set_Callback_Data['Philippines_Region'])
							this.state['Philippines_Region_Province'] = JSON.parse(set_Callback_Data['Philippines_Region_Province'])
							this.state['Philippines_Region_Province_Locality'] = JSON.parse(set_Callback_Data['Philippines_Region_Province_Locality'])

							set_Resolve(true)
						})
					})

				else if (location.pathname == '/Cooperative/Associated')
					get_Cooperative = System_Manipulator.System_Promise((set_Resolve) =>
					{
						let get_FormData = new FormData()
						get_FormData.append('Action', 'Cooperative_Associated')
						get_FormData.append('User_Identity', Session_User_Identity())

						ECIMS_Main_HTTP.Select(get_FormData, set_Callback_Data =>
						{
							this.state['Cooperative'] = JSON.parse(set_Callback_Data['Cooperative'])
							this.state['Cooperative_Type'] = JSON.parse(set_Callback_Data['Cooperative_Type'])
							this.state['Cooperative_Category'] = JSON.parse(set_Callback_Data['Cooperative_Category'])
							this.state['Cooperative_OperationArea'] = JSON.parse(set_Callback_Data['Cooperative_OperationArea'])
							this.state['Cooperative_CommonBond'] = JSON.parse(set_Callback_Data['Cooperative_CommonBond'])
							this.state['Cooperative_Capitalization'] = JSON.parse(set_Callback_Data['Cooperative_Capitalization'])

							this.state['Cooperative_Associated'] = JSON.parse(set_Callback_Data['Cooperative_Associated'])
					
							this.state['Philippines_Organization'] = JSON.parse(set_Callback_Data['Philippines_Organization'])
							this.state['Philippines_Region'] = JSON.parse(set_Callback_Data['Philippines_Region'])
							this.state['Philippines_Region_Province'] = JSON.parse(set_Callback_Data['Philippines_Region_Province'])
							this.state['Philippines_Region_Province_Locality'] = JSON.parse(set_Callback_Data['Philippines_Region_Province_Locality'])

							this.state['User_Member_Information'] = JSON.parse(set_Callback_Data['User_Member_Information'])

							set_Resolve(true)
						})
					})

				else if (location.pathname == '/Cooperative/Join')
					get_Cooperative = System_Manipulator.System_Promise((set_Resolve) =>
					{
						let get_FormData = new FormData()
						get_FormData.append('Action', 'Cooperative_Dissociated')
						get_FormData.append('User_Identity', Session_User_Identity())

						ECIMS_Main_HTTP.Select(get_FormData, set_Callback_Data =>
						{
							this.state['Cooperative'] = JSON.parse(set_Callback_Data['Cooperative'])
							this.state['Cooperative_Type'] = JSON.parse(set_Callback_Data['Cooperative_Type'])
							this.state['Cooperative_Category'] = JSON.parse(set_Callback_Data['Cooperative_Category'])
							this.state['Cooperative_OperationArea'] = JSON.parse(set_Callback_Data['Cooperative_OperationArea'])
							this.state['Cooperative_CommonBond'] = JSON.parse(set_Callback_Data['Cooperative_CommonBond'])
							this.state['Cooperative_Capitalization'] = JSON.parse(set_Callback_Data['Cooperative_Capitalization'])

							this.state['Cooperative_Dissociated'] = JSON.parse(set_Callback_Data['Cooperative_Dissociated'])
							this.state['Cooperative_Pending'] = JSON.parse(set_Callback_Data['Cooperative_Pending'])
							this.state['Cooperative_Declined'] = JSON.parse(set_Callback_Data['Cooperative_Declined'])

							this.state['Philippines_Organization'] = JSON.parse(set_Callback_Data['Philippines_Organization'])
							this.state['Philippines_Region'] = JSON.parse(set_Callback_Data['Philippines_Region'])
							this.state['Philippines_Region_Province'] = JSON.parse(set_Callback_Data['Philippines_Region_Province'])
							this.state['Philippines_Region_Province_Locality'] = JSON.parse(set_Callback_Data['Philippines_Region_Province_Locality'])

							set_Resolve(true)
						})
					})

				if (this.Mounted && await get_Cooperative)
					System_Preloader.Load(1e2, this, this.get_Cooperative_List_Interface(), () =>
					{
						this.Initialize_Cooperative_List()

						System_Preloader.Hide()
					})
			}

			/*else if (location.pathname == '/Cooperative/Associated')
			{

			}

			else if (location.pathname == '/Cooperative/Join')
			{

			}*/

			else
				System_Preloader.Load(1e2, this, <ECIMS_Sample/>, () => {})
		}

		shouldComponentUpdate()
		{
			return true
		}

		componentWillUnmount()
		{
			this.Mounted = false
		}

		render()
		{
			if (System_Mode == 'Development')
				console.log('Succesfully Executed render() : ECIMS_Cooperative Class')

			return	this.state['Interface']
		}
	}

	window.ECIMS_Cooperative = ECIMS_Cooperative
})