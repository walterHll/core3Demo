using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using System.Threading;

namespace core3Demo
{
    public class WebHostedService : IHostedService
    {
        private readonly IServer _server;
        private readonly RequestDelegate _handler;
        public WebHostedService(IServer server, RequestDelegate handler)
        {
            _server = server;
            _handler = handler;
        }
        public Task StartAsync(CancellationToken cancellationToken) => _server.StartAsync(_handler);
        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}
