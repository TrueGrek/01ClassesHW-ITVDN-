using System;
using System.Collections.Generic;
using System.Text;

namespace _02ClassesHW
{
    class Author
    {
        private string aut;
        public Author(string aut)
        {
            this.aut = aut;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(aut);
        }
    }
}
