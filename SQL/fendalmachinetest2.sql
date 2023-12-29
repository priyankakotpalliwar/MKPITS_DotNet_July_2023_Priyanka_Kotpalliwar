create table TableProductGDTDetails(product_Gst_id int
,Gst_detail_Name varchar(500),CGST decimal,SGST DECIMAL ,IGST decimal,
PRIMARY KEY(CGST,SGST,IGST))

SELECT * FROM TableProductGDTDetails

create table TableproductCategory(ProductCategoryID int PRIMARY KEY,
ProductTypeName varchar(500),Product_GST_ID int )

create table TableProduct(ProductID int, ProductTypeID int, ProductName varchar(500))


create table TableInvoiceDetails(Invoice_detailID int,CustomerName varchar(500),
Customer_contact varchar(15),ProductCategoryID int foreign key references TableproductCategory(ProductCategoryID),
product_ID INT,ResidentialTypeID int,Invoice_Date datetime,quantity decimal,Price decimal,CGST decimal foreign key TableProductGDTDetails(CGST))