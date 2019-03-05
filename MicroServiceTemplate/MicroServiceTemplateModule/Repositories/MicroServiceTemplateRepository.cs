using System.Collections.Generic;
using AutoMapper;
using MicroServiceTemplate.MicroServiceTemplateModule.Data;
using MicroServiceTemplate.MicroServiceTemplateModule.Repositories.Interfaces;
using Serilog;
using Thorium.Core.MicroServices.Abstractions;
using Thorium.Core.MicroServices.ConfigurationModels;
using Thorium.Core.MicroServices.Repositories;

namespace MicroServiceTemplate.MicroServiceTemplateModule.Repositories
{
    public class MicroServiceTemplateRepository :  GenericContextRepositoryBase<MicroServiceTemplateDbContext>, IMicroServiceTemplateRepository
    {
        public MicroServiceTemplateRepository(List<DbSettings> localSettings, IMapper mapper, ILogger logger) :
            base (localSettings.Find(c => c.Name == "MicroServiceTemplateDb"), mapper, logger)
        {
        }
    }
}