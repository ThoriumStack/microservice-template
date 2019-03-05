using System;
using Thorium.Core.MicroServices;

namespace MicroServiceTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            var runner = new ServiceRunner();
            runner.Run(new MicroServiceTemplateServiceStartup(), args);
        }
    }
}