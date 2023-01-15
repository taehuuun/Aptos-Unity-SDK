using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aptos.Unity.SDK.Generated.Core
{
    public class ApiError : Exception
    {
        public readonly string Url;
        public readonly int Status;
        public readonly string StatusText;
        public readonly object Body;
        public readonly ApiRequestOptions Request;

        public ApiError(ApiRequestOptions request, ApiResult response, string message) : base(message)
        {
            Url = response.Url;
            Status = response.Status;
            StatusText = response.StatusText;
            Body = response.Body;
            Request = request;
        }
    }

}