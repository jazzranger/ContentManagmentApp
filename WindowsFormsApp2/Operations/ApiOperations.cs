using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WpfApp2.Models;

namespace WpfApp2.Operations
{
    class ApiOperations
    {
        private string baseUrl;
        string username;
        string password;
        //HttpClient client;
        public ApiOperations()
        {
            this.baseUrl = "http://157.26.82.44:2240";
            this.username = "8";
            this.password = "admin.groupe666";
            //this.client = new HttpClient();

        }

        public HttpClient TokenAs(HttpClient client, User user)
        {
            try
            {
                client.DefaultRequestHeaders.Authorization
                         = new AuthenticationHeaderValue("Bearer", user.access_token);
                return client;
            }
            catch
            {
                return null;
            }          
        }

        public User Auth()
        {

            string endpoint = this.baseUrl + "/token";
            HttpClient client = new HttpClient();

            //var register = client.PostAsync("api/account/register",
            //    new FormUrlEncodedContent(
            //        new Dictionary<string, string> { { "Email", username }, { "Password", password }, { "ConfirmPassword", password } }
            //    )).Result;
            //register.EnsureSuccessStatusCode();

           
            try
            {
                var login = client.PostAsync(endpoint, new FormUrlEncodedContent(new Dictionary<string, string>
                    { { "grant_type", "password" }, { "username", this.username }, { "password", this.password } })).Result;
                var result = login.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<User>(result);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<Document> GetDoc(User user)
        {
            string endpoint = this.baseUrl + "/api/document/7854/display";
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, endpoint);
            string token = user.access_token;
            HttpClient client = new HttpClient();

            client = TokenAs(client, user);
            HttpResponseMessage response = await client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead);
            var result = response.Content.ReadAsStringAsync().Result;
            client.CancelPendingRequests();
            return JsonConvert.DeserializeObject<Document>(result); 

        }

        public async Task<List<Document>> GetBox(User user)
        {         
            string endpoint = this.baseUrl + "/api/task-manager/workflow";
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, endpoint);

            HttpClient client = new HttpClient();
            client = TokenAs(client, user);
            HttpResponseMessage response = await client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

            var result = response.Content.ReadAsStringAsync().Result;
            var i = JsonConvert.DeserializeObject<List<Document>>(result)[0].Id;

            string endpoint2 = this.baseUrl + "/api/search/basket/" + i;         
            var response2 = await client.PostAsync(endpoint2, null);
            var contents = await response2.Content.ReadAsStringAsync();           
            var doc = JsonConvert.DeserializeObject<List<Document>>(contents);

            return doc;
        }
    }
}

