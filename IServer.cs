using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace core3Demo
{
    public interface IServer
    {
        Task StartAsync(RequestDelegate handler);
    }
}
