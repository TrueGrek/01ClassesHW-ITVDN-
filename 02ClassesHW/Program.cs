//Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс Book.Создать классы Title, Author и Content, каждый из которых должен содержать
//одно строковое поле и метод void Show().
//Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
//Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и
//содержание. 

using System;

namespace _02ClassesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Author Aut = new Author("Анджей Сапковский");
            Title Tit = new Title("Ведьмак");
            Content Con = new Content("И так началась сага о Ведьмаке...");
            Aut.Show();
            Tit.Show();
            Con.Show();
            Console.ReadKey();

        }
    }
}
