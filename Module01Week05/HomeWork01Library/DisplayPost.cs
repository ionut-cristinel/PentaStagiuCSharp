using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa DisplayPost este responsabila de afisarea postarilor in consola
    public static class DisplayPost
    {
        // metoda care afiseaza o postare dupa id
        public static void DisplayPostById(Post post)
        {
            if (post != null)
            {
                Console.WriteLine($"  > ({UserService.UserConnected}): \n");
                Console.WriteLine($"  > ({UserService.UserConnected}): {post.Id}");
                Console.WriteLine($"  > ({UserService.UserConnected}): {post.TextOfPost}");
                Console.WriteLine($"  > ({UserService.UserConnected}): {post.Author}   {post.DateOfPost.ToShortDateString()}");
                Console.WriteLine($"  > ({UserService.UserConnected}): ---------------------\n");
            }
            else
            {
                StandardMessages.NullIdPost(UserService.UserConnected);
            }
        }

        // metoda care afiseaza toate postarile
        public static void DisplayAllPosts(Post[] posts)
        {
            for (short i = 0; i < posts.Length; i++)
            {
                if (posts[i] != null)
                {
                    Console.WriteLine($"  > ({UserService.UserConnected}): \n");
                    Console.WriteLine($"  > ({UserService.UserConnected}): {posts[i].Id}");
                    Console.WriteLine($"  > ({UserService.UserConnected}): {posts[i].TextOfPost}");
                    Console.WriteLine($"  > ({UserService.UserConnected}): {posts[i].Author}   {posts[i].DateOfPost.ToShortDateString()}");
                    Console.WriteLine($"  > ({UserService.UserConnected}): ---------------------");
                }
            }
        }
    }
}
