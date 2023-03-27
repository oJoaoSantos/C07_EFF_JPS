using D04_EF6_Migrations_DAL;

namespace D04_EF6_Migrations_Client
{

    static class BooksDBClient
    {
        #region Create
        public static void CreateDDC()
        {

            DaweyDecimalClassification ddc = new DaweyDecimalClassification
            {
                DDCCode = "000",
                DDCClassification = "Computer science, information and general works"
            };

            using (var context = new BookDBContext())
            {
                context.DaweyDecimalClassification.Add(ddc);
                context.SaveChanges();
            }

        }
        public static void CreatePublisher()
        {

            Publisher publisher = new Publisher
            {
                Name = "New publisher"
            };

            using (var context = new BookDBContext())
            {
                context.Publisher.Add(publisher);
                context.SaveChanges();
            }

        }

        public static void CreateBook()
        {

            Book book = new Book
            {
                PublisherID = 1,
                DaweyDecimalClassificationID = 1,
                Title = "New book",
                ISBN = "123456789"
            };

            using (var context = new BookDBContext())
            {
                context.Book.Add(book);
                context.SaveChanges();
            }

        }
        #endregion

        #region Read

        #endregion

        #region Update

        #endregion

        #region Delete

        #endregion


    }

}
