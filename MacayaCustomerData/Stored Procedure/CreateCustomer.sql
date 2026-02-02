CREATE PROCEDURE [dbo].[CreateCustomer]
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @PhoneNumber NVARCHAR(20) = NULL,
    @Address NVARCHAR(200) = NULL
AS
BEGIN
    INSERT INTO Customer (FirstName, LastName, PhoneNumber, Address)
    VALUES (@FirstName, @LastName, @PhoneNumber, @Address);

END;
