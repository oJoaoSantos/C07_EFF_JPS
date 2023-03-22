using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D02_EF6_CF_v2.Model
{
    public partial class Blog
    {
        public void CreateBlog(Blog blog, string name)
        {
            blog.Name = name;            
        }

        public void ListBlog()
        {
            using (var db = new BlogContext())
            {
                Utility.WriteTitle("Blogs");
                var queryBlog = db.Blog.Select(b => b).OrderBy(b => b.Name);
                queryBlog.ToList().ForEach(b => Console.WriteLine($"ID: {b.BlogId}\tName: {b.Name}"));
            }
        }

    }
}
