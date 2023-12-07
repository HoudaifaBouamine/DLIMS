SELECT 
u.User_Id,u.UserName,u.isActive,U.Permission,u.Password
,n.NationalityName,n.CountryName,p.* 
FROM Users u 
JOIN Persons p 
ON u.Person_Id = p.Person_Id 
JOIN Nationalities n ON p.Nationality_Id = n.Nationality_Id