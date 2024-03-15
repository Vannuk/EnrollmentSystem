CREATE DATABASE [ERU_TEST];
USE [ERU_TEST];
CREATE TABLE [UserLogin](
  Username VARCHAR(30),
  Userpassword VARCHAR(30)
);
---[ INSERT INTO [UserLogin] ]
INSERT INTO [UserLogin] VALUES
('Admin','123')
---[ SELECT * FROM TABLE [UserLogin] ]
SELECT * FROM [UserLogin];