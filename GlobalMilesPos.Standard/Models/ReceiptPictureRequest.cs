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
    public class ReceiptPictureRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string terminalId;
        private int recognitionId;
        private string fileName;
        private string picture;

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
        /// Session based user identification number.
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
        /// File name of the picture.
        /// </summary>
        [JsonProperty("file_name")]
        public string FileName 
        { 
            get 
            {
                return this.fileName; 
            } 
            set 
            {
                this.fileName = value;
                onPropertyChanged("FileName");
            }
        }

        /// <summary>
        /// Base64 encoded binary picture data.
        /// </summary>
        [JsonProperty("picture")]
        public string Picture 
        { 
            get 
            {
                return this.picture; 
            } 
            set 
            {
                this.picture = value;
                onPropertyChanged("Picture");
            }
        }
    }
} 