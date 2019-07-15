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
    public partial class AuthenticationController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static AuthenticationController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static AuthenticationController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new AuthenticationController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// An access token will allow you to make requests for the system. We support only one type of token: client_credentials
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.OAuthResponse response from the API call</return>
        public Models.OAuthResponse CreateAuthentication(Models.OAuthRequest body)
        {
            Task<Models.OAuthResponse> t = CreateAuthenticationAsync(body);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// An access token will allow you to make requests for the system. We support only one type of token: client_credentials
        /// </summary>
        /// <param name="body">Required parameter: The body of the request.</param>
        /// <return>Returns the Models.OAuthResponse response from the API call</return>
        public async Task<Models.OAuthResponse> CreateAuthenticationAsync(Models.OAuthRequest body)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/oauth/token");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

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
                return APIHelper.JsonDeserialize<Models.OAuthResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 