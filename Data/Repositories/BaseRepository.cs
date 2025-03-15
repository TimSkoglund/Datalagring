﻿using Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public abstract class BaseRepository<TEntity>(DataContext context) where TEntity : class
{
    protected readonly DataContext _context = context;
    protected readonly DbSet<TEntity> _db = context.Set<TEntity>();

    public async Task TaskAsync(TEntity entity)
    {
        await _db.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<TEntity>> GetAsync()
    {
        var entities = await _db.ToListAsync();
        return entities;
    }
    public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> expression)
    {
        var entity = await _db.FirstOrDefaultAsync(expression);
        return entity;
    }
    public async Task UpdateAsync(TEntity entity)
    {
        _db.Update(entity);
        await _context.SaveChangesAsync();
    }
    public async Task RemoveAsync(TEntity entity)
    {
        _db.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
//CREATE
//READ
//UPDATE
//DELETE

