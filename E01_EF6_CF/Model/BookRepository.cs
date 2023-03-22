using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_EF6_CF.Model
{
    internal partial class Book
    {
        public void CreateBook(Book book, int publisherId, string isbn, string title, DateTime date)
        {
            book.PublisherId = publisherId;
            book.ISBN= isbn;
            book.Title = title;
            book.Date = date;
        }

        public void ReadBooks()
        {
            Utility.WriteTitle("Books");
            using (var db = new DBContext())
            {
                var queryBlog = db.Book.Select(b => b).OrderBy(b => b.Title);
                queryBlog.ToList().ForEach(b => Console.WriteLine($"ID: {b.PublisherId}\t|\tISBN: {b.ISBN.ToUpper()}\t|\tTitle: {b.Title}\t|\tDate: {b.Date.ToShortDateString()}"));
            }
        }
    }
}
