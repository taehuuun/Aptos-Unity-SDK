namespace Aptos.Unity.SDK.Generated.Core
{
    public class ApiResult
    {
        public string url { get; }
        public bool ok { get; }
        public int status { get; }
        public string statusText { get; }
        public dynamic body { get; }

        public ApiResult(string url, bool ok, int status, string statusText, dynamic body)
        {
            this.url = url;
            this.ok = ok;
            this.status = status;
            this.statusText = statusText;
            this.body = body;
        }
    }
}
