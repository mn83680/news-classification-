using Microsoft.AspNetCore.Mvc;
using NewsClasification.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace NewsClasification.Controllers
{
    public class CategoryController : Controller
    {
        Entity context = new Entity();

        public IActionResult Category()
        {
            List<Category> cateModel = context.categories.ToList();
            //    List<Category> categories = new List<Category>();
            //  categories.Add(new Category(1, "test"));
            //Console.WriteLine(categories.Count);

            return View(cateModel);
        }

        /*
        public IActionResult ShowNewsId(int Id)
        {
            Id = 1;
            List<News> NewsModel = context.news.Where(x => x.Id == Id).ToList();
            return View(NewsModel);
        }
        */
    }
}
