/*
 * APIMATICCalculator.PCL
 *
 * This file was automatically generated for testing by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using APIMATICCalculator.PCL.Controllers;
using APIMATICCalculator.PCL.Http.Client;
using APIMATICCalculator.PCL.Utilities;

namespace APIMATICCalculator.PCL
{
    public partial class APIMATICCalculatorClient: IAPIMATICCalculatorClient
    {

        /// <summary>
        /// Singleton access to SimpleCalculator controller
        /// </summary>
        public ISimpleCalculatorController SimpleCalculator
        {
            get
            {
                return SimpleCalculatorController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Client controller
        /// </summary>
        public IAPIController Client
        {
            get
            {
                return APIController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to OAuthAuthorization controller
        /// </summary>
        public IOAuthAuthorizationController OAuthAuthorization
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
        public APIMATICCalculatorClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public APIMATICCalculatorClient(string gfdsfkl, string dsfsdf, string oAuthClientId, string oAuthClientSecret, string oAuthUsername, string oAuthPassword)
        {
            Configuration.Gfdsfkl = gfdsfkl;
            Configuration.Dsfsdf = dsfsdf;
            Configuration.OAuthClientId = oAuthClientId;
            Configuration.OAuthClientSecret = oAuthClientSecret;
            Configuration.OAuthUsername = oAuthUsername;
            Configuration.OAuthPassword = oAuthPassword;
        }
        #endregion
    }
}