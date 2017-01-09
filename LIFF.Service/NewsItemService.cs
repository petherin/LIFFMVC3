using LIFF.Data.Infrastructure;
using LIFF.Data.Repositories;
using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Service
{
    public interface INewsItemService
    {
        IEnumerable<NewsItem> GetNewsItems();
        NewsItem GetNewsItem(int id);
        void CreateNewsItem(NewsItem newsItem);
        void SaveNewsItem();
    }

    public class NewsItemService : INewsItemService
    {
        private readonly INewsItemRepository newsItemRepository;
        private readonly IUnitOfWork unitOfWork;

        public NewsItemService(INewsItemRepository newsItemtRepository, IUnitOfWork unitOfWork)
        {
            this.newsItemRepository = newsItemRepository;
            this.unitOfWork = unitOfWork;
        }

        #region INewsItemService Members
        public void CreateNewsItem(NewsItem newsItem)
        {
            newsItemRepository.Add(newsItem);
        }

        public IEnumerable<NewsItem> GetNewsItems()
        {
            var newsItems = newsItemRepository.GetAll();
            return newsItems;
        }

        public NewsItem GetNewsItem(int id)
        {
            var newsItem = newsItemRepository.GetById(id);
            return newsItem;
        }
        
        public void SaveNewsItem()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
