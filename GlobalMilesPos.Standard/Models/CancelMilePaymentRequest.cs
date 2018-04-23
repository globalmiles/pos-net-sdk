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
    public class CancelMilePaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string bonusPaymentProvisionId;
        private string oKCSicilNo;

        /// <summary>
        /// Provision ID
        /// </summary>
        [JsonProperty("bonusPaymentProvisionId")]
        public string BonusPaymentProvisionId 
        { 
            get 
            {
                return this.bonusPaymentProvisionId; 
            } 
            set 
            {
                this.bonusPaymentProvisionId = value;
                onPropertyChanged("BonusPaymentProvisionId");
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