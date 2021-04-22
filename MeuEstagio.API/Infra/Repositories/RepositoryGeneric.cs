using MeuEstagio.API.Data;
using MeuEstagio.API.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace MeuEstagio.API.Infra.Repositories
{
    public class RepositoryGeneric<T> : IGeneric<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;

        public RepositoryGeneric()
        {

        }
        public RepositoryGeneric(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(T Objeto)
        {
            await _dbContext.Set<T>().AddAsync(Objeto);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(T Objeto)
        {
            _dbContext.Set<T>().Update(Objeto);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(T Objeto)
        {
            _dbContext.Set<T>().Remove(Objeto);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);

        }

        public async Task<List<T>> List()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }


        #region Disposed

        //private bool _disposed = false;

        //// Instantiate a SafeHandle instance.
        //private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);


        //// Public implementation of Dispose pattern callable by consumers.
        //public void Dispose() => Dispose(true);

        //// Protected implementation of Dispose pattern.
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (_disposed)
        //    {
        //        return;
        //    }

        //    if (disposing)
        //    {
        //        // Dispose managed state (managed objects).
        //        _safeHandle?.Dispose();
        //    }

        //    _disposed = true;
        //}


        #endregion
    }
}
