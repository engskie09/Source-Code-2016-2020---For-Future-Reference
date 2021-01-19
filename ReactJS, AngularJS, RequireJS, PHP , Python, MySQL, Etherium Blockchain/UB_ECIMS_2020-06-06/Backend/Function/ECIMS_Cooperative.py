#! "C:/Python38/python.exe"

from ECIMS_Main import *

class Cooperative:

	def Select_Cooperative():

		if GLOBAL['REQUEST']['Select_Action'] == 'Select : Specific':
			Query_Select	=	f"""
									SELECT * FROM Cooperative INNER JOIN Cooperative_EconomicSurvey

									ON Cooperative.Cooperative_Identity = Cooperative_EconomicSurvey.Cooperative_Identity

									WHERE Cooperative_EconomicSurvey.Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'
								"""

		elif GLOBAL['REQUEST']['Select_Action'] == 'Select : Specific : { Cooperative_State }':
			Query_Select	=	f"""
									SELECT * FROM Cooperative

									WHERE

									Cooperative_State = '{ GLOBAL['REQUEST']['Cooperative_State'] }'
								"""

		elif GLOBAL['REQUEST']['Select_Action'] == 'Select : Specific : { Cooperative_Inserted_By }':
			Query_Select	=	f"""
									SELECT * FROM Cooperative

									WHERE

									Cooperative_Inserted_By = '{ GLOBAL['REQUEST']['Cooperative_Inserted_By'] }'
								"""
		
		elif GLOBAL['REQUEST']['Select_Action'] == 'Select : Specific : { Cooperative_State, Cooperative_Inserted_By }':
			Query_Select	=	f"""
									SELECT * FROM Cooperative

									WHERE

									Cooperative_State = '{ GLOBAL['REQUEST']['Cooperative_State'] }'

									AND

									Cooperative_Inserted_By = '{ GLOBAL['REQUEST']['Cooperative_Inserted_By'] }'
								"""

		elif GLOBAL['REQUEST']['Select_Action'] == 'Select : Specific : { Member_Identity { Member_State } }':
			Query_Select	=	f"""
									SELECT * FROM Cooperative

									WHERE

									Cooperative_Identity IN

									(
										SELECT Cooperative_Identity FROM Cooperative_OrganizationalStructure_Member

										WHERE

										Member_Identity = '{ GLOBAL['REQUEST']['Member_Identity'] }' AND Member_State = '{ GLOBAL['REQUEST']['Member_State'] }'
									)

								"""

		elif GLOBAL['REQUEST']['Select_Action'] == 'Select : Specific : { Member_Identity { Member_State } }, Cooperative_State':
			Query_Select	=	f"""
									SELECT * FROM Cooperative

									WHERE

									Cooperative_Identity IN

									(
										SELECT Cooperative_Identity FROM Cooperative_OrganizationalStructure_Member

										WHERE

										Member_Identity = '{ GLOBAL['REQUEST']['Member_Identity'] }' AND Member_State = '{ GLOBAL['REQUEST']['Member_State'] }'
									)

									AND

									Cooperative_State = '{ GLOBAL['REQUEST']['Cooperative_State'] }'

								"""

		elif GLOBAL['REQUEST']['Select_Action'] == 'Select : Specific : { Cooperative_State, { Member_Identity { Member_State = Pending | Confirmed | Declined } } }':
			Query_Select	=	f"""
									SELECT * FROM Cooperative

									WHERE

									Cooperative_Identity NOT IN

									(
										SELECT Cooperative_Identity FROM Cooperative_OrganizationalStructure_Member

										WHERE

										(Member_Identity = '{ GLOBAL['REQUEST']['Member_Identity'] }' AND Member_State = '{ GLOBAL['REQUEST']['Member_State_1'] }')

										OR

										(Member_Identity = '{ GLOBAL['REQUEST']['Member_Identity'] }' AND Member_State = '{ GLOBAL['REQUEST']['Member_State_2'] }')

										OR

										(Member_Identity = '{ GLOBAL['REQUEST']['Member_Identity'] }' AND Member_State = '{ GLOBAL['REQUEST']['Member_State_3'] }')
									)

									AND

									Cooperative_State = '{ GLOBAL['REQUEST']['Cooperative_State'] }'

								"""

		PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Select)

		PyMySQL_Data = GLOBAL['PyMySQL_Cursor'].fetchall()

		if PyMySQL_Row_Count > 0:
			return simplejson.dumps(PyMySQL_Data, indent = 4, sort_keys = True, default = str)

		else:
			return []

	def Insert_Cooperative():

		Query_Insert = f"""
							INSERT INTO Cooperative
							(
								Cooperative_Identity,
								Cooperative_Name,
								Cooperative_Parent,
								Cooperative_Background,
								Cooperative_Rationale,
								Cooperative_Type,
								Cooperative_Category,
								Cooperative_Region,
								Cooperative_Province,
								Cooperative_Locality,
								Cooperative_Office_Address,
								Cooperative_Operation_Area,
								Cooperative_Common_Bond,
								Cooperative_Member_Composition,
								Cooperative_Founder,
								Cooperative_Member_Projected_Growth,
								Cooperative_Organization_Registration,
								Cooperative_State,
								Cooperative_Inserted_By,
								Cooperative_Inserted_DateTime
							)

							VALUES
							(
								'{ GLOBAL['REQUEST']['Cooperative_Identity'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Name'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Parent'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Background'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Rationale'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Type'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Category'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Region'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Province'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Locality'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Office_Address'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Operation_Area'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Common_Bond'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Member_Composition'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Founder'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Member_Projected_Growth'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Organization_Registration'] }',
								'{ GLOBAL['REQUEST']['Cooperative_State'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Inserted_By'] }',
								'{ GLOBAL['REQUEST']['Cooperative_Inserted_DateTime'] }'
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

	def Update_Cooperative():

		if GLOBAL['REQUEST']['Update_Action'] == 'Update : Specific':
			Query_Update = f"""
								UPDATE Cooperative

								SET

								Cooperative_Name						=	'{ GLOBAL['REQUEST']['Cooperative_Name'] }',
								Cooperative_Parent						=	'{ GLOBAL['REQUEST']['Cooperative_Parent'] }',
								Cooperative_Background					=	'{ GLOBAL['REQUEST']['Cooperative_Background'] }'

								WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'
							"""

		elif GLOBAL['REQUEST']['Update_Action'] == 'Update : Specific : [ Cooperative_State ]':
			Query_Update = f"""
								UPDATE Cooperative

								SET

								Cooperative_State = '{ GLOBAL['REQUEST']['Cooperative_State'] }',
								Cooperative_Updated_By = '{ GLOBAL['REQUEST']['Cooperative_Updated_By'] }',
								Cooperative_Updated_DateTime = '{ GLOBAL['REQUEST']['Cooperative_Updated_DateTime'] }'

								WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'
							"""

		elif GLOBAL['REQUEST']['Update_Action'] == 'Update : Specific : [ Cooperative_Ethereum_Address, Cooperative_Ethereum_Key, Cooperative_Ethereum_Address_Vault, Cooperative_Ethereum_Key_Vault ]':
			Query_Update = f"""
								UPDATE Cooperative

								SET

								Cooperative_Ethereum_Address = '{ GLOBAL['REQUEST']['Cooperative_Ethereum_Address'] }',
								Cooperative_Ethereum_Key = '{ GLOBAL['REQUEST']['Cooperative_Ethereum_Key'] }',
								Cooperative_Ethereum_Address_Vault = '{ GLOBAL['REQUEST']['Cooperative_Ethereum_Address_Vault'] }',
								Cooperative_Ethereum_Key_Vault = '{ GLOBAL['REQUEST']['Cooperative_Ethereum_Key_Vault'] }',
								Cooperative_Updated_By = '{ GLOBAL['REQUEST']['Cooperative_Updated_By'] }',
								Cooperative_Updated_DateTime = '{ GLOBAL['REQUEST']['Cooperative_Updated_DateTime'] }'

								WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'
							"""

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Update)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Delete_Cooperative():

		if GLOBAL['REQUEST']['Action'] == 'Delete : All':
			Query_Delete =	f"""
								DELETE FROM Cooperative;
								DELETE FROM Cooperative_EconomicSurvey;
								DELETE FROM Cooperative_ShareCapital;
								DELETE FROM Cooperative_EconomicAspect;
								DELETE FROM Cooperative_FinancialAspect;
								DELETE FROM Cooperative_TechnicalAspect;
								DELETE FROM Cooperative_OrganizationalStructure;
								DELETE FROM Cooperative_OrganizationalStructure_Member;
								DELETE FROM Cooperative_OrganizationalStructure_Member_Position;
								DELETE FROM Cooperative_OrganizationalStructure_Member_Chart;
								DELETE FROM Cooperative_OrganizationalStructure_Committee;
								DELETE FROM Cooperative_OrganizationalStructure_Committee_Member;
							"""

		elif GLOBAL['REQUEST']['Action'] == 'Delete : Specific':
			Query_Delete =	f"""
								DELETE FROM Cooperative												WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }';
								DELETE FROM Cooperative_EconomicSurvey								WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }';
								DELETE FROM Cooperative_ShareCapital								WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }';
								DELETE FROM Cooperative_EconomicAspect								WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }';
								DELETE FROM Cooperative_FinancialAspect								WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }';
								DELETE FROM Cooperative_TechnicalAspect								WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }';
								DELETE FROM Cooperative_OrganizationalStructure 					WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }';
								DELETE FROM Cooperative_OrganizationalStructure_Member				WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }';
								DELETE FROM Cooperative_OrganizationalStructure_Member_Position		WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }';
								DELETE FROM Cooperative_OrganizationalStructure_Member_Chart		WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }';
								DELETE FROM Cooperative_OrganizationalStructure_Committee			WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }';
								DELETE FROM Cooperative_OrganizationalStructure_Committee_Member	WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }';
							"""

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Delete)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False
		return True

	def Insert_Cooperative_EconomicSurvey():

		Query_Insert =	f"""
							INSERT INTO Cooperative_EconomicSurvey
							(
								Cooperative_Identity,
								EconomicSurvey_Description
							)

							VALUES
							(
								'{ GLOBAL['REQUEST']['Cooperative_Identity'] }',
								'{ GLOBAL['REQUEST']['EconomicSurvey_Description'] }'
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

	def Update_Cooperative_EconomicSurvey():

		Query_Update =	f"""
							UPDATE Cooperative_EconomicSurvey

							SET

							EconomicSurvey_Description = '{ GLOBAL['REQUEST']['EconomicSurvey_Description'] }'

							WHERE

							Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'
						"""					
		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Update)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Insert_Cooperative_ShareCapital():

		Query_Insert = f"""
							INSERT INTO Cooperative_ShareCapital
							(
								Cooperative_Identity,
								ShareCapital_Authorized,
								ShareCapital_Issued,
								ShareCapital_Unissued,
								ShareCapital_Subscribed,
								ShareCapital_Unsubscribed,
								`ShareCapital_Called-Up`,
								ShareCapital_Uncalled,
								`ShareCapital_Paid-Up`,
								ShareCapital_Unpaid,
								ShareCapital_Reserve,
								ShareCapital_Par_Value
							)

							VALUES
							(
								'{ GLOBAL['REQUEST']['Cooperative_Identity'] }',
								'{ GLOBAL['REQUEST']['ShareCapital_Authorized'] }',
								'{ GLOBAL['REQUEST']['ShareCapital_Issued'] }',
								'{ GLOBAL['REQUEST']['ShareCapital_Unissued'] }',
								'{ GLOBAL['REQUEST']['ShareCapital_Subscribed'] }',
								'{ GLOBAL['REQUEST']['ShareCapital_Unsubscribed'] }',
								'{ GLOBAL['REQUEST']['ShareCapital_Called-Up'] }',
								'{ GLOBAL['REQUEST']['ShareCapital_Uncalled'] }',
								'{ GLOBAL['REQUEST']['ShareCapital_Paid-Up'] }',
								'{ GLOBAL['REQUEST']['ShareCapital_Unpaid'] }',
								'{ GLOBAL['REQUEST']['ShareCapital_Reserve'] }',
								'{ GLOBAL['REQUEST']['ShareCapital_Par_Value'] }'
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

	def Update_Cooperative_ShareCapital():

		Query_Update = f"""
							UPDATE Cooperative_ShareCapital

							SET

							ShareCapital_Authorized = '{ GLOBAL['REQUEST']['ShareCapital_Authorized'] }',
							ShareCapital_Issued = '{ GLOBAL['REQUEST']['ShareCapital_Issued'] }',
							ShareCapital_Unissued = '{ GLOBAL['REQUEST']['ShareCapital_Unissued'] }',
							ShareCapital_Subscribed = '{ GLOBAL['REQUEST']['ShareCapital_Subscribed'] }',
							ShareCapital_Unsubscribed = '{ GLOBAL['REQUEST']['ShareCapital_Unsubscribed'] }',
							ShareCapital_Called-Up = '{ GLOBAL['REQUEST']['ShareCapital_Called-Up'] }',
							ShareCapital_Uncalled = '{ GLOBAL['REQUEST']['ShareCapital_Uncalled'] }',
							ShareCapital_Paid-Up = '{ GLOBAL['REQUEST']['ShareCapital_Paid-Up'] }',
							ShareCapital_Unpaid = '{ GLOBAL['REQUEST']['ShareCapital_Unpaid'] }',
							ShareCapital_Reserve = '{ GLOBAL['REQUEST']['ShareCapital_Reserve'] }',
							ShareCapital_Par_Value = '{ GLOBAL['REQUEST']['ShareCapital_Par_Value'] }'

							WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'
						"""

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Update)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Insert_Cooperative_EconomicAspect():

		Query_Insert = f"""
							INSERT INTO Cooperative_EconomicAspect
							(
								Cooperative_Identity,
								EconomicAspect_Identical_Cooperative_Plan,
								EconomicAspect_Strategy,
								EconomicAspect_Target_Market,
								EconomicAspect_Activity
							)

							VALUES
							(
								'{ GLOBAL['REQUEST']['Cooperative_Identity'] }',
								'{ GLOBAL['REQUEST']['EconomicAspect_Identical_Cooperative_Plan'] }',
								'{ GLOBAL['REQUEST']['EconomicAspect_Strategy'] }',
								'{ GLOBAL['REQUEST']['EconomicAspect_Target_Market'] }',
								'{ GLOBAL['REQUEST']['EconomicAspect_Activity'] }'
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

	def Update_Cooperative_EconomicAspect():

		Query_Update = f"""
							UPDATE Cooperative_EconomicAspect

							SET

							EconomicAspect_Identical_Cooperative_Plan = '{ GLOBAL['REQUEST']['EconomicAspect_Identical_Cooperative_Plan'] }',
							EconomicAspect_Strategy = '{ GLOBAL['REQUEST']['EconomicAspect_Strategy'] }',
							EconomicAspect_Target_Market = '{ GLOBAL['REQUEST']['EconomicAspect_Target_Market'] }',
							EconomicAspect_Activity = '{ GLOBAL['REQUEST']['EconomicAspect_Activity'] }'

							WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'
						"""

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Update)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Insert_Cooperative_FinancialAspect():

		Query_Insert = f"""
							INSERT INTO Cooperative_FinancialAspect
							(
								Cooperative_Identity,
								FinancialAspect_Capitalization_Generate_Capital,
								FinancialAspect_Capitalization_Initial_Capital,
								FinancialAspect_Capitalization_Internal_Capital_Strategy,
								FinancialAspect_Revenue_Projected,
								FinancialAspect_Expense_Estimated,
								FinancialAspect_Organization_Investment

							)

							VALUES
							(
								'{ GLOBAL['REQUEST']['Cooperative_Identity'] }',
								'{ GLOBAL['REQUEST']['FinancialAspect_Capitalization_Generate_Capital'] }',
								'{ GLOBAL['REQUEST']['FinancialAspect_Capitalization_Initial_Capital'] }',
								'{ GLOBAL['REQUEST']['FinancialAspect_Capitalization_Internal_Capital_Strategy'] }',
								'{ GLOBAL['REQUEST']['FinancialAspect_Revenue_Projected'] }',
								'{ GLOBAL['REQUEST']['FinancialAspect_Expense_Estimated'] }',
								'{ GLOBAL['REQUEST']['FinancialAspect_Organization_Investment'] }'
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

	def Update_Cooperative_FinancialAspect():

		Query_Update = f"""
							UPDATE Cooperative_FinancialAspect

							SET

							FinancialAspect_Capitalization_Generate_Capital = '{ GLOBAL['REQUEST']['FinancialAspect_Capitalization_Generate_Capital'] }',
							FinancialAspect_Capitalization_Initial_Capital = '{ GLOBAL['REQUEST']['FinancialAspect_Capitalization_Initial_Capital'] }',
							FinancialAspect_Capitalization_Internal_Capital_Strategy = '{ GLOBAL['REQUEST']['FinancialAspect_Capitalization_Internal_Capital_Strategy'] }',
							FinancialAspect_Revenue_Projected = '{ GLOBAL['REQUEST']['FinancialAspect_Revenue_Projected'] }',
							FinancialAspect_Expense_Estimated = '{ GLOBAL['REQUEST']['FinancialAspect_Expense_Estimated'] }'
							FinancialAspect_Organization_Investment = '{ GLOBAL['REQUEST']['FinancialAspect_Organization_Investment'] }'

							WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'
						"""

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Update)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Insert_Cooperative_TechnicalAspect():

		Query_Insert = f"""
							INSERT INTO Cooperative_TechnicalAspect
							(
								Cooperative_Identity,
								TechnicalAspect_Equipment,
								TechnicalAspect_Machinery,
								TechnicalAspect_Facility,
								TechnicalAspect_Procurement_Mode,
								TechnicalAspect_Operator_Background
							)

							VALUES
							(
								'{ GLOBAL['REQUEST']['Cooperative_Identity'] }',
								'{ GLOBAL['REQUEST']['TechnicalAspect_Equipment'] }',
								'{ GLOBAL['REQUEST']['TechnicalAspect_Machinery'] }',
								'{ GLOBAL['REQUEST']['TechnicalAspect_Facility'] }',
								'{ GLOBAL['REQUEST']['TechnicalAspect_Procurement_Mode'] }',
								'{ GLOBAL['REQUEST']['TechnicalAspect_Operator_Background'] }'
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

	def Update_Cooperative_TechnicalAspect():

		Query_Update = f"""
							UPDATE Cooperative_TechnicalAspect

							SET

							TechnicalAspect_Equipment = '{ GLOBAL['REQUEST']['TechnicalAspect_Equipment'] }',
							TechnicalAspect_Machinery = '{ GLOBAL['REQUEST']['TechnicalAspect_Machinery'] }',
							TechnicalAspect_Facility = '{ GLOBAL['REQUEST']['TechnicalAspect_Facility'] }',
							TechnicalAspect_Procurement_Mode = '{ GLOBAL['REQUEST']['TechnicalAspect_Procurement_Mode'] }',
							TechnicalAspect_Operator_Background = '{ GLOBAL['REQUEST']['TechnicalAspect_Operator_Background'] }'

							WHERE Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'
						"""

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Update)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Select_Cooperative_Category():

		if GLOBAL['REQUEST']['Select_Action'] == 'Select : All':
			Query_Select = f"""
								SELECT * FROM Cooperative_Category
							"""

		PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Select)

		PyMySQL_Data = GLOBAL['PyMySQL_Cursor'].fetchall()

		if PyMySQL_Row_Count > 0:
			return simplejson.dumps(PyMySQL_Data, indent = 4, sort_keys = True, default = str)

		else:
			return []

	def Insert_Cooperative_Category():

		Query_Insert = f"""
							INSERT INTO Cooperative_Category
							(
								Category_Identity,
								Category_Name,
								Category_Description
							)

							VALUES
							(
								'{ GLOBAL['REQUEST']['Category_Identity'] }',
								'{ GLOBAL['REQUEST']['Category_Name'] }',
								'{ GLOBAL['REQUEST']['Category_Description'] }'
							)
						"""
		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Insert)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			Main.Update_Counter(GLOBAL['Cooperative_Category_Counter_Code'])
			return True

		else:
			return False

	def Delete_Cooperative_Category():

		Query_Delete = "DELETE FROM Cooperative_Category"

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Delete)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Select_Cooperative_Type():

		if GLOBAL['REQUEST']['Select_Action'] == 'Select : All':
			Query_Select = f"""
								SELECT * FROM Cooperative_Type
							"""

		PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Select)

		PyMySQL_Data = GLOBAL['PyMySQL_Cursor'].fetchall()

		if PyMySQL_Row_Count > 0:
			return simplejson.dumps(PyMySQL_Data, indent = 4, sort_keys = True, default = str)

		else:
			return []

	def Insert_Cooperative_Type():

		Query_Insert = f"""
							INSERT INTO Cooperative_Type
							(
								Type_Identity,
								Type_Name,
								Type_Description
							)

							VALUES
							(
								'{ GLOBAL['REQUEST']['Type_Identity'] }',
								'{ GLOBAL['REQUEST']['Type_Name'] }',
								'{ GLOBAL['REQUEST']['Type_Description'] }'
							)
						"""
		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Insert)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			Main.Update_Counter(GLOBAL['Cooperative_Type_Counter_Code'])
			return True

		else:
			return False

	def Delete_Cooperative_Type():

		Query_Delete = "DELETE FROM Cooperative_Type"

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Delete)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Select_Cooperative_OperationArea():

		if GLOBAL['REQUEST']['Select_Action'] == 'Select : All':
			Query_Select = f"""
								SELECT * FROM Cooperative_OperationArea
							"""

		PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Select)

		PyMySQL_Data = GLOBAL['PyMySQL_Cursor'].fetchall()

		if PyMySQL_Row_Count > 0:
			return simplejson.dumps(PyMySQL_Data, indent = 4, sort_keys = True, default = str)

		else:
			return []

	def Insert_Cooperative_OperationArea():

		Query_Insert = f"""
							INSERT INTO Cooperative_OperationArea
							(
								OperationArea_Identity,
								OperationArea_Name,
								OperationArea_Description
							)

							VALUES
							(
								'{ GLOBAL['REQUEST']['OperationArea_Identity'] }',
								'{ GLOBAL['REQUEST']['OperationArea_Name'] }',
								'{ GLOBAL['REQUEST']['OperationArea_Description'] }'
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

	def Delete_Cooperative_OperationArea():

		Query_Delete = "DELETE FROM Cooperative_OperationArea"

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Delete)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Select_Cooperative_CommonBond():

		if GLOBAL['REQUEST']['Select_Action'] == 'Select : All':
			Query_Select = f"""
								SELECT * FROM Cooperative_CommonBond
							"""

		PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Select)

		PyMySQL_Data = GLOBAL['PyMySQL_Cursor'].fetchall()

		if PyMySQL_Row_Count > 0:
			return simplejson.dumps(PyMySQL_Data, indent = 4, sort_keys = True, default = str)

		else:
			return []

	def Insert_Cooperative_CommonBond():

		Query_Insert = f"""
							INSERT INTO Cooperative_CommonBond
							(
								CommonBond_Identity,
								CommonBond_Name,
								CommonBond_Description
							)

							VALUES
							(
								'{ GLOBAL['REQUEST']['CommonBond_Identity'] }',
								'{ GLOBAL['REQUEST']['CommonBond_Name'] }',
								'{ GLOBAL['REQUEST']['CommonBond_Description'] }'
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

	def Delete_Cooperative_CommonBond():

		Query_Delete = "DELETE FROM Cooperative_CommonBond"

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Delete)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Select_Cooperative_Capitalization():

		if GLOBAL['REQUEST']['Select_Action'] == 'Select : All':
			Query_Select = f"""
								SELECT * FROM Cooperative_Capitalization
							"""

		PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Select)

		PyMySQL_Data = GLOBAL['PyMySQL_Cursor'].fetchall()

		if PyMySQL_Row_Count > 0:
			return simplejson.dumps(PyMySQL_Data, indent = 4, sort_keys = True, default = str)

		else:
			return []

	def Insert_Cooperative_Capitalization():

		Query_Insert = f"""
							INSERT INTO Cooperative_Capitalization
							(
								Capitalization_Identity,
								Capitalization_Name,
								Capitalization_Description
							)

							VALUES
							(
								'{ GLOBAL['REQUEST']['Capitalization_Identity'] }',
								'{ GLOBAL['REQUEST']['Capitalization_Name'] }',
								'{ GLOBAL['REQUEST']['Capitalization_Description'] }'
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

	def Delete_Cooperative_Capitalization():

		Query_Delete = "DELETE FROM Cooperative_Capitalization"

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Delete)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Select_Cooperative_OrganizationalStructure_Member():

		if GLOBAL['REQUEST']['Select_Action'] == 'Select : All':
			Query_Select	=	f"""
									SELECT * FROM Cooperative_OrganizationalStructure_Member
								"""

		elif GLOBAL['REQUEST']['Select_Action'] == 'Select : Specific : { Cooperative_Identity, Member_Identity }':
			Query_Select	=	f"""
									SELECT * FROM Cooperative_OrganizationalStructure_Member

									WHERE

									Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'

									AND

									Member_Identity = '{ GLOBAL['REQUEST']['Member_Identity'] }'
								"""

		elif GLOBAL['REQUEST']['Select_Action'] == 'Select : Specific : { Member_Identity, Member_State = Confirmed }':
			Query_Select	=	f"""
									SELECT * FROM Cooperative_OrganizationalStructure_Member

									WHERE

									Member_Identity = '{ GLOBAL['REQUEST']['Member_Identity'] }'

									AND
									
									Member_State = '{ GLOBAL['REQUEST']['Member_State'] }'
								"""

		elif GLOBAL['REQUEST']['Select_Action'] == 'Select : Specific : { Member_Identity }':
			Query_Select	=	f"""
									SELECT * FROM Cooperative_OrganizationalStructure_Member

									WHERE

									Member_Identity = '{ GLOBAL['REQUEST']['Member_Identity'] }'
								"""

		PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Select)

		PyMySQL_Data = GLOBAL['PyMySQL_Cursor'].fetchall()

		if PyMySQL_Row_Count > 0:
			return simplejson.dumps(PyMySQL_Data, indent = 4, sort_keys = True, default = str)

		else:
			return []

	def Insert_Cooperative_OrganizationalStructure_Member():

		Query_Insert = f"""
							INSERT INTO Cooperative_OrganizationalStructure_Member
							(
								Cooperative_Identity,
								Member_Identity,
								Member_Position,
								Member_Appointment_Status,
								Member_Eligibility,
								Member_Compensation,
								Member_State
							)

							VALUES
							(
								'{ GLOBAL['REQUEST']['Cooperative_Identity'] }',
								'{ GLOBAL['REQUEST']['Member_Identity'] }',
								'{ GLOBAL['REQUEST']['Member_Position'] }',
								'{ GLOBAL['REQUEST']['Member_Appointment_Status'] }',
								'{ GLOBAL['REQUEST']['Member_Eligibility'] }',
								'{ GLOBAL['REQUEST']['Member_Compensation'] }',
								'{ GLOBAL['REQUEST']['Member_State'] }'
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

	def Update_Cooperative_OrganizationalStructure_Member():

		if GLOBAL['REQUEST']['Update_Action'] == 'Update : Specific : [ Member_State ] : { Cooperative_Identity, Member_Identity }':
			Query_Update = f"""
								UPDATE Cooperative_OrganizationalStructure_Member

								SET

								Member_State = '{ GLOBAL['REQUEST']['Member_State'] }'
							
								WHERE

								Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'

								AND

								Member_Identity = '{ GLOBAL['REQUEST']['Member_Identity'] }'
							"""

		elif GLOBAL['REQUEST']['Update_Action'] == 'Update : Specific : [ Member_Position, Member_State ] : { Cooperative_Identity, Member_Identity }':
			Query_Update = f"""
								UPDATE Cooperative_OrganizationalStructure_Member

								SET

								Member_Position = '{ GLOBAL['REQUEST']['Member_Position'] }',
								Member_State = '{ GLOBAL['REQUEST']['Member_State'] }'
							
								WHERE

								Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'

								AND

								Member_Identity = '{ GLOBAL['REQUEST']['Member_Identity'] }'
							"""

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Update)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False

	def Delete_Cooperative_OrganizationalStructure_Member():

		if GLOBAL['REQUEST']['Delete_Action'] == 'Delete : Specific : { Cooperative_Identity, Member_Identity }':
			Query_Delete	=	f"""
									DELETE FROM Cooperative_OrganizationalStructure_Member

									WHERE

									Cooperative_Identity = '{ GLOBAL['REQUEST']['Cooperative_Identity'] }'

									AND

									Member_Identity = '{ GLOBAL['REQUEST']['Member_Identity'] }'
								"""

		try:
			PyMySQL_Row_Count = GLOBAL['PyMySQL_Cursor'].execute(Query_Delete)
			GLOBAL['PyMySQL_Connection'].commit()

		except Exception as set_Exception:
			return str(set_Exception)

		if PyMySQL_Row_Count > 0:
			return True

		else:
			return False