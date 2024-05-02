using NewsClassNet6.Models;

namespace NewsClassNet6.Repository
{
    public interface INewsRepository
    {
        List<News> GetAll();
        News GetById(int id);
        void Insert(News item);
        void Edit(int id, News item);
        void Delete(int id);
    }
}