using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoApi
{
    public class ProductDetails
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("ProductName")]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        public string ProductStock { get; set; }
    }
}
