define('ECIMS_Cooperative_List', () =>
{
	class ECIMS_Cooperative_List extends ECIMS_Cooperative
	{
		constructor()
		{
			if (System_Mode == 'Development')
				console.log('Succesfully Loaded : ECIMS_Cooperative_List Class')

			super()

			this.set_Cooperative_EconomicSurvey()
			this.set_Cooperative_Manage()
		}

		set_Cooperative_EconomicSurvey()
		{
			this.Cooperative_EconomicSurvey = new ECIMS_Cooperative_EconomicSurvey()
			this.Cooperative_EconomicSurvey.state['Action'] = 'View'
			this.Cooperative_EconomicSurvey.get_Cooperative_List_Interface = this.get_Cooperative_List_Interface

			this.get_Table_OrganizationalStructure_Member_Element = this.Cooperative_EconomicSurvey.get_Table_OrganizationalStructure_Member_Element
			this.get_Table_OrganizationalStructure_Committee_Element = this.Cooperative_EconomicSurvey.get_Table_OrganizationalStructure_Committee_Element
			this.get_Cooperative_EconomicSurvey_Interface = this.Cooperative_EconomicSurvey.get_Cooperative_EconomicSurvey_Interface
			this.set_Cooperative_EconomicSurvey_Data = this.Cooperative_EconomicSurvey.set_Cooperative_EconomicSurvey_Data

			this.set_Component_Mutablity('Cooperative_EconomicSurvey', false)
		}

		set_Cooperative_Manage()
		{
			this.Cooperative_Manage = new ECIMS_Cooperative_Manage()
			this.Cooperative_Manage.get_Cooperative_List_Interface = this.get_Cooperative_List_Interface

			this.get_Cooperative_Manage_Interface = this.Cooperative_Manage.get_Cooperative_Manage_Interface
			this.Initialize_Cooperative_Manage = this.Cooperative_Manage.Initialize_Cooperative_Manage
			this.Select_User = this.Cooperative_Manage.Select_User
			this.Manage_User = this.Cooperative_Manage.Manage_User
		}

		Select_Cooperative_List(set_Action, set_Data)
		{

			if (set_Action == 'Cooperative Economic Survey')
			{
				this.Element['Dialog_Cooperative_EconomicSurvey'].current.Title = 'Loading Economic Survey'
				this.Element['Dialog_Cooperative_EconomicSurvey'].current.Size = 'Small'
				//this.Element['Dialog_Cooperative_EconomicSurvey'].current.Closable = true
				this.Element['Dialog_Cooperative_EconomicSurvey'].current.Mode = 'Wait'
				this.Element['Dialog_Cooperative_EconomicSurvey'].current.Hide_Button()
				this.Element['Dialog_Cooperative_EconomicSurvey'].current.Show()

				this.set_Component_Mutablity('Cooperative_EconomicSurvey')
				let get_FormData = new FormData()
				get_FormData.append('Action', 'Select_Cooperative')
				get_FormData.append('Select_Action', 'Select : Specific')
				get_FormData.append('Cooperative_Identity', set_Data)

				ECIMS_Main_HTTP.Select(get_FormData, set_Callback_Data =>
				{
					this.set_Cooperative_EconomicSurvey_Data(JSON.parse(set_Callback_Data[0]['EconomicSurvey_Description']))

					this.Element['Dialog_Cooperative_EconomicSurvey'].current.Title = 'Cooperative Economic Survey'
					this.Element['Dialog_Cooperative_EconomicSurvey'].current.Size = 'Large'
					this.Element['Dialog_Cooperative_EconomicSurvey'].current.Mode = 'Custom'
					this.Element['Dialog_Cooperative_EconomicSurvey'].current.Show_Button()
				})
			}

			else if (set_Action == 'Cooperative View')
			{

			}

			else if (set_Action == 'Cooperative Manage')
			{
				let get_FormData = new FormData()
				get_FormData.append('Action', 'Cooperative_Manage')
				get_FormData.append('Cooperative_Identity', set_Data)

				ECIMS_Main_HTTP.Select(get_FormData, set_Callback_Data =>
				{
					this.Cooperative_Identity = set_Data
					this.state['Cooperative_Applicant'] = JSON.parse(set_Callback_Data['Cooperative_Applicant'])
					this.state['Cooperative_Member'] = JSON.parse(set_Callback_Data['Cooperative_Member'])

					this.set_Component_Mutablity('Cooperative_Manage', true)
					this.Initialize_Cooperative_Manage()

					$(this.Element['Tab_Cooperative_List'].current).hide()
					$(this.Element['Tab_Cooperative_Manage'].current).show()
				})
			}
		}

		Manage_Cooperative_List(set_Action, set_Data, set_Element)
		{
			let get_Promise = new Promise(System_Manipulator.System_Dialog_Promise)

			System_Dialog.Title = 'Are You sure?'
			System_Dialog.Size = 'Small'
			System_Dialog.Mode = 'Choice'
			System_Dialog.Alert_Interface = 'Warning'

			let get_FormData = new FormData()

			if (set_Action == 'Confirm' || set_Action == 'Decline')
			{
				get_FormData.append('Action', 'Update_Cooperative')
				get_FormData.append('Update_Action', 'Update : Specific : [ Cooperative_State ]')
				get_FormData.append('Cooperative_Identity', set_Data)
				get_FormData.append('User_Identity', Session_User_Identity())

				if (set_Action == 'Confirm')
				{
					System_Dialog.Alert_Text = 'This Cooperative will be confirmed.'

					for (let get_Counter = 0; get_Counter <= this.state['Cooperative_Pending'].length; get_Counter ++)
					{
						if (set_Data == this.state['Cooperative_Pending'][get_Counter]['Cooperative_Identity'])
						{
							get_FormData.append('Member_Identity', this.state['Cooperative_Pending'][get_Counter]['Cooperative_Inserted_By'])
							break
						}
					}

					get_FormData.append('Cooperative_State', 'Confirmed')
				}

				else if (set_Action == 'Decline')
				{
					System_Dialog.Alert_Text = 'This Cooperative will be declined.'

					get_FormData.append('Cooperative_State', 'Declined')
				}
			}

			else if (set_Action == 'Join')
			{
				System_Dialog.Alert_Text = 'Click "Yes" to send an application of joining in this Cooperative'

				get_FormData.append('Action', 'Cooperative_Join')
				get_FormData.append('Cooperative_Identity', set_Data)
				get_FormData.append('User_Identity', Session_User_Identity())
			}

			else if (set_Action == 'Cancel Application')
			{
				System_Dialog.Alert_Text = 'Click "Yes" to cancel the application of joining in this Cooperative'

				get_FormData.append('Action', 'Delete_Cooperative_OrganizationalStructure_Member')
				get_FormData.append('Delete_Action', 'Delete : Specific : { Cooperative_Identity, Member_Identity }')
				get_FormData.append('Cooperative_Identity', set_Data)
				get_FormData.append('Member_Identity', Session_User_Identity())
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
						let get_Element = $(set_Element).parent()

						if (set_Action == 'Confirm')
						{
							let get_RowIndex = this.Table_Cooperative_Pending.DataTable().row(get_Element).index()

							this.Table_Cooperative_Confirmed.DataTable().row.add(this.Table_Cooperative_Pending.DataTable().row(get_RowIndex).data()).draw()
							this.Table_Cooperative_Pending.DataTable().row(get_RowIndex).remove().draw()
						}

						else if (set_Action == 'Decline')
						{
							let get_RowIndex = this.Table_Cooperative_Pending.DataTable().row(get_Element).index()

							this.Table_Cooperative_Declined.DataTable().row.add(this.Table_Cooperative_Pending.DataTable().row(get_RowIndex).data()).draw()
							this.Table_Cooperative_Pending.DataTable().row(get_RowIndex).remove().draw()
						}

						else if (set_Action == 'Join')
						{
							if ($('#Table_Cooperative_Dissociated').hasClass('show'))
							{
								let get_RowIndex = this.Table_Cooperative_Dissociated.DataTable().row(get_Element).index()

								this.Table_Cooperative_Pending.DataTable().row.add(this.Table_Cooperative_Dissociated.DataTable().row(get_RowIndex).data()).draw()
								this.Table_Cooperative_Dissociated.DataTable().row(get_RowIndex).remove().draw()
							}

							else
							{
								let get_RowIndex = this.Table_Cooperative_Declined.DataTable().row(get_Element).index()

								this.Table_Cooperative_Pending.DataTable().row.add(this.Table_Cooperative_Declined.DataTable().row(get_RowIndex).data()).draw()
								this.Table_Cooperative_Declined.DataTable().row(get_RowIndex).remove().draw()
							}
						}

						else if (set_Action == 'Cancel Application')
						{
							let get_RowIndex = this.Table_Cooperative_Pending.DataTable().row(get_Element).index()

							this.Table_Cooperative_Dissociated.DataTable().row.add(this.Table_Cooperative_Pending.DataTable().row(get_RowIndex).data()).draw()
							this.Table_Cooperative_Pending.DataTable().row(get_RowIndex).remove().draw()
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

		Initialize_Cooperative_List()
		{
			const Initialize_Cooperative_List = (() =>
			{
				if (location.pathname != '/Cooperative/List')
					return

				$('a[href = "#Table_Cooperative_Pending"]').trigger('click')

				this.Table_Cooperative_Pending = $(this.Element['Table_Cooperative_Pending'].current)
				this.Table_Cooperative_Confirmed = $(this.Element['Table_Cooperative_Confirmed'].current)
				this.Table_Cooperative_Declined = $(this.Element['Table_Cooperative_Declined'].current)
				this.Table_Cooperative_Cancelled = $(this.Element['Table_Cooperative_Cancelled'].current)

				this.Table_Cooperative_Pending.DataTable
				({
					'data'			:	this.state['Cooperative_Pending'],
					'columnDefs'	:
					[
						{
							'className'	:	'text-center',
							'targets'	:	'_all'
						}
					],

					'columns'	:
					[
						{ 'data' : 'Cooperative_Name' },

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Type'].length; get_Counter ++)
									if (set_Data['Cooperative_Type'] == this.state['Cooperative_Type'][get_Counter]['Type_Identity'])
										return this.state['Cooperative_Type'][get_Counter]['Type_Name']
								
								return ''
							}
						},

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Category'].length; get_Counter ++)
									if (set_Data['Cooperative_Category'] == this.state['Cooperative_Category'][get_Counter]['Category_Identity'])
										return this.state['Cooperative_Category'][get_Counter]['Category_Name']
								
								return ''
							}
						},

						{ 'data' : 'Cooperative_Office_Address' },

						{
							'data' : null,
							'orderable' : false,
							'createdCell' : (set_Cell, set_CellData, set_RowData, set_RowIndex, set_ColumnIndex) =>
							{
								ReactDOM.render
								(
									<div className = 'd-flex justify-content-center flex-column'>
										<div className = 'p-1'>
											<button onClick = { () => this.Select_Cooperative_List('Cooperative Economic Survey', set_CellData['Cooperative_Identity']) } type = 'button' className = 'btn btn-info waves-effect DataTable_Button'>Economic Survey</button>
										</div>

										<div className = 'p-1'>
											<button onClick = { () => this.Manage_Cooperative_List('Confirm', set_CellData['Cooperative_Identity'], set_Cell) } type = 'button' className = 'btn btn-success waves-effect DataTable_Button'>Confirm</button>
										</div>

										<div className = 'p-1'>
											<button onClick = { () => this.Manage_Cooperative_List('Decline', set_CellData['Cooperative_Identity'], set_Cell) } type = 'button' className = 'btn btn-danger waves-effect DataTable_Button'>Decline</button>
										</div>
									</div>
									,set_Cell
								)
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
							title	:	'Cooperative'
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
							$(this.Element['Table_Cooperative_Pending'].current).parent().find('.dataTables_actions')[0]
						)
					},
				})

				this.Table_Cooperative_Confirmed.DataTable
				({
					'data'			:	this.state['Cooperative_Confirmed'],
					'columnDefs'	:
					[
						{
							'className'	:	'text-center',
							'targets'	:	'_all'
						}
					],

					'columns'	:
					[
						{ 'data' : 'Cooperative_Name' },

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Type'].length; get_Counter ++)
									if (set_Data['Cooperative_Type'] == this.state['Cooperative_Type'][get_Counter]['Type_Identity'])
										return this.state['Cooperative_Type'][get_Counter]['Type_Name']

								return ''
							}
						},

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Category'].length; get_Counter ++)
									if (set_Data['Cooperative_Category'] == this.state['Cooperative_Category'][get_Counter]['Category_Identity'])
										return this.state['Cooperative_Category'][get_Counter]['Category_Name']

								return ''
							}
						},

						{ 'data' : 'Cooperative_Office_Address' },

						{
							'data' : null,
							'orderable' : false,
							'createdCell' : (set_Cell, set_CellData, set_RowData, set_RowIndex, set_ColumnIndex) =>
							{
								ReactDOM.render
								(
									<div className = 'd-flex justify-content-center flex-column'>
										<div className = 'p-1'>
											<button onClick = { () => this.Select_Cooperative_List('Cooperative View', set_CellData['Cooperative_Identity']) } type = 'button' className = 'btn btn-info waves-effect DataTable_Button'>View</button>
										</div>
									</div>
									,set_Cell
								)

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
							title	:	'Cooperative'
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
							$(this.Element['Table_Cooperative_Confirmed'].current).parent().find('.dataTables_actions')[0]
						)
					},
				})

				this.Table_Cooperative_Declined.DataTable
				({
					'data'			:	this.state['Cooperative_Declined'],
					'columnDefs'	:
					[
						{
							'className'	:	'text-center',
							'targets'	:	'_all'
						}
					],

					'columns'	:
					[
						{ 'data' : 'Cooperative_Name' },

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Type'].length; get_Counter ++)
									if (set_Data['Cooperative_Type'] == this.state['Cooperative_Type'][get_Counter]['Type_Identity'])
										return this.state['Cooperative_Type'][get_Counter]['Type_Name']

								return ''
							}
						},

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Category'].length; get_Counter ++)
									if (set_Data['Cooperative_Category'] == this.state['Cooperative_Category'][get_Counter]['Category_Identity'])
										return this.state['Cooperative_Category'][get_Counter]['Category_Name']

								return ''
							}
						},

						{ 'data' : 'Cooperative_Office_Address' },

						{
							'data' : null,
							'orderable' : false,
							'createdCell' : (set_Cell, set_CellData, set_RowData, set_RowIndex, set_ColumnIndex) =>
							{
								ReactDOM.render
								(
									<div className = 'd-flex justify-content-center flex-column'>
										<div className = 'p-1'>
											<button onClick = { () => this.Select_Cooperative_List('Cooperative Economic Survey', set_CellData['Cooperative_Identity']) } type = 'button' className = 'btn btn-info waves-effect DataTable_Button'>Economic Survey</button>
										</div>
									</div>
									,set_Cell
								)

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
							title	:	'Cooperative'
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
							$(this.Element['Table_Cooperative_Declined'].current).parent().find('.dataTables_actions')[0]
						)
					},
				})

				this.Table_Cooperative_Cancelled.DataTable
				({
					'data'			:	this.state['Cooperative_Cancelled'],
					'columnDefs'	:
					[
						{
							'className'	:	'text-center',
							'targets'	:	'_all'
						}
					],

					'columns'	:
					[
						{ 'data' : 'Cooperative_Name' },

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Type'].length; get_Counter ++)
									if (set_Data['Cooperative_Type'] == this.state['Cooperative_Type'][get_Counter]['Type_Identity'])
										return this.state['Cooperative_Type'][get_Counter]['Type_Name']

								return ''
							}
						},

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Category'].length; get_Counter ++)
									if (set_Data['Cooperative_Category'] == this.state['Cooperative_Category'][get_Counter]['Category_Identity'])
										return this.state['Cooperative_Category'][get_Counter]['Category_Name']

								return ''
							}
						},

						{ 'data' : 'Cooperative_Office_Address' },

						{
							'data' : null,
							'orderable' : false,
							'createdCell' : (set_Cell, set_CellData, set_RowData, set_RowIndex, set_ColumnIndex) =>
							{
								ReactDOM.render
								(
									<div className = 'd-flex justify-content-center flex-column'>
										<div className = 'p-1'>
											<button onClick = { () => this.Select_Cooperative_List('Cooperative Economic Survey', set_CellData['Cooperative_Identity']) } type = 'button' className = 'btn btn-info waves-effect DataTable_Button'>Economic Survey</button>
										</div>
									</div>
									,set_Cell
								)

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
							title	:	'Cooperative'
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
							$(this.Element['Table_Cooperative_Cancelled'].current).parent().find('.dataTables_actions')[0]
						)
					},
				})
			})()

			const Initialize_Cooperative_Join = (() =>
			{
				if (location.pathname != '/Cooperative/Join')
					return

				$('a[href="#Table_Cooperative_Dissociated"]').trigger('click')

				this.Table_Cooperative_Dissociated = $(this.Element['Table_Cooperative_Dissociated'].current)
				this.Table_Cooperative_Pending = $(this.Element['Table_Cooperative_Pending'].current)
				this.Table_Cooperative_Declined = $(this.Element['Table_Cooperative_Declined'].current)

				this.Table_Cooperative_Dissociated.DataTable
				({
					'data'			:	this.state['Cooperative_Dissociated'],
					'columnDefs'	:
					[
						{
							'className'	:	'text-center',
							'targets'	:	'_all'
						}
					],

					'columns'	:
					[
						{ 'data' : 'Cooperative_Name' },

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Type'].length; get_Counter ++)
									if (set_Data['Cooperative_Type'] == this.state['Cooperative_Type'][get_Counter]['Type_Identity'])
										return this.state['Cooperative_Type'][get_Counter]['Type_Name']

								return ''
							}
						},

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Category'].length; get_Counter ++)
									if (set_Data['Cooperative_Category'] == this.state['Cooperative_Category'][get_Counter]['Category_Identity'])
										return this.state['Cooperative_Category'][get_Counter]['Category_Name']

								return ''
							}
						},

						{ 'data' : 'Cooperative_Office_Address' },

						{
							'data' : null,
							'orderable' : false,
							'createdCell' : (set_Cell, set_CellData, set_RowData, set_RowIndex, set_ColumnIndex) =>
							{
								ReactDOM.render
								(
									<div className = 'd-flex justify-content-center flex-column'>
										<div className = 'p-1'>
											<button onClick = { () => this.Select_Cooperative_List('Cooperative View', set_CellData['Cooperative_Identity']) } type = 'button' className = 'btn btn-info waves-effect DataTable_Button'>View</button>
										</div>

										<div className = 'p-1'>
											<button onClick = { () => this.Manage_Cooperative_List('Join', set_CellData['Cooperative_Identity'], set_Cell) } type = 'button' className = 'btn btn-success waves-effect DataTable_Button'>Join</button>
										</div>

										<div className = 'p-1'>
											<button onClick = { () => this.Manage_Cooperative_List('Report', set_CellData['Cooperative_Identity'], set_Cell) } type = 'button' className = 'btn btn-danger waves-effect DataTable_Button'>Report</button>
										</div>
									</div>
									,set_Cell
								)
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
							title	:	'Cooperative'
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
							$(this.Element['Table_Cooperative_Dissociated'].current).parent().find('.dataTables_actions')[0]
						)
					},
				})

				this.Table_Cooperative_Pending.DataTable
				({
					'data'			:	this.state['Cooperative_Pending'],
					'columnDefs'	:
					[
						{
							'className'	:	'text-center',
							'targets'	:	'_all'
						}
					],

					'columns'	:
					[
						{ 'data' : 'Cooperative_Name' },

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Type'].length; get_Counter ++)
									if (set_Data['Cooperative_Type'] == this.state['Cooperative_Type'][get_Counter]['Type_Identity'])
										return this.state['Cooperative_Type'][get_Counter]['Type_Name']

								return ''
							}
						},

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Category'].length; get_Counter ++)
									if (set_Data['Cooperative_Category'] == this.state['Cooperative_Category'][get_Counter]['Category_Identity'])
										return this.state['Cooperative_Category'][get_Counter]['Category_Name']

								return ''
							}
						},

						{ 'data' : 'Cooperative_Office_Address' },

						{
							'data' : null,
							'orderable' : false,
							'createdCell' : (set_Cell, set_CellData, set_RowData, set_RowIndex, set_ColumnIndex) =>
							{
								ReactDOM.render
								(
									<div className = 'd-flex justify-content-center flex-column'>
										<div className = 'p-1'>
											<button onClick = { () => this.Select_Cooperative_List('Cooperative View', set_CellData['Cooperative_Identity']) } type = 'button' className = 'btn btn-info waves-effect DataTable_Button'>View</button>
										</div>

										<div className = 'p-1'>
											<button onClick = { () => this.Manage_Cooperative_List('Cancel Application', set_CellData['Cooperative_Identity'], set_Cell) } type = 'button' className = 'btn btn-warning waves-effect DataTable_Button'>Cancel Application</button>
										</div>

										<div className = 'p-1'>
											<button onClick = { () => this.Manage_Cooperative_List('Report', set_CellData['Cooperative_Identity'], set_Cell) } type = 'button' className = 'btn btn-danger waves-effect DataTable_Button'>Report</button>
										</div>
									</div>
									,set_Cell
								)
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
							title	:	'Cooperative'
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
							$(this.Element['Table_Cooperative_Pending'].current).parent().find('.dataTables_actions')[0]
						)
					},
				})

				this.Table_Cooperative_Declined.DataTable
				({
					'data'			:	this.state['Cooperative_Declined'],
					'columnDefs'	:
					[
						{
							'className'	:	'text-center',
							'targets'	:	'_all'
						}
					],

					'columns'	:
					[
						{ 'data' : 'Cooperative_Name' },

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Type'].length; get_Counter ++)
									if (set_Data['Cooperative_Type'] == this.state['Cooperative_Type'][get_Counter]['Type_Identity'])
										return this.state['Cooperative_Type'][get_Counter]['Type_Name']

								return ''	
							}
						},

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Category'].length; get_Counter ++)
									if (set_Data['Cooperative_Category'] == this.state['Cooperative_Category'][get_Counter]['Category_Identity'])
										return this.state['Cooperative_Category'][get_Counter]['Category_Name']

								return ''
							}
						},

						{ 'data' : 'Cooperative_Office_Address' },

						{
							'data' : null,
							'orderable' : false,
							'createdCell' : (set_Cell, set_CellData, set_RowData, set_RowIndex, set_ColumnIndex) =>
							{
								ReactDOM.render
								(
									<div className = 'd-flex justify-content-center flex-column'>
										<div className = 'p-1'>
											<button onClick = { () => this.Select_Cooperative_List('Cooperative View', set_CellData['Cooperative_Identity']) } type = 'button' className = 'btn btn-info waves-effect DataTable_Button'>View</button>
										</div>

										<div className = 'p-1'>
											<button onClick = { () => this.Manage_Cooperative_List('Join', set_CellData['Cooperative_Identity'], set_Cell) } type = 'button' className = 'btn btn-success waves-effect DataTable_Button'>Rejoin</button>
										</div>

										<div className = 'p-1'>
											<button onClick = { () => this.Manage_Cooperative_List('Report', set_CellData['Cooperative_Identity'], set_Cell) } type = 'button' className = 'btn btn-danger waves-effect DataTable_Button'>Report</button>
										</div>
									</div>
									,set_Cell
								)
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
							title	:	'Cooperative'
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
							$(this.Element['Table_Cooperative_Declined'].current).parent().find('.dataTables_actions')[0]
						)
					},
				})
			})()

			const Initialize_Cooperative_Associated = (() =>
			{
				if (location.pathname != '/Cooperative/Associated')
					return

				$('a[href="#Table_Cooperative_Associated"]').trigger('click')

				this.Table_Cooperative_Associated = $(this.Element['Table_Cooperative_Associated'].current)

				this.Table_Cooperative_Associated.DataTable
				({
					'data'			:	this.state['Cooperative_Associated'],
					'columnDefs'	:
					[
						{
							'className'	:	'text-center',
							'targets'	:	'_all'
						}
					],

					'columns'	:
					[
						{ 'data' : 'Cooperative_Name' },

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Type'].length; get_Counter ++)
									if (set_Data['Cooperative_Type'] == this.state['Cooperative_Type'][get_Counter]['Type_Identity'])
										return this.state['Cooperative_Type'][get_Counter]['Type_Name']

								return ''
							}
						},

						{
							'data'		:	null,
							'render'	:	set_Data =>
							{
								for (let get_Counter = 0; get_Counter < this.state['Cooperative_Category'].length; get_Counter ++)
									if (set_Data['Cooperative_Category'] == this.state['Cooperative_Category'][get_Counter]['Category_Identity'])
										return this.state['Cooperative_Category'][get_Counter]['Category_Name']

								return ''
							}
						},

						{ 'data' : 'Cooperative_Office_Address' },

						{
							'data' : null,
							'orderable' : false,
							'createdCell' : (set_Cell, set_CellData, set_RowData, set_RowIndex, set_ColumnIndex) =>
							{
								ReactDOM.render
								(
									<div className = 'd-flex justify-content-center flex-column'>
										<div className = 'p-1'>
											<button onClick = { () => this.Select_Cooperative_List('Cooperative Manage', set_CellData['Cooperative_Identity']) } type = 'button' className = 'btn btn-info waves-effect DataTable_Button'>Manage</button>
										</div>

										<div className = 'p-1'>
											<button onClick = { () => this.Manage_Cooperative_List('Leave', set_CellData['Cooperative_Identity'], set_Cell) } type = 'button' className = 'btn btn-warning waves-effect DataTable_Button'>Leave</button>
										</div>

										<div className = 'p-1'>
											<button onClick = { () => this.Manage_Cooperative_List('Report', set_CellData['Cooperative_Identity'], set_Cell) } type = 'button' className = 'btn btn-danger waves-effect DataTable_Button'>Report</button>
										</div>
									</div>
									,set_Cell
								)
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
							title	:	'Cooperative'
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
							$(this.Element['Table_Cooperative_Associated'].current).parent().find('.dataTables_actions')[0]
						)
					},
				})

			})()
		}

		get_Cooperative_List_Interface()
		{
			return	<div>
						<section className = 'content'>
							<div className = 'content__inner'>
								<div className = 'content__title'>
									<h1>Cooperative ({ this.state['Action'] })</h1>
								</div>

								<div className = 'card'>
									<div className = 'card-body'>
										<a onClick = { set_Event => System_Manipulator.set_Card_Size(set_Event, this) } className = 'page-link Card_Resizer float-right'><i className = { this.state['Card_State'] == 'Minimize' ? 'zwicon-expand-alt' : 'zwicon-collapse-alt' }></i></a>
										<ECIMS_Dialog ref = { this.Element['Dialog_Cooperative_EconomicSurvey'] } 
										
											Button =
											{[
												{
													'Identity'	:	'Close',
													'Text'		:	'Close',
													'Class'		:	'btn btn-danger btn-lg',
													'Function'	:	() =>
													{
														this.Element['Dialog_Cooperative_EconomicSurvey'].current.Hide()
													}
												}
											]}

											Custom = {{  'Available' : true, 'Interface' : this.get_Cooperative_EconomicSurvey_Interface() }} 
										/>

										<div ref = { this.Element['Tab_Cooperative_List'] } className = 'tab-container'>
											<ul className = 'nav nav-tabs' role = 'tablist'>
											{
												location.pathname == '/Cooperative/List' && Session_User_Privilege().includes('Admin')
												?
													<li className = 'nav-item'>
														<a className = 'nav-link' data-toggle = 'tab' href = '#Table_Cooperative_Pending' role = 'tab'>Pending</a>
													</li>
												:
												<div></div>
											}

											{
												location.pathname == '/Cooperative/List' && Session_User_Privilege().includes('Admin')
												?
												<li className = 'nav-item'>
													<a className = 'nav-link' data-toggle = 'tab' href = '#Table_Cooperative_Confirmed' role = 'tab'>Confirmed</a>
												</li>
												:
												<div></div>
											}

											{
												location.pathname == '/Cooperative/List' && Session_User_Privilege().includes('Admin')
												?
												<li className = 'nav-item'>
													<a className = 'nav-link' data-toggle = 'tab' href = '#Table_Cooperative_Declined' role = 'tab'>Declined</a>
												</li>
												:
												<div></div>
											}

											{
												location.pathname == '/Cooperative/List' && Session_User_Privilege().includes('Admin')
												?
												<li className = 'nav-item'>
													<a className = 'nav-link' data-toggle = 'tab' href = '#Table_Cooperative_Cancelled' role = 'tab'>Cancelled</a>
												</li>
												:
												<div></div>
											}

											{
												location.pathname == '/Cooperative/Associated' && Session_User_Privilege().includes('Cooperator')
												?
												<li className = 'nav-item'>
													<a className = 'nav-link' data-toggle = 'tab' href = '#Table_Cooperative_Associated' role = 'tab'>Associated</a>
												</li>
												:
												<div></div>
											}

											{
												location.pathname == '/Cooperative/Join' && Session_User_Privilege().includes('Cooperator')
												?
												<li className = 'nav-item'>
													<a className = 'nav-link' data-toggle = 'tab' href = '#Table_Cooperative_Dissociated' role = 'tab'>Dissociated</a>
												</li>
												:
												<div></div>
											}

											{
												location.pathname == '/Cooperative/Join' && Session_User_Privilege().includes('Cooperator')
												?
												<li className = 'nav-item'>
													<a className = 'nav-link' data-toggle = 'tab' href = '#Table_Cooperative_Pending' role = 'tab'>Pending</a>
												</li>
												:
												<div></div>
											}

											{
												location.pathname == '/Cooperative/Join' && Session_User_Privilege().includes('Cooperator')
												?
												<li className = 'nav-item'>
													<a className = 'nav-link' data-toggle = 'tab' href = '#Table_Cooperative_Declined' role = 'tab'>Declined</a>
												</li>
												:
												<div></div>
											}
											</ul>

											<div className = 'tab-content'>
											{
												(location.pathname == '/Cooperative/List' && Session_User_Privilege().includes('Admin')) || (location.pathname == '/Cooperative/Join' && Session_User_Privilege().includes('Cooperator'))
												?
												<div className = 'tab-pane fade' id = 'Table_Cooperative_Pending' role = 'tabpanel'>
													<table ref = { this.Element['Table_Cooperative_Pending'] } className = 'table table-bordered table-hover' width = '100%'>
														<thead>
															<tr>
																<th>Name</th>
																<th>Type</th>
																<th>Category</th>
																<th>Office Address</th>
																<th>Action</th>
															</tr>
														</thead>
														<tbody>
														</tbody>
													</table>
												</div>
												:
												<div></div>
											}

											{
												location.pathname == '/Cooperative/List' && Session_User_Privilege().includes('Admin')
												?
												<div className = 'tab-pane fade' id = 'Table_Cooperative_Confirmed' role = 'tabpanel'>
													<table ref = { this.Element['Table_Cooperative_Confirmed'] } className = 'table table-bordered table-hover' width = '100%'>
														<thead>
															<tr>
																<th>Name</th>
																<th>Type</th>
																<th>Category</th>
																<th>Office Address</th>
																<th>Action</th>
															</tr>
														</thead>
														<tbody>
														</tbody>
													</table>
												</div>
												:
												<div></div>
											}

											{
												(location.pathname == '/Cooperative/List' && Session_User_Privilege().includes('Admin')) || (location.pathname == '/Cooperative/Join' && Session_User_Privilege().includes('Cooperator'))
												?
												<div className = 'tab-pane fade' id = 'Table_Cooperative_Declined' role = 'tabpanel'>
													<table ref = { this.Element['Table_Cooperative_Declined'] } className = 'table table-bordered table-hover' width = '100%'>
														<thead>
															<tr>
																<th>Name</th>
																<th>Type</th>
																<th>Category</th>
																<th>Office Address</th>
																<th>Action</th>
															</tr>
														</thead>
														<tbody>
														</tbody>
													</table>
												</div>
												:
												<div></div>
											}

											{
												location.pathname == '/Cooperative/List' && Session_User_Privilege().includes('Admin')
												?
												<div className = 'tab-pane fade' id = 'Table_Cooperative_Cancelled' role = 'tabpanel'>
													<table ref = { this.Element['Table_Cooperative_Cancelled'] } className = 'table table-bordered table-hover' width = '100%'>
														<thead>
															<tr>
																<th>Name</th>
																<th>Type</th>
																<th>Category</th>
																<th>Office Address</th>
																<th>Action</th>
															</tr>
														</thead>
														<tbody>
														</tbody>
													</table>
												</div>
												:
												<div></div>
											}

											{
												location.pathname == '/Cooperative/Associated' && Session_User_Privilege().includes('Cooperator')
												?
												<div className = 'tab-pane fade' id = 'Table_Cooperative_Associated' role = 'tabpanel'>
													<table ref = { this.Element['Table_Cooperative_Associated'] } className = 'table table-bordered table-hover' width = '100%'>
														<thead>
															<tr>
																<th>Name</th>
																<th>Type</th>
																<th>Category</th>
																<th>Office Address</th>
																<th>Action</th>
															</tr>
														</thead>
														<tbody>
														</tbody>
													</table>
												</div>
												:
												<div></div>
											}

											{
												location.pathname == '/Cooperative/Join' && Session_User_Privilege().includes('Cooperator')
												?
												<div className = 'tab-pane fade' id = 'Table_Cooperative_Dissociated' role = 'tabpanel'>
													<table ref = { this.Element['Table_Cooperative_Dissociated'] } className = 'table table-bordered table-hover' width = '100%'>
														<thead>
															<tr>
																<th>Name</th>
																<th>Type</th>
																<th>Category</th>
																<th>Office Address</th>
																<th>Action</th>
															</tr>
														</thead>
														<tbody>
														</tbody>
													</table>
												</div>
												:
												<div></div>
											}
											</div>
										</div>

										<div ref = { this.Element['Tab_Cooperative_Manage'] } style = {{ 'display' : 'none' }}>
											{ this.get_Cooperative_Manage_Interface() }
										</div>

									</div>
								</div>
							</div>
						</section>
					</div>
		}
	}

	window.ECIMS_Cooperative_List = ECIMS_Cooperative_List
})