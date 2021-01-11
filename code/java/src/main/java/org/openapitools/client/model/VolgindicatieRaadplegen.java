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
import java.time.LocalDate;
import org.openapitools.client.model.Volgindicatie;
import org.openapitools.client.model.VolgindicatieRaadplegenAllOf;

/**
 * VolgindicatieRaadplegen
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-01-11T10:01:27.106Z[Etc/UTC]")
public class VolgindicatieRaadplegen {
  public static final String SERIALIZED_NAME_EINDDATUM = "einddatum";
  @SerializedName(SERIALIZED_NAME_EINDDATUM)
  private LocalDate einddatum;

  public static final String SERIALIZED_NAME_BURGERSERVICENUMMER = "burgerservicenummer";
  @SerializedName(SERIALIZED_NAME_BURGERSERVICENUMMER)
  private String burgerservicenummer;


  public VolgindicatieRaadplegen einddatum(LocalDate einddatum) {
    
    this.einddatum = einddatum;
    return this;
  }

   /**
   * Datum vanaf wanneer de volgindicatie niet meer actief zal zijn.
   * @return einddatum
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Datum vanaf wanneer de volgindicatie niet meer actief zal zijn.")

  public LocalDate getEinddatum() {
    return einddatum;
  }


  public void setEinddatum(LocalDate einddatum) {
    this.einddatum = einddatum;
  }


  public VolgindicatieRaadplegen burgerservicenummer(String burgerservicenummer) {
    
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
    VolgindicatieRaadplegen volgindicatieRaadplegen = (VolgindicatieRaadplegen) o;
    return Objects.equals(this.einddatum, volgindicatieRaadplegen.einddatum) &&
        Objects.equals(this.burgerservicenummer, volgindicatieRaadplegen.burgerservicenummer);
  }

  @Override
  public int hashCode() {
    return Objects.hash(einddatum, burgerservicenummer);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class VolgindicatieRaadplegen {\n");
    sb.append("    einddatum: ").append(toIndentedString(einddatum)).append("\n");
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

