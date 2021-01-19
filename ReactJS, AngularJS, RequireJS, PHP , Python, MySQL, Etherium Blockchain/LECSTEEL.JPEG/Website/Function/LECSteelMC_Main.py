#! "T:/Python 3.8.0/python.exe"
#print("Content-Type: text/html\n")

# Main #

import collections
import pymysql
import json
import os
import simplejson

from http import cookies

Branch_Identity = '0001'

Material_Code = 'MATL'
Material_Category_Code = 'MATL-CAT'
Material_Type_Code = 'MATL-TYP'

Client_Code = 'CLT'

Supplier_Code = 'SPLR'
Supplier_Category_Code = 'SPLR-CAT'

Employee_Code = 'EMP'

Purchase_Order_Code = 'PO'
Receiving_Report_Code = 'RR'


PyMySQL_Connection = None	
PyMySQL_Cursor = None

class Main:

	def set_PyMySQL_Connection():

		global PyMySQL_Connection, PyMySQL_Cursor
		
		PyMySQL_Connection = pymysql.connect("localhost", "root", "", "db_lecsteelmc", cursorclass=pymysql.cursors.DictCursor)		
		
		PyMySQL_Cursor = PyMySQL_Connection.cursor(pymysql.cursors.DictCursor)
		
	def get_Counter_Information(set_Code):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity

		PyMySQL_Query = "SELECT Counter_Count FROM tbl_counter_information WHERE Counter_Code = '" + set_Code + "' AND Counter_Identity LIKE '%-" + Branch_Identity +"-%'"

		PyMySQL_Row_Count = PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Data = PyMySQL_Cursor.fetchall()

		if PyMySQL_Row_Count > 0:
			return PyMySQL_Data[0]['Counter_Count']

		else:
			return 'No Data'

	def set_Counter_Information(set_Code):

		global PyMySQL_Connection, PyMySQL_Cursor, Branch_Identity

		#return 'set_Code'

		PyMySQL_Query = "UPDATE tbl_counter_information SET Counter_Count = Counter_Count + 1 WHERE Counter_Code = '" + set_Code + "' AND Counter_Identity LIKE '%-" + Branch_Identity +"-%'"
		
		PyMySQL_Cursor.execute(PyMySQL_Query)

		PyMySQL_Connection.commit()

	def Image_Save(set_File, set_Folder, set_File_Name):

		"""if set_File.filename.endswith('.jpeg') or set_File.filename.endswith('.jpg'):
			get_File_Extension = '.jpeg'

		elif set_File.filename.endswith('.png'):
			get_File_Extension = '.png'

		elif set_File.filename.endswith('.gif'):
			get_File_Extension = '.gif'

		else:
			return None"""

		set_File.save('/'.join([os.path.join(os.path.dirname(os.path.abspath('./')), 'Data/Image/' + set_Folder), set_File_Name + '.jpeg']))

		return 'Data/Image/' + set_Folder + '/' + set_File_Name + '.jpeg'

Main.set_PyMySQL_Connection()

from flask import Flask, request, jsonify
from wsgiref.handlers import CGIHandler

#app = Flask(__name__)

#app.config['DEBUG'] = True
#app.config['SERVER_NAME'] = 'localhost'