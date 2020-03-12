using System;
using System.Collections.Generic;
using System.Text;

namespace _02ClassesHW
{
    class Content
    {
        private string con;
        public Content(string con)
        {
            this.con = con;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(con);
        }
    }
}
