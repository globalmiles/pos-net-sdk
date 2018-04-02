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
    public class BonusProvision : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string bonusPaymentProvisionId;
        private int usedBonusAmount;
        private string dateTime;

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
        /// Used Bonus Amount
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
        /// Date/time
        /// </summary>
        [JsonProperty("dateTime")]
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