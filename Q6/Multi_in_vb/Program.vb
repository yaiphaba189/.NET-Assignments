Imports System

Module Program
    Public Class FirstData
        Protected radius As Single

        Public Sub SetRadius(r As Single)
            radius = r
        End Sub
    End Class

    Public Class SecondData
        Inherits FirstData

    End Class

    Public Class Circle
        Inherits SecondData

        Public Function GetArea() As Single
            Return Math.PI * radius * radius
        End Function
    End Class

    Sub Main()
        Dim data As New Circle()
        data.SetRadius(7)
        Console.WriteLine("The area of the circle is: {0}", data.GetArea())
        Console.ReadKey()
    End Sub
End Module
