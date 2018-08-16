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
    public class GetTerminalInfoResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int returnCode;
        private string returnDesc;
        private string terminalId;
        private string receiptHeader;
        private string receiptFooter;
        private int partnerId;
        private int branchId;
        private bool merchantIdMandatory;
        private string defaultCurrency;

        /// <summary>
        /// 0 Success, 1 and bigger than 1 unsuccessful.
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
        /// Header text for the receipt.
        /// </summary>
        [JsonProperty("receipt_header")]
        public string ReceiptHeader 
        { 
            get 
            {
                return this.receiptHeader; 
            } 
            set 
            {
                this.receiptHeader = value;
                onPropertyChanged("ReceiptHeader");
            }
        }

        /// <summary>
        /// Footer text for the receipt.
        /// </summary>
        [JsonProperty("receipt_footer")]
        public string ReceiptFooter 
        { 
            get 
            {
                return this.receiptFooter; 
            } 
            set 
            {
                this.receiptFooter = value;
                onPropertyChanged("ReceiptFooter");
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
        /// Indicates whether the merchant ID parameter is required in the Transaction Result request.
        /// </summary>
        [JsonProperty("merchant_id_mandatory")]
        public bool MerchantIdMandatory 
        { 
            get 
            {
                return this.merchantIdMandatory; 
            } 
            set 
            {
                this.merchantIdMandatory = value;
                onPropertyChanged("MerchantIdMandatory");
            }
        }

        /// <summary>
        /// ISO-4217 3-letter default currency code for the partner.
        /// </summary>
        [JsonProperty("default_currency")]
        public string DefaultCurrency 
        { 
            get 
            {
                return this.defaultCurrency; 
            } 
            set 
            {
                this.defaultCurrency = value;
                onPropertyChanged("DefaultCurrency");
            }
        }
    }
} 