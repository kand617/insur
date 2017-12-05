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
    public class NewInput : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.NewRequest body;
        private string cacheControl;
        private string contentType;
        private string postmanToken;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("body")]
        public Models.NewRequest Body 
        { 
            get 
            {
                return this.body; 
            } 
            set 
            {
                this.body = value;
                onPropertyChanged("Body");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("cache-control")]
        public string CacheControl 
        { 
            get 
            {
                return this.cacheControl; 
            } 
            set 
            {
                this.cacheControl = value;
                onPropertyChanged("CacheControl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("content-type")]
        public string ContentType 
        { 
            get 
            {
                return this.contentType; 
            } 
            set 
            {
                this.contentType = value;
                onPropertyChanged("ContentType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("postman-token")]
        public string PostmanToken 
        { 
            get 
            {
                return this.postmanToken; 
            } 
            set 
            {
                this.postmanToken = value;
                onPropertyChanged("PostmanToken");
            }
        }
    }
} 