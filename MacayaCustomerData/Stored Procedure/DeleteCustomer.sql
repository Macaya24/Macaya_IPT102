CREATE PROCEDURE [dbo].[DeleteCustomer]
    @CustomerId INT
AS
BEGIN
    DELETE FROM Customer
    WHERE CustomerId = @CustomerId;

END;
