using System.Linq.Expressions;

namespace SCM.Infrastructure.Core;

public interface IDaoBase<Entity, TypeId> where Entity : class
{
    Task<List<Entity>> GetAll();
    Task<Entity> GetById(TypeId id);
    Task<List<Entity>> GetWithFilter(Expression<Func<Entity, bool>> filter);
    Task<bool> Exists(Expression<Func<Entity, bool>> filter);
    void Save(Entity entity);
    void Update(Entity entity);
}
