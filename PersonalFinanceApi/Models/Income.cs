namespace PersonalFinanceApi.Models
{
    public class Income
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Source { get; set; }
        public DateTime DateReceived { get; set; }

    }
}
