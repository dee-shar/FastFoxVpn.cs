using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FastFoxVpnApi
{
    public class FastFoxVpn
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://api.fastfoxvpn.com/api/v1";
        public FastFoxVpn()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("okhttp/3.14.9");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> getServers(string uuid)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/servers?uuid={uuid}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
