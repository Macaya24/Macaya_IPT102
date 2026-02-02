using MacayaDomain.Commands;
using MacayaDomain.Models;
using MacayaFramework.Extensions;
using MacayaRepository.Interfaces;

namespace IMacayaFramework.Commands;

public class DeleteCustomer : IDeleteCustomer
{
    private readonly string _connectionName = "DefaultConnection";
    private readonly string _storedProcedureName;
    private readonly IRepository _reposository;

    public DeleteCustomer(IRepository reposository)
    {
        _storedProcedureName = "[dbo].[DeleteCustomer]";
        _reposository = reposository;
    }

    public async Task<bool> ExecuteAsync(CustomerModel model)
    {
        var p = model.ToCustomerDynamicParameters();
        return await _reposository.SaveDataAsync(_connectionName, _storedProcedureName, p);
    }
}
