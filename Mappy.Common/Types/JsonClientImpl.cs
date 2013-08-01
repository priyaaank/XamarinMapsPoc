using System;
using ServiceStack.ServiceClient.Web;
using ServiceStack.Common.Web;
using System.Collections.Generic;
using ServiceStack.ServiceHost;

namespace BankApp.Common.Lib
{
    public class JsonClientImpl : IJsonClient
    {
        private static Double TIMEOUT = 30d;

        #region IJsonClient implementation

        public void DoGetRequest<T> (string url, string callbackParam, Action<string, T> successCallback, Action<string, T, Exception> failureCallback)
        {
            var client = new JsonServiceClient(url);
            client.HttpMethod = HttpMethods.Get;
            client.Timeout = TimeSpan.FromSeconds(TIMEOUT);
            client.GetAsync<T> ("", r => successCallback(callbackParam, r), (r, ex) => failureCallback(callbackParam, r, ex));
        }

        public void DoGetRequest<T> (string url, Action<T> successCallback, Action<Exception> failureCallback)
        {
            var client = new JsonServiceClient(url);
            client.HttpMethod = HttpMethods.Get;
            client.Timeout = TimeSpan.FromSeconds(TIMEOUT);
            client.GetAsync<T> ("", r => successCallback(r), (r, ex) => failureCallback(ex));
        }

		public T DoGetRequestSync<T> (string url)
		{
			var client = new JsonServiceClient(url);
			client.HttpMethod = HttpMethods.Get;
			client.Timeout = TimeSpan.FromSeconds(TIMEOUT);
			return client.Get<T> (url);
		}

        public void DoPostRequest<Req, Res> (string url, Req request, Action<Req, Res> successCallback, Action<Req, Res, Exception> failureCallback)
        {
            var client = new JsonServiceClient(url);
            client.HttpMethod = HttpMethods.Post;
            client.Timeout = TimeSpan.FromSeconds(TIMEOUT);
            client.SendAsync<Res>(request, r => successCallback(request, r), (r, ex) => failureCallback(request, r, ex));
        }

        #endregion

        public JsonClientImpl ()
        {
        }
    }
}

