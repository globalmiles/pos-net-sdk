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
        private double totalReceiptAmount;
        private double totalVatAmount;
        private string currency;
        private int partnerId;
        private int branchId;
        private string terminalId;
        private string receiptNumber;
        private string extraNumber1;
        private string extraNumber2;
        private int recognitionId;
        private string receiptType;
        private string receiptDateTime;
        private Models.Invoice invoiceInfo;
        private List<Models.Payment> payments;
        private List<Models.Discount> discounts;
        private string extraData;

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
        /// Total tax amount.
        /// </summary>
        [JsonProperty("total_vat_amount")]
        public double TotalVatAmount 
        { 
            get 
            {
                return this.totalVatAmount; 
            } 
            set 
            {
                this.totalVatAmount = value;
                onPropertyChanged("TotalVatAmount");
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
        /// Partner ID.
        /// </summary>
        [JsonProperty("partner_id")]
        public int PartnerId 
        { 
            get 
            {
                return this.partnerId; 
            } 
            set 
            {
                this.partnerId = value;
                onPropertyChanged("PartnerId");
            }
        }

        /// <summary>
        /// Branch ID.
        /// </summary>
        [JsonProperty("branch_id")]
        public int BranchId 
        { 
            get 
            {
                return this.branchId; 
            } 
            set 
            {
                this.branchId = value;
                onPropertyChanged("BranchId");
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

        /// <summary>
        /// Receipt number.
        /// </summary>
        [JsonProperty("receipt_number")]
        public string ReceiptNumber 
        { 
            get 
            {
                return this.receiptNumber; 
            } 
            set 
            {
                this.receiptNumber = value;
                onPropertyChanged("ReceiptNumber");
            }
        }

        /// <summary>
        /// Extra number 1.
        /// </summary>
        [JsonProperty("extra_number_1")]
        public string ExtraNumber1 
        { 
            get 
            {
                return this.extraNumber1; 
            } 
            set 
            {
                this.extraNumber1 = value;
                onPropertyChanged("ExtraNumber1");
            }
        }

        /// <summary>
        /// Extra number 2.
        /// </summary>
        [JsonProperty("extra_number_2")]
        public string ExtraNumber2 
        { 
            get 
            {
                return this.extraNumber2; 
            } 
            set 
            {
                this.extraNumber2 = value;
                onPropertyChanged("ExtraNumber2");
            }
        }

        /// <summary>
        /// Session based identification number.
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
        /// Receipt type (Invoice , Food ..)
        /// </summary>
        [JsonProperty("receipt_type")]
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
        /// It should be DDMMYYYYHHMM formatted.
        /// </summary>
        [JsonProperty("receipt_date_time")]
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
        /// Invoice details.
        /// </summary>
        [JsonProperty("invoice_info")]
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
        /// Payment details.
        /// </summary>
        [JsonProperty("payments")]
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
        /// Discount details.
        /// </summary>
        [JsonProperty("discounts")]
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

        /// <summary>
        /// Extra data.
        /// </summary>
        [JsonProperty("extra_data")]
        public string ExtraData 
        { 
            get 
            {
                return this.extraData; 
            } 
            set 
            {
                this.extraData = value;
                onPropertyChanged("ExtraData");
            }
        }
    }
} 