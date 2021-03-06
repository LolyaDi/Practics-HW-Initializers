﻿using CitiesCatalog.DataAccess;
using System.Collections.Generic;
using System.Data.Entity;

namespace CitiesCatalog.Services.Abstract
{
    public class Service
    {
        public DataContext _context;

        public Service()
        {
            _context = new DataContext();
        }

        public List<TEntity> Select<TEntity>() where TEntity : class
        {
            var entities = new List<TEntity>();
            entities.AddRange(_context.Set<TEntity>());

            return entities;
        }

        public void Insert<TEntity>(TEntity entity) where TEntity : class
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
