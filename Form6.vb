Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h, i, respuesta As Integer
        h = TextBox1.Text
        i = TextBox2.Text
        respuesta = h / i
        TextBox3.Text = respuesta
        If TextBox1.Text = 0 Then
            TextBox3.Text = "syntaxis error"
        ElseIf TextBox2.Text = 0 Then
            TextBox3.Text = "syntaxis error"
        End If
        If TextBox1.Text = 0 Then
            TextBox3.Text = ""
            MsgBox("syntaxis error")
        ElseIf TextBox2.Text = "" Then
            MsgBox("syntaxis error")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
         Form2.Show()
    End Sub
End Class