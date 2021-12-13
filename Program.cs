using System;
using MongoDB.Driver;

namespace MongoDBConnectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MongoClient dbClient = new MongoClient("mongodb+srv://sa:admin123@cluster0.lftks.mongodb.net/Cluster0?retryWrites=true&w=majority");

            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }
        }

    }
}