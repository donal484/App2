create login carcenterLogin
with password='carcenterLogin';
GO
create database carcenterDB;
GO
Use carcenterDB;
GO
Create user carcenterUser for login carcenterLogin; --Creo el usuario para el login del carcenter
GO
EXEC sp_addrolemember 'db_datareader', 'carcenterUser';
GRANT CREATE TABLE TO carcenterUser;
GO

GRANT ALTER, CONTROL, CREATE SEQUENCE, DELETE, EXECUTE,
INSERT, REFERENCES, SELECT, TAKE OWNERSHIP, VIEW CHANGE TRACKING, 
VIEW DEFINITION, UPDATE ON SCHEMA :: dbo TO carcenterUser;
GO