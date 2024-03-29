﻿CREATE TABLE Doctor(
  DID         INT IDENTITY(1, 1) PRIMARY KEY,
  First       NVARCHAR(64) NOT NULL,
  Last        NVARCHAR(64) NOT NULL,
  BeeperID    INT NOT NULL CHECK (BeeperID > 0),
  Initials    NVARCHAR(3) NOT NULL
);

CREATE TABLE Time (
  TID         INT IDENTITY(1, 1) PRIMARY KEY,
  Date        DATE NOT NULL,
  IsHoliday   BIT NOT NULL DEFAULT(0)
);

CREATE TABLE Call (
  DID         INT FOREIGN KEY REFERENCES Doctor(DID),
  TID         INT FOREIGN KEY REFERENCES Time(TID)
  PRIMARY KEY (DID, TID)
);

CREATE TABLE Call (
  DID         INT FOREIGN KEY REFERENCES Doctor(DID),
  TID         INT FOREIGN KEY REFERENCES Time(TID)
  PRIMARY KEY (DID, TID)
);