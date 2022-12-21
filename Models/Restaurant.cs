using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Grupp2.Models;

    /// <summary>
    /// Model for Restaurant document
    /// </summary>

public class Restaurant {

    /// <summary>
    /// Creates an unique id for each restaurant object
    /// </summary>

    //id field is to be represented as an ObjectId in BSON in mongoDB
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? _id { get; set; }

    // has no custom mapping will be borough in JSON and in mongoDB
    public string borough { get; set;} = null!;

    //has no custom mapping will be cuisine in JSON and in mongoDB
    public string cuisine { get; set; } = null!;

    //has no custom mapping just a list of menuItems in mongoDB
    public List<string> menuItems { get; set; } = null!;

    /// <summary>
    /// referance for the database and model to communicate through
    /// </summary>
    [BsonElement("coordinates")]
    [JsonPropertyName("coordinates")]
    public Coordinates Coordinates {get; set;} = null!;

}
