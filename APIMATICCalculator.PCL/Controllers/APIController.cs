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
    public partial class APIController: BaseController, IAPIController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static APIController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static APIController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new APIController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="Models.NewInput">Object containing request parameters</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic New(Models.NewInput input)
        {
            Task<dynamic> t = NewAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="Models.NewInput">Object containing request parameters</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> NewAsync(Models.NewInput input)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/1.1/test.php");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "cache-control", input.CacheControl },
                { "content-type", input.ContentType },
                { "postman-token", input.PostmanToken }
            };
            _headers.Add("gfdsfkl", Configuration.Gfdsfkl);
            _headers.Add("dsfsdf", Configuration.Dsfsdf);
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthToken.AccessToken));

            //append body params
            var _body = APIHelper.JsonSerialize(input.Body);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 