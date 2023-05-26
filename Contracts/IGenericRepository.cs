namespace first_asp_app.Contracts
{
    public interface IGenericRepository<T> where T: class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<bool> Exists(int id);

        Task DeleteAsync(int id);

        Task UpdateAsync(T entity);

        Task<T> AddAsync(T entity);

        Task<List<T>> AddRangeAsync(List<T> entities);
    }
}
