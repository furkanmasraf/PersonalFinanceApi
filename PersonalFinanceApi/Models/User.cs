namespace PersonalFinanceApi.Models
{
    public class User
    {
        public int Id { get; set; }

        // Ad Soyad
        public string FullName { get; set; }

        // Email
        public string Email { get; set; }

        // Şifre (ileride Hash'lenecek)
        public string Password { get; set; }

        // İlişkiler
        public ICollection<Account> Accounts { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Income> Incomes { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }  
}
