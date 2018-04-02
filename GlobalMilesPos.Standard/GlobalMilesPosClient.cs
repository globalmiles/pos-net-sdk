/*
 * GlobalMilesPos.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using GlobalMiles.Pos.Controllers;
using GlobalMiles.Pos.Http.Client;
using GlobalMiles.Pos.Utilities;

namespace GlobalMiles.Pos
{
    public partial class GlobalMilesPosClient
    {

        /// <summary>
        /// Singleton access to PaymentSystems controller
        /// </summary>
        public PaymentSystemsController PaymentSystems
        {
            get
            {
                return PaymentSystemsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Authentication controller
        /// </summary>
        public AuthenticationController Authentication
        {
            get
            {
                return AuthenticationController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Common controller
        /// </summary>
        public CommonController Common
        {
            get
            {
                return CommonController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to BonusPayments controller
        /// </summary>
        public BonusPaymentsController BonusPayments
        {
            get
            {
                return BonusPaymentsController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to OAuthAuthorization controller
        /// </summary>
        public OAuthAuthorizationController OAuthAuthorization
        {
            get
            {
                return OAuthAuthorizationController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Authorization instance

        public AuthManager Auth
        {
            get { return AuthManager.Instance; }
        }

        #endregion
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public GlobalMilesPosClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public GlobalMilesPosClient(string oAuthClientId, string oAuthClientSecret)
        {
            Configuration.OAuthClientId = oAuthClientId;
            Configuration.OAuthClientSecret = oAuthClientSecret;
        }
        #endregion
    }
}