define('CITACH_Server_Member', function()
{
	class CITACH_Server_Member extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Server_Member Class')

			super()

			this.Switch_Fragment = this.Switch_Fragment.bind(this)

			////alert($(findDOMNode(this.refs.refXD)).text('123123'))

			//alert($(findDOMNode(this.refs.refXD)).text('123123'))

			/*this.state = {
				Member_Firstname	:	'',
				Member_Middlename	:	'',
				Member_Lastname		:	''
			}

			/*handleUserInput(e)
			{
				const name = e.target.name
				const value = e.target.value
				this.setState({[name]: value})
			}

			onChange = { (event) => this.handleUserInput(event) } value = { this.state.Member_Firstname } */
		}

		Switch_Fragment(set_Fragment)
		{
			if (set_Fragment == 'Visible_User_Personal_Information_List')
			{
				$(findDOMNode(this.refs.Visible_User_Personal_Information_List)).show()
				$(findDOMNode(this.refs.Visible_User_Personal_Information)).hide()
			}

			else if (set_Fragment == 'Visible_User_Personal_Information')
			{
				$(findDOMNode(this.refs.Visible_User_Personal_Information)).show()
				$(findDOMNode(this.refs.Visible_User_Personal_Information_List)).hide()
			}
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Server_Member Class')

			this.Switch_Fragment('Visible_User_Personal_Information')

			$('#User_Position').dropdown({ maxSelections : 3, on : 'hover' })

			window.CITACH_Server_Index.set_Image_Upload_Preview('User_Image_Path', 'User_Image')

			CITACH_User_Information.Select_User_Information
			(
				{
					'Action'				:	'Select_User_Information', 
					'Action_Select'			:	'Select : All',
					'Action_Select_Data'	:	null
				},

			function(set_Callback_Data)
			{
				//alert(set_Callback_Data)

				$('#table_User_Information').DataTable
				(
					{
						'responsive'	:	true,
						'data'			:	JSON.parse(set_Callback_Data),
						columnDefs		:
						[
							{								
								'className'	:	'text-center',
								'targets'	:	'_all'
							}
						],

						'columns'	:
						[
							{
								'orderable'	:	false,
								'data'		:	null,
								'width'		:	'100px',
								render		:	function (set_Data)
								{
									return  "<img class = 'DatatableImage' alt='" + URL_No_Image + "' src='" + URL_No_Image + "'>"
								}
							},

							{
								'data'	:	null,
								render	:	function (set_Data)
								{
									return  set_Data['User_Firstname'] + ', ' + set_Data['User_Lastname']
								}
							},

							{   'data' : 'User_Firstname'   },
							{   'data' : 'User_Lastname'   },

							{
								'orderable'	:	false,
								'data'		:	null,
								'width'		:	'8em',
								render		:	function (set_Data)
								{
									return  "<button type='button' class = 'btn btn-warning DatatableButton'>Update</button>" +
											"<br/><br/>" +
											"<button type='button' class = 'btn btn-danger DatatableButton'>Delete</button>"
								}
							},
						]
					}
				)
			})			

			$('#form_User_Personal_Information').form(
			{
				fields	:
				{
					User_Firstname	:
					{
						identifier	:	'User_Firstname',
						rules		:	
						[
							{
								type	:	'empty',
								prompt	:	'Please enter Firstname.'
							}
						]
					},

					User_Lastname	:
					{
						identifier	:	'User_Lastname',
						rules		:	
						[
							{
								type	:	'empty',
								prompt	:	'Please enter Lastname.'
							}
						]
					},

					User_Position	:
					{
						identifier	:	'User_Position',
						rules		:	
						[
							{
								type	:	'empty',
								prompt	:	'Please select Spiritual Gift.'
							}
						]
					},

					User_Image_Path	:
					{
						identifier	:	'User_Image_Path',
						rules		:	
						[
							{
								type	:	'empty',
								prompt	:	'Please Attach an Image.'
							}
						]
					}
				},

				onSuccess: function(set_Button)
				{	
					set_Button.preventDefault()

					var get_FormData = new FormData($(document.querySelector('#form_User_Personal_Information'))[0])
					get_FormData.append('Action', 'Insert_User_Information')

					CITACH_User_Information.Manage_User_Information(get_FormData, function(set_Callback_Data)
					{
						if (set_Callback_Data)
						{
							$('#form_User_Personal_Information').trigger('reset')
							$('#User_Position').dropdown('clear')
							$('#User_Image').attr('src', URL_No_Image)
						}
					})

				}
			
			})
		}

		render()
		{
			return	<div>
						<div ref = 'Visible_User_Personal_Information_List'>
							<div id = 'page-wrapper'>
								<div className = 'container-fluid'>

									<hr/>

									<div className = 'row'>
										<div className = 'col-lg-12'>
											<h1 className = 'page-header'>Member List</h1>
										</div>
									</div>

									<div className = 'row'>
										<div className = 'col-lg-10'>
											<div className = 'panel panel-default'>

												<div className = 'panel-heading'>
													Member Information
												</div>

												<div className = 'panel-body'>
													<div className = 'row'>

														<div className = 'col-md-12 table-responsive'>

															<button type = 'button' className = 'btn btn-info btn-lg' onClick = { () => this.Switch_Fragment('Visible_User_Personal_Information') }>+</button>
															<hr/>
															<table id = 'table_User_Information' className = 'table table-striped table-bordered table-hover' style = {{ 'width' : '100%' }}>
																<thead>
																	<tr>
																		<th>Image</th>
																		<th>Name</th>
																		<th>Church</th>
																		<th>Spiritual Gift</th>
																		<th>Action</th>
																	</tr>
																</thead>

																<tbody>
																	<tr>
																		<th>Image</th>
																		<td>Name</td>
																		<td>Church</td>
																		<td>Spiritual Gift</td>
																		<th>Action</th>
																	</tr>	
																</tbody>
															</table>

														</div>
													</div>
												</div>
												
											</div>
										</div>
									</div>

								</div>
							</div>
						</div>

						<div ref = 'Visible_User_Personal_Information'>
							<div id = 'page-wrapper'>
								<div className = 'container-fluid'>

									<hr/>

									<div className = 'row'>
										<div className = 'col-lg-12'>
											<h1 className = 'page-header'>Manage Member</h1>
										</div>
									</div>

									<div className = 'row'>
										<div className = 'col-lg-6'>
											<div className = 'panel panel-default'>

												<div className = 'panel-heading'>
													Member Information
												</div>

												<div className = 'panel-body'>
													<div className = 'row'>
														<div className = 'col-md-12'>

															<button type = 'button' className = 'btn btn-info btn-lg' onClick = { () => this.Switch_Fragment('Visible_User_Personal_Information_List') }>{'<'}</button>
															<hr/>
															<form id = 'form_User_Personal_Information' className = 'ui form'>
																<div className = 'form-row col-md'>

																	<div className = 'form-group col-md-4'>
																		<div className = 'field'>
																			<input name = 'User_Firstname' id = 'User_Firstname' type = 'text' className = 'form-control' required/>
																			<label className = 'form-control-placeholder' htmlFor = 'User_Firstname'>First Name</label>
																		</div>
																	</div>

																	<div className = 'form-group col-md-4'>
																		<div className = 'field'>
																			<input name = 'User_Middlename' id = 'User_Middlename' type = 'text' className = 'form-control' required/>
																			<label className = 'form-control-placeholder' htmlFor = 'User_Middlename'>Middle Name</label>
																		</div>
																	</div>

																	<div className = 'form-group col-md-4'>
																		<div className = 'field'>
																			<input name = 'User_Lastname' id = 'User_Lastname' type = 'text' className = 'form-control' required/>
																			<label className = 'form-control-placeholder' htmlFor = 'User_Lastname'>Last Name</label>
																		</div>
																	</div>

																	<div className = 'form-group col-md-12'>
																		<div className = 'field'>
																			<select name = 'User_Position' id = 'User_Position' className = 'ui fluid search dropdown' multiple = { true }>
																				<option value = ''>Spritual Gift</option>
																				<option value = '1'>Pastor/Pastora</option>
																				<option value = '2'>Reverand</option>
																				<option value = '3'>Choir</option>
																				<option value = '4'>Member</option>																	
																			</select>
																		</div>
																	</div>

																	<div className = 'form-group col-md-12'>
																		<div className = 'field'>																		
																			<button type = 'button' className = 'btn btn-outline btn-info' onClick = { function(){ $('#User_Image_Path').click() } }>Upload Image<hr/>
																				<input name = 'User_Image_Path' id = 'User_Image_Path' type = 'file' style = {{ 'display' : 'none' }}/>
																				<img id = 'User_Image' className = 'ui image' src = { URL_No_Image }/>
																			</button>
																		</div>
																	</div>

																	<div className = 'form-group col-md-12'>
																		<button type = 'button' className = 'btn btn-success submit'>Save</button>
																	</div>

																	<div className = 'form-group col-md-12'>
																		<div className = 'ui error message'></div>
																	</div>

																</div>
															</form>
														</div>
													</div>
												</div>
												
											</div>
										</div>
									</div>

								</div>
							</div>
						</div>
						
						<div id = ''>Under Development</div>
					</div>
		}
	}

	window.CITACH_Server_Member = CITACH_Server_Member
})