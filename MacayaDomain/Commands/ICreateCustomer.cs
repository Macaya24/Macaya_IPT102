using System;
using System.Collections.Generic;
using System.Text;
using MacayaDomain.Models;
namespace MacayaDomain.Commands
{
    public interface ICreateCustomer

    {
        Task<bool> ExecuteAsync(CustomerModel model);

    }
}
