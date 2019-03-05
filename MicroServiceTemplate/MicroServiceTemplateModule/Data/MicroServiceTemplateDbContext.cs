using Microsoft.EntityFrameworkCore;
using Thorium.Core.DataProvider;

namespace MicroServiceTemplate.MicroServiceTemplateModule.Data
{
    public class MicroServiceTemplateDbContext : ContextBase
    {
        private string _connectionString;

        public MicroServiceTemplateDbContext(string connectionString)
        {
            _connectionString = connectionString;

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: Connect to a real database.
            optionsBuilder.UseInMemoryDatabase("MicroServiceTemplate_db");
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}