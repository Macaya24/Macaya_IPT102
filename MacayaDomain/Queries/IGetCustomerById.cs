using System;
using System.Collections.Generic;
using System.Text;
using MacayaDomain.Models;

namespace MacayaDomain.Queries
{
   public interface IGetCustomerById
    {
        Task<CustomerModel?> ExecuteAsync(int Id);

    }
}
