using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Movies.Desktop.Helpers
{
    public class HttpClientHelper
    {
        private static readonly Lazy<HttpClientHelper> _instance =
      new(() => new HttpClientHelper());

        public static HttpClientHelper Instance => _instance.Value;

        private readonly CookieContainer _cookieContainer;

        private readonly HttpClientHandler _handler;

        private readonly HttpClient _client;

        private readonly JsonSerializerOptions _jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        private HttpClientHandler()
        {
            _cookieContainer = new CookieContainer();

            _handler = new HttpClientHandler();

        }
    }
}
