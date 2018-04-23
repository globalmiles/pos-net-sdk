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
        /// After getting customer info's and RecognitionID to start Payment with Miles Use this API.
        /// After calling this API successfully OTP code send to customer GSM number. This OTP must be used with Complete API in order to complete sale.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
        /// and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b
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
        /// After getting customer info's and RecognitionID to start Payment with Miles Use this API.
        /// After calling this API successfully OTP code send to customer GSM number. This OTP must be used with Complete API in order to complete sale.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
        /// and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b
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
            _queryBuilder.Append("/v1/pos/StartBonusPayment");


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
        /// In order to finalize payment with Miles use this API. Use the OTP number  which is send to user GSM on the Request body.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
        /// and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CompleteMilePaymentResponse response from the API call</return>
        public Models.CompleteMilePaymentResponse CreateCompleteMilePayment(Models.CompleteMilePaymentRequest body)
        {
            Task<Models.CompleteMilePaymentResponse> t = CreateCompleteMilePaymentAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// In order to finalize payment with Miles use this API. Use the OTP number  which is send to user GSM on the Request body.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
        /// and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CompleteMilePaymentResponse response from the API call</return>
        public async Task<Models.CompleteMilePaymentResponse> CreateCompleteMilePaymentAsync(Models.CompleteMilePaymentRequest body)
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
                return APIHelper.JsonDeserialize<Models.CompleteMilePaymentResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// In order to cancel payment with miles you can use this API. It allows to cancel payment only related GSM and terminal ID numbers.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
        /// and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CancelMilePaymentResponse response from the API call</return>
        public Models.CancelMilePaymentResponse CreateCancelMilePayment(Models.CancelMilePaymentRequest body)
        {
            Task<Models.CancelMilePaymentResponse> t = CreateCancelMilePaymentAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// In order to cancel payment with miles you can use this API. It allows to cancel payment only related GSM and terminal ID numbers.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
        /// and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.CancelMilePaymentResponse response from the API call</return>
        public async Task<Models.CancelMilePaymentResponse> CreateCancelMilePaymentAsync(Models.CancelMilePaymentRequest body)
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
                return APIHelper.JsonDeserialize<Models.CancelMilePaymentResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Before cancelling the payment with Miles this API is used to list the related sale.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
        /// and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.GetBonusProvisionsResponse response from the API call</return>
        public Models.GetBonusProvisionsResponse CreateGetMileProvisions(Models.GetMileProvisionsRequest body)
        {
            Task<Models.GetBonusProvisionsResponse> t = CreateGetMileProvisionsAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Before cancelling the payment with Miles this API is used to list the related sale.
        /// You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
        /// and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.GetBonusProvisionsResponse response from the API call</return>
        public async Task<Models.GetBonusProvisionsResponse> CreateGetMileProvisionsAsync(Models.GetMileProvisionsRequest body)
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
                return APIHelper.JsonDeserialize<Models.GetBonusProvisionsResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 