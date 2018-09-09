CREATE  TABLE  Customer (
    CID             INT IDENTITY(20001,1)  PRIMARY  KEY,
    FirstName       NVARCHAR(64)  NOT  NULL,
    LastName        NVARCHAR(64)  NOT  NULL,
    Email           NVARCHAR(64) NOT NULL
);

CREATE TABLE BikeType ( 
	TID		        INT IDENTITY(1,1) PRIMARY KEY,			
	BikeDescription NVARCHAR(256) NOT NULL,				
	HourlyPrice	    MONEY CHECK (HourlyPrice > 0)
);

CREATE TABLE Bike (
	BID			    INT IDENTITY(1001,1) PRIMARY KEY,				
	TID			    INT NOT NULL FOREIGN KEY REFERENCES BikeType(TID),	
	BikeYear		SMALLINT NOT NULL CHECK (BikeYear > 0),
	Rented			BIT NOT NULL DEFAULT(0)		
);

CREATE TABLE Rental (
	RID 		    INT IDENTITY(1,1) PRIMARY KEY,		
	CID			    INT NOT NULL FOREIGN KEY REFERENCES Customer(CID),
	StartTime   	DATETIME NOT NULL,						-- hh:mm:ss, e.g 09:54:32
	ExpDuration	    FLOAT NOT NULL CHECK (ExpDuration > 0), -- i.e 0.5 for 30 mins
	NumBikes        SMALLINT NOT NULL CHECK (NumBikes > 0),
	ActDuration	    FLOAT CHECK (ActDuration > 0),  -- NULL if rental is still out
    TotalPrice      MONEY   -- NULL if rental is still out
);

CREATE TABLE RentalDetail (
    RDID            INT IDENTITY(1, 1) PRIMARY KEY,
    RID             INT NOT NULL FOREIGN KEY REFERENCES Rental(RID),
    BID             INT NOT NULL FOREIGN KEY REFERENCES Bike(BID)
);

CREATE INDEX CustomerLastName_Index
ON Customer(LastName)
INCLUDE (FirstName, Email);

CREATE INDEX BikeTID_Index
ON Bike(TID)
INCLUDE (BikeYear, Rented);


DROP INDEX CustomerLastName_Index ON Customer;
DROP INDEX BikeTID_Index ON Bike;


SELECT * 
FROM Customer
ORDER BY LastName ASC,
FirstName ASC;

SELECT BID, BikeYear, Rented, BikeDescription, HourlyPrice
FROM Bike WITH (INDEX(BikeTID_Index))
INNER JOIN  BikeType ON Bike.TID = BikeType.TID 
ORDER BY BID ASC;


