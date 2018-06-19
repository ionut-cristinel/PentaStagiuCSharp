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
        private void OnUserNotConnected()
        {
            if (UserNotConnected != null)
                UserNotConnected();
        }

        private void OnShowPostById(Post post)
        {
            if (ShowPostById != null)
                ShowPostById(post);
        }

        private void OnShowAllPosts(Post[] posts)
        {
            if (ShowAllPosts != null)
                ShowAllPosts(posts);
        }
    }
}
