using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NewsClasification.Models
{
    public class StoreNews
    {
        public List<News> newsCache;

        public void AddNews(News news)
        {
            if (news != null && !newsCache.Any(n => n.Id == news.Id))
            {
                newsCache.Add(news);
            }
        }

        public void DeleteNews(int newsId)
        {
            newsCache.RemoveAll(n => n.Id == newsId);
        }
        public IEnumerable<News> GetAllNews()
        {
            return newsCache;
            //  newsCache.AsReadOnly()
        }

        [ForeignKey("Publisher")]
        public int pub_Id { get; set; }
        public Publisher publisher;

        [ForeignKey("News")]
        public int pub { get; set; }
        public News news;
    }
}
