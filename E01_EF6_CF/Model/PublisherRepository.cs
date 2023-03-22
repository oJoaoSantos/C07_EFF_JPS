using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_EF6_CF.Model
{
    internal partial class Publisher
    {
        public void CreatePublisher(Publisher publisher, string name)
        {
            bool ValidatePublisherName()
            {
                using (var db = new DBContext())
                {
                    var validateQuery = db.Publisher.Select(p => p.Name).ToList();
                    bool exists = validateQuery.Exists(p => p == name);
                    return exists;
                }
            }

            Utility.WriteTitle("Publishers");
            Utility.BlockSeparator(1);

            bool notValid = ValidatePublisherName();
            if (notValid)
            {
                Console.WriteLine("Invalid Publisher Name.");
            }
            else
            {
                publisher.Name = name;

                using (var db = new DBContext())
                {
                    db.Publisher.Add(publisher);
                    db.SaveChanges();
                }
            }
        }

        public void ReadPublishers()
        {
            Utility.BlockSeparator(1);

            using (var db = new DBContext())
            {
                var queryBlog = db.Publisher.Select(p => p).OrderBy(p => p.Name);
                queryBlog.ToList().ForEach(p => Console.WriteLine($"ID: {p.PublisherId}   |   Name: {p.Name}"));
            }
        }
    }
}
