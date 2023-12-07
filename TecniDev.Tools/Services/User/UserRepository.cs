using TecniDev.Tools.Data.Context;

namespace TecniDev.Tools.Services.User
{
    internal class UserRepository<TEntity, TId> : IUserRepository<TEntity, TId> where TEntity : class, new()
    {
        protected readonly UserContext _context;
        protected UserContext Context { get => _context; }

        public UserRepository(UserContext userContext)
        {
            _context = userContext;
        }

        public void Add(TEntity entity)
        {
            ArgumentNullException.ThrowIfNull(entity);
            try
            {
                Context.Add(entity);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(TId id)
        {
            var entity = _context.Find<TEntity>(id);
            ArgumentNullException.ThrowIfNull(entity);
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public TEntity FindById(TId id)
        {
            var entity = _context.Find<TEntity>(id);
            ArgumentNullException.ThrowIfNull(entity);
            return entity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return _context.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(TEntity entity)
        {
            ArgumentNullException.ThrowIfNull(entity);
            try
            {
                _context.ChangeTracker.Clear();
                _context.Update(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close()
        {
            _context?.Dispose();
            Context?.Dispose();
        }
    }
}
