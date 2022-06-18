using BudgetManager.Data.Interfaces;
using BudgetManager.Models;

namespace BudgetManager.Services
{
    public class UserData : IUserData
    {
        private readonly BudgetContext _dbContext;

        public UserData(BudgetContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User AddUser(User user)
        {
            _dbContext.Add(user);
            _dbContext.SaveChangesAsync();
            return user;
        }

        public User DeleteUser(Guid id)
        {
            User user = _dbContext.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _dbContext.Remove(user);
                _dbContext.SaveChangesAsync();
                return user;
            }
            return null;
        }

        public User GetUser(Guid id)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public List<User> GetUsers()
        {
            var users = _dbContext.Users;
            return users.ToList();
        }

        public User UpdateUser(User user)
        {
            var oldUser = _dbContext.Users.FirstOrDefault(u => u.Id == user.Id);
            if (oldUser != null)
            {
                oldUser.Login = user.Login;
                oldUser.Password = user.Password;
                oldUser.ModifiedOn = user.ModifiedOn;
                _dbContext.SaveChangesAsync();
                return oldUser;
            }
            return null;
        }
    }
}
