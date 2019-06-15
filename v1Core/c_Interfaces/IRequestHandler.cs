using System.Threading.Tasks;

namespace CyberJeff
{
    interface IRequestHandler
    {
        Task HandleRequest();
    }
}
