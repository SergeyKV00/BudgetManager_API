using BudgetManager.Data.Interfaces;
using BudgetManager.Models;

namespace BudgetManager.Data
{
    public class UserData : IUserData
    {
        private readonly BudgetContext _budgetContext;

        public UserData(BudgetContext budgetContext)
        {
            _budgetContext = budgetContext;
        }

        public User AddUser(User user)
        {
            _budgetContext.Add(user);
            _budgetContext.SaveChangesAsync();
            return user;
        }

        public User DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(Guid id)
        {
            var user = _budgetContext.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public List<User> GetUsers()
        {
            var users = _budgetContext.Users;
            return users.ToList();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
