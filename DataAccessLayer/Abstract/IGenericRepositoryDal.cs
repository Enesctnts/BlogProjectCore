using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericRepositoryDal<T> where T:class
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetlistAll();
        T GetByID(int id);
        List<T> GetlistAll(Expression<Func<T,bool>> filter);

    }
}
