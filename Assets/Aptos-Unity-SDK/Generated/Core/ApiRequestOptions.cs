using System.Collections.Generic;

namespace Aptos.Unity.SDK.Generated.Core
{
    public enum Method
    {
        GET, PUT, POST, DELETE, OPTIONS, HEAD, PATCH
    }

public class ApiRequestOptions
{
    public readonly Method Method;
    public readonly string Url;
    public readonly Dictionary<string, object> Path;
    public readonly Dictionary<string, object> Cookies;
    public readonly Dictionary<string, object> Headers;
    public readonly Dictionary<string, object> Query;
    public readonly Dictionary<string, object> FormData;
    public readonly object Body;
    public readonly string MediaType;
    public readonly string ResponseHeader;
    public readonly Dictionary<int, string> Errors;

    public ApiRequestOptions(Method method, string url, Dictionary<string, object> path = null, Dictionary<string, object> cookies = null, Dictionary<string, object> headers = null, Dictionary<string, object> query = null, Dictionary<string, object> formData = null, object body = null, string mediaType = null, string responseHeader = null, Dictionary<int, string> errors = null)
    {
        Method = method;
        Url = url;
        Path = path;
        Cookies = cookies;
        Headers = headers;
        Query = query;
        FormData = formData;
        Body = body;
        MediaType = mediaType;
        ResponseHeader = responseHeader;
        Errors = errors;
    }
}

}