#! "C:/Python38/python.exe"

#print('Content-Type : text/html\n')
print('Content-type:application/json;charset=utf-8\n')
#print('Content-Type : application/x-www-form-urlencoded')

from ECIMS_Main import *

def Main_HTTP_Method():

	try:
		GLOBAL['REQUEST'] = request.form.to_dict()

		if GLOBAL['REQUEST']['Action'] == 'User : Registration':

			from ECIMS_User import User
			from ECIMS_Blockchain import Blockchain

			GLOBAL['REQUEST']['User_Identity']			=	'USR-' + str(Main.Select_Counter(GLOBAL['User_Counter_Code']))
			GLOBAL['REQUEST']['User_Type']				=	'Cooperator'
			GLOBAL['REQUEST']['User_Privilege']			=	'["Cooperator"]'
			GLOBAL['REQUEST']['User_State']				=	'Unconfirmed'

			get_Ethereum_Account = Blockchain.Create_Account()

			GLOBAL['REQUEST']['User_Ethereum_Address']	=	get_Ethereum_Account['Address']
			GLOBAL['REQUEST']['User_Ethereum_Key']		=	get_Ethereum_Account['Private_Key']
			GLOBAL['REQUEST']['User_Inserted_By']		=	GLOBAL['REQUEST']['User_Identity']
			GLOBAL['REQUEST']['User_Inserted_DateTime']	=	str(datetime.now())

			GLOBAL['REQUEST']['User_Gender']			=	''
			GLOBAL['REQUEST']['User_Citizenship']		=	''
			GLOBAL['REQUEST']['User_Birth_Place']		=	''
			GLOBAL['REQUEST']['User_Birth_DateTime']	=	''
			GLOBAL['REQUEST']['User_Address_Home']		=	''
			GLOBAL['REQUEST']['User_Image_Path']		=	request.files['User_Image_Path']

			if GLOBAL['REQUEST']['User_Image_Path'].filename != '':
				GLOBAL['REQUEST']['User_Image_Path'] = Main.Image_Save(GLOBAL['REQUEST']['User_Image_Path'], 'User', GLOBAL['REQUEST']['User_Identity'])

			else:
				GLOBAL['REQUEST']['User_Image_Path'] = ''

			GLOBAL['REQUEST']['Employment_Company_Name']					=	''
			GLOBAL['REQUEST']['Employment_Business_Type']					=	''
			GLOBAL['REQUEST']['Employment_Business_Form']					=	''
			GLOBAL['REQUEST']['Employment_Business_Address']				=	''
			GLOBAL['REQUEST']['Employment_Employer_Firstname']				=	''
			GLOBAL['REQUEST']['Employment_Employer_Middlename']				=	''
			GLOBAL['REQUEST']['Employment_Employer_Lastname']				=	''
			GLOBAL['REQUEST']['Employment_Business_Contact_Number']			=	''
			GLOBAL['REQUEST']['Employment_Business_Contact_Number_Local']	=	''
			GLOBAL['REQUEST']['Employment_Tenure_Year']						=	''
			GLOBAL['REQUEST']['Employment_Appointment_Status']				=	''
			GLOBAL['REQUEST']['Employment_Position_Title']					=	''
			GLOBAL['REQUEST']['Employment_Position_Level']					=	''
			GLOBAL['REQUEST']['Employment_Pay_Period']						=	''
			GLOBAL['REQUEST']['Employment_Hired_DateTime']					=	''

			if User.Insert_User_Credential() == True & User.Insert_User_Personal() == True & User.Insert_User_Personal_Employment() == True:

				Main.Update_Counter(GLOBAL['User_Counter_Code'])
				return { 'Output' : 'Insert Succeeded' }

			else:
				return { 'Output' : 'Insert Failed' }

		elif GLOBAL['REQUEST']['Action'] == 'User : Login':

			from ECIMS_User import User

			return str(User.Select_User())

		elif GLOBAL['REQUEST']['Action'] == 'User : Send Account Confirmation Code':

			from ECIMS_User import User

			GLOBAL['REQUEST']['Confirmation_Identity']			=	'USR-CFMTN-' + str(Main.Select_Counter(GLOBAL['User_Confirmation_Counter_Code']))
			GLOBAL['REQUEST']['Confirmation_Code']				=	Hashids(salt = str(datetime.now()), min_length=10).encrypt(random.randrange(0, 999)).upper()
			GLOBAL['REQUEST']['Confirmation_Status']			=	'Pending'
			GLOBAL['REQUEST']['Confirmation_Inserted_DateTime']	=	str(datetime.now())

			if User.Insert_User_Confirmation() == True:

				Main.Update_Counter(GLOBAL['User_Confirmation_Counter_Code'])
				Main.set_Email_Message('UB_ECIMS', GLOBAL['REQUEST']['User_Address_Email'], 'Account Confirmation', 'Your Confirmation Code is: ' + GLOBAL['REQUEST']['Confirmation_Code'])
				Main.set_ShortMessageService_Message('UB_ECIMS', '63' + GLOBAL['REQUEST']['User_Contact_TelephoneNumber_Mobile'], 'Account Confirmation', 'Your Confirmation Code is: ' + GLOBAL['REQUEST']['Confirmation_Code'])

				return { 'Output' : 'Insert Succeeded' }

			else:
				return { 'Output' : 'Insert Failed' }

		elif GLOBAL['REQUEST']['Action'] == 'User : Confirm Account':

			from ECIMS_User import User

			get_Data = User.Select_User_Confirmation()

			if get_Data == []:
				return str(get_Data)

			else:

				GLOBAL['REQUEST']['Update_Action'] = 'Update : Specific : [ User_State ]'
				GLOBAL['REQUEST']['User_State'] = 'Confirmed'
				GLOBAL['REQUEST']['User_Updated_By'] = GLOBAL['REQUEST']['User_Identity']
				GLOBAL['REQUEST']['User_Updated_DateTime'] = str(datetime.now())

				if User.Update_User_Credential() == True:

					GLOBAL['REQUEST']['Confirmation_Identity'] = json.loads(get_Data)[0]['Confirmation_Identity']
					GLOBAL['REQUEST']['Confirmation_Status'] = 'Used'
					User.Update_User_Confirmation()

					return { 'Output' : 'Update Succeeded' }

				else:
					return { 'Output' : 'Update Failed' }

		elif GLOBAL['REQUEST']['Action'] == 'Select_User':

			from ECIMS_User import User

			return str(User.Select_User())

		elif GLOBAL['REQUEST']['Action'] == 'Update_User_Credential':

			from ECIMS_User import User

			GLOBAL['REQUEST']['User_Updated_DateTime'] = str(datetime.now())

			if User.Update_User_Credential() == True:
				return { 'Output' : 'Update Succeeded' }

			else:
				return { 'Output' : 'Insert Failed' }


		elif GLOBAL['REQUEST']['Action'] == 'Update_User_Personal':

			from ECIMS_User import User

			if request.files['User_Image_Path'].filename != '':
				GLOBAL['REQUEST']['User_Image_Path'] = Main.Image_Save(request.files['User_Image_Path'], 'User', GLOBAL['REQUEST']['User_Identity'])
				GLOBAL['REQUEST']['Update_Action'] = 'Update : Specific'

			else:
				GLOBAL['REQUEST']['Update_Action'] = 'Update : Specific : < User_Image_Path >'

			get_Boolean_1 = User.Update_User_Personal()

			GLOBAL['REQUEST']['Update_Action'] = 'Update : Specific : [ User_Updated_By, User_Updated_DateTime ]'
			GLOBAL['REQUEST']['User_Updated_DateTime'] = str(datetime.now())
			get_Boolean_2 = User.Update_User_Credential()

			if get_Boolean_1 and get_Boolean_2:
				return { 'Output' : 'Update Succeeded'}

			else:
				return { 'Output' : 'Insert Failed'}

		elif GLOBAL['REQUEST']['Action'] == 'Update_User_Personal_Employment':

			from ECIMS_User import User

			GLOBAL['REQUEST']['Update_Action'] = 'Update : Specific'
			get_Boolean_1 = User.Update_User_Personal_Employment()

			GLOBAL['REQUEST']['Update_Action'] = 'Update : Specific : [ User_Updated_By, User_Updated_DateTime ]'
			GLOBAL['REQUEST']['User_Updated_DateTime'] = str(datetime.now())
			get_Boolean_2 = User.Update_User_Credential()

			if get_Boolean_1 and get_Boolean_2:
				return { 'Output' : 'Update Succeeded' }

			else:
				return { 'Output' : 'Insert Failed' }

		elif GLOBAL['REQUEST']['Action'] == 'Select_Cooperative':

			from ECIMS_Cooperative import Cooperative

			return str(Cooperative.Select_Cooperative())

		elif GLOBAL['REQUEST']['Action'] == 'Select_Cooperative_Type':

			from ECIMS_Cooperative import Cooperative

			return str(Cooperative.Select_Cooperative_Type())

		elif GLOBAL['REQUEST']['Action'] == 'Select_Cooperative_Category':

			from ECIMS_Cooperative import Cooperative

			return str(Cooperative.Select_Cooperative_Category())

		elif GLOBAL['REQUEST']['Action'] == 'Select_Cooperative_OperationArea':

			from ECIMS_Cooperative import Cooperative

			return str(Cooperative.Select_Cooperative_OperationArea())

		elif GLOBAL['REQUEST']['Action'] == 'Select_Cooperative_CommonBond':

			from ECIMS_Cooperative import Cooperative

			return str(Cooperative.Select_Cooperative_CommonBond())

		elif GLOBAL['REQUEST']['Action'] == 'Insert_Cooperative_EconomicSurvey':

			from ECIMS_Cooperative import Cooperative

			GLOBAL['REQUEST']['Cooperative_Identity'] = 'COOP-' + str(Main.Select_Counter(GLOBAL['Cooperative_Counter_Code']))
			GLOBAL['REQUEST']['EconomicSurvey_Description'] = GLOBAL['REQUEST']['Cooperative_EconomicSurvey']
			GLOBAL['REQUEST']['Cooperative_Parent'] = ''
			GLOBAL['REQUEST']['Cooperative_Founder'] = json.dumps([GLOBAL['REQUEST']['User_Identity']])
			GLOBAL['REQUEST']['Cooperative_Inserted_By'] = GLOBAL['REQUEST']['User_Identity']
			GLOBAL['REQUEST']['Cooperative_Inserted_DateTime'] = str(datetime.now())

			get_Boolean_1 = Cooperative.Insert_Cooperative()
			get_Boolean_2 = Cooperative.Insert_Cooperative_EconomicSurvey()
			get_Boolean_3 = Cooperative.Insert_Cooperative_ShareCapital()
			get_Boolean_4 = Cooperative.Insert_Cooperative_EconomicAspect()
			get_Boolean_5 = Cooperative.Insert_Cooperative_FinancialAspect()
			get_Boolean_6 = Cooperative.Insert_Cooperative_TechnicalAspect()
 
			if get_Boolean_1 and get_Boolean_2 and get_Boolean_3 and get_Boolean_4 and get_Boolean_5 and get_Boolean_6:

				Main.Update_Counter(GLOBAL['Cooperative_Counter_Code'])

				return { 'Output' : 'Insert Succeeded'}

			else:
				return { 'Output' : 'Insert Failed'}

		elif GLOBAL['REQUEST']['Action'] == 'Update_Cooperative_EconomicSurvey':

			from ECIMS_Cooperative import Cooperative

			GLOBAL['REQUEST']['EconomicSurvey_Description'] = GLOBAL['REQUEST']['Cooperative_EconomicSurvey']
			GLOBAL['REQUEST']['Cooperative_Parent'] = ''
			GLOBAL['REQUEST']['Cooperative_Founder'] = json.dumps([GLOBAL['REQUEST']['User_Identity']])
			GLOBAL['REQUEST']['Cooperative_Updated_By'] = GLOBAL['REQUEST']['User_Identity']
			GLOBAL['REQUEST']['Cooperative_Updated_DateTime'] = str(datetime.now())

			get_Boolean_1 = Cooperative.Update_Cooperative()
			get_Boolean_2 = Cooperative.Update_Cooperative_EconomicSurvey()
			get_Boolean_3 = Cooperative.Update_Cooperative_ShareCapital()
			get_Boolean_4 = Cooperative.Update_Cooperative_EconomicAspect()
			get_Boolean_5 = Cooperative.Update_Cooperative_FinancialAspect()
			get_Boolean_6 = Cooperative.Update_Cooperative_TechnicalAspect()
 
			if get_Boolean_1 and get_Boolean_2 and get_Boolean_3 and get_Boolean_4 and get_Boolean_5 and get_Boolean_6:
				return { 'Output' : 'Update Succeeded'}

			else:
				return { 'Output' : 'Update Failed'}

		elif GLOBAL['REQUEST']['Action'] == 'Update_Cooperative':

			from ECIMS_Cooperative import Cooperative

			GLOBAL['REQUEST']['Cooperative_Updated_By'] = GLOBAL['REQUEST']['User_Identity']
			GLOBAL['REQUEST']['Cooperative_Updated_DateTime'] = str(datetime.now())


			if GLOBAL['REQUEST']['Cooperative_State'] == 'Confirmed' and GLOBAL['REQUEST']['Update_Action'] == 'Update : Specific : [ Cooperative_State ]':

				from ECIMS_Blockchain import Blockchain

				get_Boolean_1 = Cooperative.Update_Cooperative()

				GLOBAL['REQUEST']['Update_Action'] = 'Update : Specific : [ Cooperative_Ethereum_Address, Cooperative_Ethereum_Key, Cooperative_Ethereum_Address_Vault, Cooperative_Ethereum_Key_Vault ]'

				get_Ethereum_Account = Blockchain.Create_Account()
				GLOBAL['REQUEST']['Cooperative_Ethereum_Address']		=	get_Ethereum_Account['Address']
				GLOBAL['REQUEST']['Cooperative_Ethereum_Key']			=	get_Ethereum_Account['Private_Key']

				get_Ethereum_Account = Blockchain.Create_Account()
				GLOBAL['REQUEST']['Cooperative_Ethereum_Address_Vault']	=	get_Ethereum_Account['Address']
				GLOBAL['REQUEST']['Cooperative_Ethereum_Key_Vault']		=	get_Ethereum_Account['Private_Key']
				get_Boolean_2 = Cooperative.Update_Cooperative()

				GLOBAL['REQUEST']['Member_Identity']			=	GLOBAL['REQUEST']['Member_Identity']
				GLOBAL['REQUEST']['Member_Position']			=	json.dumps(['Owner', 'Member'])
				GLOBAL['REQUEST']['Member_Appointment_Status']	=	''
				GLOBAL['REQUEST']['Member_Eligibility']			=	''
				GLOBAL['REQUEST']['Member_Compensation']		=	''
				GLOBAL['REQUEST']['Member_State']				=	'Confirmed'

				get_Boolean_3 = Cooperative.Insert_Cooperative_OrganizationalStructure_Member()

				if get_Boolean_1 and get_Boolean_2 and get_Boolean_3:
					return { 'Output' : 'Update Succeeded' }

				else:
					return { 'Output' : 'Update Failed' }

			else:

				if Cooperative.Update_Cooperative() == True:
					return { 'Output' : 'Update Succeeded' }

				else:
					return { 'Output' : 'Update Failed' }

		elif GLOBAL['REQUEST']['Action'] == 'Delete_Cooperative_OrganizationalStructure_Member':

			from ECIMS_Cooperative import Cooperative

			if Cooperative.Delete_Cooperative_OrganizationalStructure_Member() == True:
				return { 'Output' : 'Delete Succeeded' }

			else:
				return { 'Output' : 'Delete Failed' }

		elif GLOBAL['REQUEST']['Action'] == 'Select_User_Personal_Gender':

			from ECIMS_User import User

			return User.Select_User_Personal_Gender()

		elif GLOBAL['REQUEST']['Action'] == 'Select_User_Log':

			from ECIMS_User import User

			return User.Select_User_Log()

		elif GLOBAL['REQUEST']['Action'] == 'Insert_User_Log':

			from ECIMS_User import User

			GLOBAL['REQUEST']['Log_Identity']			=	'USR-LG-' + str(Main.Select_Counter(GLOBAL['User_Log_Counter_Code']))
			GLOBAL['REQUEST']['Log_Inserted_By']		=	GLOBAL['REQUEST']['User_Identity']
			GLOBAL['REQUEST']['Log_Inserted_DateTime']	=	str(datetime.now())

			if User.Insert_User_Log() == True:
				Main.Update_Counter(GLOBAL['User_Log_Counter_Code'])

				return { 'Output' : 'Insert Succeeded' }

			else:
				return { 'Output' : 'Insert Failed' }

		elif GLOBAL['REQUEST']['Action'] == 'Select_Philippines_Region':

			from ECIMS_Philippines import Philippines

			return Philippines.Select_Philippines_Region()

		elif GLOBAL['REQUEST']['Action'] == 'Select_Philippines_Region_Province':

			from ECIMS_Philippines import Philippines

			return Philippines.Select_Philippines_Region_Province()

		elif GLOBAL['REQUEST']['Action'] == 'Select_Philippines_Region_Province_Locality':

			from ECIMS_Philippines import Philippines

			return Philippines.Select_Philippines_Region_Province_Locality()

		elif GLOBAL['REQUEST']['Action'] == 'Select_Philippines_Organization':

			from ECIMS_Philippines import Philippines

			return Philippines.Select_Philippines_Organization()

		elif GLOBAL['REQUEST']['Action'] == 'Cooperative_EconomicSurvey':

			from ECIMS_Cooperative import Cooperative
			from ECIMS_Philippines import Philippines

			get_Output											=	{}

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Cooperative_State }'
			GLOBAL['REQUEST']['Cooperative_State']				=	'Confirmed'
			get_Output['Cooperative']							=	str(Cooperative.Select_Cooperative())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Cooperative_Inserted_By }'
			GLOBAL['REQUEST']['Cooperative_Inserted_By']		=	GLOBAL['REQUEST']['User_Identity']
			get_Output['Cooperative_Requested']					=	str(Cooperative.Select_Cooperative())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : All'
			get_Output['Cooperative_Type']						=	str(Cooperative.Select_Cooperative_Type())
			get_Output['Cooperative_Category']					=	str(Cooperative.Select_Cooperative_Category())
			get_Output['Cooperative_OperationArea']				=	str(Cooperative.Select_Cooperative_OperationArea())
			get_Output['Cooperative_CommonBond']				=	str(Cooperative.Select_Cooperative_CommonBond())
			get_Output['Cooperative_Capitalization']			=	str(Cooperative.Select_Cooperative_Capitalization())
			get_Output['Philippines_Organization']				=	str(Philippines.Select_Philippines_Organization())
			get_Output['Philippines_Region']					=	str(Philippines.Select_Philippines_Region())
			get_Output['Philippines_Region_Province']			=	str(Philippines.Select_Philippines_Region_Province())
			get_Output['Philippines_Region_Province_Locality']	=	str(Philippines.Select_Philippines_Region_Province_Locality())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Member_Identity }'
			GLOBAL['REQUEST']['Member_Identity']				=	GLOBAL['REQUEST']['User_Identity']
			get_Output['User_Member_Information']				=	str(Cooperative.Select_Cooperative_OrganizationalStructure_Member())

			return get_Output

		elif GLOBAL['REQUEST']['Action'] == 'Cooperative_List':

			from ECIMS_Cooperative import Cooperative
			from ECIMS_Philippines import Philippines

			get_Output											=	{}

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Cooperative_State }'
			GLOBAL['REQUEST']['Cooperative_State']				=	'Pending'
			get_Output['Cooperative_Pending']					=	str(Cooperative.Select_Cooperative())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Cooperative_State }'
			GLOBAL['REQUEST']['Cooperative_State']				=	'Confirmed'
			get_Output['Cooperative_Confirmed']					=	str(Cooperative.Select_Cooperative())
			get_Output['Cooperative']							=	str(Cooperative.Select_Cooperative())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Cooperative_State }'
			GLOBAL['REQUEST']['Cooperative_State']				=	'Declined'
			get_Output['Cooperative_Declined']					=	str(Cooperative.Select_Cooperative())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Cooperative_State }'
			GLOBAL['REQUEST']['Cooperative_State']				=	'Cancelled'
			get_Output['Cooperative_Cancelled']					=	str(Cooperative.Select_Cooperative())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : All'
			get_Output['Cooperative_Type']						=	str(Cooperative.Select_Cooperative_Type())
			get_Output['Cooperative_Category']					=	str(Cooperative.Select_Cooperative_Category())
			get_Output['Cooperative_OperationArea']				=	str(Cooperative.Select_Cooperative_OperationArea())
			get_Output['Cooperative_CommonBond']				=	str(Cooperative.Select_Cooperative_CommonBond())
			get_Output['Cooperative_Capitalization']			=	str(Cooperative.Select_Cooperative_Capitalization())
			get_Output['Philippines_Organization']				=	str(Philippines.Select_Philippines_Organization())
			get_Output['Philippines_Region']					=	str(Philippines.Select_Philippines_Region())
			get_Output['Philippines_Region_Province']			=	str(Philippines.Select_Philippines_Region_Province())
			get_Output['Philippines_Region_Province_Locality']	=	str(Philippines.Select_Philippines_Region_Province_Locality())

			return get_Output

		elif GLOBAL['REQUEST']['Action'] == 'Cooperative_Associated':

			from ECIMS_Cooperative import Cooperative
			from ECIMS_Philippines import Philippines

			get_Output											=	{}

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Cooperative_State }'
			GLOBAL['REQUEST']['Cooperative_State']				=	'Confirmed'
			get_Output['Cooperative']							=	str(Cooperative.Select_Cooperative())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Member_Identity { Member_State } }, Cooperative_State'
			GLOBAL['REQUEST']['Member_Identity']				=	GLOBAL['REQUEST']['User_Identity']
			GLOBAL['REQUEST']['Member_State']					=	'Confirmed'
			get_Output['Cooperative_Associated']				=	str(Cooperative.Select_Cooperative())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : All'
			get_Output['Cooperative_Type']						=	str(Cooperative.Select_Cooperative_Type())
			get_Output['Cooperative_Category']					=	str(Cooperative.Select_Cooperative_Category())
			get_Output['Cooperative_OperationArea']				=	str(Cooperative.Select_Cooperative_OperationArea())
			get_Output['Cooperative_CommonBond']				=	str(Cooperative.Select_Cooperative_CommonBond())
			get_Output['Cooperative_Capitalization']			=	str(Cooperative.Select_Cooperative_Capitalization())
			get_Output['Philippines_Organization']				=	str(Philippines.Select_Philippines_Organization())
			get_Output['Philippines_Region']					=	str(Philippines.Select_Philippines_Region())
			get_Output['Philippines_Region_Province']			=	str(Philippines.Select_Philippines_Region_Province())
			get_Output['Philippines_Region_Province_Locality']	=	str(Philippines.Select_Philippines_Region_Province_Locality())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Member_Identity }'
			GLOBAL['REQUEST']['Member_Identity']				=	GLOBAL['REQUEST']['User_Identity']
			get_Output['User_Member_Information']				=	str(Cooperative.Select_Cooperative_OrganizationalStructure_Member())

			return get_Output

		elif GLOBAL['REQUEST']['Action'] == 'Cooperative_Dissociated':

			from ECIMS_Cooperative import Cooperative
			from ECIMS_Philippines import Philippines

			get_Output											=	{}

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Cooperative_State }'
			GLOBAL['REQUEST']['Cooperative_State']				=	'Confirmed'
			get_Output['Cooperative']							=	str(Cooperative.Select_Cooperative())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Cooperative_State, { Member_Identity { Member_State = Pending | Confirmed | Declined } } }'
			GLOBAL['REQUEST']['Member_Identity']				=	GLOBAL['REQUEST']['User_Identity']
			GLOBAL['REQUEST']['Member_State_1']					=	'Pending'
			GLOBAL['REQUEST']['Member_State_2']					=	'Confirmed'
			GLOBAL['REQUEST']['Member_State_3']					=	'Declined'
			get_Output['Cooperative_Dissociated']				=	str(Cooperative.Select_Cooperative())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : Specific : { Member_Identity { Member_State } }'
			GLOBAL['REQUEST']['Member_Identity']				=	GLOBAL['REQUEST']['User_Identity']

			GLOBAL['REQUEST']['Member_State']					=	'Pending'
			get_Output['Cooperative_Pending']					=	str(Cooperative.Select_Cooperative())

			GLOBAL['REQUEST']['Member_State']					=	'Declined'
			get_Output['Cooperative_Declined']					=	str(Cooperative.Select_Cooperative())

			GLOBAL['REQUEST']['Select_Action']					=	'Select : All'
			get_Output['Cooperative_Type']						=	str(Cooperative.Select_Cooperative_Type())
			get_Output['Cooperative_Category']					=	str(Cooperative.Select_Cooperative_Category())
			get_Output['Cooperative_OperationArea']				=	str(Cooperative.Select_Cooperative_OperationArea())
			get_Output['Cooperative_CommonBond']				=	str(Cooperative.Select_Cooperative_CommonBond())
			get_Output['Cooperative_Capitalization']			=	str(Cooperative.Select_Cooperative_Capitalization())
			get_Output['Philippines_Organization']				=	str(Philippines.Select_Philippines_Organization())
			get_Output['Philippines_Region']					=	str(Philippines.Select_Philippines_Region())
			get_Output['Philippines_Region_Province']			=	str(Philippines.Select_Philippines_Region_Province())
			get_Output['Philippines_Region_Province_Locality']	=	str(Philippines.Select_Philippines_Region_Province_Locality())

			return get_Output

		elif GLOBAL['REQUEST']['Action'] == 'Cooperative_Join':

			from ECIMS_Cooperative import Cooperative

			GLOBAL['REQUEST']['Member_Identity']			=	GLOBAL['REQUEST']['User_Identity']
			GLOBAL['REQUEST']['Member_Position']			=	json.dumps(['Applicant'])
			GLOBAL['REQUEST']['Member_Appointment_Status']	=	''
			GLOBAL['REQUEST']['Member_Eligibility']			=	''
			GLOBAL['REQUEST']['Member_Compensation']		=	''
			GLOBAL['REQUEST']['Member_State']				=	'Pending'

			GLOBAL['REQUEST']['Select_Action'] = 'Select : Specific : { Cooperative_Identity, Member_Identity }'
			
			if Cooperative.Select_Cooperative_OrganizationalStructure_Member() == []:

				if Cooperative.Insert_Cooperative_OrganizationalStructure_Member() == True:
					return { 'Output' : 'Insert Succeeded' }

				else:
					return { 'Output' : 'Insert Failed' }

			else:

				GLOBAL['REQUEST']['Update_Action'] = 'Update : Specific : [ Member_State ] : { Cooperative_Identity, Member_Identity }'

				if Cooperative.Update_Cooperative_OrganizationalStructure_Member() == True:
					return { 'Output' : 'Update Succeeded' }

				else:
					return { 'Output' : 'Update Failed' }

		elif GLOBAL['REQUEST']['Action'] == 'Cooperative_Manage':

			from ECIMS_User import User
			from ECIMS_Cooperative import Cooperative
			from ECIMS_Philippines import Philippines

			get_Output									=	{}

			GLOBAL['REQUEST']['Select_Action']			=	'Select : Specific : { { Cooperative_Identity, Member_State } }'
			GLOBAL['REQUEST']['Member_State']			=	'Pending'
			get_Output['Cooperative_Applicant']			=	str(User.Select_User())

			GLOBAL['REQUEST']['Member_State']			=	'Confirmed'
			get_Output['Cooperative_Member']			=	str(User.Select_User())

			return get_Output

		elif GLOBAL['REQUEST']['Action'] == 'Cooperator_Account':

			from ECIMS_User import User

			get_Output									=	{}

			GLOBAL['REQUEST']['Select_Action']			=	'Select : Specific'
			get_Output['User_Information']				=	str(User.Select_User())

			GLOBAL['REQUEST']['Select_Action']			=	'Select : All'
			get_Output['User_Gender']					=	str(User.Select_User_Personal_Gender())

			return get_Output

		elif GLOBAL['REQUEST']['Action'] == 'Update_Cooperative_OrganizationalStructure_Member':

			from ECIMS_Cooperative import Cooperative

			if Cooperative.Update_Cooperative_OrganizationalStructure_Member() == True:
				return { 'Output' : 'Update Succeeded' }

			else:
				return { 'Output' : 'Update Failed' }

		else:
			return { 'Output' : 'No Action' }

	except Exception as set_Exception:
		return { 'Output' : set_Exception }

Main.set_Flask(Main_HTTP_Method)