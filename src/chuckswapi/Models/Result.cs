/*
 * Chuck SWAPI API
 *
 * .NET CORE C# Chuck SWAPI Project API.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: don@obeyi.com
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

namespace chuckswapi.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Result : IEquatable<Result>
    { 
        /// <summary>
        /// Data Source is the Star Wars API
        /// </summary>
        /// <value>Data Source is the Star Wars API</value>
        [DataMember(Name="people")]
        public List<People> People { get; set; }

        /// <summary>
        /// Source is the Chuck Norris API
        /// </summary>
        /// <value>Source is the Chuck Norris API</value>
        [DataMember(Name="jokes")]
        public List<Jokes> Jokes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Result {\n");
            sb.Append("  People: ").Append(People).Append("\n");
            sb.Append("  Jokes: ").Append(Jokes).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Result)obj);
        }

        /// <summary>
        /// Returns true if Result instances are equal
        /// </summary>
        /// <param name="other">Instance of Result to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Result other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    People == other.People ||
                    People != null &&
                    People.SequenceEqual(other.People)
                ) && 
                (
                    Jokes == other.Jokes ||
                    Jokes != null &&
                    Jokes.SequenceEqual(other.Jokes)
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
                    if (People != null)
                    hashCode = hashCode * 59 + People.GetHashCode();
                    if (Jokes != null)
                    hashCode = hashCode * 59 + Jokes.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Result left, Result right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Result left, Result right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
