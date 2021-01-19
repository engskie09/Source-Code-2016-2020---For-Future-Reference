#! "C:/Python38/python.exe"

from ECIMS_Main import *

class Philippines:

	def Select_Philippines_Region():

		if GLOBAL['REQUEST']['Select_Action'] == 'Select : All':
			Query_Select = f"""
								SELECT * FROM Philippines_Region
							"""

		PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Select)

		PyMySQL_Data = GLOBAL['PyMySQL_Cursor'].fetchall()

		if PyMySQL_Row_Count > 0:
			return simplejson.dumps(PyMySQL_Data, indent = 4, sort_keys = True, default = str)

		else:
			return []

	def Insert_Philippines_Region():

		Query_Insert = f"""
							INSERT INTO Philippines_Region
							(
								Region_Identity,
								Region_Name
							)
							VALUES
							(
								'{ GLOBAL['REQUEST']['Region_Identity'] }',
								'{ GLOBAL['REQUEST']['Region_Name'] }'
							)
						"""
		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Insert)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Delete_Philippines_Region():

		Query_Delete = "DELETE FROM Philippines_Region"

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Delete)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Select_Philippines_Region_Province():

		if GLOBAL['REQUEST']['Select_Action'] == 'Select : All':
			Query_Select = f"""
								SELECT * FROM Philippines_Region_Province
							"""

		PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Select)

		PyMySQL_Data = GLOBAL['PyMySQL_Cursor'].fetchall()

		if PyMySQL_Row_Count > 0:
			return simplejson.dumps(PyMySQL_Data, indent = 4, sort_keys = True, default = str)

		else:
			return []

	def Insert_Philippines_Region_Province():

		Query_Insert = f"""
							INSERT INTO Philippines_Region_Province
							(
								Province_Identity,
								Province_Name,
								Province_Region
							)
							VALUES
							(
								'{ GLOBAL['REQUEST']['Province_Identity'] }',
								'{ GLOBAL['REQUEST']['Province_Name'] }',
								'{ GLOBAL['REQUEST']['Region_Identity'] }'
							)
						"""
		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Insert)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Delete_Philippines_Region_Province():

		Query_Delete = "DELETE FROM Philippines_Region_Province"

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Delete)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Select_Philippines_Region_Province_Locality():

		if GLOBAL['REQUEST']['Select_Action'] == 'Select : All':
			Query_Select = f"""
								SELECT * FROM Philippines_Region_Province_Locality
							"""

		PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Select)

		PyMySQL_Data = GLOBAL['PyMySQL_Cursor'].fetchall()

		if PyMySQL_Row_Count > 0:
			return simplejson.dumps(PyMySQL_Data, indent = 4, sort_keys = True, default = str)

		else:
			return []

	def Insert_Philippines_Region_Province_Locality():

		Query_Insert = f"""
							INSERT INTO Philippines_Region_Province_Locality
							(
								Locality_Identity,
								Locality_Name,
								Locality_Region,
								Locality_Province
							)
							VALUES
							(
								'{ GLOBAL['REQUEST']['Locality_Identity'] }',
								'{ GLOBAL['REQUEST']['Locality_Name'] }',
								'{ GLOBAL['REQUEST']['Region_Identity'] }',
								'{ GLOBAL['REQUEST']['Province_Identity'] }'
							)
						"""
		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Insert)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Delete_Philippines_Region_Province_Locality():

		Query_Delete = "DELETE FROM Philippines_Region_Province_Locality"

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Delete)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Select_Philippines_Organization():

		if GLOBAL['REQUEST']['Select_Action'] == 'Select : All':
			Query_Select = f"""
								SELECT * FROM Philippines_Organization
							"""

		PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Select)

		PyMySQL_Data = GLOBAL['PyMySQL_Cursor'].fetchall()

		if PyMySQL_Row_Count > 0:
			return simplejson.dumps(PyMySQL_Data, indent = 4, sort_keys = True, default = str)

		else:
			return []

	def Insert_Philippines_Organization():

		Query_Insert = f"""
							INSERT INTO Philippines_Organization
							(
								Organization_Identity,
								Organization_Name,
								Organization_Abbreviation,
								Organization_Description
							)
							VALUES
							(
								'{ GLOBAL['REQUEST']['Organization_Identity'] }',
								'{ GLOBAL['REQUEST']['Organization_Name'] }',
								'{ GLOBAL['REQUEST']['Organization_Abbreviation'] }',
								'{ GLOBAL['REQUEST']['Organization_Description'] }'
							)
						"""
		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Insert)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Delete_Philippines_Organization():

		Query_Delete = "DELETE FROM Philippines_Organization"

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Delete)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False