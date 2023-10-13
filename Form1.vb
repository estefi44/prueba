Imports System.DirectoryServices

Public Class Form1
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim usuario, Password As String
        usuario = txtusuario.Text
        Password = txtcontraseña.Text

        If (usuario = "soyelmejor") And (password = "123") Then
            Form2.Show()
        Else
            MsgBox("incorrecto, intentelo nuevamente")

        End If
    End Sub

    Private Sub txtcontraseña_TextChanged(sender As Object, e As EventArgs) Handles txtcontraseña.TextChanged

    End Sub
End Class
