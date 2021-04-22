using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuEstagio.API.Interface
{
    public interface IGeneric<T> where T : class
    {
        Task Add(T Objeto);
        Task Update(T Objeto);
        Task Delete(int id);
        Task<T> GetById(int id);
        Task<List<T>> List();
    }
}
