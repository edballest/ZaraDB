---Vendor,Address,Category---
CREATE TABLE Vendor(
vendor_name		VARCHAR(20) PRIMARY KEY,
country			VARCHAR(20),
delivery_method	VARCHAR(20),
delivety_time	int)


---Store,Customer,Product---

CREATE TABLE Product(
UPC_code		NVARCHAR(14) PRIMARY KEY,
description		NVARCHAR(MAX),
type			VARCHAR(20),
department		VARCHAR(20),
size			AS SUBSTRING(UPC_code,10,2),
color			AS SUBSTRING(UPC_code,12,3),
FOREIGN KEY (type) REFERENCES Category)


---Credit Card, Transaction, Suplies, Inventory---

CREATE TABLE Inventory(
store_Id		INT,
UPC_code		NVARCHAR(14),
price			SMALLMONEY,
quantity		INT,
threshold		INT,
order_quantity	INT,
PRIMARY KEY (store_id,UPC_code),
FOREIGN KEY (store_id) REFERENCES Store,
FOREIGN KEY (UPC_code) REFERENCES Product)

