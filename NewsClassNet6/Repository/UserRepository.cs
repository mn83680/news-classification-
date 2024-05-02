using NewsClassNet6.Models;
using Microsoft.EntityFrameworkCore;

namespace NewsClassNet6.Repository
{
    public class UserRepository: IUserRepository
    {
        //CRUD
        //DI
        Entity context;//= new ITIEntity();

        public Guid id { get; set; }
        public UserRepository(Entity _context)
        {
            id = Guid.NewGuid();
            context = _context;
        }

        public List<User> GetAll()
        {
            return context.users.ToList();
        }
        public List<User> GetAllStudentsWithUsersData()
        {
            return context.users.Include(s => s.Id).ToList();
        }
        public User GetById(int id)
        {
            return context.users.FirstOrDefault(x => x.Id == id);
        }
        public void Insert(User item)
        {
            context.users.Add(item);
            context.SaveChanges();
        }
        public void Edit(int id, User item)
        {
            User oldStudent = GetById(id);
            oldStudent.Name = item.Name;
            oldStudent.Id = item.Id;
            
            
        
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            User oldStudent = GetById(id);
            context.users.Remove(oldStudent);
            context.SaveChanges();
        }

        public List<User> GetAllUsersWithUsersData()
        {
            throw new NotImplementedException();
        }
    }
}
