using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MacayaDomain.Commands;
using MacayaDomain.Models;
using MacayaFramework.Extensions;
using MacayaRepository.Interfaces;

namespace MacayaFramework.Commands;

public class CreateCustomer : ICreateCustomer
{
    private readonly string _connectionName = "DefaultConnection";
    private readonly string _storedProcedureName;
    private readonly IRepository _reposository;

    public CreateCustomer(IRepository reposository)
    {
        _storedProcedureName = "[dbo].[CreateCustomer]";
        _reposository = reposository;
    }

    public async Task<bool> ExecuteAsync(CustomerModel model)
    {
        var p = model.ToCustomerDynamicParameters();
        return await _reposository.SaveDataAsync(_connectionName, _storedProcedureName, p);
    }
}
