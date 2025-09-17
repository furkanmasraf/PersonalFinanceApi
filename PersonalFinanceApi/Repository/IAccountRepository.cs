using PersonalFinanceApi.Models;

namespace PersonalFinanceApi.Repository
{
    public interface IAccountRepository
    {
        Task<Account> GetByIdAsync(int id);
        Task<IEnumerable<Account>> GetByUserIdAsync(int userId);
        Task AddAsync(Account account);
        Task UpdateAsync(Account account);
        Task DeleteAsync(int id);
    }
}
