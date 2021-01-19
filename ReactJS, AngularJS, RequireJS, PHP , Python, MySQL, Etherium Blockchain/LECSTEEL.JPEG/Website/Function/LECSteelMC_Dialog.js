/* Dialog */

/* Dynamic Dialog Box created by Rafael Nobleza Masallo. Cheeersss!!! */
/* Dynamic Dialog Box created by Rafael Nobleza Masallo. Cheeersss!!! */
/* Dynamic Dialog Box created by Rafael Nobleza Masallo. Cheeersss!!! */
/* `Wag ninyo kalimutan iinclude yung Template if ieedit itong Dialog Class */

export class Dialog
{
	constructor(set_VariableName, set_Identity)
	{
		this.Identity = set_Identity

		const Dialog = this

		angular.element('body').append(angular.element('<div id = New_Dialog_' + set_Identity + '>')
		.load('Interface/LECSteelMC_Dialog.html', function()
		{
			console.log("Class Dialog has been initialized.");

			angular.element('#New_Dialog_' + set_Identity + ' #Dialog').attr('id', 'Dialog_' + set_Identity)

			angular.element('#New_Dialog_' + set_Identity + ' #Dialog_Title').attr('id', 'Dialog_Title_' + set_Identity)

			angular.element('#New_Dialog_' + set_Identity + ' #Dialog_Loading').attr('id', 'Dialog_Loading_' + set_Identity)

			angular.element('#New_Dialog_' + set_Identity + ' #Dialog_Alert').attr('id', 'Dialog_Alert_' + set_Identity)
			angular.element('#New_Dialog_' + set_Identity + ' #Dialog_Alert_Title').attr('id', 'Dialog_Alert_Title_' + set_Identity)
			angular.element('#New_Dialog_' + set_Identity + ' #Dialog_Alert_Message').attr('id', 'Dialog_Alert_Message_' + set_Identity)
			
			angular.element('#New_Dialog_' + set_Identity + ' #Dialog_Form').attr('id', 'Dialog_Form_' + set_Identity)
			
			angular.element('#New_Dialog_' + set_Identity + ' #btn_Close').attr('id', 'btn_Close_' + set_Identity)
			angular.element('#New_Dialog_' + set_Identity + ' #btn_Ok').attr('id', 'btn_Ok_' + set_Identity)
			angular.element('#New_Dialog_' + set_Identity + ' #btn_No').attr('id', 'btn_No_' + set_Identity)
			
			this.btn_Ok =
			{
				Button_Text: "Ok",				

				set Text(set_Text)
				{				
					this.Button_Text = set_Text

					angular.element('#btn_Ok_' + Dialog.Identity).text(set_Text)			
				},

				get Text()
				{
					return this.Button_Text
				},

				Button_Visible : true,

				set Visible(set_Visible)
				{
					this.Button_Visible = set_Visible

					if (set_Visible)				
						angular.element('#btn_Ok_' + Dialog.Identity).show()			

					else
						angular.element('#btn_Ok_' + Dialog.Identity).hide()
				},

				get Visible()
				{
					return this.Button_Visible
				},

				
				Button_Interface : 'btn btn-primary"',

				set Interface(set_Interface)
				{
					this.Button_Interface = set_Interface
					
					angular.element('#btn_Ok_' + Dialog.Identity).attr('class', set_Interface)
				},

				get Interface()
				{
					return this.Button_Interface
				},

				set Click(set_Function)
				{					
					angular.element('#btn_Ok_' + Dialog.Identity).removeAttr('ng-Click')
					angular.element('#btn_Ok_' + Dialog.Identity).attr('ng-Click', set_VariableName + '.Dialog.Result = '+'"Ok"'+';' + set_Function)				
				}

			}

			this.btn_No =
			{
				Button_Text: "No",		

				set Text(set_Text)
				{				
					this.Button_Text = set_Text

					angular.element('#btn_No_' + Dialog.Identity).text(set_Text)			
				},

				get Text()
				{
					return this.Button_Text
				},

				Button_Visible : true,

				set Visible(set_Visible)
				{
					this.Button_Visible = set_Visible

					if (set_Visible)				
						angular.element('#btn_No_' + Dialog.Identity).show()			

					else
						angular.element('#btn_No_' + Dialog.Identity).hide()
				},

				get Visible()
				{
					return this.Button_Visible
				},

				Button_Interface : 'btn btn-primary"',

				set Interface(set_Interface)
				{
					this.Button_Interface = set_Interface

					angular.element('#btn_No_' + Dialog.Identity).attr('class', set_Interface)
				},

				get Interface()
				{
					return this.Button_Interface
				},

				set Click(set_Function)
				{					
					angular.element('#btn_No_' + Dialog.Identity).removeAttr('ng-Click')
					angular.element('#btn_No_' + Dialog.Identity).attr('ng-Click', set_VariableName + '.Dialog.Result = '+'"No"'+';' + set_Function)			
				}
			}

			this.Dialog =
			{
				Dialog_Title: 'Dialog',

				set Title(set_Title)
				{
					this.Dialog_Title = set_Title

					angular.element('#Dialog_Title_' + Dialog.Identity).text(set_Title)
				},

				get Title()
				{
					return this.Dialog_Title
				},

				Dialog_Closeable: false,

				set Closeable(set_Closeable)
				{
					this.Dialog_Closeable = set_Closeable

					if (set_Closeable)
					{						
						angular.element('#btn_Close_' + Dialog.Identity).show()
						angular.element('#Dialog_' + Dialog.Identity).modal({ animated: true, keyboard: set_Closeable, backdrop: set_Closeable, ignoreBackdropClick: !set_Closeable })
					}

					else
					{
						angular.element('#btn_Close_' + Dialog.Identity).hide()
						angular.element('#Dialog_' + Dialog.Identity).modal({ animated: true, keyboard: set_Closeable, backdrop: 'static', ignoreBackdropClick: !set_Closeable })									
					}
				},

				get Closeable()
				{
					return this.Dialog_Closeable
				},

				Dialog_Result: null,

				set Result(set_Result)
				{					
					this.Dialog_Result = set_Result
					console.log(set_Result)
				},

				get Result()
				{
					return this.Dialog_Result
				}
			}

			this.Loading =
			{
				Loading_Visible : false,

				set Visible(set_Visible)
				{	
					this.Loading_Visible = set_Visible

					if (set_Visible)
					{
						angular.element('#Dialog_Alert_' + Dialog.Identity).hide()
						angular.element('#Dialog_Form_' + Dialog.Identity).hide()
						angular.element('#Dialog_Loading_' + Dialog.Identity).show()
					}												
				}

			}

			this.Alert =
			{
				Alert_Title : 'Title Here',

				set Title(set_Title)
				{
					this.Alert_Title = set_Title
					angular.element('#Dialog_Alert_Title_' + Dialog.Identity).text(set_Title)
				},

				Alert_Message : 'Message Here',

				set Message(set_Message)
				{
					this.Alert_Message = set_Message
					angular.element('#Dialog_Alert_Message_' + Dialog.Identity).text(set_Message)
				},

				Alert_Visible : false,

				set Visible(set_Visible)
				{
					this.Alert_Visible = set_Visible

					if (set_Visible)
					{
						angular.element('#Dialog_Alert_' + Dialog.Identity).show()
						angular.element('#Dialog_Form_' + Dialog.Identity).hide()
						angular.element('#Dialog_Loading_' + Dialog.Identity).hide()
					}
				},

				Alert_Interface : 'alert alert-dismissible alert-success',
				
				set Interface(set_Interface)
				{
					this.Alert_Interface = set_Interface

					angular.element('#Dialog_Alert_' + Dialog.Identity).attr('class', set_Interface)
				}
			}

			this.Form =
			{
				Form_Visible : false,

				set Visible(set_Visible)
				{
					this.set_Visible = set_Visible

					if (set_Visible)
					{												
						angular.element('#Dialog_Alert_' + Dialog.Identity).hide()
						angular.element('#Dialog_Form_' + Dialog.Identity).show()
						angular.element('#Dialog_Loading_' + Dialog.Identity).hide()
					}

				}
			}



		}.bind(this)));
		
	}

