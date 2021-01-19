#! "T:/Python 3.8.0/python.exe"

# Purchase_Order_Information #

from LECSteelMC_Main import *

class Purchase_Order_Information:

	Table_Name_1 = 'tbl_purchase_order_information_parent'
	Table_Name_2 = 'tbl_purchase_order_information_child'

	def Select_Purchase_Order_Information_Parent(set_Data) :

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity		
		
		if set_Data['Action'] == 'Select : All' :
			PyMySQL_Query = "SELECT * FROM " + Purchase_Order_Information.Table_Name_1

		elif set_Data['Action'] == 'Select : All : Purchase_Order_Status { Posted }' :
			PyMySQL_Query = "SELECT * FROM " + Purchase_Order_Information.Table_Name_1 + " WHERE Purchase_Order_Status = 'Posted'"
		
		elif set_Data['Action'] == 'Select : Specific' :			
			PyMySQL_Query = "SELECT * FROM " + Purchase_Order_Information.Table_Name_1 + " WHERE Purchase_Order_Identity = '" + set_Data['Purchase_Order_Identity'] + "'"
		
		else :
			return 'No Action'
		
		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)		

		PyMySQL_Data = PyMySQL_Cursor.fetchall()


		if PyMySQL_Row_Count > 0:

			JSON_Output = []

			for set_PyMySQL_Data in PyMySQL_Data :

				get_PyMySQL_Data = collections.OrderedDict()

				if set_Data['Action'] == 'Select : Specific':
					get_PyMySQL_Data['Purchase_Order_Information_Child'] = Purchase_Order_Information.Select_Purchase_Order_Information_Child(set_Data)

				
				get_PyMySQL_Data['Purchase_Order_Identity']				= set_PyMySQL_Data['Purchase_Order_Identity']
				get_PyMySQL_Data['Purchase_Order_Number_Parent']		= set_PyMySQL_Data['Purchase_Order_Number_Parent']
				get_PyMySQL_Data['Purchase_Order_Supplier_Identity']	= set_PyMySQL_Data['Purchase_Order_Supplier_Identity']				
				get_PyMySQL_Data['Purchase_Order_Remarks']				= set_PyMySQL_Data['Purchase_Order_Remarks']
				get_PyMySQL_Data['Purchase_Order_Amount']  				= set_PyMySQL_Data['Purchase_Order_Amount']
				get_PyMySQL_Data['Purchase_Order_Amount_Paid']			= set_PyMySQL_Data['Purchase_Order_Amount_Paid']
				get_PyMySQL_Data['Purchase_Order_DateTime_Issue']  		= set_PyMySQL_Data['Purchase_Order_DateTime_Issue']
				get_PyMySQL_Data['Purchase_Order_DateTime_Due']			= set_PyMySQL_Data['Purchase_Order_DateTime_Due']
				get_PyMySQL_Data['Purchase_Order_DateTime_Posted']		= set_PyMySQL_Data['Purchase_Order_DateTime_Posted']
				get_PyMySQL_Data['Purchase_Order_DateTime_Unposted']	= set_PyMySQL_Data['Purchase_Order_DateTime_Unposted']
				get_PyMySQL_Data['Purchase_Order_Status']				= set_PyMySQL_Data['Purchase_Order_Status']
				get_PyMySQL_Data['Purchase_Order_Image_Path']			= set_PyMySQL_Data['Purchase_Order_Image_Path']

				JSON_Output.append(get_PyMySQL_Data)

			return simplejson.dumps(JSON_Output, indent = 4, sort_keys = True, default = str)			

		else:
			return 'No Data'

	def Insert_Purchase_Order_Information_Parent(set_Data) :

		global PyMySQL_Connection, PyMySQL_Cursor		

		get_Purchase_Order_Count = str(Main.get_Counter_Information(Purchase_Order_Code))
		
		if len(get_Purchase_Order_Count) < 4:
			if len(get_Purchase_Order_Count) == 1:
				get_Purchase_Order_Count = '000' + str(get_Purchase_Order_Count)

			elif len(get_Purchase_Order_Count) == 2:
				get_Purchase_Order_Count = '00' + str(get_Purchase_Order_Count)

			elif len(get_Purchase_Order_Count) == 3:
				get_Purchase_Order_Count = '0' + str(get_Purchase_Order_Count)

		try:
			
			get_Purchase_Order_Identity = Purchase_Order_Code + '-' + Branch_Identity + '-' + get_Purchase_Order_Count
			
			if set_Data['Purchase_Order_Image'].filename != '':
				get_Purchase_Order_Image_Path = Main.Image_Save(set_Data['Purchase_Order_Image'], 'Purchase_Order', get_Purchase_Order_Identity)
			
			else:
				get_Purchase_Order_Image_Path = ''			

			Query_Column = '(	 	 Purchase_Order_Identity,					  Purchase_Order_Number_Parent,						  Purchase_Order_Supplier_Identity,						  Purchase_Order_Remarks, 						Purchase_Order_Amount,						 Purchase_Order_Amount_Paid,					   Purchase_Order_DateTime_Issue,						Purchase_Order_DateTime_Due, 					   Purchase_Order_DateTime_Posted,			      		 Purchase_Order_DateTime_Unposted,						 Purchase_Order_Status, 				Purchase_Order_Image_Path)'
			Query_Value = "('" + get_Purchase_Order_Identity + "', '" + set_Data['Purchase_Order_Number_Parent'] + "', '" + set_Data['Purchase_Order_Supplier_Identity'] + "', '" + set_Data['Purchase_Order_Remarks'] + "', '" + set_Data['Purchase_Order_Amount'] + "', '" + set_Data['Purchase_Order_Amount_Paid'] + "', '" + set_Data['Purchase_Order_DateTime_Issue'] + "', '" + set_Data['Purchase_Order_DateTime_Due'] + "', '" + set_Data['Purchase_Order_DateTime_Posted'] + "', '" + set_Data['Purchase_Order_DateTime_Unposted'] + "', '" + set_Data['Purchase_Order_Status'] + "', '" + get_Purchase_Order_Image_Path + "')"


			PyMySQL_Query = "INSERT INTO " + Purchase_Order_Information.Table_Name_1 + " " + Query_Column + " VALUES " + Query_Value + ""

			PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

			PyMySQL_Connection.commit()

		except Exception as set_Exception:
			
			return str(set_Exception)

		if PyMySQL_Row_Count > 0 :

			Main.set_Counter_Information(Purchase_Order_Code)
			
			if str(Purchase_Order_Information.Insert_Purchase_Order_Information_Child(get_Purchase_Order_Identity, set_Data['Purchase_Order_Information_Child'])) == 'Insert Succeeded' :

				return 'Insert Succeeded'

			else:

				return 'Insert Failed'

		else:

			return 'Insert Failed'

	def Update_Purchase_Order_Information_Parent(set_Data) :

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity	

		if set_Data['Purchase_Order_Image'].filename != '' :
			get_Purchase_Order_Image_Path = Main.Image_Save(set_Data['Purchase_Order_Image'], 'Purchase_Order', set_Data['Purchase_Order_Identity'])
			
		else:
			get_Purchase_Order_Image_Path = ''


		get_String_1 = "Purchase_Order_Supplier_Identity = '" + set_Data['Purchase_Order_Supplier_Identity']  + "', Purchase_Order_Remarks = '" + set_Data['Purchase_Order_Remarks']  + "', "
		get_String_2 = "Purchase_Order_Amount = '" + set_Data['Purchase_Order_Amount']  + "', Purchase_Order_Amount_Paid = '" + set_Data['Purchase_Order_Amount_Paid']  + "', Purchase_Order_DateTime_Issue = '" + set_Data['Purchase_Order_DateTime_Issue']  + "', "
		get_String_3 = "Purchase_Order_DateTime_Due = '" + set_Data['Purchase_Order_DateTime_Due']  + "', Purchase_Order_DateTime_Posted = '" + set_Data['Purchase_Order_DateTime_Posted']  + "', Purchase_Order_DateTime_Unposted = '" + set_Data['Purchase_Order_DateTime_Unposted']  + "', "
		get_String_4 = "Purchase_Order_Status = '" + set_Data['Purchase_Order_Status'] + "'"

		if get_Purchase_Order_Image_Path != '' :
			get_String_4 += ", Purchase_Order_Image_Path = '" + get_Purchase_Order_Image_Path + "'"


		PyMySQL_Query = "UPDATE " + Purchase_Order_Information.Table_Name_1 + " SET " + get_String_1 + get_String_2 + get_String_3 + get_String_4 + " WHERE Purchase_Order_Identity = '" + set_Data['Purchase_Order_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()

		return Purchase_Order_Information.Update_Purchase_Order_Information_Child(set_Data['Purchase_Order_Identity'], set_Data['Purchase_Order_Information_Child'])
		
		return 'Update Succeeded'

	def Delete_Purchase_Order_Information_Parent(set_Data) :

		global PyMySQL_Connection, PyMySQL_Cursor

		PyMySQL_Query = "DELETE FROM " + Purchase_Order_Information.Table_Name_1 + " WHERE Purchase_Order_Identity = '" + set_Data['Purchase_Order_Identity'] + "'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()		

		if PyMySQL_Row_Count > 0:

			return 'Delete Succeeded'

		else:
			return 'Delete Failed'



	def Select_Purchase_Order_Information_Child(set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity

		if set_Data['Action'] == 'Select : All':
			PyMySQL_Query = "SELECT * FROM " + Purchase_Order_Information.Table_Name_2
		
		elif set_Data['Action'] == 'Select : Specific':			
			PyMySQL_Query = "SELECT * FROM " + Purchase_Order_Information.Table_Name_2 + " WHERE Purchase_Order_Identity = '" + set_Data['Purchase_Order_Identity'] + "'"
		
		else:
			return 'No Action'
		
		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)		

		PyMySQL_Data = PyMySQL_Cursor.fetchall()


		if PyMySQL_Row_Count > 0:

			JSON_Output = []

			for set_PyMySQL_Data in PyMySQL_Data :

				get_PyMySQL_Data = collections.OrderedDict()
				
				get_PyMySQL_Data['Purchase_Order_Identity']				= set_PyMySQL_Data['Purchase_Order_Identity']
				get_PyMySQL_Data['Purchase_Order_Number_Child']			= set_PyMySQL_Data['Purchase_Order_Number_Child']
				get_PyMySQL_Data['Purchase_Order_Material_Identity']	= set_PyMySQL_Data['Purchase_Order_Material_Identity']
				get_PyMySQL_Data['Purchase_Order_Quantity_Issued']		= set_PyMySQL_Data['Purchase_Order_Quantity_Issued']
				get_PyMySQL_Data['Purchase_Order_Quantity_Served']		= set_PyMySQL_Data['Purchase_Order_Quantity_Served']
				get_PyMySQL_Data['Purchase_Order_Quantity_Balance']		= set_PyMySQL_Data['Purchase_Order_Quantity_Balance']
				get_PyMySQL_Data['Purchase_Order_Employee_Identity']	= set_PyMySQL_Data['Purchase_Order_Employee_Identity']

				JSON_Output.append(get_PyMySQL_Data)

			return simplejson.dumps(JSON_Output)			

		else:
			return 'No Data'



	def Insert_Purchase_Order_Information_Child(set_Purchase_Order_Identity, set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor

		set_Data = json.loads(set_Data)

		try:

			PyMySQL_Row_Count = 0

			for set_Data in set_Data:


				Query_Column = '(		 Purchase_Order_Identity,					  Purchase_Order_Number_Child,						 Purchase_Order_Material_Identity,						 Purchase_Order_Quantity_Issued,					   Purchase_Order_Quantity_Served,						 Purchase_Order_Quantity_Balance,						Purchase_Order_Employee_Identity)'
				Query_Value = "('" + set_Purchase_Order_Identity + "', '" + set_Data['Purchase_Order_Number_Child'] + "', '" + set_Data['Purchase_Order_Material_Identity'] + "', '" + set_Data['Purchase_Order_Quantity_Issued'] + "', '" + set_Data['Purchase_Order_Quantity_Served'] + "', '" + set_Data['Purchase_Order_Quantity_Balance'] + "', '" + set_Data['Purchase_Order_Employee_Identity'] + "')"
			
				PyMySQL_Query = "INSERT INTO " + Purchase_Order_Information.Table_Name_2 + " " + Query_Column + " VALUES " + Query_Value + ""		

				PyMySQL_Row_Count += PyMySQL_Cursor.execute(PyMySQL_Query)

			PyMySQL_Connection.commit()

		except Exception as set_Exception:
			
			return str(set_Exception)


		if PyMySQL_Row_Count > 0:						
				
			return 'Insert Succeeded'

		else:
			return 'Insert Failed'

	def Update_Purchase_Order_Information_Child(set_Purchase_Order_Identity, set_Data):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity		

		set_Data = json.loads(set_Data)

		try:

			PyMySQL_Row_Count = 0

			for set_Data in set_Data:
				get_String_1 = "Purchase_Order_Quantity_Issued = '" + str(set_Data['Purchase_Order_Quantity_Issued'])  + "', Purchase_Order_Quantity_Served = '" + str(set_Data['Purchase_Order_Quantity_Served'])  + "', Purchase_Order_Quantity_Balance = '" + str(set_Data['Purchase_Order_Quantity_Balance'])  + "'"
				
				PyMySQL_Query = "UPDATE " + Purchase_Order_Information.Table_Name_2 + " SET " + get_String_1 + " WHERE Purchase_Order_Identity = '" + set_Purchase_Order_Identity + "' AND Purchase_Order_Material_Identity = '" + set_Data['Purchase_Order_Material_Identity'] + "'"
				
				PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

			PyMySQL_Connection.commit()

		except Exception as set_Exception:
			
			return str(set_Exception)
		
		return 'Update Succeeded'


app = Flask(__name__)


@app.route('/Select_Purchase_Order_Information_Parent', methods = ['POST'])
def Method_1():

	get_Data = request.data
	get_Data = json.loads(get_Data)

	return Purchase_Order_Information.Select_Purchase_Order_Information_Parent(get_Data)

@app.route('/Insert_Purchase_Order_Information_Parent', methods = ['POST'])
def Method_2():	

	get_Data = request.form.to_dict()
	get_Data_File = request.files['Purchase_Order_Image']
	get_Data.update( {'Purchase_Order_Image' : get_Data_File} )
	
	return Purchase_Order_Information.Insert_Purchase_Order_Information_Parent(get_Data)


@app.route('/Update_Purchase_Order_Information_Parent', methods = ['POST'])
def Method_3():

	get_Data = request.form.to_dict()
	get_Data_File = request.files['Purchase_Order_Image']
	get_Data.update( {'Purchase_Order_Image' : get_Data_File} )
	
	return Purchase_Order_Information.Update_Purchase_Order_Information_Parent(get_Data)

@app.route('/Delete_Purchase_Order_Information_Parent', methods = ['POST'])
def Method_4():
	
	get_Data = request.data	
	get_Data = json.loads(get_Data)

	return Purchase_Order_Information.Delete_Purchase_Order_Information_Parent(get_Data)

if __name__ == '__main__':
	CGIHandler().run(app)