using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    class Post
    {
        private int Id { get; set; }
        private string Author { get; set; }
        private string PostContent { get; set; }
        private DateTime DateOfPost { get; set; }

        public Post(int id, DateTime dateOfPost, params string[] args)
        {
            Id = id;
            Author = args[0];
            PostContent = args[1];
            DateOfPost = dateOfPost;
        }
    }
}
