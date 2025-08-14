namespace PersonalFinanceApi.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } = "Expense"; // "Income" veya "Expense"
        public string Category { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
