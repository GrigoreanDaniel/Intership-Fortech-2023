using AssetManagement.Application.Repositories;
using AssetManagement.Domain.Common;
using AssetManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Infrastructure.Repositories;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    protected readonly DatabaseContext _context;

    public BaseRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<T> CreateAsync(T entity)
    {
        return (await _context.AddAsync(entity)).Entity;
    }

    public virtual Task<T> UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);

        _context.Entry(entity).State = EntityState.Modified;

        return Task.FromResult(entity);
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
    }

    public virtual async Task<T?> GetAsync(int id, CancellationToken cancellationToken)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public virtual async Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _context.Set<T>().ToListAsync(cancellationToken);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}