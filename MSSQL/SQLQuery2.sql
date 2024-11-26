-- Relations
--one to one
--one to many
--many to many 

DROP DATABASE PB202
USE master
CREATE DATABASE PB202
USE PB202
CREATE TABLE Groups
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10),
Size INT
)
CREATE TABLE Students
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10),
GroupId INT FOREIGN KEY REFERENCES Groups(Id)
)

CREATE TABLE Details
(
Id INT PRIMARY KEY IDENTITY,
Email NVARCHAR(20),
[Address] NVARCHAR(20),
Phone NVARCHAR(20),
StudentId INT FOREIGN KEY REFERENCES Students(Id)
)

CREATE TABLE Courses
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10)
)

CREATE TABLE CourseStudents
(
Id INT PRIMARY KEY IDENTITY,
StudentId INT FOREIGN KEY REFERENCES Students(Id),
CourseId INT FOREIGN KEY REFERENCES Courses(Id),
)

--Joins 
--INNER JOIN
SELECT s.*,d.Email,d.Address,d.Phone FROM Students s
INNER JOIN Details d
ON
s.Id=d.StudentId

--LEFT JOIN
SELECT * FROM Students s
LEFT JOIN Details d
ON
s.Id=d.StudentId

--FULL OUTER JOIN
SELECT * FROM Students s
FULL JOIN Details d
ON
s.Id=d.StudentId

--RIGHT JOIN
SELECT * FROM Students s
RIGHT JOIN Details d
ON
s.Id=d.StudentId

--SELF JOIN
CREATE TABLE Positions
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10),
ManagerId INT
)
SELECT p.Name,a.Name FROM Positions p
JOIN  Positions a
ON
p.ManagerId=a.Id

--CROSS JOIN
CREATE TABLE Products
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10)
)
CREATE TABLE Sizes
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10)
)
SELECT * FROM Products
CROSS JOIN Sizes

--NON EQUI
ALTER TABLE Students ADD Point DECIMAL(18,2) 

CREATE TABLE Grades
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10),
MinGrade INT,
MaxGrade INT
)

SELECT s.*,g.Name PointName FROM Students s
JOIN Grades g
ON
s.Point>g.MinGrade AND s.Point<g.MaxGrade


--UNION,UNION ALL,EXCEPT,INTERSECT 

CREATE TABLE OldStudents
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10),
GroupId INT FOREIGN KEY REFERENCES Groups(Id),
Point DECIMAL(18,2) 
)
SELECT Name,Point FROM Students
UNION
SELECT Name,Point FROM OldStudents

SELECT * FROM Students
UNION ALL
SELECT * FROM OldStudents

SELECT * FROM Students
EXCEPT
SELECT * FROM OldStudents 

SELECT * FROM Students
INTERSECT
SELECT * FROM OldStudents 

CREATE DATABASE Netflix
USE Netflix

CREATE TABLE Directors
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10)
)
CREATE TABLE Movies
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10),
Imdb DECIMAL(18,2),
Duration INT,
DirectorId INT FOREIGN KEY REFERENCES Directors(Id)
)
CREATE TABLE Actors
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10)
)

CREATE TABLE MoviesActors
(
Id INT PRIMARY KEY IDENTITY,
MovieId INT FOREIGN KEY REFERENCES Movies(Id),
ActorId INT FOREIGN KEY REFERENCES Actors(Id)
)
CREATE TABLE Genres
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(10)
)

CREATE TABLE MovieGenres
(
Id INT PRIMARY KEY IDENTITY,
MovieId INT FOREIGN KEY REFERENCES Movies(Id),
GenreId INT FOREIGN KEY REFERENCES Genres(Id)
)
--1
SELECT m.Name MovieName,m.Imdb,g.Name GenreName,d.Name DirectorName,a.Name ActorName FROM Movies m
JOIN MovieGenres mg
ON
m.Id=mg.MovieId
JOIN Genres g
ON
g.Id=mg.GenreId
JOIN Directors d
ON
d.Id=m.DirectorId
JOIN MoviesActors ma
ON
m.Id=ma.MovieId
JOIN Actors a
ON
a.Id=ma.ActorId
WHERE m.Imdb>6

--2
SELECT m.Name,m.Imdb,g.Name FROM Movies m
JOIN MovieGenres mg
ON
m.Id=mg.MovieId
JOIN Genres g
ON
g.Id=mg.GenreId
WHERE g.Name LIKE '%a%'

--3
SELECT m.Name,m.Imdb,m.Duration,g.Name FROM Movies m
JOIN MovieGenres mg
ON
m.Id=mg.MovieId
JOIN Genres g
ON
g.Id=mg.GenreId
WHERE m.Name LIKE '%t' AND LEN(m.Name)>6

--4
USE Netflix
CREATE VIEW GetMovies
AS
SELECT m.Name MovieName,m.Imdb,g.Name GenreName,d.Name DirectorName,a.Name ActorName FROM Movies m
JOIN MovieGenres mg
ON
m.Id=mg.MovieId
JOIN Genres g
ON
g.Id=mg.GenreId
JOIN Directors d
ON
d.Id=m.DirectorId
JOIN MoviesActors ma
ON
m.Id=ma.MovieId
JOIN Actors a
ON
a.Id=ma.ActorId
WHERE m.Imdb>(SELECT AVG(Imdb) FROM Movies)

SELECT Imdb FROM GetMovies



