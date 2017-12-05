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
    public class CreateRequestTokenInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string grantType = "password";
        private string authorization;
        private string username;
        private string password;
        private string scope;

        /// <summary>
        /// Grant Type
        /// </summary>
        [JsonProperty("grant_type")]
        public string GrantType 
        { 
            get 
            {
                return this.grantType; 
            } 
            private set 
            {
                this.grantType = value;
                onPropertyChanged("GrantType");
            }
        }

        /// <summary>
        /// Authorization header in Basic auth format
        /// </summary>
        [JsonProperty("Authorization")]
        public string Authorization 
        { 
            get 
            {
                return this.authorization; 
            } 
            set 
            {
                this.authorization = value;
                onPropertyChanged("Authorization");
            }
        }

        /// <summary>
        /// Resource owner username
        /// </summary>
        [JsonProperty("username")]
        public string Username 
        { 
            get 
            {
                return this.username; 
            } 
            set 
            {
                this.username = value;
                onPropertyChanged("Username");
            }
        }

        /// <summary>
        /// Resource owner password
        /// </summary>
        [JsonProperty("password")]
        public string Password 
        { 
            get 
            {
                return this.password; 
            } 
            set 
            {
                this.password = value;
                onPropertyChanged("Password");
            }
        }

        /// <summary>
        /// Requested scopes as a space-delimited list.
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
    }
} 