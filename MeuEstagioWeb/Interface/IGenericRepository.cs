using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuEstagioWeb.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> Lista();
        T GetById(int id);
        void Insert(T entidade);
        void Delete(int id);
        void Update(int id, T entidade);
    }
}
