using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ekakoskatl.Models;

namespace Ekakoskatl.Data.Infraestucture
{
    public abstract class BaseRepository<T> where T : class
    {
        #region Properties
        private EkakoskatlWebEntity _dataContext;
        private readonly IDbSet<T> _dbSet;

        private IDbFactory DbFactory { get; set; }

        protected StoreEntities DbContext
        {
            get { return _dataContext ?? (_dataContext = DbFactory.Init()); }
        }
        #endregion
        protected RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            _dbSet = DbContext.Set<T>();
        }

        #region Implementation
        public virtual void Add(T entity)
        {
            try
            {
                _dataContext.Configuration.AutoDetectChangesEnabled = false;
                _dbSet.Add(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _dataContext.Configuration.AutoDetectChangesEnabled = true;
            }

        }
        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Add(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");
                //_dataContext.Dispose();
                //_dataContext = new StoreEntities();
                _dataContext.Configuration.AutoDetectChangesEnabled = false;

                _dataContext.Set<T>().AddRange(entities);
                //var cont = 0;
                //foreach (var entity in entities)
                //{
                //    cont++;
                //    _dataContext.Set<T>().Add(entity);
                //    if (cont % 10 == 0)
                //    {
                //        _dataContext.SaveChanges();
                //        _dataContext.Dispose();
                //        _dataContext = new StoreEntities();
                //        _dataContext.Configuration.AutoDetectChangesEnabled = false;
                //    //}
                ////}
                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _dataContext.Configuration.AutoDetectChangesEnabled = true;
            }
        }
        public virtual void Update(T entity)
        {
            //_dbSet.Attach(entity);
            //_dataContext.Entry(entity).State = EntityState.Modified;
            var entry = _dataContext.Entry(entity);
            if (entry.State == EntityState.Detached || entry.State == EntityState.Modified)
            {
                _dbSet.Attach(entity); //attach
                entry.State = EntityState.Modified; //do it here
            }
            if (entry.State == EntityState.Unchanged)
            {
                entry.State = EntityState.Detached;
                _dbSet.Attach(entity);
                entry.State = EntityState.Modified;
            }
        }

        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual void Update(IEnumerable<T> entities)
        {
            try
            {

                if (entities == null)
                    throw new ArgumentNullException("entities");
                //_dataContext.Dispose();
                //_dataContext = new StoreEntities();
                _dataContext.Configuration.AutoDetectChangesEnabled = false;
                //var cont = 0;
                foreach (var entity in entities)
                {
                    //cont++;
                    _dataContext.Entry(entity).State = EntityState.Modified;
                    //if (cont % 100==0)
                    //{
                    //    _dataContext.SaveChanges();
                    //    _dataContext.Dispose();
                    //    _dataContext = new StoreEntities();
                    //    _dataContext.Configuration.AutoDetectChangesEnabled = false;
                    //}
                }
                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _dataContext.Configuration.AutoDetectChangesEnabled = true;
            }
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = _dbSet.Where(where).AsEnumerable();
            foreach (T obj in objects)
                _dbSet.Remove(obj);
        }

        public virtual T GetById(int id)
        {
            try
            {
                _dataContext.Configuration.AutoDetectChangesEnabled = false;
                return _dbSet.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                _dataContext.Configuration.AutoDetectChangesEnabled = true;
            }

        }
        public virtual T GetByUUID(Guid id)
        {
            try
            {
                _dataContext.Configuration.AutoDetectChangesEnabled = false;
                return _dbSet.Find(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                _dataContext.Configuration.AutoDetectChangesEnabled = true;
            }

        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).FirstOrDefault();
        }

        public virtual List<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes)
        {

            var query = includes.Aggregate<Expression<Func<T, object>>, IQueryable<T>>(_dbSet, (current, include) => current.Include(include));

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return query.ToList();
        }
                     
        #endregion
    }
}
