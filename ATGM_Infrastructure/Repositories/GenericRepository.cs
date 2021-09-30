using ATGM_DomainServices.Repositories;
using ATGM_Infrastructure.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATGM_Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> Index()
        {
            return _context.Set<TEntity>();
        }

        public TEntity GetByID(int ID)
        {
            return _context.Set<TEntity>().Find(ID);
        }

        public TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public TEntity MarkForAdd(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;

            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();

            return entity;
        }

        public TEntity MarkForUpdate(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();

            return entity;
        }

        public TEntity MarkForDelete(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

            return entity;
        }

        public bool SaveChanges()
        {
            try
            {
                _context.SaveChanges();
                return true;
            } catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
