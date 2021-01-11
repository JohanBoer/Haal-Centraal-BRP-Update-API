/*
 * BRP Update API
 * Met deze API kun je opvragen welke door jou gevolgde personen zijn gewijzigd in de BRP. Je kunt je abonneren op een persoon die je wilt volgen, en je kunt opvragen welke personen door jou worden gevolgd. Je kunt deze API gebruiken in combinatie met de BRP bevragen API, bijvoorbeeld om lokale kopiegegevens actueel te houden.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * VolgindicatieRaadplegenAllOf
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-01-06T08:32:33.412Z[Etc/UTC]")
public class VolgindicatieRaadplegenAllOf {
  public static final String SERIALIZED_NAME_BURGERSERVICENUMMER = "burgerservicenummer";
  @SerializedName(SERIALIZED_NAME_BURGERSERVICENUMMER)
  private String burgerservicenummer;


  public VolgindicatieRaadplegenAllOf burgerservicenummer(String burgerservicenummer) {
    
    this.burgerservicenummer = burgerservicenummer;
    return this;
  }

   /**
   * Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.
   * @return burgerservicenummer
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Identificerend gegeven van een ingeschreven natuurlijk persoon, als bedoeld in artikel 1.1 van de Wet algemene bepalingen burgerservicenummer.")

  public String getBurgerservicenummer() {
    return burgerservicenummer;
  }


  public void setBurgerservicenummer(String burgerservicenummer) {
    this.burgerservicenummer = burgerservicenummer;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    VolgindicatieRaadplegenAllOf volgindicatieRaadplegenAllOf = (VolgindicatieRaadplegenAllOf) o;
    return Objects.equals(this.burgerservicenummer, volgindicatieRaadplegenAllOf.burgerservicenummer);
  }

  @Override
  public int hashCode() {
    return Objects.hash(burgerservicenummer);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class VolgindicatieRaadplegenAllOf {\n");
    sb.append("    burgerservicenummer: ").append(toIndentedString(burgerservicenummer)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

