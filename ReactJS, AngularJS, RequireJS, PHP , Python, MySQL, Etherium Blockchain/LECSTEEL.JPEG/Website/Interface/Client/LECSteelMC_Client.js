/*-------------Engskie09_Client-----------------*/
/*-------------Engskie09_Client-----------------*/
/*-------------Engskie09_Client-----------------*/
/*-------------Engskie09_Client-----------------*/
/*-------------Engskie09_Client-----------------*/

export function LECSteelMC_Client_Controller($rootScope, $scope, $compile, Client_Information)
{
    angular.element('.selectpicker').selectpicker()

    angular.element('select').on('change', function()
    {
        angular.element('#' + this.id).parent().removeClass('is-invalid')        
    })
    
    $scope.set_Image_Upload_Preview('Client_Image', 'Client_Image_Content')

    var tbl_Client_Information = angular.element('#tbl_Client_Information')

    $scope.Module_Loading_Visible = true
    $scope.LECSteelMC_Client_Visible = false

    $rootScope.set_Client_Action = function(set_Action)
    {
        angular.element('#frm_Client_Information').trigger('reset')

        angular.element('#Client_Status').change(function()
        {
            angular.element(this).parent().removeClass('is-invalid')
        })

        angular.element('#Client_Status').val(0).change()

        angular.element('#Client_Image_Content').attr('src', null)
       
        var get_Element = angular.element('#btn_Action')
        
        if (set_Action == 'Insert')            
            get_Element.text('Add')

        else if (set_Action == 'Update')            
            get_Element.text('Edit')
    }

    $scope.Select_Client_Information = function(set_Element, set_Action)
    {

        if (set_Action == 'Select : All')
            set_Action = ({'Action' :  'Select : All'})

        else if (set_Action == 'Select : Specific')
            set_Action = ({'Action' : 'Select : Specific',  'Client_Identity' : $scope.get_Element_Identity(set_Element)})

        Client_Information.Select_Client_Information(set_Action,

        function(set_Callback_Data)
        {
            if (set_Action['Action'] == 'Select : All')
            {
                $scope.Module_Loading_Visible = true
                $scope.LECSteelMC_Client_Visible = false

                setTimeout(function () 
                {
                    tbl_Client_Information.DataTable(
                    {
                        orderCellsTop: true,

                        fixedHeader: true,

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
                                    return  "<img class='rounded-circle' style = 'height: 8em' alt='No Image' src='" + data['Client_Image_Path'] + "'>"
                                }
                            },

                            {   data : "Client_FullName"   },
                            {   data : "Client_Position"  },
                            {   data : "Client_Address_List"  },
                            {   data : "Client_Contact_LandlineNumber"  },
                            {   data : "Client_Contact_MobileNumber"  },
                            {   data : "Client_Contact_EmailAddress"  },
                            {   data : "Client_Contact_FaxNumber"  },
                            {   data : "Client_Remark"  },
                            
                            {   orderable : false, 
                                data : null,
                                width : '5em',
                                render : function (data)
                                { 
                                    return  "<button class = 'btn btn-outline-success mr-1 col-md' id = '" + data['Client_Identity'] + "' ng-click = '" + 'Select_Client_Information($event, "Select : Specific");'  + "'>Edit</button>" +
                                            "<hr>" +
                                            "<button class = 'btn btn-outline-danger col-md' id = '" + data['Client_Identity'] + "' ng-click = '" + 'Manage_Client_Information($event, "Delete_Client_Information")' + "'>Delete</button>"
                                }
                            }                           
                        ],

                        createdRow: function(row, data, index)
                        {
                            $compile(row)($scope);
                        }
                    })

                    $scope.Module_Loading_Visible = false
                    $scope.LECSteelMC_Client_Visible = true

                }, 500)
                
            }

            else if (set_Action['Action'] == 'Select : Specific') 
            {  

                
                var get_JSON = JSON.parse(set_Callback_Data)
                $scope.set_Client_Action('Update')                
                angular.element('#Client_Identity').val(get_JSON[0]["Client_Identity"])
                angular.element('#Client_FullName').val(get_JSON[0]["Client_FullName"])
                angular.element('#Client_Position').val(get_JSON[0]["Client_Position"])
                angular.element('#Client_Address_List').val(get_JSON[0]["Client_Address_List"])
                angular.element('#Client_Contact_LandlineNumber').val(get_JSON[0]["Client_Contact_LandlineNumber"])
                angular.element('#Client_Contact_MobileNumber').val(get_JSON[0]["Client_Contact_MobileNumber"])
                angular.element('#Client_Contact_EmailAddress').val(get_JSON[0]["Client_Contact_EmailAddress"])
                angular.element('#Client_Contact_FaxNumber').val(get_JSON[0]["Client_Contact_FaxNumber"])
                angular.element('#Client_Remark').val(get_JSON[0]["Client_Remark"])
                angular.element('#Client_Status').val(get_JSON[0]["Client_Status"]).change()

                angular.element('#Client_Image_Content').attr('src', get_JSON[0]['Client_Image_Path'])

                $rootScope.Client_List_Visible = false
                $rootScope.Client_Manage_Visible = true

            }
        })
    }

    $scope.Manage_Client_Information = function(set_Element, set_Action)
    {
        if (set_Action == 'Delete_Client_Information')
        {
            $scope.get_Dialog_Choice.Dialog.Title = 'Are you sure?'

            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-warning'
            $scope.get_Dialog_Choice.Alert.Title = 'Are you sure'
            $scope.get_Dialog_Choice.Alert.Message = 'that you want to delete this Client?'
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

                    var get_Data = ({'Action' :  'Delete : Specific', 'Client_Identity' : set_Value})

                    Client_Information.Manage_Client_Information(set_Action, JSON.stringify(get_Data),
                    function(set_Callback_Data)
                    {
                        if (set_Callback_Data)
                        {
                            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-success'
                            $scope.get_Dialog_Choice.Alert.Title = 'Success...'
                            $scope.get_Dialog_Choice.Alert.Message = 'Client has been deleted...'
                            $scope.get_Dialog_Choice.Alert.Visible = true

                            tbl_Client_Information.DataTable().destroy()

                            $scope.Select_Client_Information(null, 'Select : All')
                        }

                        else
                        {
                            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-primary'
                            $scope.get_Dialog_Choice.Alert.Title = 'Cannot Process...'
                            $scope.get_Dialog_Choice.Alert.Message = 'Client cannot be deleted...'
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
            angular.element('#frm_Client_Information').validate(
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
                        set_Action = 'Insert_Client_Information'

                    else if (get_Element.text() == 'Edit')
                        set_Action = 'Update_Client_Information'

                    setTimeout(function () 
                    {
                        var get_Data = new FormData(angular.element(document.querySelector('#frm_Client_Information'))[0])
                    
                        Client_Information.Manage_Client_Information(set_Action, get_Data, 
                        
                        function(set_Callback_Data)
                        {
                            if (set_Callback_Data)
                            {
                                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-success'
                                $scope.get_Dialog_Wait.Alert.Title = 'Success...'

                                if (get_Element.text() == 'Add')
                                    $scope.get_Dialog_Wait.Alert.Message = 'New Client has been added...'

                                else if (get_Element.text() == 'Edit')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Client has been updated...'

                                $scope.get_Dialog_Wait.Alert.Visible = true
                                
                                tbl_Client_Information.DataTable().destroy()

                                $scope.Select_Client_Information(null, 'Select : All')

                                $rootScope.Client_List_Visible = true
                                $rootScope.Client_Manage_Visible = false         
                            }

                            else
                            {
                                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-primary'
                                $scope.get_Dialog_Wait.Alert.Title = 'Cannot Process...'

                                if (get_Element.text() == 'Add')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Client cannot be added...'

                                else if (get_Element.text() == 'Edit')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Client cannot be updated...'
                                
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

/*-------------Engskie09_Client-----------------*/
/*-------------Engskie09_Client-----------------*/
/*-------------Engskie09_Client-----------------*/
/*-------------Engskie09_Client-----------------*/
/*-------------Engskie09_Client-----------------*/