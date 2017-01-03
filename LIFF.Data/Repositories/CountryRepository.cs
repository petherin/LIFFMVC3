using LIFF.Data.Infrastructure;
using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Repositories
{
    public class CountryRepository : RepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(IDbFactory dbFactory) : base(dbFactory) { }
        
    }

    public interface ICountryRepository : IRepository<Country>
    {
    }
}
