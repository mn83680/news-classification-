using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsClassNet6.Models;
using System.Collections.Generic;
using System.Linq;

namespace NewsClassNet6.Controllers
{
    [Authorize]
    public class NewsController : Controller
    {
        Entity context = new Entity();

        public IActionResult News()
        {
            List<News> cateModel = context.news.ToList();
            //    List<Category> categories = new List<Category>();
            //  categories.Add(new Category(1, "test"));
            //Console.WriteLine(categories.Count);

            return View(cateModel);
        }
       
        /*
         * 
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
         */
    }
}
