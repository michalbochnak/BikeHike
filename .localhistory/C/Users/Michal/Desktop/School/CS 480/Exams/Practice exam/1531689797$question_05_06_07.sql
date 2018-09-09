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