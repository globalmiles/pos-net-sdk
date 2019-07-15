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
    public class StartMilePaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double totalReceiptAmount;
        private double usedMilesAsAmount;
        private string currency;
        private int recognitionId;
        private string terminalId;

        /// <summary>
        /// Total receipt amount.
        /// </summary>
        [JsonProperty("total_receipt_amount")]
        public double TotalReceiptAmount 
        { 
            get 
            {
                return this.totalReceiptAmount; 
            } 
            set 
            {
                this.totalReceiptAmount = value;
                onPropertyChanged("TotalReceiptAmount");
            }
        }

        /// <summary>
        /// Used amount that has been used in the shopping.
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
    }
} 