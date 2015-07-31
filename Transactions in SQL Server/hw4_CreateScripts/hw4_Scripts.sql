--
-- Sharad Tanwar
-- U. of Illinois, Chicago
-- CS480, Summer 2015
-- Homework 4 - Scripts
--

-- DROP TABLE SailBoat;
-- Drop Table Postion;
-- Drop TABLE CrewMember;
-- DROP TABLE Roles;
-- DROP TABLE Owner;


-- Boat information
CREATE TABLE SailBoat(
	SailBoatID	INT IDENTITY(1,1) PRIMARY KEY,
	Name		VARCHAR(240) NOT NULL,
	Sail_Number INT			 NOT NULL,
	Boat_Length FLOAT, 
	Picture		VARBINARY(MAX) 
);

-- Owner of the Boat
CREATE TABLE OwnerInfo(
	SailBoatID INT FOREIGN KEY REFERENCES SailBoat(SailBoatID),
	OwnerName VARCHAR(240)
	Primary Key (SailBoatID,OwnerName)
);

-- Crew Member Roles 
CREATE TABLE Roles(
	RoleID INT IDENTITY(1,1) PRIMARY KEY,
	RoleName VARCHAR(240) NOT NULL
);

-- Crew Member
CREATE TABLE CrewMember(
	CrewMemberID INT IDENTITY(1,1) PRIMARY KEY,
	SailBoatID INT FOREIGN KEY REFERENCES SailBoat(SailBoatID),
	FirstName VARCHAR(240) NOT NULL,
	LastName VARCHAR(240) NOT NULL,
	City VARCHAR(240) NOT NULL,
	HomeState VARCHAR(240) NOT NULL,
	RoleID INT FOREIGN KEY REFERENCES Roles(RoleID)
);

--  Position of the SailBoat
CREATE TABLE Postion(
	PositionID	INT IDENTITY(1,1) PRIMARY KEY,
	SailBoatID	INT FOREIGN KEY REFERENCES SailBoat(SailBoatID),
	InfoDate	DATE NOT NULL,
	Infotime	TIME NOT NULL,
	Direction	INT NOT NULL,
	Speed		FLOAT,
	Latitude	VARCHAR(240),
	Longitude	VARCHAR(240)
);