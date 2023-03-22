using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_EF6_CF.Model
{
    internal partial class Publisher
    {
        public void CreatePublisher(Publisher publisher, string name)
        {
            publisher.Name = name;
        }

        public void ReadPublishers()
        {
            Utility.WriteTitle("Publishers");
            using (var db = new DBContext())
            {
                var queryBlog = db.Publisher.Select(p => p).OrderBy(p => p.Name);
                queryBlog.ToList().ForEach(p => Console.WriteLine($"ID: {p.PublisherId}   |   Name: {p.Name}"));
            }
        }
    }
}
