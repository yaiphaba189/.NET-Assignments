Imports System

Namespace BookInfo
    Interface IBook
        Sub ShowBookTitle(title As String)
        Sub ShowBookAuthor(author As String)
    End Interface

    Class Book
        Implements IBook

        Public Sub ShowBookTitle(title As String) Implements IBook.ShowBookTitle
            Console.WriteLine("The title of the book is: {0}", title)
        End Sub

        Public Sub ShowBookAuthor(author As String) Implements IBook.ShowBookAuthor
            Console.WriteLine("The author of the book is: {0}", author)
        End Sub
    End Class

    Module Program
        Sub Main()
            Dim book As New Book()
            book.ShowBookTitle("To Kill a Mockingbird")
            book.ShowBookAuthor("Harper Lee")

            Console.ReadKey()
        End Sub
    End Module
End Namespace
