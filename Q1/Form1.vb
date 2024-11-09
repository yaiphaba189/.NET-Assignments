Imports System.Xml.XPath

Public Class Form1
    Dim num1 As Integer
    Dim num2 As Integer
    Dim ans As Integer
    Private Sub Number1_TextChanged(sender As Object, e As EventArgs) Handles Number1.TextChanged
        num1 = Number1.Text
    End Sub

    Private Sub Number2_TextChanged(sender As Object, e As EventArgs) Handles Number2.TextChanged
        num2 = Number2.Text
    End Sub

    Private Sub Addbt_Click(sender As Object, e As EventArgs) Handles Addbt.Click
        Result.Text = num1 + num2
    End Sub

    Private Sub Subbt_Click(sender As Object, e As EventArgs) Handles Subbt.Click
        Result.Text = num1 - num2
    End Sub

    Private Sub Mulbt_Click(sender As Object, e As EventArgs) Handles Mulbt.Click
        Result.Text = num1 * num2
    End Sub

    Private Sub Divbt_Click(sender As Object, e As EventArgs) Handles Divbt.Click
        Result.Text = num1 / num2
    End Sub

    Private Sub Powbt_Click(sender As Object, e As EventArgs) Handles Powbt.Click
        Result.Text = num1 ^ num2
    End Sub

    Private Sub Clearbt_Click(sender As Object, e As EventArgs) Handles Clearbt.Click
        Number1.Clear()
        Number2.Clear()
        Result.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Result_TextChanged(sender As Object, e As EventArgs) Handles Result.TextChanged

    End Sub
End Class
