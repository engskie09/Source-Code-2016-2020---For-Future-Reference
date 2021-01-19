window.onload = function()
{
	//alert("Testing");	

}

//Get Current Button
function get_currentButton(control, set_currentButton)
{
	//Product
	if(set_currentButton == "btn_addProduct")
	{
		insert_product_information();			
	}

	else if(set_currentButton == "btn_acceptOrder")
	{
		accept_product_order_information(control.id);			
	}

	else if(set_currentButton == "btn_declineOrder")
	{
		decline_product_order_information(control.id);	
	}

	else if(set_currentButton == "btn_deleteProduct")
	{
		delete_product_information(control.id);	
	}

	
}

//current Navigation
function aTag_getCurrentNavigationBar(set_aTagValue)
{
	if (set_aTagValue == "Product_List")
	{				
		get_ProductTable();
		set_tagDisplay(set_aTagValue);			
	}

	else if (set_aTagValue == "PendingTransaction_List")
	{				
		get_PendingTransactionTable("Pending");
		set_tagDisplay(set_aTagValue);			
	}

	else if (set_aTagValue == "PastTransaction_List")
	{				
		get_PendingTransactionTable("Accept/Decline");
		set_tagDisplay("PendingTransaction_List");			
	}

}

function set_tagDisplay(set_tagID)
{

	var div_Product_List = document.getElementById("Product_List");
	var div_PendingTransaction_List = document.getElementById("PendingTransaction_List");	

	div_Product_List.style.display = "none";
	div_PendingTransaction_List.style.display = "none";

	var get_tagID = document.getElementById(set_tagID);
	get_tagID.style.display = "block";	

}



function delete_product_information(set_ProductID)
{
	var data = "Admin=delete_product_information" + "&set_ProductID=" + set_ProductID ;

	$.ajax({

		url: "MasalloSystemMethodsXD/MasalloSystemMethods_GeneralSessionBukasNaPotek.php",
		type: "POST",
		data: data,

		success: function(response)
		{
			alert(response);
			get_ProductTable();			
		}
	});		
}

function accept_product_order_information(set_OrderID)
{
	var data = "Admin=accept_product_order_information" + "&set_OrderID=" + set_OrderID ;

	$.ajax({

		url: "MasalloSystemMethodsXD/MasalloSystemMethods_GeneralSessionBukasNaPotek.php",
		type: "POST",
		data: data,

		success: function(response)
		{
			get_PendingTransactionTable();
			//alert(response);
		}
	});		
}

function decline_product_order_information(set_OrderID)
{
	var data = "Admin=decline_product_order_information" + "&set_OrderID=" + set_OrderID ;

	$.ajax({

		url: "MasalloSystemMethodsXD/MasalloSystemMethods_GeneralSessionBukasNaPotek.php",
		type: "POST",
		data: data,

		success: function(response)
		{
			get_PendingTransactionTable();
			//alert(response);
		}
	});		
}



/*

░░░░░░░░░╔═══╗░░░░░░╔╗░░░░░╔╗░░░░░░░░░░░░░
░░░░░░░░░║╔═╗║░░░░░░║║░░░░╔╝╚╗░░░░░░░░░░░░
░░░░░░░░░║╚═╝╠═╦══╦═╝╠╗╔╦═╩╗╔╬══╗░░░░░░░░░
╔══╦══╦══╣╔══╣╔╣╔╗║╔╗║║║║╔═╣║║══╬══╦══╦══╗
╚══╩══╩══╣║░░║║║╚╝║╚╝║╚╝║╚═╣╚╬══╠══╩══╩══╝
░░░░░░░░░╚╝░░╚╝╚══╩══╩══╩══╩═╩══╝░░░░░░░░░

*/

class set_ProductTable
{
	constructor(setProduct_ID, setProduct_Name, setProduct_Price, setProduct_Quantity, setProduct_Description, setProduct_Image, setProduct_Action)
	{		
		$('#tbl_ProductList').DataTable();
		$('.dataTables_length').addClass('bs-select');

		var t = $('#tbl_ProductList').DataTable();    	
    	

    	t.row.add( [
    		setProduct_ID,
            setProduct_Name,
            setProduct_Price,
            setProduct_Quantity,
            setProduct_Description,
            setProduct_Image,
            setProduct_Action

        ] ).draw( false );

	}
}


