using SuperZapatos.Domain.Models;
using SuperZapatos.WF.Models;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SuperZapatos.WF.ConsumoApi
{
    public class HttpClientArticles
    {
        static HttpClient client = new HttpClient();
        public HttpClientArticles()
        {
            string endpoint = ConfigurationManager.AppSettings["urlService"];
            if (client.BaseAddress == null)            {
                
                client.BaseAddress = new Uri(endpoint);
            }
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<BaseResponse<IEnumerable<Articles>>> GetArticlesAsync(string path)
        {
            BaseResponse<IEnumerable<Articles>> articles = new BaseResponse<IEnumerable<Articles>>();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                articles = await response.Content.ReadAsAsync<BaseResponse<IEnumerable<Articles>>>();
            }
            return articles;
        }

        public async Task<BaseResponse<Articles>> GetArticlesByIdAsync(string path, int id)
        {
            BaseResponse<Articles> articles = new BaseResponse<Articles>();
            HttpResponseMessage response = await client.GetAsync(path + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                articles = await response.Content.ReadAsAsync<BaseResponse<Articles>>();
            }
            return articles;
        }

        public async Task<BaseResponse<IEnumerable<Store>>> GetStoresAsync(string path)
        {
            BaseResponse<IEnumerable<Store>> stores = new BaseResponse<IEnumerable<Store>>();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                stores = await response.Content.ReadAsAsync<BaseResponse<IEnumerable<Store>>>();
            }
            return stores;
        }

        public async Task CreateArticleAsync(string path, Articles article)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                path, article);
            response.EnsureSuccessStatusCode();
        }

        public async Task EditArticleAsync(string path, int id, Articles article)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                path + "/" + id, article);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteArticleAsync(string path, int id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                path + "/" + id);
            response.EnsureSuccessStatusCode();

        }
    }
}
