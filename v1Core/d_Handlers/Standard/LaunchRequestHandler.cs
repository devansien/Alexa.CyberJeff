using System.Threading.Tasks;

namespace CyberJeff
{
    class LaunchRequestHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessManager.ProcessRequest($"{BuiltInRequest.LaunchRequest}", async () =>
            {
                await Task.Run(() =>
                {
                    State.NumPlayed++;
                    State.NumPrompted = 0;
                });
            });
        }
    }
}
