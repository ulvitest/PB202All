CREATE DATABASE RestaurantDb
USE RestaurantDb

CREATE TABLE Meals
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10) UNIQUE,
Price DECIMAL(18,2)
)

CREATE TABLE [Tables]
(
Id INT PRIMARY KEY IDENTITY,
[No] NVARCHAR(10) UNIQUE
)

CREATE TABLE Orders
(
Id INT PRIMARY KEY IDENTITY,
MealId INT FOREIGN KEY REFERENCES Meals(Id),
TableId INT FOREIGN KEY REFERENCES [Tables](Id),
OrderDate DATETIME2
)
--Bütün masadatalarını yanında o masaya edilmiş sifariş sayı ilə birlikdə select edən query

SELECT t.*,(SELECT COUNT(*)  FROM Orders WHERE TableId=t.Id) AS OrderCount FROM [Tables] t
SELECT COUNT(*) AS OrderCount FROM Orders WHERE TableId=2

--Bütün yeməkləri o yeməyin sifariş sayı ilə select edən query
SELECT m.*,(SELECT COUNT(*)  FROM Orders WHERE MealId=m.Id) AS OrderCount FROM Meals m

-- Bütün sirafiş datalarını yanında yeməyin adı ilə select edən query
SELECT o.*,m.Name FROM Orders o
JOIN Meals m
ON
m.Id=o.MealId

--Bütün sirafiş datalarını yanında yeməyin adı və masanın nömrəsi  ilə select edən query
SELECT o.*,m.Name,t.No FROM Orders o
JOIN Meals m
ON
m.Id=o.MealId
JOIN [Tables] t
ON
t.Id=o.TableId

--Bütün masa datalarını yanında o masının sifarişlərinin ümumi məbləği ilə select edən query 
SELECT t.*,(SELECT SUM(m.Price) FROM Orders o
JOIN Meals m
ON
m.Id =o.MealId
WHERE o.TableId=t.Id) AS TotalPrice
FROM [Tables] t


SELECT SUM(m.Price) FROM Orders o
JOIN Meals m
ON
m.Id =o.MealId
WHERE o.TableId=1

--1-id li masaya verilmis ilk sifarişlə son sifariş arasında neçə saat fərq olduğunu select edən query
SELECT TOP(1) * FROM Tables t
JOIN Orders o
ON
o.TableId=t.Id
WHERE t.Id=1
ORDER BY OrderDate DESC

SELECT DATEDIFF(HOUR,MIN(o.OrderDate),MAX(o.OrderDate)) AS DateDifff FROM Tables t
JOIN Orders o
ON
o.TableId=t.Id
WHERE t.Id=1

--ən son 30-dəqədən əvvəl verilmiş sifarişləri select edən query
SELECT * FROM Orders o
WHERE o.OrderDate<DATEADD(MINUTE,-30,GETDATE())

--heç sifariş verməmiş masaları select edən query
SELECT * FROM [Tables] t
WHERE
NOT EXISTS
(SELECT * FROM Orders o WHERE o.TableId=t.Id )

--son 60 dəqiqədə heç sifariş verməmiş masaları select edən query
SELECT * FROM [Tables] t
WHERE
NOT EXISTS
(SELECT * FROM Orders o WHERE o.TableId=t.Id AND o.OrderDate>DATEADD(MINUTE,-60,GETDATE()))

--INDEX(PRIMARY KEY),VIEW,PROCEDURE,FUNCTION,TRIGGER

SELECT * FROM GetTableWithOrder

USE RestaurantDb

CREATE PROCEDURE sp_GetTableWithId @searchId INT
AS
SELECT DATEDIFF(HOUR,MIN(o.OrderDate),MAX(o.OrderDate)) AS DateDifff FROM Tables t
JOIN Orders o
ON
o.TableId=t.Id
WHERE t.Id=@searchId
EXEC sp_GetTableWithId 2
DROP PROCEDURE sp_GetTableWithId

SELECT COUNT(*) FROM Orders

CREATE FUNCTION GetOrderCount()
RETURNS INT
AS 
BEGIN
DECLARE @count INT

RETURN @count
END

DROP FUNCTION dbo.GetOrderCount
SELECT dbo.GetOrderCount()



DELETE FROM [Tables]  WHERE Id=6

CREATE TRIGGER ShowAllAfterDeleteInsertUpdateTables
ON [Tables]
AFTER DELETE,INSERT,UPDATE
AS
BEGIN
SELECT * FROM Tables 
END

INSERT INTO [Tables] VALUES('No5')

--extract sql 


