CREATE DATABASE StationeryManagement
GO 
USE StationeryManagement

CREATE TABLE Roles(
	IDRole INT IDENTITY PRIMARY KEY,
	RoleName NVARCHAR(250) UNIQUE NOT NULL,
	DateCreate DATE DEFAULT GETDATE() NOT NULL,
	Status INT
)

INSERT INTO Roles(RoleName,Status) VALUES('Admin',1) -- Create role Admin
INSERT INTO Roles(RoleName,Status) VALUES('CEO',1) --Create role CEO
INSERT INTO Roles(RoleName,Status) VALUES('Chief of Department',1) --Create role Chief of Department
INSERT INTO Roles(RoleName,Status) VALUES('Employee',1) --Create role Employee

CREATE TABLE Departments(
	IDDepartment NVARCHAR(250) PRIMARY KEY,
	NameDepartment NVARCHAR(250) UNIQUE NOT NULL,
	DateCreate DATE DEFAULT GETDATE() NOT NULL,
	Status INT
)

INSERT INTO Departments(IDDepartment,NameDepartment,Status) VALUES('DCMB','Company Management Board',1) --Create Department with name 'Company Management Board'
INSERT INTO Departments(IDDepartment,NameDepartment,Status) VALUES('DHRD','Human Resouces Department',1) --Create Department with name 'Human Resouces Department'
INSERT INTO Departments(IDDepartment,NameDepartment,Status) VALUES('DAD','Acounting Department',1) --Create Department with name 'Adminiѕtration Department'
INSERT INTO Departments(IDDepartment,NameDepartment,Status) VALUES('DPD','Purchasing Department',1) --Create Department with name 'Purchasing Department'

CREATE TABLE Employees(
	IDEmployee INT IDENTITY(0,1) PRIMARY KEY,
	NameEmployee NVARCHAR(250) NOT NULL,
	EmailId NVARCHAR(250) UNIQUE NOT NULL,
	Password NVARCHAR(250) NOT NULL,
	Adress NVARCHAR(250) NOT NULL,
	Sex INT NOT NULL,
	BirthDay DATE NOT NULL,
	RegistrationNumber INT NOT NULL,
	IDDepartment NVARCHAR(250) FOREIGN KEY REFERENCES Departments(IDDepartment),
	IDRole INT FOREIGN KEY REFERENCES Roles(IDRole),
	Status INT
)
-- Create Employee Admin
INSERT INTO Employees(NameEmployee,EmailId,Password,Adress,Sex,BirthDay,RegistrationNumber,IDDepartment,IDRole,Status) VALUES('ADMIN','admin10@gmail.com','Admin10102002@','Vietnam',1,'1998-10-10',0,'DCMB',1,1)
-- Create Employee CEO The account creator is admin RegistrationNumber == IDEmployee == 0
INSERT INTO Employees(NameEmployee,EmailId,Password,Adress,Sex,BirthDay,RegistrationNumber,IDDepartment,IDRole,Status) VALUES('CEO Nguyen Duc Vinh','vinh1020@gmail.com','Vinh10102002@','Vietnam',1,'2002-10-10',0,'DCMB',2,1)
-- Create Employee Chief of Department The account creator is CEO RegistrationNumber == IDEmployee == 1
INSERT INTO Employees(NameEmployee,EmailId,Password,Adress,Sex,BirthDay,RegistrationNumber,IDDepartment,IDRole,Status) VALUES('Ha Dinh Tien','tien0965@gmail.com','Tien09652002@','Vietnam',1,'2002-05-09',1,'DHRD',3,1)
INSERT INTO Employees(NameEmployee,EmailId,Password,Adress,Sex,BirthDay,RegistrationNumber,IDDepartment,IDRole,Status) VALUES('Nguyen Tuyet Nhi','nhi0305@gmail.com','Nhi05052002@','Vietnam',0,'2002-03-05',1,'DAD',3,1)
INSERT INTO Employees(NameEmployee,EmailId,Password,Adress,Sex,BirthDay,RegistrationNumber,IDDepartment,IDRole,Status) VALUES('Nguyen Kim Tuyet','tuyet0345@gmail.com','Tuyet03452002@','Vietnam',0,'2002-03-15',1,'DPD',3,1)
-- Create Employees The account creator is Chief of Department RegistrationNumber == IDEmployee == 2
INSERT INTO Employees(NameEmployee,EmailId,Password,Adress,Sex,BirthDay,RegistrationNumber,IDDepartment,IDRole,Status) VALUES('Ngo Kim Trung','ktrung0706@gmail.com','Ktung07062002@','Vietnam',1,'2002-07-06',2,'DAD',4,1)
INSERT INTO Employees(NameEmployee,EmailId,Password,Adress,Sex,BirthDay,RegistrationNumber,IDDepartment,IDRole,Status) VALUES('Duong Trung Tuan','dtuan0213@gmail.com','Dtuan02132002@','Vietnam',1,'2002-02-13',2,'DHRD',4,1)

