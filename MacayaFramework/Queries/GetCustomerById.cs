using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MacayaDomain.Models;
using MacayaRepository.Interfaces;
using MacayaFramework.Extensions;
namespace IPT102Framework.Queries;

public class GetCustomerById
{
    private readonly string _connectionName;
    private readonly string _storedProcedureName;
    private readonly IRepository _reposository;

    public GetCustomerById(IRepository reposository)
    {
        _connectionName = "DefaultConnection";
        _storedProcedureName = "[dbo].[GetCustomerById]";
        _reposository = reposository;
    }

    public async Task<CustomerModel?> ExecuteAsync(int id)
    {
        var parameters = new Dapper.DynamicParameters();
        parameters.Add("Id", id);
        var result = await _reposository.GetDataAsync<CustomerModel>(_connectionName, _storedProcedureName, parameters);

        return result.FirstOrDefault();
    }
}
