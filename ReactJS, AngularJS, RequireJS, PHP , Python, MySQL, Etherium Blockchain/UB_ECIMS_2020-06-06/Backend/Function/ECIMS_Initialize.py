#! "C:/Python38/python.exe"

from ECIMS_Cooperative import *
from ECIMS_Philippines import *
from ECIMS_User import *
from ECIMS_Blockchain import *

#GLOBAL['REQUEST']['Select_Action'] = 'Select : All'

#print(Philippines.Select_Philippines_Region())
#print(Philippines.Select_Philippines_Region_Province())
#print(Philippines.Select_Philippines_Region_Province_Locality())

#GLOBAL['REQUEST']['Select_Action'] = 'Select : Specific : { Member_Identity { Member_State = Pending | Member_State = Declined } }'
#GLOBAL['REQUEST']['Member_Identity'] = 'USR-1'
#GLOBAL['REQUEST']['Member_State_1'] = 'Pending'
#GLOBAL['REQUEST']['Member_State_2'] = 'Declined'
#print(str(Cooperative.Select_Cooperative()))

def set_Initialize():
	#Programming
	#GLOBAL['REQUEST']['Action'] = 'Delete : All'
	Initialize.Initialize_Cooperative()
	#Initialize.Initialize_Cooperative_Category()
	#Initialize.Initialize_Cooperative_Type()
	#Initialize.Initialize_Philippines()
	#Initialize.Initialize_User()
	#Initialize.Initialize_User_Gender()
	#Initialize.Initialize_Cooperative_OperationArea()
	#Initialize.Initialize_Cooperative_CommonBond()

	#Initialize.Initialize_Philippines_Organization()

	#Initialize.Initialize_Cooperative_Capitalization()

	print('Success')

