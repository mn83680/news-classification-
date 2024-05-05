using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewsClassNet6.Models;
using System.Security.Principal;

namespace NewsClassNet6.Controllers
{


    [Authorize]
    public class CategoryController : Controller
    {
        Entity context = new Entity();
        // Model Binder -> Collect Data from Form -> Storage By Action Method .
        public IActionResult New()
        {
            //view="New",Model=null
            return View(new Category());
        }
        //<form method="post">
        [HttpPost] 
        public IActionResult SaveNew(Category cat)//Brimitev Type -> if exist -> Storage -> else = Null .
        {
            if (cat.Name != null)
            {
                context.categories.Add(cat);
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
            
        }



        public IActionResult Index()
        {
            List<Category> deptList = context.categories.ToList();

            //return View("Index",deptList);//view =index ,Model = deptlist
            return View(deptList);       
            //view =Index ,Model =deptList
            //return View("Index");//view=Index,Model=null
            //return View();//view=index ,Model =null
        }
        //Category/details
        
        public IActionResult Details(int id)
        {
            Category cat = context.categories.FirstOrDefault(d => d.Id == id);
            return View("Details", cat);
        }
        //......................................................................................................5..........
        

        public IActionResult Category()
        {
            List<Category> cateModel = context.categories.ToList();
            //    List<Category> categories = new List<Category>();
            //  categories.Add(new Category(1, "test"));
            //Console.WriteLine(categories.Count);

            return View(cateModel);
        }
        public IActionResult Sport()
        {
            List<News> cateModel = context.news.ToList();
            //    List<Category> categories = new List<Category>();
            //  categories.Add(new Category(1, "test"));
            //Console.WriteLine(categories.Count);

            return View(cateModel);
        }
        public IActionResult Political()
        {
            List<News> cateModel = context.news.ToList();
            //    List<Category> categories = new List<Category>();
            //  categories.Add(new Category(1, "test"));
            //Console.WriteLine(categories.Count);

            return View(cateModel);
        }
        public IActionResult Economic()
        {
            List<News> cateModel = context.news.ToList();
            //    List<Category> categories = new List<Category>();
            //  categories.Add(new Category(1, "test"));
            //Console.WriteLine(categories.Count);

            return View(cateModel);
        }
        public IActionResult Technology()
        {
            List<News> cateModel = context.news.ToList();
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
