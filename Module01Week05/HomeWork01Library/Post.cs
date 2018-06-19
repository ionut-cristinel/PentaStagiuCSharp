using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa care contine proprietatile unei postari
    public class Post
    {
        // id-ul postarilor
        public short Id { get; private set; }
        // autorul postarilor
        public string Author { get; private set; }
        // textul postarilor
        public string TextOfPost { get; private set; }
        // data postarilor
        public DateTime DateOfPost { get; private set; }

        public Post(short id, params string[] args)
        {
            Id = id;
            Author = args[0];
            TextOfPost = args[1];
            DateOfPost = DateTime.Now;
        }
    }
}
