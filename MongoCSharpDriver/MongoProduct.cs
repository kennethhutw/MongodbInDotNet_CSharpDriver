using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MongoDB.Bson;

namespace MongoCSharpDriver
{
    public class MongoProduct
    {
        public ObjectId _id { get; set; }
        public string ID { get; set; }
        public string ProductName { get; set; }
        public string Quantity { get; set; }
    }
}