using Microsoft.AspNetCore.Mvc;
using PersonalFinanceApi.Models;
using PersonalFinanceApi.DTOs;

namespace PersonalFinanceApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private static List<Transaction> transactions = new List<Transaction>();
        private static int idCounter = 1;

        [HttpPost("{userId}")]
        public IActionResult AddTransaction(int userId, TransactionDto dto)
        {
            var transaction = new Transaction
            {
                Id = idCounter++,
                UserId = userId,
                Amount = dto.Amount,
                Type = dto.Type,
                Category = dto.Category,
                Date = dto.Date
            };
            transactions.Add(transaction);
            return Ok(transaction);
        }

        [HttpGet("{userId}")]
        public IActionResult GetTransactions(int userId)
        {
            var userTransactions = transactions.Where(t => t.UserId == userId).ToList();
            return Ok(userTransactions);
        }
    }
}
