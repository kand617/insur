/*
 * APIMATICCalculator.PCL
 *
 * This file was automatically generated for testing by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATICCalculator.PCL;
using APIMATICCalculator.PCL.Utilities;


namespace APIMATICCalculator.PCL.Models
{
    public class OAuthToken : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string accessToken;
        private string tokenType;
        private long? expiresIn;
        private string scope;
        private long? expiry;
        private string refreshToken;

        /// <summary>
        /// Access token
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken 
        { 
            get 
            {
                return this.accessToken; 
            } 
            set 
            {
                this.accessToken = value;
                onPropertyChanged("AccessToken");
            }
        }

        /// <summary>
        /// Type of access token
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType 
        { 
            get 
            {
                return this.tokenType; 
            } 
            set 
            {
                this.tokenType = value;
                onPropertyChanged("TokenType");
            }
        }

        /// <summary>
        /// Time in seconds before the access token expires
        /// </summary>
        [JsonProperty("expires_in")]
        public long? ExpiresIn 
        { 
            get 
            {
                return this.expiresIn; 
            } 
            set 
            {
                this.expiresIn = value;
                onPropertyChanged("ExpiresIn");
            }
        }

        /// <summary>
        /// List of scopes granted
        /// This is a space-delimited list of strings.
        /// </summary>
        [JsonProperty("scope")]
        public string Scope 
        { 
            get 
            {
                return this.scope; 
            } 
            set 
            {
                this.scope = value;
                onPropertyChanged("Scope");
            }
        }

        /// <summary>
        /// Time of token expiry as unix timestamp (UTC)
        /// </summary>
        [JsonProperty("expiry")]
        public long? Expiry 
        { 
            get 
            {
                return this.expiry; 
            } 
            set 
            {
                this.expiry = value;
                onPropertyChanged("Expiry");
            }
        }

        /// <summary>
        /// Refresh token
        /// Used to get a new access token when it expires.
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken 
        { 
            get 
            {
                return this.refreshToken; 
            } 
            set 
            {
                this.refreshToken = value;
                onPropertyChanged("RefreshToken");
            }
        }
    }
} 