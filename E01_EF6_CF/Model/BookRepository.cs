using D00_Utility;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace E01_EF6_CF.Model
{
    internal partial class Book
    {
        public void CreateBook(Book book, int publisherId, string isbn, string title, DateTime date)
        {
            bool ValidatePublisherId()
            {
                using (var db = new DBContext())
                {
                    var validateQuery = db.Publisher.Select(p => p.PublisherId).ToList();
                    bool exists = validateQuery.Exists(p => p == publisherId);
                    return exists;
                }
            }

            Utility.BlockSeparator(2);
            Utility.WriteTitle("Books");
            Utility.BlockSeparator(1);


            bool valid = ValidatePublisherId();
            if (valid)
            {
                book.PublisherId = publisherId;
                book.ISBN = isbn;
                book.Title = title;
                book.Date = date;

                using (var db = new DBContext())
                {
                    db.Book.Add(book);
                    db.SaveChanges();
                }
            }
            else
            {
                Console.WriteLine("Invalid Publisher Id.");
            }
        }

        public void ReadBooks()
        {
            Utility.BlockSeparator(1);
            using (var db = new DBContext())
            {
                var queryBlog = db.Book.Select(b => b).OrderBy(b => b.Title);
                queryBlog.ToList().ForEach(b => Console.WriteLine($"Book ID: {b.BookId}   |   Publisher ID: {b.PublisherId}   |   ISBN: {b.ISBN.ToUpper()}   |   Title: {b.Title}   |   Date: {b.Date.ToShortDateString()}"));
            }
        }
    }
}