class Initialize:

	def Initialize_Cooperative_Capitalization():

		Cooperative.Delete_Cooperative_Capitalization()
		Main.reset_Counter(GLOBAL['Cooperative_Capitalization_Counter_Code'])
		get_Capitalization_Description	=	[
												'Share Capital Subscription',
												'Deferred payment of patronage refund/interest on share capital (Revolving Capital)',
												'Acquisition of Loans/borrowings',
												'Solicitation/acceptance of donations, subsidies, grants, etc.',
												'Fund raising activities'
											]

		for set_Data in get_Capitalization_Description:

			GLOBAL['REQUEST']['Capitalization_Identity'] = 'COOP-CPTLZTN-' + str(Main.Select_Counter(GLOBAL['Cooperative_Capitalization_Counter_Code']))
			GLOBAL['REQUEST']['Capitalization_Name'] = GLOBAL['REQUEST']['Capitalization_Identity']
			GLOBAL['REQUEST']['Capitalization_Description'] = set_Data

			if Cooperative.Insert_Cooperative_Capitalization() == True:
				Main.Update_Counter(GLOBAL['Cooperative_Capitalization_Counter_Code'])



	def Initialize_Philippines_Organization():

		Philippines.Delete_Philippines_Organization()
		Main.reset_Counter(GLOBAL['Philippines_Organization_Counter_Code'])
		get_Philippines_Organization_Data = [
												{
													'Organization_Name' : 'Department of Labor and Employment',
													'Organization_Abbreviation' : 'DOLE'
												},

												{
													'Organization_Name' : 'Department of Tourism',
													'Organization_Abbreviation' : 'DOT'
												},

												{
													'Organization_Name' : 'Department of Trade and Industry',
													'Organization_Abbreviation' : 'DTI'
												},

												{
													'Organization_Name' : 'Department of Budget and Management',
													'Organization_Abbreviation' : 'DBM'
												},

												{
													'Organization_Name' : 'Department of Foreign Affairs',
													'Organization_Abbreviation' : 'DFA'
												},

												{
													'Organization_Name' : 'National Anti-Poverty Commission',
													'Organization_Abbreviation' : 'NAPC'
												},
											]
		for set_Data in get_Philippines_Organization_Data:

			GLOBAL['REQUEST']['Organization_Identity'] = 'PH-ORG-' + str(Main.Select_Counter(GLOBAL['Philippines_Organization_Counter_Code']))
			GLOBAL['REQUEST']['Organization_Name'] = set_Data['Organization_Name']
			GLOBAL['REQUEST']['Organization_Abbreviation'] = set_Data['Organization_Abbreviation']
			GLOBAL['REQUEST']['Organization_Description'] = set_Data['Organization_Name']

			if Philippines.Insert_Philippines_Organization() == True:
				Main.Update_Counter(GLOBAL['Philippines_Organization_Counter_Code'])

	def Initialize_Cooperative_OperationArea():

		Cooperative.Delete_Cooperative_OperationArea()
		Main.reset_Counter(GLOBAL['Cooperative_OperationArea_Counter_Code'])
		get_OperationArea_Name = ['Barangay', 'Municipal/City', 'Provincial', 'Regional', 'National']

		for set_Data in get_OperationArea_Name:
		
			GLOBAL['REQUEST']['OperationArea_Identity'] = 'COOP-OA-' + str(Main.Select_Counter(GLOBAL['Cooperative_OperationArea_Counter_Code']))
			GLOBAL['REQUEST']['OperationArea_Name'] = set_Data
			GLOBAL['REQUEST']['OperationArea_Description'] = set_Data

			if Cooperative.Insert_Cooperative_OperationArea() == True:
				Main.Update_Counter(GLOBAL['Cooperative_OperationArea_Counter_Code'])

	def Initialize_Cooperative_CommonBond():

		Cooperative.Delete_Cooperative_CommonBond()
		Main.reset_Counter(GLOBAL['Cooperative_CommonBond_Counter_Code'])
		get_CommonBond_Name = ['Residential', 'Institutional', 'Occupational', 'Associational']

		for set_Data in get_CommonBond_Name:
		
			GLOBAL['REQUEST']['CommonBond_Identity'] = 'COOP-CB-' + str(Main.Select_Counter(GLOBAL['Cooperative_CommonBond_Counter_Code']))
			GLOBAL['REQUEST']['CommonBond_Name'] = set_Data
			GLOBAL['REQUEST']['CommonBond_Description'] = set_Data

			if Cooperative.Insert_Cooperative_CommonBond() == True:
				Main.Update_Counter(GLOBAL['Cooperative_CommonBond_Counter_Code'])

	def Initialize_User_Gender():
		User.Delete_User_Personal_Gender()
		Main.reset_Counter(GLOBAL['User_Gender_Counter_Code'])

		get_Gender_Data = ['Male', 'Female']

		for set_Data in get_Gender_Data:
			GLOBAL['REQUEST']['Gender_Identity'] = 'USR-GNDR-' + str(Main.Select_Counter(GLOBAL['User_Gender_Counter_Code']))
			GLOBAL['REQUEST']['Gender_Name'] = set_Data
			GLOBAL['REQUEST']['Gender_Description'] = set_Data

			if User.Insert_User_Personal_Gender() == True:
				Main.Update_Counter(GLOBAL['User_Gender_Counter_Code'])

	def Initialize_User():
		User.Delete_User()
		Main.reset_Counter(GLOBAL['User_Counter_Code'])
		Main.reset_Counter(GLOBAL['User_Confirmation_Counter_Code'])
		get_Etherium = Blockchain.get_Admin_Account()

		Query_Insert = f"""
							INSERT INTO User_Credential
							(
								User_Identity,
								User_Name,
								User_Password,
								User_Type,
								User_Privilege,
								User_State,
								User_Ethereum_Address,
								User_Ethereum_Key,
								User_Inserted_By,
								User_Inserted_DateTime
							)
							VALUES
							(
								'USR-Admin',
								'admin',
								'admin',
								'Admin',
								'["Admin"]',
								'Confirmed',
								'{ get_Etherium['Address'] }',
								'{ get_Etherium['Private_Key'] }',
								'USR-Admin',
								'{ str(datetime.now()) }'
							);

							INSERT INTO User_Personal
							(
								User_Identity,
								User_Firstname,
								User_Middlename,
								User_Lastname
							)
							VALUES
							(
								'USR-Admin',
								'Rafael',
								'Nobleza',
								'Masallo'
							);

							INSERT INTO User_Personal_Employment (User_Identity) VALUES ('USR-Admin')
						"""

		GLOBAL['PyMySQL_Cursor'].execute(Query_Insert)
		GLOBAL['PyMySQL_Connection'].commit()

	def Initialize_Cooperative():
		GLOBAL['REQUEST']['Action'] = 'Delete : All'
		Cooperative.Delete_Cooperative()
		Main.reset_Counter(GLOBAL['Cooperative_Counter_Code'])

	def Initialize_Cooperative_Category():

		Cooperative.Delete_Cooperative_Category()
		Main.reset_Counter(GLOBAL['Cooperative_Category_Counter_Code'])
		get_Cooperative_Category_Name = ['Primary', 'Secondary', 'Tertiary']

		for set_Data in get_Cooperative_Category_Name:
		
			GLOBAL['REQUEST']['Category_Identity'] = 'COOP-CAT-' + str(Main.Select_Counter(GLOBAL['Cooperative_Category_Counter_Code']))
			GLOBAL['REQUEST']['Category_Name'] = set_Data
			GLOBAL['REQUEST']['Category_Description'] = set_Data

			if Cooperative.Insert_Cooperative_Category() == True:
				Main.Update_Counter(GLOBAL['Cooperative_Category_Counter_Code'])

	def Initialize_Cooperative_Type():

		Cooperative.Delete_Cooperative_Type()
		Main.reset_Counter(GLOBAL['Cooperative_Type_Counter_Code'])
		get_Cooperative_Type_Name	=	[
											'Advocacy', 'Agrarian Reform', 'Agriculture', 'Consumers',
											'Cooperative Bank', 'Credit', 'Credit Surety Fund', 'Dairy',
											'Education', 'Electric', 'Federation', 'Financial Service',
											'Fishermen', 'Health Service', 'Housing', 'Insurance',
											'Labor Service', 'Marketing', 'Producers', 'Professional',
											'Service', 'Small Scale Mining', 'Transport', 'Union',
											'Water Service', 'Workers'
										]

		for set_Data in get_Cooperative_Type_Name:

			GLOBAL['REQUEST']['Type_Identity'] = 'COOP-TYP-' + str(Main.Select_Counter(GLOBAL['Cooperative_Type_Counter_Code']))
			GLOBAL['REQUEST']['Type_Name'] = set_Data
			GLOBAL['REQUEST']['Type_Description'] = set_Data

			if Cooperative.Insert_Cooperative_Type() == True:
				Main.Update_Counter(GLOBAL['Cooperative_Type_Counter_Code'])

	def Initialize_Philippines():

		Philippines.Delete_Philippines_Region()
		Philippines.Delete_Philippines_Region_Province()
		Philippines.Delete_Philippines_Region_Province_Locality()
		Main.reset_Counter(GLOBAL['Philippines_Region_Counter_Code'])
		Main.reset_Counter(GLOBAL['Philippines_Region_Province_Counter_Code'])
		Main.reset_Counter(GLOBAL['Philippines_Region_Province_Locality_Counter_Code'])

		for set_Data in Philippines_Data:

			GLOBAL['REQUEST']['Region_Identity'] = 'PH-RGN-' + str(Main.Select_Counter(GLOBAL['Philippines_Region_Counter_Code']))
			GLOBAL['REQUEST']['Region_Name'] = set_Data['Region_Name']

			if Philippines.Insert_Philippines_Region() == True:
				Main.Update_Counter(GLOBAL['Philippines_Region_Counter_Code'])

			if 'Region_Province' in set_Data:

				for set_Province in set_Data['Region_Province']:
					get_Province_Name = set_Province['Province_Name']

					GLOBAL['REQUEST']['Province_Identity'] = 'PH-RGN-PROV-' + str(Main.Select_Counter(GLOBAL['Philippines_Region_Province_Counter_Code']))
					GLOBAL['REQUEST']['Province_Name'] = set_Province['Province_Name']

					if Philippines.Insert_Philippines_Region_Province() == True:
						Main.Update_Counter(GLOBAL['Philippines_Region_Province_Counter_Code'])

					for set_Locality in set_Province['Province_Locality']:

						GLOBAL['REQUEST']['Locality_Identity'] = 'PH-RGN-PROV-LOC-' + str(Main.Select_Counter(GLOBAL['Philippines_Region_Province_Locality_Counter_Code']))
						GLOBAL['REQUEST']['Locality_Name'] = set_Locality['Locality_Name']

						if Philippines.Insert_Philippines_Region_Province_Locality() == True:
							Main.Update_Counter(GLOBAL['Philippines_Region_Province_Locality_Counter_Code'])

			elif 'Region_Locality' in set_Data:

				for set_Locality in set_Data['Region_Locality']:
					GLOBAL['REQUEST']['Locality_Identity'] = 'PH-RGN-PROV-LOC-' + str(Main.Select_Counter(GLOBAL['Philippines_Region_Province_Locality_Counter_Code']))
					GLOBAL['REQUEST']['Locality_Name'] = set_Locality['Locality_Name']
					GLOBAL['REQUEST']['Province_Identity'] = ''

					if Philippines.Insert_Philippines_Region_Province_Locality() == True:
						Main.Update_Counter(GLOBAL['Philippines_Region_Province_Locality_Counter_Code'])

			else:
				print('------Invalid------')

			print('_________________________')
			print('_________________________')
			print('_________________________')
			print('_________________________')


