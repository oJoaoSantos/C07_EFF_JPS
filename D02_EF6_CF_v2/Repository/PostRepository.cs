
using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace D02_EF6_CF_v2.Model
{
    public partial class Post
    {
        public void CreatePost(Post post, int blogId, string title, string content)
        {
            post.BlogId = blogId;
            post.Title = title;
            post.Content = content;
        }

        public void ReadPost()
        {
            Utility.BlockSeparator(2);
            Utility.WriteTitle("Posts");
            using (var db = new BlogContext())
            {
                var queryPost = db.Post.Select(p => p).OrderBy(p => p.Title);
                queryPost.ToList().ForEach(p => Console.WriteLine($"ID: {p.PostId}\tBlog ID: {p.BlogId}\tTitle: {p.Title}\tContent: {p.Content}"));
            }
        }

    }
}
