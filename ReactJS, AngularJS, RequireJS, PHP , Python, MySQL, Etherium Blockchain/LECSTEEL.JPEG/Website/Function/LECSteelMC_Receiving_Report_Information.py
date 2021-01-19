#! "T:/Python 3.8.0/python.exe"

# Receiving_Report_Information #

from LECSteelMC_Main import *

class Receiving_Report_Information:

	Table_Name_1 = 'tbl_Receiving_Report_information_parent'
	Table_Name_2 = 'tbl_Receiving_Report_information_child'

	def Select_Receiving_Report_Information_Parent(set_Data) :

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity		
		
		if set_Data['Action'] == 'Select : All' :
			PyMySQL_Query = "SELECT * FROM " + Receiving_Report_Information.Table_Name_1

		else :
			return 'No Action'
		
		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)		

		PyMySQL_Data = PyMySQL_Cursor.fetchall()


		if PyMySQL_Row_Count > 0:

			JSON_Output = []

			for set_PyMySQL_Data in PyMySQL_Data :

				get_PyMySQL_Data = collections.OrderedDict()

				if set_Data['Action'] == 'Select : Specific':
					get_PyMySQL_Data['Receiving_Report_Information_Child'] = Receiving_Report_Information.Select_Receiving_Report_Information_Child(set_Data)

				
				get_PyMySQL_Data['Receiving_Report_Identity']				= set_PyMySQL_Data['Receiving_Report_Identity']
				get_PyMySQL_Data['Receiving_Report_Number_Parent']		= set_PyMySQL_Data['Receiving_Report_Number_Parent']
				get_PyMySQL_Data['Receiving_Report_Supplier_Identity']	= set_PyMySQL_Data['Receiving_Report_Supplier_Identity']				
				get_PyMySQL_Data['Receiving_Report_Remarks']				= set_PyMySQL_Data['Receiving_Report_Remarks']
				get_PyMySQL_Data['Receiving_Report_Amount']  				= set_PyMySQL_Data['Receiving_Report_Amount']
				get_PyMySQL_Data['Receiving_Report_Amount_Paid']			= set_PyMySQL_Data['Receiving_Report_Amount_Paid']
				get_PyMySQL_Data['Receiving_Report_DateTime_Issue']  		= set_PyMySQL_Data['Receiving_Report_DateTime_Issue']
				get_PyMySQL_Data['Receiving_Report_DateTime_Due']			= set_PyMySQL_Data['Receiving_Report_DateTime_Due']
				get_PyMySQL_Data['Receiving_Report_DateTime_Posted']		= set_PyMySQL_Data['Receiving_Report_DateTime_Posted']
				get_PyMySQL_Data['Receiving_Report_DateTime_Unposted']	= set_PyMySQL_Data['Receiving_Report_DateTime_Unposted']
				get_PyMySQL_Data['Receiving_Report_Status']				= set_PyMySQL_Data['Receiving_Report_Status']
				get_PyMySQL_Data['Receiving_Report_Image_Path']			= set_PyMySQL_Data['Receiving_Report_Image_Path']

				JSON_Output.append(get_PyMySQL_Data)

			return simplejson.dumps(JSON_Output, indent = 4, sort_keys = True, default = str)			

		else:
			return 'No Data'

	def Insert_Receiving_Report_Information_Parent(set_Data) :

		global PyMySQL_Connection, PyMySQL_Cursor		

		get_Receiving_Report_Count = str(Main.get_Counter_Information(Receiving_Report_Code))
		
		if len(get_Receiving_Report_Count) < 4:
			if len(get_Receiving_Report_Count) == 1:
				get_Receiving_Report_Count = '000' + str(get_Receiving_Report_Count)

			elif len(get_Receiving_Report_Count) == 2:
				get_Receiving_Report_Count = '00' + str(get_Receiving_Report_Count)

			elif len(get_Receiving_Report_Count) == 3:
				get_Receiving_Report_Count = '0' + str(get_Receiving_Report_Count)

		try:
			
			get_Receiving_Report_Identity = Receiving_Report_Code + '-' + Branch_Identity + '-' + get_Receiving_Report_Count
			
			if set_Data['Receiving_Report_Image'].filename != '':
				get_Receiving_Report_Image_Path = Main.Image_Save(set_Data['Receiving_Report_Image'], 'Receiving_Report', get_Receiving_Report_Identity)
			
			else:
				get_Receiving_Report_Image_Path = ''			

			Query_Column = '(	 	 Receiving_Report_Identity,					  Receiving_Report_Number_Parent,						  Receiving_Report_Supplier_Identity,						  Receiving_Report_Remarks, 						Receiving_Report_Amount,						 Receiving_Report_Amount_Paid,					   Receiving_Report_DateTime_Issue,						Receiving_Report_DateTime_Due, 					   Receiving_Report_DateTime_Posted,			      		 Receiving_Report_DateTime_Unposted,						 Receiving_Report_Status, 				Receiving_Report_Image_Path)'
			Query_Value = "('" + get_Receiving_Report_Identity + "', '" + set_Data['Receiving_Report_Number_Parent'] + "', '" + set_Data['Receiving_Report_Supplier_Identity'] + "', '" + set_Data['Receiving_Report_Remarks'] + "', '" + set_Data['Receiving_Report_Amount'] + "', '" + set_Data['Receiving_Report_Amount_Paid'] + "', '" + set_Data['Receiving_Report_DateTime_Issue'] + "', '" + set_Data['Receiving_Report_DateTime_Due'] + "', '" + set_Data['Receiving_Report_DateTime_Posted'] + "', '" + set_Data['Receiving_Report_DateTime_Unposted'] + "', '" + set_Data['Receiving_Report_Status'] + "', '" + get_Receiving_Report_Image_Path + "')"


			PyMySQL_Query = "INSERT INTO " + Receiving_Report_Information.Table_Name_1 + " " + Query_Column + " VALUES " + Query_Value + ""

			PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

			PyMySQL_Connection.commit()

		except Exception as set_Exception:
			
			return str(set_Exception)

		if PyMySQL_Row_Count > 0 :

			Main.set_Counter_Information(Receiving_Report_Code)
			
			if str(Receiving_Report_Information.Insert_Receiving_Report_Information_Child(get_Receiving_Report_Identity, set_Data['Receiving_Report_Information_Child'])) == 'Insert Succeeded' :

				return 'Insert Succeeded'

			else:

				return 'Insert Failed'

		else:

			return 'Insert Failed'

	def Update_Receiving_Report_Information_Parent(set_Data) :

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity	

		if set_Data['Receiving_Report_Image'].filename != '' :
			get_Receiving_Report_Image_Path = Main.Image_Save(set_Data['Receiving_Report_Image'], 'Receiving_Report', set_Data['Receiving_Report_Identity'])
			
		else:
			get_Receiving_Report_Image_Path = ''


		get_String_1 = "Receiving_Report_Supplier_Identity = '" + set_Data['Receiving_Report_Supplier_Identity']  + "', Receiving_Report_Remarks = '" + set_Data['Receiving_Report_Remarks']  + "', "
		get_String_2 = "Receiving_Report_Amount = '" + set_Data['Receiving_Report_Amount']  + "', Receiving_Report_Amount_Paid = '" + set_Data['Receiving_Report_Amount_Paid']  + "', Receiving_Report_DateTime_Issue = '" + set_Data['Receiving_Report_DateTime_Issue']  + "', "
		get_String_3 = "Receiving_Report_DateTime_Due = '" + set_Data['Receiving_Report_DateTime_Due']  + "', Receiving_Report_DateTime_Posted = '" + set_Data['Receiving_Report_DateTime_Posted']  + "', Receiving_Report_DateTime_Unposted = '" + set_Data['Receiving_Report_DateTime_Unposted']  + "', "
		get_String_4 = "Receiving_Report_Status = '" + set_Data['Receiving_Report_Status'] + "'"

		if get_Receiving_Report_Image_Path != '' :
			get_String_4 += ", Receiving_Report_Image_Path = '" + get_Receiving_Report_Image_Path + "'"


		PyMySQL_Query = "UPDATE " + Receiving_Report_Information.Table_Name_1 + " SET " + get_String_1 + get_String_2 + get_String_3 + get_String_4 + " WHERE Receiving_Report_Identity = '" + set_Data['Receiving_Report_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()

		return Receiving_Report_Information.Update_Receiving_Report_Information_Child(set_Data['Receiving_Report_Identity'], set_Data['Receiving_Report_Information_Child'])
		
		return 'Update Succeeded'

	def Delete_Receiving_Report_Information_Parent(set_Data) :

		global PyMySQL_Connection, PyMySQL_Cursor

		PyMySQL_Query = "DELETE FROM " + Receiving_Report_Information.Table_Name_1 + " WHERE Receiving_Report_Identity = '" + set_Data['Receiving_Report_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Delete Succeeded'

		else:
			return 'Delete Failed'



	def Select_Receiving_Report_Information_Child(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity

		if set_Data['Action'] == 'Select : All':
			PyMySQL_Query = "SELECT * FROM " + Receiving_Report_Information.Table_Name_2
		
		elif set_Data['Action'] == 'Select : Specific':			
			PyMySQL_Query = "SELECT * FROM " + Receiving_Report_Information.Table_Name_2 + " WHERE Receiving_Report_Identity = '" + set_Data['Receiving_Report_Identity'] + "'"
		
		else:
			return 'No Action'
		
		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)		

		PyMySQL_Data = PyMySQL_Cursor.fetchall()


		if PyMySQL_Row_Count > 0:

			JSON_Output = []

			for set_PyMySQL_Data in PyMySQL_Data :

				get_PyMySQL_Data = collections.OrderedDict()
				
				get_PyMySQL_Data['Receiving_Report_Identity']				= set_PyMySQL_Data['Receiving_Report_Identity']
				get_PyMySQL_Data['Receiving_Report_Number_Child']			= set_PyMySQL_Data['Receiving_Report_Number_Child']
				get_PyMySQL_Data['Receiving_Report_Material_Identity']	= set_PyMySQL_Data['Receiving_Report_Material_Identity']
				get_PyMySQL_Data['Receiving_Report_Quantity_Issued']		= set_PyMySQL_Data['Receiving_Report_Quantity_Issued']
				get_PyMySQL_Data['Receiving_Report_Quantity_Served']		= set_PyMySQL_Data['Receiving_Report_Quantity_Served']
				get_PyMySQL_Data['Receiving_Report_Quantity_Balance']		= set_PyMySQL_Data['Receiving_Report_Quantity_Balance']
				get_PyMySQL_Data['Receiving_Report_Employee_Identity']	= set_PyMySQL_Data['Receiving_Report_Employee_Identity']

				JSON_Output.append(get_PyMySQL_Data)

			return simplejson.dumps(JSON_Output)			

		else:
			return 'No Data'



	def Insert_Receiving_Report_Information_Child(set_Receiving_Report_Identity, set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		set_Data = json.loads(set_Data)

		try:

			PyMySQL_Row_Count = 0

			for set_Data in set_Data:


				Query_Column = '(		 Receiving_Report_Identity,					  Receiving_Report_Number_Child,						 Receiving_Report_Material_Identity,						 Receiving_Report_Quantity_Issued,					   Receiving_Report_Quantity_Served,						 Receiving_Report_Quantity_Balance,						Receiving_Report_Employee_Identity)'
				Query_Value = "('" + set_Receiving_Report_Identity + "', '" + set_Data['Receiving_Report_Number_Child'] + "', '" + set_Data['Receiving_Report_Material_Identity'] + "', '" + set_Data['Receiving_Report_Quantity_Issued'] + "', '" + set_Data['Receiving_Report_Quantity_Served'] + "', '" + set_Data['Receiving_Report_Quantity_Balance'] + "', '" + set_Data['Receiving_Report_Employee_Identity'] + "')"
			
				PyMySQL_Query = "INSERT INTO " + Receiving_Report_Information.Table_Name_2 + " " + Query_Column + " VALUES " + Query_Value + ""		

				PyMySQL_Row_Count += PyMySQL_Cursor.execute(PyMySQL_Query)

			PyMySQL_Connection.commit()

		except Exception as set_Exception:
			
			return str(set_Exception)


		if PyMySQL_Row_Count > 0:						
				
			return 'Insert Succeeded'

		else:
			return 'Insert Failed'

	def Update_Receiving_Report_Information_Child(set_Receiving_Report_Identity, set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity		

		set_Data = json.loads(set_Data)

		try:

			PyMySQL_Row_Count = 0

			for set_Data in set_Data:
				get_String_1 = "Receiving_Report_Quantity_Issued = '" + str(set_Data['Receiving_Report_Quantity_Issued'])  + "', Receiving_Report_Quantity_Served = '" + str(set_Data['Receiving_Report_Quantity_Served'])  + "', Receiving_Report_Quantity_Balance = '" + str(set_Data['Receiving_Report_Quantity_Balance'])  + "'"
				
				PyMySQL_Query = "UPDATE " + Receiving_Report_Information.Table_Name_2 + " SET " + get_String_1 + " WHERE Receiving_Report_Identity = '" + set_Receiving_Report_Identity + "' AND Receiving_Report_Material_Identity = '" + set_Data['Receiving_Report_Material_Identity'] + "'"
				
				PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

			PyMySQL_Connection.commit()

		except Exception as set_Exception:
			
			return str(set_Exception)
		
		return 'Update Succeeded'


app = Flask(__name__)


@app.route('/Select_Receiving_Report_Information_Parent', methods = ['POST'])
def Method_1():

	get_Data = request.data
	get_Data = json.loads(get_Data)

	return Receiving_Report_Information.Select_Receiving_Report_Information_Parent(get_Data)

@app.route('/Insert_Receiving_Report_Information_Parent', methods = ['POST'])
def Method_2():	

	get_Data = request.form.to_dict()
	get_Data_File = request.files['Receiving_Report_Image']
	get_Data.update( {'Receiving_Report_Image' : get_Data_File} )
	
	return Receiving_Report_Information.Insert_Receiving_Report_Information_Parent(get_Data)


@app.route('/Update_Receiving_Report_Information_Parent', methods = ['POST'])
def Method_3():

	get_Data = request.form.to_dict()
	get_Data_File = request.files['Receiving_Report_Image']
	get_Data.update( {'Receiving_Report_Image' : get_Data_File} )
	
	return Receiving_Report_Information.Update_Receiving_Report_Information_Parent(get_Data)

@app.route('/Delete_Receiving_Report_Information_Parent', methods = ['POST'])
def Method_4():
	
	get_Data = request.data	
	get_Data = json.loads(get_Data)

	return Receiving_Report_Information.Delete_Receiving_Report_Information_Parent(get_Data)

if __name__ == '__main__':
	CGIHandler().run(app)