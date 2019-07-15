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
    public class GetCustomerInfoResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int returnCode;
        private string returnDesc;
        private int recognitionId;
        private double availableMilesAsAmount;
        private double loyaltyDiscountedTotalAmount;
        private string currency;

        /// <summary>
        /// 0  Success, 1 and bigger than 1 unsuccessful.
        /// </summary>
        [JsonProperty("return_code")]
        public int ReturnCode 
        { 
            get 
            {
                return this.returnCode; 
            } 
            set 
            {
                this.returnCode = value;
                onPropertyChanged("ReturnCode");
            }
        }

        /// <summary>
        /// if success return is empty. if unsuccessful it returns error message.
        /// </summary>
        [JsonProperty("return_desc")]
        public string ReturnDesc 
        { 
            get 
            {
                return this.returnDesc; 
            } 
            set 
            {
                this.returnDesc = value;
                onPropertyChanged("ReturnDesc");
            }
        }

        /// <summary>
        /// Session based user identification number.
        /// </summary>
        [JsonProperty("recognition_id")]
        public int RecognitionId 
        { 
            get 
            {
                return this.recognitionId; 
            } 
            set 
            {
                this.recognitionId = value;
                onPropertyChanged("RecognitionId");
            }
        }

        /// <summary>
        /// The available miles as an amount that the customer can use in this transaction which is calculated from customer's current miles.
        /// </summary>
        [JsonProperty("available_miles_as_amount")]
        public double AvailableMilesAsAmount 
        { 
            get 
            {
                return this.availableMilesAsAmount; 
            } 
            set 
            {
                this.availableMilesAsAmount = value;
                onPropertyChanged("AvailableMilesAsAmount");
            }
        }

        /// <summary>
        /// Loyalty discounted total amount.
        /// </summary>
        [JsonProperty("loyalty_discounted_total_amount")]
        public double LoyaltyDiscountedTotalAmount 
        { 
            get 
            {
                return this.loyaltyDiscountedTotalAmount; 
            } 
            set 
            {
                this.loyaltyDiscountedTotalAmount = value;
                onPropertyChanged("LoyaltyDiscountedTotalAmount");
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
    }
} 