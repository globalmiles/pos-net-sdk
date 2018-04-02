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
        /// This API will help you to retrieve customer's mil quantity and unique identifier value.Unique identifier value must be used by Transaction Result API in order to complete shopping.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.GetCustomerInfoResponse response from the API call</return>
        public Models.GetCustomerInfoResponse CreateGetCustomerInfo(
                string accept,
                string contentType,
                string authorization,
                Models.GetCustomerInfoRequest body)
        {
            Task<Models.GetCustomerInfoResponse> t = CreateGetCustomerInfoAsync(accept, contentType, authorization, body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This API will help you to retrieve customer's mil quantity and unique identifier value.Unique identifier value must be used by Transaction Result API in order to complete shopping.
        /// </summary>
        /// <param name="accept">Required parameter: It advertises which content type is able to understand.</param>
        /// <param name="contentType">Required parameter: It tells the client what the content type of the returned.</param>
        /// <param name="authorization">Required parameter: It includes OAuth2 token.</param>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.GetCustomerInfoResponse response from the API call</return>
        public async Task<Models.GetCustomerInfoResponse> CreateGetCustomerInfoAsync(
                string accept,
                string contentType,
                string authorization,
                Models.GetCustomerInfoRequest body)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/pos/GetCustomerInfo");


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
                return APIHelper.JsonDeserialize<Models.GetCustomerInfoResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 