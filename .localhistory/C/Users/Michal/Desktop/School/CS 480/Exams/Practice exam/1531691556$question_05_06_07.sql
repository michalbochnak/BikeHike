CREATE TABLE Customers (
  CID         INT IDENTITY (2001, 1) PRIMARY KEY,
  FirstName   NVARCHAR(64) NOT NULL,
  LastName    NVARCHAR(64) NOT NULL
);

CREATE TABLE Products(
  PID         INT IDENTITY(1000, 1) PRIMARY KEY,
  Name        NVARCHAR(64) NOT NULL,
  Price       DECIMAL NOT NULL CHECK (Price >= 0),
  Quantity    INT NOT NULL CHECK (Quantity >= 0)
);

CREATE TABLE Orders (
  OID         INT IDENTITY(1, 1) PRIMARY KEY,
  CID         INT FOREIGN KEY REFERENCES Customers(CID),
  OrderDate   DATE NOT NULL
);

CREATE TABLE OrderDetails(
  OID       INT FOREIGN KEY REFERENCES Orders(OID),
  PID       INT FOREIGN KEY REFERENCES Products(PID),
  Quantity  INT NOT NULL CHECK (Quantity >= 0),
  PricePaid DECIMAL CHECK (PricePaid >= 0)
);


INSERT INTO Customers (FirstName, LastName)
VALUES                ('Helen', 'Bochnak'),
                      ('Aga', 'Bochnak'),
                      ('John', 'Bell'),
                      ('John', 'Hard'),
                      ('Stan', 'Mazowski'),
                      ('Sean', 'Hummel');

INSERT INTO Products(Name, Price, Quantity)
VALUES              ('Pen', 0.99, 100),
                    ('Pencil', 0.33, 500),
                    ('Sticky Notes', 2.29, 0);

INSERT INTO Orders  (CID, OrderDate)
VALUES              ((SELECT CID FROM Customers WHERE FirstName = 'Aga'), '1/31/2016');

INSERT INTO OrderDetails  (OID, PID, Quantity, PricePaid)
VALUES                    ((SELECT OID FROM Orders WHERE CID = 2004), (SELECT PID FROM Products WHERE PID = 1001), 10, 9.99);


SELECT *
FROM Customers;

SELECT *
FROM Products;

SELECT *
FROM Orders;

SELECT *
FROM OrderDetails;


SELECT FirstName, LastName
FROM Customers
JOIN Orders ON Customers.CID = Orders.CID
ORDER BY LastName, FirstName;