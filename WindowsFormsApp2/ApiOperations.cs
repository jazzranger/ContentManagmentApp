﻿using ContentManagmentApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace ContentManagmentApp
{
    class ApiOperations
    {
        private string baseUrl;
        //string username;
        //string password;
        //HttpClient client;
        public ApiOperations()
        {
            this.baseUrl = "http://157.26.82.44:2240";
            //this.username = "2";
            //this.password = "admin.groupe666";
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

        public User Auth(string username, string password)
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
                    { { "grant_type", "password" }, { "username", username }, { "password", password } })).Result;
                var result = login.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<User>(result);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<Document> GetDoc(User user, int docId)
        {
            string endpoint = this.baseUrl + "/api/document/" + docId.ToString() + "/display";
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, endpoint);
            string token = user.access_token;
            HttpClient client = new HttpClient();

            client = TokenAs(client, user);
            HttpResponseMessage response = await client.SendAsync(message, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
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
            var basketId = JsonConvert.DeserializeObject<List<Document>>(result)[0].Id;

            endpoint = this.baseUrl + "/api/search/basket/" + basketId;         
            response = await client.PostAsync(endpoint, null).ConfigureAwait(false);
            var contents = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<Document>>(contents);
        }

        public List<Document> GetList()
        {
            var l = "[{\"ObjectID\":8108,\"ContentTypeID\":3534,\"FlowID\":80,\"ObjectLock\":null,\"IsDigitallySigned\":false,\"IsDistributed\":false,\"IsPendingConfirmation\":false,\"IsLastVersion\":true,\"Distributor\":null,\"TotalComments\":0,\"TotalAttachments\":0,\"TotalAlerts\":0,\"Permissions\":{\"DocumentEdit\":true,\"DocumentDelete\":false,\"DocumentDownload\":true,\"DocumentPrint\":true,\"CommentCreate\":true,\"CommentRead\":true,\"CommentUpdate\":false,\"CommentDelete\":false,\"AuditRead\":true},\"Plugins\":[],\"Fields\":[{\"DefFieldID\":0,\"Title\":\"FEtat\",\"Type\":3,\"Code\":\"FEtat\",\"Value\":\"VSignataireDeux\",\"Observations\":null,\"IsRequired\":true,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}},{\"DefFieldID\":0,\"Title\":\"Somme\",\"Type\":2,\"Code\":\"FSomme\",\"Value\":\"200‘000.00\",\"Observations\":null,\"IsRequired\":true,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}},{\"DefFieldID\":0,\"Title\":\"Directeur\",\"Type\":4,\"Code\":\"FDirecteur\",\"Value\":\"Hugo Bey\",\"Observations\":null,\"IsRequired\":true,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}},{\"DefFieldID\":0,\"Title\":\"Responsable \",\"Type\":4,\"Code\":\"FResponsable\",\"Value\":\"Masha Responsable\",\"Observations\":null,\"IsRequired\":true,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}},{\"DefFieldID\":0,\"Title\":\"Premier signataire\",\"Type\":4,\"Code\":\"FSignataire1\",\"Value\":\"Lucas Signature2\",\"Observations\":null,\"IsRequired\":true,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}},{\"DefFieldID\":0,\"Title\":\"Seconde signataire\",\"Type\":4,\"Code\":\"FSignataire2\",\"Value\":\"Olivier Signateur1\",\"Observations\":null,\"IsRequired\":true,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}},{\"DefFieldID\":0,\"Title\":\"Sous-validateur\",\"Type\":4,\"Code\":\"FSousValidateur\",\"Value\":\"\",\"Observations\":null,\"IsRequired\":false,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}}],\"ContentType\":\"Facteur v1.15\",\"Version\":\"v1.0\",\"Author\":\"admin2 a\",\"CreationDate\":\"21.12.2019 16:05\",\"IsDeleted\":false,\"IsLastItem\":false,\"Extension\":\".PNG\"},{\"ObjectID\":8110,\"ContentTypeID\":3534,\"FlowID\":80,\"ObjectLock\":null,\"IsDigitallySigned\":false,\"IsDistributed\":false,\"IsPendingConfirmation\":false,\"IsLastVersion\":true,\"Distributor\":null,\"TotalComments\":0,\"TotalAttachments\":0,\"TotalAlerts\":0,\"Permissions\":{\"DocumentEdit\":true,\"DocumentDelete\":false,\"DocumentDownload\":true,\"DocumentPrint\":true,\"CommentCreate\":true,\"CommentRead\":true,\"CommentUpdate\":false,\"CommentDelete\":false,\"AuditRead\":true},\"Plugins\":[],\"Fields\":[{\"DefFieldID\":0,\"Title\":\"FEtat\",\"Type\":3,\"Code\":\"FEtat\",\"Value\":\"VSignataireDeux\",\"Observations\":null,\"IsRequired\":true,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}},{\"DefFieldID\":0,\"Title\":\"Somme\",\"Type\":2,\"Code\":\"FSomme\",\"Value\":\"150‘000.00\",\"Observations\":null,\"IsRequired\":true,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}},{\"DefFieldID\":0,\"Title\":\"Directeur\",\"Type\":4,\"Code\":\"FDirecteur\",\"Value\":\"Hugo Bey\",\"Observations\":null,\"IsRequired\":true,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}},{\"DefFieldID\":0,\"Title\":\"Responsable \",\"Type\":4,\"Code\":\"FResponsable\",\"Value\":\"Masha Responsable\",\"Observations\":null,\"IsRequired\":true,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}},{\"DefFieldID\":0,\"Title\":\"Premier signataire\",\"Type\":4,\"Code\":\"FSignataire1\",\"Value\":\"Lucas Signature2\",\"Observations\":null,\"IsRequired\":true,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}},{\"DefFieldID\":0,\"Title\":\"Seconde signataire\",\"Type\":4,\"Code\":\"FSignataire2\",\"Value\":\"Olivier Signateur1\",\"Observations\":null,\"IsRequired\":true,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}},{\"DefFieldID\":0,\"Title\":\"Sous-validateur\",\"Type\":4,\"Code\":\"FSousValidateur\",\"Value\":\"\",\"Observations\":null,\"IsRequired\":false,\"IsVisible\":true,\"IsReadOnly\":false,\"ListElements\":null,\"RelatedFieldsCodes\":null,\"Validations\":{\"Mask\":null,\"MinVal\":null,\"MaxVal\":null,\"Scale\":null,\"MaxLength\":null}}],\"ContentType\":\"Facteur v1.15\",\"Version\":\"v1.1\",\"Author\":\"admin2 a\",\"CreationDate\":\"21.12.2019 16:46\",\"IsDeleted\":false,\"IsLastItem\":false,\"Extension\":\".png\"}]";
            var doc = JsonConvert.DeserializeObject<List<Document>>(l);
            return doc;
        }

        public async Task<bool> Validate()
        {
            var user = Globals.LoggedInUser;
            HttpClient client = new HttpClient();
            client = TokenAs(client, user);

            var endpoint = this.baseUrl + "/api/flow/validate/" + Globals.selectedDoc.ObjectID;
            var response = await client.PostAsync(endpoint, null).ConfigureAwait(false);
            var statuscode = response.IsSuccessStatusCode;
            return statuscode;
        }

        public async Task<bool> Refuse()
        {
            var user = Globals.LoggedInUser;
            HttpClient client = new HttpClient();
            client = TokenAs(client, user);

            var endpoint = this.baseUrl + "/api/flow/refuse/" + Globals.selectedDoc.ObjectID;
            var response = await client.PostAsync(endpoint, null).ConfigureAwait(false);
            var statuscode = response.IsSuccessStatusCode;
            return statuscode;
        }
    }
}

