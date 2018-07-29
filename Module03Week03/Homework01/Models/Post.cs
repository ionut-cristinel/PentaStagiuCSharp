using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework01.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }
        public Language Language { get; set; }
        public string Author { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}