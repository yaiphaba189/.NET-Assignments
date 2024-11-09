Imports System

Module ConstrucVB
    Class Employee

        Private _id As Integer
        Private _name As String


        Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                If value <= 0 Then
                    Throw New ArgumentException("ID must be positive.")
                End If
                _id = value
            End Set
        End Property

        Public Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                If String.IsNullOrWhiteSpace(value) Then
                    Throw New ArgumentException("Name cannot be empty.")
                End If
                _name = value
            End Set
        End Property

        Public Sub New()
            Id = 101
            Name = "Jain"
            Console.WriteLine("The default constructor is called.")
            DisplayEmployeeInfo()
        End Sub


        Public Sub New(i As Integer, n As String)
            Id = i
            Name = n
            Console.WriteLine("The parameterized constructor is called.")
            DisplayEmployeeInfo()
        End Sub


        Private Sub DisplayEmployeeInfo()
            Console.WriteLine("ID is {0} and name is {1}", Id, Name)
        End Sub
    End Class

    Sub Main()
        Dim employee1 As New Employee()
        Dim employee2 As New Employee(202, "Jain")
        Console.ReadKey()
    End Sub
End Module
