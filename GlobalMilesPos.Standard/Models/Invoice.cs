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
    public class Invoice : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string invoiceType;
        private string invoiceNo;
        private string invoiceDate;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("invoiceType")]
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("invoiceNo")]
        public string InvoiceNo 
        { 
            get 
            {
                return this.invoiceNo; 
            } 
            set 
            {
                this.invoiceNo = value;
                onPropertyChanged("InvoiceNo");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("invoiceDate")]
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