CREATE TABLE Categories(
	IDCategory INT IDENTITY PRIMARY KEY,
	NameCategory NVARCHAR(250) UNIQUE NOT NULL,
	DateCreate DATE DEFAULT GETDATE() NOT NULL,
	Status INT
)

-- Create Categories
INSERT INTO Categories(NameCategory,Status) VALUES('Ballpoint pens',1)
INSERT INTO Categories(NameCategory,Status) VALUES('Pencil',1)
INSERT INTO Categories(NameCategory,Status) VALUES('Line marker pens',1)
INSERT INTO Categories(NameCategory,Status) VALUES('Staple',1)
INSERT INTO Categories(NameCategory,Status) VALUES('Profile tray',1)
INSERT INTO Categories(NameCategory,Status) VALUES('Printing paper',1)
INSERT INTO Categories(NameCategory,Status) VALUES('Scissors',1)
INSERT INTO Categories(NameCategory,Status) VALUES('Paper knives',1)

CREATE TABLE Stationeries(
	IDStationerie INT IDENTITY PRIMARY KEY,
	NameStationerie NVARCHAR(250) UNIQUE NOT NULL,
	UnitOfMeasure NVARCHAR(250) NOT NULL,
	Image NVARCHAR(250) NOT NULL,
	Price FLOAT NOT NULL,
	DateCreate DATE DEFAULT GETDATE() NOT NULL,
	IDCategory INT FOREIGN KEY REFERENCES Categories(IDCategory),
	Status INT
)


-- Create Stationeries
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Gel Pen A (Red) (50Pens/Box)','Box','station1.jpg',8,1,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Ballpoint Pen TL FO-024 0.7MM RED (20Pens/Box)','Box','station2.jpg',4,1,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Thien Long Ballpoint Pen 036 0.7MM (20Pens/Box)','Box','station3.jpg',8,1,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Bút TL PH02 0.8MM (10Pens/Box)','Box','station4.jpg',6,1,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Pencil CS 327 (20Pens/Box)','Box','station5.jpg',3,2,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Pencil CS 311 (20Pens/Box)','Box','station6.jpg',4,2,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Wood pencil GP-04 HB (10Pens/Box)','Box','station7.jpg',2,2,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Line marker pens Staedtler (4 color)','Box','station8.jpg',1,3,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Line marker pens TL – HL-07 color yellow (10Pens/Box)','Box','station9.jpg',4,3,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Line marker pens TL – HALOZEE HL03 yellow (5Pens/Pen Blister)','Pen Blister','station10.jpg',4,3,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Black butterfly clip 19MM (10Staples/Box)','Box','station11.jpg',2,4,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Triangle clamp C – 62 (10Staples/Box)','Box','station12.jpg',1.5,4,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Plastic Acco Clamp (50Staples/Box)','Box','station13.jpg',1,4,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('3 drawer vertical file tray','Unit','station14.jpg',1.6,5,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('3 tier plastic tray','Unit','station15.jpg',3.2,5,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Iron document tray','Unit','station16.jpg',10,5,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Photo Paper A4 Smartist 70','Bin','station17.jpg',2.5,6,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Photo Paper Double A A3-70','Bin','station18.jpg',6.2,6,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Photo Paper A4 70 TL PP-001','Bin','station19.jpg',3,6,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Scissors VP Deli 172mm 6026','Unit','station20.jpg',1.2,7,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Pulling Deli 6001','Unit','station21.jpg',1.4,7,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('Pulling Deli 6010','Unit','station22.jpg',1.4,7,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('SDI 0404 Paper Cutter','Box','station23.jpg',0.5,8,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('SDI 0423 Paper Cutter','Box','station24.jpg',0.6,8,1)
INSERT INTO Stationeries(NameStationerie,UnitOfMeasure,Image,Price,IDCategory,Status) VALUES('SDI 1403C Paper Cutter Blade Small','Box','station25.jpg',0.24,8,1)

CREATE TABLE RequestStationery(
	IDRequestStationery INT IDENTITY PRIMARY KEY,
	IDEmployee INT FOREIGN KEY REFERENCES Employees(IDEmployee),
	IDStationerie INT FOREIGN KEY REFERENCES Stationeries(IDStationerie),
	Quantity INT NOT NULL,
	Note NTEXT,
	DateCreate DATE DEFAULT GETDATE() NOT NULL,
	Status INT
)

CREATE TABLE Feedbacks(
	IDFeedback INT IDENTITY PRIMARY KEY,
	IDEmployee INT FOREIGN KEY REFERENCES Employees(IDEmployee),
	Content NTEXT NOT NULL,
	DateCreate DATE DEFAULT GETDATE() NOT NULL,
	Status INT
)