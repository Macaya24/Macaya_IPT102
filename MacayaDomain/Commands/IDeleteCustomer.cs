using System;
using System.Collections.Generic;
using System.Text;
using MacayaDomain.Models;

namespace MacayaDomain.Commands
{
    public interface IDeleteCustomer
    {
        Task<bool> ExecuteAsync(CustomerModel model);

    }
}
