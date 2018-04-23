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
    public class GetMileProvisionsRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string readCode;
        private string readCodeType;
        private string oKCSicilNo;

        /// <summary>
        /// Customer Identification Method ; GSM NO, Customer Unique ID or CODE
        /// </summary>
        [JsonProperty("readCode")]
        public string ReadCode 
        { 
            get 
            {
                return this.readCode; 
            } 
            set 
            {
                this.readCode = value;
                onPropertyChanged("ReadCode");
            }
        }

        /// <summary>
        /// 1: GSM NO, 2: Customer unique identifier, 3: CODE
        /// </summary>
        [JsonProperty("readCodeType")]
        public string ReadCodeType 
        { 
            get 
            {
                return this.readCodeType; 
            } 
            set 
            {
                this.readCodeType = value;
                onPropertyChanged("ReadCodeType");
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