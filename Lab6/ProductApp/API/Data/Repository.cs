using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DataContext context;
        public Repository(DataContext context)
        {
            this.context = context;
        }

        public bool Create(T entity)
        {
            if(this.GetById(entity.Id) != null)
            {
                return false;
            } else
            {
                this.context.Set<T>().Add(entity);
                this.context.SaveChanges();
                return true;
            }
            
        }

        public IEnumerable<T> GetAll() => this.context.Set<T>().AsEnumerable();

        public T GetById(int id) => this.context.Set<T>().Find(id);

        public T Remove(int id)
        {
            T temp = GetById(id);
            if (temp != null)
            {
                this.context.Set<T>().Remove(this.context.Set<T>().Find(id));
                this.context.SaveChanges();
                return temp;
            }
            else return null;
           
        }

        public void Update(T entity)
        {
            //this.context.Set<T>().Update(entity);
            this.context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.context.SaveChanges();
        }

        public IEnumerable<T> GetByCriteria(Func<T, bool> filter) => this.context.Set<T>().Where(filter).AsEnumerable();
        
        
        public void Entry(T entity)
        {
            this.context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }   

}
