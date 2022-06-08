namespace BudgetManager.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public DateTime? RevokeOn { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
