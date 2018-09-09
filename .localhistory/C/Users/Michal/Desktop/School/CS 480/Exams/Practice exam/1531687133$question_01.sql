CREATE TABLE Doctor(
  DID         INT IDENTITY(1, 1) PRIMARY KEY,
  First       NVARCHAR(64) NOT NULL,
  Last        NVARCHAR(64) NOT NULL,
  BeeperID    INT NOT NULL CHECK (BeeperID > 0),
  Initials    NVARCHAR(3) NOT NULL
);

