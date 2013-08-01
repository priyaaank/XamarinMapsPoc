using System;
using ServiceStack.ServiceHost;

namespace BankApp.Common.Lib
{
    public interface IJsonClient
    {
        void DoGetRequest<T>(string url, string callbackParam, Action<string, T> successCallback, Action<string, T, Exception> failureCallback);

        void DoGetRequest<T> (string url, Action<T> successCallback, Action<Exception> failureCallback);

		T DoGetRequestSync<T> (string url);

        void DoPostRequest<Req, Res> (string url, Req request, Action<Req, Res> successCallback, Action<Req, Res, Exception> failureCallback);
    }
}

