using System;

namespace BookInfo
{
    interface IBook
    {
        void ShowBookTitle(string title);
        void ShowBookAuthor(string author);
    }

    class Book : IBook
    {
        public void ShowBookTitle(string title)
        {
            Console.WriteLine("The title of the book is: {0}", title);
        }

        public void ShowBookAuthor(string author)
        {
            Console.WriteLine("The author of the book is: {0}", author);
        }
    }

    class Program
    {
        public static void Main()
        {
            Book book = new Book();
            book.ShowBookTitle("To Kill a Mockingbird");
            book.ShowBookAuthor("Harper Lee");

            Console.ReadKey();
        }
    }
}
