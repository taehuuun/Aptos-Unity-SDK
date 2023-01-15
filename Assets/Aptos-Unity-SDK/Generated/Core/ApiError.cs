using System;

namespace Aptos.Unity.SDK.Generated.Core
{
    public class ApiError : Exception
    {
        public string url { get; }
        public int status { get; }
        public string statusText { get; }
        public dynamic body { get; }
        public ApiRequestOptions request { get; }

        public ApiError(ApiRequestOptions request, ApiResult response, string message)
            : base(message)
        {
            this.url = response.url;
            this.status = response.status;
            this.statusText = response.statusText;
            this.body = response.body;
            this.request = request;
        }
    }

}