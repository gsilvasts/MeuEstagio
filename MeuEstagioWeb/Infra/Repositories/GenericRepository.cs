using MeuEstagioWeb.Interface;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace MeuEstagioWeb.Infra.Repositories
{
    public class GenericRepository <T> : IGenericRepository<T>, IDisposable where T :  class
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entidade)
        {
            throw new NotImplementedException();
        }

        public List<T> Lista()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, T entidade)
        {
            throw new NotImplementedException();
        }

        #region Disposed

        private bool _disposed = false;

        // Instantiate a SafeHandle instance.
        private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose() => Dispose(true);

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // Dispose managed state (managed objects).
                _safeHandle?.Dispose();
            }

            _disposed = true;
        }
        #endregion
    }
}
