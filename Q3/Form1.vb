Public Class Form1
    Dim term As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To term
            TextBox2.Text &= i ^ 2 & " "
        Next


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        term = TextBox1.Text

    End Sub
End Class
