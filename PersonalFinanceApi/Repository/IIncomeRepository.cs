using PersonalFinanceApi.Models;

namespace PersonalFinanceApi.Repository
{
    public interface IIncomeRepository
    {
        Task<Income> GetByIdAsync(int id);
        Task<IEnumerable<Income>> GetByUserIdAsync(int userId);
        Task<IEnumerable<Income>> GetByAccountIdAsync(int accountId);
        Task AddAsync(Income income);
        Task UpdateAsync(Income income);
        Task DeleteAsync(int id);
    }
}
