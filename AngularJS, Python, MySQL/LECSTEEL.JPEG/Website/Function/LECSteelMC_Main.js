import * as LECSteelMC_Dialog from './LECSteelMC_Dialog.js'

/* Main */

window.LECSteelMC = angular.module('LECSteelMC', ['ngRoute', 'ngCookies']);

LECSteelMC.config(function($routeProvider)
{
    $routeProvider

    .when('/Main',
    {
        templateUrl: "./Interface/LECSteelMC_Main.html", 
        controller: 'LECSteelMC_Main_Controller' 
    })

    .when('/Material',
    {
        templateUrl: "./Interface/Material/LECSteelMC_Material.html", 
        controller: 'LECSteelMC_Material_Controller' 
    })

    .when('/Material/Category',
    {
        templateUrl: "./Interface/Material/LECSteelMC_Material_Category.html", 
        controller: 'LECSteelMC_Material_Category_Controller' 
    })

    .when('/Material/Type',
    {
        templateUrl: "./Interface/Material/LECSteelMC_Material_Type.html", 
        controller: 'LECSteelMC_Material_Type_Controller' 
    })

    .when('/Client',
    {
        templateUrl: "./Interface/Client/LECSteelMC_Client.html", 
        controller: 'LECSteelMC_Client_Controller' 
    })

    .when('/Supplier',
    {
        templateUrl: "./Interface/Supplier/LECSteelMC_Supplier.html", 
        controller: 'LECSteelMC_Supplier_Controller' 
    })

    .when('/Supplier/Category',
    {
        templateUrl: "./Interface/Supplier/LECSteelMC_Supplier_Category.html", 
        controller: 'LECSteelMC_Supplier_Category_Controller' 
    })

    .when('/Employee',
    {
        templateUrl: "./Interface/Employee/LECSteelMC_Employee.html",
        controller: 'LECSteelMC_Employee_Controller'
    })

    .when('/Purchase_Order',
    {
        templateUrl: "./Interface/Purchase_Order/LECSteelMC_Purchase_Order.html",
        controller: 'LECSteelMC_Purchase_Order_Controller'
    })

    .when('/Receiving_Report',
    {
        templateUrl: "./Interface/Receiving_Report/LECSteelMC_Receiving_Report.html",
        controller: 'LECSteelMC_Receiving_Report_Controller'
    })

    .otherwise(
    {
        redirectTo: '/Main'
    });

});

LECSteelMC.factory('User_Information', [ function(){ return new LECSteelMC_Employee_Information.User_Information()}]);

/* Employee */
import * as LECSteelMC_Employee_Information from './LECSteelMC_Employee_Information.js'

LECSteelMC.factory('Employee_Information', [ function(){ return new LECSteelMC_Employee_Information.Employee_Information()}]);

import * as LECSteelMC_Employee from '../Interface/Employee/LECSteelMC_Employee.js'

LECSteelMC.controller('LECSteelMC_Employee_Controller', 
['$rootScope','$scope', '$compile', 'Employee_Information', LECSteelMC_Employee.LECSteelMC_Employee_Controller])


/* Client */
import * as LECSteelMC_Client_Information from './LECSteelMC_Client_Information.js'

LECSteelMC.factory('Client_Information', [ function(){ return new LECSteelMC_Client_Information.Client_Information()}]);

import * as LECSteelMC_Client from '../Interface/Client/LECSteelMC_Client.js'

LECSteelMC.controller('LECSteelMC_Client_Controller', 
['$rootScope','$scope', '$compile', 'Client_Information', LECSteelMC_Client.LECSteelMC_Client_Controller])


/* Supplier */
import * as LECSteelMC_Supplier_Information from './LECSteelMC_Supplier_Information.js'

LECSteelMC.factory('Supplier_Information', [ function(){ return new LECSteelMC_Supplier_Information.Supplier_Information()}]);

import * as LECSteelMC_Supplier from '../Interface/Supplier/LECSteelMC_Supplier.js'

LECSteelMC.controller('LECSteelMC_Supplier_Controller', 
['$rootScope','$scope', '$compile', 'Supplier_Information', LECSteelMC_Supplier.LECSteelMC_Supplier_Controller])


import * as LECSteelMC_Supplier_Category from '../Interface/Supplier/LECSteelMC_Supplier_Category.js'

