using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa Factory creaza obiectele Brain, User, UserService si Post
    public static class Factory
    {
        public static Brain CreateBrain()
        {
            return new Brain();
        }

        internal static User CreateUser(int id, DateTime birthDate, params string[] args)
        {
            return new User(id, birthDate, args);
        }

        public static UserService CreateUserService()
        {
            return new UserService();
        }

        public static MessageBoard CreateMessageBoard()
        {
            return new MessageBoard();
        }

        internal static Post CreatePost(short id, params string[] args)
        {
            return new Post(id, args);
        }
    }
}