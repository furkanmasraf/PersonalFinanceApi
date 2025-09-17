namespace PersonalFinanceApi.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public string Type { get; set; } // "cash", "credit_card", "bank_transfer", vb.
        public bool IsIncome { get; set; } // true: gelir, false: gider

        // İlişkiler
        public int UserId { get; set; }
        public User User { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
