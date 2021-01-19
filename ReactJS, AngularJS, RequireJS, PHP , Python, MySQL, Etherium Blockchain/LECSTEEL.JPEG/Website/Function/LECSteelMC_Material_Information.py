#! "T:/Python 3.8.0/python.exe"

# Employee_Information #

from LECSteelMC_Main import *

class Material_Information:

	Table_Name_1 = 'tbl_material_information'
	Table_Name_2 = 'tbl_material_category_information'
	Table_Name_3 = 'tbl_material_type_information'	

	def Select_Material_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity


		get_Category_Value = " INNER JOIN " + Material_Information.Table_Name_2 + " ON " + Material_Information.Table_Name_1 + ".Material_Category_Identity = " + Material_Information.Table_Name_2 + ".Category_Identity "
		get_Type_Value = " INNER JOIN " + Material_Information.Table_Name_3 + " ON " + Material_Information.Table_Name_1 + ".Material_Type_Identity = " + Material_Information.Table_Name_3 + ".Type_Identity "
		

		if set_Data['Action'] == 'Select : All':
			PyMySQL_Query = "SELECT * FROM " + Material_Information.Table_Name_1 + get_Category_Value + get_Type_Value
		
		elif set_Data['Action'] == 'Select : Specific':			
			PyMySQL_Query = "SELECT * FROM " + Material_Information.Table_Name_1 + get_Category_Value + get_Type_Value + " WHERE Material_Identity = '" + set_Data['Material_Identity'] + "'"
		
		else:
			return 'No Action'
			
		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)		

		PyMySQL_Data = PyMySQL_Cursor.fetchall()

		if PyMySQL_Row_Count > 0:

			JSON_Output = []

			for set_PyMySQL_Data in PyMySQL_Data :

				get_PyMySQL_Data = collections.OrderedDict()

				get_PyMySQL_Data['Material_Identity']  					= set_PyMySQL_Data['Material_Identity']
				get_PyMySQL_Data['Material_Part_Number']  				= set_PyMySQL_Data['Material_Part_Number']
				get_PyMySQL_Data['Material_Description']  				= set_PyMySQL_Data['Material_Description']
				get_PyMySQL_Data['Material_Unit']  						= set_PyMySQL_Data['Material_Unit']
				get_PyMySQL_Data['Material_Size']  						= set_PyMySQL_Data['Material_Size']				
				get_PyMySQL_Data['Material_Category_Identity']			= set_PyMySQL_Data['Material_Category_Identity']
				get_PyMySQL_Data['Material_Type_Identity']				= set_PyMySQL_Data['Material_Type_Identity']
				get_PyMySQL_Data['Category_Name']						= set_PyMySQL_Data['Category_Name']
				get_PyMySQL_Data['Type_Name']							= set_PyMySQL_Data['Type_Name']
				get_PyMySQL_Data['Material_Remark']  					= set_PyMySQL_Data['Material_Remark']
				get_PyMySQL_Data['Material_Quantity']  					= set_PyMySQL_Data['Material_Quantity']
				get_PyMySQL_Data['Material_Reorder_Point']  			= set_PyMySQL_Data['Material_Reorder_Point']
				get_PyMySQL_Data['Material_Order_Minimum']  			= set_PyMySQL_Data['Material_Order_Minimum']
				get_PyMySQL_Data['Material_Price_Expensive']  			= set_PyMySQL_Data['Material_Price_Expensive']
				get_PyMySQL_Data['Material_Price_Least']  				= set_PyMySQL_Data['Material_Price_Least']
				get_PyMySQL_Data['Material_Order_Identity_Expensive']  	= set_PyMySQL_Data['Material_Order_Identity_Expensive']
				get_PyMySQL_Data['Material_Order_Identity_Least']  		= set_PyMySQL_Data['Material_Order_Identity_Least']
				get_PyMySQL_Data['Material_Price_Current']  			= set_PyMySQL_Data['Material_Price_Current']
				get_PyMySQL_Data['Material_Image_Path']  				= set_PyMySQL_Data['Material_Image_Path']

				JSON_Output.append(get_PyMySQL_Data)

			return simplejson.dumps(JSON_Output)			

		else:
			return 'No Data'

	def Insert_Material_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity, Material_Code

		get_Material_Count = str(Main.get_Counter_Information(Material_Code))
		if len(get_Material_Count) < 4:
			if len(get_Material_Count) == 1:
				get_Material_Count = '000' + str(get_Material_Count)

			elif len(get_Material_Count) == 2:
				get_Material_Count = '00' + str(get_Material_Count)

			elif len(get_Material_Count) == 3:
				get_Material_Count = '0' + str(get_Material_Count)

		get_Material_Identity = Material_Code + '-' + Branch_Identity + '-' + get_Material_Count
		
		if set_Data['Material_Image'].filename != '':
			get_Material_Image_Path = Main.Image_Save(set_Data['Material_Image'], 'Material', get_Material_Identity)
		
		else:
			get_Material_Image_Path = ''

		Query_Column = '(	 Material_Identity, 						Material_Part_Number, 						Material_Description, 						Material_Unit, 						 Material_Size, 					  Material_Category_Identity, 					    Material_Type_Identity, 						Material_Remark,					   Material_Quantity, 						Material_Order_Minimum, 					  Material_Price_Current, 			  Material_Image_Path)'
		Query_Value = "('" + get_Material_Identity + "', '" + set_Data['Material_Part_Number'] + "', '" + set_Data['Material_Description'] + "', '" + set_Data['Material_Unit'] + "', '" + set_Data['Material_Size'] + "', '" + set_Data['Material_Category_Identity'] + "', '" + set_Data['Material_Type_Identity'] + "', '" + set_Data['Material_Remark'] + "', '" + set_Data['Material_Quantity'] + "', '" + set_Data['Material_Order_Minimum'] + "', '" + set_Data['Material_Price_Current'] + "', '" + get_Material_Image_Path + "')"


		PyMySQL_Query = "INSERT INTO " + Material_Information.Table_Name_1 + " " + Query_Column + " VALUES " + Query_Value + ""

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:
			Main.set_Counter_Information(Material_Code)			
				
			return 'Insert Succeeded'

		else:
			return 'Insert Failed'

	def Update_Material_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity, Material_Code	

		if set_Data['Material_Image'].filename != '':
			get_Material_Image_Path = Main.Image_Save(set_Data['Material_Image'], 'Material', set_Data['Material_Identity'])
			
		else:
			get_Material_Image_Path = ''


		get_String_1 = "Material_Part_Number = '" + set_Data['Material_Part_Number']  + "', Material_Unit = '" + set_Data['Material_Unit']  + "', Material_Size = '" + set_Data['Material_Size']  + "', "
		get_String_2 = "Material_Category_Identity = '" + set_Data['Material_Category_Identity']  + "', Material_Type_Identity = '" + set_Data['Material_Type_Identity']  + "', Material_Quantity = '" + set_Data['Material_Quantity']  + "', "
		get_String_3 = "Material_Order_Minimum = '" + set_Data['Material_Order_Minimum']  + "', Material_Price_Current = '" + set_Data['Material_Price_Current']  + "', Material_Description = '" + set_Data['Material_Description']  + "'"
			
		
		if get_Material_Image_Path != '':			
			get_String_3 += ", Material_Image_Path = '" + get_Material_Image_Path + "'"


		PyMySQL_Query = "UPDATE " + Material_Information.Table_Name_1 + " SET " + get_String_1 + get_String_2 + get_String_3 + " WHERE Material_Identity = '" + set_Data['Material_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Update Succeeded'

		else:
			return 'Update Failed'

	def Delete_Material_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		PyMySQL_Query = "DELETE FROM " + Material_Information.Table_Name_1 + " WHERE Material_Identity = '" + set_Data['Material_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Delete Succeeded'

		else:
			return 'Delete Failed'


	def Select_Material_Category_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity

		if set_Data['Action'] == 'Select : All':
			PyMySQL_Query = "SELECT * FROM " + Material_Information.Table_Name_2 + ""
		
		elif set_Data['Action'] == 'Select : Specific':			
			PyMySQL_Query = "SELECT * FROM " + Material_Information.Table_Name_2 + " WHERE Category_Identity = '" + set_Data['Category_Identity'] + "'"
		
		else:
			return 'No Action'

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

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
			
	def Insert_Material_Category_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		get_Category_Count = str(Main.get_Counter_Information(Material_Category_Code))


		if len(get_Category_Count) < 4:
			if len(get_Category_Count) == 1:
				get_Category_Count = '000' + str(get_Category_Count)

			elif len(get_Category_Count) == 2:
				get_Category_Count = '00' + str(get_Category_Count)

			elif len(get_Category_Count) == 3:
				get_Category_Count = '0' + str(get_Category_Count)

		
		get_Category_Identity = Material_Category_Code + '-' + Branch_Identity + '-' + get_Category_Count

		Query_Column = '(Category_Identity, Category_Name, Category_Description)'
		Query_Value = "('" + get_Category_Identity + "', '" + set_Data['Category_Name'] + "', '" + set_Data['Category_Description'] + "')"

		

		PyMySQL_Query = "INSERT INTO " + Material_Information.Table_Name_2 + " " + Query_Column + " VALUES " + Query_Value + ""

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:
			Main.set_Counter_Information(Material_Category_Code)
				
			return 'Insert Succeeded'

		else:
			return 'Insert Failed'

	def Update_Material_Category_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		PyMySQL_Query = "UPDATE " + Material_Information.Table_Name_2 + " SET Category_Name = '" + set_Data['Category_Name'] + "', Category_Description = '" + set_Data['Category_Description'] + "'  WHERE Category_Identity = '" + set_Data['Category_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Update Succeeded'

		else:
			return 'Update Failed'

	def Delete_Material_Category_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		PyMySQL_Query = "DELETE FROM " + Material_Information.Table_Name_2 + " WHERE Category_Identity = '" + set_Data['Category_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Delete Succeeded'

		else:
			return 'Delete Failed'



	def Select_Material_Type_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity

		if set_Data['Action'] == 'Select : All':
			PyMySQL_Query = "SELECT * FROM " + Material_Information.Table_Name_3 + ""
		
		elif set_Data['Action'] == 'Select : Specific':			
			PyMySQL_Query = "SELECT * FROM " + Material_Information.Table_Name_3 + " WHERE Type_Identity = '" + set_Data['Type_Identity'] + "'"
		
		else:
			return 'No Action'

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Data = PyMySQL_Cursor.fetchall()

		if PyMySQL_Row_Count > 0:

			JSON_Output = []

			for set_PyMySQL_Data in PyMySQL_Data :

				get_PyMySQL_Data = collections.OrderedDict()

				get_PyMySQL_Data['Type_Identity'] = set_PyMySQL_Data['Type_Identity']
				get_PyMySQL_Data['Type_Name'] = set_PyMySQL_Data['Type_Name']
				get_PyMySQL_Data['Type_Description'] = set_PyMySQL_Data['Type_Description']

				JSON_Output.append(get_PyMySQL_Data)

			return simplejson.dumps(JSON_Output)

		else:

			return 'No Data'
			
	def Insert_Material_Type_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		get_Type_Count = str(Main.get_Counter_Information(Material_Type_Code))


		if len(get_Type_Count) < 4:
			if len(get_Type_Count) == 1:
				get_Type_Count = '000' + str(get_Type_Count)

			elif len(get_Type_Count) == 2:
				get_Type_Count = '00' + str(get_Type_Count)

			elif len(get_Type_Count) == 3:
				get_Type_Count = '0' + str(get_Type_Count)

		
		get_Type_Identity = Material_Type_Code + '-' + Branch_Identity + '-' + get_Type_Count

		Query_Column = '(Type_Identity, Type_Name, Type_Description)'
		Query_Value = "('" + get_Type_Identity + "', '" + set_Data['Type_Name'] + "', '" + set_Data['Type_Description'] + "')"

		

		PyMySQL_Query = "INSERT INTO " + Material_Information.Table_Name_3 + " " + Query_Column + " VALUES " + Query_Value + ""

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:
			Main.set_Counter_Information(Material_Type_Code)
				
			return 'Insert Succeeded'

		else:
			return 'Insert Failed'

	def Update_Material_Type_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		PyMySQL_Query = "UPDATE " + Material_Information.Table_Name_3 + " SET Type_Name = '" + set_Data['Type_Name'] + "', Type_Description = '" + set_Data['Type_Description'] + "'  WHERE Type_Identity = '" + set_Data['Type_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Update Succeeded'

		else:
			return 'Update Failed'

	def Delete_Material_Type_Information(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		PyMySQL_Query = "DELETE FROM " + Material_Information.Table_Name_3 + " WHERE Type_Identity = '" + set_Data['Type_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Delete Succeeded'

		else:
			return 'Delete Failed'




#app.config['DEBUG'] = True

#get_Data = json.loads('{"Action" : "Select : All", "Material_Identity" : "MATL-0001-0143"}')

#print(Material_Information.Select_Material_Information(get_Data))


app = Flask(__name__)

#*************Rafael_Material*************#
#*************Rafael_Material*************#
#*************Rafael_Material*************#
#*************Rafael_Material*************#
#*************Rafael_Material*************#
@app.route('/Select_Material_Information', methods = ['POST'])
def Method_1():

	get_Data = request.data
	get_Data = json.loads(get_Data)

	return Material_Information.Select_Material_Information(get_Data)

@app.route('/Insert_Material_Information', methods = ['POST'])
def Method_2():

	get_Data = request.form.to_dict()
	get_Data_File = request.files['Material_Image']
	get_Data.update( {'Material_Image' : get_Data_File} )
	
	return Material_Information.Insert_Material_Information(get_Data)


@app.route('/Update_Material_Information', methods = ['POST'])
def Method_3():

	get_Data = request.form.to_dict()
	get_Data_File = request.files['Material_Image']
	get_Data.update( {'Material_Image' : get_Data_File} )
	
	return Material_Information.Update_Material_Information(get_Data)

@app.route('/Delete_Material_Information', methods = ['POST'])
def Method_4():
	
	get_Data = request.data	
	get_Data = json.loads(get_Data)

	return Material_Information.Delete_Material_Information(get_Data)

#*************Rafael_Material*************#
#*************Rafael_Material*************#
#*************Rafael_Material*************#
#*************Rafael_Material*************#
#*************Rafael_Material*************#


#*************Rafael_Material_Category*************#
#*************Rafael_Material_Category*************#
#*************Rafael_Material_Category*************#
#*************Rafael_Material_Category*************#
#*************Rafael_Material_Category*************#

@app.route('/Select_Material_Category_Information', methods = ['POST'])
def Method_5():

	get_Data = request.data
	get_Data = json.loads(get_Data)

	return Material_Information.Select_Material_Category_Information(get_Data)

@app.route('/Insert_Material_Category_Information', methods = ['POST'])
def Method_6():

	get_Data = request.form.to_dict()	

	return Material_Information.Insert_Material_Category_Information(get_Data)


@app.route('/Update_Material_Category_Information', methods = ['POST'])
def Method_7():

	get_Data = request.form.to_dict()

	return Material_Information.Update_Material_Category_Information(get_Data)

@app.route('/Delete_Material_Category_Information', methods = ['POST'])
def Method_8():
	
	get_Data = request.data	
	get_Data = json.loads(get_Data)

	return Material_Information.Delete_Material_Category_Information(get_Data)

#*************Rafael_Material_Category*************#
#*************Rafael_Material_Category*************#
#*************Rafael_Material_Category*************#
#*************Rafael_Material_Category*************#
#*************Rafael_Material_Category*************#


#*************Rafael_Material_Type*************#
#*************Rafael_Material_Type*************#
#*************Rafael_Material_Type*************#
#*************Rafael_Material_Type*************#
#*************Rafael_Material_Type*************#

@app.route('/Select_Material_Type_Information', methods = ['POST'])
def Method_9():

	get_Data = request.data
	get_Data = json.loads(get_Data)

	return Material_Information.Select_Material_Type_Information(get_Data)

@app.route('/Insert_Material_Type_Information', methods = ['POST'])
def Method_10():

	get_Data = request.form.to_dict()	

	return Material_Information.Insert_Material_Type_Information(get_Data)


@app.route('/Update_Material_Type_Information', methods = ['POST'])
def Method_11():

	get_Data = request.form.to_dict()

	return Material_Information.Update_Material_Type_Information(get_Data)

@app.route('/Delete_Material_Type_Information', methods = ['POST'])
def Method_12():
	
	get_Data = request.data	
	get_Data = json.loads(get_Data)

	return Material_Information.Delete_Material_Type_Information(get_Data)

#*************Rafael_Material_Type*************#
#*************Rafael_Material_Type*************#
#*************Rafael_Material_Type*************#
#*************Rafael_Material_Type*************#
#*************Rafael_Material_Type*************#


#get_Data = json.loads('{"Category_Identity":"","Category_Name":"sad","Category_Description":"asd"}')

#Material_Information.Insert_Material_Category_Information(get_Data)

if __name__ == '__main__':
	CGIHandler().run(app)