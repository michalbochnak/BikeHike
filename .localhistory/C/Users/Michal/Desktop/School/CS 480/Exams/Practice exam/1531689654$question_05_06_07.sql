﻿CREATE TABLE Customers (
  CID         INT IDENTITY (2001, 1) PRIMARY KEY,
  FirstName   NVARCHAR(64) NOT NULL,
  LastName    NVARCHAR(64) NOT NULL
);