using PersonalFinanceApi.Models;
namespace PersonalFinanceApi.Repository

{
    public interface IExpenseRepository
    {
        Task<Expense> GetByIdAsync(int id);
        Task<IEnumerable<Expense>> GetByUserIdAsync(int userId);
        Task<IEnumerable<Expense>> GetByAccountIdAsync(int accountId);
        Task AddAsync(Expense expense);
        Task UpdateAsync(Expense expense);
        Task DeleteAsync(int id);
    }
}
