using System;
using System.Collections.Generic;
using System.Text;

namespace _02ClassesHW
{
    class Title
    {
        private string tit;
        public Title(string tit)
        {
            this.tit = tit;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(tit);
        }


    }
}
