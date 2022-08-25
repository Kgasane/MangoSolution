using FrondEnd.MangoApp.Models;
using MangoApp.Models;
using MangoApp.Services.IServices;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MangoApp.Services
{
    public class BaseService : IbaseServices
    {
        public IHttpClientFactory httpclient { get; set; }
        public ResponseDto responseModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public BaseService(IHttpClientFactory httpclient, ResponseDto responseModel)
        {
            this.httpclient = httpclient;
            this.responseModel = new ResponseDto();
        }

        public Task<T> SendingAsync<T>(APIRequest aPIRequest)
        {
     
            try
            {
                var client = httpclient.CreateClient("MangoApp");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(aPIRequest.URL);
                client.DefaultRequestHeaders.Clear();

                if(aPIRequest.Data == null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(aPIRequest.Data), Encoding.UTF8, "application/json");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
