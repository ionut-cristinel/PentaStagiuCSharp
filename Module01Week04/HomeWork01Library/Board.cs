using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork01Library;

namespace HomeWork01Library
{
    // clasa care se ocupa de crearea si afisarea postarilor
    public class Board
    {
        // lista in care sunt adaugate postarile userilor
        private static List<Post> AllPosts = new List<Post>();
        // id-ul postarilor
        private static int NextId = 1;
        // autorul postarilor
        private UserService Author;

        // constructor care seteaza valoare pentru proprietatea Autor
        public Board(UserService author)
        {
            Author = author;
        }

        // constructor care executa codul aferent comenzilor date user
        public Board(string command)
        {
            switch (command)
            {
                case "create post":
                    AddPost();
                    break;
                case "display post":
                    DisplayAllPosts();
                    break;
            }
        }

        // metoda care afiseaza postarile
        // afisarea se face dupa data in ordine descrescatoare
        private void DisplayAllPosts()
        {
            if (AllPosts.Count == 0)
            {
                Console.WriteLine("  There is no post.\n");
                return;
            }

            // postarile sunt sortate dupa data la care au fost create
            AllPosts.Sort();
            // este inversata ordinea de afisare, pentru ca cele mai recente sa fie afisate primele
            AllPosts.Reverse();

            foreach (Post post in AllPosts)
            {
                Console.WriteLine($"\n");
                Console.WriteLine($"  {post.Id} /  {post.Author}");
                Console.WriteLine($"  {post.PostContent}");
                Console.WriteLine($"  {post.DateOfPost}");
                Console.WriteLine($"  ____________________________________");
            }
            Console.WriteLine("\n");
        }

        // metoda care adauga o postare noua
        private void AddPost()
        {
            // se verifica daca user-ul este conectat
            // doar persoanele conectate pot adauga postari
            UserService isLogged = new UserService();
            string author = isLogged.GetLoggedUser();
            if (author.ToLower() == "false")
            {
                Console.WriteLine("  You must be logged in to write a post.\n");
                return;
            }
            // daca userul este logat se citeste textul postari si daca este unul valid se adauga in lista AllPosts o postare noua
            Console.WriteLine("\n  Add your post here:");
            string userInput;
            while (true)
            {
                userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput.Trim()))
                {
                    Console.WriteLine("  Invalid value, try again.");
                    continue;
                }
                break;
            }
            DateTime time = DateTime.Now;
            Post newPost = new Post(NextId++, time.ToLongTimeString(), author, userInput);
            AllPosts.Add(newPost);
            Console.WriteLine("  Posting successfully created.\n");
        }
    }
}
