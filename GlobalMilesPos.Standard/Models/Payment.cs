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
    public class Payment : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double payAmount;
        private string paymentType;
        private int? milesPaymentProvisionId;

        /// <summary>
        /// Amount of the payment.
        /// </summary>
        [JsonProperty("pay_amount")]
        public double PayAmount 
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
        /// Type of the payment.
        /// </summary>
        [JsonProperty("payment_type")]
        public string PaymentType 
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

        /// <summary>
        /// Provision ID for pay with miles.
        /// </summary>
        [JsonProperty("miles_payment_provision_id")]
        public int? MilesPaymentProvisionId 
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
    }
} 