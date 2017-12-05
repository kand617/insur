/*
 * APIMATICCalculator.PCL
 *
 * This file was automatically generated for testing by APIMATIC v2.0 ( https://apimatic.io )
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
using APIMATICCalculator.PCL;
using APIMATICCalculator.PCL.Utilities;
using APIMATICCalculator.PCL.Http.Request;
using APIMATICCalculator.PCL.Http.Response;
using APIMATICCalculator.PCL.Http.Client;
using APIMATICCalculator.PCL.Exceptions;

namespace APIMATICCalculator.PCL.Controllers
{
    public partial class OAuthAuthorizationController: BaseController, IOAuthAuthorizationController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static OAuthAuthorizationController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static OAuthAuthorizationController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new OAuthAuthorizationController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Create a new OAuth 2 token.
        /// </summary>
        /// <param name="Models.CreateRequestTokenInput">Object containing request parameters</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint</param>
        /// <return>Returns the Models.OAuthToken response from the API call</return>
        public Models.OAuthToken CreateRequestToken(Models.CreateRequestTokenInput input, Dictionary<string, object> fieldParameters = null)
        {
            Task<Models.OAuthToken> t = CreateRequestTokenAsync(input, fieldParameters);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new OAuth 2 token.
        /// </summary>
        /// <param name="Models.CreateRequestTokenInput">Object containing request parameters</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint</param>
        /// <return>Returns the Models.OAuthToken response from the API call</return>
        public async Task<Models.OAuthToken> CreateRequestTokenAsync(Models.CreateRequestTokenInput input, Dictionary<string, object> fieldParameters = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/iisadasdjadasodisd0-2394-023jalskasdasd");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "Authorization", input.Authorization }
            };
            _headers.Add("gfdsfkl", Configuration.Gfdsfkl);
            _headers.Add("dsfsdf", Configuration.Dsfsdf);

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "grant_type", "password" ),
                new KeyValuePair<string, object>( "username", input.Username ),
                new KeyValuePair<string, object>( "password", input.Password ),
                new KeyValuePair<string, object>( "scope", input.Scope )
            };
            //optional form parameters
            _fields.AddRange(APIHelper.PrepareFormFieldsFromObject("",fieldParameters, arrayDeserializationFormat: ArrayDeserializationFormat));
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new OAuthProviderException(@"OAuth 2 provider returned an error.", _context);

            if (_response.StatusCode == 401)
                throw new OAuthProviderException(@"OAuth 2 provider says client authentication failed.", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.OAuthToken>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Obtain a new access token using a refresh token
        /// </summary>
        /// <param name="Models.CreateRefreshTokenInput">Object containing request parameters</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint</param>
        /// <return>Returns the Models.OAuthToken response from the API call</return>
        public Models.OAuthToken CreateRefreshToken(Models.CreateRefreshTokenInput input, Dictionary<string, object> fieldParameters = null)
        {
            Task<Models.OAuthToken> t = CreateRefreshTokenAsync(input, fieldParameters);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Obtain a new access token using a refresh token
        /// </summary>
        /// <param name="Models.CreateRefreshTokenInput">Object containing request parameters</param>
        /// <param name="fieldParameters">Additional optional form parameters are supported by this endpoint</param>
        /// <return>Returns the Models.OAuthToken response from the API call</return>
        public async Task<Models.OAuthToken> CreateRefreshTokenAsync(Models.CreateRefreshTokenInput input, Dictionary<string, object> fieldParameters = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/iisadasdjadasodisd0-2394-023jalskasdasd");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "Authorization", input.Authorization }
            };
            _headers.Add("gfdsfkl", Configuration.Gfdsfkl);
            _headers.Add("dsfsdf", Configuration.Dsfsdf);

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "grant_type", "refresh_token" ),
                new KeyValuePair<string, object>( "refresh_token", input.RefreshToken ),
                new KeyValuePair<string, object>( "scope", input.Scope )
            };
            //optional form parameters
            _fields.AddRange(APIHelper.PrepareFormFieldsFromObject("",fieldParameters, arrayDeserializationFormat: ArrayDeserializationFormat));
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new OAuthProviderException(@"OAuth 2 provider returned an error.", _context);

            if (_response.StatusCode == 401)
                throw new OAuthProviderException(@"OAuth 2 provider says client authentication failed.", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.OAuthToken>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 