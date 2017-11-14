﻿---Vendor,Address,Category---
CREATE TABLE Vendor(
vendor_name		VARCHAR(20) PRIMARY KEY,
country			VARCHAR(20),
delivery_method	VARCHAR(20),
delivery_time	INT)

CREATE TABLE Category(
type			VARCHAR(20) PRIMARY KEY,
category		VARCHAR(20))


---Store,Customer,Product---

CREATE TABLE Customer(
customer_id		INT PRIMARY KEY,
email			NVARCHAR(20) NOT NULL,
password		NVARCHAR(20) NOT NULL,
address_id		INT,
first_name		NVARCHAR(20),
middle_name		NVARCHAR(20),
last_name		NVARCHAR(20),				
FOREIGN KEY (address_id) REFERENCES Address)

CREATE TABLE Product(
UPC_code		NVARCHAR(14) PRIMARY KEY,
description		NVARCHAR(MAX),
type			VARCHAR(20),
department		VARCHAR(20),
size			AS SUBSTRING(UPC_code,10,2),
color			AS SUBSTRING(UPC_code,12,3),
FOREIGN KEY (type) REFERENCES Category)


---Credit Card, Transaction, Suplies, Inventory---

CREATE TABLE Credit_Card(
customer_id		INT,
number			INT,
PRIMARY KEY (customer_id,number),
FOREIGN KEY (customer_id) REFERENCES Customer)


CREATE TABLE Transact(
UPC_code		NVARCHAR(14),
customer_id		INT,
store_id		INT,
quantity		INT,
date_time		SMALLDATETIME,	
PRIMARY KEY (UPC_code,customer_id,store_id),
FOREIGN KEY (UPC_code) REFERENCES Product,
FOREIGN KEY (customer_id) REFERENCES Customer,
FOREIGN KEY (store_id) REFERENCES Store,
)


CREATE TABLE Inventory(
store_id		INT,
UPC_code		NVARCHAR(14),
price			SMALLMONEY,
quantity		INT,
threshold		INT,
order_quantity	INT,
PRIMARY KEY (store_id,UPC_code),
FOREIGN KEY (store_id) REFERENCES Store,
FOREIGN KEY (UPC_code) REFERENCES Product)