	Show()
	{
		angular.element('#Dialog_' + this.Identity).modal('show')
	}	

	Hide()
	{
		angular.element('#Dialog_' + this.Identity).modal('hide')
	}

	Toggle()
	{
		angular.element('#Dialog_' + this.Identity).modal('toggle')
	}

	check_Visible_Value()
	{
		if(angular.element('#Dialog_' + this.Identity).hasClass('show'))
			return true

		else
			return false
	}

	Compile($set_Compile, $set_Scope)
	{		
		$set_Compile(angular.element('#Dialog_' + this.Identity))($set_Scope)
	}

	set_Dialog_Control(set_Control)
	{
		angular.element('#Dialog_Form_' + this.Identity).html(set_Control)
	}

	get_Dialog_Control_Data(set_Key, set_Value)
	{	
		var get_Dialog_Form = angular.element(document.querySelector('#Dialog_Form_' + this.Identity))[0]

		var get_Dialog_Form_Data = new FormData(get_Dialog_Form)

		if (Array.isArray(set_Key) && Array.isArray(set_Value))				
			for (let set_Counter = 0; set_Counter < set_Key.length; set_Counter ++)			
				get_Dialog_Form_Data.append(set_Key[set_Counter], set_Value[set_Counter])
		else		
			get_Dialog_Form_Data.append(set_Key, set_Value)
				
		
		/*if(formData.has('Username'))
			alert(formData.get('Username'));

		if(formData.has('Password'))
			alert(formData.get('Password'));
		for (var set_KeyValue of get_Dialog_Form_Data.entries())
		{			
			console.log(set_KeyValue[0]); 
			console.log(set_KeyValue[1]);
		}*/

		return get_Dialog_Form_Data		
		
	}

	del_Dialog_Control()
	{
		angular.element('#Dialog_Form_' + this.Identity).html(null)
	}

	del_Dialog()
	{
		angular.element('#New_Dialog_' + this.Identity).remove()
	}

	check_Dialog_Control()
	{
		var get_Dialog_Form = angular.element('#Dialog_Form_' + this.Identity)
		
		if (get_Dialog_Form.html() == null || get_Dialog_Form.html() == '')
		{
			return false
		}
		
		else
			return true
	}
}

export var Form_Interface_Login = $.get('./Interface/LECSteelMC_Login.html',
									function(set_data)
									{ 
										Form_Interface_Login = set_data 
									}).done(function()
									{ 
										console.log('LECSteelMC_Login.html has been loaded successfully.') 
									})