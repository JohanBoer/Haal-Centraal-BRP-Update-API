/* 
 * BRP Update API
 *
 * Met deze API kun je opvragen welke door jou gevolgde personen zijn gewijzigd in de BRP. Je kunt je abonneren op een persoon die je wilt volgen, en je kunt opvragen welke personen door jou worden gevolgd. Je kunt deze API gebruiken in combinatie met de BRP bevragen API, bijvoorbeeld om lokale kopiegegevens actueel te houden.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Volgindicatie
    /// </summary>
    [DataContract]
    public partial class Volgindicatie :  IEquatable<Volgindicatie>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Volgindicatie" /> class.
        /// </summary>
        /// <param name="einddatum">Datum vanaf wanneer de volgindicatie niet meer actief zal zijn..</param>
        public Volgindicatie(DateTime einddatum = default(DateTime))
        {
            this.Einddatum = einddatum;
        }
        
        /// <summary>
        /// Datum vanaf wanneer de volgindicatie niet meer actief zal zijn.
        /// </summary>
        /// <value>Datum vanaf wanneer de volgindicatie niet meer actief zal zijn.</value>
        [DataMember(Name="einddatum", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Einddatum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Volgindicatie {\n");
            sb.Append("  Einddatum: ").Append(Einddatum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Volgindicatie);
        }

        /// <summary>
        /// Returns true if Volgindicatie instances are equal
        /// </summary>
        /// <param name="input">Instance of Volgindicatie to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Volgindicatie input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Einddatum == input.Einddatum ||
                    (this.Einddatum != null &&
                    this.Einddatum.Equals(input.Einddatum))
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
                int hashCode = 41;
                if (this.Einddatum != null)
                    hashCode = hashCode * 59 + this.Einddatum.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
