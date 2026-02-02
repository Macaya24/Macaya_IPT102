CREATE PROCEDURE [dbo].[UpdateCustomer]
    @CustomerId INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @PhoneNumber NVARCHAR(20) = NULL,
    @Address NVARCHAR(200) = NULL
AS
BEGIN
    UPDATE Customer
    SET 
        FirstName = @FirstName,
        LastName = @LastName,
        PhoneNumber = @PhoneNumber,
        Address = @Address
    WHERE CustomerId = @CustomerId;

END;
