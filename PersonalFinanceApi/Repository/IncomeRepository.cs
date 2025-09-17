using Microsoft.EntityFrameworkCore;
using PersonalFinanceApi.Data;
using PersonalFinanceApi.Models;

namespace PersonalFinanceApi.Repository
{
    public class IncomeRepository : IIncomeRepository
    {
        private readonly AppDbContext _context;

        public IncomeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Income> GetByIdAsync(int id)
        {
            return await _context.Incomes
                .Include(i => i.User)
                .Include(i => i.Account)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<Income>> GetByUserIdAsync(int userId)
        {
            return await _context.Incomes
                .Include(i => i.Account)
                .Where(i => i.UserId == userId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Income>> GetByAccountIdAsync(int accountId)
        {
            return await _context.Incomes
                .Include(i => i.User)
                .Where(i => i.AccountId == accountId)
                .ToListAsync();
        }

        public async Task AddAsync(Income income)
        {
            await _context.Incomes.AddAsync(income);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Income income)
        {
            _context.Incomes.Update(income);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var income = await _context.Incomes.FindAsync(id);
            if (income != null)
            {
                _context.Incomes.Remove(income);
                await _context.SaveChangesAsync();
            }
        }
    }
}
