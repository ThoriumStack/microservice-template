using System.Collections.Generic;
using MicroServiceTemplate.Endpoints;
using MicroServiceTemplate.MicroServiceTemplateModule.Repositories;
using MicroServiceTemplate.MicroServiceTemplateModule.Repositories.Interfaces;
using MicroServiceTemplate.MicroServiceTemplateModule.Services;
using MicroServiceTemplate.MicroServiceTemplateModule.Services.Interfaces;
using Serilog;
using Thorium.Core.MicroServices;
using Thorium.Core.MicroServices.Abstractions;
using Thorium.Core.MicroServices.ConfigurationModels;
using Thorium.Core.MicroServices.LivenessChecks;

namespace MicroServiceTemplate
{
    public class MicroServiceTemplateServiceStartup : IServiceStartup, ISeedable, ICanCheckLiveness
    {
        public void ConfigureService(ServiceConfiguration configuration)
        {
            configuration.InjectAutoMapper();
            configuration.InjectServiceBase();

            //configuration.AddConfiguration<List<DbSettings>>();
            // Your services and repositories go here
            configuration.Inject<IMicroServiceTemplateRepository, MicroServiceTemplateRepository>();
            configuration.Inject<IMicroServiceTemplateService, MicroServiceTemplateService>();
            
            configuration.AddServiceEndpoint<MicroServiceTemplateEndpointSample>();
            
        }

        public void SeedData(List<DbSettings> databaseSettings, ILogger logger)
        {
            // you can do data seeding and migrations here.
        }


        public void ConfigureLivenessChecks(LivenessCheckConfiguration config)
        {
            // Add liveness checks here.
            //config.AddCheck<>();
            
        }
    }
}