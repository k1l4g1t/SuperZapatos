using SuperZapatos.Domain.Models;
using SuperZapatos.WF.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SuperZapatos.WF.ConsumoApi
{
    public class HttpClientStores
    {
        static HttpClient client = new HttpClient();
        public HttpClientStores()
        {
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri("https://localhost:7033/services/");
            }
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<BaseResponse<IEnumerable<Store>>> GetStoresAsync(string path)
        {
            BaseResponse<IEnumerable<Store>> articles = new BaseResponse<IEnumerable<Store>>();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                articles = await response.Content.ReadAsAsync<BaseResponse<IEnumerable<Store>>>();
            }
            return articles;
        }

        public async Task<BaseResponse<Store>> GetStoresByIdAsync(string path, int id)
        {
            BaseResponse<Store> stores = new BaseResponse<Store>();
            HttpResponseMessage response = await client.GetAsync(path + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                stores = await response.Content.ReadAsAsync<BaseResponse<Store>>();
            }
            return stores;
        }

        public async Task CreateStoreAsync(string path, Store store)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                path, store);
            response.EnsureSuccessStatusCode();
        }

        public async Task EditStoreAsync(string path, int id, Store store)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                path + "/" + id, store);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteStoreAsync(string path, int id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                path + "/" + id);
            response.EnsureSuccessStatusCode();

        }
    }
}
