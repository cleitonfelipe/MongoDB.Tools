using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace MongoDB.Tools
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = $@"<connectionstring>";
            string pathToCAFile = @"<path/certicate file>";

            X509Store localTrustStore = new X509Store(StoreName.Root);
            X509Certificate2Collection certificateCollection = new X509Certificate2Collection();
            //certificateCollection.Import(pathToCAFile);
            certificateCollection.ImportFromPem(pathToCAFile);
            //var cert = new X509Certificate2(pathToCAFile);

            try
            {
                localTrustStore.Open(OpenFlags.ReadWrite);
                localTrustStore.AddRange(certificateCollection);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Root certificate import failed: " + ex.Message);
                throw;
            }
            finally
            {
                localTrustStore.Close();
            }

            MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            settings.SslSettings = new SslSettings
            {
                EnabledSslProtocols = SslProtocols.Tls12,
                ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return certificate.GetCertHashString() == "<Hexadecimal Certificate hash value>";
                }
            };
            var client = new MongoClient(settings);

            var database = client.GetDatabase("<DatabaseName>");
            var Collection = database.GetCollection<Model>("ColletionName");

            try
            {
                var dados = Collection.Find(new BsonDocument()).CountDocuments();

                Console.WriteLine($"{dados}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
