namespace NLayerCore.Servicess
{
    public interface IService<T>where T:class
    {
     Task<T> GetByIdAsync(int id);
     Task<IEnumerable<T>> GetAllAsync();
     IQueryable<T> Where (Expression<Func<T,bool>> expression);
     Task<bool> AnyAsync(Expression<Func<T,bool>> expression);
     Task<T> AddAsync(T entity);
     void Update(T entity);
     void Remove(T entity);
     void RemoveRange(IEnumerable<T>entities); 
    }
}