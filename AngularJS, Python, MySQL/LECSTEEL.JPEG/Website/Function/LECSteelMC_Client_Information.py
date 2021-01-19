#! "T:/Python 3.8.0/python.exe"

# Employee_Information #

from LECSteelMC_Main import *

class Client_Information:

	Table_Name_1 = 'tbl_client_information'

	def Select_Client_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity

		if set_Data['Action'] == 'Select : All':
			PyMySQL_Query = "SELECT * FROM " + Client_Information.Table_Name_1
		
		elif set_Data['Action'] == 'Select : Specific':			
			PyMySQL_Query = "SELECT * FROM " + Client_Information.Table_Name_1 + " WHERE Client_Identity = '" + set_Data['Client_Identity'] + "'"
		
		else:
			return 'No Action'
			
		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)		

		PyMySQL_Data = PyMySQL_Cursor.fetchall()


		if PyMySQL_Row_Count > 0:

			JSON_Output = []

			for set_PyMySQL_Data in PyMySQL_Data :

				get_PyMySQL_Data = collections.OrderedDict()

				get_PyMySQL_Data['Client_Identity']  				= set_PyMySQL_Data['Client_Identity']
				get_PyMySQL_Data['Client_FullName']  				= set_PyMySQL_Data['Client_FullName']
				get_PyMySQL_Data['Client_Position']  				= set_PyMySQL_Data['Client_Position']				
				get_PyMySQL_Data['Client_Address_List']  			= set_PyMySQL_Data['Client_Address_List']
				get_PyMySQL_Data['Client_Contact_LandlineNumber']  	= set_PyMySQL_Data['Client_Contact_LandlineNumber']
				get_PyMySQL_Data['Client_Contact_MobileNumber']  	= set_PyMySQL_Data['Client_Contact_MobileNumber']
				get_PyMySQL_Data['Client_Contact_EmailAddress']  	= set_PyMySQL_Data['Client_Contact_EmailAddress']
				get_PyMySQL_Data['Client_Contact_FaxNumber']  		= set_PyMySQL_Data['Client_Contact_FaxNumber']
				get_PyMySQL_Data['Client_Remark']  					= set_PyMySQL_Data['Client_Remark']
				get_PyMySQL_Data['Client_Status']  					= set_PyMySQL_Data['Client_Status']
				get_PyMySQL_Data['Client_Image_Path']				= set_PyMySQL_Data['Client_Image_Path']

				JSON_Output.append(get_PyMySQL_Data)

			return simplejson.dumps(JSON_Output)			

		else:
			return 'No Data'

	def Insert_Client_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor		

		get_Client_Count = str(Main.get_Counter_Information(Client_Code))
		if len(get_Client_Count) < 4:
			if len(get_Client_Count) == 1:
				get_Client_Count = '000' + str(get_Client_Count)

			elif len(get_Client_Count) == 2:
				get_Client_Count = '00' + str(get_Client_Count)

			elif len(get_Client_Count) == 3:
				get_Client_Count = '0' + str(get_Client_Count)

		get_Client_Identity = Client_Code + '-' + Branch_Identity + '-' + get_Client_Count
		
		if set_Data['Client_Image']	 != '':
			get_Client_Image_Path = Main.Image_Save(set_Data['Client_Image'], 'Client', get_Client_Identity)
		
		else:
			get_Client_Image_Path = ''

		Query_Column = '(	 Client_Identity, 						  Client_FullName, 						 Client_Position, 						Client_Address_List, 					   Client_Contact_LandlineNumber, 						Client_Contact_MobileNumber, 					   Client_Contact_EmailAddress, 					  Client_Contact_FaxNumber, 					  Client_Remark, 					   Client_Status,			      Client_Image_Path)'
		Query_Value = "('" + get_Client_Identity + "', '" + set_Data['Client_FullName'] + "', '" + set_Data['Client_Position'] + "', '" + set_Data['Client_Address_List'] + "', '" + set_Data['Client_Contact_LandlineNumber'] + "', '" + set_Data['Client_Contact_MobileNumber'] + "', '" + set_Data['Client_Contact_EmailAddress'] + "', '" + set_Data['Client_Contact_FaxNumber'] + "', '" + set_Data['Client_Remark'] + "', '" + set_Data['Client_Status'] + "', '" + get_Client_Image_Path + "')"


		PyMySQL_Query = "INSERT INTO " + Client_Information.Table_Name_1 + " " + Query_Column + " VALUES " + Query_Value + ""

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:
			Main.set_Counter_Information(Client_Code)			
				
			return 'Insert Succeeded'

		else:
			return 'Insert Failed'

	def Update_Client_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity	

		if set_Data['Client_Image'].filename != '':
			get_Client_Image_Path = Main.Image_Save(set_Data['Client_Image'], 'Client', set_Data['Client_Identity'])
			
		else:
			get_Client_Image_Path = ''


		get_String_1 = "Client_FullName = '" + set_Data['Client_FullName']  + "', Client_Position = '" + set_Data['Client_Position']  + "', Client_Address_List = '" + set_Data['Client_Address_List']  + "', "
		get_String_2 = "Client_Contact_LandlineNumber = '" + set_Data['Client_Contact_LandlineNumber']  + "', Client_Contact_MobileNumber = '" + set_Data['Client_Contact_MobileNumber']  + "', Client_Contact_EmailAddress = '" + set_Data['Client_Contact_EmailAddress']  + "', "
		get_String_3 = "Client_Contact_FaxNumber = '" + set_Data['Client_Contact_FaxNumber']  + "', Client_Remark = '" + set_Data['Client_Remark']  + "', Client_Status = '" + set_Data['Client_Status']  + "'"
			
		
		if get_Client_Image_Path != '':			
			get_String_3 += ", Client_Image_Path = '" + get_Client_Image_Path + "'"


		PyMySQL_Query = "UPDATE " + Client_Information.Table_Name_1 + " SET " + get_String_1 + get_String_2 + get_String_3 + " WHERE Client_Identity = '" + set_Data['Client_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Update Succeeded'

		else:

			if get_Client_Image_Path != '':

				return 'Update Succeeded'

			else:
				
				return 'Update Failed'

	def Delete_Client_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		PyMySQL_Query = "DELETE FROM " + Client_Information.Table_Name_1 + " WHERE Client_Identity = '" + set_Data['Client_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Delete Succeeded'

		else:
			return 'Delete Failed'



app = Flask(__name__)


@app.route('/Select_Client_Information', methods = ['POST'])
def Method_1():

	get_Data = request.data
	get_Data = json.loads(get_Data)

	return Client_Information.Select_Client_Information(get_Data)

@app.route('/Insert_Client_Information', methods = ['POST'])
def Method_2():	

	get_Data = request.form.to_dict()
	get_Data_File = request.files['Client_Image']
	get_Data.update( {'Client_Image' : get_Data_File} )
	
	return Client_Information.Insert_Client_Information(get_Data)


@app.route('/Update_Client_Information', methods = ['POST'])
def Method_3():

	get_Data = request.form.to_dict()
	get_Data_File = request.files['Client_Image']
	get_Data.update( {'Client_Image' : get_Data_File} )
	
	return Client_Information.Update_Client_Information(get_Data)

@app.route('/Delete_Client_Information', methods = ['POST'])
def Method_4():
	
	get_Data = request.data	
	get_Data = json.loads(get_Data)

	return Client_Information.Delete_Client_Information(get_Data)

if __name__ == '__main__':
	CGIHandler().run(app)