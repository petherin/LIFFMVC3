using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        LIFFEntities dbContext;

        public LIFFEntities Init()
        {
            return dbContext ?? (dbContext = new LIFFEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
