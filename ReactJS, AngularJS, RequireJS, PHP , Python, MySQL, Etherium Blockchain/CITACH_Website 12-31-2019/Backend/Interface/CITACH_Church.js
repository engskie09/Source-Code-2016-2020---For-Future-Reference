define('CITACH_Server_Church', function()
{
	class CITACH_Server_Church extends Component
	{
		constructor()
		{
			console.log('Succesfully Loaded : CITACH_Server_Church Class')

			super()
		}

		componentDidMount()
		{
			console.log('Succesfully Executed componentDidMount() : CITACH_Server_Church Class')

			$('#Church_Leader').dropdown({ maxSelections : 3, on : 'hover' })

			window.CITACH_Server_Index.set_Image_Upload_Preview('Church_Image_Path', 'Church_Image')
		}

		render()
		{
			return	<div>
						<div id='page-wrapper'>
							<div className = 'container-fluid'>

								<hr/>

								<div className = 'row'>
									<div className = 'col-lg-12'>
										<h1 className = 'page-header'>Manage Church</h1>
									</div>
								</div>

								<div className = 'row'>
									<div className = 'col-lg-12'>
										<div className = 'panel panel-default'>

											<div className = 'panel-heading'>
												Daughter Church Information
											</div>

											<div className = 'panel-body'>
												<div className = 'row'>
													<div className = 'col-md-6'>
														<form>
															<div className = 'form-row col-md'>

																<div className = 'form-group col-md-12'>
																	<input type = 'text' name = 'Church_Name' id = 'Church_Name' className = 'form-control' required/>
																	<label className = 'form-control-placeholder' htmlFor = 'Church_Name'>Church Name</label>
																</div>

																<div className = 'form-group col-md-12'>
																	<input type = 'text' name = 'Church_Address' id = 'Church_Address' className = 'form-control' required/>
																	<label className = 'form-control-placeholder' htmlFor = 'Church_Address'>Address</label>
																</div>

																<div className = 'form-group col-md-12'>
																	<select name = 'Church_Leader' id = 'Church_Leader' className = 'ui fluid search dropdown' multiple = 'true'>
																		<option value = ''>Daughter Church Leader</option>
																		<option value = '1'>Pastor Bano</option>
																		<option value = '2'>Pastora Abnoy</option>
																	</select>
																</div>

																<div className = 'form-group col-md-12'>
																	<input type = 'file' name = 'Church_Image_Path' id = 'Church_Image_Path' style = {{ 'display' : 'none' }}/>
																	<button type = 'button' className = 'btn btn-outline btn-info' onClick = { function(){ $('#Church_Image_Path').click() }}>Upload Image<hr/>
																		<img className = 'ui large image' id = 'Church_Image' src = '../Data/System/No_Image.png'/>
																	</button>
																</div>

																<div className = 'form-group col-md-12'>
																	<button type = 'button' id = 'btn_Save' className = 'btn btn-success btn-block'>Save</button>
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
		}
	}

	window.CITACH_Server_Church = CITACH_Server_Church
})