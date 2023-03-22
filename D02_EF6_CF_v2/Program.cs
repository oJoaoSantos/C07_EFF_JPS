// SQL DML: Data manipulation Language --> SELECT, INSERT, UPDATE, DELETE

// CRUD Operations --> CREATE, READ, UPDATE, DELETE

using D00_Utility;
using D02_EF6_CF_v2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CF_v2
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

                blog01.CreateBlog(blog01, "Blog Test 03");
                db.Blog.Add(blog01);
                db.SaveChanges();

                blog01.ReadBlog();
                #endregion

                #region Posts
                Post post01 = new Post();
                Post post02 = new Post();
                Post post03 = new Post();

                post01.CreatePost(post01, 3, "Post 07", "Post 07 Content ... ... ... ");
                post02.CreatePost(post02, 3, "Post 08", "Post 08 Content ... ... ... ");
                post03.CreatePost(post03, 3, "Post 09", "Post 09 Content ... ... ... ");

                db.Post.Add(post01);
                db.Post.Add(post02);
                db.Post.Add(post03);

                db.SaveChanges();

                post03.ReadPost();
                #endregion
            }

            Utility.TerminateConsole();

        }
    }
}
