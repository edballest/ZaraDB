---Vendor,Address,Category---
CREATE TABLE Vendor(
vendor_name		VARCHAR(20) PRIMARY KEY,
country			VARCHAR(20),
delivery_method	VARCHAR(20),
delivery_time	TINYINT	NOT NULL,
CHECK delivery_method IN('truck','train','airplane','boat'))

CREATE TABLE Category(
type			VARCHAR(20) PRIMARY KEY,
category		VARCHAR(20))

CREATE TABLE Address(
address_id		INT PRIMARY KEY IDENTITY,
country			VARCHAR(20)	NOT NULL,
city			VARCHAR(20)	NOT NULL,
street			VARCHAR(20)	NOT NULL,
number			VARCHAR(5)	NOT NULL,
apartment		VARCHAR(5),
zip_code		CHAR(5) NOT NULL)

---Store,Customer,Product---

CREATE TABLE Customer(
customer_id		INT PRIMARY KEY IDENTITY,
email			NVARCHAR(20) NOT NULL,
password		NVARCHAR(20) NOT NULL,
address_id		INT,
first_name		NVARCHAR(20),
middle_name		NVARCHAR(20),
last_name		NVARCHAR(20),				
FOREIGN KEY (address_id) REFERENCES Address ON DELETE CASCADE)

CREATE TABLE Product(
UPC_code		CHAR(14) PRIMARY KEY,
description		NVARCHAR(50)NOT NULL,
type			VARCHAR(20) NOT NULL,
department		VARCHAR(20) NOT NULL,
item			AS SUBSTRING(UPC_code,1,9),
size			AS SUBSTRING(UPC_code,10,2),
color			AS SUBSTRING(UPC_code,12,3),
FOREIGN KEY (type) REFERENCES Category)

CREATE TABLE Store(
store_id		INT PRIMARY KEY IDENTITY,
opens			TIME(0),
closes			TIME(0),
max_inventory	INT NOT NULL,
address_id		INT,
FOREIGN KEY (address_id) REFERENCES Address)

---Credit Card, Transaction, Supplies, Inventory---

CREATE TABLE Credit_Card(
customer_id		INT,
number			CHAR(16),
PRIMARY KEY (customer_id,number),
FOREIGN KEY (customer_id) REFERENCES Customer)

CREATE TABLE Transactions(
UPC_code		CHAR(14),
customer_id		INT,
store_id		INT,
quantity		INT NOT NULL,
date_time		SMALLDATETIME NOT NULL,	
PRIMARY KEY (UPC_code,customer_id,store_id),
FOREIGN KEY (UPC_code) REFERENCES Product,
FOREIGN KEY (customer_id) REFERENCES Customer,
FOREIGN KEY (store_id) REFERENCES Store
CHECK quantity > 0)

CREATE TABLE Supplies(
vendor_name		VARCHAR(20),
store_id		INT,
UPC_code		CHAR(14),
PRIMARY KEY(vendor_name, store_id, UPC_code),
FOREIGN KEY (vendor_name) references Vendor,
FOREIGN KEY (store_id) references Store,
FOREIGN KEY (UPC_code) references Product)

CREATE TABLE Inventory(
store_id		INT,
UPC_code		CHAR(14),
price			SMALLMONEY NOT NULL,
quantity		INT NOT NULL,
threshold		INT NOT NULL,
order_quantity	INT NOT NULL,
PRIMARY KEY (store_id,UPC_code),
FOREIGN KEY (store_id) REFERENCES Store,
FOREIGN KEY (UPC_code) REFERENCES Product)

