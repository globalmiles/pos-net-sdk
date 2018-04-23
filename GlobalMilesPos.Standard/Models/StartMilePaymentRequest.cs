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
    public class StartMilePaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int totalReceiptAmount;
        private int usedBonusAmount;
        private int recognitionId;
        private string oKCSicilNo;

        /// <summary>
        /// Total Receipt Amount  ex:12.35 TL == 1235
        /// </summary>
        [JsonProperty("totalReceiptAmount")]
        public int TotalReceiptAmount 
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
        /// Used Amount that has been used in the shopping  ex:0.85 TL == 85
        /// </summary>
        [JsonProperty("usedBonusAmount")]
        public int UsedBonusAmount 
        { 
            get 
            {
                return this.usedBonusAmount; 
            } 
            set 
            {
                this.usedBonusAmount = value;
                onPropertyChanged("UsedBonusAmount");
            }
        }

        /// <summary>
        /// Session based user identification number
        /// </summary>
        [JsonProperty("recognitionId")]
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
        /// Terminal code.
        /// </summary>
        [JsonProperty("OKCSicilNo")]
        public string OKCSicilNo 
        { 
            get 
            {
                return this.oKCSicilNo; 
            } 
            set 
            {
                this.oKCSicilNo = value;
                onPropertyChanged("OKCSicilNo");
            }
        }
    }
} 