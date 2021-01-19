/*-------------Engskie09_Material-----------------*/
/*-------------Engskie09_Material-----------------*/
/*-------------Engskie09_Material-----------------*/
/*-------------Engskie09_Material-----------------*/
/*-------------Engskie09_Material-----------------*/

export function LECSteelMC_Material_Controller($rootScope, $scope, $compile, Material_Information)
{
    angular.element('.selectpicker').selectpicker()

    angular.element('select').on('change', function()
    {
        angular.element('#' + this.id).parent().removeClass('is-invalid')        
    })
    
    $scope.set_Image_Upload_Preview('Material_Image', 'Material_Image_Content')

    $scope.Input_Number_Validation('Material_Quantity', 'Natural', null, null)
    $scope.Input_Number_Validation('Material_Order_Minimum', 'Natural', null, null)
    $scope.Input_Number_Validation('Material_Price_Current', 'Decimal', null, null)

    var tbl_Material_Information = angular.element('#tbl_Material_Information')

    var get_Element_Material_Category_Identity = angular.element('#Material_Category_Identity')

    get_Element_Material_Category_Identity.empty()
    get_Element_Material_Category_Identity.append("<option selected disabled>Select Category</option>")           

    Material_Information.Select_Material_Category_Information(({'Action' :  'Select : All'}),
    function(set_Callback_Data)
    {           
        angular.forEach(JSON.parse(set_Callback_Data), function(set_Value, set_Key)
        {
            console.log(set_Value['Category_Identity'])
            get_Element_Material_Category_Identity.append("<option value = '" + set_Value['Category_Identity'] + "' data-subtext = '" + set_Value['Category_Description'] + "'>" + set_Value['Category_Name'] + "</option>")
        })

        get_Element_Material_Category_Identity.selectpicker('refresh')

        get_Element_Material_Category_Identity.val(0).change()
    })

    var get_Element_Material_Type_Identity = angular.element('#Material_Type_Identity')

    get_Element_Material_Type_Identity.empty()
    get_Element_Material_Type_Identity.append("<option selected disabled>Select Type</option>")           

    Material_Information.Select_Material_Type_Information(({'Action' :  'Select : All'}),
    function(set_Callback_Data)
    {           
        angular.forEach(JSON.parse(set_Callback_Data), function(set_Value, set_Key)
        {
            console.log(set_Value['Type_Identity'])
            get_Element_Material_Type_Identity.append("<option value = '" + set_Value['Type_Identity'] + "' data-subtext = '" + set_Value['Type_Description'] + "'>" + set_Value['Type_Name'] + "</option>")
        })

        get_Element_Material_Type_Identity.selectpicker('refresh')

        get_Element_Material_Type_Identity.val(0).change()
    })

    $scope.Module_Loading_Visible = true
    $scope.LECSteelMC_Material_Visible = false


	$rootScope.set_Material_Action = function(set_Action)
    {

        angular.element('#Material_Category_Identity').change(function()
        {         
            angular.element(this).parent().removeClass('is-invalid')
        })

        angular.element('#Material_Type_Identity').change(function()
        {
            angular.element(this).parent().removeClass('is-invalid')
        })
     
        get_Element_Material_Category_Identity.val(0).change()
        get_Element_Material_Type_Identity.val(0).change()

        angular.element('#Material_Image_Content').attr('src', null)

        angular.element('#frm_Material_Information').trigger('reset')
  
        var get_Element = angular.element('#btn_Action')

        if (set_Action == 'Insert')        
            get_Element.text('Add')
       

        else if (set_Action == 'Update')        
            get_Element.text('Edit')               
    }

    $scope.Select_Material_Information = function(set_Element, set_Action)
    {
        if (set_Action == 'Select : All')
            set_Action = ({'Action' :  'Select : All'})

        else if (set_Action == 'Select : Specific')
            set_Action = ({'Action' : 'Select : Specific',  'Material_Identity' : $scope.get_Element_Identity(set_Element)})

        Material_Information.Select_Material_Information(set_Action,

        function(set_Callback_Data)
        {
            if (set_Action['Action'] == 'Select : All')
            {
                $scope.Module_Loading_Visible = true
                $scope.LECSteelMC_Material_Visible = false

                setTimeout(function () 
                {
                    tbl_Material_Information.DataTable(
                    {
                        data: JSON.parse(set_Callback_Data),

                        dom: 'Bfrtip',
                     
                        buttons: 
                        {
                            buttons: 
                            [
                                {
                                    extend : 'print', 
                                    text : 'Print', 
                                    className : 'btn btn-outline-primary btn-lg', 
                                    title : 'Raw Materials', 
                                    exportOptions : 
                                    {
                                        columns : ':visible'
                                    }  
                                },

                                {
                                    extend : 'copy', 
                                    text : 'Copy', 
                                    className : 'btn btn-outline-primary btn-lg'
                                },

                                {
                                    extend : 'excel', 
                                    text : 'Excel', 
                                    className : 'btn btn-outline-primary btn-lg', 
                                    title : 'Raw Materials', 
                                    exportOptions : 
                                    {
                                        columns : ':visible'
                                    }  
                                },

                                {
                                    extend : 'pdf', 
                                    text : 'PDF', 
                                    className : 'btn btn-outline-primary btn-lg', 
                                    title : 'Raw Materials', 
                                    exportOptions : 
                                    {
                                        columns : ':visible'
                                    }  
                                },

                                {
                                    extend : 'csv', 
                                    text : 'CSV', 
                                    className : 'btn btn-outline-primary btn-lg', 
                                    title : 'Raw Materials', 
                                    exportOptions : 
                                    {
                                        columns : ':visible'
                                    }  
                                },

                                {   
                                    extend : 'colvis', 
                                    text : 'Show/Hide Columns', 
                                    className : 'btn btn-outline-primary btn-lg',
                                    columnText: function ( dt, idx, title )
                                    {
                                        return "<button class = 'btn btn-outline-primary btn-lg col-md'>" + title + "</button>"
                                    }
                                }                                
                            ]
                        },

                        initComplete: function()
                        {
                            angular.element('.dt-button').removeClass('dt-button') 
                        },
                        
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
                                    return  "<img class='rounded-circle' style = 'height: 8em' alt='No Image' src='" + data['Material_Image_Path'] + "'>"
                                }
                            },
                            
                            {   data : "Material_Part_Number"   },
                            {   data : "Material_Unit"  },
                            {   data : "Material_Size"  },
                            {   data : "Category_Name"  },
                            {   data : "Type_Name"  },
                            {   data : "Material_Quantity"  },
                            
                            {   orderable : false, 
                                data : null,
                                width : '5em',
                                render : function (data)
                                { 
                                    return  "<button class = 'btn btn-outline-success mr-1 col-md' id = '" + data['Material_Identity'] + "' ng-click = '" + 'Select_Material_Information($event, "Select : Specific");'  + "'>Edit</button>" +
                                            "<hr>" +
                                            "<button class = 'btn btn-outline-danger col-md' id = '" + data['Material_Identity'] + "' ng-click = '" + 'Manage_Material_Information($event, "Delete_Material_Information")' + "'>Delete</button>"
                                }
                            }
                        ],

                        createdRow: function(row, data, index)
                        {
                            $compile(row)($scope);
                        }
                    })

                    $scope.Module_Loading_Visible = false
                    $scope.LECSteelMC_Material_Visible = true

                }, 500)



                
            }

            else if (set_Action['Action'] == 'Select : Specific') 
            {
                var get_JSON = JSON.parse(set_Callback_Data)

                $scope.set_Material_Action('Update')
                
                angular.element('#Material_Identity').val(get_JSON[0]["Material_Identity"])

                angular.element('#Material_Part_Number').val(get_JSON[0]["Material_Part_Number"])
                angular.element('#Material_Unit').val(get_JSON[0]["Material_Unit"])
                angular.element('#Material_Size').val(get_JSON[0]["Material_Size"])

                angular.element('#Material_Category_Identity').val(get_JSON[0]["Material_Category_Identity"]).change()
                angular.element('#Material_Type_Identity').val(get_JSON[0]["Material_Type_Identity"]).change()

                angular.element('#Material_Quantity').val(get_JSON[0]["Material_Quantity"])
                angular.element('#Material_Order_Minimum').val(get_JSON[0]["Material_Order_Minimum"])
                angular.element('#Material_Price_Current').val(get_JSON[0]["Material_Price_Current"])

                angular.element('#Material_Description').val(get_JSON[0]["Material_Description"])
                angular.element('#Material_Remark').val(get_JSON[0]["Material_Remark"])
                
                angular.element('#Material_Image_Content').attr('src', get_JSON[0]["Material_Image_Path"])

                $rootScope.Material_List_Visible = false
                $rootScope.Material_Manage_Visible = true
            }
        })
    }

    $scope.Manage_Material_Information = function(set_Element, set_Action)
    {
        if (set_Action == 'Delete_Material_Information')
        {            

            $scope.get_Dialog_Choice.Dialog.Title = 'Are you sure?'

            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-warning'
            $scope.get_Dialog_Choice.Alert.Title = 'Are you sure'
            $scope.get_Dialog_Choice.Alert.Message = 'that you want to delete this Raw Material?'
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

                    var get_Data = ({'Action' :  'Delete : Specific', 'Material_Identity' : set_Value})

                    Material_Information.Manage_Material_Information(set_Action, JSON.stringify(get_Data),
                    function(set_Callback_Data)
                    {
                        if (set_Callback_Data)
                        {
                            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-success'
                            $scope.get_Dialog_Choice.Alert.Title = 'Success...'
                            $scope.get_Dialog_Choice.Alert.Message = 'Material has been deleted...'
                            $scope.get_Dialog_Choice.Alert.Visible = true

                            tbl_Material_Information.DataTable().destroy()

                            $scope.Select_Material_Information(null, 'Select : All')

                        }

                        else
                        {
                            $scope.get_Dialog_Choice.Alert.Interface = 'alert alert-dismissible alert-primary'
                            $scope.get_Dialog_Choice.Alert.Title = 'Cannot Process...'
                            $scope.get_Dialog_Choice.Alert.Message = 'Material cannot be deleted...'
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
            angular.element('#frm_Material_Information').validate(
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
                        set_Action = 'Insert_Material_Information'

                    else if (get_Element.text() == 'Edit')
                        set_Action = 'Update_Material_Information'

                    setTimeout(function () 
                    {
                        var get_Data = new FormData(angular.element(document.querySelector('#frm_Material_Information'))[0])
                        
                        Material_Information.Manage_Material_Information(set_Action, get_Data, 
                        
                        function(set_Callback_Data)
                        {
                            if (set_Callback_Data)
                            {
                                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-success'
                                $scope.get_Dialog_Wait.Alert.Title = 'Success...'

                                if (get_Element.text() == 'Add')
                                    $scope.get_Dialog_Wait.Alert.Message = 'New Raw Material has been added...'

                                else if (get_Element.text() == 'Edit')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Raw Material has been updated...'

                                $scope.get_Dialog_Wait.Alert.Visible = true


                                tbl_Material_Information.DataTable().destroy()

                                $scope.Select_Material_Information(null, 'Select : All')
                                
                                $rootScope.Material_List_Visible = true
                                $rootScope.Material_Manage_Visible = false           
                            }

                            else
                            {
                                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-primary'
                                $scope.get_Dialog_Wait.Alert.Title = 'Cannot Process...'

                                if (get_Element.text() == 'Add')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Raw Material cannot be added...'

                                else if (get_Element.text() == 'Edit')
                                    $scope.get_Dialog_Wait.Alert.Message = 'Raw Material cannot be updated...'
                                
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

/*-------------Engskie09_Material-----------------*/
/*-------------Engskie09_Material-----------------*/
/*-------------Engskie09_Material-----------------*/
/*-------------Engskie09_Material-----------------*/
/*-------------Engskie09_Material-----------------*/