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
    public partial class People : IEquatable<People>
    { 
        /// <summary>
        /// Boba Fett
        /// </summary>
        /// <value>Boba Fett</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// 183 (number)
        /// </summary>
        /// <value>183 (number)</value>
        [DataMember(Name="height")]
        public decimal? Height { get; set; }

        /// <summary>
        /// 78.2 (number)
        /// </summary>
        /// <value>78.2 (number)</value>
        [DataMember(Name="mass")]
        public decimal? Mass { get; set; }

        /// <summary>
        /// black
        /// </summary>
        /// <value>black</value>
        [DataMember(Name="hair_color")]
        public string HairColor { get; set; }

        /// <summary>
        /// fair
        /// </summary>
        /// <value>fair</value>
        [DataMember(Name="skin_color")]
        public string SkinColor { get; set; }

        /// <summary>
        /// brown
        /// </summary>
        /// <value>brown</value>
        [DataMember(Name="eye_color")]
        public string EyeColor { get; set; }

        /// <summary>
        /// 31.5BBY
        /// </summary>
        /// <value>31.5BBY</value>
        [DataMember(Name="birth_year")]
        public string BirthYear { get; set; }

        /// <summary>
        /// male
        /// </summary>
        /// <value>male</value>
        [DataMember(Name="gender")]
        public string Gender { get; set; }

        /// <summary>
        /// http://swapi.dev/api/planets/10/
        /// </summary>
        /// <value>http://swapi.dev/api/planets/10/</value>
        [DataMember(Name="homeworld")]
        public string Homeworld { get; set; }

        /// <summary>
        /// Gets or Sets Films
        /// </summary>
        [DataMember(Name="films")]
        public List<string> Films { get; set; }

        /// <summary>
        /// Gets or Sets Species
        /// </summary>
        [DataMember(Name="species")]
        public List<string> Species { get; set; }

        /// <summary>
        /// Gets or Sets Vehicles
        /// </summary>
        [DataMember(Name="vehicles")]
        public List<string> Vehicles { get; set; }

        /// <summary>
        /// Gets or Sets Starships
        /// </summary>
        [DataMember(Name="starships")]
        public List<string> Starships { get; set; }

        /// <summary>
        /// 2014-12-15T12:49:32.457000Z
        /// </summary>
        /// <value>2014-12-15T12:49:32.457000Z</value>
        [DataMember(Name="created")]
        public string Created { get; set; }

        /// <summary>
        /// 2014-12-20T21:17:50.349000Z
        /// </summary>
        /// <value>2014-12-20T21:17:50.349000Z</value>
        [DataMember(Name="edited")]
        public string Edited { get; set; }

        /// <summary>
        /// http://swapi.dev/api/people/22/
        /// </summary>
        /// <value>http://swapi.dev/api/people/22/</value>
        [DataMember(Name="url")]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class People {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Mass: ").Append(Mass).Append("\n");
            sb.Append("  HairColor: ").Append(HairColor).Append("\n");
            sb.Append("  SkinColor: ").Append(SkinColor).Append("\n");
            sb.Append("  EyeColor: ").Append(EyeColor).Append("\n");
            sb.Append("  BirthYear: ").Append(BirthYear).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Homeworld: ").Append(Homeworld).Append("\n");
            sb.Append("  Films: ").Append(Films).Append("\n");
            sb.Append("  Species: ").Append(Species).Append("\n");
            sb.Append("  Vehicles: ").Append(Vehicles).Append("\n");
            sb.Append("  Starships: ").Append(Starships).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Edited: ").Append(Edited).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return obj.GetType() == GetType() && Equals((People)obj);
        }

        /// <summary>
        /// Returns true if People instances are equal
        /// </summary>
        /// <param name="other">Instance of People to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(People other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Height == other.Height ||
                    Height != null &&
                    Height.Equals(other.Height)
                ) && 
                (
                    Mass == other.Mass ||
                    Mass != null &&
                    Mass.Equals(other.Mass)
                ) && 
                (
                    HairColor == other.HairColor ||
                    HairColor != null &&
                    HairColor.Equals(other.HairColor)
                ) && 
                (
                    SkinColor == other.SkinColor ||
                    SkinColor != null &&
                    SkinColor.Equals(other.SkinColor)
                ) && 
                (
                    EyeColor == other.EyeColor ||
                    EyeColor != null &&
                    EyeColor.Equals(other.EyeColor)
                ) && 
                (
                    BirthYear == other.BirthYear ||
                    BirthYear != null &&
                    BirthYear.Equals(other.BirthYear)
                ) && 
                (
                    Gender == other.Gender ||
                    Gender != null &&
                    Gender.Equals(other.Gender)
                ) && 
                (
                    Homeworld == other.Homeworld ||
                    Homeworld != null &&
                    Homeworld.Equals(other.Homeworld)
                ) && 
                (
                    Films == other.Films ||
                    Films != null &&
                    Films.SequenceEqual(other.Films)
                ) && 
                (
                    Species == other.Species ||
                    Species != null &&
                    Species.SequenceEqual(other.Species)
                ) && 
                (
                    Vehicles == other.Vehicles ||
                    Vehicles != null &&
                    Vehicles.SequenceEqual(other.Vehicles)
                ) && 
                (
                    Starships == other.Starships ||
                    Starships != null &&
                    Starships.SequenceEqual(other.Starships)
                ) && 
                (
                    Created == other.Created ||
                    Created != null &&
                    Created.Equals(other.Created)
                ) && 
                (
                    Edited == other.Edited ||
                    Edited != null &&
                    Edited.Equals(other.Edited)
                ) && 
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Height != null)
                    hashCode = hashCode * 59 + Height.GetHashCode();
                    if (Mass != null)
                    hashCode = hashCode * 59 + Mass.GetHashCode();
                    if (HairColor != null)
                    hashCode = hashCode * 59 + HairColor.GetHashCode();
                    if (SkinColor != null)
                    hashCode = hashCode * 59 + SkinColor.GetHashCode();
                    if (EyeColor != null)
                    hashCode = hashCode * 59 + EyeColor.GetHashCode();
                    if (BirthYear != null)
                    hashCode = hashCode * 59 + BirthYear.GetHashCode();
                    if (Gender != null)
                    hashCode = hashCode * 59 + Gender.GetHashCode();
                    if (Homeworld != null)
                    hashCode = hashCode * 59 + Homeworld.GetHashCode();
                    if (Films != null)
                    hashCode = hashCode * 59 + Films.GetHashCode();
                    if (Species != null)
                    hashCode = hashCode * 59 + Species.GetHashCode();
                    if (Vehicles != null)
                    hashCode = hashCode * 59 + Vehicles.GetHashCode();
                    if (Starships != null)
                    hashCode = hashCode * 59 + Starships.GetHashCode();
                    if (Created != null)
                    hashCode = hashCode * 59 + Created.GetHashCode();
                    if (Edited != null)
                    hashCode = hashCode * 59 + Edited.GetHashCode();
                    if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(People left, People right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(People left, People right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
