using AdessoWorldLeague.Core.Entities;
using System.Linq.Expressions;

namespace AdessoWorldLeague.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null, List<T> entities = null);
        T Get(Expression<Func<T, bool>> filter, List<T> entities = null);
        T Add(T entity, List<T> entities = null);
        T Update(T entity, List<T> entities = null);
        bool Delete(T entity, List<T> entities = null);
    }
}
