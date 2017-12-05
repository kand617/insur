/*
 * APIMATICCalculator.PCL
 *
 * This file was automatically generated for testing by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMATICCalculator.PCL;
using APIMATICCalculator.PCL.Utilities;
using APIMATICCalculator.PCL.Http.Request;
using APIMATICCalculator.PCL.Http.Response;
using APIMATICCalculator.PCL.Http.Client;

namespace APIMATICCalculator.PCL.Controllers
{
    public partial interface IOAuthAuthorizationController
    {
        /// <summary>
        /// Create a new OAuth 2 token.
        /// </summary>
        /// <param name="Models.CreateRequestTokenInput">Object containing request parameters</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint</param>
        /// <return>Returns the Models.OAuthToken response from the API call</return>
        Models.OAuthToken CreateRequestToken(Models.CreateRequestTokenInput input, Dictionary<string, object> fieldParameters = null);

        /// <summary>
        /// Create a new OAuth 2 token.
        /// </summary>
        /// <param name="Models.CreateRequestTokenInput">Object containing request parameters</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint</param>
        /// <return>Returns the Models.OAuthToken response from the API call</return>
        Task<Models.OAuthToken> CreateRequestTokenAsync(Models.CreateRequestTokenInput input, Dictionary<string, object> fieldParameters = null);

        /// <summary>
        /// Obtain a new access token using a refresh token
        /// </summary>
        /// <param name="Models.CreateRefreshTokenInput">Object containing request parameters</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint</param>
        /// <return>Returns the Models.OAuthToken response from the API call</return>
        Models.OAuthToken CreateRefreshToken(Models.CreateRefreshTokenInput input, Dictionary<string, object> fieldParameters = null);

        /// <summary>
        /// Obtain a new access token using a refresh token
        /// </summary>
        /// <param name="Models.CreateRefreshTokenInput">Object containing request parameters</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint</param>
        /// <return>Returns the Models.OAuthToken response from the API call</return>
        Task<Models.OAuthToken> CreateRefreshTokenAsync(Models.CreateRefreshTokenInput input, Dictionary<string, object> fieldParameters = null);

    }
} 