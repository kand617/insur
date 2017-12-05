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
    public class New : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int counter;
        private Models.Advance advance;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("counter")]
        public int Counter 
        { 
            get 
            {
                return this.counter; 
            } 
            set 
            {
                this.counter = value;
                onPropertyChanged("Counter");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("advance")]
        public Models.Advance Advance 
        { 
            get 
            {
                return this.advance; 
            } 
            set 
            {
                this.advance = value;
                onPropertyChanged("Advance");
            }
        }
    }
} 