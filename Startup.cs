using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace core3Demo
{
    public abstract class StartupBase
    {
        public StartupBase() => Debug.WriteLine(this.GetType().FullName);
        public void Configure(IApplicationBuilder app) { }
    }

    public class StartupDevelopment : StartupBase { }
    public class StartupStaging : StartupBase { }
    public class Startup : StartupBase { }

}
