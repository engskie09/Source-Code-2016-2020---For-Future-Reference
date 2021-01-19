define('ECIMS_Cooperative_Manage', () =>
{
	class ECIMS_Cooperative_Manage extends ECIMS_Cooperative
	{
		constructor()
		{
			if (System_Mode == 'Development')
				console.log('Succesfully Loaded : ECIMS_Cooperative_Manage Class')

			super()
		}

		Select_User(set_Data)
		{
			this.Element['Dialog_Cooperative_Member_Information'].current.Title = 'Loading User Information'
			this.Element['Dialog_Cooperative_Member_Information'].current.Size = 'Small'
			//this.Element['Dialog_Cooperative_EconomicSurvey'].current.Closable = true
			this.Element['Dialog_Cooperative_Member_Information'].current.Mode = 'Wait'
			this.Element['Dialog_Cooperative_Member_Information'].current.Hide_Button()
			this.Element['Dialog_Cooperative_Member_Information'].current.Show()

			this.set_Component_Mutablity('Cooperative_EconomicSurvey')

			let get_FormData = new FormData()
			get_FormData.append('Action', 'Cooperator_Account')
			get_FormData.append('User_Identity', set_Data)

			ECIMS_Main_HTTP.Select(get_FormData, set_Callback_Data =>
			{
				this.Element['Dialog_Cooperative_Member_Information'].current.Title = 'User Information'
				this.Element['Dialog_Cooperative_Member_Information'].current.Size = 'Large'
				this.Element['Dialog_Cooperative_Member_Information'].current.Mode = 'Custom'
				this.Element['Dialog_Cooperative_Member_Information'].current.Show_Button()

				this.Element['Cooperator_Account'].current.state['User_Information'] = JSON.parse(set_Callback_Data['User_Information'])[0]
				this.Element['Cooperator_Account'].current.state['User_Gender'] = JSON.parse(set_Callback_Data['User_Gender'])
				this.Element['Cooperator_Account'].current.set_Component_Mutablity('Cooperator_Account', false)
				this.Element['Cooperator_Account'].current.Update_Interface()

				this.Element['Cooperator_Account'].current.set_Cooperator_Account_Data(this.Element['Cooperator_Account'].current.state['User_Information'])
				this.Element['Cooperator_Account'].current.Initialize_Cooperator_Account()
			})
		}

		Manage_User(set_Action, set_Data, set_Element)
		{
			let get_Promise = new Promise(System_Manipulator.System_Dialog_Promise)

			System_Dialog.Title = 'Are You sure?'
			System_Dialog.Size = 'Small'
			System_Dialog.Mode = 'Choice'
			System_Dialog.Alert_Interface = 'Warning'

			let get_FormData = new FormData()

			if (set_Action == 'Confirm')
			{
				System_Dialog.Alert_Text = 'Confirm Application'

				get_FormData.append('Action', 'Update_Cooperative_OrganizationalStructure_Member')
				get_FormData.append('Update_Action', 'Update : Specific : [ Member_Position, Member_State ] : { Cooperative_Identity, Member_Identity }')
				get_FormData.append('Member_Identity', set_Data)
				get_FormData.append('Cooperative_Identity', this.Cooperative_Identity)

				get_FormData.append('Member_Position', '["Member"]')
				get_FormData.append('Member_State', 'Confirmed')

			}

			else if (set_Action == 'Decline')
			{
				System_Dialog.Alert_Text = 'Cancel Application'

				get_FormData.append('Action', 'Update_Cooperative_OrganizationalStructure_Member')
				get_FormData.append('Update_Action', 'Update : Specific : [ Member_Position, Member_State ] : { Cooperative_Identity, Member_Identity }')
				get_FormData.append('Cooperative_Identity', this.Cooperative_Identity)
				get_FormData.append('Member_Identity', set_Data)

				get_FormData.append('Member_Position', '["Member"]')
				get_FormData.append('Member_State', 'Declined')
			}

			get_Promise.then((set_Resolve_Data) =>
			{
				if (set_Resolve_Data == 'Yes')
				{
					System_Dialog.Title = 'Loading...'
					System_Dialog.Mode = 'Wait'
					System_Dialog.Hide_Button()

					ECIMS_Main_HTTP.Manage(get_FormData, set_Callback_Data =>
					{
						if (set_Action == 'Confirm' || set_Action == 'Decline')
						{
							let get_Element = set_Element != null ? $(set_Element).parent() : false
							let get_RowIndex = this.Table_Cooperative_Applicant.DataTable().row(get_Element).index()

							this.Table_Cooperative_Applicant.DataTable().row(get_RowIndex).remove().draw()

							let get_FormData = new FormData()

							get_FormData.append('Action', 'Select_User')
							get_FormData.append('Select_Action', 'Select : Specific : { { Cooperative_Identity, Member_State } }')
							get_FormData.append('Cooperative_Identity', this.Cooperative_Identity)
							get_FormData.append('Member_State', 'Confirmed')

							ECIMS_Main_HTTP.Select(get_FormData, set_Callback_Data =>
							{
								this.state['Cooperative_Member'] = set_Callback_Data
								this.Initialize_Table_Cooperative_Member()
							})
						}

						setTimeout(() => System_Dialog.Hide(), 1000)
					})
				}

				else if (set_Resolve_Data == 'No')
					System_Dialog.Hide()
				
				else
					console.log('No Resolve Data')
			})
		}

		Initialize_Cooperative_Manage()
		{
			$(this.Element['Table_Cooperative_Member'].current).parent().css('display', 'block')
			$(this.Element['Table_Cooperative_Applicant'].current).parent().css('display', 'none')

			const Initialize_Cooperative_Applicant = (() =>
			{
				this.Table_Cooperative_Applicant = $(this.Element['Table_Cooperative_Applicant'].current)				
				this.Table_Cooperative_Applicant.DataTable().clear().destroy()

				this.Table_Cooperative_Applicant.DataTable
				({
					'data'			:	this.state['Cooperative_Applicant'],
					'columnDefs'	:
					[
						{
							'className'	:	'text-center',
							'targets'	:	'_all'
						}
					],

					'columns'	:
					[
						{ 'data' : 'User_Firstname' },
						{ 'data' : 'User_Middlename' },
						{ 'data' : 'User_Lastname' },

						{
							'data' : null,
							'orderable' : false,
							'createdCell' : (set_Cell, set_CellData, set_RowData, set_RowIndex, set_ColumnIndex) =>
							{
								let get_Position
								let get_Member_Identity

								for (let get_Counter = 0; get_Counter < this.state['User_Member_Information'].length; get_Counter ++)
								{
									if (this.Cooperative_Identity == this.state['User_Member_Information'][get_Counter]['Cooperative_Identity'])
									{
										get_Position = JSON.parse(this.state['User_Member_Information'][get_Counter]['Member_Position'])
										get_Member_Identity = this.state['User_Member_Information'][get_Counter]['Member_Identity']
										break
									}
								}

								if (get_Position.includes('Owner'))
								{
									ReactDOM.render
									(
										<div className = 'd-flex justify-content-center flex-column'>
											<div className = 'p-1'>
												<button onClick = { () => this.Select_User(set_CellData['User_Identity']) } type = 'button' className = 'btn btn-info waves-effect DataTable_Button'>View</button>
											</div>

											<div className = 'p-1'>
												<button onClick = { () => this.Manage_User('Confirm', set_CellData['User_Identity'], set_Cell) } type = 'button' className = 'btn btn-warning waves-effect DataTable_Button'>Confirm</button>
											</div>

											<div className = 'p-1'>
												<button onClick = { () => this.Manage_User('Decline', set_CellData['User_Identity'], set_Cell) } type = 'button' className = 'btn btn-danger waves-effect DataTable_Button'>Decline</button>
											</div>
										</div>
										,set_Cell
									)
								}

								else if (get_Position.includes('Member'))
								{
									ReactDOM.render
									(
										<div className = 'd-flex justify-content-center flex-column'>
											<div className = 'p-1'>
												<button onClick = { () => this.Select_User(set_CellData['User_Identity']) } type = 'button' className = 'btn btn-info waves-effect DataTable_Button'>View</button>
											</div>
										</div>
										,set_Cell
									)
								}
							}
						}
					],

					'lengthMenu'	:
					[
						[15, 30, 45, -1],
						['15 Rows', '30 Rows', '45 Rows', 'Everything']
					],

					'language'		:	{ 'searchPlaceholder' : 'Search for records...' },
					'sDom'			:	'<"dataTables__top"flB<"dataTables_actions">>rt<"dataTables__bottom"ip><"clear">',
					'buttons'		:
					[
						{
							extend	:	'excelHtml5',
							title	:	'Export Data'
						},

						{
							extend	:	'csvHtml5',
							title	:	'Export Data'
						},

						{
							extend	:	'print',
							title	:	'Etherium Transaction'
						}
					],

					'initComplete'	:	() =>
					{
						ReactDOM.render
						(
							<div>
								<i className = 'zwicon-more-h' data-toggle = 'dropdown'></i>
								<div className = 'dropdown-menu dropdown-menu-right'>
									<a onClick =
									{
										set_Event =>
										{
											$(set_Event.target).parent().parent().parent().prev().children('.buttons-print').click()
										}
									}
									className = 'dropdown-item'>Print</a>
									<div className = 'dropdown-divider'></div>
									<div className = 'dropdown-header border-bottom-0 pt-0'>
										<small>Download as</small>
									</div>
									<a onClick =
									{
										set_Event =>
										{
											$(set_Event.target).parent().parent().parent().prev().children('.buttons-excel').click()
										}
									}
									className = 'dropdown-item'>Excel (.xlsx)</a>
									<a onClick =
									{
										set_Event =>
										{
											$(set_Event.target).parent().parent().parent().prev().children('.buttons-csv').click()
										}
									}
									className = 'dropdown-item'>CSV (.csv)</a>
								</div>
							</div>,
							$(this.Element['Table_Cooperative_Applicant'].current).parent().find('.dataTables_actions')[0]
						)
					},
				})

				
			})()

			this.Initialize_Table_Cooperative_Member = (() =>
			{
				this.Table_Cooperative_Member = $(this.Element['Table_Cooperative_Member'].current)				
				this.Table_Cooperative_Member.DataTable().clear().destroy()

				this.Table_Cooperative_Member.DataTable
				({
					'data'			:	this.state['Cooperative_Member'],
					'columnDefs'	:
					[
						{
							'className'	:	'text-center',
							'targets'	:	'_all'
						}
					],

					'columns'	:
					[
						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								
								return set_Data['User_Firstname'] + ' ' + set_Data['User_Lastname']
							}
						},

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								return JSON.parse(set_Data['Member_Position']).join(', ')
							}
						},

						{
							'data' : null,
							'orderable' : false,
							'createdCell' : (set_Cell, set_CellData, set_RowData, set_RowIndex, set_ColumnIndex) =>
							{
								let get_Position
								let get_Member_Identity

								for (let get_Counter = 0; get_Counter < this.state['User_Member_Information'].length; get_Counter ++)
								{
									if (this.Cooperative_Identity == this.state['User_Member_Information'][get_Counter]['Cooperative_Identity'])
									{
										get_Position = JSON.parse(this.state['User_Member_Information'][get_Counter]['Member_Position'])
										get_Member_Identity = this.state['User_Member_Information'][get_Counter]['Member_Identity']
										break
									}
								}

								if (get_Position.includes('Owner'))
								{
									if (set_CellData['User_Identity'] != get_Member_Identity)
										ReactDOM.render
										(
											<div className = 'd-flex justify-content-center flex-column'>
												<div className = 'p-1'>
													<button onClick = { () => this.Select_User(set_CellData['User_Identity']) } type = 'button' className = 'btn btn-info waves-effect DataTable_Button'>View</button>
												</div>
												<div className = 'p-1'>
													<button onClick = { () => this.Manage_User('Kick', set_CellData['User_Identity'], set_Cell) } type = 'button' className = 'btn btn-danger waves-effect DataTable_Button'>Kick</button>
												</div>
											</div>
											,set_Cell
										)

									else
										ReactDOM.render
										(
											<div></div>
											,set_Cell
										)
								}

								else if (get_Position.includes('Member'))
								{
									ReactDOM.render
									(
										<div className = 'd-flex justify-content-center flex-column'>
											<div className = 'p-1'>
												<button onClick = { () => this.Select_User(set_CellData['User_Identity']) } type = 'button' className = 'btn btn-info waves-effect DataTable_Button'>View</button>
											</div>
										</div>
										,set_Cell
									)
								}
							}
						}
					],

					'lengthMenu'	:
					[
						[15, 30, 45, -1],
						['15 Rows', '30 Rows', '45 Rows', 'Everything']
					],

					'language'		:	{ 'searchPlaceholder' : 'Search for records...' },
					'sDom'			:	'<"dataTables__top"flB<"dataTables_actions">>rt<"dataTables__bottom"ip><"clear">',
					'buttons'		:
					[
						{
							extend	:	'excelHtml5',
							title	:	'Export Data'
						},

						{
							extend	:	'csvHtml5',
							title	:	'Export Data'
						},

						{
							extend	:	'print',
							title	:	'Etherium Transaction'
						}
					],

					'initComplete'	:	() =>
					{
						ReactDOM.render
						(
							<div>
								<i className = 'zwicon-more-h' data-toggle = 'dropdown'></i>
								<div className = 'dropdown-menu dropdown-menu-right'>
									<a onClick =
									{
										set_Event =>
										{
											$(set_Event.target).parent().parent().parent().prev().children('.buttons-print').click()
										}
									}
									className = 'dropdown-item'>Print</a>
									<div className = 'dropdown-divider'></div>
									<div className = 'dropdown-header border-bottom-0 pt-0'>
										<small>Download as</small>
									</div>
									<a onClick =
									{
										set_Event =>
										{
											$(set_Event.target).parent().parent().parent().prev().children('.buttons-excel').click()
										}
									}
									className = 'dropdown-item'>Excel (.xlsx)</a>
									<a onClick =
									{
										set_Event =>
										{
											$(set_Event.target).parent().parent().parent().prev().children('.buttons-csv').click()
										}
									}
									className = 'dropdown-item'>CSV (.csv)</a>
								</div>
							</div>,
							$(this.Element['Table_Cooperative_Member'].current).parent().find('.dataTables_actions')[0]
						)
					},
				})
			})

			this.Initialize_Table_Cooperative_Member()

			const Initialize_Cooperative_Finance = (() =>
			{
				this.Table_Cooperative_Contribution = $(this.Element['Table_Cooperative_Contribution'].current)				
				//this.Table_Cooperative_Contribution.DataTable().clear().destroy()

				this.Table_Cooperative_Contribution.DataTable
				({
					'columnDefs'	:
					[
						{
							'className'	:	'text-center',
							'targets'	:	'_all'
						}
					],

					'lengthMenu'	:
					[
						[15, 30, 45, -1],
						['15 Rows', '30 Rows', '45 Rows', 'Everything']
					],

					'language'		:	{ 'searchPlaceholder' : 'Search for records...' },
					'sDom'			:	'<"dataTables__top"flB<"dataTables_actions">>rt<"dataTables__bottom"ip><"clear">',
					'buttons'		:
					[
						{
							extend	:	'excelHtml5',
							title	:	'Export Data'
						},

						{
							extend	:	'csvHtml5',
							title	:	'Export Data'
						},

						{
							extend	:	'print',
							title	:	'Etherium Transaction'
						}
					],

					'initComplete'	:	() =>
					{
						ReactDOM.render
						(
							<div>
								<i className = 'zwicon-more-h' data-toggle = 'dropdown'></i>
								<div className = 'dropdown-menu dropdown-menu-right'>
									<a onClick =
									{
										set_Event =>
										{
											$(set_Event.target).parent().parent().parent().prev().children('.buttons-print').click()
										}
									}
									className = 'dropdown-item'>Print</a>
									<div className = 'dropdown-divider'></div>
									<div className = 'dropdown-header border-bottom-0 pt-0'>
										<small>Download as</small>
									</div>
									<a onClick =
									{
										set_Event =>
										{
											$(set_Event.target).parent().parent().parent().prev().children('.buttons-excel').click()
										}
									}
									className = 'dropdown-item'>Excel (.xlsx)</a>
									<a onClick =
									{
										set_Event =>
										{
											$(set_Event.target).parent().parent().parent().prev().children('.buttons-csv').click()
										}
									}
									className = 'dropdown-item'>CSV (.csv)</a>
								</div>
							</div>,
							$(this.Element['Table_Cooperative_Contribution'].current).parent().find('.dataTables_actions')[0]
						)
					},
				})

				this.Table_Cooperative_Loan = $(this.Element['Table_Cooperative_Loan'].current)				
				//this.Table_Cooperative_Loan.DataTable().clear().destroy()

				this.Table_Cooperative_Loan.DataTable
				({
					'columnDefs'	:
					[
						{
							'className'	:	'text-center',
							'targets'	:	'_all'
						}
					],

					'lengthMenu'	:
					[
						[15, 30, 45, -1],
						['15 Rows', '30 Rows', '45 Rows', 'Everything']
					],

					'language'		:	{ 'searchPlaceholder' : 'Search for records...' },
					'sDom'			:	'<"dataTables__top"flB<"dataTables_actions">>rt<"dataTables__bottom"ip><"clear">',
					'buttons'		:
					[
						{
							extend	:	'excelHtml5',
							title	:	'Export Data'
						},

						{
							extend	:	'csvHtml5',
							title	:	'Export Data'
						},

						{
							extend	:	'print',
							title	:	'Etherium Transaction'
						}
					],

					'initComplete'	:	() =>
					{
						ReactDOM.render
						(
							<div>
								<i className = 'zwicon-more-h' data-toggle = 'dropdown'></i>
								<div className = 'dropdown-menu dropdown-menu-right'>
									<a onClick =
									{
										set_Event =>
										{
											$(set_Event.target).parent().parent().parent().prev().children('.buttons-print').click()
										}
									}
									className = 'dropdown-item'>Print</a>
									<div className = 'dropdown-divider'></div>
									<div className = 'dropdown-header border-bottom-0 pt-0'>
										<small>Download as</small>
									</div>
									<a onClick =
									{
										set_Event =>
										{
											$(set_Event.target).parent().parent().parent().prev().children('.buttons-excel').click()
										}
									}
									className = 'dropdown-item'>Excel (.xlsx)</a>
									<a onClick =
									{
										set_Event =>
										{
											$(set_Event.target).parent().parent().parent().prev().children('.buttons-csv').click()
										}
									}
									className = 'dropdown-item'>CSV (.csv)</a>
								</div>
							</div>,
							$(this.Element['Table_Cooperative_Loan'].current).parent().find('.dataTables_actions')[0]
						)
					},
				})
			})()

			const Initialize_Organogram_Cooperative_OrganizationalStructure_Member_Chart = (() =>
			{
				this.Element['OrganizationalStructure_Member_Chart'].current.Mutable = true
				this.Element['OrganizationalStructure_Member_Chart'].current.Initialize_DataTable()
			
				/*set_Data['Cooperative_OrganizationalStructure_Member_Chart'].map(set_Data =>
				{
					this.Element['OrganizationalStructure_Member_Chart'].current.Insert
					({
						'Identity'			:	set_Data['Identity'],
						'Identity_Parent'	:	set_Data['Identity_Parent'],
						'Title'				:	set_Data['Title'],
						'Description'		:	set_Data['Description'],
						'Image'				:	set_Data['Image']
					})
				})*/

				this.Element['OrganizationalStructure_Member_Chart'].current.Insert
				({
					'Identity'			:	'asdasd',
					'Identity_Parent'	:	'',
					'Title'				:	'asdasd',
					'Description'		:	'asddadw',
					'Image'				:	''
				})

				if (this.check_Component_Mutablity('Cooperative_Manage'))
					this.Element['OrganizationalStructure_Member_Chart'].current.Mutable = true

				else
					this.Element['OrganizationalStructure_Member_Chart'].current.Mutable = false

				this.Element['OrganizationalStructure_Member_Chart'].current.Initialize_Chart()
			})()
			
		}

		get_Cooperative_Manage_Interface()
		{
			return	<div className = 'tab-container'>	
						<a
							onClick =
							{
								() =>
								{
									$(this.Element['Tab_Cooperative_List'].current).show()
									$(this.Element['Tab_Cooperative_Manage'].current).hide()
								}
							}
							className = 'page-link Carousel_Navigator float-left'>
							<i className = 'zwicon-arrow-left'></i>
						</a>

						<ul className = 'nav nav-tabs' role = 'tablist'>
							<li className = 'nav-item'>
								<a className = 'nav-link active' data-toggle = 'tab' href = '#Table_Member' role = 'tab'>Members</a>
							</li>

							<li className = 'nav-item'>
								<a className = 'nav-link' data-toggle = 'tab' href = '#Tab_Finance' role = 'tab'>Finance</a>
							</li>

							<li className = 'nav-item'>
								<a className = 'nav-link' data-toggle = 'tab' href = '#Tab_Organogram' role = 'tab'>Organogram</a>
							</li>

							<li className = 'nav-item'>
								<a className = 'nav-link' data-toggle = 'tab' href = '#Tab_Committee' role = 'tab'>Committee</a>
							</li>

							<li className = 'nav-item'>
								<a className = 'nav-link' data-toggle = 'tab' href = '#Tab_Activities' role = 'tab'>Activities</a>
							</li>
						</ul>

						<div className = 'tab-content'>
							<div className = 'tab-pane fade active show' id = 'Table_Member' role = 'tabpanel'>
								<ECIMS_Dialog ref = { this.Element['Dialog_Cooperative_Member_Information'] } 
										
									Button =
									{[
										{
											'Identity'	:	'Close',
											'Text'		:	'Close',
											'Class'		:	'btn btn-danger btn-lg',
											'Function'	:	() =>
											{
												this.Element['Dialog_Cooperative_Member_Information'].current.Hide()
												this.Element['Cooperator_Account'].current.Update_Interface()

												$('input').attr('readOnly', false)
												$('textarea').attr('readOnly', false)
												$('select').prop('disabled', false)	
											}
										}
									]}

									Custom = {{  'Available' : true, 'Interface' : <ECIMS_Cooperator_Account ref = { this.Element['Cooperator_Account'] }/> }} 
								/>
								<div>
									<a
										onClick =
										{
											set_Event =>
											{
												$(this.Element['Table_Cooperative_Member'].current).parent().parent().css('display', 'none')
												$(this.Element['Table_Cooperative_Applicant'].current).parent().parent().css('display', 'block')
											}
										}
										className = 'text-primary Highlight_Text'>
										Show Membership Application
									</a>

									<h4 className = 'card-title pt-4'>Cooperative Members</h4>
									<h6 className = 'card-subtitle'><span className = 'Highlight_Text'></span></h6>

									<hr className = 'pb-4'/>

									<table ref = { this.Element['Table_Cooperative_Member'] } className = 'table table-bordered table-hover' width = '100%'>
										<thead>
											<tr>
												<th>Fullname</th>
												<th>Position</th>
												<th>Action</th>
											</tr>
										</thead>
										<tbody>
										</tbody>
									</table>
								</div>

								<div>
									<a
										onClick =
										{
											set_Event =>
											{
												$(this.Element['Table_Cooperative_Member'].current).parent().parent().css('display', 'block')
												$(this.Element['Table_Cooperative_Applicant'].current).parent().parent().css('display', 'none')
											}
										}
										className = 'text-primary Highlight_Text'>
										Show Member List
									</a>

									<h4 className = 'card-title pt-4'>Cooperative Applicants</h4>
									<h6 className = 'card-subtitle'>Users that want to join in Your&nbsp;<span className = 'Highlight_Text'>Cooperative</span></h6>

									<hr className = 'pb-4'/>

									<table ref = { this.Element['Table_Cooperative_Applicant'] } className = 'table table-bordered table-hover' width = '100%'>
										<thead>
											<tr>
												<th>First Name</th>
												<th>Middle Name</th>
												<th>Last Name</th>
												<th>Action</th>
											</tr>
										</thead>
										<tbody>
										</tbody>
									</table>
								</div>
							</div>

							<div className = 'tab-pane fade' id = 'Tab_Finance' role = 'tabpanel'>
								<div className = 'tab-container'>
									<ul className = 'nav nav-tabs' role = 'tablist'>
										<li className = 'nav-item'>
											<a className = 'nav-link active' data-toggle = 'tab' href = '#Tab_Contribution' role = 'tab'>Contribution</a>
										</li>

										<li className = 'nav-item'>
											<a className = 'nav-link' data-toggle = 'tab' href = '#Tab_Loan' role = 'tab'>Loan</a>
										</li>

										<li className = 'nav-item'>
											<a className = 'nav-link' data-toggle = 'tab' href = '#Tab_Transaction' role = 'tab'>Transaction</a>
										</li>
									</ul>

									<div className = 'tab-content'>
										<div className = 'tab-pane fade active show' id = 'Tab_Contribution' role = 'tabpanel'>
											<div className = 'pb-4'>
												<button className = 'btn btn-outline-theme btn--icon-text waves-effect' type = 'button' data-toggle = 'collapse' data-target = '#Collapse_EconomicAspect_Activity'>
													<i className = 'zwicon-line-chart'></i>Contribute
												</button>
											</div>

											<table ref = { this.Element['Table_Cooperative_Contribution'] } className = 'table table-bordered table-hover' width = '100%'>
												<thead>
													<tr>
														<th>Contributor</th>
														<th>Amount</th>
														<th>Date</th>
													</tr>
												</thead>
												<tbody>
													<tr>
														<td>Christian Isidroooooo</td>
														<td>₱100000.00</td>
														<td>2020-2-10</td>
													</tr>

													<tr>
														<td>John Louie Hernandezzzzzzz</td>	
														<td>₱200000.00</td>
														<td>2020-5-17</td>
													</tr>

													<tr>
														<td>Rafael Masalloooooooooooooooo</td>	
														<td>₱500000.00</td>
														<td>2020-3-15</td>
													</tr>
												</tbody>
											</table>
										</div>

										<div className = 'tab-pane fade' id = 'Tab_Loan' role = 'tabpanel'>
											<div className = 'pb-4'>
												<button className = 'btn btn-outline-theme btn--icon-text waves-effect pb-4' type = 'button' data-toggle = 'collapse' data-target = '#Collapse_EconomicAspect_Activity'>
													<i className = 'zwicon-money-stack'></i>Loan
												</button>
											</div>

											<table ref = { this.Element['Table_Cooperative_Loan'] } className = 'table table-bordered table-hover' width = '100%'>
												<thead>
													<tr>
														<th>Loaner</th>
														<th>Loan Amount</th>
														<th>Interest Rate</th>
														<th>Total Amount</th>
														<th>Term</th>
														<th>Amount to Pay</th>
														<th>Date from/to</th>
													</tr>
												</thead>
												<tbody>
													<tr>
														<td>Christian Isidro</td>
														<td>₱500.00</td>
														<td>10%</td>
														<td>₱550.00</td>
														<td>Daily</td>
														<td>₱50</td>
														<td>2020-1-10 - 2020-1-20</td>
													</tr>

													<tr>
														<td>John Louie Hernandez</td>	
														<td>₱1000.00</td>
														<td>50%</td>
														<td>₱1500.00</td>
														<td>Monthly</td>
														<td>₱750</td>
														<td>2020-1-10 - 2020-2-20</td>									
													</tr>

													<tr>	
														<td>Rafael Masallo</td>
														<td>₱500.00</td>
														<td>30%</td>
														<td>₱150.00</td>
														<td>Semi-Monthly</td>
														<td>₱325</td>
														<td>2020-1-1 - 2020-1-29</td>										
													</tr>
												</tbody>
											</table>
										</div>

										<div className = 'tab-pane fade' id = 'Tab_Transaction' role = 'tabpanel'>Tab_Transaction
										</div>
									</div>
								</div>
							</div>

							<div className = 'tab-pane fade' id = 'Tab_Organogram' role = 'tabpanel'>
								<div className = ' col-md-12 pb-2 Remove_Padding_Left Remove_Padding_Right'>
									<button
										onClick =
										{
											() =>
											{
												this.Element['OrganizationalStructure_Member_Chart'].current.Insert
												({
													'Identity'			:	'USR-' + this.Element['OrganizationalStructure_Member_Chart'].current.Counter,
													'Identity_Parent'	:	'',
													'Title'				:	'Member',
													'Description'		:	'Name ' + this.Element['OrganizationalStructure_Member_Chart'].current.Counter,
													'Image'				:	URL_Person_Image
												})

												this.Element['OrganizationalStructure_Member_Chart'].current.Counter ++

												this.Element['OrganizationalStructure_Member_Chart'].current.Initialize_Chart()
											}
										}
										className = 'btn btn-outline-theme btn--icon-text waves-effect'
										type = 'button'>
										<i className = 'zwicon-user-plus'></i>Add&nbsp;<span className = 'Highlight_Text'>Member</span>&nbsp;
									</button>
								</div>

								<div className = ' col-md-12 pb-2 Remove_Padding_Left Remove_Padding_Right'>
									<System_Organogram ref = { this.Element['OrganizationalStructure_Member_Chart'] }/>
								</div>
							</div>

							<div className = 'tab-pane fade' id = 'Tab_Committee' role = 'tabpanel'>
							</div>

							<div className = 'tab-pane fade' id = 'Tab_Activities' role = 'tabpanel'>
							</div>
						</div>
					</div>
		}
	}

	window.ECIMS_Cooperative_Manage = ECIMS_Cooperative_Manage
})