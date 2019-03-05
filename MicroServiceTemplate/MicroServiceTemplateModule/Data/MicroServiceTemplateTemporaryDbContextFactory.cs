using Microsoft.EntityFrameworkCore.Design;

namespace MicroServiceTemplate.MicroServiceTemplateModule.Data
{
 
    
    public class MicroServiceTemplateTemporaryDbContextFactory : IDesignTimeDbContextFactory<MicroServiceTemplateDbContext>
    {
        public MicroServiceTemplateDbContext CreateDbContext(string[] args)
        {
            
            return new MicroServiceTemplateDbContext("User ID=postgres;Password=;Host=localhost;Port=5432;Database=MicroServiceTemplate;Pooling=true;");
        }
    }
}