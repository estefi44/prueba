<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtusuario = New TextBox()
        txtcontraseña = New TextBox()
        btningresar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Label1.Font = New Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(347, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 26)
        Label1.TabIndex = 0
        Label1.Text = "acesso"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Red
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(172, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 24)
        Label2.TabIndex = 1
        Label2.Text = "usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Red
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(160, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 25)
        Label3.TabIndex = 2
        Label3.Text = "contraseña"
        ' 
        ' txtusuario
        ' 
        txtusuario.Location = New Point(347, 109)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(100, 23)
        txtusuario.TabIndex = 3
        ' 
        ' txtcontraseña
        ' 
        txtcontraseña.Location = New Point(347, 187)
        txtcontraseña.Name = "txtcontraseña"
        txtcontraseña.PasswordChar = "*"c
        txtcontraseña.Size = New Size(100, 23)
        txtcontraseña.TabIndex = 4
        ' 
        ' btningresar
        ' 
        btningresar.BackColor = SystemColors.AppWorkspace
        btningresar.Location = New Point(531, 122)
        btningresar.Name = "btningresar"
        btningresar.Size = New Size(117, 70)
        btningresar.TabIndex = 5
        btningresar.Text = "ingresar"
        btningresar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btningresar)
        Controls.Add(txtcontraseña)
        Controls.Add(txtusuario)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents btningresar As Button
End Class
