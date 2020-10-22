/*
 * Chuck Norris IO
 *
 * chucknorris.io is a free JSON API for hand curated Chuck Norris facts.  Chuck Norris facts are satirical factoids about martial artist and actor Chuck Norris that have become an Internet phenomenon and as a result have become widespread in popular culture. The 'facts' are normally absurd hyperbolic claims about Norris' toughness, attitude, virility, sophistication, and masculinity.  Chuck Norris facts have spread around the world, leading not only to translated versions, but also spawning localized versions mentioning country-specific advertisements and other Internet phenomena. Allusions are also sometimes made to his use of roundhouse kicks to perform seemingly any task, his large amount of body hair with specific regard to his beard, and his role in the action television series Walker, Texas Ranger.
 *
 * OpenAPI spec version: 2.0.0
 * Contact: m@matchilling.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace chuckswapi_api.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ModelAndView : IEquatable<ModelAndView>
    { 
        /// <summary>
        /// Gets or Sets Empty
        /// </summary>
        [DataMember(Name="empty")]
        public bool? Empty { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model")]
        public Object Model { get; set; }

        /// <summary>
        /// Gets or Sets ModelMap
        /// </summary>
        [DataMember(Name="model_map")]
        public Dictionary<string, Object> ModelMap { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference")]
        public bool? Reference { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum _100CONTINUEEnum for 100 CONTINUE
            /// </summary>
            [EnumMember(Value = "100 CONTINUE")]
            _100CONTINUEEnum = 1,
            
            /// <summary>
            /// Enum _101SWITCHINGPROTOCOLSEnum for 101 SWITCHING_PROTOCOLS
            /// </summary>
            [EnumMember(Value = "101 SWITCHING_PROTOCOLS")]
            _101SWITCHINGPROTOCOLSEnum = 2,
            
            /// <summary>
            /// Enum _102PROCESSINGEnum for 102 PROCESSING
            /// </summary>
            [EnumMember(Value = "102 PROCESSING")]
            _102PROCESSINGEnum = 3,
            
            /// <summary>
            /// Enum _103CHECKPOINTEnum for 103 CHECKPOINT
            /// </summary>
            [EnumMember(Value = "103 CHECKPOINT")]
            _103CHECKPOINTEnum = 4,
            
            /// <summary>
            /// Enum _200OKEnum for 200 OK
            /// </summary>
            [EnumMember(Value = "200 OK")]
            _200OKEnum = 5,
            
            /// <summary>
            /// Enum _201CREATEDEnum for 201 CREATED
            /// </summary>
            [EnumMember(Value = "201 CREATED")]
            _201CREATEDEnum = 6,
            
            /// <summary>
            /// Enum _202ACCEPTEDEnum for 202 ACCEPTED
            /// </summary>
            [EnumMember(Value = "202 ACCEPTED")]
            _202ACCEPTEDEnum = 7,
            
            /// <summary>
            /// Enum _203NONAUTHORITATIVEINFORMATIONEnum for 203 NON_AUTHORITATIVE_INFORMATION
            /// </summary>
            [EnumMember(Value = "203 NON_AUTHORITATIVE_INFORMATION")]
            _203NONAUTHORITATIVEINFORMATIONEnum = 8,
            
            /// <summary>
            /// Enum _204NOCONTENTEnum for 204 NO_CONTENT
            /// </summary>
            [EnumMember(Value = "204 NO_CONTENT")]
            _204NOCONTENTEnum = 9,
            
            /// <summary>
            /// Enum _205RESETCONTENTEnum for 205 RESET_CONTENT
            /// </summary>
            [EnumMember(Value = "205 RESET_CONTENT")]
            _205RESETCONTENTEnum = 10,
            
            /// <summary>
            /// Enum _206PARTIALCONTENTEnum for 206 PARTIAL_CONTENT
            /// </summary>
            [EnumMember(Value = "206 PARTIAL_CONTENT")]
            _206PARTIALCONTENTEnum = 11,
            
            /// <summary>
            /// Enum _207MULTISTATUSEnum for 207 MULTI_STATUS
            /// </summary>
            [EnumMember(Value = "207 MULTI_STATUS")]
            _207MULTISTATUSEnum = 12,
            
            /// <summary>
            /// Enum _208ALREADYREPORTEDEnum for 208 ALREADY_REPORTED
            /// </summary>
            [EnumMember(Value = "208 ALREADY_REPORTED")]
            _208ALREADYREPORTEDEnum = 13,
            
            /// <summary>
            /// Enum _226IMUSEDEnum for 226 IM_USED
            /// </summary>
            [EnumMember(Value = "226 IM_USED")]
            _226IMUSEDEnum = 14,
            
            /// <summary>
            /// Enum _300MULTIPLECHOICESEnum for 300 MULTIPLE_CHOICES
            /// </summary>
            [EnumMember(Value = "300 MULTIPLE_CHOICES")]
            _300MULTIPLECHOICESEnum = 15,
            
            /// <summary>
            /// Enum _301MOVEDPERMANENTLYEnum for 301 MOVED_PERMANENTLY
            /// </summary>
            [EnumMember(Value = "301 MOVED_PERMANENTLY")]
            _301MOVEDPERMANENTLYEnum = 16,
            
            /// <summary>
            /// Enum _302FOUNDEnum for 302 FOUND
            /// </summary>
            [EnumMember(Value = "302 FOUND")]
            _302FOUNDEnum = 17,
            
            /// <summary>
            /// Enum _302MOVEDTEMPORARILYEnum for 302 MOVED_TEMPORARILY
            /// </summary>
            [EnumMember(Value = "302 MOVED_TEMPORARILY")]
            _302MOVEDTEMPORARILYEnum = 18,
            
            /// <summary>
            /// Enum _303SEEOTHEREnum for 303 SEE_OTHER
            /// </summary>
            [EnumMember(Value = "303 SEE_OTHER")]
            _303SEEOTHEREnum = 19,
            
            /// <summary>
            /// Enum _304NOTMODIFIEDEnum for 304 NOT_MODIFIED
            /// </summary>
            [EnumMember(Value = "304 NOT_MODIFIED")]
            _304NOTMODIFIEDEnum = 20,
            
            /// <summary>
            /// Enum _305USEPROXYEnum for 305 USE_PROXY
            /// </summary>
            [EnumMember(Value = "305 USE_PROXY")]
            _305USEPROXYEnum = 21,
            
            /// <summary>
            /// Enum _307TEMPORARYREDIRECTEnum for 307 TEMPORARY_REDIRECT
            /// </summary>
            [EnumMember(Value = "307 TEMPORARY_REDIRECT")]
            _307TEMPORARYREDIRECTEnum = 22,
            
            /// <summary>
            /// Enum _308PERMANENTREDIRECTEnum for 308 PERMANENT_REDIRECT
            /// </summary>
            [EnumMember(Value = "308 PERMANENT_REDIRECT")]
            _308PERMANENTREDIRECTEnum = 23,
            
            /// <summary>
            /// Enum _400BADREQUESTEnum for 400 BAD_REQUEST
            /// </summary>
            [EnumMember(Value = "400 BAD_REQUEST")]
            _400BADREQUESTEnum = 24,
            
            /// <summary>
            /// Enum _401UNAUTHORIZEDEnum for 401 UNAUTHORIZED
            /// </summary>
            [EnumMember(Value = "401 UNAUTHORIZED")]
            _401UNAUTHORIZEDEnum = 25,
            
            /// <summary>
            /// Enum _402PAYMENTREQUIREDEnum for 402 PAYMENT_REQUIRED
            /// </summary>
            [EnumMember(Value = "402 PAYMENT_REQUIRED")]
            _402PAYMENTREQUIREDEnum = 26,
            
            /// <summary>
            /// Enum _403FORBIDDENEnum for 403 FORBIDDEN
            /// </summary>
            [EnumMember(Value = "403 FORBIDDEN")]
            _403FORBIDDENEnum = 27,
            
            /// <summary>
            /// Enum _404NOTFOUNDEnum for 404 NOT_FOUND
            /// </summary>
            [EnumMember(Value = "404 NOT_FOUND")]
            _404NOTFOUNDEnum = 28,
            
            /// <summary>
            /// Enum _405METHODNOTALLOWEDEnum for 405 METHOD_NOT_ALLOWED
            /// </summary>
            [EnumMember(Value = "405 METHOD_NOT_ALLOWED")]
            _405METHODNOTALLOWEDEnum = 29,
            
            /// <summary>
            /// Enum _406NOTACCEPTABLEEnum for 406 NOT_ACCEPTABLE
            /// </summary>
            [EnumMember(Value = "406 NOT_ACCEPTABLE")]
            _406NOTACCEPTABLEEnum = 30,
            
            /// <summary>
            /// Enum _407PROXYAUTHENTICATIONREQUIREDEnum for 407 PROXY_AUTHENTICATION_REQUIRED
            /// </summary>
            [EnumMember(Value = "407 PROXY_AUTHENTICATION_REQUIRED")]
            _407PROXYAUTHENTICATIONREQUIREDEnum = 31,
            
            /// <summary>
            /// Enum _408REQUESTTIMEOUTEnum for 408 REQUEST_TIMEOUT
            /// </summary>
            [EnumMember(Value = "408 REQUEST_TIMEOUT")]
            _408REQUESTTIMEOUTEnum = 32,
            
            /// <summary>
            /// Enum _409CONFLICTEnum for 409 CONFLICT
            /// </summary>
            [EnumMember(Value = "409 CONFLICT")]
            _409CONFLICTEnum = 33,
            
            /// <summary>
            /// Enum _410GONEEnum for 410 GONE
            /// </summary>
            [EnumMember(Value = "410 GONE")]
            _410GONEEnum = 34,
            
            /// <summary>
            /// Enum _411LENGTHREQUIREDEnum for 411 LENGTH_REQUIRED
            /// </summary>
            [EnumMember(Value = "411 LENGTH_REQUIRED")]
            _411LENGTHREQUIREDEnum = 35,
            
            /// <summary>
            /// Enum _412PRECONDITIONFAILEDEnum for 412 PRECONDITION_FAILED
            /// </summary>
            [EnumMember(Value = "412 PRECONDITION_FAILED")]
            _412PRECONDITIONFAILEDEnum = 36,
            
            /// <summary>
            /// Enum _413PAYLOADTOOLARGEEnum for 413 PAYLOAD_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "413 PAYLOAD_TOO_LARGE")]
            _413PAYLOADTOOLARGEEnum = 37,
            
            /// <summary>
            /// Enum _413REQUESTENTITYTOOLARGEEnum for 413 REQUEST_ENTITY_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "413 REQUEST_ENTITY_TOO_LARGE")]
            _413REQUESTENTITYTOOLARGEEnum = 38,
            
            /// <summary>
            /// Enum _414URITOOLONGEnum for 414 URI_TOO_LONG
            /// </summary>
            [EnumMember(Value = "414 URI_TOO_LONG")]
            _414URITOOLONGEnum = 39,
            
            /// <summary>
            /// Enum _414REQUESTURITOOLONGEnum for 414 REQUEST_URI_TOO_LONG
            /// </summary>
            [EnumMember(Value = "414 REQUEST_URI_TOO_LONG")]
            _414REQUESTURITOOLONGEnum = 40,
            
            /// <summary>
            /// Enum _415UNSUPPORTEDMEDIATYPEEnum for 415 UNSUPPORTED_MEDIA_TYPE
            /// </summary>
            [EnumMember(Value = "415 UNSUPPORTED_MEDIA_TYPE")]
            _415UNSUPPORTEDMEDIATYPEEnum = 41,
            
            /// <summary>
            /// Enum _416REQUESTEDRANGENOTSATISFIABLEEnum for 416 REQUESTED_RANGE_NOT_SATISFIABLE
            /// </summary>
            [EnumMember(Value = "416 REQUESTED_RANGE_NOT_SATISFIABLE")]
            _416REQUESTEDRANGENOTSATISFIABLEEnum = 42,
            
            /// <summary>
            /// Enum _417EXPECTATIONFAILEDEnum for 417 EXPECTATION_FAILED
            /// </summary>
            [EnumMember(Value = "417 EXPECTATION_FAILED")]
            _417EXPECTATIONFAILEDEnum = 43,
            
            /// <summary>
            /// Enum _418IAMATEAPOTEnum for 418 I_AM_A_TEAPOT
            /// </summary>
            [EnumMember(Value = "418 I_AM_A_TEAPOT")]
            _418IAMATEAPOTEnum = 44,
            
            /// <summary>
            /// Enum _419INSUFFICIENTSPACEONRESOURCEEnum for 419 INSUFFICIENT_SPACE_ON_RESOURCE
            /// </summary>
            [EnumMember(Value = "419 INSUFFICIENT_SPACE_ON_RESOURCE")]
            _419INSUFFICIENTSPACEONRESOURCEEnum = 45,
            
            /// <summary>
            /// Enum _420METHODFAILUREEnum for 420 METHOD_FAILURE
            /// </summary>
            [EnumMember(Value = "420 METHOD_FAILURE")]
            _420METHODFAILUREEnum = 46,
            
            /// <summary>
            /// Enum _421DESTINATIONLOCKEDEnum for 421 DESTINATION_LOCKED
            /// </summary>
            [EnumMember(Value = "421 DESTINATION_LOCKED")]
            _421DESTINATIONLOCKEDEnum = 47,
            
            /// <summary>
            /// Enum _422UNPROCESSABLEENTITYEnum for 422 UNPROCESSABLE_ENTITY
            /// </summary>
            [EnumMember(Value = "422 UNPROCESSABLE_ENTITY")]
            _422UNPROCESSABLEENTITYEnum = 48,
            
            /// <summary>
            /// Enum _423LOCKEDEnum for 423 LOCKED
            /// </summary>
            [EnumMember(Value = "423 LOCKED")]
            _423LOCKEDEnum = 49,
            
            /// <summary>
            /// Enum _424FAILEDDEPENDENCYEnum for 424 FAILED_DEPENDENCY
            /// </summary>
            [EnumMember(Value = "424 FAILED_DEPENDENCY")]
            _424FAILEDDEPENDENCYEnum = 50,
            
            /// <summary>
            /// Enum _426UPGRADEREQUIREDEnum for 426 UPGRADE_REQUIRED
            /// </summary>
            [EnumMember(Value = "426 UPGRADE_REQUIRED")]
            _426UPGRADEREQUIREDEnum = 51,
            
            /// <summary>
            /// Enum _428PRECONDITIONREQUIREDEnum for 428 PRECONDITION_REQUIRED
            /// </summary>
            [EnumMember(Value = "428 PRECONDITION_REQUIRED")]
            _428PRECONDITIONREQUIREDEnum = 52,
            
            /// <summary>
            /// Enum _429TOOMANYREQUESTSEnum for 429 TOO_MANY_REQUESTS
            /// </summary>
            [EnumMember(Value = "429 TOO_MANY_REQUESTS")]
            _429TOOMANYREQUESTSEnum = 53,
            
            /// <summary>
            /// Enum _431REQUESTHEADERFIELDSTOOLARGEEnum for 431 REQUEST_HEADER_FIELDS_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "431 REQUEST_HEADER_FIELDS_TOO_LARGE")]
            _431REQUESTHEADERFIELDSTOOLARGEEnum = 54,
            
            /// <summary>
            /// Enum _451UNAVAILABLEFORLEGALREASONSEnum for 451 UNAVAILABLE_FOR_LEGAL_REASONS
            /// </summary>
            [EnumMember(Value = "451 UNAVAILABLE_FOR_LEGAL_REASONS")]
            _451UNAVAILABLEFORLEGALREASONSEnum = 55,
            
            /// <summary>
            /// Enum _500INTERNALSERVERERROREnum for 500 INTERNAL_SERVER_ERROR
            /// </summary>
            [EnumMember(Value = "500 INTERNAL_SERVER_ERROR")]
            _500INTERNALSERVERERROREnum = 56,
            
            /// <summary>
            /// Enum _501NOTIMPLEMENTEDEnum for 501 NOT_IMPLEMENTED
            /// </summary>
            [EnumMember(Value = "501 NOT_IMPLEMENTED")]
            _501NOTIMPLEMENTEDEnum = 57,
            
            /// <summary>
            /// Enum _502BADGATEWAYEnum for 502 BAD_GATEWAY
            /// </summary>
            [EnumMember(Value = "502 BAD_GATEWAY")]
            _502BADGATEWAYEnum = 58,
            
            /// <summary>
            /// Enum _503SERVICEUNAVAILABLEEnum for 503 SERVICE_UNAVAILABLE
            /// </summary>
            [EnumMember(Value = "503 SERVICE_UNAVAILABLE")]
            _503SERVICEUNAVAILABLEEnum = 59,
            
            /// <summary>
            /// Enum _504GATEWAYTIMEOUTEnum for 504 GATEWAY_TIMEOUT
            /// </summary>
            [EnumMember(Value = "504 GATEWAY_TIMEOUT")]
            _504GATEWAYTIMEOUTEnum = 60,
            
            /// <summary>
            /// Enum _505HTTPVERSIONNOTSUPPORTEDEnum for 505 HTTP_VERSION_NOT_SUPPORTED
            /// </summary>
            [EnumMember(Value = "505 HTTP_VERSION_NOT_SUPPORTED")]
            _505HTTPVERSIONNOTSUPPORTEDEnum = 61,
            
            /// <summary>
            /// Enum _506VARIANTALSONEGOTIATESEnum for 506 VARIANT_ALSO_NEGOTIATES
            /// </summary>
            [EnumMember(Value = "506 VARIANT_ALSO_NEGOTIATES")]
            _506VARIANTALSONEGOTIATESEnum = 62,
            
            /// <summary>
            /// Enum _507INSUFFICIENTSTORAGEEnum for 507 INSUFFICIENT_STORAGE
            /// </summary>
            [EnumMember(Value = "507 INSUFFICIENT_STORAGE")]
            _507INSUFFICIENTSTORAGEEnum = 63,
            
            /// <summary>
            /// Enum _508LOOPDETECTEDEnum for 508 LOOP_DETECTED
            /// </summary>
            [EnumMember(Value = "508 LOOP_DETECTED")]
            _508LOOPDETECTEDEnum = 64,
            
            /// <summary>
            /// Enum _509BANDWIDTHLIMITEXCEEDEDEnum for 509 BANDWIDTH_LIMIT_EXCEEDED
            /// </summary>
            [EnumMember(Value = "509 BANDWIDTH_LIMIT_EXCEEDED")]
            _509BANDWIDTHLIMITEXCEEDEDEnum = 65,
            
            /// <summary>
            /// Enum _510NOTEXTENDEDEnum for 510 NOT_EXTENDED
            /// </summary>
            [EnumMember(Value = "510 NOT_EXTENDED")]
            _510NOTEXTENDEDEnum = 66,
            
            /// <summary>
            /// Enum _511NETWORKAUTHENTICATIONREQUIREDEnum for 511 NETWORK_AUTHENTICATION_REQUIRED
            /// </summary>
            [EnumMember(Value = "511 NETWORK_AUTHENTICATION_REQUIRED")]
            _511NETWORKAUTHENTICATIONREQUIREDEnum = 67
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [DataMember(Name="view")]
        public View View { get; set; }

        /// <summary>
        /// Gets or Sets ViewName
        /// </summary>
        [DataMember(Name="view_name")]
        public string ViewName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelAndView {\n");
            sb.Append("  Empty: ").Append(Empty).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  ModelMap: ").Append(ModelMap).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  View: ").Append(View).Append("\n");
            sb.Append("  ViewName: ").Append(ViewName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ModelAndView)obj);
        }

        /// <summary>
        /// Returns true if ModelAndView instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelAndView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelAndView other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Empty == other.Empty ||
                    Empty != null &&
                    Empty.Equals(other.Empty)
                ) && 
                (
                    Model == other.Model ||
                    Model != null &&
                    Model.Equals(other.Model)
                ) && 
                (
                    ModelMap == other.ModelMap ||
                    ModelMap != null &&
                    ModelMap.SequenceEqual(other.ModelMap)
                ) && 
                (
                    Reference == other.Reference ||
                    Reference != null &&
                    Reference.Equals(other.Reference)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    View == other.View ||
                    View != null &&
                    View.Equals(other.View)
                ) && 
                (
                    ViewName == other.ViewName ||
                    ViewName != null &&
                    ViewName.Equals(other.ViewName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Empty != null)
                    hashCode = hashCode * 59 + Empty.GetHashCode();
                    if (Model != null)
                    hashCode = hashCode * 59 + Model.GetHashCode();
                    if (ModelMap != null)
                    hashCode = hashCode * 59 + ModelMap.GetHashCode();
                    if (Reference != null)
                    hashCode = hashCode * 59 + Reference.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (View != null)
                    hashCode = hashCode * 59 + View.GetHashCode();
                    if (ViewName != null)
                    hashCode = hashCode * 59 + ViewName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ModelAndView left, ModelAndView right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ModelAndView left, ModelAndView right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
