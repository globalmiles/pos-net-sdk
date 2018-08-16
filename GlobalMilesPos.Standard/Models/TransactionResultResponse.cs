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
    public class TransactionResultResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int returnCode;
        private string returnDesc;
        private string qrData;
        private string extraInfo;

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
        /// Text data to be used for printing the receipt.
        /// </summary>
        [JsonProperty("qr_data")]
        public string QrData 
        { 
            get 
            {
                return this.qrData; 
            } 
            set 
            {
                this.qrData = value;
                onPropertyChanged("QrData");
            }
        }

        /// <summary>
        /// Extra information for generel usage.
        /// </summary>
        [JsonProperty("extra_info")]
        public string ExtraInfo 
        { 
            get 
            {
                return this.extraInfo; 
            } 
            set 
            {
                this.extraInfo = value;
                onPropertyChanged("ExtraInfo");
            }
        }
    }
} 