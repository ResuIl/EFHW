namespace EfUow.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity>? GetList(Func<TEntity, bool>? predicate = null);
        TEntity? GetById(int Id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
