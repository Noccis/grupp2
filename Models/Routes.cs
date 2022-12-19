using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Grupp2.Models;

#pragma warning disable CS1591
public class Routes
{

    [BsonRepresentation(BsonType.ObjectId)]
    [BsonId]
    public string? Id { get; set; }

    [BsonElement("airline")]
    [JsonPropertyName("airline")]
    public Airline Airline { get; set; } = null!;



    [BsonElement("src_airport")]
    [JsonPropertyName("src_airport")]
    public string? Src_airport { get; set; } = null!;

    [BsonElement("dst_airport")]
    [JsonPropertyName("dst_airport")]
    public string? Dst_airport { get; set; } = null!;

    [BsonElement("codeshare")]
    [JsonPropertyName("codeshare")]
    public string? Codeshare { get; set; } = null!;

    [BsonElement("stops")]
    [JsonPropertyName("stops")]
    public int Stops { get; set; }


    [BsonElement("airplane")]
    [JsonPropertyName("airplane")]
    public string Airplane { get; set; } = null!;




}
#pragma warning restore CS1591