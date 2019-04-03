using System.Diagnostics;

namespace Antlia.MovimentosManuais.Infrastructure
{
    public class MMContext : DbContext
    {
        public MMContext()
            : base("name=AntliaConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
