using Administrativo.Models;
using Microsoft.EntityFrameworkCore;

namespace Administrativo.Contexts
{
    public class LancamentoContext: DbContext
    {
        public LancamentoContext(DbContextOptions<LancamentoContext> options)
            :base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<Lancamento> Lancamentos { get; set; }

    }
}
