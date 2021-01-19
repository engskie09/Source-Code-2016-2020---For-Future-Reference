define('ECIMS_Blockchain', () =>
{
	class ECIMS_Blockchain
	{
		constructor()
		{
			if (System_Mode == 'Development')
				console.log('Succesfully Loaded : ECIMS_Blockchain Class')

			this.User_Account
			this.User_Balance =
			{
				'ETH'	:	0,
				'PHP'	:	0
			}

			this.Web3 = new Web3('HTTP://127.0.0.1:7545')

			this.Web3.eth.getGasPrice((set_Error, set_Data) =>
			{
				//console.log(set_Error)
				//console.log(set_Data)
			})

			this.Web3.eth.getBlock("latest", false, (set_Error, set_Data) =>
			{
				//console.log(set_Data.gasLimit)
			})

			//2020-07-07
			this.Exchange_Rate =
			{
				'ETH' : { 'ETH' : 1, 'PHP' : 11769.43 },
				'PHP' : { 'PHP' : 1, 'ETH' : 0.000085 }
			}
		}

		get Account_Address()
		{
			return this.User_Account_Address
		}

		set Account_Address(set_ACcount_Address)
		{
			this.User_Account_Address = set_ACcount_Address
		}

		get Account()
		{
			return this.User_Account
		}

		set Account(set_Private_Key)
		{
			this.User_Account = this.Web3.eth.accounts.privateKeyToAccount(set_Private_Key)
			this.Account_Address = this.User_Account['address']
		}

		get Balance()
		{
			return this.Web3.eth.getBalance(this.User_Account['address']).then(set_Balance =>
			{
				let get_Balance = this.Web3.utils.fromWei(set_Balance, 'ether')

				this.User_Balance['ETH'] = this.Convert_Currency('ETH', 'ETH', 2, get_Balance, 'Comma')
				this.User_Balance['PHP'] = this.Convert_Currency('ETH', 'PHP', 2, get_Balance, 'Comma')

				return this.User_Balance
			})
		}

		async Send_Balance(set_Account, set_Value, set_Callback_Function)
		{
			let get_TX = new EthereumJS_TX.Tx
			({
				'nonce'		:	await this.Web3.eth.getTransactionCount(this.Account_Address),
				'gasPrice'	:	this.Web3.utils.toHex(0),
				'gas'		:	this.Web3.utils.toHex(1000000000000000),
				'from'		:	this.Account_Address,
				'to'		:	set_Account.address,
				'value'		:	this.Web3.utils.toHex(this.Web3.utils.toWei(set_Value.toString(), 'ether'))
			})

			get_TX.sign(new EthereumJS_TX.Buffer.Buffer(this.User_Account.privateKey.substring(2), 'hex'))

			let get_Data = get_TX.serialize()

			this.Web3.eth.sendSignedTransaction('0x' + get_Data.toString('hex')).on('receipt', console.log)

			set_Callback_Function()
		}

		Convert_Currency(set_Currency_From, set_Currency_To, set_Decimal_Place, set_Amount, set_Seperator)
		{
			if (set_Amount == '')
				set_Amount = 0

			if (set_Seperator == 'Comma')
				return (this.Exchange_Rate[set_Currency_From][set_Currency_To] * set_Amount).toFixed(set_Decimal_Place).replace(/\d(?=(\d{3})+\.)/g, '$&,')
			
			else
				return (this.Exchange_Rate[set_Currency_From][set_Currency_To] * set_Amount).toFixed(set_Decimal_Place)
		}

		get_Identity(set_Character_Length)
		{
			let get_Identity			=	'';
			let get_Character			=	'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
			let get_Character_Length	=	get_Character.length;

			for (let set_Counter = 0; set_Counter < set_Character_Length; set_Counter ++)
			{
				get_Identity += get_Character.charAt(Math.floor(Math.random() * get_Character_Length));
			}

			return get_Identity;
		}

		CryptoCurrency_Withdraw_Inteface(set_Component)
		{
			return	<div>
						<div ref = { set_Component.Element['Dialog_CryptoCurrency_Withdraw'] } className = 'modal fade' tabIndex = '-1' role = 'dialog'>
							<div className = 'modal-dialog'>
								<div className = 'modal-content'>

									<h3 className = 'text-center pt-4'>Withdraw Etherium</h3>

									<div className = 'modal-body'>
										<div className = 'tab-container'>
											<ul className = 'nav nav-tabs' role = 'tablist' style = {{ 'display' : 'none' }}>
												<li className = 'nav-item'>
													<a className = 'nav-link active' data-toggle = 'tab' href = '#CryptoCurrency_Withdraw_1' role = 'tab'></a>
												</li>

												<li className = 'nav-item'>
													<a className = 'nav-link' data-toggle = 'tab' href = '#CryptoCurrency_Withdraw_2' role = 'tab'></a>
												</li>
											</ul>
											<div className = 'tab-content'>
												<div className = 'tab-pane fade active show' id = 'CryptoCurrency_Withdraw_1' role = 'tabpanel'>
													<form>
														<div className = 'form-row'>
															<div className = 'form-group col-md-12 pb-2'>
																<button
																	onClick =
																	{
																		() =>
																		{
																			if ($('input[name = "PHP"]').prop('readonly'))
																			{
																				$('input[name = "PHP"]').prop('readonly', false)
																				$('input[name = "ETH"]').prop('readonly', true)
																			}

																			else
																			{
																				$('input[name = "PHP"]').prop('readonly', true)
																				$('input[name = "ETH"]').prop('readonly', false)
																			}
																		}
																	}
																	className = 'btn btn-theme btn--icon-text col-md waves-effect' type = 'button'>
																	<i className = 'zwicon-credit-card'></i>Switch Currency
																</button>
															</div>

															<div className = 'form-group col-md-6 pb-2'>
																<input onChange = { set_Event => $('#CryptoCurrency_Withdraw_ETH').val(this.Convert_Currency('PHP', 'ETH', 10, set_Event.target.value)) } id = 'CryptoCurrency_Withdraw_PHP' name = 'PHP' className = 'form-control' type = 'number' step = '0.01' defaultValue = '0.00' required/>
																<label className = 'form-control-placeholder' htmlFor = 'PHP'>PHP</label>
																<div className = 'valid-feedback'>PHP is valid</div>
																<div className = 'invalid-feedback'>Please provide an PHP</div>
															</div>

															<div className = 'form-group col-md-6 pb-2'>
																<input onChange = { set_Event => $('#CryptoCurrency_Withdraw_PHP').val(this.Convert_Currency('ETH', 'PHP', 2, set_Event.target.value)) } id = 'CryptoCurrency_Withdraw_ETH' name = 'ETH' className = 'form-control' type = 'number' step = '0.0000000001' defaultValue = '0.00' readOnly required/>
																<label className = 'form-control-placeholder' htmlFor = 'ETH'>ETH</label>
																<div className = 'valid-feedback'>ETH is valid</div>
																<div className = 'invalid-feedback'>Please provide an ETH</div>
															</div>

															<div className = 'form-group col-md-12 pb-2'>
																<input id = 'CryptoCurrency_Withdraw_User_Address_Email' name = 'User_Address_Email' className = 'form-control' type = 'text' required/>
																<label className = 'form-control-placeholder' htmlFor = 'User_Address_Email'>Email Address (Paypal)</label>
																<div className = 'valid-feedback'>Email Address is valid</div>
																<div className = 'invalid-feedback'>Please provide an Email Address</div>
															</div>

															<div className = 'form-group col-md-12 pb-2'>
																<button
																	onClick =
																	{
																		set_Event =>
																		{

																			let get_Element = $(set_Event.target)

																			$(set_Event.target).parents('.tab-content').prev().find('.nav-link[href = "#CryptoCurrency_Withdraw_2"]').trigger('click')
																			get_Element.parents('.tab-content').prev().find('.nav-link[href = "#CryptoCurrency_Withdraw_2"]').trigger('click')
																			get_Element.parents('.tab-content').find('#CryptoCurrency_Withdraw_Loader').show()
																			get_Element.parents('.tab-content').find('#CryptoCurrency_Withdraw_Message').hide()

																			let get_Client_ID = 'AfIuRkjJe4B46mEFjpij7SJon6RIs9m9z44vvNCJB8KZ_72Xjkh81JyXtQ_CDYSwohol3sGoDuk9WKah'
																			let get_Secret = 'ELV-jJ0JjhCK-d_hdIxwwe66ouOOQYA6itusQnRfRj-fqus6oxh2q6HOeMqs5SGTxwqewhO12C50SK-w'
																			let get_Sender_Batch_ID = this.get_Identity(10)

																			let get_Data =
																			{
																				'sender_batch_header':
																				{
																					'sender_batch_id': get_Sender_Batch_ID,
																					'email_subject': 'You have a payout!',
																					'email_message': 'You have received a payout! Thanks for using our service!'
																				},

																				'items':
																				[
																					{
																						'recipient_type'	: 'EMAIL',
																						'amount'	:
																						{
																							'value': $('#CryptoCurrency_Withdraw_PHP').val(),
																							'currency': 'PHP'
																						},
																						'note': 'Thank You!!!',
																						'receiver': $('#CryptoCurrency_Withdraw_User_Address_Email').val()
																					},
																				]
																			}

																			$.ajax
																			({
																				'url'			:	'https://api.sandbox.paypal.com/v1/oauth2/token',
																				'type'			:	'POST',
																				'data'			:	{ 'grant_type' : 'client_credentials' },

																				'beforeSend'	:	set_jQueryXMLHttpRequest =>
																				{
																					set_jQueryXMLHttpRequest.setRequestHeader('Authorization', 'Basic ' + btoa(get_Client_ID + ':' + get_Secret))
																				},

																				'success'		:	set_Response =>
																				{
																					let get_Token = set_Response

																					$.ajax
																					({
																						'url'			:	'https://api.sandbox.paypal.com/v1/payments/payouts',
																						'type'			:	'POST',
																						'data'			:	JSON.stringify(get_Data),
																						'contentType'	:	'application/json',

																						'beforeSend'	:	set_jQueryXMLHttpRequest =>
																						{
																							set_jQueryXMLHttpRequest.setRequestHeader('Authorization', 'Bearer ' + get_Token['access_token'])
																						},

																						'success'		:	set_Response =>
																						{
																							$.ajax
																							({
																								'url'			:	'https://api.sandbox.paypal.com/v1/payments/payouts/' + set_Response['batch_header']['payout_batch_id'],
																								'type'			:	'GET',
																								'contentType'	:	'application/json',

																								'beforeSend'	:	set_jQueryXMLHttpRequest =>
																								{
																									set_jQueryXMLHttpRequest.setRequestHeader('Authorization', 'Bearer ' + get_Token['access_token'])
																								},

																								'success'		:	set_Response =>
																								{
																									console.log(set_Response)

																									let get_FormData = new FormData()

																									get_FormData.append('Action', 'Insert_User_Log')
																									get_FormData.append('User_Identity', Session_User_Identity())
																									get_FormData.append('Log_Action', 'Withdrew Etherium')
																									get_FormData.append('Log_Type', 'Etherium : Remove')
																									get_FormData.append('Log_Information', JSON.stringify(set_Response))

																									ECIMS_Main_HTTP.Manage(get_FormData, set_Callback_Data =>
																									{
																										if (set_Callback_Data)
																										{
																											get_Element.parents('.tab-content').find('#CryptoCurrency_Withdraw_Message').text('Successfully withdrew Etherium from Your Wallet')
																											System_Blockchain_User.Send_Balance(System_Blockchain_Owner.User_Account, $('#CryptoCurrency_Withdraw_ETH').val(), async () =>
																											{
																												let get_Balance = await System_Blockchain_User.Balance
						
																												set_Component.state['User_Ethereum_Balance'] = get_Balance['ETH']
																												set_Component.state['User_PhilippinePeso_Balance'] = get_Balance['PHP']

																												set_Component.Update_Interface()
																											})
																										}

																										else
																											$('#CryptoCurrency_Withdraw_Message').text('Can`t withdraw Etherium from Your Wallet. Please try again later')

																										$('#CryptoCurrency_Withdraw_Loader').hide()
																										$('#CryptoCurrency_Withdraw_Message').show()

																										setTimeout(()=>
																										{
																											get_Element.parents('.tab-content').prev().find('.nav-link[href = "#CryptoCurrency_Withdraw_1"]').trigger('click')
																										}, 3e3)
																									})

																								},

																								'error'			:	(set_jQueryXMLHttpRequest, set_TextStatus, set_ErrorThrown) =>
																								{
																									console.log('Withdrawal Error')
																									get_Element.parents('.tab-content').prev().find('.nav-link[href = "#CryptoCurrency_Withdraw_1"]').trigger('click')

																								}
																							})
																						},

																						'error'			:	(set_jQueryXMLHttpRequest, set_TextStatus, set_ErrorThrown) =>
																						{
																							console.log('Withdrawal Error')
																							get_Element.parents('.tab-content').prev().find('.nav-link[href = "#CryptoCurrency_Withdraw_1"]').trigger('click')

																						}
																					})
																				},

																				'error'			:	(set_jQueryXMLHttpRequest, set_TextStatus, set_ErrorThrown) =>
																				{
																					console.log('Withdrawal Error')
																					get_Element.parents('.tab-content').prev().find('.nav-link[href = "#CryptoCurrency_Withdraw_1"]').trigger('click')
																				}
																			})
																			
																		}
																	}
																	className = 'btn btn-theme btn--icon-text col-md waves-effect' type = 'button'>
																	<i className = 'zwicon-export'></i>Withdraw
																</button>
															</div>
														</div>
													</form>
												</div>

												<div className = 'tab-pane fade' id = 'CryptoCurrency_Withdraw_2' role = 'tabpanel'>
													<form>
														<div className = 'form-row'>
															<div className = 'form-group col-md-12 pb-2'>
																<center className = 'mt-4'>
																	<h2 id = 'CryptoCurrency_Withdraw_Loader' className = 'Loading mb-4' style = {{ 'display' : 'none' }}></h2>
																	<h2 id = 'CryptoCurrency_Withdraw_Message' style = {{ 'display' : 'none' }}></h2>
																</center>
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
		}

		CryptoCurrency_Transaction_Inteface(set_Component)
		{
			let get_Interface = (set_Component) =>
			{
				return	<div>
							<table ref = { set_Component.Element['Table_CryptoCurrency_Transaction'] } className = 'table table-bordered table-hover' width = '100%'>
								<thead>
									<tr>
										<th>Date</th>
										<th>Action</th>
										<th>Amount</th>
									</tr>
								</thead>
								<tbody></tbody>
							</table>
						</div>
			}

			return	<ECIMS_Dialog ref = { set_Component.Element['Dialog_CryptoCurrency_Transaction'] } 

			Button =
			{[
				{
					'Identity'	:	'Close',
					'Text'		:	'Close',
					'Class'		:	'btn btn-danger btn-lg',
					'Function'	:	() =>
					{
						set_Component.Element['Dialog_CryptoCurrency_Transaction'].current.Hide()
					}
				}
			]}

			Custom = {{  'Available' : true, 'Interface' : get_Interface(set_Component) }} 
			/>
		}

		CryptoCurrency_Add_Interface(set_Component)
		{
			return	<div>
						<div ref = { set_Component.Element['Dialog_CryptoCurrency_Add'] } className = 'modal fade' tabIndex = '-1' role = 'dialog'>
							<div className = 'modal-dialog'>
								<div className = 'modal-content'>

									<h3 className = 'text-center pt-4'>Add Etherium</h3>

									<div className = 'modal-body'>
										<div className = 'tab-container'>
											<ul className = 'nav nav-tabs' role = 'tablist' style = {{ 'display' : 'none' }}>
												<li className = 'nav-item'>
													<a className = 'nav-link active' data-toggle = 'tab' href = '#CryptoCurrency_Add_1' role = 'tab'></a>
												</li>

												<li className = 'nav-item'>
													<a className = 'nav-link' data-toggle = 'tab' href = '#CryptoCurrency_Add_2' role = 'tab'></a>
												</li>

												<li className = 'nav-item'>
													<a className = 'nav-link' data-toggle = 'tab' href = '#CryptoCurrency_Add_3' role = 'tab'></a>
												</li>
											</ul>

											<div className = 'tab-content'>
												<div className = 'tab-pane fade active show' id = 'CryptoCurrency_Add_1' role = 'tabpanel'>
													<form>
														<div className = 'form-row'>
															<div className = 'form-group col-md-12 pb-2'>
																<button
																	onClick =
																	{
																		() =>
																		{
																			if ($('input[name = "PHP"]').prop('readonly'))
																			{
																				$('input[name = "PHP"]').prop('readonly', false)
																				$('input[name = "ETH"]').prop('readonly', true)
																			}

																			else
																			{
																				$('input[name = "PHP"]').prop('readonly', true)
																				$('input[name = "ETH"]').prop('readonly', false)
																			}
																		}
																	}
																	className = 'btn btn-theme btn--icon-text col-md waves-effect' type = 'button'>
																	<i className = 'zwicon-credit-card'></i>Switch Currency
																</button>
															</div>

															<div className = 'form-group col-md-6 pb-2'>
																<input onChange = { set_Event => $('#CryptoCurrency_Add_ETH').val(this.Convert_Currency('PHP', 'ETH', 10, set_Event.target.value)) } id = 'CryptoCurrency_Add_PHP' name = 'PHP' className = 'form-control' type = 'number' step = '0.01' defaultValue = '0.00' required/>
																<label className = 'form-control-placeholder' htmlFor = 'PHP'>PHP</label>
																<div className = 'valid-feedback'>PHP is valid</div>
																<div className = 'invalid-feedback'>Please provide an PHP</div>
															</div>

															<div className = 'form-group col-md-6 pb-2'>
																<input onChange = { set_Event => $('#CryptoCurrency_Add_PHP').val(this.Convert_Currency('ETH', 'PHP', 2, set_Event.target.value)) } id = 'CryptoCurrency_Add_ETH' name = 'ETH' className = 'form-control' type = 'number' step = '0.0000000001' defaultValue = '0.00' readOnly required/>
																<label className = 'form-control-placeholder' htmlFor = 'ETH'>ETH</label>
																<div className = 'valid-feedback'>ETH is valid</div>
																<div className = 'invalid-feedback'>Please provide an ETH</div>
															</div>

															<div className = 'form-group col-md-12 pb-2'>
																<button
																	onClick =
																	{
																		set_Event =>
																		{
																			let get_Element = $(set_Event.target)

																			set_Component.Element['Paypal_Checkout_Interface'].current.Paypal_Checkout_Initialization($('input[name = "PHP"]').val(),
																			
																			set_Callback_Data =>
																			{
																				if (set_Callback_Data)
																				{
																					get_Element.parents('.tab-content').prev().find('.nav-link[href = "#CryptoCurrency_Add_3"]').trigger('click')
																					$('#CryptoCurrency_Add_Loader').show()
																					$('#CryptoCurrency_Add_Message').hide()
																				}

																				else
																				{
																					get_Element.parents('.tab-content').prev().find('.nav-link[href = "#CryptoCurrency_Add_2"]').trigger('click')
																					$('#CryptoCurrency_Add_Loader').hide()
																					$('#CryptoCurrency_Add_Message').show()
																				}
																			},

																			set_Callback_Data =>
																			{
																				get_Element.parents('.tab-content').prev().find('.nav-link[href = "#CryptoCurrency_Add_3"]').trigger('click')
																				$('#CryptoCurrency_Add_Loader').show()
																				$('#CryptoCurrency_Add_Message').hide()

																				let get_FormData = new FormData()

																				get_FormData.append('Action', 'Insert_User_Log')
																				get_FormData.append('User_Identity', Session_User_Identity())
																				get_FormData.append('Log_Action', 'Purchased Etherium')
																				get_FormData.append('Log_Type', 'Etherium : Add')

																				if (set_Callback_Data != undefined)
																					get_FormData.append('Log_Information', JSON.stringify(set_Callback_Data))

																				else
																					get_FormData.append('Log_Information', '')

																				ECIMS_Main_HTTP.Manage(get_FormData, set_Callback_Data =>
																				{
																					if (set_Callback_Data)
																					{
																						$('#CryptoCurrency_Add_Message').text('Successfully added Etherium to Your Wallet')
																						System_Blockchain_Owner.Send_Balance(this.User_Account, $('#CryptoCurrency_Add_ETH').val(), async () =>
																						{
																							let get_Balance = await System_Blockchain_User.Balance
	
																							set_Component.state['User_Ethereum_Balance'] = get_Balance['ETH']
																							set_Component.state['User_PhilippinePeso_Balance'] = get_Balance['PHP']

																							set_Component.Update_Interface()
																						})
																					}

																					else
																						$('#CryptoCurrency_Add_Message').text('Can`t add Etherium to Your Wallet. Please try again later')

																					$('#CryptoCurrency_Add_Loader').hide()
																					$('#CryptoCurrency_Add_Message').show()

																					setTimeout(()=>
																					{
																						get_Element.parents('.tab-content').prev().find('.nav-link[href = "#CryptoCurrency_Add_1"]').trigger('click')
																					}, 3e3)
																				})
																			})

																			$(set_Event.target).parents('.tab-content').prev().find('.nav-link[href = "#CryptoCurrency_Add_2"]').trigger('click')
																		}
																	}
																	className = 'btn btn-theme btn--icon-text col-md waves-effect' type = 'button'>
																	<i className = 'zwicon-credit-card'></i>
																	<div>Process Addition of Etherium</div>
																</button>
															</div>
														</div>
													</form>
												</div>

												<div className = 'tab-pane fade' id = 'CryptoCurrency_Add_2' role = 'tabpanel'>
													<form>
														<div className = 'form-row'>
															<div className = 'form-group col-md-12 pb-2'>
																<ECIMS_Authenticator ref = { set_Component.Element['Paypal_Checkout_Interface'] } method = 'Paypal'/>
															</div>

															<div className = 'form-group col-md-12 pb-2'>
																<button onClick = { set_Event => $(set_Event.target).parents('.tab-content').prev().find('.nav-link[href = "#CryptoCurrency_Add_1"]').trigger('click') } className = 'btn btn-theme btn--icon-text col-md waves-effect' type = 'button'>
																	<i className = 'zwicon-back'></i>Back
																</button>
															</div>
														</div>
													</form>
												</div>

												<div className = 'tab-pane fade' id = 'CryptoCurrency_Add_3' role = 'tabpanel'>
													<form>
														<div className = 'form-row'>
															<div className = 'form-group col-md-12 pb-2'>
																<center className = 'mt-4'>
																	<h2 id = 'CryptoCurrency_Add_Loader' className = 'Loading mb-4' style = {{ 'display' : 'none' }}></h2>
																	<h2 id = 'CryptoCurrency_Add_Message' style = {{ 'display' : 'none' }}></h2>
																</center>
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
		}
	}

	window.ECIMS_Blockchain = ECIMS_Blockchain
})