function get_ProductTable()
{
	var data = "Admin=get_product_information";

	$.ajax({

		url: "MasalloSystemMethodsXD/MasalloSystemMethods_GeneralSessionBukasNaPotek.php",
		type: "POST",
		data: data,

		success: function(response)
		{

			//alert(response);
		
			var list_Product_ID = [];
			var list_Product_Name = [];
			var list_Product_Price = [];
			var list_Product_Quantity = [];
			var list_Product_Description = []; 
			var list_Product_Image = [];
			var list_Product_Action = [];


			document.getElementById("tblBody_ProductList").innerHTML = response;
			var t = $('#tbl_ProductList').DataTable();
			
			
			var rowCount = document.getElementById('tbl_ProductList').rows.length;
		
			for (var i = 1; i < rowCount; i++)
			{						
				list_Product_ID.push				(document.getElementById("tbl_ProductList").rows[i].cells[0].innerHTML);
				list_Product_Name.push				(document.getElementById("tbl_ProductList").rows[i].cells[1].innerHTML);
				list_Product_Price.push				(document.getElementById("tbl_ProductList").rows[i].cells[2].innerHTML);
				list_Product_Quantity.push			(document.getElementById("tbl_ProductList").rows[i].cells[3].innerHTML);
				list_Product_Description.push		(document.getElementById("tbl_ProductList").rows[i].cells[4].innerHTML);
				list_Product_Image.push				(document.getElementById("tbl_ProductList").rows[i].cells[5].innerHTML);
				list_Product_Action.push			(document.getElementById("tbl_ProductList").rows[i].cells[6].innerHTML);			
				
			}				

			$('#tblBody_ProductList').empty();
			var t = $('#tbl_ProductList').DataTable();
			t.rows().remove().draw();
			
			for (var i = 0; i < rowCount - 1; i++)
			{
				var xD = new set_ProductTable(
					list_Product_ID[i], 
					list_Product_Name[i],
					list_Product_Price[i],
					list_Product_Quantity[i],
					list_Product_Description[i],
					list_Product_Image[i],
					list_Product_Action[i]);
										
			}
	
		}
	});		
}



function insert_product_information()
{	
	var form = document.querySelector("#form_addProduct");
	var formData = new FormData(form);
	formData.append('Admin', 'insert_product_information');
	
	for (var value of formData.values()) {
	   console.log(value); 
	}

	$.ajax({
		url: "MasalloSystemMethodsXD/MasalloSystemMethods_GeneralSessionBukasNaPotek.php",		
		type: "POST",
		data: formData,
		contentType: false,       
	    cache: false,             
	    processData:false, 

		success: function(response)
		{
			//alert(response);
			get_ProductTable();
		}});	
}

class set_PendingTransactionTable
{
	constructor(setProduct_ID, setProduct_Name, setProduct_Quantity, setProduct_Action)
	{		
		$('#tbl_PendingTransactionList').DataTable();
		$('.tbl_PendingTransactionList').addClass('bs-select');

		var t = $('#tbl_PendingTransactionList').DataTable();    	
    	

    	t.row.add( [
    		setProduct_ID,
            setProduct_Name,
            setProduct_Quantity,
            setProduct_Action

        ] ).draw( false );

	}
}


function get_PendingTransactionTable(set_Status)
{
	var data = "Admin=get_product_order_information" + "&get_Status=" + set_Status;

	$.ajax({

		url: "MasalloSystemMethodsXD/MasalloSystemMethods_GeneralSessionBukasNaPotek.php",
		type: "POST",
		data: data,

		success: function(response)
		{

			//alert(response);
		
			var list_Product_ID = [];
			var list_Product_Name = [];
			var list_Product_Quantity = [];
			var list_Product_Action = [];


			document.getElementById("tblBody_PendingTransactionList").innerHTML = response;
			var t = $('#tbl_PendingTransactionList').DataTable();
			
			
			var rowCount = document.getElementById('tbl_PendingTransactionList').rows.length;
		
			for (var i = 1; i < rowCount; i++)
			{						
				list_Product_ID.push				(document.getElementById("tbl_PendingTransactionList").rows[i].cells[0].innerHTML);
				list_Product_Name.push				(document.getElementById("tbl_PendingTransactionList").rows[i].cells[1].innerHTML);
				list_Product_Quantity.push				(document.getElementById("tbl_PendingTransactionList").rows[i].cells[2].innerHTML);
				list_Product_Action.push			(document.getElementById("tbl_PendingTransactionList").rows[i].cells[3].innerHTML);			
				
			}				

			$('#tblBody_PendingTransactionList').empty();
			var t = $('#tbl_PendingTransactionList').DataTable();
			t.rows().remove().draw();
			
			for (var i = 0; i < rowCount - 1; i++)
			{
				var xD = new set_PendingTransactionTable(
					list_Product_ID[i], 
					list_Product_Name[i],
					list_Product_Quantity[i],
					list_Product_Action[i]);
										
			}
	
		}
	});		
}







