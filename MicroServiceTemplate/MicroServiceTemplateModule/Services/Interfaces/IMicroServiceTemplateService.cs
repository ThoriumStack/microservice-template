using Thorium.Core.Model;
using Thorium.Core.Model.Abstractions;

namespace MicroServiceTemplate.MicroServiceTemplateModule.Services.Interfaces
{
    public interface IMicroServiceTemplateService : IServiceBase
    {
        ReplyBase DoSomething();
    }
}