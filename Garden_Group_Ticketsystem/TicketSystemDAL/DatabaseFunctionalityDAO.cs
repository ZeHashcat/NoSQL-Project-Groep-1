using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace TicketSystemDAL
{
    public class DatabaseFunctionalityDAO
    {
        private MongoClient databaseClient = new MongoClient("mongodb+srv://Hashcat:<LozEBY3XA38WHZEX>@ggticketsystemdb-g1.gri5vod.mongodb.net/?retryWrites=true&w=majority");

        public MongoClient DatabaseClient { get { return databaseClient; } }


    }
}
