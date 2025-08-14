namespace PersonalFinanceApi.DTOs
{
    public class TransactionDto
    {
        public decimal Amount { get; set; }
        public string Type { get; set; } = "Expense";
        public string Category { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
