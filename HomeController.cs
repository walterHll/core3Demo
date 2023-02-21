using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace core3Demo
{
    public class HomeController : Controller
    {
        private readonly IHostApplicationLifetime _lifetime;

        public HomeController(IHostApplicationLifetime lifetime)
            => _lifetime = lifetime;

        [HttpGet("/index")]
        public void Index() { }

        [HttpGet("/stop")]
        public void Stop() => _lifetime.StopApplication();
    }
}
