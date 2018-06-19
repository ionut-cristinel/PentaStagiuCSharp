using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // clasa partiala MessageBoard implementeaza interfata IPost
    // clasa este responsabila de actiunile pe care userul le poate face cu o postare
    public partial class MessageBoard : IPost
    {
        public delegate void UserNotConnectedDelegate();
        public event UserNotConnectedDelegate UserNotConnected;

        public delegate void ShowPostByIdDelegate(Post post);
        public event ShowPostByIdDelegate ShowPostById;

        public delegate void ShowAllPostsDelegate(Post[] posts);
        public event ShowAllPostsDelegate ShowAllPosts;

        // array care va primi toate postarile create
        public Post[] AllPost = new Post[15];

        // indexer utilizat pentru a accesa o postare dupa id si pentru a adauga o postare noua in AllPost
        public Post this[short id]
        {
            get
            {
                return AllPost[id];
            }
            set
            {
                AllPost[id] = value;
            }
        }

        // afiseaza toate postarile
        public void ShowAllPost()
        {
            if (UserService.UserConnected == null)
            {
                OnUserNotConnected();
                return;
            }
            OnShowAllPosts(AllPost);
        }

        // afiseaza o postare dupa id
        public void ShowPost(short id)
        {
            if (UserService.UserConnected == null)
            {
                OnUserNotConnected();
                return;
            }
            OnShowPostById(AllPost[id]);
        }

        // adauga o postare noua in AllPost
        public void AddNewPost(short id, Post post)
        {
            this.AllPost[id] = post;
        }
    }
}
