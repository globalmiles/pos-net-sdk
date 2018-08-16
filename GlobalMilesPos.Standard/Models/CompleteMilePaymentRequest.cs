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
    public class CompleteMilePaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string terminalId;
        private string otp;

        /// <summary>
        /// Terminal ID.
        /// </summary>
        [JsonProperty("terminal_id")]
        public string TerminalId 
        { 
            get 
            {
                return this.terminalId; 
            } 
            set 
            {
                this.terminalId = value;
                onPropertyChanged("TerminalId");
            }
        }

        /// <summary>
        /// One time password that sends to customer phone.
        /// </summary>
        [JsonProperty("otp")]
        public string Otp 
        { 
            get 
            {
                return this.otp; 
            } 
            set 
            {
                this.otp = value;
                onPropertyChanged("Otp");
            }
        }
    }
} 