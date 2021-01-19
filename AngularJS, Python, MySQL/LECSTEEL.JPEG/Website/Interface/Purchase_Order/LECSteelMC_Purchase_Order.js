/*-------------Engskie09_Purchase_Orderkie09_Purchase_Order-----------------*/
/*-------------Engskie09_Purchase_Order-----------------*/
/*-------------Engskie09_Purchase_Order-----------------*/
/*-------------Engskie09_Purchase_Order-----------------*/
/*-------------Engskie09_Purchase_Order-----------------*/


export function LECSteelMC_Purchase_Order_Controller($rootScope, $scope, $compile, Purchase_Order_Information, Supplier_Information, Material_Information, User_Information)
{
    angular.element('.selectpicker').selectpicker()
    angular.element.fn.datepicker.defaults.format = "yyyy/mm/dd"
    angular.element('.datepicker').datepicker()
    
    angular.element('select').on('change', function()
    {
        angular.element('#' + this.id).parent().removeClass('is-invalid')      
    })

    angular.element('label').click(function()
    {
        var get_Label = $(this).attr('for')       
        
        angular.element('#' + get_Label ).trigger('focusin')
    })

    angular.element('#Purchase_Order_DateTime_Issue').focusin(function()
    {
        setTimeout(function () 
        {
            $('.datepicker').each(function(index, obj)
            {                
                $(this).html(null)
            })

        }, 500)
    })

    //angular.element('#Purchase_Order_DateTime_Issue').trigger('focusin')

    angular.element('#Purchase_Order_DateTime_Posted').focusin(function()
    {
        setTimeout(function () 
        {
            $('.datepicker').each(function(index, obj)
            {
                $(this).html(null)
            })

        }, 500)
    })

    //angular.element('#Purchase_Order_DateTime_Posted').trigger('focusin')

    angular.element('#Purchase_Order_DateTime_Unposted').focusin(function()
    {
        setTimeout(function () 
        {
            $('.datepicker').each(function(index, obj)
            {                
                $(this).html(null)
            })

        }, 500)
    })
        
    //angular.element('#Purchase_Order_DateTime_Unposted').trigger('focusin')

    $scope.set_Image_Upload_Preview('Purchase_Order_Image', 'Purchase_Order_Image_Content')    

    var Purchase_Order_Supplier_Identity = angular.element('#Purchase_Order_Supplier_Identity')

    Purchase_Order_Supplier_Identity.empty()    
    Purchase_Order_Supplier_Identity.append("<option value = 'null' selected disabled>Supplier Code</option>")    
    
    Supplier_Information.Select_Supplier_Information(({'Action' :  'Select : Specific : { Supplier_Identity, Supplier_Code, Supplier_Name }'}),
    function(set_Callback_Data)
    {
        angular.forEach(JSON.parse(set_Callback_Data), function(set_Value, set_Key)
        {            
            Purchase_Order_Supplier_Identity.append("<option value = '" + set_Value['Supplier_Identity'] + "' data-subtext = '" + set_Value['Supplier_Name'] + "'>" + set_Value['Supplier_Code'] + "</option>")
        })

        Purchase_Order_Supplier_Identity.selectpicker('refresh')  

        Purchase_Order_Supplier_Identity.val(0).change()

        Purchase_Order_Supplier_Identity.on('change', function()
        {
            $scope.set_Purchase_Order_Supplier_Identity_Change()
        })
    })
    
    var Purchase_Order_Status = angular.element('#Purchase_Order_Status')

    Purchase_Order_Status.empty()

    Purchase_Order_Status.append
    (
        "<option value = 'null' selected disabled>Select Status</option>" +
        "<option value = 'Posted'>Post</option>" +
        "<option value = 'Unposted'>Unpost</option>"        
    )

    Purchase_Order_Status.selectpicker('refresh')

    Purchase_Order_Status.val(0).change()

    Purchase_Order_Status.on('change', function()
    {
        $scope.set_Purchase_Order_Status_Change()
    })

    var tbl_Material_Information = angular.element('#tbl_Material_Information')
    var tbl_Purchase_Order_Material_Information = angular.element('#tbl_Purchase_Order_Material_Information')

    var tbl_Purchase_Order_Information = angular.element('#tbl_Purchase_Order_Information')

    tbl_Purchase_Order_Material_Information.DataTable(
    {
        dom : 'Bfrtip',

        buttons :
        {   
            buttons :
            [
                {              
                    text: 'Add Material',

                    className: 'btn btn-outline-primary btn-lg',

                    action: function()
                    {
                        $rootScope.Material_List_Visible = true
                        $rootScope.Purchase_Order_Manage_Visible = false                       
                    }
                }
            ]
            
        },

        footerCallback : function(row, data, start, end, display)
        {
            var api = this.api()
            
            var intVal = function(i)
            {
                return typeof i === 'string' ? i.replace(/[\$,]/g, '')*1 
                : typeof i === 'number' ? i : 0
            }

            var total = api.column(8).data().reduce(function(a, b)
            {
                return intVal(a) + intVal(b)
            }, 0 )

            var pageTotal = api.column(8, { page: 'current' }).data().reduce(
            function(a, b)
            {
                return intVal(a) + intVal(b)
            }, 0 )

            angular.element('#Purchase_Order_Amount').val(total)
            
            //angular.element(api.column(8).footer()).html('This Page: '+pageTotal + '<br> (All: '+ total + ' total)')
            angular.element(api.column(8).footer()).html(total)
        },

        autoWidth: false,

        columnDefs: 
        [                          
          { targets : '_all', className : 'dt-center' },
          { targets : 0, className : '.check', visible : false }
        ],

        initComplete: function()
        {
            angular.element('.dt-button').removeClass('dt-button') 
        },

        createdRow: function(row, data, index)
        {
            $compile(row)($scope);
        }
    })    

    var btn_Action = angular.element('#btn_Action')

    $scope.Module_Loading_Visible = false
    $scope.LECSteelMC_Purchase_Order_Visible = true

	$rootScope.set_Purchase_Order_Action = function(set_Action)
	{
        if (set_Action == 'Insert')
        {
            var get_Date_Today = new Date().toISOString().slice(0,10)

            setTimeout(function () 
            {
                angular.element('#Purchase_Order_DateTime_Issue').datepicker('update', get_Date_Today)

            }, 1000)            
            
            btn_Action.text('Add new P.O')
        }

        else if (set_Action == 'Update')
            btn_Action.text('Save')        
        
        tbl_Purchase_Order_Material_Information.DataTable().clear().draw()

        angular.element('#frm_Purchase_Order_Information').trigger('reset')
        
        angular.element('#Purchase_Order_Amount').val(0)                                
                                     
        angular.element('#Purchase_Order_Image_Content').attr('src', null)

        $scope.Purchase_Order_Supplier_Identity = {'value' : null}
        $scope.Purchase_Order_Status = {'value' : null}

        Purchase_Order_Supplier_Identity.val(0).change()

        Purchase_Order_Status.val(0).change()

        angular.element('#Employee_Username').val(User_Information.Username)

    }

    $scope.Select_Purchase_Order_Information_Parent = function(set_Element, set_Action)
    {
        if (set_Action == 'Select : Specific')
            set_Action = ({'Action' : 'Select : Specific',  'Purchase_Order_Identity' : $scope.get_Element_Identity(set_Element)})
        
        else
            set_Action = ({'Action' :  set_Action})
        Purchase_Order_Information.Select_Purchase_Order_Information_Parent(set_Action,

        function(set_Callback_Data)
        {
            if (set_Action['Action'] == 'Select : All')
            {

                $scope.Module_Loading_Visible = true
                $scope.LECSteelMC_Purchase_Order_Visible = false
                setTimeout(function () 
                {
                    tbl_Purchase_Order_Information.DataTable(
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
                                    return  "<img class='rounded-circle' style = 'height: 8em' alt='No Image' src='" + data['Purchase_Order_Image_Path'] + "'>"
                                }
                            },

                            {   data : "Purchase_Order_Number_Parent"   },
                            {   data : "Purchase_Order_Amount"   },
                            {   data : "Purchase_Order_Amount_Paid"  },
                            {   data : "Purchase_Order_Status"  },
                            
                            {   orderable : false, 
                                data : null,
                                width : '5em',
                                render : function (data)
                                {
                                	return  "<button class = 'btn btn-outline-success mr-1 col-md' id = '" + data['Purchase_Order_Identity'] + "' ng-click = '" + 'Select_Purchase_Order_Information_Parent($event, "Select : Specific");'  + "'>Edit</button>" 
                                }
                            }                           
                        ],

                        createdRow: function(row, data, index)
                        {
                            $compile(row)($scope);
                        }
                    })                   
                    
                    $scope.Module_Loading_Visible = false
                    $scope.LECSteelMC_Purchase_Order_Visible = true

                }, 500)
            }

            else if (set_Action['Action'] == 'Select : Specific') 
            {
                var get_JSON = JSON.parse(set_Callback_Data)

                $scope.set_Purchase_Order_Action('Update')

                $scope.Manage_Purchase_Order_Material('Insert : Multiple', get_JSON[0]['Purchase_Order_Information_Child'])

                angular.element('#Purchase_Order_Identity').val(get_JSON[0]['Purchase_Order_Identity'])
                angular.element('#Purchase_Order_Number_Parent').val(get_JSON[0]['Purchase_Order_Number_Parent'])

                Purchase_Order_Supplier_Identity.val(get_JSON[0]["Purchase_Order_Supplier_Identity"]).change()
                
                

                angular.element('#Purchase_Order_Supplier_Term').val(get_JSON[0]["Purchase_Order_Supplier_Term"])
                angular.element('#Purchase_Order_Remarks').val(get_JSON[0]["Purchase_Order_Remarks"])


                angular.element('#Purchase_Order_DateTime_Due').datepicker('update', $scope.set_DateTime_Value(get_JSON[0]["Purchase_Order_DateTime_Due"]).toISOString().slice(0,10))
                angular.element('#Purchase_Order_DateTime_Issue').datepicker('update', $scope.set_DateTime_Value(get_JSON[0]["Purchase_Order_DateTime_Issue"]).toISOString().slice(0,10))
                angular.element('#Purchase_Order_DateTime_Posted').datepicker('update', $scope.set_DateTime_Value(get_JSON[0]["Purchase_Order_DateTime_Posted"]).toISOString().slice(0,10))
                angular.element('#Purchase_Order_DateTime_Unposted').datepicker('update', $scope.set_DateTime_Value(get_JSON[0]["Purchase_Order_DateTime_Unposted"]).toISOString().slice(0,10))

                $scope.Purchase_Order_DateTime_Posted = angular.element('#Purchase_Order_DateTime_Posted').val()
                $scope.Purchase_Order_DateTime_Unposted = angular.element('#Purchase_Order_DateTime_Unposted').val()
                
                Purchase_Order_Status.val(get_JSON[0]["Purchase_Order_Status"]).change()
                
                angular.element('#Purchase_Order_Amount').val(get_JSON[0]['Purchase_Order_Amount'])

                angular.element('#Purchase_Order_Amount_Paid').val(get_JSON[0]['Purchase_Order_Amount_Paid'])

                angular.element('#Purchase_Order_Image_Content').attr('src', get_JSON[0]['Purchase_Order_Image_Path'])

                

                $rootScope.Purchase_Order_List_Visible = false
                $rootScope.Purchase_Order_Manage_Visible = true
            }
        })
    }

    $scope.Manage_Purchase_Order_Information_Parent = function(set_Element, set_Action)
    {
        if (set_Action == 'Delete_Purchase_Order_Information_Parent')
        {
            alert('Delete')
        }

        else
        {
            angular.element('#frm_Purchase_Order_Information').validate(
            {
                errorPlacement: function (error, element)
                {

                    if (element.hasClass('selectpicker'))
                    {
                        if(Purchase_Order_Supplier_Identity.val() == '? undefined:undefined ?')                        
                            Purchase_Order_Supplier_Identity.parent().addClass('is-invalid')
                        

                        element.parent().addClass('is-invalid')                        
                    }

                },

                errorClass:'is-invalid-custom',

                submitHandler: function()
                {
                    var get_Purchase_Order_Information = $scope.get_Purchase_Order_Information()

                    if (get_Purchase_Order_Information == null)
                    {
                        $scope.get_Dialog_Wait.btn_Ok.Visible = false
                        $scope.get_Dialog_Wait.btn_No.Visible = false                        

                        $scope.get_Dialog_Wait.Dialog.Title = 'No Raw Material'
                        $scope.get_Dialog_Wait.Dialog.Closeable = true

                        $scope.get_Dialog_Wait.Alert.Visible = true
                        $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-primary'
                        $scope.get_Dialog_Wait.Alert.Title = 'Cannot Process...'                              
                        $scope.get_Dialog_Wait.Alert.Message = 'Please add Raw Masterial'

                        $scope.get_Dialog_Wait.Show()

                        return
                    }                    

                    $scope.get_Dialog_Wait.Dialog.Title = 'Please Wait...'

                    $scope.get_Dialog_Wait.Loading.Visible = true

                    $scope.get_Dialog_Wait.btn_Ok.Visible = false
                    $scope.get_Dialog_Wait.btn_No.Visible = false
                    
                    $scope.get_Dialog_Wait.Dialog.Closeable = false

                    $scope.get_Dialog_Wait.Show()
                    
                    setTimeout(function ()
                    {
                        if (btn_Action.text() == 'Add new P.O')
                            set_Action = 'Insert_Purchase_Order_Information_Parent'

                        else if (btn_Action.text() == 'Save')
                            set_Action = 'Update_Purchase_Order_Information_Parent'
                        
                        var get_Data = new FormData(angular.element(document.querySelector('#frm_Purchase_Order_Information'))[0])

                        get_Data.set('Purchase_Order_Information_Child', get_Purchase_Order_Information)

                        Purchase_Order_Information.Manage_Purchase_Order_Information_Parent(set_Action, get_Data, 
                        
                        function(set_Callback_Data)
                        {
                            if (set_Callback_Data)
                            {
                                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-success'
                                $scope.get_Dialog_Wait.Alert.Title = 'Success...'

                                if (btn_Action.text() == 'Add new P.O')
                                    $scope.get_Dialog_Wait.Alert.Message = 'New P.O has been added...'

                                else if (btn_Action.text() == 'Save')
                                    $scope.get_Dialog_Wait.Alert.Message = 'P.O has been updated...'

                                $scope.get_Dialog_Wait.Alert.Visible = true                                    


                                $scope.set_Purchase_Order_Action(null)
                                
                                tbl_Purchase_Order_Information.DataTable().destroy()
                                $scope.Select_Purchase_Order_Information_Parent(null, 'Select : All')

                                $rootScope.Material_Type_List_Visible = true
                                $rootScope.Material_Type_Manage_Visible = false                                
            
                            }

                            else
                            {
                                $scope.get_Dialog_Wait.Alert.Interface = 'alert alert-dismissible alert-primary'
                                $scope.get_Dialog_Wait.Alert.Title = 'Cannot Process...'

                                if (btn_Action.text() == 'Add')
                                    $scope.get_Dialog_Wait.Alert.Message = 'P.O cannot be added...'

                                else if (btn_Action.text() == 'Edit')
                                    $scope.get_Dialog_Wait.Alert.Message = 'P.O cannot be updated...'
                                
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

    $scope.set_DateTime_Value = function(set_DateTime)
    {
        var get_DateTime = null;

        if(typeof set_DateTime === 'string')
        {
            get_DateTime = set_DateTime.split(/[- :]/);

            get_DateTime = new Date(get_DateTime[0], get_DateTime[1] - 1, get_DateTime[2], get_DateTime[3] || 0, get_DateTime[4] || 0, get_DateTime[5] || 0);          
        }

        return get_DateTime;  
    }
    
    $scope.set_Purchase_Order_Supplier_Identity_Change = function()
    {
        if (Purchase_Order_Supplier_Identity.val() != null)
            $scope.Select_Supplier_Information('Select : Specific', Purchase_Order_Supplier_Identity.val())
    }

    $scope.Purchase_Order_DateTime_Posted = null
    $scope.Purchase_Order_DateTime_Unposted = null

    $scope.set_Purchase_Order_Status_Change = function()
    {
        if (btn_Action.text() == 'Add new P.O')
        {
            var get_Date_Today = new Date().toISOString().slice(0,10)

            angular.element('#Purchase_Order_DateTime_Issue').datepicker('update', get_Date_Today)

            if (Purchase_Order_Status.val() == 'Posted')
            {   
                angular.element('#Purchase_Order_DateTime_Posted').datepicker('update', get_Date_Today)
                angular.element('#Purchase_Order_DateTime_Unposted').datepicker('update', '1/01/01')
            }


            else if (Purchase_Order_Status.val() == 'Unposted')
            {
                angular.element('#Purchase_Order_DateTime_Unposted').datepicker('update', get_Date_Today)
                angular.element('#Purchase_Order_DateTime_Posted').datepicker('update', '1/01/01')
            }

            angular.element('#Purchase_Order_Amount_Paid').val(0)
        }

        else
        {
            var get_Date_Today = new Date().toISOString().slice(0,10)

            angular.element('#Purchase_Order_DateTime_Issue').datepicker('update', get_Date_Today)

            if (Purchase_Order_Status.val() == 'Posted')
            {   
                angular.element('#Purchase_Order_DateTime_Posted').datepicker('update', get_Date_Today)
                angular.element('#Purchase_Order_DateTime_Unposted').datepicker('update', $scope.Purchase_Order_DateTime_Unposted)
            }


            else if (Purchase_Order_Status.val() == 'Unposted')
            {
                angular.element('#Purchase_Order_DateTime_Unposted').datepicker('update', get_Date_Today)
                angular.element('#Purchase_Order_DateTime_Posted').datepicker('update', $scope.Purchase_Order_DateTime_Posted)
            }
        }
    }

    $scope.get_Purchase_Order_Information = function()
    {
        if (tbl_Purchase_Order_Material_Information.DataTable().rows().count() == 0)        
            return null

        else
        {
            var get_tbl_Purchase_Order_Material_Information_Value = []

            tbl_Purchase_Order_Material_Information.DataTable().rows().every(function()
            {
                get_tbl_Purchase_Order_Material_Information_Value.push
                ({
                    'Purchase_Order_Number_Child'       :  angular.element('#Purchase_Order_Number_Parent').val(), 
                    'Purchase_Order_Material_Identity'  :  this.data()[0],
                    'Purchase_Order_Quantity_Issued'    :  this.data()[6],
                    'Purchase_Order_Quantity_Served'    :  '0',
                    'Purchase_Order_Quantity_Balance'   :  this.data()[6],
                    'Purchase_Order_Employee_Identity'  :  User_Information.Identity

                })
            })

            return JSON.stringify(get_tbl_Purchase_Order_Material_Information_Value)
        }
    }


    $scope.Manage_Purchase_Order_Material = function(set_Action, set_Object)
    {
        var get_Data = tbl_Material_Information.DataTable().row(angular.element('#tbl_Material_Information #' + $scope.get_Element_Identity(set_Object)).closest('tr')).data()

        var get_Data_Index = tbl_Purchase_Order_Material_Information.DataTable().row(angular.element('#tbl_Purchase_Order_Material_Information #' + $scope.get_Element_Identity(set_Object)).closest('tr')).index()

        if (set_Action == 'Insert : Multiple')
        {
            angular.forEach(JSON.parse(set_Object), function(set_Value, set_Key)
            {
                get_Data = tbl_Material_Information.DataTable().row(angular.element('#tbl_Material_Information #' + set_Value['Purchase_Order_Material_Identity']).closest('tr')).data()

                tbl_Purchase_Order_Material_Information.DataTable().row.add(
                [
                    set_Value['Purchase_Order_Material_Identity'],
                    "<img class='rounded-circle' style = 'height: 8em' alt='No Image' src='" + get_Data['Material_Image_Path'] + "'>",
                    get_Data['Material_Part_Number'],
                    get_Data['Material_Description'],
                    get_Data['Material_Unit'],
                    get_Data['Material_Size'],
                    set_Value['Purchase_Order_Quantity_Issued'],
                    get_Data['Material_Price_Current'],                    
                    parseInt(get_Data['Material_Price_Current']) * parseInt(set_Value['Purchase_Order_Quantity_Issued']), 
                    "<button type = 'button' class = 'btn btn-outline-success mr-1 col-md' id = '" + set_Value['Purchase_Order_Material_Identity'] + "' ng-click = '" + 'Manage_Purchase_Order_Material("Update", $event)' + "'>Edit</button>" +
                    "<hr>" +
                    "<button type = 'button' class = 'btn btn-outline-danger col-md' id = '" + set_Value['Purchase_Order_Material_Identity'] + "' ng-click = '" + 'Manage_Purchase_Order_Material("Delete", $event)' + "'>Delete</button>"
                ]).draw()
            })
        }

        else if (set_Action == 'Delete')
            tbl_Purchase_Order_Material_Information.DataTable().row(get_Data_Index).remove().draw()

        else
        {
            $scope.get_Dialog_Choice.Dialog.Title = 'How many?'

            $scope.get_Dialog_Choice.Dialog.Closeable = false

            $scope.get_Dialog_Choice.btn_Ok.Visible = true
            $scope.get_Dialog_Choice.btn_No.Visible = true

            angular.element('#Dialog_Form_Choice').addClass('d-flex justify-content-center')

            $scope.get_Dialog_Choice.del_Dialog_Control()

            $scope.get_Dialog_Choice.set_Dialog_Control(
            "<div class = 'form-group col-md-3'>" +
                "<input type = 'text' name = 'Order_Material_Quantity' id = 'Order_Material_Quantity' class = 'form-control' required>" +
                "<label class = 'form-control-placeholder' for = 'Order_Material_Quantity'>Quantity</label>" +
            "</div>")

            $scope.get_Dialog_Choice.Show()

            let promise = new Promise(function(resolve, reject)
            {                
                angular.element('#btn_Ok_' + $scope.get_Dialog_Choice.Identity).click(function()
                {
                    resolve(true)
                })

                angular.element('#btn_No_' + $scope.get_Dialog_Choice.Identity).click(function()
                {                    
                    resolve(false)
                })

            }).then(function(set_Value)
            {
                if (set_Value)
                {
                    tbl_Purchase_Order_Material_Information.DataTable().rows().eq(0).each(function(set_Index)
                    {
                        var get_Data_Purchase_Order_Information = tbl_Purchase_Order_Material_Information.DataTable().row(set_Index).data()

                        if (get_Data_Purchase_Order_Information[0] == get_Data['Material_Identity'])                        
                            set_Action = 'Update'

                        console.log(get_Data_Purchase_Order_Information[0] + ', ' + get_Data['Material_Identity'] )
                    })

                    if (set_Action == 'Insert')
                    {                       

                        tbl_Purchase_Order_Material_Information.DataTable().row.add(
                        [
                            get_Data['Material_Identity'],
                            "<img class='rounded-circle' style = 'height: 8em' alt='No Image' src='" + get_Data['Material_Image_Path'] + "'>",
                            get_Data['Material_Part_Number'],
                            get_Data['Material_Description'],
                            get_Data['Material_Unit'],
                            get_Data['Material_Size'],                            
                            angular.element('#Order_Material_Quantity').val(),
                            get_Data['Material_Price_Current'],
                            parseInt(get_Data['Material_Price_Current']) * parseInt(angular.element('#Order_Material_Quantity').val()), 
                            "<button type = 'button' class = 'btn btn-outline-success mr-1 col-md' id = '" + get_Data['Material_Identity'] + "' ng-click = '" + 'Manage_Purchase_Order_Material("Update", $event)' + "'>Edit</button>" +
                            "<hr>" +
                            "<button type = 'button' class = 'btn btn-outline-danger col-md' id = '" + get_Data['Material_Identity'] + "' ng-click = '" + 'Manage_Purchase_Order_Material("Delete", $event)' + "'>Delete</button>"
                        ]).draw()                        
                    }

                    else if (set_Action == 'Update')
                    {        
                        if (angular.element('#Order_Material_Quantity').val() != 0)
                        {
                            tbl_Purchase_Order_Material_Information.DataTable().cell(get_Data_Index, 6).data(angular.element('#Order_Material_Quantity').val()).draw()
                            tbl_Purchase_Order_Material_Information.DataTable().cell(get_Data_Index, 8).data(parseInt(tbl_Purchase_Order_Material_Information.DataTable().cell(get_Data_Index, 6).data()) * parseInt(tbl_Purchase_Order_Material_Information.DataTable().cell(get_Data_Index, 7).data())).draw()
                        }

                        else
                            tbl_Purchase_Order_Material_Information.DataTable().row(get_Data_Index).remove().draw()
                    }

                    $rootScope.Material_List_Visible = false
                    $rootScope.Purchase_Order_Manage_Visible = true

                    $scope.get_Dialog_Choice.Hide()
                }               
                
                else
                    $scope.get_Dialog_Choice.Hide()

                angular.element('#Dialog_Form_Choice').removeClass('d-flex justify-content-center')
                
                $scope.get_Dialog_Choice.del_Dialog_Control()
            })
        }    
    }

    $scope.Select_Supplier_Information = function(set_Action, set_Object)
    {
        if (set_Action == 'Select : Specific')
            set_Action = ({'Action' :  set_Action, 'Supplier_Identity' : set_Object})

        Supplier_Information.Select_Supplier_Information(set_Action,

        function(set_Callback_Data)
        {
            if (set_Action['Action'] == 'Select : Specific')
            {
                var get_JSON = JSON.parse(set_Callback_Data)
                
                angular.element('#Purchase_Order_Supplier_Term').val(get_JSON[0]['Supplier_Term'])
                angular.element('#Supplier_Name').val(get_JSON[0]['Supplier_Name'])
                angular.element('#Supplier_Contact_BusinessAddress').val(get_JSON[0]['Supplier_Contact_BusinessAddress'])               
            }
        })
    }    

    $scope.Select_Material_Information = function(set_Element, set_Action)
    {
        if (set_Action == 'Select : All')
            set_Action = ({'Action' :  'Select : All'})

        Material_Information.Select_Material_Information(set_Action,

        function(set_Callback_Data)
        {
            if (set_Action['Action'] == 'Select : All')
            {
                $scope.Module_Loading_Visible = true
                $scope.LECSteelMC_Purchase_Order_Visible = false

                setTimeout(function () 
                {
                    tbl_Material_Information.DataTable(
                    {
                        dom : 'Bfrtip',

                        buttons :
                        {   
                            buttons :
                            [
                                {              
                                    text: 'Back',

                                    className: 'btn btn-outline-primary btn-lg',

                                    action: function()
                                    {
                                        $rootScope.Material_List_Visible = false
                                        $rootScope.Purchase_Order_Manage_Visible = true
                                    }
                                }
                            ]
                            
                        },

                        initComplete: function()
                        {
                            angular.element('.dt-button').removeClass('dt-button') 
                        },

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
                                    return  "<img class='rounded-circle' style = 'height: 8em' alt='No Image' src='" + data['Material_Image_Path'] + "'>"
                                }
                            },
                            
                            {   data : "Material_Part_Number"   },
                            {   data : "Material_Unit"  },
                            {   data : "Material_Size"  },
                            {   data : "Category_Name"  },
                            {   data : "Type_Name"  },
                            {   data : "Material_Price_Current"  },
                            
                            {
                                orderable : false, 
                                data : null,
                                width : '5em',
                                render : function (data)
                                { 
                                    return  "<button class = 'btn btn-outline-info col-md' id = '" + data['Material_Identity'] + "' ng-click = '" + 'Manage_Purchase_Order_Material("Insert", $event)' + "'>Add</button>"
                                }
                            }
                        ],

                        createdRow: function(row, data, index)
                        {
                            $compile(row)($scope);
                        }
                    })

                    $scope.Module_Loading_Visible = false
                    $scope.LECSteelMC_Purchase_Order_Visible = true

                }, 500)

                /*angular.element('#tbl_Material_Information tbody').on( 'click', 'td', function()
                {
                    alert( angular.element('#tbl_Material_Information').DataTable().cell( this ).data() );
                })*/
            }
         
        })
    }
}

/*-------------Engskie09_Purchase_Order-----------------*/
/*-------------Engskie09_Purchase_Order-----------------*/
/*-------------Engskie09_Purchase_Order-----------------*/
/*-------------Engskie09_Purchase_Order-----------------*/
/*-------------Engskie09_Purchase_Order-----------------*/