namespace Aptos.Unity.SDK.Generated.Core
{
    public class ApiResult
    {
        public readonly string Url;
        public readonly bool Ok;
        public readonly int Status;
        public readonly string StatusText;
        public readonly object Body;

        public ApiResult(string url, bool ok, int status, string statusText, object body)
        {
            Url = url;
            Ok = ok;
            Status = status;
            StatusText = statusText;
            Body = body;
        }
    }

}
