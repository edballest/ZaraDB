---Vendor,Address,Category---
CREATE TABLE Vendor(
vendor_name		VARCHAR(20) PRIMARY KEY,
country			VARCHAR(20),
delivery_method	VARCHAR(20),
delivery_time	INT)

CREATE TABLE Category(
type			VARCHAR(20) PRIMARY KEY,
category		VARCHAR(20))

CREATE TABLE Adresses(
address_id		CHAR(5) PRIMARY KEY,
country			VARCHAR(20),
city			VARCHAR(20),
street			VARCHAR(20),
number			VARCHAR(5),
apartment		VARCHAR(5),
zip_code		CHAR(5))

---Store,Customer,Product---

CREATE TABLE Customer(
customer_id		INT PRIMARY KEY,
email			NVARCHAR(20) NOT NULL,
password		NVARCHAR(20) NOT NULL,
address_id		CHAR(5),
first_name		NVARCHAR(20),
middle_name		NVARCHAR(20),
last_name		NVARCHAR(20),				
FOREIGN KEY (address_id) REFERENCES Adresses)

CREATE TABLE Product(
UPC_code		NVARCHAR(14) PRIMARY KEY,
description		NVARCHAR(MAX),
type			VARCHAR(20),
department		VARCHAR(20),
size			AS SUBSTRING(UPC_code,10,2),
color			AS SUBSTRING(UPC_code,12,3),
FOREIGN KEY (type) REFERENCES Category)

CREATE TABLE Store(
store_id		CHAR(5) PRIMARY KEY,
opens			TIME,
closes			TIME,
max_inventory	INT not null,
address_id		CHAR(5),
FOREIGN KEY (address_id) references Addresses)



---Credit Card, Transaction, Supplies, Inventory---

CREATE TABLE Credit_Card(
customer_id		INT,
number			INT,
PRIMARY KEY (customer_id,number),
FOREIGN KEY (customer_id) REFERENCES Customer)


CREATE TABLE Transact(
UPC_code		NVARCHAR(14),
customer_id		INT,
store_id		CHAR(5),
quantity		INT,
date_time		SMALLDATETIME,	
PRIMARY KEY (UPC_code,customer_id,store_id),
FOREIGN KEY (UPC_code) REFERENCES Product,
FOREIGN KEY (customer_id) REFERENCES Customer,
FOREIGN KEY (store_id) REFERENCES Store
)

CREATE TABLE Supplies(
vendor_name		VARCHAR(20),
store_id		CHAR(5),
UPC_code		NVARCHAR(14),
PRIMARY KEY(vendor_name, store_id, UPC_code),
FOREIGN KEY (vendor_name) references Vendor,
FOREIGN KEY (store_id) references Store,
FOREIGN KEY (UPC_code) references Product
)

CREATE TABLE Inventory(
store_id		CHAR(5),
UPC_code		NVARCHAR(14),
price			SMALLMONEY,
quantity		INT,
threshold		INT,
order_quantity	INT,
PRIMARY KEY (store_id,UPC_code),
FOREIGN KEY (store_id) REFERENCES Store,
FOREIGN KEY (UPC_code) REFERENCES Product)

