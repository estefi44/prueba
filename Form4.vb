Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c, d, respuesta As Integer
        c = TextBox1.Text
        d = TextBox2.Text
        respuesta = c - d
        TextBox3.Text = respuesta


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
End Class