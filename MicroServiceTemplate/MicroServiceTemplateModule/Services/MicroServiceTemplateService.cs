using System;
using MicroServiceTemplate.MicroServiceTemplateModule.Repositories.Interfaces;
using MicroServiceTemplate.MicroServiceTemplateModule.Services.Interfaces;
using Serilog;
using Thorium.Core.MicroServices.Services;
using Thorium.Core.Model;

namespace MicroServiceTemplate.MicroServiceTemplateModule.Services
{
    public class MicroServiceTemplateService : ServiceBase, IMicroServiceTemplateService
    {
        private readonly IMicroServiceTemplateRepository _microServiceTemplateRepository;

        public MicroServiceTemplateService(ILogger logger, IMicroServiceTemplateRepository microServiceTemplateRepository): base(logger, microServiceTemplateRepository)
        {
            _microServiceTemplateRepository = microServiceTemplateRepository;
        }

        public ReplyBase DoSomething()
        {
            try
            {
                _logger.Information("Our service is doing something!");
                return ReplyBase.Success();
            }
            catch (Exception e)
            {
                return ReplyFromFatal<ReplyBase>(e, "Unable to do something");
            }
        }
    }
}