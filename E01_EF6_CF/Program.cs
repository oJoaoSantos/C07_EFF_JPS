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

            using (var db = new DBContext())
            {
                #region Publisher
                Publisher publisher01 = new Publisher();
                Publisher publisher02 = new Publisher();

                //publisher01.CreatePublisher(publisher01, "Publisher Test 01");
                //publisher02.CreatePublisher(publisher02, "Publisher Test 02");

                //db.Publisher.Add(publisher01);
                //db.Publisher.Add(publisher02);

                //db.SaveChanges();

                publisher02.ReadPublishers();
                #endregion

                #region Book
                Book book01 = new Book();
                Book book02 = new Book();
                Book book03 = new Book();

                //book01.CreateBook(book01, 1, "978-3-16-148410-0", "Book Test 01", new DateTime(1995, 01, 01));
                //book02.CreateBook(book02, 2, "978-3-16-148410-1", "Book Test 02", new DateTime(1995, 01, 02));
                //book03.CreateBook(book03, 1, "978-3-16-148410-2", "Book Test 03", new DateTime(1995, 01, 03));

                //db.Book.Add(book01);
                //db.Book.Add(book02);
                //db.Book.Add(book03);

                //db.SaveChanges();
                
                book03.ReadBooks();
                #endregion
            }

            Utility.TerminateConsole();

        }
    }
}
