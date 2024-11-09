Imports System

Module Program
    Public Class Shape
        Protected radius As Single
        Protected height As Single

        Public Sub SetDimensions(r As Single, h As Single)
            radius = r
            height = h
        End Sub
    End Class

    Public Class Cylinder
        Inherits Shape

        Public Function GetSurfaceArea() As Single
            Return 2 * Math.PI * radius * (radius + height)
        End Function
    End Class

    Sub Main()
        Dim data As New Cylinder()
        data.SetDimensions(7, 10)
        Console.WriteLine("The Surface Area of the Cylinder is {0}", data.GetSurfaceArea())
        Console.ReadKey()
    End Sub
End Module
