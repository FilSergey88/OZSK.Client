using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using OZSK.Client.Model.Abstr;

namespace OZSK.Client.ServiceAgent
{
    public class BaseGetServiceAgent<TParam, TResult>
    {
        private string _path;
        private readonly ServiceConfig _serviceConfig;

        public BaseGetServiceAgent(string path)
        {
            _path = path;
            _serviceConfig = new ServiceConfig
            {
                BaseURL = Constant.BaseURl,
                Port = Constant.Port
            };
        }

        public virtual async Task<TResult> Execute(TParam param, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Execute path: {_path}");
            using var client = HttpClientBuilder.CreateClient();
            var builder = new UriBuilder(_serviceConfig.BaseURL)
            {
                Port = _serviceConfig.Port,
                Path = $"/api/{BuildUrl(_path, param)}",
                Query = BuildUrlParams(param).ToString()
            };

            var uri = builder.ToString();

            var response = await CallAsync(cancellationToken, client, uri);

            if (response.IsSuccessStatusCode)
            {
                var data = await ProcessResponse(response);
                return data;
            }
            else
            {
                var exception = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(exception))
                {
                    exception = $"Ошибка при получении данных, сервер ответил: {response.ReasonPhrase}";
                }

                throw new Exception(exception);
            }
        }

        protected virtual NameValueCollection BuildUrlParams(TParam param)
        {
            return HttpUtility.ParseQueryString(param?.ToString());
        }

        protected virtual async Task<TResult> ProcessResponse(HttpResponseMessage response)
        {
            var result = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.NoContent)
                return await Task.FromResult(default(TResult));

            return await Task.Run(() => JsonConvert.DeserializeObject<TResult>(result));
        }

        protected virtual async Task<HttpResponseMessage> CallAsync(CancellationToken cancellationToken,
            HttpClient client, string uri)
        {
            return await client.GetAsync(uri, cancellationToken);
        }

        protected virtual string BuildUrl(string baseUrl, TParam param)
        {
            return baseUrl;
        }
    }
}