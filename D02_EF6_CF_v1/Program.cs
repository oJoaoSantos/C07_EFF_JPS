using D02_EF6_CF_v1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D02_EF6_CF_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUniCodeConsole();

            using (var db = new BlogContext())
            {
                #region Blog
                Blog blog01 = new Blog();

                // blog01.BlogId = 1;       -->  pela conveção é automático.
                blog01.Name = "Blog Teste 1";

                db.Blog.Add(blog01);

                db.SaveChanges();

                Utility.WriteTitle("Blogs");
                var queryBlog = db.Blog.Select(b => b).OrderBy(b => b.Name);
                queryBlog.ToList().ForEach(b => Console.WriteLine($"ID: {b.BlogId}\tName: {b.Name}"));
                #endregion

                #region Posts
                Post post01 = new Post();
                Post post02 = new Post();
                Post post03 = new Post();

                post01.BlogId = 9;
                post01.Title = "Post 01";
                post01.Content = "Post 01 Content ... ... ... ";

                post02.BlogId = 9;
                post02.Title = "Post 02";
                post02.Content = "Post 02 Content ... ... ... ";

                post03.BlogId = 9;
                post03.Title = "Post 03";
                post03.Content = "Post 03 Content ... ... ... ";

                db.Post.Add(post01);
                db.Post.Add(post02);
                db.Post.Add(post03);

                db.SaveChanges();

                Utility.BlockSeparator(2);
                Utility.WriteTitle("Posts");
                var queryPost = db.Post.Select(p => p).OrderBy(p => p.Title);
                queryPost.ToList().ForEach(p => Console.WriteLine($"ID: {p.PostId}\tBlog ID: {p.BlogId}\tTitle: {p.Title}\tContent: {p.Content}"));
                #endregion

            }

            Utility.TerminateConsole();
        }
    }
}
