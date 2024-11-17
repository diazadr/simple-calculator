Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Single = Val(TextBox1.Text)
        Dim num2 As Single = Val(TextBox2.Text)
        Dim Sum As Single = num1 + num2
        Label4.Text = Sum.ToString
        MsgBox("Hasil penjumlahan adalah: " & Sum.ToString())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Single = Val(TextBox1.Text)
        Dim num2 As Single = Val(TextBox2.Text)
        Dim Sum As Single = num1 - num2
        Label4.Text = Sum.ToString
        MsgBox("Hasil penjumlahan adalah: " & Sum.ToString())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Single = Val(TextBox1.Text)
        Dim num2 As Single = Val(TextBox2.Text)
        Dim Sum As Single = num1 * num2
        Label4.Text = Sum.ToString
        MsgBox("Hasil penjumlahan adalah: " & Sum.ToString())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Single = Val(TextBox1.Text)
        Dim num2 As Single = Val(TextBox2.Text)
        Dim Sum As Single = num1 / num2
        Label4.Text = Sum.ToString
        MsgBox("Hasil penjumlahan adalah: " & Sum.ToString())
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label4.Text = ""
        MsgBox("Text Di Clear")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
