using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewsClassNet6.Models;
using NewsClassNet6.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace NewsClassNet6.Controllers
{
    [Authorize]
    public class NewsController : Controller
    {
        Entity context = new Entity();

        //............................................................Edit.........................


        //open page
        public IActionResult Edit(int id)
        {
            ViewBag.cats = context.categories.ToList<Category>();
            News? nes = context.news.FirstOrDefault(n => n.Id == id);
            return View(nes);
        }
        //Save
        [HttpPost] //not used URL => News/SaveEdit/1?Title=...&Contint=... => Just By Form
        //Defult [HttpGet]
        public IActionResult SaveEdit(int id , News newnews) //call form
        {
      
            //get old
            News nes = context.news.FirstOrDefault(c => c.Id == id);

             if(newnews.Id != null)
            { 
                nes.Title = newnews.Title;
                nes.Content = newnews.Content;
                nes.Category_Id = newnews.Category_Id;
            }
            context.SaveChanges(); //action   ,  controller ,  Details of news
           return RedirectToAction("NewsAdmin" , "News");
           //return RedirectToAction("Details" , "Category" , new {id=nes.Category_Id});
        }

        //............................................View..................................................... 
      
        public IActionResult News()
        {
            
            List<News> cateModel = context.news.ToList();
           

            return View(cateModel);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult NewsAdmin()
        {
            List<News> cateModel = context.news.ToList();
           

            return View(cateModel);
        }

        //................................add...............................................

        public IActionResult New()
        {
           

            return View();
        }
        [HttpPost]
        public IActionResult New(News newS)
        {
            ViewBag.cats = context.categories.ToList<Category>();
            //save
            context.news.Add(newS);
                context.SaveChanges();
                return RedirectToAction("News");
            
            
        }

        //...................................Delete...................................................

        public IActionResult Delete(int id)
        {
            News? ne = context.news.FirstOrDefault(s => s.Id == id);
            context.news.Remove(ne);
            context.SaveChanges();
            return RedirectToAction("News");

        }

        /*
         
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
