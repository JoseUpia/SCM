using Microsoft.EntityFrameworkCore;
using SCM.Domain.Context;
using System.Linq.Expressions;

namespace SCM.Infrastructure.Core;

public abstract class DaoBase<Entity, TypeId> : IDaoBase<Entity, TypeId> where Entity : class
{
    private readonly HealtSyncContext _healtSyncContext;
    private DbSet<Entity> _entities;
    public DaoBase(HealtSyncContext healtSyncContext)
    {
        _healtSyncContext = healtSyncContext;
        _entities = healtSyncContext.Set<Entity>();
    }

    public virtual async Task<List<Entity>> GetAll()
        => await this._entities.ToListAsync();
    
    public virtual Task<Entity> GetById(TypeId id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<List<Entity>> GetWithFilter(Expression<Func<Entity, bool>> filter)
        => await this._entities.Where(filter).ToListAsync();

    public virtual async Task<bool> Exists(Expression<Func<Entity, bool>> filter)
        => await this._entities.AnyAsync(filter);

    public virtual void Save(Entity entity)
    {
        try
        {
             this._entities.Entry(entity).State = EntityState.Added;
        }
        catch (Exception ex)
        {   
            throw;
        }
    }

    public virtual void Update(Entity entity)
    {
        try
        {
            this._entities.Entry(entity).State = EntityState.Modified;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
