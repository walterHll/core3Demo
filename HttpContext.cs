using Microsoft.AspNetCore.Http;
using System.Collections.Specialized;
using System.IO;
using System;

namespace core3Demo
{
    public class HttpContext
    {
        public HttpRequest Request { get; }
        public HttpResponse Response { get; }

        public HttpContext(IFeatureCollection features)
        {
            Request = new HttpRequest(features);
            Response = new HttpResponse(features);
        }
    }
    public class HttpRequest
    {
        private readonly IHttpRequestFeature _feature;

        public Uri Url => _feature.Url;
        public NameValueCollection Headers => _feature.Headers;
        public Stream Body => _feature.Body;

        public HttpRequest(IFeatureCollection features) => _feature = features.Get<IHttpRequestFeature>();
    }
    public class HttpResponse
    {
        private readonly IHttpResponseFeature _feature;

        public NameValueCollection Headers => _feature.Headers;
        public Stream Body => _feature.Body;
        public int StatusCode { get => _feature.StatusCode; set => _feature.StatusCode = value; }

        public HttpResponse(IFeatureCollection features) => _feature = features.Get<IHttpResponseFeature>();

    }
}
