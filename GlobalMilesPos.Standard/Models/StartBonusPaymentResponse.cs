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
    public class StartBonusPaymentResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int returnCode;
        private string returnDesc;
        private string bonusPaymentProvisionId;
        private bool oTPNeeded;

        /// <summary>
        /// 0 ise başarılı, 1 veya daha büyük ise başarısız
        /// </summary>
        [JsonProperty("returnCode")]
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
        /// Başarılı ise boş, eğer hata varsa; hata mesajını içerir.
        /// </summary>
        [JsonProperty("returnDesc")]
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
        /// Provizyon ID
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
        /// Tek kullanımlık parola gerekli mi?
        /// </summary>
        [JsonProperty("OTPNeeded")]
        public bool OTPNeeded 
        { 
            get 
            {
                return this.oTPNeeded; 
            } 
            set 
            {
                this.oTPNeeded = value;
                onPropertyChanged("OTPNeeded");
            }
        }
    }
} 