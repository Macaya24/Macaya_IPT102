using System.Data;
using Dapper;
using MacayaDomain.Models;

namespace MacayaFramework.Extensions
{
    public static class CustomerExtension
    {
        public static DynamicParameters ToCustomerDynamicParameters(this CustomerModel model)
        {
            var p = new DynamicParameters();

            p.Add("@CustomerId", model.CustomerId, DbType.Int32, ParameterDirection.Input);
            p.Add("@FirstName", model.FirstName, DbType.String, ParameterDirection.Input);
            p.Add("@LastName", model.LastName, DbType.String, ParameterDirection.Input);
            p.Add("@PhoneNumber", model.PhoneNumber, DbType.String, ParameterDirection.Input);
            p.Add("@Address", model.Address, DbType.String, ParameterDirection.Input);

            return p;
        }
    }
}
