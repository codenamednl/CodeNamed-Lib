using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CodeNamed.Infrastructure.Web
{
    public class WebApiClient : IWebApiClient
    {      
        public T Post<T>(string apiRoute, T entity) where T : class, new()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var result = client.PostAsJsonAsync(apiRoute, entity).Result;

                    return result.Content.ReadAsAsync<T>().Result;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return default(T);
            }
        }

        public TResult Post<T, TResult>(string apiRoute, T entity) where T : class, new()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var result = client.PostAsJsonAsync(apiRoute, entity).Result;

                    return result.Content.ReadAsAsync<TResult>().Result;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return default(TResult);
            }
        }

        public T Get<T>(string apiRoute, string queryString)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = client.GetAsync($"{apiRoute}?{queryString}").Result;

                return result.Content.ReadAsAsync<T>().Result;
            }
        }

        public T Put<T>(string apiRoute, T entity) where T : new()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = client.PutAsJsonAsync(apiRoute, entity).Result;

                return result.Content.ReadAsAsync<T>().Result;
            }
        }
    }
}