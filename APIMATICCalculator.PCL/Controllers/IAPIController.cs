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
    public partial interface IAPIController
    {
        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="Models.NewInput">Object containing request parameters</param>
        /// <return>Returns the dynamic response from the API call</return>
        dynamic New(Models.NewInput input);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="Models.NewInput">Object containing request parameters</param>
        /// <return>Returns the dynamic response from the API call</return>
        Task<dynamic> NewAsync(Models.NewInput input);

    }
} 