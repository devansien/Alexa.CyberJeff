using System.Threading.Tasks;

namespace CyberJeff
{
    class SessionEndedRequestHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessManager.ProcessRequest($"{BuiltInRequest.SessionEndedRequest}", async () =>
            {
                await Task.Run(() =>
                {
                    Logger.Write("Session expired");
                });
            });
        }
    }
}
