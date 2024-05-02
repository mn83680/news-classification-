using NewsClassNet6.Models;

namespace NewsClassNet6.Repository
{
    public class NewsRepository : INewsRepository
    {
        Entity context;//= new ITIEntity();
        public NewsRepository(Entity _context)
        {
            context = _context;
        }
        public List<News> GetAll()
        {
            return context.news.ToList();
        }
        public News GetById(int id)
        {
            return context.news.FirstOrDefault(x => x.Id == id);
        }
        public void Insert(News item)
        {
            context.news.Add(item);
            context.SaveChanges();
        }
        public void Edit(int id, News item)
        {
            News oldDept = GetById(id);
            oldDept.Title = item.Title;
            oldDept.Content = item.Content;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            News oldDept = GetById(id);
            context.news.Remove(oldDept);
            context.SaveChanges();
        }
    }
}