LECSteelMC.controller('LECSteelMC_Supplier_Category_Controller', 
['$rootScope','$scope', '$compile', 'Supplier_Information', LECSteelMC_Supplier_Category.LECSteelMC_Supplier_Category_Controller])


/* Material */
import * as LECSteelMC_Material_Information from './LECSteelMC_Material_Information.js'

LECSteelMC.factory('Material_Information', [ function(){ return new LECSteelMC_Material_Information.Material_Information()}]);

import * as LECSteelMC_Material from '../Interface/Material/LECSteelMC_Material.js'

LECSteelMC.controller('LECSteelMC_Material_Controller', 
['$rootScope','$scope', '$compile', 'Material_Information', LECSteelMC_Material.LECSteelMC_Material_Controller])

import * as LECSteelMC_Material_Category from '../Interface/Material/LECSteelMC_Material_Category.js'

LECSteelMC.controller('LECSteelMC_Material_Category_Controller', 
['$rootScope','$scope', '$compile', 'Material_Information', LECSteelMC_Material_Category.LECSteelMC_Material_Category_Controller])

import * as LECSteelMC_Material_Type from '../Interface/Material/LECSteelMC_Material_Type.js'

LECSteelMC.controller('LECSteelMC_Material_Type_Controller', 
['$rootScope','$scope', '$compile', 'Material_Information', LECSteelMC_Material_Type.LECSteelMC_Material_Type_Controller])


/* Purchase Order */

import * as LECSteelMC_Purchase_Order_Information from './LECSteelMC_Purchase_Order_Information.js'

LECSteelMC.factory('Purchase_Order_Information', [ function(){ return new LECSteelMC_Purchase_Order_Information.Purchase_Order_Information()}]);

import * as LECSteelMC_Purchase_Order from '../Interface/Purchase_Order/LECSteelMC_Purchase_Order.js'

LECSteelMC.controller('LECSteelMC_Purchase_Order_Controller', 
['$rootScope','$scope', '$compile', 'Purchase_Order_Information', 'Supplier_Information', 'Material_Information', 'User_Information', LECSteelMC_Purchase_Order.LECSteelMC_Purchase_Order_Controller])

/* Purchase Order */

import * as LECSteelMC_Receiving_Report_Information from './LECSteelMC_Receiving_Report_Information.js'

LECSteelMC.factory('Receiving_Report_Information', [ function(){ return new LECSteelMC_Receiving_Report_Information.Receiving_Report_Information()}]);

import * as LECSteelMC_Receiving_Report from '../Interface/Receiving_Report/LECSteelMC_Receiving_Report.js'

LECSteelMC.controller('LECSteelMC_Receiving_Report_Controller', 
['$rootScope','$scope', '$compile', 'Receiving_Report_Information', 'Purchase_Order_Information', 'Supplier_Information', 'Material_Information', 'User_Information', LECSteelMC_Receiving_Report.LECSteelMC_Receiving_Report_Controller])

