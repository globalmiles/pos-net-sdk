/*
 * GlobalMilesPos.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using GlobalMiles.Pos;
using GlobalMiles.Pos.Utilities;
using GlobalMiles.Pos.Http.Request;
using GlobalMiles.Pos.Http.Response;
using GlobalMiles.Pos.Http.Client;
using GlobalMiles.Pos.Exceptions;

namespace GlobalMiles.Pos.Controllers
{
    public partial class CommonController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static CommonController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static CommonController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new CommonController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// This endpoint will help you to get terminal settings in order to use internal operations.
        /// You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="terminalId">Required parameter: Terminal ID.</param>
        /// <return>Returns the Models.GetTerminalInfoResponse response from the API call</return>
        public Models.GetTerminalInfoResponse GetTerminalInfo(string terminalId)
        {
            Task<Models.GetTerminalInfoResponse> t = GetTerminalInfoAsync(terminalId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint will help you to get terminal settings in order to use internal operations.
        /// You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="terminalId">Required parameter: Terminal ID.</param>
        /// <return>Returns the Models.GetTerminalInfoResponse response from the API call</return>
        public async Task<Models.GetTerminalInfoResponse> GetTerminalInfoAsync(string terminalId)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/pos/terminal_info");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "terminal_id", terminalId }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthToken.AccessToken));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetTerminalInfoResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This endpoint will help you to get customer's miles amount as a currency and unique identifier value. Unique identifier value must be used by Transaction Result endpint in order to complete shopping.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="readCode">Required parameter: Customer Identification Method; GSM, FFP ID, CODE or EMAIL</param>
        /// <param name="readCodeType">Required parameter: 1: GSM, 2: FFP ID, 3: CODE, 4: EMAIL</param>
        /// <param name="totalAmount">Required parameter: Total receipt amount.</param>
        /// <param name="totalVatAmount">Required parameter: Total tax value.</param>
        /// <param name="currency">Required parameter: ISO-4217 3-letter currency code.</param>
        /// <param name="partnerId">Required parameter: Partner ID.</param>
        /// <param name="branchId">Required parameter: Branch ID.</param>
        /// <param name="terminalId">Required parameter: Terminal ID.</param>
        /// <return>Returns the Models.GetCustomerInfoResponse response from the API call</return>
        public Models.GetCustomerInfoResponse GetCustomerInfo(
                string readCode,
                string readCodeType,
                double totalAmount,
                double totalVatAmount,
                string currency,
                int partnerId,
                int branchId,
                string terminalId)
        {
            Task<Models.GetCustomerInfoResponse> t = GetCustomerInfoAsync(readCode, readCodeType, totalAmount, totalVatAmount, currency, partnerId, branchId, terminalId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint will help you to get customer's miles amount as a currency and unique identifier value. Unique identifier value must be used by Transaction Result endpint in order to complete shopping.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="readCode">Required parameter: Customer Identification Method; GSM, FFP ID, CODE or EMAIL</param>
        /// <param name="readCodeType">Required parameter: 1: GSM, 2: FFP ID, 3: CODE, 4: EMAIL</param>
        /// <param name="totalAmount">Required parameter: Total receipt amount.</param>
        /// <param name="totalVatAmount">Required parameter: Total tax value.</param>
        /// <param name="currency">Required parameter: ISO-4217 3-letter currency code.</param>
        /// <param name="partnerId">Required parameter: Partner ID.</param>
        /// <param name="branchId">Required parameter: Branch ID.</param>
        /// <param name="terminalId">Required parameter: Terminal ID.</param>
        /// <return>Returns the Models.GetCustomerInfoResponse response from the API call</return>
        public async Task<Models.GetCustomerInfoResponse> GetCustomerInfoAsync(
                string readCode,
                string readCodeType,
                double totalAmount,
                double totalVatAmount,
                string currency,
                int partnerId,
                int branchId,
                string terminalId)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/pos/customer_info");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "read_code", readCode },
                { "read_code_type", readCodeType },
                { "total_amount", totalAmount },
                { "total_vat_amount", totalVatAmount },
                { "currency", currency },
                { "partner_id", partnerId },
                { "branch_id", branchId },
                { "terminal_id", terminalId }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthToken.AccessToken));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetCustomerInfoResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// This endpoint will help you to upload receipt pictures which is related with a recognition ID and a transaction result.
        /// You can try this endoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.ReceiptPictureResponse response from the API call</return>
        public Models.ReceiptPictureResponse UploadReceiptPictures(Models.ReceiptPictureRequest body)
        {
            Task<Models.ReceiptPictureResponse> t = UploadReceiptPicturesAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This endpoint will help you to upload receipt pictures which is related with a recognition ID and a transaction result.
        /// You can try this endoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.ReceiptPictureResponse response from the API call</return>
        public async Task<Models.ReceiptPictureResponse> UploadReceiptPicturesAsync(Models.ReceiptPictureRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/pos/receipt_pictures");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthToken.AccessToken));

            //append body params
            var _body = APIHelper.JsonSerialize(body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ReceiptPictureResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 