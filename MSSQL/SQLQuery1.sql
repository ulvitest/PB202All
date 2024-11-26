--DDL COMMANDS
CREATE DATABASE PB202
DROP DATABASE PB202
USE PB202

CREATE TABLE Students
(
Id INT,
[Name] NVARCHAR(10),
Age INT,
Email NVARCHAR(10)
)
ALTER TABLE Students ADD PhoneNumber NVARCHAR(10)
ALTER TABLE Students DROP COLUMN PhoneNumber

ALTER TABLE Students
ALTER COLUMN [Name] INT;

ALTER TABLE Students
ALTER COLUMN [Name] NVARCHAR(10);

ALTER TABLE Students
ALTER COLUMN Email NVARCHAR(20);

EXEC sp_rename Students,Student
EXEC sp_rename Student,Students
EXEC sp_rename 'Students.Name',Ad
EXEC sp_rename 'Students.Ad',[Name]

DROP TABLE Students

--DML COMMANDS
SELECT *  FROM Students 

INSERT INTO Students VALUES
(3,'Samid',20,'samid@code.edu.az'),
(4,'Ziya',30,'ziya@gmail.com')

INSERT INTO Students VALUES
(5,'Orxan',32,'orxan@code.edu.az')

INSERT INTO Students (Id,[Name],Email) VALUES
(6,'Fatime','fatime@code.edu.az')

DELETE FROM Students WHERE Id=5
DELETE FROM Students WHERE [Name]='ziya'
DELETE FROM Students WHERE Age=20 AND Email='hacixan@mail.ru'
DELETE FROM Students WHERE Age=20 OR Email='hacixan@mail.ru'

UPDATE Students SET [Name]='Filankes' WHERE Id=1

SELECT *  FROM Students WHERE Id IN(2,3,4)

SELECT *  FROM Students WHERE Id>2

SELECT *  FROM Students WHERE Id BETWEEN 1 AND 2

SELECT *  FROM Students WHERE [Name] LIKE '%in%'

SELECT *  FROM Students

SELECT COUNT(*) AS StudenCount FROM Students

SELECT SUM(Id) FROM Students

SELECT AVG(Age) FROM Students

SELECT MIN(Age) FROM Students

SELECT MAX(Age) FROM Students

SELECT *  FROM Students WHERE Age >(SELECT AVG(Age) FROM Students)

SELECT LEN(Name),Name FROM Students

SELECT CHARINDEX('@',Email),Email FROM Students

SELECT SUBSTRING(Email,1,3),Email FROM Students 

SELECT SUBSTRING(Email,1,CHARINDEX('@',Email)-1),Email FROM Students 
SELECT SUBSTRING(Email,CHARINDEX('@',Email)+1,LEN(Email)),Email FROM Students 

--CONSTRAINTS
DROP TABLE Students

CREATE TABLE Students
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10) NOT NULL,
Age INT CHECK(Age>0 AND Age<50),
Email NVARCHAR(30) UNIQUE,
Surname NVARCHAR(30) DEFAULT('---')
)
INSERT INTO Students ([Name],Age,Email,Surname)
VALUES
('Alizamin',20,'alizamin@gmail.com','Agazade')

INSERT INTO Students ([Name],Age,Email)
VALUES
('Ziya',30,'ziya@gmail.com')

INSERT INTO Students (Age,Email)
VALUES
(30,'ziya@gmail.com')

SELECT * FROM Students

DROP TABLE Students

CREATE TABLE Groups
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10) NOT NULL,
Size INT
)
SELECT * FROM Groups

CREATE TABLE Students
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10) NOT NULL,
Age INT CHECK(Age>0 AND Age<50),
Email NVARCHAR(30) UNIQUE,
Surname NVARCHAR(30) DEFAULT('---'),
GroupId INT CONSTRAINT FK_aaaaa FOREIGN KEY REFERENCES Groups(Id)
)

INSERT INTO Students ([Name],Age,Email,Surname,GroupId)
VALUES
('Alizamin',20,'alizamin@gmail.com','Agazade',20)

DROP TABLE Students

ALTER TABLE Students ADD GroupId INT

ALTER TABLE Students
ADD CONSTRAINT FK_aaa FOREIGN KEY (GroupId) REFERENCES Groups(Id)

TRUNCATE TABLE Groups
DELETE FROM Groups

ALTER TABLE Students
DROP CONSTRAINT FK_aaaaa







