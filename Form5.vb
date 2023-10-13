Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, q, respuesta As Integer
        p = TextBox1.Text
        q = TextBox2.Text
        respuesta = p * q
        TextBox3.Text = respuesta


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
End Class