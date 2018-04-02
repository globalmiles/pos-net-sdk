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
    public class GetCustomerInfoResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int returnCode;
        private string returnDesc;
        private int recognitionId;
        private int availablePoint;
        private int loyaltyDiscountedPrice;

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
        /// Kullanıcının GlobalMiles sistemindeki unique identifier değeri
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
        /// Müşterinin bu işlemde kullanabileceği puanın TL karşılığıdır. Son iki karakter kuruşları temsil eder. Örneğin: 12.56 TL == 1256
        /// </summary>
        [JsonProperty("availablePoint")]
        public int AvailablePoint 
        { 
            get 
            {
                return this.availablePoint; 
            } 
            set 
            {
                this.availablePoint = value;
                onPropertyChanged("AvailablePoint");
            }
        }

        /// <summary>
        /// Sadakat indirimi. Son iki karakter kuruşları temsil eder. Örneğin: 90.50 TL == 9050
        /// </summary>
        [JsonProperty("loyaltyDiscountedPrice")]
        public int LoyaltyDiscountedPrice 
        { 
            get 
            {
                return this.loyaltyDiscountedPrice; 
            } 
            set 
            {
                this.loyaltyDiscountedPrice = value;
                onPropertyChanged("LoyaltyDiscountedPrice");
            }
        }
    }
} 