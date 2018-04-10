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
    public class TransactionResultRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int totalReceiptAmount;
        private int totalVATAmount;
        private string oKCSicilNo;
        private int receiptNo;
        private int zno;
        private int recognitionId;
        private int ekuNo;
        private string receiptType;
        private string receiptDateTime;
        private Models.Invoice invoiceInfo;
        private List<Models.Payment> payments;
        private List<Models.Discount> discounts;

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
        /// Total VAT Amount  ex: 0.85 TL == 85
        /// </summary>
        [JsonProperty("totalVATAmount")]
        public int TotalVATAmount 
        { 
            get 
            {
                return this.totalVATAmount; 
            } 
            set 
            {
                this.totalVATAmount = value;
                onPropertyChanged("TotalVATAmount");
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

        /// <summary>
        /// ReceiptNo
        /// </summary>
        [JsonProperty("ReceiptNo")]
        public int ReceiptNo 
        { 
            get 
            {
                return this.receiptNo; 
            } 
            set 
            {
                this.receiptNo = value;
                onPropertyChanged("ReceiptNo");
            }
        }

        /// <summary>
        /// Z no
        /// </summary>
        [JsonProperty("Zno")]
        public int Zno 
        { 
            get 
            {
                return this.zno; 
            } 
            set 
            {
                this.zno = value;
                onPropertyChanged("Zno");
            }
        }

        /// <summary>
        /// Session based Identification Number .
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
        /// Eku no (Electronic Journal)
        /// </summary>
        [JsonProperty("EkuNo")]
        public int EkuNo 
        { 
            get 
            {
                return this.ekuNo; 
            } 
            set 
            {
                this.ekuNo = value;
                onPropertyChanged("EkuNo");
            }
        }

        /// <summary>
        /// Receipt Type (Invoice , Food ..)
        /// </summary>
        [JsonProperty("ReceiptType")]
        public string ReceiptType 
        { 
            get 
            {
                return this.receiptType; 
            } 
            set 
            {
                this.receiptType = value;
                onPropertyChanged("ReceiptType");
            }
        }

        /// <summary>
        /// It should be  GGAAYYYYSSDD formatted.
        /// </summary>
        [JsonProperty("ReceiptDateTime")]
        public string ReceiptDateTime 
        { 
            get 
            {
                return this.receiptDateTime; 
            } 
            set 
            {
                this.receiptDateTime = value;
                onPropertyChanged("ReceiptDateTime");
            }
        }

        /// <summary>
        /// Invoice detail info
        /// </summary>
        [JsonProperty("InvoiceInfo")]
        public Models.Invoice InvoiceInfo 
        { 
            get 
            {
                return this.invoiceInfo; 
            } 
            set 
            {
                this.invoiceInfo = value;
                onPropertyChanged("InvoiceInfo");
            }
        }

        /// <summary>
        /// Payment Detail Block
        /// </summary>
        [JsonProperty("Payments")]
        public List<Models.Payment> Payments 
        { 
            get 
            {
                return this.payments; 
            } 
            set 
            {
                this.payments = value;
                onPropertyChanged("Payments");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Discounts")]
        public List<Models.Discount> Discounts 
        { 
            get 
            {
                return this.discounts; 
            } 
            set 
            {
                this.discounts = value;
                onPropertyChanged("Discounts");
            }
        }
    }
} 