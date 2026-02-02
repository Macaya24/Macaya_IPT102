CREATE PROCEDURE [dbo].[GetCustomerById]
    @CustomerId INT
AS
BEGIN
    SELECT CustomerId, FirstName, LastName, PhoneNumber, Address
    FROM Customer
    WHERE CustomerId = @CustomerId;
END;
