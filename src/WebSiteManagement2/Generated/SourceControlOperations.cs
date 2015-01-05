// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.WebSites;
using Microsoft.Azure.Management.WebSites.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.WebSites
{
    /// <summary>
    /// User source controls operations
    /// </summary>
    internal partial class SourceControlOperations : IServiceOperations<WebSiteManagementClient>, ISourceControlOperations
    {
        /// <summary>
        /// Initializes a new instance of the SourceControlOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal SourceControlOperations(WebSiteManagementClient client)
        {
            this._client = client;
        }
        
        private WebSiteManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.WebSites.WebSiteManagementClient.
        /// </summary>
        public WebSiteManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Get user source control
        /// </summary>
        /// <param name='name'>
        /// Required. The name of the source control (GitHub, Bitbucket,
        /// CodePlex or Dropbox)
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The get source control operation response.
        /// </returns>
        public async Task<SourceControlGetResponse> GetAsync(string name, CancellationToken cancellationToken)
        {
            // Validate
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("name", name);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/providers/Microsoft.Web/SourceControls/" + Uri.EscapeDataString(name) + "?";
            url = url + "api-version=2014-06-01";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    SourceControlGetResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new SourceControlGetResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            SourceControl sourceControlInstance = new SourceControl();
                            result.SourceControl = sourceControlInstance;
                            
                            JToken propertiesValue = responseDoc["properties"];
                            if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                            {
                                SourceControlProperties propertiesInstance = new SourceControlProperties();
                                sourceControlInstance.Properties = propertiesInstance;
                                
                                JToken tokenValue = propertiesValue["token"];
                                if (tokenValue != null && tokenValue.Type != JTokenType.Null)
                                {
                                    string tokenInstance = ((string)tokenValue);
                                    propertiesInstance.Token = tokenInstance;
                                }
                                
                                JToken tokenSecretValue = propertiesValue["tokenSecret"];
                                if (tokenSecretValue != null && tokenSecretValue.Type != JTokenType.Null)
                                {
                                    string tokenSecretInstance = ((string)tokenSecretValue);
                                    propertiesInstance.TokenSecret = tokenSecretInstance;
                                }
                            }
                            
                            JToken idValue = responseDoc["id"];
                            if (idValue != null && idValue.Type != JTokenType.Null)
                            {
                                string idInstance = ((string)idValue);
                                sourceControlInstance.Id = idInstance;
                            }
                            
                            JToken nameValue = responseDoc["name"];
                            if (nameValue != null && nameValue.Type != JTokenType.Null)
                            {
                                string nameInstance = ((string)nameValue);
                                sourceControlInstance.Name = nameInstance;
                            }
                            
                            JToken locationValue = responseDoc["location"];
                            if (locationValue != null && locationValue.Type != JTokenType.Null)
                            {
                                string locationInstance = ((string)locationValue);
                                sourceControlInstance.Location = locationInstance;
                            }
                            
                            JToken tagsSequenceElement = ((JToken)responseDoc["tags"]);
                            if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                            {
                                foreach (JProperty property in tagsSequenceElement)
                                {
                                    string tagsKey = ((string)property.Name);
                                    string tagsValue = ((string)property.Value);
                                    sourceControlInstance.Tags.Add(tagsKey, tagsValue);
                                }
                            }
                            
                            JToken typeValue = responseDoc["type"];
                            if (typeValue != null && typeValue.Type != JTokenType.Null)
                            {
                                string typeInstance = ((string)typeValue);
                                sourceControlInstance.Type = typeInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// List source controls for user.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The list source controls operation response.
        /// </returns>
        public async Task<SourceControlListResponse> ListAsync(CancellationToken cancellationToken)
        {
            // Validate
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/providers/Microsoft.Web/SourceControls?";
            url = url + "api-version=2014-06-01";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    SourceControlListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new SourceControlListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    SourceControl propertiesInstance = new SourceControl();
                                    result.SourceControls.Add(propertiesInstance);
                                    
                                    JToken propertiesValue = valueValue["properties"];
                                    if (propertiesValue != null && propertiesValue.Type != JTokenType.Null)
                                    {
                                        SourceControlProperties propertiesInstance2 = new SourceControlProperties();
                                        propertiesInstance.Properties = propertiesInstance2;
                                        
                                        JToken tokenValue = propertiesValue["token"];
                                        if (tokenValue != null && tokenValue.Type != JTokenType.Null)
                                        {
                                            string tokenInstance = ((string)tokenValue);
                                            propertiesInstance2.Token = tokenInstance;
                                        }
                                        
                                        JToken tokenSecretValue = propertiesValue["tokenSecret"];
                                        if (tokenSecretValue != null && tokenSecretValue.Type != JTokenType.Null)
                                        {
                                            string tokenSecretInstance = ((string)tokenSecretValue);
                                            propertiesInstance2.TokenSecret = tokenSecretInstance;
                                        }
                                    }
                                    
                                    JToken idValue = valueValue["id"];
                                    if (idValue != null && idValue.Type != JTokenType.Null)
                                    {
                                        string idInstance = ((string)idValue);
                                        propertiesInstance.Id = idInstance;
                                    }
                                    
                                    JToken nameValue = valueValue["name"];
                                    if (nameValue != null && nameValue.Type != JTokenType.Null)
                                    {
                                        string nameInstance = ((string)nameValue);
                                        propertiesInstance.Name = nameInstance;
                                    }
                                    
                                    JToken locationValue = valueValue["location"];
                                    if (locationValue != null && locationValue.Type != JTokenType.Null)
                                    {
                                        string locationInstance = ((string)locationValue);
                                        propertiesInstance.Location = locationInstance;
                                    }
                                    
                                    JToken tagsSequenceElement = ((JToken)valueValue["tags"]);
                                    if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                                    {
                                        foreach (JProperty property in tagsSequenceElement)
                                        {
                                            string tagsKey = ((string)property.Name);
                                            string tagsValue = ((string)property.Value);
                                            propertiesInstance.Tags.Add(tagsKey, tagsValue);
                                        }
                                    }
                                    
                                    JToken typeValue = valueValue["type"];
                                    if (typeValue != null && typeValue.Type != JTokenType.Null)
                                    {
                                        string typeInstance = ((string)typeValue);
                                        propertiesInstance.Type = typeInstance;
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Update source control for user.
        /// </summary>
        /// <param name='name'>
        /// Required. The name of the source control (can be: GitHub,
        /// Bitbucket, CodePlex, Dropbox)
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Source Control
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The update source control operation response.
        /// </returns>
        public async Task<SourceControlUpdateResponse> UpdateAsync(string name, SourceControlUpdateParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.Properties == null)
            {
                throw new ArgumentNullException("parameters.Properties");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("name", name);
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "UpdateAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/providers/Microsoft.Web/SourceControls/" + Uri.EscapeDataString(name) + "?";
            url = url + "api-version=2014-06-01";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Put;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                JToken requestDoc = null;
                
                JObject sourceControlUpdateParametersValue = new JObject();
                requestDoc = sourceControlUpdateParametersValue;
                
                JObject propertiesValue = new JObject();
                sourceControlUpdateParametersValue["properties"] = propertiesValue;
                
                if (parameters.Properties.Token != null)
                {
                    propertiesValue["token"] = parameters.Properties.Token;
                }
                
                if (parameters.Properties.TokenSecret != null)
                {
                    propertiesValue["tokenSecret"] = parameters.Properties.TokenSecret;
                }
                
                requestContent = requestDoc.ToString(Newtonsoft.Json.Formatting.Indented);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    SourceControlUpdateResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new SourceControlUpdateResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        JToken sourceControlValue = responseDoc["SourceControl"];
                        if (sourceControlValue != null && sourceControlValue.Type != JTokenType.Null)
                        {
                            SourceControlUpdateResponse sourceControlInstance = new SourceControlUpdateResponse();
                            
                            SourceControl sourceControlInstance2 = new SourceControl();
                            result.SourceControl = sourceControlInstance2;
                            
                            JToken propertiesValue2 = sourceControlValue["properties"];
                            if (propertiesValue2 != null && propertiesValue2.Type != JTokenType.Null)
                            {
                                SourceControlProperties propertiesInstance = new SourceControlProperties();
                                sourceControlInstance2.Properties = propertiesInstance;
                                
                                JToken tokenValue = propertiesValue2["token"];
                                if (tokenValue != null && tokenValue.Type != JTokenType.Null)
                                {
                                    string tokenInstance = ((string)tokenValue);
                                    propertiesInstance.Token = tokenInstance;
                                }
                                
                                JToken tokenSecretValue = propertiesValue2["tokenSecret"];
                                if (tokenSecretValue != null && tokenSecretValue.Type != JTokenType.Null)
                                {
                                    string tokenSecretInstance = ((string)tokenSecretValue);
                                    propertiesInstance.TokenSecret = tokenSecretInstance;
                                }
                            }
                            
                            JToken idValue = sourceControlValue["id"];
                            if (idValue != null && idValue.Type != JTokenType.Null)
                            {
                                string idInstance = ((string)idValue);
                                sourceControlInstance2.Id = idInstance;
                            }
                            
                            JToken nameValue = sourceControlValue["name"];
                            if (nameValue != null && nameValue.Type != JTokenType.Null)
                            {
                                string nameInstance = ((string)nameValue);
                                sourceControlInstance2.Name = nameInstance;
                            }
                            
                            JToken locationValue = sourceControlValue["location"];
                            if (locationValue != null && locationValue.Type != JTokenType.Null)
                            {
                                string locationInstance = ((string)locationValue);
                                sourceControlInstance2.Location = locationInstance;
                            }
                            
                            JToken tagsSequenceElement = ((JToken)sourceControlValue["tags"]);
                            if (tagsSequenceElement != null && tagsSequenceElement.Type != JTokenType.Null)
                            {
                                foreach (JProperty property in tagsSequenceElement)
                                {
                                    string tagsKey = ((string)property.Name);
                                    string tagsValue = ((string)property.Value);
                                    sourceControlInstance2.Tags.Add(tagsKey, tagsValue);
                                }
                            }
                            
                            JToken typeValue = sourceControlValue["type"];
                            if (typeValue != null && typeValue.Type != JTokenType.Null)
                            {
                                string typeInstance = ((string)typeValue);
                                sourceControlInstance2.Type = typeInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
