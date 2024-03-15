	CREATE DATABASE ERU_Core
	use ERU_Core;
	--create table
	Create table [UserLogin]
	(
		UserID VARCHAR(50) PRIMARY KEY,
		UserName VARCHAR(50),
		Userpassword VARCHAR(50),
		UserRole VARCHAR(50)
	)
	Create TABLE [Students]
	(
			RegNo Int Identity(1,1),
			RegDate DATE,
			StudentID VARCHAR(50) PRIMARY KEY,
			FullNameKH NVARCHAR(255),
			FullNameEng VARCHAR(50),
			Gender  NVARCHAR(10),
			DOB DATE,
			ParentContact VARCHAR(50),
			Email VARCHAR(100),
			Address NVARCHAR(255),
			UserID VARCHAR(50) Foreign Key References UserLogin(UserID),
			PhoneNumber VARCHAR(50),
			Major Varchar(100),
			Program Varchar(50),
			StudyTime Varchar(50)
	);
	INSERT INTO [UserLogin] VALUES
		('E01','Yi Sokheng','Rec@123','Receptionist'),
		('E02','Chan Nita','Cas@123','Cashier'),
		('E03','Chea Nika','Adm@123','Admin'),
		('E04','Lay Sovannuk','Eru@123','ERU Manager')

	CREATE TABLE [PAYMENTS]
	(
			InvoiceNo VARCHAR(60) UNIQUE,
			TeamName VARCHAR(100),
			StuID VARCHAR(50) FOREIGN KEY REFERENCES Students(StudentID),
			FULLNAME VARCHAR(50),
			SHIFTS VARCHAR(50),
			PROGRAMS VARCHAR(50),
			Batch VARCHAR(50),
			PaymentDate DATE,
			ItemNo1 Int,
			ItemNo2 Int,
			ItemNo3 Int,
			Description1 VARCHAR(50),
			Description2 VARCHAR(50),
			Description3 VARCHAR(50),
			Qty1 Int,
			Qty2 Int,
			Qty3 Int,
			UnitPrice1 Float,
			UnitPrice2 Float,
			UnitPrice3 Float,
			Scholarship1 Float,
			Scholarship2 Float,
			Scholarship3 Float,
			AmountDuo1 Float,
			AmountDuo2 Float,
			AmountDuo3 Float,
			CashPaid1 Float,
			CashPaid2 Float,
			CashPaid3 Float,
			Total Float,
			UserID VARCHAR(50) Foreign Key References UserLogin(UserID),
	);
	 ---[ CREATE STORE PROCEDURE FOR ENROLLMENTREPORT ]
	CREATE PROCEDURE [protbEnrollmentReport]
	AS
	BEGIN
	SELECT RegNo,
		RegDate,
		StudentID,
		FullNameKH,
		FullNameEng,
		Gender,
		DOB,
		ParentContact,
		Email,
		Address,
		UserID,
		PhoneNumber,
		Major,
		Program,
		StudyTime
	FROM [Students]
	END
	GO;

	Exec [protbEnrollmentReport];

	---[ CREATE STORE PROCEDURE FOR COUNT DASHBOARD ]
	CREATE PROCEDURE [protbStudentsByenroll]
	 @Program VARCHAR(50)
	 AS 
	 BEGIN
	SELECT Program, COUNT(*) AS TotalStudents
	  From [Students] 
	  WHERE Program = @Program
	  GROUP BY Program
	END
	Exec [protbStudentsByenroll] @Program = 'Bachelor';

	CREATE TABLE TransactionLog(
		TranID INT PRIMARY KEY IDENTITY(1,1),
		UserID NVARCHAR(50),
		TranDate SMALLDATETIME,
		[Action] NVARCHAR(50),
		[Table] NVARCHAR(50),
		[Object] NVARCHAR(50)
	)
	CREATE PROCEDURE [dbo].[sp_GetTansactionLog]
	AS
	BEGIN
	  SELECT TranID, UserID AS EmpID, TranDate, [Action], [Table], [Object] 
	  FROM TransactionLog
	END;
	Exec [dbo].[sp_GetTansactionLog]

	CREATE TRIGGER trg_Student
	ON Students
	AFTER INSERT
	AS BEGIN
		INSERT INTO TransactionLog(UserID, TranDate, [Action],[Table], [Object])
		SELECT UserID, GETDATE(), 'INSERT', 'STUDENT', StudentID
		FROM INSERTED
	END

	CREATE TRIGGER trg_Payment
	ON PAYMENTS
	AFTER INSERT
	AS BEGIN
		INSERT INTO TransactionLog(UserID, TranDate, [Action], [Table], [Object])
		SELECT UserID, GETDATE(), 'INSERT', 'PAYMENT', StuID
		FROM INSERTED
	END

	CREATE PROCEDURE protbEnrollmentReports
	 AS
	 BEGIN
	SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RegNo ,
			RegDate,
			StudentID,
			FullNameKH,
			FullNameEng,
			Gender,
			DOB,
			ParentContact,
			Email,
			Address,
			UserID,
			PhoneNumber,
			Major,
			Program,
			StudyTime
	FROM [Students]
	 END

	CREATE PROCEDURE protbScholarshipReports
	As
	 Begin
			SELECT St.RegNo, St.FullNameEng, St.Gender, p.Scholarship1, p.AmountDuo1, p.CashPaid1 FROM Students St
			INNER JOIN PAYMENTS p ON St.FullNameEng = p.FULLNAME;
	END
	Exec protbScholarshipReports

	CREATE PROCEDURE protbPolicyIncome
	As
		Begin
			Select p.InvoiceNo, St.StudentID, St.FullNameEng, St.Gender, p.Description1, p.Qty1, p.UnitPrice1, p.AmountDuo1, p.CashPaid1,
			p.Description2, p.Qty2, p.UnitPrice2, p.AmountDuo2, p.CashPaid2, p.Description3, p.Qty3, p.UnitPrice3, p.AmountDuo3, p.CashPaid3,
			p.Total FROM Students St INNER JOIN PAYMENTS p ON St.FullNameEng = p.FULLNAME;
	End
	Exec protbPolicyIncome

	---[PROC DASHBOARD]
	CREATE proc proTotalStudent
	 @Program VARCHAR(50)
	 AS 
	 BEGIN
	Select Program, COUNT(*) AS TotalStudents
		From [Students] 
		WHERE Program = @Program
		Group by Program
	END

	Exec proTotalStudent @Program = 'Bachelor';
	---[PRO STUDENT DASHBOARD]
	CREATE proc proStudentByStatus
	 @Gender VARCHAR(50)
	 AS 
	 BEGIN
	Select Gender, COUNT(*) AS TotalStudents
		From [Students] 
		WHERE Gender = @Gender
		Group by Gender
	END

	Exec proStudentByStatus @Gender = 'Female';

	---[PRO MAJOR DASHBOARD]
	CREATE proc proTopBymajor
	 @Major VARCHAR(50)
	 AS 
	 BEGIN
	Select s.Major, COUNT(*) AS TopMajor
		From [Students] s
		WHERE Major =@Major
		Group by Major
	END

	Exec proTopBymajor @Major = 'BusinessIT';


	INSERT INTO [UserLogin] VALUES
	('E01', 'Chhit Helen','Eru!@#123','Receptionist'),
	('E02', 'Chorm Somalin','Eru!@#123','Receptionist'),
	('E05', 'Chea Sonita','Cas!@#123','Cashier')

	SELECT * FROM [UserLogin];
