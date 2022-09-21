using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace TicketSystemDAL
{
    public class DatabaseDebugDAO : DatabaseFunctionalityDAO
    {
        private List<MongoDB.Bson.BsonDocument> databaseList;

        public List<MongoDB.Bson.BsonDocument> DatabaseList { get { return databaseList; } }

        public DatabaseDebugDAO()
        {
            databaseList = DatabaseClient.ListDatabases().ToList();
        }

        public void PrintDatabaseList()
        {
            foreach(MongoDB.Bson.BsonDocument bsonDocument in DatabaseList)
            {
                Console.WriteLine(bsonDocument);
            }
        }
        
    }
}
