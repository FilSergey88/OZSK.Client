using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OZSK.Client.Model.Abstr;

namespace OZSK.Client.ServiceAgent
{
    public class BasePostServiceAgent<TParam, TResult> 
    {
        private readonly string _path;
        private readonly ServiceConfig _serviceConfig;
        public BasePostServiceAgent(string path)
        {
            _path = path;
            _serviceConfig = new ServiceConfig
            {
                Port = Constant.Port,
                BaseURL = Constant.BaseURl
            };
        }
        public virtual async Task<TResult> Execute(TParam param, CancellationToken cancellationToken)
        {
            using var client = HttpClientBuilder.CreateClient();
            var content = CreateStringContent(param);
            var paramsss = JsonConvert.SerializeObject(param);
            var builder = new UriBuilder(_serviceConfig.BaseURL)
            {
                Port = _serviceConfig.Port,
                Path = $"{(string.IsNullOrWhiteSpace(_serviceConfig.BasePath) ? string.Empty : _serviceConfig.BasePath + "/" + _serviceConfig.ServiceName)}/api/{_path}"
            };

            var uri = builder.ToString();


            var response = await CallAsync(cancellationToken, client, uri, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrWhiteSpace(result))
                    return default(TResult);

                return await Task.Run(() => JsonConvert.DeserializeObject<TResult>(result));
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
        protected virtual StringContent CreateStringContent(TParam param)
        {
            var content = JsonConvert.SerializeObject(param,
                new JsonSerializerSettings() { DateTimeZoneHandling = DateTimeZoneHandling.Unspecified });

            return new StringContent(content,
                Encoding.UTF8, "application/json");
        }
        protected virtual async Task<HttpResponseMessage> CallAsync(CancellationToken cancellationToken, HttpClient client, string uri, StringContent content)
        {
            return await client.PostAsync(uri, content, cancellationToken);
        }
    }
}
