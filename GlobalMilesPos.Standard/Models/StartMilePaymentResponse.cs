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
    public class StartMilePaymentResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int returnCode;
        private string returnDesc;
        private int milesPaymentProvisionId;
        private bool otpNeeded;

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
        /// Provision ID for the payment.
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
        /// Is a one-time password required?
        /// </summary>
        [JsonProperty("otp_needed")]
        public bool OtpNeeded 
        { 
            get 
            {
                return this.otpNeeded; 
            } 
            set 
            {
                this.otpNeeded = value;
                onPropertyChanged("OtpNeeded");
            }
        }
    }
} 