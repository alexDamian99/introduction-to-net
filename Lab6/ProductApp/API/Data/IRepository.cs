using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetByCriteria(Func<T, bool> filter);

        bool Create(T entity);

        void Update(T entity);

        T Remove(int id);

        void Entry(T entity);
    }

}
