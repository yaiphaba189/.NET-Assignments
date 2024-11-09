using System;

namespace BookInfo
{
    interface ITitle
    {
        void ShowTitle(string title);
    }

    interface IAuthor
    {
        void ShowAuthor(string author);
    }

    class Book : ITitle, IAuthor
    {
        public void ShowTitle(string title)
        {
            Console.WriteLine("The title of the book is: {0}", title);
        }

        public void ShowAuthor(string author)
        {
            Console.WriteLine("The author of the book is: {0}", author);
        }
    }

    class Program
    {
        public static void Main()
        {
            Book book = new Book();
            book.ShowTitle("To Kill a Mockingbird");
            book.ShowAuthor("Harper Lee");

            Console.ReadKey();
        }
    }
}
