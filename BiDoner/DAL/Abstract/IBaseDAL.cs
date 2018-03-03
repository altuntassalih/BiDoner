using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiDoner.DAL.Abstract
{
    public interface IBaseDAL<T>
    {
        int Add(T entity);
        bool Delete(string id);
        bool Update(T entity);
        T Get(string id);
        List<T> GetAll();

    }
}
