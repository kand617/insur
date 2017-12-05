/*
 * APIMATICCalculator.PCL
 *
 * This file was automatically generated for testing by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using APIMATICCalculator.PCL.Controllers;

namespace APIMATICCalculator.PCL
{
    public partial interface IAPIMATICCalculatorClient
    {

        /// <summary>
        /// Singleton access to SimpleCalculator controller
        /// </summary>
        ISimpleCalculatorController SimpleCalculator { get;}

        /// <summary>
        /// Singleton access to Client controller
        /// </summary>
        IAPIController Client { get;}

        /// <summary>
        /// Singleton access to OAuthAuthorization controller
        /// </summary>
        IOAuthAuthorizationController OAuthAuthorization { get;}

    }
}