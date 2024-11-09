Module Program
    Sub Main()

        Dim ProductCollection As New Dictionary(Of String, Double)
        ProductCollection.Add("Laptop", 899.99)
        ProductCollection.Add("Smartphone", 599.49)
        ProductCollection.Add("Headphones", 79.99)
        ProductCollection.Add("Keyboard", 49.99)
        ProductCollection.Add("Mouse", 25.49)

        Console.WriteLine("Product List with Prices: ")
        For Each product As KeyValuePair(Of String, Double) In ProductCollection
            Console.WriteLine("Product: {0}, Price: {1:C}", product.Key, product.Value)
        Next


        Dim EmployeeDetails As New Dictionary(Of Integer, String) From {{101, "John"}, {102, "Sara"}, {103, "David"}, {104, "Emma"}}

        Console.WriteLine(" ")

        Console.WriteLine("Employee Details: ")
        For Each employee As KeyValuePair(Of Integer, String) In EmployeeDetails
            Console.WriteLine("Employee ID: {0}, Name: {1}", employee.Key, employee.Value)
        Next

        Console.ReadKey()
    End Sub
End Module
