using NewsClassNet6.Models;
using NewsClassNet6.Repository;

namespace NewsClassNet6.Repository
{
    public class UserMockREspotory: IUserRepository
    {
        List<User> Users = new List<User>();
        public UserMockREspotory()
        {
            Users.Add(new User());
        }

        public Guid id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Delete(int id)
        {
            //students.Remove();
        }

        public void Edit(int id, User item)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<User> getallStudent()
        {
            return Users;
        }

        public List<User> GetAllUsersWithUsersData()
        {
            throw new NotImplementedException();
        }


        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(User item)
        {
            throw new NotImplementedException();
        }
    }
}
