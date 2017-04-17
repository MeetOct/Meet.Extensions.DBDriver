using System;

namespace Meet.Extensions.DBDriver.Mongo
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class MongoAttribute : Attribute
    {
        public string Database { get; set; } = string.Empty;
        public string Collection { get; set; } = string.Empty;
        public MongoAttribute(string database, string collection)
        {
            Database = database;
            Collection = collection;
        }
    }
}
