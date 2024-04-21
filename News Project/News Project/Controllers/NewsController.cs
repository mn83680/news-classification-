using Microsoft.AspNetCore.Mvc;
using News_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace News_Project.Controllers
{
    public class NewsController : Controller
    {
        ITIEntity context = new ITIEntity();
        public IActionResult News()
        {
            List<News> NModel = context.News.ToList();
            return View(NModel);
        }
    }
}
