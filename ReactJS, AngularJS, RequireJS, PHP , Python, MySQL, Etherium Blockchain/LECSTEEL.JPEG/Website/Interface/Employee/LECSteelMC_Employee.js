/*-------------Engskie09_Employee-----------------*/
/*-------------Engskie09_Employee-----------------*/
/*-------------Engskie09_Employee-----------------*/
/*-------------Engskie09_Employee-----------------*/
/*-------------Engskie09_Employee-----------------*/

export function LECSteelMC_Employee_Controller($rootScope, $scope, $compile, Employee_Information)
{
    angular.element('.selectpicker').selectpicker()

    angular.element('select').on('change', function()
    {
        angular.element('#' + this.id).parent().removeClass('is-invalid')        
    })

    $scope.set_Image_Upload_Preview('Employee_Image', 'Employee_Image_Content')

    var tbl_Employee_Information = angular.element('#tbl_Employee_Information')

    $scope.Module_Loading_Visible = true
    $scope.LECSteelMC_Employee_Visible = false

    $rootScope.set_Employee_Action = function(set_Action)
    {
        angular.element('#frm_Employee_Information').trigger('reset')

        angular.element('#Employee_Position').change(function()
        {
            angular.element(this).parent().removeClass('is-invalid')
        })
        
        angular.element('#Employee_Position').val(0).change()       
        
        angular.element('#Employee_Image_Content').attr('src', null)           
               

        var get_Element = angular.element('#btn_Action')      
        
        if (set_Action == 'Insert')        
            get_Element.text('Add')

        else if (set_Action == 'Update')        
            get_Element.text('Edit')
    }

    $scope.Select_Employee_Information = function(set_Element, set_Action)
    {
        if (set_Action == 'Select : All')
            set_Action = ({'Action' :  'Select : All'})

        else if (set_Action == 'Select : Specific')
            set_Action = ({'Action' : 'Select : Specific',  'Employee_Identity' : $scope.get_Element_Identity(set_Element)})

        Employee_Information.Select_Employee_Information(set_Action,

        function(set_Callback_Data)
        {
            if (set_Action['Action'] == 'Select : All')
            {

                $scope.Module_Loading_Visible = true
                $scope.LECSteelMC_Employee_Visible = false

                setTimeout(function () 
                {
                    tbl_Employee_Information.DataTable(
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
                                    return  "<img class='rounded-circle' style = 'height: 8em' alt='No Image' src='" + data['Employee_Image_Path'] + "'>"
                                }
                            },

                            {   data : "Employee_Username"   },
                            {   data : "Employee_FullName"   },
                            {   data : "Employee_Position"  },
                            
                            {   orderable : false, 
                                data : null,
                                width : '5em',
                                render : function (data)
                                { 
                                    return  "<button class = 'btn btn-outline-success mr-1 col-md' id = '" + data['Employee_Identity'] + "' ng-click = '" + 'Select_Employee_Information($event, "Select : Specific");'  + "'>Edit</button>" +
                                            "<hr>" +
                                            "<button class = 'btn btn-outline-danger col-md' id = '" + data['Employee_Identity'] + "' ng-click = '" + 'Manage_Employee_Information($event, "Delete_Employee_Information")' + "'>Delete</button>"

                                }
                            }                           
                        ],

                        createdRow: function(row, data, index)
                        {
                            $compile(row)($scope);
                        }
                    })                   
                    
                    $scope.Module_Loading_Visible = false
                    $scope.LECSteelMC_Employee_Visible = true

                }, 500)
            }

            else if (set_Action['Action'] == 'Select : Specific') 
            {                
                var get_JSON = JSON.parse(set_Callback_Data)
                $scope.set_Employee_Action('Update')                
                angular.element('#Employee_Identity').val(get_JSON[0]["Employee_Identity"])
                angular.element('#Employee_Username').val(get_JSON[0]["Employee_Username"])
                angular.element('#Employee_Password').val(get_JSON[0]["Employee_Password"])
                angular.element('#Employee_FirstName').val(get_JSON[0]["Employee_FirstName"])
                angular.element('#Employee_MiddleName').val(get_JSON[0]["Employee_MiddleName"])
                angular.element('#Employee_LastName').val(get_JSON[0]["Employee_LastName"]) 
                angular.element('#Employee_Position').val(get_JSON[0]["Employee_Position"]).change()

                angular.element('#Employee_Image_Content').attr('src', get_JSON[0]['Employee_Image_Path'])

                $rootScope.Employee_List_Visible = false
                $rootScope.Employee_Manage_Visible = true
            }
        })
    }

    $scope.Manage_Employee_Information = function(set_Element, set_Action)
    {
        if (set_Action == 'Delete_Employee_Information')
        {
            $scope.get_Dialog_Choice.Dialog.Title = 'Are you sure?'

            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-warning'
            $scope.get_Dialog_Choice.Alert.Title = 'Are you sure'
            $scope.get_Dialog_Choice.Alert.Message = 'that you want to delete this Employee?'
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

                    var get_Data = ({'Action' :  'Delete : Specific', 'Employee_Identity' : set_Value})

                    Employee_Information.Manage_Employee_Information(set_Action, JSON.stringify(get_Data),
                    function(set_Callback_Data)
                    {
                        if (set_Callback_Data)
                        {
                            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-success'
                            $scope.get_Dialog_Choice.Alert.Title = 'Success...'
                            $scope.get_Dialog_Choice.Alert.Message = 'Employee has been deleted...'
                            $scope.get_Dialog_Choice.Alert.Visible = true

                            tbl_Employee_Information.DataTable().destroy()

                            $scope.Select_Employee_Information(null, 'Select : All')
                        }

                        else
                        {
                            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-primary'
                            $scope.get_Dialog_Choice.Alert.Title = 'Cannot Process...'
                            $scope.get_Dialog_Choice.Alert.Message = 'Employee cannot be deleted...'
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
            angular.element('#frm_Employee_Information').validate(
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
                        set_Action = 'Insert_Employee_Information'

                    else if (get_Element.text() == 'Edit')
                        set_Action = 'Update_Employee_Information'
                    
                    setTimeout(function () 
                    {
                        var get_Data = new FormData(angular.element(document.querySelector('#frm_Employee_Information'))[0])
                    
                        Employee_Information.Manage_Employee_Information(set_Action, get_Data, 
                        
                        function(set_Callback_Data)
                        {
                            if (set_Callback_Data)
                            {
                                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-success'
                                $scope.get_Dialog_Wait.Alert.Title = 'Success...'

                                if (get_Element.text() == 'Add')
                                    $scope.get_Dialog_Wait.Alert.Message = 'New Employee has been added...'

                                else if (get_Element.text() == 'Edit')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Employee has been updated...'

                                $scope.get_Dialog_Wait.Alert.Visible = true


                                tbl_Employee_Information.DataTable().destroy()

                                $scope.Select_Employee_Information(null, 'Select : All')

                                $rootScope.Employee_List_Visible = true
                                $rootScope.Employee_Manage_Visible = false         
                            }

                            else
                            {
                                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-primary'
                                $scope.get_Dialog_Wait.Alert.Title = 'Cannot Process...'

                                if (get_Element.text() == 'Add')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Employee cannot be added...'

                                else if (get_Element.text() == 'Edit')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Employee cannot be updated...'
                                
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

}

/*-------------Engskie09_Employee-----------------*/
/*-------------Engskie09_Employee-----------------*/
/*-------------Engskie09_Employee-----------------*/
/*-------------Engskie09_Employee-----------------*/
/*-------------Engskie09_Employee-----------------*/