CREATE TABLE Table1 (
  F1      INT,
  F2      NVARCHAR(3)
);

CREATE TABLE Table2 (
  G1      INT,
  G2      INT,
  G3      NVARCHAR(3)
);


INSERT INTO Table1 (F1, F2)
VALUES  (10, 'ABC'),
        (25, 'DEF'),
        (87, 'GHI'); 

INSERT INTO Table2 (G1, G2, G3)
VALUES  (5, 10, 'AAA'),
        (10, 87, 'BBB'),
        (15, 156, 'CCC'),
        (20, 10, 'DDD'),
        (25, 91, 'EEE');
        

SELECT F1, F2, G3
FROM Table1
INNER JOIN Table2 ON F1 = G2
ORDER BY F1 ASC;

SELECT F1, G1, G3
FROM Table1
RIGHT JOIN Table2 ON F1 = G2
ORDER BY G1 ASC;

SELECT F1, G1, G3
FROM Table1
LEFT JOIN Table2 ON F1 = G2
ORDER BY G1 ASC;

