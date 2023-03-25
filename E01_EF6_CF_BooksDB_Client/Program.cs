using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_EF6_CF_BooksDB_Client
{

    internal class Program
    {

        static void Main(string[] args)
        {

            BooksDBClient.CreatePublisher();
            BooksDBClient.CreateBook();

            Console.Write("Data entered successfully.");

            Console.ReadKey();

        }

    }

}
