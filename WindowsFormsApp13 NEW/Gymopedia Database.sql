create database Gymopedia;

use Gymopedia;

-------creating tables to store data
create table  Member  
(MemberID INT PRIMARY KEY identity,
	FirstName VARCHAR(50),
    LastName VARCHAR(50),
	Gender VARCHAR(10),
	DateOfBirth DATE,
    Email VARCHAR(100),
    Phone VARCHAR(20),
    JoinDate DATE,
    MembershipType VARCHAR(50)
);
select * from Member

CREATE TABLE Trainer 
(
    TrainerID INT PRIMARY KEY identity,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
	Gender VARCHAR(10),
    DateOfBirth DATE,
    Email VARCHAR(100),
    Phone VARCHAR(20),
    Specialization VARCHAR(100)
);

CREATE TABLE Equipment (
    EquipmentID INT PRIMARY KEY IDENTITY,
    EquipmentName VARCHAR(100),
    Price varchar(10),
    DateOfPurchase DATE,
    Quantity varchar,
	Other  Varchar(100)

);





--------inserting data into tables

INSERT INTO Member (FirstName, LastName, Email, Phone, JoinDate, MembershipType)  
VALUES ('Kasun', 'Peiris', 'kasun@gmail.com', '0785671234', '2023-01-01', 'Premium');

SELECT * FROM Member;  

