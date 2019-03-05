using MicroServiceTemplate.MicroServiceTemplateModule.Services.Interfaces;
using Thorium.Core.MicroServices.Abstractions;

namespace MicroServiceTemplate.Endpoints
{
    public class MicroServiceTemplateEndpointSample : IServiceEndpoint
    {
        private readonly IMicroServiceTemplateService _service;

        public MicroServiceTemplateEndpointSample(IMicroServiceTemplateService service)
        {
            _service = service;
        }
        
        
        public void StartServer()
        {
            _service.DoSomething();
        }

        public void StopServer()
        {
            // place your clean up code here for an endpoint
        }

        public string EndpointDescription => "MicroServiceTemplate sample endpoint";
    }
}