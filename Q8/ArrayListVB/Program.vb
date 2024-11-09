Imports System

Module Program
    Sub Main()
        Dim list As ArrayList = New ArrayList()
        list.Add("Hello")
        list.Add("This")
        list.Add("is")
        list.Add("Yaiphaba")
        list.Add(5)
        list.Add("th")
        list.Add("Sem")
        list.Add("Student,")
        list.Add(2024)

        Console.Write(" it is Array ")
        For Each item In list
            Console.WriteLine(item)
        Next
        Console.ReadKey()
    End Sub
End Module
