using BudgetManager.Models;

namespace BudgetManager.Data.Interfaces
{
    public interface IUserData
    {
        // Create
        User AddUser(User user);

        // Read 
        List<User> GetUsers();

        User GetUser(Guid id);

        // Update
        User UpdateUser(User user);

       // Delete
       User DeleteUser(User user);
    }
}