#As of June 30, 2019

Philippines_Data	=	[
							{
								'Region_Name' :	'National Capital Region (NCR)',
								'Region_Locality' :
								[
									{ 'Locality_Name' : 'Manila' },
									{ 'Locality_Name' : 'Mandaluyong' },
									{ 'Locality_Name' : 'Marikina' },
									{ 'Locality_Name' : 'Pasig' },
									{ 'Locality_Name' : 'Quezon City' },
									{ 'Locality_Name' : 'San Juan' },
									{ 'Locality_Name' : 'Caloocan' },
									{ 'Locality_Name' : 'Malabon' },
									{ 'Locality_Name' : 'Navotas' },
									{ 'Locality_Name' : 'Valenzuela' },
									{ 'Locality_Name' : 'Las Piñas' },
									{ 'Locality_Name' : 'Makati' },
									{ 'Locality_Name' : 'Muntinlupa' },
									{ 'Locality_Name' : 'Parañaque' },
									{ 'Locality_Name' : 'Pasay' },
									{ 'Locality_Name' : 'Pateros' },
									{ 'Locality_Name' : 'Taguig' }
								]
							},

							{
								'Region_Name' : 'Ilocos Region (Region I)',
								'Region_Province' :
								[
									{ 
										'Province_Name' : 'Ilocos Norte',
										'Province_Locality' :
										[
											{ 'Locality_Name' : 'Adams' },
											{ 'Locality_Name' : 'Bacarra' },
											{ 'Locality_Name' : 'Badoc' },
											{ 'Locality_Name' : 'Bangui' },
											{ 'Locality_Name' : 'Banna' },
											{ 'Locality_Name' : 'Batac' },
											{ 'Locality_Name' : 'Burgos' },
											{ 'Locality_Name' : 'Carasi' },
											{ 'Locality_Name' : 'Currimao' },
											{ 'Locality_Name' : 'Dingras' },
											{ 'Locality_Name' : 'Dumalneg' },
											{ 'Locality_Name' : 'Laoag' },
											{ 'Locality_Name' : 'Marcos' },
											{ 'Locality_Name' : 'Nueva Era' },
											{ 'Locality_Name' : 'Pagudpud' },
											{ 'Locality_Name' : 'Paoay' },
											{ 'Locality_Name' : 'Pasuquin' },
											{ 'Locality_Name' : 'Piddig' },
											{ 'Locality_Name' : 'Pinili' },
											{ 'Locality_Name' : 'San Nicolas' },
											{ 'Locality_Name' : 'Sarrat' },
											{ 'Locality_Name' : 'Solsona' },
											{ 'Locality_Name' : 'Vintar' }
										]
									},

									{ 
										'Province_Name' : 'Ilocos Sur',
										'Province_Locality' :
										[
											{ 'Locality_Name' : 'Alilem' },
											{ 'Locality_Name' : 'Banayoyo' },
											{ 'Locality_Name' : 'Bantay' },
											{ 'Locality_Name' : 'Burgos' },
											{ 'Locality_Name' : 'Cabugao' },
											{ 'Locality_Name' : 'Candon' },
											{ 'Locality_Name' : 'Caoayan' },
											{ 'Locality_Name' : 'Cervantes' },
											{ 'Locality_Name' : 'Galimuyod' },
											{ 'Locality_Name' : 'Gregorio del Pilar' },
											{ 'Locality_Name' : 'Lidlida' },
											{ 'Locality_Name' : 'Magsingal' },
											{ 'Locality_Name' : 'Nagbukel' },
											{ 'Locality_Name' : 'Narvacan' },
											{ 'Locality_Name' : 'Quirino' },
											{ 'Locality_Name' : 'Salcedo' },
											{ 'Locality_Name' : 'San Emilio' },
											{ 'Locality_Name' : 'San Esteban' },
											{ 'Locality_Name' : 'San Ildefonso' },
											{ 'Locality_Name' : 'San Juan' },
											{ 'Locality_Name' : 'San Vicente' },
											{ 'Locality_Name' : 'Santa' },
											{ 'Locality_Name' : 'Santa Catalina' },
											{ 'Locality_Name' : 'Santa Cruz' },
											{ 'Locality_Name' : 'Santa Lucia' },
											{ 'Locality_Name' : 'Santa Maria' },
											{ 'Locality_Name' : 'Santiago' },
											{ 'Locality_Name' : 'Santo Domingo' },
											{ 'Locality_Name' : 'Sicay' },
											{ 'Locality_Name' : 'Sinait' },
											{ 'Locality_Name' : 'Sugpon' },
											{ 'Locality_Name' : 'Suyo' },
											{ 'Locality_Name' : 'Tagudin' },
											{ 'Locality_Name' : 'Vigan' }
										]
									},

									{ 
										'Province_Name' : 'La Union',
										'Province_Locality' :
										[
											{ 'Locality_Name' : 'Agoo' },
											{ 'Locality_Name' : 'Aringay' },
											{ 'Locality_Name' : 'Bacnotan' },
											{ 'Locality_Name' : 'Bagulin' },
											{ 'Locality_Name' : 'Balaoan' },
											{ 'Locality_Name' : 'Bangar' },
											{ 'Locality_Name' : 'Bauang' },
											{ 'Locality_Name' : 'Burgos' },
											{ 'Locality_Name' : 'Caba' },
											{ 'Locality_Name' : 'Damortis' },
											{ 'Locality_Name' : 'Luna' },
											{ 'Locality_Name' : 'Naguilian' },
											{ 'Locality_Name' : 'Pugo' },
											{ 'Locality_Name' : 'Rosario' },
											{ 'Locality_Name' : 'San Fernando' },
											{ 'Locality_Name' : 'San Gabriel' },
											{ 'Locality_Name' : 'San Juan' },
											{ 'Locality_Name' : 'Santol' },
											{ 'Locality_Name' : 'Sto. Tomas' },
											{ 'Locality_Name' : 'Sudipen' },
											{ 'Locality_Name' : 'Tubao' }
										]
									},

									{ 
										'Province_Name' : 'Pangasinan',
										'Province_Locality' :
										[
											{ 'Locality_Name' : 'Agno' },
											{ 'Locality_Name' : 'aguilar' },
											{ 'Locality_Name' : 'Alaminos' },
											{ 'Locality_Name' : 'Alcala' },
											{ 'Locality_Name' : 'Anda' },
											{ 'Locality_Name' : 'Asingan' },
											{ 'Locality_Name' : 'Balungao' },
											{ 'Locality_Name' : 'Bani' },
											{ 'Locality_Name' : 'Basista' },
											{ 'Locality_Name' : 'Bautista' },
											{ 'Locality_Name' : 'Bayambang' },
											{ 'Locality_Name' : 'Binalonan' },
											{ 'Locality_Name' : 'Binmaley' },
											{ 'Locality_Name' : 'Bolinao' },
											{ 'Locality_Name' : 'Bugallon' },
											{ 'Locality_Name' : 'Burgos' },
											{ 'Locality_Name' : 'Calasiao' },
											{ 'Locality_Name' : 'Dagupan City' },
											{ 'Locality_Name' : 'Dasol' },
											{ 'Locality_Name' : 'Infanta' },
											{ 'Locality_Name' : 'Labrador' },
											{ 'Locality_Name' : 'Laoac' },
											{ 'Locality_Name' : 'Lingayen' },
											{ 'Locality_Name' : 'Mabini' },
											{ 'Locality_Name' : 'Malasiqui' },
											{ 'Locality_Name' : 'Manaoag' },
											{ 'Locality_Name' : 'mangaldan' },
											{ 'Locality_Name' : 'Mangatarem' },
											{ 'Locality_Name' : 'Mapandan' },
											{ 'Locality_Name' : 'Natividad' },
											{ 'Locality_Name' : 'Pozorrubio' },
											{ 'Locality_Name' : 'Rosales' },
											{ 'Locality_Name' : 'San Carlos City' },
											{ 'Locality_Name' : 'San Fabian' },
											{ 'Locality_Name' : 'San Jacinto' },
											{ 'Locality_Name' : 'San Manuel' },
											{ 'Locality_Name' : 'San Nicolas' },
											{ 'Locality_Name' : 'San Quintin' },
											{ 'Locality_Name' : 'Sison' },
											{ 'Locality_Name' : 'Sta. Barbara' },
											{ 'Locality_Name' : 'Sta. Maria' },
											{ 'Locality_Name' : 'Sto. Tomas' },
											{ 'Locality_Name' : 'Sual' },
											{ 'Locality_Name' : 'Tayug' },
											{ 'Locality_Name' : 'Umingan' },
											{ 'Locality_Name' : 'Urbiztondo' },
											{ 'Locality_Name' : 'Urdaneta' },
											{ 'Locality_Name' : 'Villasis' }
										]
									}
								]
							}#,

							#{
							#	'Region_Name' : 'Test',
							#	'Region_Province' :
							#	[
							#		{ 
							#			'Province_Name' : '',
							#			'Province_Locality' :
							#			[
							#				{
							#					'Locality_Name' : ''
							#				}
							#			]
							#		}
							#	]
							#}
						]

