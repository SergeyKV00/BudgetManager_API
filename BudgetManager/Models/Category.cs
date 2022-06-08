namespace BudgetManager.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public TypeOperation TypeOperation { get; set; }
        
        public ICollection<User> Users { get; set; }
    }
}
