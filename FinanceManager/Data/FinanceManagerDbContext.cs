using Microsoft.EntityFrameworkCore;

namespace FinanceManager.Data
{
    public class FinanceManagerDbContext: DbContext
    {
        public FinanceManagerDbContext(DbContextOptions<FinanceManagerDbContext> options): base(options) { }
    }
}
