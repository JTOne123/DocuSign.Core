/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using DocuSign.Core.Client;
using DocuSign.Core.Model;

namespace DocuSign.Core.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITemplateDocumentTabsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns tabs on the document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <param name="pageNumbers"> (optional)</param>
        /// <returns>TemplateDocumentTabs</returns>
        TemplateDocumentTabs TabsGetTemplateDocumentTabs (string accountId, string documentId, string templateId, string pageNumbers = null);

        /// <summary>
        /// Returns tabs on the document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <param name="pageNumbers"> (optional)</param>
        /// <returns>ApiResponse of TemplateDocumentTabs</returns>
        ApiResponse<TemplateDocumentTabs> TabsGetTemplateDocumentTabsWithHttpInfo (string accountId, string documentId, string templateId, string pageNumbers = null);
        /// <summary>
        /// Returns tabs on the specified page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="pageNumber">The page number being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <returns>TemplateDocumentTabs</returns>
        TemplateDocumentTabs TabsGetTemplatePageTabs (string accountId, string documentId, string pageNumber, string templateId);

        /// <summary>
        /// Returns tabs on the specified page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="pageNumber">The page number being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <returns>ApiResponse of TemplateDocumentTabs</returns>
        ApiResponse<TemplateDocumentTabs> TabsGetTemplatePageTabsWithHttpInfo (string accountId, string documentId, string pageNumber, string templateId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns tabs on the document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <param name="pageNumbers"> (optional)</param>
        /// <returns>Task of TemplateDocumentTabs</returns>
        System.Threading.Tasks.Task<TemplateDocumentTabs> TabsGetTemplateDocumentTabsAsync (string accountId, string documentId, string templateId, string pageNumbers = null);

        /// <summary>
        /// Returns tabs on the document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <param name="pageNumbers"> (optional)</param>
        /// <returns>Task of ApiResponse (TemplateDocumentTabs)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateDocumentTabs>> TabsGetTemplateDocumentTabsAsyncWithHttpInfo (string accountId, string documentId, string templateId, string pageNumbers = null);
        /// <summary>
        /// Returns tabs on the specified page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="pageNumber">The page number being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <returns>Task of TemplateDocumentTabs</returns>
        System.Threading.Tasks.Task<TemplateDocumentTabs> TabsGetTemplatePageTabsAsync (string accountId, string documentId, string pageNumber, string templateId);

        /// <summary>
        /// Returns tabs on the specified page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="pageNumber">The page number being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <returns>Task of ApiResponse (TemplateDocumentTabs)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateDocumentTabs>> TabsGetTemplatePageTabsAsyncWithHttpInfo (string accountId, string documentId, string pageNumber, string templateId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TemplateDocumentTabsApi : ITemplateDocumentTabsApi
    {
        private DocuSign.Core.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateDocumentTabsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TemplateDocumentTabsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = DocuSign.Core.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateDocumentTabsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TemplateDocumentTabsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = DocuSign.Core.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DocuSign.Core.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Returns tabs on the document. 
        /// </summary>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <param name="pageNumbers"> (optional)</param>
        /// <returns>TemplateDocumentTabs</returns>
        public TemplateDocumentTabs TabsGetTemplateDocumentTabs (string accountId, string documentId, string templateId, string pageNumbers = null)
        {
             ApiResponse<TemplateDocumentTabs> localVarResponse = TabsGetTemplateDocumentTabsWithHttpInfo(accountId, documentId, templateId, pageNumbers);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns tabs on the document. 
        /// </summary>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <param name="pageNumbers"> (optional)</param>
        /// <returns>ApiResponse of TemplateDocumentTabs</returns>
        public ApiResponse< TemplateDocumentTabs > TabsGetTemplateDocumentTabsWithHttpInfo (string accountId, string documentId, string templateId, string pageNumbers = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling TemplateDocumentTabsApi->TabsGetTemplateDocumentTabs");
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling TemplateDocumentTabsApi->TabsGetTemplateDocumentTabs");
            // verify the required parameter 'templateId' is set
            if (templateId == null)
                throw new ApiException(400, "Missing required parameter 'templateId' when calling TemplateDocumentTabsApi->TabsGetTemplateDocumentTabs");

            var localVarPath = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/tabs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (templateId != null) localVarPathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (pageNumbers != null) localVarQueryParams.Add("page_numbers", Configuration.ApiClient.ParameterToString(pageNumbers)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TabsGetTemplateDocumentTabs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TemplateDocumentTabs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateDocumentTabs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateDocumentTabs)));
            
        }

        /// <summary>
        /// Returns tabs on the document. 
        /// </summary>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <param name="pageNumbers"> (optional)</param>
        /// <returns>Task of TemplateDocumentTabs</returns>
        public async System.Threading.Tasks.Task<TemplateDocumentTabs> TabsGetTemplateDocumentTabsAsync (string accountId, string documentId, string templateId, string pageNumbers = null)
        {
             ApiResponse<TemplateDocumentTabs> localVarResponse = await TabsGetTemplateDocumentTabsAsyncWithHttpInfo(accountId, documentId, templateId, pageNumbers);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns tabs on the document. 
        /// </summary>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <param name="pageNumbers"> (optional)</param>
        /// <returns>Task of ApiResponse (TemplateDocumentTabs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateDocumentTabs>> TabsGetTemplateDocumentTabsAsyncWithHttpInfo (string accountId, string documentId, string templateId, string pageNumbers = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling TemplateDocumentTabsApi->TabsGetTemplateDocumentTabs");
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling TemplateDocumentTabsApi->TabsGetTemplateDocumentTabs");
            // verify the required parameter 'templateId' is set
            if (templateId == null)
                throw new ApiException(400, "Missing required parameter 'templateId' when calling TemplateDocumentTabsApi->TabsGetTemplateDocumentTabs");

            var localVarPath = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/tabs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (templateId != null) localVarPathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter
            if (pageNumbers != null) localVarQueryParams.Add("page_numbers", Configuration.ApiClient.ParameterToString(pageNumbers)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TabsGetTemplateDocumentTabs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TemplateDocumentTabs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateDocumentTabs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateDocumentTabs)));
            
        }

        /// <summary>
        /// Returns tabs on the specified page. 
        /// </summary>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="pageNumber">The page number being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <returns>TemplateDocumentTabs</returns>
        public TemplateDocumentTabs TabsGetTemplatePageTabs (string accountId, string documentId, string pageNumber, string templateId)
        {
             ApiResponse<TemplateDocumentTabs> localVarResponse = TabsGetTemplatePageTabsWithHttpInfo(accountId, documentId, pageNumber, templateId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns tabs on the specified page. 
        /// </summary>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="pageNumber">The page number being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <returns>ApiResponse of TemplateDocumentTabs</returns>
        public ApiResponse< TemplateDocumentTabs > TabsGetTemplatePageTabsWithHttpInfo (string accountId, string documentId, string pageNumber, string templateId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling TemplateDocumentTabsApi->TabsGetTemplatePageTabs");
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling TemplateDocumentTabsApi->TabsGetTemplatePageTabs");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling TemplateDocumentTabsApi->TabsGetTemplatePageTabs");
            // verify the required parameter 'templateId' is set
            if (templateId == null)
                throw new ApiException(400, "Missing required parameter 'templateId' when calling TemplateDocumentTabsApi->TabsGetTemplatePageTabs");

            var localVarPath = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages/{pageNumber}/tabs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // path parameter
            if (templateId != null) localVarPathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TabsGetTemplatePageTabs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TemplateDocumentTabs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateDocumentTabs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateDocumentTabs)));
            
        }

        /// <summary>
        /// Returns tabs on the specified page. 
        /// </summary>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="pageNumber">The page number being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <returns>Task of TemplateDocumentTabs</returns>
        public async System.Threading.Tasks.Task<TemplateDocumentTabs> TabsGetTemplatePageTabsAsync (string accountId, string documentId, string pageNumber, string templateId)
        {
             ApiResponse<TemplateDocumentTabs> localVarResponse = await TabsGetTemplatePageTabsAsyncWithHttpInfo(accountId, documentId, pageNumber, templateId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns tabs on the specified page. 
        /// </summary>
        /// <exception cref="DocuSign.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">The external account number (int) or account ID Guid.</param>
        /// <param name="documentId">The ID of the document being accessed.</param>
        /// <param name="pageNumber">The page number being accessed.</param>
        /// <param name="templateId">The ID of the template being accessed.</param>
        /// <returns>Task of ApiResponse (TemplateDocumentTabs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateDocumentTabs>> TabsGetTemplatePageTabsAsyncWithHttpInfo (string accountId, string documentId, string pageNumber, string templateId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling TemplateDocumentTabsApi->TabsGetTemplatePageTabs");
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling TemplateDocumentTabsApi->TabsGetTemplatePageTabs");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling TemplateDocumentTabsApi->TabsGetTemplatePageTabs");
            // verify the required parameter 'templateId' is set
            if (templateId == null)
                throw new ApiException(400, "Missing required parameter 'templateId' when calling TemplateDocumentTabsApi->TabsGetTemplatePageTabs");

            var localVarPath = "/v2/accounts/{accountId}/templates/{templateId}/documents/{documentId}/pages/{pageNumber}/tabs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // path parameter
            if (templateId != null) localVarPathParams.Add("templateId", Configuration.ApiClient.ParameterToString(templateId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TabsGetTemplatePageTabs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TemplateDocumentTabs>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateDocumentTabs) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateDocumentTabs)));
            
        }

    }
}
