/*
 * GlobalMilesPos.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io )
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
    public partial class BonusPaymentsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static BonusPaymentsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static BonusPaymentsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new BonusPaymentsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// After getting customer info's and RecognitionID to start Payment with Miles Use this API.
        /// After calling this API successfully OTP code send to cutomer GSM number. This OTP must be used with Complete API in order to complete sale.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.StartBonusPaymentResponse response from the API call</return>
        public Models.StartBonusPaymentResponse CreateStartBonusPayment(
                string accept,
                string contentType,
                string authorization,
                Models.StartBonusPaymentRequest body)
        {
            Task<Models.StartBonusPaymentResponse> t = CreateStartBonusPaymentAsync(accept, contentType, authorization, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// After getting customer info's and RecognitionID to start Payment with Miles Use this API.
        /// After calling this API successfully OTP code send to cutomer GSM number. This OTP must be used with Complete API in order to complete sale.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.StartBonusPaymentResponse response from the API call</return>
        public async Task<Models.StartBonusPaymentResponse> CreateStartBonusPaymentAsync(
                string accept,
                string contentType,
                string authorization,
                Models.StartBonusPaymentRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/pos/StartBonusPayment");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "Accept", accept },
                { "Content-Type", contentType },
                { "Authorization", authorization }
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
                return APIHelper.JsonDeserialize<Models.StartBonusPaymentResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// In order to finalise payment with Miles use this API.Use the OTP number  which is send to user GSM on the Request body.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CompleteBonusPaymentResponse response from the API call</return>
        public Models.CompleteBonusPaymentResponse CreateCompleteBonusPayment(
                string accept,
                string contentType,
                string authorization,
                Models.CompleteBonusPaymentRequest body)
        {
            Task<Models.CompleteBonusPaymentResponse> t = CreateCompleteBonusPaymentAsync(accept, contentType, authorization, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// In order to finalise payment with Miles use this API.Use the OTP number  which is send to user GSM on the Request body.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CompleteBonusPaymentResponse response from the API call</return>
        public async Task<Models.CompleteBonusPaymentResponse> CreateCompleteBonusPaymentAsync(
                string accept,
                string contentType,
                string authorization,
                Models.CompleteBonusPaymentRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/pos/CompleteBonusPayment");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "Accept", accept },
                { "Content-Type", contentType },
                { "Authorization", authorization }
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
                return APIHelper.JsonDeserialize<Models.CompleteBonusPaymentResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// In order to cancel payment with miles you can use this API. It allows to cancel payment only related GSM and terminal ID numbers.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CancelBonusPaymentResponse response from the API call</return>
        public Models.CancelBonusPaymentResponse CreateCancelBonusPayment(
                string accept,
                string contentType,
                string authorization,
                Models.CancelBonusPaymentRequest body)
        {
            Task<Models.CancelBonusPaymentResponse> t = CreateCancelBonusPaymentAsync(accept, contentType, authorization, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// In order to cancel payment with miles you can use this API. It allows to cancel payment only related GSM and terminal ID numbers.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CancelBonusPaymentResponse response from the API call</return>
        public async Task<Models.CancelBonusPaymentResponse> CreateCancelBonusPaymentAsync(
                string accept,
                string contentType,
                string authorization,
                Models.CancelBonusPaymentRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/pos/CancelBonusPayment");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "Accept", accept },
                { "Content-Type", contentType },
                { "Authorization", authorization }
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
                return APIHelper.JsonDeserialize<Models.CancelBonusPaymentResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Before cancelling the payment with Miles this API is used to list the related sale.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.GetBonusProvisionsResponse response from the API call</return>
        public Models.GetBonusProvisionsResponse CreateGetBonusProvisions(
                string accept,
                string contentType,
                string authorization,
                Models.GetBonusProvisionsRequest body)
        {
            Task<Models.GetBonusProvisionsResponse> t = CreateGetBonusProvisionsAsync(accept, contentType, authorization, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Before cancelling the payment with Miles this API is used to list the related sale.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.GetBonusProvisionsResponse response from the API call</return>
        public async Task<Models.GetBonusProvisionsResponse> CreateGetBonusProvisionsAsync(
                string accept,
                string contentType,
                string authorization,
                Models.GetBonusProvisionsRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/pos/GetBonusProvisions");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "Accept", accept },
                { "Content-Type", contentType },
                { "Authorization", authorization }
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
                return APIHelper.JsonDeserialize<Models.GetBonusProvisionsResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 