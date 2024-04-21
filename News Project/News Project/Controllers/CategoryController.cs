using Microsoft.AspNetCore.Mvc;
using News_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace News_Project.Controllers
{

    public class CategoryController : Controller
    {
        ITIEntity context = new ITIEntity();
        public IActionResult Index()
        {
            
            List<Category> cateModel = context.Category.ToList();
        //    List<Category> categories = new List<Category>();
          //  categories.Add(new Category(1, "test"));
            //Console.WriteLine(categories.Count);
            
            return View(cateModel);
        }


        public IActionResult ShowNewsId( int Id)
        {
            Id = 1;
            List<News> NewsModel = context.News.Where(x => x.NewsId == Id).ToList();
            return View( NewsModel);
        }
    }   

}