set_Initialize()

"""
							INSERT INTO Cooperative
							(
								Cooperative_Identity,
								Cooperative_Name,
								Cooperative_Type,
								Cooperative_Category,
								Cooperative_Region,
								Cooperative_Province,
								Cooperative_Locality,
								Cooperative_Office_Address,
								Cooperative_State,
								Cooperative_Inserted_By,
								Cooperative_Inserted_DateTime
							)
							VALUES
							(
								'{ GLOBAL['REQUEST']['Cooperative_Identity'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Name'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Type'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Category'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Region'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Province'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Locality'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Office_Address'] }',
								'{ GLOBAL['REQUEST']['Cooperative_State'] }',
								'{ GLOBAL['REQUEST']['User_Identity'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Inserted_DateTime'] }'

							);
							INSERT INTO Cooperative_ShareCapital							(Cooperative_Identity) VALUES ('{ GLOBAL['REQUEST']['Cooperative_Identity'] }');
							INSERT INTO Cooperative_EconomicAspect							(Cooperative_Identity) VALUES ('{ GLOBAL['REQUEST']['Cooperative_Identity'] }');
							INSERT INTO Cooperative_FinancialAspect							(Cooperative_Identity) VALUES ('{ GLOBAL['REQUEST']['Cooperative_Identity'] }');
							INSERT INTO Cooperative_TechnicalAspect							(Cooperative_Identity) VALUES ('{ GLOBAL['REQUEST']['Cooperative_Identity'] }');
							INSERT INTO Cooperative_OrganizationalStructure					(Cooperative_Identity) VALUES ('{ GLOBAL['REQUEST']['Cooperative_Identity'] }');
						"""