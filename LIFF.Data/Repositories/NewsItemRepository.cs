using LIFF.Data.Infrastructure;
using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Repositories
{
    public class NewsItemRepository : RepositoryBase<NewsItem>, INewsItemRepository
    {
        public NewsItemRepository(IDbFactory dbFactory) : base(dbFactory) { }

       
    }

    public interface INewsItemRepository : IRepository<NewsItem>
    {
    }

}
