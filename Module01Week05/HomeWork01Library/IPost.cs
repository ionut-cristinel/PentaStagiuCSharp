using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01Library
{
    // interfata IPost este implementata de clasa MessageBoard
    // interfata are doua metode pentru afisarea postarilor
    public interface IPost
    {
        void ShowAllPost();
        void ShowPost(short id);
    }
}
