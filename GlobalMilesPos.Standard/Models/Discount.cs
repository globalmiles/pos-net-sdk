/*
 * GlobalMilesPos.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io )
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
using GlobalMiles.Pos;
using GlobalMiles.Pos.Utilities;


namespace GlobalMiles.Pos.Models
{
    public class Discount : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string origin;
        private string type;
        private double mvalue;

        /// <summary>
        /// Origin of the discount. 1: Global Miles, 2: Other.
        /// </summary>
        [JsonProperty("origin")]
        public string Origin 
        { 
            get 
            {
                return this.origin; 
            } 
            set 
            {
                this.origin = value;
                onPropertyChanged("Origin");
            }
        }

        /// <summary>
        /// Type of the discount. 0: amount based, 1: rate based.
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Value of the discount.
        /// </summary>
        [JsonProperty("value")]
        public double Value 
        { 
            get 
            {
                return this.mvalue; 
            } 
            set 
            {
                this.mvalue = value;
                onPropertyChanged("Value");
            }
        }
    }
} 