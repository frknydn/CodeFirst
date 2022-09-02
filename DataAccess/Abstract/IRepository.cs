using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public  interface IRepository<T> where T : class
    {
        bool Add(T entity);
        int Save();
    }
}
