using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Grupp2.Models;

    /// <summary>
    /// Address model containing properties of city, zip, street and number
    /// </summary>
public class Address {

    [BsonElement("city")]
    [JsonPropertyName("city")]

    public string? City { get; set; }

    [BsonElement("zip")]
    [JsonPropertyName("zip")]
    public int Zip { get; set; }

     [BsonElement("street")]
    [JsonPropertyName("street")]
    public string? Street { get; set; }

     [BsonElement("number")]
    [JsonPropertyName("number")]
    public int Number { get; set; }

}
