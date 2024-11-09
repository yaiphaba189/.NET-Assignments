Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles TypeInfo.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Number.TextChanged

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Result.Click

    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim fact As Integer = 1
        Dim inputNumber As Integer = Val(Number.Text)

        For i As Integer = 1 To inputNumber
            fact *= i

            If i < inputNumber Then

            End If
        Next


        ResultBox.Text = fact.ToString()
    End Sub
End Class
