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
    public class Payment : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int payAmount;
        private int paymentType;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payAmount")]
        public int PayAmount 
        { 
            get 
            {
                return this.payAmount; 
            } 
            set 
            {
                this.payAmount = value;
                onPropertyChanged("PayAmount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("paymentType")]
        public int PaymentType 
        { 
            get 
            {
                return this.paymentType; 
            } 
            set 
            {
                this.paymentType = value;
                onPropertyChanged("PaymentType");
            }
        }
    }
} 