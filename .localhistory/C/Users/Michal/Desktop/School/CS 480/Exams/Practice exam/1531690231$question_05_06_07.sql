CREATE TABLE Customers (
  CID         INT IDENTITY (2001, 1) PRIMARY KEY,
  FirstName   NVARCHAR(64) NOT NULL,
  LastName    NVARCHAR(64) NOT NULL
);

CREATE TABLE Products(
  PID         INT IDENTITY(1000, 1) PRIMARY KEY,
  Name        NVARCHAR(64) NOT NULL,
  Price       DECIMAL NOT NULL CHECK (Price > 0),
  Quantity    INT NOT NULL CHECK (Quantity > 0)
);

CREATE TABLE Orders (
  OID         INT IDENTITY(1, 1) PRIMARY KEY,
  CID         INT FOREIGN KEY REFERENCES Customers(CID),
  OrderDate   DATE NOT NULL
);

CREATE TABLE OrderDetails(
  OID       INT FOREIGN KEY REFERENCES Orders(OID),
  PID       INT FOREIGN KEY REFERENCES Products(PID),
  Quantity  INT NOT NULL CHECK (Quantity > 0),
  PricePaid DECIMAL CHECK (PricePaid > 0)
);


INSERT INTO Customers (FirstName, LastName)
VALUES                ('Michal', 'Bochnak'),
                      ('Joe', 'Hummel');

SELECT *
FROM Customers;

UPDATE TABLE Customers
SET FirstName('Joe')
WHERE ;