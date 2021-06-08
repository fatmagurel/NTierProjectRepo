using NTierProject.CORE.Entity.Concrete;
using NTierProject.CORE.Enum;
using NTierProject.DATAACCESS.Context;
using NTierProject.DATAACCESS.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Transactions;

namespace NTierProject.DATAACCESS.Repositories.Concrete
{
    public class Repository<T> : IRepository<T> where T : CoreEntity
    {
        private readonly ProjectContext _context;
        public Repository(ProjectContext context)
        {
            _context = context;
        }

        

        public bool Activate(Guid id)
        {
            T activated = GetByID(id);
            activated.Status = Status.Active;
            return Update(activated);
        }

        public bool Add(T item)
        {
            _context.Set<T>().Add(item);
            return Save() > 0;
        }

        public bool Add(List<T> items)
        {
            _context.Set<T>().AddRange(items);
            return Save() > 0;
        }

        public bool Any(Expression<Func<T, bool>> exp) => _context.Set<T>().Any(exp);
        
        //public bool Any(Expression<Func<T, bool>> exp)
        //{
        //    return _context.Set<T>().Any(exp);
        //}

        public List<T> GetActive()
        {
            return _context.Set<T>().Where(x => x.Status == Status.Active).ToList();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetByDefault(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp).FirstOrDefault();
        }

        public T GetByID(Guid id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp).ToList();
        }

        public bool Remove(T item)
        {
            item.Status = Status.Deleted;
            return Update(item);
        }

        public bool Remove(Guid id)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    T deleted = GetByID(id);
                    deleted.Status = Status.Deleted;
                    ts.Complete();
                    return Update(deleted);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveAll(Expression<Func<T, bool>> exp)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    var collection = GetDefault(exp);

                    int count = 0;

                    foreach (var item in collection)
                    {
                        item.Status = Status.Deleted;
                        bool opResult = Update(item);
                        if (opResult) count++;
                    }

                    if (collection.Count == count) ts.Complete();
                    else return false;

                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public bool Update(T item)
        {
            try
            {
                _context.Set<T>().Update(item);
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;                
            }
        }
    }
}
