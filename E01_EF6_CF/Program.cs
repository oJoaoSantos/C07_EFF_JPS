using D00_Utility;
using E01_EF6_CF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_EF6_CF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            #region Publisher
            Publisher publisher = new Publisher();

            publisher.CreatePublisher(publisher, "Publisher Test 04");
            publisher.ReadPublishers();
            #endregion

            #region Book
            Book book = new Book();

            book.CreateBook(book, 3, "978-3-16-148410-3", "Book Test 04", new DateTime(1995, 01, 04));
            book.ReadBooks();
            #endregion

            Utility.TerminateConsole();

        }
    }
}
