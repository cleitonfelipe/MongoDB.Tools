using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Authentication;

namespace MongoDB.Tools
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = $@"mongodb://poc-cosmo-db:lujwqRyLNdWbpkxRaMy8Co6nwWIB8M3bTkisxJgdGyh5q6eEh9BfGbgDX4rMQex2xNaIZhciWl4fFVZNV2BPTw==@poc-cosmo-db.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
            MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
            var client = new MongoClient(settings);

            //BsonClassMap.RegisterClassMap<Admissao>(cm => {
            //    cm.AutoMap();
            //    cm.GetMemberMap(c => c.comments).;
            //});

            var database = client.GetDatabase("AdmissaoDigital");
            var Collection = database.GetCollection<Admissao>("ContratosAdmissao");

            var dados = Collection.Find(new BsonDocument()).ToList();

            //StreamWriter streamWriter = new StreamWriter(@"C:\Users\omehe\Desktop\FileMongo\scriptBackup.json");

            //foreach (var item in dados)
            //{
            //    streamWriter.WriteLine(item.ToJson());
            //}

            //streamWriter.Close();
        }
    }
}
