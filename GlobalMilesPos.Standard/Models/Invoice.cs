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
    public class Invoice : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string invoiceType;
        private string invoiceNumber;
        private string invoiceDate;

        /// <summary>
        /// Type of the invoice.
        /// </summary>
        [JsonProperty("invoice_type")]
        public string InvoiceType 
        { 
            get 
            {
                return this.invoiceType; 
            } 
            set 
            {
                this.invoiceType = value;
                onPropertyChanged("InvoiceType");
            }
        }

        /// <summary>
        /// Number of the invoice.
        /// </summary>
        [JsonProperty("invoice_number")]
        public string InvoiceNumber 
        { 
            get 
            {
                return this.invoiceNumber; 
            } 
            set 
            {
                this.invoiceNumber = value;
                onPropertyChanged("InvoiceNumber");
            }
        }

        /// <summary>
        /// Date of the invoice.
        /// </summary>
        [JsonProperty("invoice_date")]
        public string InvoiceDate 
        { 
            get 
            {
                return this.invoiceDate; 
            } 
            set 
            {
                this.invoiceDate = value;
                onPropertyChanged("InvoiceDate");
            }
        }
    }
} 