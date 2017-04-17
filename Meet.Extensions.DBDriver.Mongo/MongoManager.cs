using MongoDB.Driver;

namespace Meet.Extensions.DBDriver.Mongo
{
    internal class MongoManager
    {
        private MongoClient client;
        private object obj = new object();

        internal MongoClient GetClient(string connString)
        {
            if (client == null)
            {
                lock (obj)
                {
                    if (client == null)
                    {
                        client = new MongoClient(connString);
                    }
                }
            }
            return client;
        }
    }
}
