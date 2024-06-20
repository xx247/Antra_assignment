USE AdventureWorks2019
GO
--1. The answer is 504
SELECT COUNT(ProductID)
FROM Production.Product

--2.
SELECT COUNT(ProductID)
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

--3.
SELECT ProductSubcategoryID, COUNT(ProductSubcategoryID) AS CountedProducts
FROM Production.Product
GROUP BY ProductSubcategoryID

--4. The answer is 209
SELECT COUNT(ProductID)
FROM Production.Product
WHERE ProductSubcategoryID IS NULL

--5. 
SELECT SUM(Quantity)
FROM Production.ProductInventory

--6.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity)<100

--7.
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity)<100

--8.
SELECT ProductID, AVG(Quantity) AS Average
FROM Production.ProductInventory
WHERE LocationID = 10
GROUP BY ProductID

--9.
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

--10.
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE Shelf!='N/A'
GROUP BY ProductID, Shelf

--11.
SELECT Color,Class,COUNT(DISTINCT Color)AS TheCount, AVG(ListPrice)AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color,Class

--12.
SELECT c.Name AS Country, p.Name AS Province
FROM person.CountryRegion c join person. StateProvince p 
ON c.CountryRegionCode=p.CountryRegionCode

--13.
SELECT c.Name AS Country, p.Name AS Province
FROM person.CountryRegion c join person. StateProvince p 
ON c.CountryRegionCode=p.CountryRegionCode
WHERE c.Name IN ('Germany','Canada')

--14.
USE Northwind
GO

SELECT p.ProductID, p.ProductName
FROM dbo.Products p 
join dbo.[Order Details] od ON p.ProductID = od.ProductID
join dbo.Orders o ON o.OrderID = od.OrderID
WHERE o.OrderDate >= DATEADD(YEAR, -27, GETDATE())

--15.
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS SUMQuantity
FROM dbo.[Order Details] od 
join dbo.Orders o ON o.OrderID = od.OrderID
GROUP BY o.ShipPostalCode
ORDER BY SUMQuantity DESC

--16.
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS SUMQuantity
FROM dbo.[Order Details] od 
join dbo.Orders o ON o.OrderID = od.OrderID
WHERE o.OrderDate >= DATEADD(YEAR, -27, GETDATE())
GROUP BY o.ShipPostalCode
ORDER BY SUMQuantity DESC

--17.
SELECT City, COUNT(*) AS NUMofCustomer
FROM dbo.Customers
GROUP BY City

--18.
SELECT City, COUNT(*) AS NUMofCustomer
FROM dbo.Customers
GROUP BY City
HAVING COUNT(*)>2

--19.
SELECT o.OrderDate, c.CompanyName, c.ContactName
FROM dbo.Orders o
join dbo.Customers c on o.CustomerID = c.CustomerID
WHERE o.OrderDate>'1998-01-01'

--20.
WITH Orders AS
(SELECT o.OrderDate, c.CompanyName, c.ContactName,DENSE_RANK()OVER (ORDER BY o.OrderDate DESC) AS RNK
FROM dbo.Orders o
join dbo.Customers c on o.CustomerID = c.CustomerID)
SELECT OrderDate, CompanyName, ContactName
FROM Orders
WHERE RNK=1

--21.
SELECT c.ContactName, SUM(od.Quantity) AS proCOUNT
FROM dbo.Customers c
left join dbo.Orders o on o.CustomerID = c.CustomerID 
join dbo.[Order Details] od on o.OrderID = od.OrderID 
GROUP BY c.ContactName

--22.
SELECT o.CustomerID, SUM(od.Quantity) AS proCOUNT
FROM dbo.Orders o
join dbo.[Order Details] od on o.OrderID = od.OrderID 
GROUP BY o.CustomerID
HAVING SUM(od.Quantity)>100

--23.
SELECT DISTINCT s.CompanyName AS [Supplier Company Name], sh.CompanyName AS [Shipping Company Name]
FROM dbo.Suppliers s
join dbo.Products p ON s.SupplierID = p.SupplierID
join dbo.[Order Details] od ON od.ProductID = p.ProductID
join dbo.Orders o ON od.OrderID = o.OrderID
join dbo.Shippers sh ON o.ShipVia = sh.ShipperID
ORDER BY s.CompanyName

--24.
SELECT o.OrderDate, p.ProductName
FROM dbo.Products p
join dbo.[Order Details] od ON od.ProductID = p.ProductID
join dbo.Orders o ON od.OrderID = o.OrderID
ORDER BY o.OrderDate

--25.
SELECT e1.FirstName AS Emp1, e2.FirstName AS Emp2, e1.Title
FROM dbo.Employees e1
JOIN dbo.Employees e2 ON e1.Title = e2.Title AND e1.FirstName != e2.FirstName


--26.
SELECT e.ReportsTo AS ManagerID, m.FirstName, COUNT(e.EmployeeID) AS NUMReporter
FROM dbo.Employees e
JOIN dbo.Employees m ON e.ReportsTo = m.EmployeeID
GROUP BY e.ReportsTo, m.FirstName
HAVING COUNT(e.EmployeeID)>2

--27.

SELECT 
    City, 
    CompanyName AS Name, 
    ContactName, 
    'Customer' AS Type
FROM 
    dbo.Customers
UNION
SELECT 
    City, 
    CompanyName AS Name, 
    ContactName, 
    'Supplier' AS Type
FROM 
    dbo.Suppliers
ORDER BY 
    City, 
    Name;







