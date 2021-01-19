<?php


    class SystemMethods_UserSession 
    {

        public $getdbServername = "localhost";
        public $getdbUsername = "u596257514_root";
        public $getdbPassword = "dreambiG1220";
        public $getdbName = "u596257514_tvs";

        //Check if have a connection;
        public function checkDBconnection()
        {
            global $MySqliConnection;

            $MySqliConnection =  mysqli_connect($this->getdbServername, $this->getdbUsername, $this->getdbPassword, $this->getdbName);

            if(mysqli_connect_errno())
            {
                echo "<script>alert ('Connection Error');</script>";
            }                   
        }

        public function insert_offender_information($a1, $a2, $a3, $a4, $a5, $a6, $a7, $a8, $a9)
        {
            global $MySqliConnection

            

            $queryColumns = "(que_no, plate_no, vehicle_type, vehicle_status, balance, violation_no, encoded_date, Full_Name, Address)";
            $queryValues = "('$a1', '$a2', '$a3', '$a4', '$a5', '$a6', '$a7', '$a8', '$a9')";

            $queryInsert = "INSERT INTO offense $queryColumns VALUES $queryValues;";

            $queryExecute = mysqli_query($MySqliConnection, $queryInsert);

        }
    }

    //Declare an object for SystemMethods_GeneralSession;
    $SystemMethods_UserSession = new SystemMethods_UserSession;

    //Call the method from the object SystemMethods_GeneralSession to check if connection is available;
    $SystemMethods_UserSession->checkDBconnection();

    if (isset($_POST["Offender"]))
    {
        if($_POST["Offender"] == "Offender") 
        {
            $array_offenderQueueingNumber = explode(',',$_POST["set_offenderQueueingNumber"]);
            $array_offenderFirstName      = explode(',',$_POST["set_offenderFirstName"]);
            $array_offenderMiddleName     = explode(',',$_POST["set_offenderMiddleName"]);
            $array_offenderLastName       = explode(',',$_POST["set_offenderLastName"]);         
            $array_offenderAddress        = explode(',',$_POST["set_offenderAddress"]);

            //$array_offenderLicenseNumber  = explode(',',$_POST["set_offenderLicenseNumber"]);
            $array_offenderPlateNumber    = explode(',',$_POST["set_offenderPlateNumber"]);
            $array_vehicleType            = explode(',',$_POST["set_vehicleType"]);
            $array_vehicleStatus          = explode(',',$_POST["set_vehicleStatus"]);
            
            //$array_offenseName            = explode(',',$_POST["set_offenseName"]);
            $array_offenseFee             = explode(',',$_POST["set_offenseFee"]);
            //$array_offensePenalty         = explode(',',$_POST["set_offensePenalty"]);
            //$array_offenseClass           = explode(',',$_POST["set_offenseClass"]);
            
            $array_offenseCode            = explode(',',$_POST["set_offenseCode"]);
            $array_offenseDate            = explode(',',$_POST["set_offenseDate"]);

            $count = count($array_offenderQueueingNumber);
            
            //echo $count;

            //$SystemMethods_UserSession->insert_offender_information();
            
            for ($wew = 0; $wew < $count; $wew++)
            {
                $fullname = $array_offenderFirstName[$wew]." ".$array_offenderMiddleName[$wew]." ".$array_offenderLastName[$wew];
                $SystemMethods_UserSession->insert_offender_information("000".$array_offenderQueueingNumber[$wew], $array_offenderPlateNumber[$wew], $array_vehicleType[$wew], $array_vehicleStatus[$wew] ,$array_offenseFee[$wew] ,$array_offenseCode[$wew], $array_offenseDate[$wew],$fullname, $array_offenderAddress[$wew]);
            }
            
            echo "success!!!";
         
         
       
        }

    }


    
    

 ?>