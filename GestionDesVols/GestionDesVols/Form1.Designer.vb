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
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        cmbRole = New ComboBox()
        btnLogin = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F)
        Label1.Location = New Point(40, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nom d'utilisateur"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F)
        Label2.Location = New Point(40, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 25)
        Label2.TabIndex = 1
        Label2.Text = "Mot de passe"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(216, 126)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(154, 24)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(220, 199)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(154, 23)
        txtPassword.TabIndex = 3
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' cmbRole
        ' 
        cmbRole.Font = New Font("Segoe UI", 11F)
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Admin", "Utilisateur simple"})
        cmbRole.Location = New Point(216, 276)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(158, 28)
        cmbRole.TabIndex = 4
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic)
        btnLogin.Location = New Point(565, 199)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(117, 38)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Se connecter"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.InactiveCaption
        Label3.Font = New Font("Segoe UI Black", 24.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(286, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(192, 45)
        Label3.TabIndex = 6
        Label3.Text = "Connexion"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13F)
        Label4.Location = New Point(40, 276)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 25)
        Label4.TabIndex = 7
        Label4.Text = "Role"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(512, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(290, 15)
        Label5.TabIndex = 8
        Label5.Text = "Travail realiser par : Achref Bejaoui et Ranim marouani"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnLogin)
        Controls.Add(cmbRole)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Connexion - Gestion des vols"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
