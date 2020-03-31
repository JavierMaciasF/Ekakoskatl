using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekakoskatl.Repository.Custom_Repository
{
    public interface IDbFactory : IDisposable
    {
        EkakoskatlWebEntity Init();
    }

    public class DbFactory : Disposable, IDbFactory
    {
        private EkakoskatlWebEntity _dbContext;

        public EkakoskatlWebEntity Init()
        {
            return _dbContext ?? (_dbContext = new EkakoskatlWebEntity());
        }

        protected override void DisposeCore()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }
    }
}
