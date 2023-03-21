using D00_Utility;
using D02_EF6_CF_v2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CFv2
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

                blog01.CreateBlog(blog01, "Blog Test 02");
                db.Blog.Add(blog01);
                db.SaveChanges();

                blog01.ListBlog();
                #endregion

                #region Posts
                Post post01 = new Post();
                Post post02 = new Post();
                Post post03 = new Post();

                post01.CreatePost(post01, 2, "Post 04", "Post 04 Content ... ... ... ");
                post02.CreatePost(post02, 2, "Post 05", "Post 05 Content ... ... ... ");
                post03.CreatePost(post03, 2, "Post 06", "Post 06 Content ... ... ... ");

                db.Post.Add(post01);
                db.Post.Add(post02);
                db.Post.Add(post03);

                db.SaveChanges();

                post03.ListPost();
                #endregion
            }

            Utility.TerminateConsole();

        }
    }
}
