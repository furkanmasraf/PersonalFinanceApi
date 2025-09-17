namespace PersonalFinanceApi.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; } // Banka, Nakit, Kredi Kartı
        public decimal Balance { get; set; }

        // İlişkiler
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

        public ICollection<Expense> Expenses { get; set; }

        public ICollection<Income> Incomes { get; set; }
    }
}
