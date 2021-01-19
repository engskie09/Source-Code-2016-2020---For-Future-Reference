#! "T:/Python 3.8.0/python.exe"

# Employee_Information #

from LECSteelMC_Main import *

class Supplier_Information:

	Table_Name_1 = 'tbl_Supplier_information'
	Table_Name_2 = 'tbl_Supplier_category_information'

	def Select_Supplier_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor
		
		if set_Data['Action'] == 'Select : All':
			PyMySQL_Query = "SELECT * FROM " + Supplier_Information.Table_Name_1
		
		elif set_Data['Action'] == 'Select : Specific':			
			PyMySQL_Query = "SELECT * FROM " + Supplier_Information.Table_Name_1 + " WHERE Supplier_Identity = '" + set_Data['Supplier_Identity'] + "'"
			
		elif set_Data['Action'] == 'Select : Specific : Supplier_Code { Supplier_Code }':
			PyMySQL_Query = "SELECT * FROM " + Supplier_Information.Table_Name_1 + " WHERE Supplier_Code = '" + set_Data['Supplier_Code'] + "'"
		
		elif set_Data['Action'] == 'Select : Specific : { Supplier_Identity, Supplier_Code, Supplier_Name }':
			PyMySQL_Query = "SELECT Supplier_Identity, Supplier_Code, Supplier_Name FROM " + Supplier_Information.Table_Name_1 + ""

		elif set_Data['Action'] == 'Select : Specific : { Supplier_Term }':
			PyMySQL_Query = "SELECT Supplier_Term FROM " + Supplier_Information.Table_Name_1 + " WHERE Supplier_Identity = '" + set_Data['Supplier_Identity'] + "'"

		else:
			return 'No Action'
			
		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)		

		PyMySQL_Data = PyMySQL_Cursor.fetchall()


		if PyMySQL_Row_Count > 0:

			JSON_Output = []

			for set_PyMySQL_Data in PyMySQL_Data :

				get_PyMySQL_Data = collections.OrderedDict()
				
				if set_Data['Action'] == 'Select : Specific : { Supplier_Identity, Supplier_Code, Supplier_Name }':

					get_PyMySQL_Data['Supplier_Identity']	= set_PyMySQL_Data['Supplier_Identity']
					get_PyMySQL_Data['Supplier_Code']		= set_PyMySQL_Data['Supplier_Code']
					get_PyMySQL_Data['Supplier_Name']		= set_PyMySQL_Data['Supplier_Name']

				elif set_Data['Action'] == 'Select : Specific : { Supplier_Term }':
					get_PyMySQL_Data['Supplier_Term'] = set_PyMySQL_Data['Supplier_Term']

				else:
					get_PyMySQL_Data['Supplier_Identity']  					= set_PyMySQL_Data['Supplier_Identity']
					get_PyMySQL_Data['Supplier_Code']						= set_PyMySQL_Data['Supplier_Code']
					get_PyMySQL_Data['Supplier_Category_Identity_List']		= set_PyMySQL_Data['Supplier_Category_Identity_List']
					get_PyMySQL_Data['Supplier_Name']						= set_PyMySQL_Data['Supplier_Name']				
					get_PyMySQL_Data['Supplier_Contact_FullName']  			= set_PyMySQL_Data['Supplier_Contact_FullName']
					get_PyMySQL_Data['Supplier_Contact_LandlineNumber']  	= set_PyMySQL_Data['Supplier_Contact_LandlineNumber']
					get_PyMySQL_Data['Supplier_Contact_MobileNumber']  		= set_PyMySQL_Data['Supplier_Contact_MobileNumber']
					get_PyMySQL_Data['Supplier_Contact_EmailAddress']  		= set_PyMySQL_Data['Supplier_Contact_EmailAddress']
					get_PyMySQL_Data['Supplier_Contact_FaxNumber']  		= set_PyMySQL_Data['Supplier_Contact_FaxNumber']
					get_PyMySQL_Data['Supplier_Contact_BusinessAddress']  	= set_PyMySQL_Data['Supplier_Contact_BusinessAddress']
					get_PyMySQL_Data['Supplier_Term']  						= set_PyMySQL_Data['Supplier_Term']
					get_PyMySQL_Data['Supplier_Status']						= set_PyMySQL_Data['Supplier_Status']
					get_PyMySQL_Data['Supplier_Image_Path']					= set_PyMySQL_Data['Supplier_Image_Path']

				JSON_Output.append(get_PyMySQL_Data)

			return simplejson.dumps(JSON_Output)			

		else:
			return 'No Data'

	def Insert_Supplier_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		get_Supplier_Count = str(Main.get_Counter_Information(Supplier_Code))
		if len(get_Supplier_Count) < 4:
			if len(get_Supplier_Count) == 1:
				get_Supplier_Count = '000' + str(get_Supplier_Count)

			elif len(get_Supplier_Count) == 2:
				get_Supplier_Count = '00' + str(get_Supplier_Count)

			elif len(get_Supplier_Count) == 3:
				get_Supplier_Count = '0' + str(get_Supplier_Count)

		get_Supplier_Identity = Supplier_Code + '-' + Branch_Identity + '-' + get_Supplier_Count
		
		if set_Data['Supplier_Image'].filename != '':
			get_Supplier_Image_Path = Main.Image_Save(set_Data['Supplier_Image'], 'Supplier', get_Supplier_Identity)
		
		else:
			get_Supplier_Image_Path = ''

		Query_Column = '(	     Supplier_Identity, 					Supplier_Category_Identity_List, 					   Supplier_Code, 							Supplier_Name, 					   	 Supplier_Contact_FullName, 					    Supplier_Contact_LandlineNumber, 					   Supplier_Contact_MobileNumber, 					    Supplier_Contact_EmailAddress, 					  	 Supplier_Contact_FaxNumber, 					   Supplier_Contact_BusinessAddress, 					   Supplier_Term,						Supplier_Status,			     Supplier_Image_Path)'
		Query_Value = "('" + get_Supplier_Identity + "', '" + set_Data['Supplier_Category_Identity_List'] + "', '" + set_Data['Supplier_Code'] + "', '" + set_Data['Supplier_Name'] + "', '" + set_Data['Supplier_Contact_FullName'] + "', '" + set_Data['Supplier_Contact_LandlineNumber'] + "', '" + set_Data['Supplier_Contact_MobileNumber'] + "', '" + set_Data['Supplier_Contact_EmailAddress'] + "', '" + set_Data['Supplier_Contact_FaxNumber'] + "', '" + set_Data['Supplier_Contact_BusinessAddress'] + "', '" + set_Data['Supplier_Term'] + "', '" + set_Data['Supplier_Status'] + "', '" + get_Supplier_Image_Path + "')"


		PyMySQL_Query = "INSERT INTO " + Supplier_Information.Table_Name_1 + " " + Query_Column + " VALUES " + Query_Value + ""


		try:

			PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)
			PyMySQL_Connection.commit()

		except Exception as set_Exception:
			
			return str(set_Exception)
				

		if PyMySQL_Row_Count > 0:
			Main.set_Counter_Information(Supplier_Code)			
				
			return 'Insert Succeeded'

		else:
			return 'Insert Failed'

	def Update_Supplier_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity	

		if set_Data['Supplier_Image'].filename != '':
			get_Supplier_Image_Path = Main.Image_Save(set_Data['Supplier_Image'], 'Supplier', set_Data['Supplier_Identity'])
			
		else:
			get_Supplier_Image_Path = ''


		get_String_1 = "Supplier_Identity = '" + set_Data['Supplier_Identity']  + "', Supplier_Code = '" + set_Data['Supplier_Code'] + "', Supplier_Category_Identity_List = '" + set_Data['Supplier_Category_Identity_List']  + "', Supplier_Name = '" + set_Data['Supplier_Name']  + "', "
		get_String_2 = "Supplier_Contact_FullName = '" + set_Data['Supplier_Contact_FullName']  + "', Supplier_Contact_LandlineNumber = '" + set_Data['Supplier_Contact_LandlineNumber']  + "', Supplier_Contact_MobileNumber = '" + set_Data['Supplier_Contact_MobileNumber']  + "', "
		get_String_3 = "Supplier_Contact_EmailAddress = '" + set_Data['Supplier_Contact_EmailAddress']  + "', Supplier_Contact_FaxNumber = '" + set_Data['Supplier_Contact_FaxNumber']  + "', Supplier_Contact_BusinessAddress = '" + set_Data['Supplier_Contact_BusinessAddress']  + "', "
		get_String_4 = "Supplier_Term = '" + set_Data['Supplier_Term']  + "', Supplier_Status = '" + set_Data['Supplier_Status']  + "'"
			
		
		if get_Supplier_Image_Path != '':			
			get_String_4 += ", Supplier_Image_Path = '" + get_Supplier_Image_Path + "'"


		PyMySQL_Query = "UPDATE " + Supplier_Information.Table_Name_1 + " SET " + get_String_1 + get_String_2 + get_String_3 + get_String_4 + " WHERE Supplier_Identity = '" + set_Data['Supplier_Identity'] + "'"

		try:			
			PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)
			PyMySQL_Connection.commit()

		except Exception as set_Exception:			
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:

			return 'Update Succeeded'

		else:

			if get_Supplier_Image_Path != '':

				return 'Update Succeeded'

			else:
				
				return 'Update Failed'

	def Delete_Supplier_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		PyMySQL_Query = "DELETE FROM " + Supplier_Information.Table_Name_1 + " WHERE Supplier_Identity = '" + set_Data['Supplier_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Delete Succeeded'

		else:
			return 'Delete Failed'

	def Select_Supplier_Category_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity

		if set_Data['Action'] == 'Select : All':
			PyMySQL_Query = "SELECT * FROM " + Supplier_Information.Table_Name_2 + ""
		
		elif set_Data['Action'] == 'Select : Specific':			
			PyMySQL_Query = "SELECT * FROM " + Supplier_Information.Table_Name_2 + " WHERE Category_Identity = '" + set_Data['Category_Identity'] + "'"
		
		else:
			return 'No Action'

		try:
			PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		except Exception as set_Exception:
			
			return str(set_Exception)

		PyMySQL_Data = PyMySQL_Cursor.fetchall()

		if PyMySQL_Row_Count > 0:

			JSON_Output = []

			for set_PyMySQL_Data in PyMySQL_Data :

				get_PyMySQL_Data = collections.OrderedDict()

				get_PyMySQL_Data['Category_Identity'] = set_PyMySQL_Data['Category_Identity']
				get_PyMySQL_Data['Category_Name'] = set_PyMySQL_Data['Category_Name']
				get_PyMySQL_Data['Category_Description'] = set_PyMySQL_Data['Category_Description']

				JSON_Output.append(get_PyMySQL_Data)

			return simplejson.dumps(JSON_Output)

		else:

			return 'No Data'
			
	def Insert_Supplier_Category_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		get_Category_Count = str(Main.get_Counter_Information(Supplier_Category_Code))


		if len(get_Category_Count) < 4:
			if len(get_Category_Count) == 1:
				get_Category_Count = '000' + str(get_Category_Count)

			elif len(get_Category_Count) == 2:
				get_Category_Count = '00' + str(get_Category_Count)

			elif len(get_Category_Count) == 3:
				get_Category_Count = '0' + str(get_Category_Count)

		
		get_Category_Identity = Supplier_Category_Code + '-' + Branch_Identity + '-' + get_Category_Count

		Query_Column = '(Category_Identity, Category_Name, Category_Description)'
		Query_Value = "('" + get_Category_Identity + "', '" + set_Data['Category_Name'] + "', '" + set_Data['Category_Description'] + "')"

		

		PyMySQL_Query = "INSERT INTO " + Supplier_Information.Table_Name_2 + " " + Query_Column + " VALUES " + Query_Value + ""	

		try:
			PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)
			PyMySQL_Connection.commit()

		except Exception as set_Exception:
			
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			Main.set_Counter_Information(Supplier_Category_Code)
				
			return 'Insert Succeeded'

		else:
			return 'Insert Failed'

	def Update_Supplier_Category_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		PyMySQL_Query = "UPDATE " + Supplier_Information.Table_Name_2 + " SET Category_Name = '" + set_Data['Category_Name'] + "', Category_Description = '" + set_Data['Category_Description'] + "'  WHERE Category_Identity = '" + set_Data['Category_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Update Succeeded'

		else:
			return 'Update Failed'

	def Delete_Supplier_Category_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		PyMySQL_Query = "DELETE FROM " + Supplier_Information.Table_Name_2 + " WHERE Category_Identity = '" + set_Data['Category_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Delete Succeeded'

		else:
			return 'Delete Failed'



app = Flask(__name__)


@app.route('/Select_Supplier_Information', methods = ['POST'])
def Method_1():

	get_Data = request.data
	get_Data = json.loads(get_Data)

	return Supplier_Information.Select_Supplier_Information(get_Data)

@app.route('/Insert_Supplier_Information', methods = ['POST'])
def Method_2():	

	get_Data = request.form.to_dict()
	get_Data_File = request.files['Supplier_Image']
	get_Data.update( {'Supplier_Image' : get_Data_File} )
	
	return Supplier_Information.Insert_Supplier_Information(get_Data)


@app.route('/Update_Supplier_Information', methods = ['POST'])
def Method_3():

	get_Data = request.form.to_dict()
	get_Data_File = request.files['Supplier_Image']
	get_Data.update( {'Supplier_Image' : get_Data_File} )
	
	return Supplier_Information.Update_Supplier_Information(get_Data)

@app.route('/Delete_Supplier_Information', methods = ['POST'])
def Method_4():
	
	get_Data = request.data	
	get_Data = json.loads(get_Data)

	return Supplier_Information.Delete_Supplier_Information(get_Data)

@app.route('/Select_Supplier_Category_Information', methods = ['POST'])
def Method_5():

	get_Data = request.data
	get_Data = json.loads(get_Data)

	return Supplier_Information.Select_Supplier_Category_Information(get_Data)

@app.route('/Insert_Supplier_Category_Information', methods = ['POST'])
def Method_6():	

	get_Data = request.form.to_dict()	

	return Supplier_Information.Insert_Supplier_Category_Information(get_Data)


@app.route('/Update_Supplier_Category_Information', methods = ['POST'])
def Method_7():

	get_Data = request.form.to_dict()

	return Supplier_Information.Update_Supplier_Category_Information(get_Data)

@app.route('/Delete_Supplier_Category_Information', methods = ['POST'])
def Method_8():
	
	get_Data = request.data	
	get_Data = json.loads(get_Data)

	return Supplier_Information.Delete_Supplier_Category_Information(get_Data)


if __name__ == '__main__':
	CGIHandler().run(app)