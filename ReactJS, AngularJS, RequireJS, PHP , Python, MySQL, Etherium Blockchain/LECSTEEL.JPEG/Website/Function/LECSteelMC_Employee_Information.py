#! "T:/Python 3.8.0/python.exe"

# Employee_Information #

from LECSteelMC_Main import *

class User_Information:

	def Select_User_Information(set_Action, set_Data):		
		
		global PyMySQL_Connection, PyMySQL_Cursor

		try:
			get_JSON = json.loads(set_Data)	
		except ValueError:
			return 'Decoding JSON has failed'

		if set_Action == 'Select : Specific : { Employee_Username, Employee_Username }':
			PyMySQL_Query = "SELECT * FROM tbl_employee_information WHERE Employee_Username = '" + get_JSON["Username"] + "' AND Employee_Password = '" + get_JSON["Password"] + "'"

		elif set_Action == 'Select : Specific : { Employee_Identity }':			
			PyMySQL_Query = "SELECT * FROM tbl_employee_information WHERE Employee_Identity = '" + get_JSON['Identity'] + "'"
		
		else:
			return('No Action : select_Employee_Information()')

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Data = PyMySQL_Cursor.fetchall()

		if PyMySQL_Row_Count > 0:
			return PyMySQL_Data[0]

		else:
			return 'No Data'


#print(LECSteelMC_Employee_Information.Select_Employee_Information('Select : Specific : { Employee_Username, Employee_Username }', '{ "Username" : "ensgskie" , "Password" : "123456" }'))

app = Flask(__name__)

@app.route('/get_User_Information/Select/Specific/(Employee_Username,Employee_Password)', methods = ['POST'])
def Method_XD():	
	Username = request.form.get('Username')
	Password = request.form.get('Password')
	return User_Information.Select_User_Information('Select : Specific : { Employee_Username, Employee_Username }', '{ "Username" : "' + Username + '" , "Password" : "' + Password + '" }')

@app.route('/get_User_Information/Select/Specific/(Employee_Identity)', methods = ['POST'])
def Method_XB():
	Identity = request.get_data(as_text=True)
	return User_Information.Select_User_Information('Select : Specific : { Employee_Identity }', '{ "Identity" : "' + Identity + '"}')



# Employee_Information #

