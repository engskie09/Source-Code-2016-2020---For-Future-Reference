/*-------------Engskie09_Material_Type-----------------*/
/*-------------Engskie09_Material_Type-----------------*/
/*-------------Engskie09_Material_Type-----------------*/
/*-------------Engskie09_Material_Type-----------------*/
/*-------------Engskie09_Material_Type-----------------*/

export function LECSteelMC_Material_Type_Controller($rootScope, $scope, $compile, Material_Information)
{

    var tbl_Material_Type_Information = angular.element('#tbl_Material_Type_Information')

    $scope.Module_Loading_Visible = true
    $scope.LECSteelMC_Material_Type_Visible = false
    
    $rootScope.set_Material_Type_Action = function(set_Action)
    {
        angular.element('#frm_Material_Type_Information').trigger('reset')
   
       
        var get_Element = angular.element('#btn_Action')
        
        if (set_Action == 'Insert')
            get_Element.text('Add')


        else if (set_Action == 'Update')            
            get_Element.text('Edit')
    }

    $scope.Select_Material_Type_Information = function(set_Element, set_Action)
    {

        if (set_Action == 'Select : All')
            set_Action = ({'Action' :  'Select : All'})

        else if (set_Action == 'Select : Specific')
            set_Action = ({'Action' : 'Select : Specific',  'Type_Identity' : $scope.get_Element_Identity(set_Element)})

        Material_Information.Select_Material_Type_Information(set_Action,

        function(set_Callback_Data)
        {
            if (set_Action['Action'] == 'Select : All')
            {              

                $scope.Module_Loading_Visible = true
                $scope.LECSteelMC_Material_Type_Visible = false  

                tbl_Material_Type_Information.DataTable(
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
                        {   data : "Type_Name"   },
                        {   data : "Type_Description"  },
                        
                        {   orderable : false, 
                            data : null,
                            width : '5em',
                            render : function (data)
                            { 
                                return  "<button class = 'btn btn-outline-success mr-1 col-md' id = '" + data['Type_Identity'] + "' ng-click = '" + 'Select_Material_Type_Information($event, "Select : Specific");'  + "'>Edit</button>" +
                                        "<hr>" +
                                        "<button class = 'btn btn-outline-danger col-md' id = '" + data['Type_Identity'] + "' ng-click = '" + 'Manage_Material_Type_Information($event, "Delete_Material_Type_Information")' + "'>Delete</button>"
                            }
                        }                           
                    ],

                    createdRow: function(row, data, index)
                    {
                        $compile(row)($scope);
                    }
                })

                $scope.Module_Loading_Visible = false
                $scope.LECSteelMC_Material_Type_Visible = true
                
            }

            else if (set_Action['Action'] == 'Select : Specific') 
            {
                var get_JSON = JSON.parse(set_Callback_Data)
                $scope.set_Material_Type_Action('Update')                
                angular.element('#Type_Identity').val(get_JSON[0]["Type_Identity"])
                angular.element('#Type_Name').val(get_JSON[0]["Type_Name"])
                angular.element('#Type_Description').val(get_JSON[0]["Type_Description"])

                $rootScope.Material_Type_List_Visible = false
                $rootScope.Material_Type_Manage_Visible = true
            }
        })
    }

    $scope.Manage_Material_Type_Information = function(set_Element, set_Action)
    {
        if (set_Action == 'Delete_Material_Type_Information')
        {
            $scope.get_Dialog_Choice.Dialog.Title = 'Are you sure?'

            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-warning'
            $scope.get_Dialog_Choice.Alert.Title = 'Are you sure'
            $scope.get_Dialog_Choice.Alert.Message = 'that you want to delete this Type?'
            $scope.get_Dialog_Choice.Alert.Visible = true

            $scope.get_Dialog_Choice.Dialog.Closeable = false

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

                    $scope.get_Dialog_Choice.Dialog.Closeable = false

                    $scope.get_Dialog_Choice.btn_Ok.Visible = true
                    $scope.get_Dialog_Choice.btn_No.Visible = true

                    var get_Data = ({'Action' :  'Delete : Specific', 'Type_Identity' : set_Value})

                    Material_Information.Manage_Material_Type_Information(set_Action, JSON.stringify(get_Data),
                    function(set_Callback_Data)
                    {

                        if (set_Callback_Data)
                        {
                            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-success'
                            $scope.get_Dialog_Choice.Alert.Title = 'Success...'
                            $scope.get_Dialog_Choice.Alert.Message = 'Type has been deleted...'
                            $scope.get_Dialog_Choice.Alert.Visible = true

                            tbl_Material_Type_Information.DataTable().destroy()

                            $scope.Select_Material_Type_Information(null, 'Select : All')
                        }

                        else
                        {
                            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-primary'
                            $scope.get_Dialog_Choice.Alert.Title = 'Cannot Process...'
                            $scope.get_Dialog_Choice.Alert.Message = 'Type cannot be deleted...'
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
            angular.element('#frm_Material_Type_Information').validate(
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
                    
                    setTimeout(function () 
                    {
                        var get_Element = angular.element('#' + $scope.get_Element_Identity(set_Element))

                        if (get_Element.text() == 'Add')
                            set_Action = 'Insert_Material_Type_Information'

                        else if (get_Element.text() == 'Edit')
                            set_Action = 'Update_Material_Type_Information'
                        
                        var get_Data = new FormData(angular.element(document.querySelector('#frm_Material_Type_Information'))[0])
                        
                        Material_Information.Manage_Material_Type_Information(set_Action, get_Data, 
                        
                        function(set_Callback_Data)
                        {
                            if (set_Callback_Data)
                            {
                                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-success'
                                $scope.get_Dialog_Wait.Alert.Title = 'Success...'

                                if (get_Element.text() == 'Add')
                                    $scope.get_Dialog_Wait.Alert.Message = 'New Type has been added...'

                                else if (get_Element.text() == 'Edit')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Type has been updated...'

                                $scope.get_Dialog_Wait.Alert.Visible = true


                                tbl_Material_Type_Information.DataTable().destroy()

                                $scope.Select_Material_Type_Information(null, 'Select : All')

                                $rootScope.Material_Type_List_Visible = true
                                $rootScope.Material_Type_Manage_Visible = false
            
                            }

                            else
                            {
                                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-primary'
                                $scope.get_Dialog_Wait.Alert.Title = 'Cannot Process...'

                                if (get_Element.text() == 'Add')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Type cannot be added...'

                                else if (get_Element.text() == 'Edit')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Type cannot be updated...'
                                
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

/*-------------Engskie09_Material_Type-----------------*/
/*-------------Engskie09_Material_Type-----------------*/
/*-------------Engskie09_Material_Type-----------------*/
/*-------------Engskie09_Material_Type-----------------*/
/*-------------Engskie09_Material_Type-----------------*/