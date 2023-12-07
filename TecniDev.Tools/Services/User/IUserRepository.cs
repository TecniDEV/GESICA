namespace TecniDev.Tools.Services.User
{
    internal interface IUserRepository<TEntity, TId> where TEntity : class, new()
    {
        IEnumerable<TEntity> GetAll();
        TEntity FindById(TId id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TId id);
    }
}
