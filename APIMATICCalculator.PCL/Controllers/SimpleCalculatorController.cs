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
    public partial class SimpleCalculatorController: BaseController, ISimpleCalculatorController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static SimpleCalculatorController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static SimpleCalculatorController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new SimpleCalculatorController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Calculates the expression using the specified operation.
        /// </summary>
        /// <param name="Models.GetCalculateInput">Object containing request parameters</param>
        /// <return>Returns the double response from the API call</return>
        public double GetCalculate(Models.GetCalculateInput input)
        {
            Task<double> t = GetCalculateAsync(input);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Calculates the expression using the specified operation.
        /// </summary>
        /// <param name="Models.GetCalculateInput">Object containing request parameters</param>
        /// <return>Returns the double response from the API call</return>
        public async Task<double> GetCalculateAsync(Models.GetCalculateInput input)
        {
            //Check if authentication token is set
            AuthManager.Instance.CheckAuthorization();
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/{operation}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "operation", Models.OperationTypeEnumHelper.ToValue(input.Operation) }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "x", input.X },
                { "y", input.Y }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };
            _headers.Add("gfdsfkl", Configuration.Gfdsfkl);
            _headers.Add("dsfsdf", Configuration.Dsfsdf);
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
                return double.Parse(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 