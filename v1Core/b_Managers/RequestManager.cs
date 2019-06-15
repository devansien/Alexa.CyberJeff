using System.Collections.Generic;

namespace CyberJeff
{
    public class RequestManager
    {
        private List<RequestType> requestTypeList;


        public RequestManager()
        {
            SetRequestTypes();
        }

        public List<RequestType> GetRequestTypes()
        {
            return requestTypeList;
        }

        private void SetRequestTypes()
        {
            requestTypeList = new List<RequestType>
            {
                new RequestType
                {
                    Name = BuiltInRequest.LaunchRequest,
                    Type = typeof(LaunchRequestHandler)
                },
                new RequestType
                {
                    Name = BuiltInRequest.SessionEndedRequest,
                    Type = typeof(SessionEndedRequestHandler)
                }
            };
        }
    }
}