LECSteelMC.controller('LECSteelMC_Main_Controller', 
[   '$rootScope','$scope', '$compile', '$cookies', '$window', '$interval', 'User_Information',
function
(
     $rootScope,  $scope,   $compile,   $cookies,   $window,   $interval, User_Information
)
{

    //set Interfaces path
    $scope.LECSteelMC_Header_Link = 'Interface/LECSteelMC_Header.html'
    $scope.LECSteelMC_Footer_Link = 'Interface/LECSteelMC_Footer.html'    
    $scope.LECSteelMC_Sidebar_Link = 'Interface/LECSteelMC_Sidebar.html'
    $scope.LECSteelMC_Main_Link = 'Interface/LECSteelMC_Main.html' 

    $scope.alert = alert.bind($window);

    $scope.scope = $scope
    $scope.cookies = $cookies    

    angular.element('#Preload_Message').text('Downloading all Web components please wait.....')    
    $scope.Session_Available = false

    $scope.User_Information = User_Information

    User_Information.set_Library($scope, $cookies)

    $scope.onload = function()
    {
        $scope.get_Dialog_Login = new LECSteelMC_Dialog.Dialog('get_Dialog_Login', 'Login')
        $scope.get_Dialog_Wait = new LECSteelMC_Dialog.Dialog('get_Dialog_Wait', 'Wait')
        $scope.get_Dialog_Choice = new LECSteelMC_Dialog.Dialog('get_Dialog_Choice', 'Choice')
        $scope.get_Dialog_Image = new LECSteelMC_Dialog.Dialog('get_Dialog_Image', 'Image')
        
        console.log('Page has been loaded successfully.')
        
        $scope.Session_Available = true
        
        $scope.ewan = $interval(function()
        {           

            if(!User_Information.check_User_Session())
            {
                $scope.Session_Available = false

                if ($scope.get_Dialog_Login.check_Visible_Value())
                    return null

                angular.element('#Preload_Message').html("<p data-toggle = 'modal' ng-click = 'get_Dialog_Login.Show()'>Download Done <i class='far fa-check-circle fa-lg' style='color: #EB6864;'></i> (No Session Detected)</p>")

                $compile(angular.element('#Preload_Message'))($scope)                

                if (!$scope.get_Dialog_Login.check_Dialog_Control())
                {
                    $scope.get_Dialog_Login.Dialog.Title = 'Enter Your Credentials'              

                    $scope.get_Dialog_Login.Dialog.Closeable = false
                   
                    $scope.get_Dialog_Login.btn_Ok.Text = 'Login'
                    $scope.get_Dialog_Login.btn_Ok.Interface = 'btn btn-outline-primary'
                    $scope.get_Dialog_Login.btn_Ok.Click = "User_Information.set_Library(scope, cookies); User_Information.get_User_Information('Select : Specific : { Employee_Username, Employee_Username }', get_Dialog_Login, get_Dialog_Login.get_Dialog_Control_Data('', ''), null)"                   

                    $scope.get_Dialog_Login.btn_No.Visible = false;
                    
                    $scope.get_Dialog_Login.set_Dialog_Control(LECSteelMC_Dialog.Form_Interface_Login)
                    $scope.get_Dialog_Login.Compile($compile, $scope)                    
                }
                

                $scope.get_Dialog_Login.Show()
            }

            else
            {
                if ($scope.Session_Available == true)
                    return null

                angular.element('#Preload_Message').html("<p>Download Done <i class='far fa-check-circle fa-lg' style='color: #EB6864;'></i>(Session Detected, Dashboard initiating...)</p>")

                $scope.get_Dialog_Login.Hide()

                setTimeout(function () 
                {
                    User_Information.get_User_Information('Select : Specific : { Employee_Identity }', null ,  $cookies.get('Identity'), 
                    function(set_Callback)
                    {           
                        
                        if ($scope.set_User_Information(set_Callback))
                        {                           
                            $scope.Session_Available = true
                            angular.element('#New_Dialog_' + $scope.get_Dialog_Login.Identity).remove()
                            
                        }

                        else
                        {
                            $scope.Session_Available = false
                            angular.element('#Preload_Message').html("<p>Download Done <i class='far fa-check-circle fa-lg' style='color: #EB6864;'></i>(Cannot proceed.)</p>")
                        }

                    }.bind(this))              
                    
                }, 1000)

                
            }
            
        }, 1500)
    }  

    $scope.set_User_Information = function(set_User_Information)
    {        
        //console.log(set_User_Information)
        if (set_User_Information != false)
        {
            $scope.User_Fullname = set_User_Information['Employee_FirstName'] + ' ' + set_User_Information['Employee_MiddleName'] + ' ' + set_User_Information['Employee_LastName']

            return true
        }       
    }

    $scope.set_Login_Session = function(set_Data)
    {      
        
        if (set_Data == 'Display Loading')
        {
            $scope.get_Dialog_Login.Loading.Visible = true
            $scope.get_Dialog_Login.btn_Ok.Visible = false

            return null
        }

        if (set_Data == false)
        {

            $scope.get_Dialog_Login.Loading.Visible = false

            $scope.get_Dialog_Login.Alert.Interface = 'alert alert-dismissible alert-primary'
            $scope.get_Dialog_Login.Alert.Title = 'Server Error...'
            $scope.get_Dialog_Login.Alert.Message = 'Try Again in few moments...'
            $scope.get_Dialog_Login.Alert.Visible = true

            setTimeout(function () 
            { 
                $scope.get_Dialog_Login.Form.Visible = true
                $scope.get_Dialog_Login.btn_Ok.Visible = true

            }, 2000)


            return set_Data
        }

        else
        {
            $scope.get_Dialog_Login.Loading.Visible = false

            //Login success
            if (set_Data != 'No Data')
            {
                $scope.get_Dialog_Login.Alert.Interface = 'alert alert-dismissible alert-success'
                $scope.get_Dialog_Login.Alert.Title = 'Success...'
                $scope.get_Dialog_Login.Alert.Message = 'You will be redirect to Dashboard in few moments...'
                $scope.get_Dialog_Login.Alert.Visible = true

                setTimeout(function () 
                {
                    User_Information.set_User_Cookie(set_Data)                              
                }.bind(this), 2000)
            }

            //Wrong credential
            else
            {
                $scope.get_Dialog_Login.Alert.Interface = 'alert alert-dismissible alert-primary'
                $scope.get_Dialog_Login.Alert.Title = 'Cannot Login...'
                $scope.get_Dialog_Login.Alert.Message = 'Try Again in few moments...'
                $scope.get_Dialog_Login.Alert.Visible = true

                setTimeout(function () 
                { 
                    $scope.get_Dialog_Login.Form.Visible = true
                    $scope.get_Dialog_Login.btn_Ok.Visible = true

                }, 2000)
            }
        }        
    }

    $scope.set_Logout_Session = function()
    {
        $cookies.remove('Identity')
        $cookies.remove('Username')
        $cookies.remove('Password')       

        $scope.get_Dialog_Login = new LECSteelMC_Dialog.Dialog('get_Dialog_Login', 'Login')
    }

    $scope.Execution_Delay = async function(set_Seconds)
    {
        (function()
        {
            console.log('Execution Delay: ' + set_Seconds + ' Seconds.')

            var start = new Date().getTime()
            
            for (var i = 0; i < 1e7; i++)
            {
                if ((new Date().getTime() - start) > set_Seconds * 1000)
                {
                    break
                }
            }
        })()       
    }

    $scope.Execution_Pause_Status = false

    $scope.Execution_Pause = function (set_Boolean)
    {
        (async function()
        {
            $scope.Execution_Pause_Status = set_Boolean
            
            while ($scope.Execution_Pause_Status)
            {
                $scope.Execution_Delay(1)
            }
        })()
    }

    $scope.Sidebar_Toggle = function()
    {

        angular.element("body").toggleClass("sidebar-toggled")
        
        angular.element(".sidebar").toggleClass("toggled")

        if (angular.element(".sidebar").hasClass("toggled"))
        {
            angular.element('.sidebar .collapse').collapse('hide')
        }
    }

    //Control Event

    $scope.set_Image_Upload_Preview = function(set_Input_Identity, set_Image_Identity)
    {
        angular.element('#' + set_Input_Identity).change(function()
        {
            var get_Image = document.querySelector('#' + set_Image_Identity)
            var get_Input    = document.querySelector('#' + set_Input_Identity).files[0]
            var get_FileReader  = new FileReader();

            get_FileReader.onloadend = function(Show_Dialog_Image)
            {
                get_Image.src = get_FileReader.result
            }

            if(get_Input)                
                get_FileReader.readAsDataURL(get_Input)
            
            else               
                get_Image.src = ""
            
        })
    }    
    
    $scope.Show_Dialog_Image = function(set_Element)
    {        

        $scope.get_Dialog_Image.Dialog.Title = ''
        $scope.get_Dialog_Image.btn_Ok.Visible = false
        $scope.get_Dialog_Image.btn_No.Visible = false
        
        $scope.get_Dialog_Image.set_Dialog_Control('<img class  = "col-md" id = "Image_Content" height="auto" width = "auto">')
        
        document.querySelector('#Image_Content').src = document.querySelector('#' + $scope.get_Element_Identity(set_Element)).src

        $scope.get_Dialog_Image.Show()
    }
    
    $scope.Input_Number_Validation = function(set_Identity, set_Type, set_Min, set_Max)
    {        
        var get_Element = angular.element('#' + set_Identity)

        var get_Regular_Expression = null

        if (set_Type == 'Natural')
        {
            get_Regular_Expression = /[0-9]/;
            
            get_Element.keypress(function(set_Event)
            {                
                if( !get_Regular_Expression.test(set_Event.key))
                    set_Event.preventDefault()                
            })

            get_Element.attr('min', set_Min)
            get_Element.attr('max', set_Max)
        }

        else if (set_Type == 'Decimal')
        {
            get_Element.change(function()
            {
                this.value = parseFloat(this.value).toFixed(2)
            })

            get_Regular_Expression = /[0-9]|\./;
            
            get_Element.keypress(function(set_Event)
            {                
                if( !get_Regular_Expression.test(set_Event.key))
                    set_Event.preventDefault()                
            })

            get_Element.attr('min', set_Min)
            get_Element.attr('max', set_Max)

            get_Element.attr('step', 0.01)
        }

    }

    $scope.get_Element_Identity = function(set_Element)
    {
        return angular.element(set_Element.target).attr("id")
    }  

    $scope.set_Path_Action = function(set_Path, set_Action)
    {

        window.location.href = '#!/' + set_Path

        console.log(set_Path)        

        if (set_Path == 'Material')
        {
            if (set_Action == 'Display')
            {            
                $rootScope.Material_List_Visible = true
                $rootScope.Material_Manage_Visible = false
            }

            else
            {                
                $rootScope.Material_List_Visible = false
                $rootScope.Material_Manage_Visible = true
            }    

            $rootScope.set_Material_Action(set_Action)      
        }

        else if (set_Path == 'Material/Category')
        {
            if (set_Action == 'Display')
            {            
                $rootScope.Material_Category_List_Visible = true
                $rootScope.Material_Category_Manage_Visible = false
            }

            else
            {                
                $rootScope.Material_Category_List_Visible = false
                $rootScope.Material_Category_Manage_Visible = true
            }    

            $rootScope.set_Material_Category_Action(set_Action)      
        }

        else if (set_Path == 'Material/Type')
        {
            if (set_Action == 'Display')
            {            
                $rootScope.Material_Type_List_Visible = true
                $rootScope.Material_Type_Manage_Visible = false
            }

            else
            {                
                $rootScope.Material_Type_List_Visible = false
                $rootScope.Material_Type_Manage_Visible = true
            }    

            $rootScope.set_Material_Type_Action(set_Action)      
        }
        
        else if (set_Path == 'Employee')
        {
            if (set_Action == 'Display')
            {            
                $rootScope.Employee_List_Visible = true
                $rootScope.Employee_Manage_Visible = false
            }

            else
            {                
                $rootScope.Employee_List_Visible = false
                $rootScope.Employee_Manage_Visible = true
            }    

            $rootScope.set_Employee_Action(set_Action)      
        }

        else if(set_Path == 'Client')
        {
            if (set_Action == 'Display')
            {            
                $rootScope.Client_List_Visible = true
                $rootScope.Client_Manage_Visible = false
            }

            else
            {                
                $rootScope.Client_List_Visible = false
                $rootScope.Client_Manage_Visible = true
            }    

            $rootScope.set_Client_Action(set_Action)      
        }

        else if(set_Path == 'Supplier')
        {
            if (set_Action == 'Display')
            {

                 $rootScope.Supplier_List_Visible = true
                 $rootScope.Supplier_Manage_Visible = false
            }

            else
            {
                $rootScope.Supplier_List_Visible = false
                $rootScope.Supplier_Manage_Visible = true
            }

            $rootScope.set_Supplier_Action(set_Action)        
        }


        else if(set_Path == 'Supplier/Category')
        {
            if (set_Action == 'Display')
            {
                $rootScope.Supplier_Category_List_Visible = true
                $rootScope.Supplier_Category_Manage_Visible = false
            }

            else
            {
                $rootScope.Supplier_Category_List_Visible = false
                $rootScope.Supplier_Category_Manage_Visible = true
            }

            $rootScope.set_Supplier_Category_Action(set_Action)        
        }

        else if(set_Path == 'Purchase_Order')
        {
            if (set_Action == 'Display')
            {
                $rootScope.Purchase_Order_List_Visible = true
                $rootScope.Purchase_Order_Manage_Visible = false
            }

            else
            {
                $rootScope.Purchase_Order_List_Visible = false
                $rootScope.Purchase_Order_Manage_Visible = true                
            }

            $rootScope.Material_List_Visible = false
            
            $rootScope.set_Purchase_Order_Action(set_Action)        
        }

        else if(set_Path == 'Receiving_Report')
        {
            if (set_Action == 'Display')
            {                   
                $rootScope.Receiving_Report_Manage_Visible = false
            }

            else
            {
                $rootScope.Receiving_Report_Manage_Visible = true
                $rootScope.Purchase_Order_List_Visible = false
            }

            $rootScope.set_Receiving_Report_Action(set_Action)
        }

    }

}])