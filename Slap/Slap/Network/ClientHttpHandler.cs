using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Slap.Slap.Network {

    public static class ClientHttpHandler {

        public static async void POST(string url, string payload) {

            HttpClientHandler httpClientHandler = new HttpClientHandler() {
                UseDefaultCredentials = true,
            };

            using (HttpClient httpClient = new HttpClient(httpClientHandler))
            using (StringContent httpContent = new StringContent(payload)) {

                await httpClient.PostAsync(url, httpContent);
            }
        }
    }
}
