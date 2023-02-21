using Microsoft.Extensions.Hosting;

namespace core3Demo
{
    public class WebHostBuilder
    {
        public WebHostBuilder(IHostBuilder hostBuilder, IApplicationBuilder applicationBuilder)
        {
            HostBuilder = hostBuilder;
            ApplicationBuilder = applicationBuilder;
        }

        public IHostBuilder HostBuilder { get; }
        public IApplicationBuilder ApplicationBuilder { get; }
    }
}
