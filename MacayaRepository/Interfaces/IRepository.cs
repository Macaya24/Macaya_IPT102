using Dapper;
namespace MacayaRepository.Interfaces
{
    public interface IRepository
    {
        public Task<IEnumerable<T>> GetDataAsync<T>(string connectionString,
       string storedProcName,
       DynamicParameters parameters = null);
        public Task<bool> SaveDataAsync(string connectionString,
            string storedProcName,
            DynamicParameters parameters = null);
    }
}
