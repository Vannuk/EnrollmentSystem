---STUDENT ENROLLMENT SYSTEM--
CREATE DATABASE StudentEnrollmentSystem

use StudentEnrollmentSystem
---CREATE TABLE Enrollment--
CREATE TABLE [Enrollments](
	RegNo INT,
	RegDate DATE,
	StudentID NVARCHAR(255) PRIMARY KEY,
	EmpNo NVARCHAR(255),
	Location VARCHAR(255),
	Status VARCHAR(255),
	MajorNo INT,
	Batch INT,
	SessionNo INT,
	CourseFee MONEY,
	Scholarship NVARCHAR(255),
	AcdYear INT,
	Grade VARCHAR(10),
	ProgNo INT
);
---CREATE TABLE Student--
CREATE TABLE [Students](
	StudentID NVARCHAR(255) PRIMARY KEY,
	FirstNameKH NVARCHAR(255),
    LastNameKH NVARCHAR(255),
    FirstNameENG VARCHAR(255),
    LastNameENG VARCHAR(255),
	Gender VARCHAR(255),
	DOB DATE,
	Parentcontact INT,
	Email NVARCHAR(255),
	Adress NVARCHAR(255),
	Phonenumber INT,
);
---CREATE TABLE Enployees---
CREATE TABLE Employees(
	EmpNo NVARCHAR(255) PRIMARY KEY,
	EmpName VARCHAR(255),
	Position VARCHAR(255),
);
---CREATE TABLE Major---
CREATE TABLE Major(
	MajorNo INT PRIMARY KEY IDENTITY(1,1),
	Major VARCHAR(255),
	Faculty VARCHAR(255)
);
---CREATE TABLE Session---
CREATE TABLE Session(
	SessionNo INT PRIMARY KEY IDENTITY(1,1),
	Session VARCHAR(255),
);
---CREATE TABLE Program---
CREATE TABLE Program(
	ProgNo INT PRIMARY KEY IDENTITY(1,1),
	program VARCHAR(255)
);
---CREATE TABLE Payments---
CREATE TABLE Payments(
	PayNo NVARCHAR(255) PRIMARY KEY,
	PayDate Date,
	StudentID NVARCHAR(255),
	CahsierID NVARCHAR(255),
	Location VARCHAR(255),
	Status VARCHAR(255),
	Remark VARCHAR(255)
);
---CREATE TABLE PaymentDetails---
CREATE TABLE PaymentDetails(
	PayNo NVARCHAR(255),
	ItemNo INT,
	Qtg INT,
	UnitPrice MONEY,
	Disscount NVARCHAR(255),
	Total MONEY,
);
---CRETAE TABLE Items---
CREATE TABLE Items(
	ItemNo INT PRIMARY KEY IDENTITY(1,1),
	Description VARCHAR(255)
);
---INSERT INTO 
INSERT INTO Enrollments VALUES
(101,'2023-08-17','BBA0001','E01','AIB','Enrolled',1,6,1,'1200',0,2020,'A',2),





