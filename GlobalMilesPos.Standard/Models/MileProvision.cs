/*
 * GlobalMilesPos.Standard
 *
 * This file was automatically generated for Global Miles by APIMATIC v2.0 ( https://apimatic.io ).
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
    public class MileProvision : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int milesPaymentProvisionId;
        private double usedMilesAsAmount;
        private string currency;
        private string dateTime;

        /// <summary>
        /// Provision ID
        /// </summary>
        [JsonProperty("miles_payment_provision_id")]
        public int MilesPaymentProvisionId 
        { 
            get 
            {
                return this.milesPaymentProvisionId; 
            } 
            set 
            {
                this.milesPaymentProvisionId = value;
                onPropertyChanged("MilesPaymentProvisionId");
            }
        }

        /// <summary>
        /// Used amount
        /// </summary>
        [JsonProperty("used_miles_as_amount")]
        public double UsedMilesAsAmount 
        { 
            get 
            {
                return this.usedMilesAsAmount; 
            } 
            set 
            {
                this.usedMilesAsAmount = value;
                onPropertyChanged("UsedMilesAsAmount");
            }
        }

        /// <summary>
        /// ISO-4217 3-letter currency code.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency 
        { 
            get 
            {
                return this.currency; 
            } 
            set 
            {
                this.currency = value;
                onPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// Date time of the mile provision.
        /// </summary>
        [JsonProperty("date_time")]
        public string DateTime 
        { 
            get 
            {
                return this.dateTime; 
            } 
            set 
            {
                this.dateTime = value;
                onPropertyChanged("DateTime");
            }
        }
    }
} 