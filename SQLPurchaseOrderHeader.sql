SELECT PUR.po_id, 
	PUR.carrier_nm,
	PUR.drop_ship_fl,
	PUR.fob_terms_cd,
	PUR.freight_cd, 
	PUR.comm_meth_cd, 
	PUR.payment_terms_cd, 
	PUR.supplier_id,
	PUR.buyer_assoc_id, 
	PUR.entered_dt, 
	PUR.order_tx, 
	PUR.drop_ship_sales_ord_id, 
	ship_address.street_addr AS ShipStreet, 
	ship_address.city_nm AS ShipCity, 
	ship_address.state_cd AS ShipState, 
	ship_address.zip_cd AS ShipZip, 
    ship_address.country_cd AS ShipCountry, 
    bill_address.street_addr AS BillStreet, 
    bill_address.city_nm AS BillCity, 
    bill_address.state_cd AS BillState, 
    bill_address.zip_cd AS BillZip, 
    bill_address.country_cd AS BillCountry, 
    bill_name.nm as Billnm, 
    ship_name.nm AS Shipnm,
	PUR.revision_nbr,
	payterms_desc.code_desc AS PayTermsDesc,
	freight_terms_desc.code_desc AS FrtTermsDesc,
	comm_meth_desc.code_desc AS CommMthdDesc,
	BuyAssociate.[assoc_nbr] AS BuyAssocNbr,
	supplier.supplier_nbr,
	sales_order.cust_po_nbr,
	name.nm as BuyAssocName
FROM purchase_order PUR 

LEFT OUTER JOIN 
	name ship_name 
	ON  
	PUR.po_id = ship_name.obj_id 
	AND  
	ship_name.nm_type_cd = 'ship' 
	AND 
	ship_name.obj_nm = 'Purchase_Order'
LEFT OUTER JOIN 
	name bill_name
	ON  
	PUR.po_id = bill_name.obj_id 
	AND  
	bill_name.nm_type_cd = 'bill' 
	AND  
	bill_name.obj_nm = 'Purchase_Order' 
LEFT OUTER JOIN 
	   address bill_address
	ON  
	PUR.po_id = bill_address.obj_id 
	AND  
	bill_address.addr_type_cd = 'STND' 
	AND  
	bill_address.obj_nm = 'Purchase_Order' 
LEFT OUTER JOIN
     address AS ship_address 
     ON ship_address.obj_id = PUR.po_id 
     AND ship_address.addr_type_cd = 'ship' 
     AND ship_address.obj_nm = 'Purchase_Order'    
LEFT OUTER JOIN
	 code_desc AS payterms_desc   
	 ON payterms_desc.code = PUR.payment_terms_cd
	 AND payterms_desc.field_nm = 'payment_terms_cd' 
LEFT OUTER JOIN
	 code_desc AS freight_terms_desc   
	 ON freight_terms_desc.code = PUR.fob_terms_cd
	 AND freight_terms_desc.field_nm = 'fob_terms_cd' 
LEFT OUTER JOIN
	 code_desc AS comm_meth_desc 
	 ON comm_meth_desc.code = PUR.comm_meth_cd
	 AND comm_meth_desc.field_nm = 'comm_meth_cd' 	
LEFT OUTER JOIN
	 associate AS BuyAssociate
     ON BuyAssociate.assoc_id = PUR.buyer_assoc_id
LEFT OUTER JOIN
	 Name
	 ON name.obj_id = PUR.buyer_assoc_id
	 AND Name.nm_type_cd = 'STND'
	 AND name.obj_nm = 'associate'
LEFT OUTER JOIN
	 supplier
	 ON supplier.supplier_id =  PUR.supplier_id
LEFT OUTER JOIN
	 sales_order
	 ON sales_order.sales_ord_id = PUR.drop_ship_sales_ord_id

WHERE PUR.po_id = 35365