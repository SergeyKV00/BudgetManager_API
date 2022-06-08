namespace BudgetManager.Models
{
    public enum TypeOperation 
    { 
        Expenditure, 
        Income 
    }

    public class Operation
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public decimal Sum { get; set; }

        public DateTime Date { get; set; }

        public TypeOperation Type { get; set; }

        public Account Account { get; set; }

        public Category Category { get; set; }
    }
}
