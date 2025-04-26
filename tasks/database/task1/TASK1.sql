-- 1. Create a table named "Employees" with columns for ID (integer), Name (varchar), and Salary (decimal).
CREATE TABLE Employees (
    ID INT NOT NULL,
    Name VARCHAR(100),
    Salary DECIMAL(18,2)
);

-- 2. Add a new column named "Department" to the "Employees" table with data type varchar(50).
ALTER TABLE Employees
ADD Department VARCHAR(50);

-- 3. Remove the "Salary" column from the "Employees" table.
ALTER TABLE Employees
DROP COLUMN Salary;

-- 4. Rename the "Department" column in the "Employees" table to "DeptName".
EXEC sp_rename 'Employees.Department', 'DeptName', 'COLUMN';

-- 5. Create a new table called "Projects" with columns for ProjectID (integer) and ProjectName (varchar).
CREATE TABLE Projects (
    ProjectID INT NOT NULL,
    ProjectName VARCHAR(100),
    CONSTRAINT PK_Projects_ProjectID PRIMARY KEY (ProjectID)  -- Make ProjectID a primary key
);

-- 6. Add a primary key constraint to the "Employees" table for the "ID" column.
ALTER TABLE Employees
ADD CONSTRAINT PK_Employees_ID PRIMARY KEY (ID);

-- 7. Create a foreign key relationship between the "Employees" table (referencing "ID") and the "Projects" table (referencing "ProjectID").
ALTER TABLE Employees
ADD CONSTRAINT FK_Employees_Projects
FOREIGN KEY (ID) REFERENCES Projects(ProjectID);

-- 8. Remove the foreign key relationship between "Employees" and "Projects."
ALTER TABLE Employees
DROP CONSTRAINT FK_Employees_Projects;

-- 9. Add a unique constraint to the "Name" column in the "Employees" table.
ALTER TABLE Employees
ADD CONSTRAINT UQ_Employees_Name UNIQUE (Name);

-- 10. Create a table named "Customers" with columns for CustomerID (integer), FirstName (varchar), LastName (varchar), Email (varchar), and Status (varchar).
CREATE TABLE Customers (
    CustomerID INT NOT NULL,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Email VARCHAR(255),
    Status VARCHAR(50)
);

-- 11. Add a unique constraint to the combination of "FirstName" and "LastName" columns in the "Customers" table.
ALTER TABLE Customers
ADD CONSTRAINT UQ_Customers_FirstName_LastName UNIQUE (FirstName, LastName);

-- 12. Add a default value of 'Active' for the "Status" column in the "Customers" table, where the default value should be applied when a new record is inserted.
ALTER TABLE Customers
ADD CONSTRAINT DF_Customers_Status DEFAULT 'Active' FOR Status;

-- 13. Create a table named "Orders" with columns for OrderID (integer), CustomerID (integer), OrderDate (datetime), and TotalAmount (decimal).
CREATE TABLE Orders (
    OrderID INT NOT NULL,
    CustomerID INT NOT NULL,
    OrderDate DATETIME,
    TotalAmount DECIMAL(18,2)
);

-- 14. Add a check constraint to the "TotalAmount" column in the "Orders" table to ensure that it is greater than zero.
ALTER TABLE Orders
ADD CONSTRAINT CHK_Orders_TotalAmount CHECK (TotalAmount > 0);
-- 15. Create a schema named "Sales" and move the "Orders" table into this schema.
CREATE SCHEMA Sales;

ALTER SCHEMA Sales TRANSFER dbo.Orders;

-- 16. Rename the "Orders" table to "SalesOrders."
EXEC sp_rename 'Sales.Orders', 'SalesOrders';
