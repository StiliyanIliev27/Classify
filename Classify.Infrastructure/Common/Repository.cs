﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Classify.Infrastructure.Common
{
    public class Repository : IRepository
    {
        private readonly ClassifyDbContext context;

        public Repository(ClassifyDbContext context)
        {
            this.context = context;
        }

        private DbSet<T> DbSet<T>() where T : class => context.Set<T>();

        public IQueryable<T> All<T>() where T : class => DbSet<T>();

        public IQueryable<T> AllReadOnly<T>() where T : class => DbSet<T>().AsNoTracking();

        public async Task AddAsync<T>(T entity) where T : class => await context.AddAsync(entity);

        public EntityEntry Delete<T>(T entity) where T : class => context.Remove(entity);

        public async Task<int> SaveChangesAsync() => await context.SaveChangesAsync();

        public async Task<T?> GetByIdAsync<T>(object id) where T : class => await DbSet<T>().FindAsync(id);
    
    }
}
