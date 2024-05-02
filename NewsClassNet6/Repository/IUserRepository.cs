using NewsClassNet6.Models;

namespace NewsClassNet6.Repository
{
    public interface IUserRepository
    {
        Guid id { get; set; }
        List<User> GetAll();
        List<User> GetAllUsersWithUsersData();
        User GetById(int id);
        void Insert(User item);
        void Edit(int id, User item);
        void Delete(int id);

    }
}
