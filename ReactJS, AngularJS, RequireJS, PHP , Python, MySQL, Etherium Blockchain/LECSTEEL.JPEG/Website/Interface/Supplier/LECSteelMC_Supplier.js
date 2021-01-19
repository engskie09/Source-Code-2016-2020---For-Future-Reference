/*-------------Engskie09_Supplier-----------------*/
/*-------------Engskie09_Supplier-----------------*/
/*-------------Engskie09_Supplier-----------------*/
/*-------------Engskie09_Supplier-----------------*/
/*-------------Engskie09_Supplier-----------------*/

export function LECSteelMC_Supplier_Controller($rootScope, $scope, $compile, Supplier_Information)
{
    angular.element('.selectpicker').selectpicker()

    angular.element('select').on('change', function()
    {
        angular.element('#' + this.id).parent().removeClass('is-invalid')        
    })
    

    $scope.set_Image_Upload_Preview('Supplier_Image', 'Supplier_Image_Content')

    var tbl_Supplier_Information = angular.element('#tbl_Supplier_Information')

    $scope.Module_Loading_Visible = true
    $scope.LECSteelMC_Supplier_Visible = false

    var get_Element_Supplier_Category = angular.element('#Supplier_Category_Identity_List')

    get_Element_Supplier_Category.empty()
    get_Element_Supplier_Category.append("<option selected disabled>Select Category</option>")           

    Supplier_Information.Select_Supplier_Category_Information(({'Action' :  'Select : All'}),
    function(set_Callback_Data)
    {
        angular.forEach(JSON.parse(set_Callback_Data), function(set_Value, set_Key)
        {
            console.log(set_Value['Category_Identity'])
            get_Element_Supplier_Category.append("<option value = '" + set_Value['Category_Identity'] + "' data-subtext = '" + set_Value['Category_Description'] + "'>" + set_Value['Category_Name'] + "</option>")
        })

        get_Element_Supplier_Category.selectpicker('refresh')        
    })

	$rootScope.set_Supplier_Action = function(set_Action)
    {
        angular.element('#frm_Supplier_Information').trigger('reset')

        angular.element('#Supplier_Image_Content').attr('src', null)

        get_Element_Supplier_Category.change(function()
        {
            angular.element(this).parent().removeClass('is-invalid')
        })

        get_Element_Supplier_Category.val(0).change()


        angular.element('#Supplier_Status').change(function()
        {
            angular.element(this).parent().removeClass('is-invalid')
        })

        angular.element('#Supplier_Status').change().val(0).change()

        var get_Element = angular.element('#btn_Action')
        
        if (set_Action == 'Insert')
            get_Element.text('Add')      

        else if (set_Action == 'Update')            
            get_Element.text('Edit')
    }

    $scope.Select_Supplier_Information = function(set_Action, set_Object)
    {

        if (set_Action == 'Select : All')
            set_Action = ({'Action' :  set_Action})

        else if (set_Action == 'Select : Specific')
            set_Action = ({'Action' : set_Action,  'Supplier_Identity' : $scope.get_Element_Identity(set_Object)})

        else if (set_Action == 'Select : Specific : Supplier_Code { Supplier_Code }')
            set_Action = ({'Action' :  set_Action, 'Supplier_Code' : set_Object})

        Supplier_Information.Select_Supplier_Information(set_Action,

        function(set_Callback_Data)
        {
            if (set_Action['Action'] == 'Select : All')
            {

                $scope.Module_Loading_Visible = true
                $scope.LECSteelMC_Supplier_Visible = false

                setTimeout(function () 
                {
                    tbl_Supplier_Information.DataTable(
                    {
                        data: JSON.parse(set_Callback_Data),

                        autoWidth: false,

                        columnDefs: 
                        [
                          { className : 'dt-center', targets : '_all'}                  
                        ],
                        
                        oLanguage : { "sSearch": '<a class="btn searchBtn" id="searchBtn"><i class="fa fa-search"></i></a>' },
                        
                        columns:
                        [
                            {   orderable : false, 
                                data : null,
                                width : '8em',
                                render : function (data)
                                { 
                                    return  "<img class='rounded-circle' style = 'height: 8em' alt='No Image' src='" + data['Supplier_Image_Path'] + "''>"
                                }
                            },                            
                            {   data : "Supplier_Name"   },
                            {   data : "Supplier_Code"   },
                            {   data : "Supplier_Contact_FullName"  },
                            {   data : "Supplier_Contact_LandlineNumber"  },
                            {   data : "Supplier_Contact_MobileNumber"  },
                            {   data : "Supplier_Contact_EmailAddress"  },
                            {   data : "Supplier_Contact_FaxNumber"  },
                            {   data : "Supplier_Contact_BusinessAddress"  },
                            {   data : "Supplier_Term"  },
                            
                            {   orderable : false, 
                                data : null,
                                width : '5em',
                                render : function (data)
                                { 
                                    return  "<button class = 'btn btn-outline-success mr-1 col-md' id = '" + data['Supplier_Identity'] + "' ng-click = '" + 'Select_Supplier_Information("Select : Specific", $event);'  + "'>Edit</button>" +
                                            "<hr>" +
                                            "<button class = 'btn btn-outline-danger col-md' id = '" + data['Supplier_Identity'] + "' ng-click = '" + 'Manage_Supplier_Information($event, "Delete_Supplier_Information")' + "'>Delete</button>"
                                }
                            }                           
                        ],

                        createdRow: function(row, data, index)
                        {
                            $compile(row)($scope);
                        }
                    })

                    $scope.Module_Loading_Visible = false
                    $scope.LECSteelMC_Supplier_Visible = true                  
                    

                }, 500)

                
            }

            else if (set_Action['Action'] == 'Select : Specific') 
            {  

                
                var get_JSON = JSON.parse(set_Callback_Data)
                $scope.set_Supplier_Action('Update')                
                angular.element('#Supplier_Identity').val(get_JSON[0]["Supplier_Identity"])
                angular.element('#Supplier_Code').val(get_JSON[0]["Supplier_Code"])

                $scope.Supplier_Code_Temporary = get_JSON[0]["Supplier_Code"]

                angular.element('#Supplier_Category_Identity_List').val(get_JSON[0]["Supplier_Category_Identity_List"])
                angular.element('#Supplier_Name').val(get_JSON[0]["Supplier_Name"])
                angular.element('#Supplier_Contact_FullName').val(get_JSON[0]["Supplier_Contact_FullName"])
                angular.element('#Supplier_Contact_LandlineNumber').val(get_JSON[0]["Supplier_Contact_LandlineNumber"])
                angular.element('#Supplier_Contact_MobileNumber').val(get_JSON[0]["Supplier_Contact_MobileNumber"])
                angular.element('#Supplier_Contact_EmailAddress').val(get_JSON[0]["Supplier_Contact_EmailAddress"])
                angular.element('#Supplier_Contact_FaxNumber').val(get_JSON[0]["Supplier_Contact_FaxNumber"])
                angular.element('#Supplier_Contact_BusinessAddress').val(get_JSON[0]["Supplier_Contact_BusinessAddress"])
                angular.element('#Supplier_Term').val(get_JSON[0]["Supplier_Term"])


                angular.element('#Supplier_Category_Identity_List').val(get_JSON[0]["Supplier_Category_Identity_List"]).change()
                
                angular.element('#Supplier_Status').val(get_JSON[0]["Supplier_Status"]).change()

                angular.element('#Supplier_Image_Content').attr('src', get_JSON[0]['Supplier_Image_Path'])

                $rootScope.Supplier_List_Visible = false
                $rootScope.Supplier_Manage_Visible = true

            }

            else if(set_Action['Action'] == 'Select : Specific : Supplier_Code { Supplier_Code }')
            {
                console.log(set_Callback_Data)

                if(set_Callback_Data) 
                {
                    if ($scope.Supplier_Code_Temporary == $scope.Supplier_Code)
                    {
                        $scope.Supplier_Code_Availability = true
                        angular.element('#Supplier_Code').removeClass('is-invalid-custom')
                    }
                    
                    else
                    {
                        $scope.Supplier_Code_Availability = false
                        angular.element('#Supplier_Code').addClass('is-invalid-custom')
                    }                   
                }             

                else
                {   
                    $scope.Supplier_Code_Availability = true
                    angular.element('#Supplier_Code').removeClass('is-invalid-custom')                    
                }

            }
        })
    }

    $scope.Manage_Supplier_Information = function(set_Element, set_Action)
    {
        if (set_Action == 'Delete_Supplier_Information')
        {
            $scope.get_Dialog_Choice.Dialog.Title = 'Are you sure?'

            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-warning'
            $scope.get_Dialog_Choice.Alert.Title = 'Are you sure'
            $scope.get_Dialog_Choice.Alert.Message = 'that you want to delete this Supplier?'
            $scope.get_Dialog_Choice.Alert.Visible = true

            $scope.get_Dialog_Choice.Dialog.Closeable = false

            $scope.get_Dialog_Choice.btn_Ok.Visible = true
            $scope.get_Dialog_Choice.btn_No.Visible = true

            $scope.get_Dialog_Choice.Show()

            let promise = new Promise(function(resolve, reject)
            {                
                angular.element('#btn_Ok_' + $scope.get_Dialog_Choice.Identity).click(function()
                {
                    resolve($scope.get_Element_Identity(set_Element))
                })

                angular.element('#btn_No_' + $scope.get_Dialog_Choice.Identity).click(function()
                {                    
                    resolve(null)
                })

            }).then(function(set_Value)
            {
                if (set_Value != null)
                {
                    $scope.get_Dialog_Choice.Dialog.Title = 'Please Wait...'
                    $scope.get_Dialog_Choice.Loading.Visible = true
                    $scope.get_Dialog_Choice.btn_Ok.Visible = false
                    $scope.get_Dialog_Choice.btn_No.Visible = false

                    var get_Data = ({'Action' :  'Delete : Specific', 'Supplier_Identity' : set_Value})

                    Supplier_Information.Manage_Supplier_Information(set_Action, JSON.stringify(get_Data),
                    function(set_Callback_Data)
                    {
                        if (set_Callback_Data)
                        {
                            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-success'
                            $scope.get_Dialog_Choice.Alert.Title = 'Success...'
                            $scope.get_Dialog_Choice.Alert.Message = 'Supplier has been deleted...'
                            $scope.get_Dialog_Choice.Alert.Visible = true
                            
                            tbl_Supplier_Information.DataTable().destroy()

                            $scope.Select_Supplier_Information('Select : All', null)
                        }

                        else
                        {
                            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-primary'
                            $scope.get_Dialog_Choice.Alert.Title = 'Cannot Process...'
                            $scope.get_Dialog_Choice.Alert.Message = 'Supplier cannot be deleted...'
                            $scope.get_Dialog_Choice.Alert.Visible = true
                        }

                        setTimeout(function () 
                        {
                            $scope.get_Dialog_Choice.Hide()

                        }, 1000)
                    })
                }

                else
                    $scope.get_Dialog_Choice.Hide()
            })
        }        

        else
        {
            if ($scope.Supplier_Code_Availability == false)
            {   
                $scope.get_Dialog_Wait.Dialog.Title = 'Please Wait...'
                $scope.get_Dialog_Wait.Loading.Visible = true
                $scope.get_Dialog_Wait.btn_Ok.Visible = false
                $scope.get_Dialog_Wait.btn_No.Visible = false
                $scope.get_Dialog_Wait.Dialog.Closeable = false

                $scope.get_Dialog_Wait.Show()  

                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-primary'
                $scope.get_Dialog_Wait.Alert.Title = 'Cannot Process...'
                $scope.get_Dialog_Wait.Alert.Message = 'Supplier Code Already Exist'
                $scope.get_Dialog_Wait.Alert.Visible = true

                setTimeout(function () 
                {
                    $scope.get_Dialog_Wait.Hide()                                

                }, 1000)

                return
            }
            
            angular.element('#frm_Supplier_Information').validate(
            {

                errorPlacement: function (error, element)
                {

                    if (element.hasClass('selectpicker'))
                    {
                        element.parent().addClass('is-invalid')                        
                    }

                },

                errorClass:'is-invalid-custom',

                submitHandler: function()
                {                    
                    $scope.get_Dialog_Wait.Dialog.Title = 'Please Wait...'
                    $scope.get_Dialog_Wait.Loading.Visible = true
                    $scope.get_Dialog_Wait.btn_Ok.Visible = false
                    $scope.get_Dialog_Wait.btn_No.Visible = false
                    $scope.get_Dialog_Wait.Dialog.Closeable = false

                    $scope.get_Dialog_Wait.Show()                    

                    var get_Element = angular.element('#' + $scope.get_Element_Identity(set_Element))

                    if (get_Element.text() == 'Add')
                        set_Action = 'Insert_Supplier_Information'

                        
                    

                    else if (get_Element.text() == 'Edit')
                        set_Action = 'Update_Supplier_Information'

                    setTimeout(function () 
                    {
                        var get_Data = new FormData(angular.element(document.querySelector('#frm_Supplier_Information'))[0])
                    
                        Supplier_Information.Manage_Supplier_Information(set_Action, get_Data,                    
                        function(set_Callback_Data)
                        {
                            if (set_Callback_Data)
                            {                                
                                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-success'
                                $scope.get_Dialog_Wait.Alert.Title = 'Success...'

                                if (get_Element.text() == 'Add')
                                    $scope.get_Dialog_Wait.Alert.Message = 'New Supplier has been added...'

                                else if (get_Element.text() == 'Edit')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Supplier has been updated...'

                                $scope.get_Dialog_Wait.Alert.Visible = true

                                tbl_Supplier_Information.DataTable().destroy()

                                $scope.Select_Supplier_Information('Select : All', null)

                                $rootScope.Supplier_List_Visible = true
                                $rootScope.Supplier_Manage_Visible = false
                            }

                            else
                            {
                                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-primary'
                                $scope.get_Dialog_Wait.Alert.Title = 'Cannot Process...'

                                if (get_Element.text() == 'Add')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Supplier cannot be added...'

                                else if (get_Element.text() == 'Edit')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Supplier cannot be updated...'
                                
                                $scope.get_Dialog_Wait.Alert.Visible = true
                            }                            

                            setTimeout(function () 
                            {
                                $scope.get_Dialog_Wait.Hide()                                

                            }, 1000)
                        })
                    }, 1000)
                }
            })       
        }        
    }

    $scope.Supplier_Code_Availability = true
    $scope.Supplier_Code_Temporary = null

    $scope.Supplier_Code_Change = function()
    {        
        $scope.Select_Supplier_Information('Select : Specific : Supplier_Code { Supplier_Code }', $scope.Supplier_Code)
    }    
}

/*-------------Engskie09_Supplier-----------------*/
/*-------------Engskie09_Supplier-----------------*/
/*-------------Engskie09_Supplier-----------------*/
/*-------------Engskie09_Supplier-----------------*/
/*-------------Engskie09_Supplier-----------------*/