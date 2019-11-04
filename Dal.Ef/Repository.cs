using Domain.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dal.Ef
{
    
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext context)
        {
            Context = context;
        }

        public TEntity Get(object id)
        {
            return Context.Set<TEntity>().Find(id);
        }
       

        public List<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(List<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public IEnumerable<TEntity> ExecuteStored(string ProcedureName, object[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
                ProcedureName += " @p" + i.ToString() + ",";
            ProcedureName = ProcedureName.Remove(ProcedureName.Length - 1, 1);


            //IEnumerable<TEntity> result = null;
            //Task myTask = Task.Run(() => result = GetAsync(Context,ProcedureName,parameters).Result);
            //myTask.Wait();           
            //return result;

            var result = Context.Set<TEntity>().FromSql(ProcedureName, parameters).ToList();
            return result;
        }

        private static async System.Threading.Tasks.Task<IEnumerable<TEntity>> GetAsync(DbContext Context, string ProcedureName, object[] parameters)
        {
            return Context.Set<TEntity>().FromSql<TEntity>(ProcedureName, parameters);
        }



        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

       

        List<TEntity> IRepository<TEntity>.Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate).ToList();
        }

        public int GetCount()
        {
            return Context.Set<TEntity>().Count();
        }
    }

}
