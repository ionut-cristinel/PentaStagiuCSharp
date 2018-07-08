using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework01.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime TimeOfPosting { get; set; }
        public string MessageContent { get; set; }
        public PostType PostType { get; set; }
        public bool IsSticky { get; set; }
        public int Priority { get; set; }
    }

    public enum PostType
    {
        Text,
        Photo
    }
}
// Id(int)
// UserId(int)
// TimeOfPosting(DateTime)
// Message(string)
// PostType(Enum with 2 values: Text and Photo)
// IsSticky(bool)
// Priority(int – optional with values ranging from 1 to 5)