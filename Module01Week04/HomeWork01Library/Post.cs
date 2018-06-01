using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa post mosteneste interfata IComparable pentru a putea sorta postarile dupa data
    class Post : IComparable<Post>
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string PostContent { get; set; }
        public string DateOfPost { get; set; }

        public Post(int id, params string[] args)
        {
            Id = id;
            DateOfPost = args[0];
            Author = args[1];
            PostContent = args[2];
        }

        // este implementata metoda interfetei, CompareTo()
        public int CompareTo(Post other)
        {
            return this.DateOfPost.CompareTo(other.DateOfPost);
        }
    }
}
