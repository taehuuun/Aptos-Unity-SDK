using System.Collections.Generic;

namespace Aptos.Unity.SDK.Generated.Core
{
    public enum Method
    {
        GET, PUT, POST, DELETE, OPTIONS, HEAD, PATCH
    }

    public class ApiRequestOptions
    {
        public Method method { get; } // the HTTP method (GET, PUT, POST, DELETE, OPTIONS, HEAD, PATCH)
        public string url { get; } // the URL of the API endpoint
        public IDictionary<string, object> path { get; set; } // optional, a dictionary containing path parameters for the request
        public IDictionary<string, object> cookies { get; set; } // optional, a dictionary containing cookies to be sent with the request
        public IDictionary<string, object> headers { get; set; } // optional, a dictionary containing headers to be sent with the request
        public IDictionary<string, object> query { get; set; } // optional, a dictionary containing query parameters for the request
        public IDictionary<string, object> formData { get; set; } // optional, a dictionary containing form data to be sent with the request
        public object body { get; set; } // optional, the request body
        public string mediaType { get; set; } // optional, the media type of the request body
        public string responseHeader { get; set; } // optional, the expected response header
        public IDictionary<int, string> errors { get; set; } // optional, a dictionary containing error codes and their associated messages
    }

}