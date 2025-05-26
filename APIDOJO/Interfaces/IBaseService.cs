public interface IBaseService<T>
{
    Task<List<T>> GetAll();
    Task<T?> GetById(int id);
    Task<T> Add(T entity);
    Task<bool> Delete(int id);
    Task<T?> Update(int id, T entity);
}