class Employee_Information:

	Table_Name_1 = 'tbl_Employee_information'

	def Select_Employee_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity

		if set_Data['Action'] == 'Select : All':
			PyMySQL_Query = "SELECT *, CONCAT(Employee_FirstName,  Employee_MiddleName, Employee_LastName) AS Employee_FullName FROM " + Employee_Information.Table_Name_1
		
		elif set_Data['Action'] == 'Select : Specific':			
			PyMySQL_Query = "SELECT *, CONCAT(Employee_FirstName, Employee_MiddleName, Employee_LastName) AS Employee_FullName FROM " + Employee_Information.Table_Name_1 + " WHERE Employee_Identity = '" + set_Data['Employee_Identity'] + "'"
		
		else:
			return 'No Action'
		

		try:
			PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)		

			PyMySQL_Data = PyMySQL_Cursor.fetchall()
		except Exception as set_Exception:

			return str(set_Exception)



		if PyMySQL_Row_Count > 0:

			JSON_Output = []

			for set_PyMySQL_Data in PyMySQL_Data :

				get_PyMySQL_Data = collections.OrderedDict()

				get_PyMySQL_Data['Employee_Identity']  				= set_PyMySQL_Data['Employee_Identity']
				get_PyMySQL_Data['Employee_Username']  				= set_PyMySQL_Data['Employee_Username']
				get_PyMySQL_Data['Employee_Password']  				= set_PyMySQL_Data['Employee_Password']				
				get_PyMySQL_Data['Employee_FirstName']  			= set_PyMySQL_Data['Employee_FirstName']
				get_PyMySQL_Data['Employee_MiddleName']  	= set_PyMySQL_Data['Employee_MiddleName']
				get_PyMySQL_Data['Employee_LastName']  	= set_PyMySQL_Data['Employee_LastName']
				get_PyMySQL_Data['Employee_FullName']  	= set_PyMySQL_Data['Employee_FullName']
				get_PyMySQL_Data['Employee_Position']  	= set_PyMySQL_Data['Employee_Position']
				get_PyMySQL_Data['Employee_Image_Path']  		= set_PyMySQL_Data['Employee_Image_Path']

				JSON_Output.append(get_PyMySQL_Data)

			return simplejson.dumps(JSON_Output)			

		else:
			return 'No Data'

	def Insert_Employee_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		get_Employee_Count = str(Main.get_Counter_Information(Employee_Code))
		if len(get_Employee_Count) < 4:
			if len(get_Employee_Count) == 1:
				get_Employee_Count = '000' + str(get_Employee_Count)

			elif len(get_Employee_Count) == 2:
				get_Employee_Count = '00' + str(get_Employee_Count)

			elif len(get_Employee_Count) == 3:
				get_Employee_Count = '0' + str(get_Employee_Count)

		get_Employee_Identity = Employee_Code + '-' + Branch_Identity + '-' + get_Employee_Count
		
		if set_Data['Employee_Image'].filename != '':
			get_Employee_Image_Path = Main.Image_Save(set_Data['Employee_Image'], 'Employee', get_Employee_Identity)
		
		else:
			get_Employee_Image_Path = ''

		Query_Column = '(	 Employee_Identity, 						Employee_Username, 						 Employee_Password, 					  Employee_FirstName, 					    Employee_MiddleName, 					   Employee_LastName, 					    Employee_Position,				   		 Employee_Privilege_List,				  Employee_Image_Path)'
		Query_Value = "('" + get_Employee_Identity + "', '" + set_Data['Employee_Username'] + "', '" + set_Data['Employee_Password'] + "', '" + set_Data['Employee_FirstName'] + "', '" + set_Data['Employee_MiddleName'] + "', '" + set_Data['Employee_LastName'] + "', '" + set_Data['Employee_Position'] + "', '" + set_Data['Employee_Privilege_List'] + "', '" + get_Employee_Image_Path + "')"

		PyMySQL_Query = "INSERT INTO " + Employee_Information.Table_Name_1 + " " + Query_Column + " VALUES " + Query_Value + ""
		
		try:
			PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)
			PyMySQL_Connection.commit()

		except Exception as set_Exception:

			return str(set_Exception)		
		
		if PyMySQL_Row_Count > 0:
			Main.set_Counter_Information(Employee_Code)			
				
			return 'Insert Succeeded'

		else:
			return 'Insert Failed'

	def Update_Employee_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity	

		if set_Data['Employee_Image'].filename != '':
			get_Employee_Image_Path = Main.Image_Save(set_Data['Employee_Image'], 'Employee', set_Data['Employee_Identity'])
			
		else:
			get_Employee_Image_Path = ''

		get_String_1 = "Employee_Username = '" + set_Data['Employee_Username']  + "', Employee_Password = '" + set_Data['Employee_Password']  + "', Employee_FirstName = '" + set_Data['Employee_FirstName']  + "', "
		get_String_2 = "Employee_MiddleName = '" + set_Data['Employee_MiddleName']  + "', Employee_LastName = '" + set_Data['Employee_LastName']  + "', Employee_Position = '" + set_Data['Employee_Position']  + "', Employee_Privilege_List = '" + set_Data['Employee_Privilege_List'] + "'"

		if get_Employee_Image_Path != '':			
			get_String_2 += ", Employee_Image_Path = '" + get_Employee_Image_Path + "'"


		PyMySQL_Query = "UPDATE " + Employee_Information.Table_Name_1 + " SET " + get_String_1 + get_String_2 + " WHERE Employee_Identity = '" + set_Data['Employee_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Update Succeeded'

		else:

			if get_Employee_Image_Path != '':
				return 'Update Succeeded'
				
			else:
				return 'Update Failed'

	def Delete_Employee_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		PyMySQL_Query = "DELETE FROM " + Employee_Information.Table_Name_1 + " WHERE Employee_Identity = '" + set_Data['Employee_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Delete Succeeded'

		else:
			return 'Delete Failed'


@app.route('/Select_Employee_Information', methods = ['POST'])
def Method_1():

	get_Data = request.data
	get_Data = json.loads(get_Data)

	return Employee_Information.Select_Employee_Information(get_Data)

@app.route('/Insert_Employee_Information', methods = ['POST'])
def Method_2():	

	get_Data = request.form.to_dict()
	get_Data_File = request.files['Employee_Image']
	get_Data.update( {'Employee_Image' : get_Data_File} )
	
	return Employee_Information.Insert_Employee_Information(get_Data)


@app.route('/Update_Employee_Information', methods = ['POST'])
def Method_3():

	get_Data = request.form.to_dict()
	get_Data_File = request.files['Employee_Image']
	get_Data.update( {'Employee_Image' : get_Data_File} )
	
	return Employee_Information.Update_Employee_Information(get_Data)

@app.route('/Delete_Employee_Information', methods = ['POST'])
def Method_4():
	
	get_Data = request.data	
	get_Data = json.loads(get_Data)

	return Employee_Information.Delete_Employee_Information(get_Data)


if __name__ == '__main__':
	CGIHandler().run(app)