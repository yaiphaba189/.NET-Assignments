Public Class Form1
    Dim term As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Resultbt.Click
        For i = 1 To term
            If i Mod 2 = 0 Then
                Even.Text &= i & " "
            Else
                Odd.Text &= i & " "
            End If
        Next
    End Sub

    Private Sub Term_TextChanged(sender As Object, e As EventArgs) Handles Termbox.TextChanged
        term = Termbox.Text
    End Sub
End Class
