using AdessoWorldLeague.Core.Entities;
using System.Linq.Expressions;

namespace AdessoWorldLeague.Core.DataAccess.InMemory
{
    public class ImEntityRepositoryBase<T> : IEntityRepository<T>
        where T : class, IEntity, new()
    {
        public List<T> GetList(Expression<Func<T, bool>> filter = null, List<T> entities = null)
        {
            if (filter != null)
            {
                Func<T, bool> func = filter.Compile();
                Predicate<T> predicate = func.Invoke;
                return entities.FindAll(predicate).ToList();
            }
            return entities.ToList();
        }

        public T Get(Expression<Func<T, bool>> filter, List<T> entities = null)
        {
            Func<T, bool> func = filter.Compile();
            Predicate<T> predicate = func.Invoke;
            var entity = entities.FindAll(predicate).FirstOrDefault();
            return entity;
        }

        public T Add(T entity, List<T> entities = null)
        {
            entities.Add(entity);
            return entity;
        }

        public T Update(T entity, List<T> entities = null)
        {
            entities.Remove(entity);
            entities.Add(entity);
            return entity;
        }

        public bool Delete(T entity, List<T> entities = null)
        {
            return entities.Remove(entity);
        }
    }
}
