using Microsoft.EntityFrameworkCore;
using Primeiro.Model.Base;
using Primeiro.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Primeiro.Repository.Generic
{
    public class GenericReository<T> : IRepository<T> where T : BaseEntity
    {
        private MySqlContext _context;

        private DbSet<T> dataset;

        public GenericReository(MySqlContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }
        

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(long id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Update(T item)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(item.Id));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return null;
        }

        public void Delete(long id)
        {
            var result = dataset.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public bool Exists(long id)
        {
            return dataset.Any(p => p.Id.Equals(id));
        }
    }
}
