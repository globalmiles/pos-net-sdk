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
    public partial class PayWithMilesController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static PayWithMilesController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static PayWithMilesController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new PayWithMilesController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// In order to cancel payment with miles you can use this endpoint. It allows to cancel payment only related GSM and terminal ID numbers.
        /// You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="milesPaymentProvisionId">Required parameter: Provision ID.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CancelMilePaymentResponse response from the API call</return>
        public Models.CancelMilePaymentResponse DeleteCancelMilePayment(int milesPaymentProvisionId, Models.CancelMilePaymentRequest body)
        {
            Task<Models.CancelMilePaymentResponse> t = DeleteCancelMilePaymentAsync(milesPaymentProvisionId, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// In order to cancel payment with miles you can use this endpoint. It allows to cancel payment only related GSM and terminal ID numbers.
        /// You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="milesPaymentProvisionId">Required parameter: Provision ID.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CancelMilePaymentResponse response from the API call</return>
        public async Task<Models.CancelMilePaymentResponse> DeleteCancelMilePaymentAsync(int milesPaymentProvisionId, Models.CancelMilePaymentRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/pos/payments/{miles_payment_provision_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "miles_payment_provision_id", milesPaymentProvisionId }
            });


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
            HttpRequest _request = ClientInstance.DeleteBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.CancelMilePaymentResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// In order to finalize payment with miles use this endpoint. Use the OTP number which is send to user GSM on the Request body.
        /// You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="milesPaymentProvisionId">Required parameter: Provision ID.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CompleteMilePaymentResponse response from the API call</return>
        public Models.CompleteMilePaymentResponse UpdateCompleteMilePayment(int milesPaymentProvisionId, Models.CompleteMilePaymentRequest body)
        {
            Task<Models.CompleteMilePaymentResponse> t = UpdateCompleteMilePaymentAsync(milesPaymentProvisionId, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// In order to finalize payment with miles use this endpoint. Use the OTP number which is send to user GSM on the Request body.
        /// You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="milesPaymentProvisionId">Required parameter: Provision ID.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CompleteMilePaymentResponse response from the API call</return>
        public async Task<Models.CompleteMilePaymentResponse> UpdateCompleteMilePaymentAsync(int milesPaymentProvisionId, Models.CompleteMilePaymentRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/pos/payments/{miles_payment_provision_id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "miles_payment_provision_id", milesPaymentProvisionId }
            });


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
            HttpRequest _request = ClientInstance.PutBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.CompleteMilePaymentResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// After getting customer info's and RecognitionID to start Payment with Miles Use this endpoint.
        /// After calling this endpoint successfully OTP code send to customer GSM number. This OTP must be used with Complete endpoint in order to complete payment.
        /// You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.StartMilePaymentResponse response from the API call</return>
        public Models.StartMilePaymentResponse CreateStartMilePayment(Models.StartMilePaymentRequest body)
        {
            Task<Models.StartMilePaymentResponse> t = CreateStartMilePaymentAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// After getting customer info's and RecognitionID to start Payment with Miles Use this endpoint.
        /// After calling this endpoint successfully OTP code send to customer GSM number. This OTP must be used with Complete endpoint in order to complete payment.
        /// You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.StartMilePaymentResponse response from the API call</return>
        public async Task<Models.StartMilePaymentResponse> CreateStartMilePaymentAsync(Models.StartMilePaymentRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/pos/payments");


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
                return APIHelper.JsonDeserialize<Models.StartMilePaymentResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Before cancelling the payment with miles this endpoint is used to list the related sale.
        /// You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="readCode">Required parameter: Customer Identification Method; GSM, FFP ID, CODE or EMAIL.</param>
        /// <param name="readCodeType">Required parameter: 1: GSM, 2: FFP ID, 3: CODE, 4: EMAIL</param>
        /// <param name="terminalId">Required parameter: Terminal ID.</param>
        /// <return>Returns the Models.GetMileProvisionsResponse response from the API call</return>
        public Models.GetMileProvisionsResponse GetMileProvisions(string readCode, string readCodeType, string terminalId)
        {
            Task<Models.GetMileProvisionsResponse> t = GetMileProvisionsAsync(readCode, readCodeType, terminalId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Before cancelling the payment with miles this endpoint is used to list the related sale.
        /// You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
        /// and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
        /// </summary>
        /// <param name="readCode">Required parameter: Customer Identification Method; GSM, FFP ID, CODE or EMAIL.</param>
        /// <param name="readCodeType">Required parameter: 1: GSM, 2: FFP ID, 3: CODE, 4: EMAIL</param>
        /// <param name="terminalId">Required parameter: Terminal ID.</param>
        /// <return>Returns the Models.GetMileProvisionsResponse response from the API call</return>
        public async Task<Models.GetMileProvisionsResponse> GetMileProvisionsAsync(string readCode, string readCodeType, string terminalId)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/pos/payments");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "read_code", readCode },
                { "read_code_type", readCodeType },
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
                return APIHelper.JsonDeserialize<Models.GetMileProvisionsResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 