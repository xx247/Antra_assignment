--1.
SELECT DISTINCT c.city
FROM dbo.Customers c
join dbo.Employees e on c.city = e.city

--2.
--use sub-query
SELECT DISTINCT city 
FROM dbo.Customers
WHERE city NOT IN(
	SELECT city
	FROM dbo.Employees
)

--do not use sub-query
SELECT DISTINCT c.City
FROM dbo.Customers c
LEFT JOIN dbo.Employees e ON c.City = e.City
WHERE e.City IS NULL

--3. 
SELECT p.ProductName, SUM(od.Quantity) AS quantity
FROM dbo.[Order Details] od
join dbo.Products p on od.ProductID = p.ProductID
GROUP BY p.ProductName

--4. 
SELECT c.city, COUNT(od.ProductID) AS TotalOrder
FROM dbo.Customers c
left join dbo.Orders o on o.ShipCity = c.City
join dbo.[Order Details] od on od.OrderID = o.OrderID
GROUP BY c.city

--5.
--use union
SELECT City
FROM dbo.Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2
UNION
SELECT City
FROM dbo.Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2

--no union
SELECT	city, COUNT(CompanyName) AS NUMCustomer
FROM dbo.Customers
GROUP BY City
HAVING COUNT(CompanyName)>=2

--6. 
SELECT c.City,COUNT(DISTINCT od.ProductID) AS NUMProducts
FROM dbo.Customers c
join dbo.Orders o on c.CustomerID = o.CustomerID
join dbo.[Order Details] od on od.OrderID = o.OrderID
GROUP BY c.city
HAVING COUNT(DISTINCT od.ProductID)>=2

--7.
SELECT c.CustomerID, c.ContactName
FROM dbo.Customers c
join dbo.Orders o on c.CustomerID = o.CustomerID
WHERE c.city !=o.ShipCity

--8.
WITH TOP5 AS(
SELECT TOP 5 ProductID, SUM(Quantity) AS Quantity1, AVG(UnitPrice) AS AVGPrice
FROM dbo.[Order Details]
GROUP BY ProductID
ORDER BY Quantity1 DESC),
Pro AS(
SELECT tp.ProductID, c.City, SUM(od.Quantity)AS Quantity2, RANK() OVER (PARTITION BY tp.ProductID ORDER BY SUM(od.Quantity) DESC) AS RNK
FROM TOP5 tp
join dbo.[Order Details] od on tp.ProductID = od.ProductID
join dbo.Orders o on od.OrderID = o.OrderID
join dbo.Customers c on c.CustomerID = o.CustomerID
GROUP BY tp.ProductID, c.City)
SELECT P.ProductID, tp.AVGPrice,p.City
FROM Pro p
join TOP5 tp on p.ProductID = tp.ProductID
WHERE p.RNK = 1

--9.
--sub-query
SELECT city
FROM dbo.Employees
WHERE city  NOT IN(
	SELECT CITY 
	FROM dbo.Customers
)
--no sub-query
SELECT e.city
FROM dbo.Employees e 
left join dbo.Customers c on e.city = c.city
WHERE c.city is null

--10.
WITH employee AS(
SELECT EmployeeID,COUNT(EmployeeID) AS NUMOrder, RANK()OVER(ORDER BY COUNT(EmployeeID) DESC) AS RNK
FROM dbo.Orders
GROUP BY EmployeeID
),
Products AS(
SELECT OrderID, SUM(Quantity) AS sumquantity,RANK()OVER(ORDER BY SUM(Quantity) DESC) AS RNK
FROM dbo.[Order Details]
GROUP BY OrderID
),
employeeCity AS(
SELECT em.City, e.RNK
FROM dbo.Employees em
join employee e ON em.EmployeeID = e.EmployeeID
),
productCity AS(
SELECT c.City,p.RNK
FROM Products p 
join dbo.Orders o on p.OrderID = o.OrderID
join dbo.Customers c on c.CustomerID = o.CustomerID
)
SELECT e.City
FROM employeeCity e
join productCity p on e.City = p.City
WHERE e.RNK=1 AND p.RNK =1

--11.
--WITH CTE AS (
--    SELECT 
--        *, 
--        ROW_NUMBER() OVER (PARTITION BY some_column ORDER BY id) as row_num
--    FROM 
--        myTable
--)
--DELETE FROM CTE
--WHERE row_num > 1;







