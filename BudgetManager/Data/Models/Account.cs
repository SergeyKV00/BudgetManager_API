namespace BudgetManager.Models
{
    public class Account
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Sum { get; set; }

        public User User { get; set; }
    }
}
