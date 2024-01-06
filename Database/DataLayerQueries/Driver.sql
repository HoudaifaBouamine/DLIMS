USE DVLD_db;
SELECT d.* FROM Drivers d 
JOIN Persons p 
ON d.Person_Id = p.Person_Id