using DocumentFormat.OpenXml.Office2010.Excel;
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
        private readonly Entity context;
        private readonly ILogger<NewsController> _logger;
        private readonly UserManager<ApplicationUser> userManager;
        public NewsController(UserManager<ApplicationUser> userManager, Entity context, ILogger<NewsController> logger)
        {
            this.userManager = userManager;
            this.context = context;  // Corrected the parameter name and assignment
            this._logger = logger;
        }

        //............................................................Search.........................
        public IActionResult SearchResult(string searchTerm)
        {
            // البحث عن الخبر الذي يحتوي على مصطلح البحث في عنوانه
            List<News>? newsItem = context.news.Where(n => n.Title.Contains(searchTerm)).ToList();

            if (newsItem == null)
            {
                // إظهار رسالة مفادها عدم وجود نتائج
                return View("NoResults");
            }

            // إعادة الخبر الذي تم العثور عليه
            return View(newsItem);
        }



        //............................................................Edit...........................
        [Authorize]
        //open page
        public IActionResult Edit(int id)
        {
            ViewBag.cats = context.categories.ToList<Category>();
            News? nes = context.news.FirstOrDefault(n => n.Id == id);
            return View(nes);
        }
        //Save
        [HttpPost] //not used URL => News/SaveEdit/1?Title=...&Contint=... => Just By Form //Defult [HttpGet]
        public IActionResult SaveEdit(int id , News newnews) //call form
        {
      
            //get old
            News nes = context.news.FirstOrDefault(c => c.Id == id);

             if(newnews.Id != null)
            { 
                nes.Title = newnews.Title;
                nes.Content = newnews.Content;
                //nes.image = newnews.image;
                nes.Category_Id = newnews.Category_Id;
            }
            context.SaveChanges(); //action   ,  controller ,  Details of news
            return RedirectToAction("NewsAdmin" , "News");
           //return RedirectToAction("Details" , "Category" , new {id=nes.Category_Id});
        }

        //............................................View..................................................... 
        [Authorize]
        public IActionResult News()
        {
            
            List<News> cateModel = context.news.ToList();
           

            return View(cateModel);
        }

        [Authorize(Roles = "Admin , Publisher")]
        public IActionResult NewsAdmin()
        {
            List<News> cateModel = context.news.ToList();
           

            return View(cateModel);
        }

        //................................add...............................................

        public IActionResult New()
        {
            //  ابعت عالتلغرام شو عم نعمل هون
            if (context == null)
            {
                // Handle the case where context is null (e.g., log an error)
                return StatusCode(500, "Internal Server Error");
            }
            ViewData["DeptList"] = context.news.ToList();

            ViewBag.cats = context.categories.ToList<Category>();

            return View(new News());
        }
        //save
        [Authorize]
        [HttpPost]
        public IActionResult New(News model)
        {
           // _logger.LogInformation("Creating a new news item.");

            model.PublishDate = DateTime.Now;
            model.PublisherId = userManager.GetUserId(User);
          // _logger.LogWarning(model.ToString());
           /* if (!ModelState.IsValid)
            {

                _logger.LogWarning("Model state is invalid.");
                _logger.LogWarning(model.Category_Id.ToString());
                ViewBag.cats = context.categories.ToList<Category>();  // Populate categories for dropdown
                return View(model);  // Return the view with the model to show validation errors
            }*/
         //   _logger.LogInformation("All Good");
            // Make sure UserManager is injected and configured
            context.news.Add(model);
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
