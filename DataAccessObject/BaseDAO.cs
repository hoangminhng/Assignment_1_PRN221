using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObject
{
    public class BaseDAO<T> where T : class
    {
        private FUMiniHotelManagementContext _context;
        private DbSet<T> _dbSet;

        public BaseDAO()
        {
            _context = new FUMiniHotelManagementContext();
            _dbSet = _context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public bool Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                var tracker = _context.Attach(entity);
                tracker.State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}
