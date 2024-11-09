Imports System

Namespace BookInfo
    Interface ITitle
        Sub ShowTitle(title As String)
    End Interface

    Interface IAuthor
        Sub ShowAuthor(author As String)
    End Interface

    Class Book
        Implements ITitle, IAuthor

        Public Sub ShowTitle(title As String) Implements ITitle.ShowTitle
            Console.WriteLine("The title of the book is: {0}", title)
        End Sub

        Public Sub ShowAuthor(author As String) Implements IAuthor.ShowAuthor
            Console.WriteLine("The author of the book is: {0}", author)
        End Sub
    End Class

    Module Program
        Sub Main()
            Dim book As New Book()
            book.ShowTitle("To Kill a Mockingbird")
            book.ShowAuthor("Harper Lee")

            Console.ReadKey()
        End Sub
    End Module
End Namespace
