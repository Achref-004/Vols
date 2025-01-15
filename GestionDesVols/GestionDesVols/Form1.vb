Public Class Form1




    ' Compte as admin et utilisateur 
    Private admins As New Dictionary(Of String, String) From {
        {"achref", "123456"}
    }
    Private users As New Dictionary(Of String, String) From {
        {"achref", "1234560"}
    }




    '  le bouton Se connecter
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        ' Récupérer les valeurs des champs

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim role As String = cmbRole.Text




        ' Vérifier les champs vides

        If username = "" Or password = "" Or role = "" Then
            MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If




        ' Authentification

        If role = "Admin" AndAlso admins.ContainsKey(username) AndAlso admins(username) = password Then

            Dim adminForm As New AdminForm()
            adminForm.Show()
            Me.Hide()
        ElseIf role = "Utilisateur simple" AndAlso users.ContainsKey(username) AndAlso users(username) = password Then

            Dim reservationForm As New ReservationForm()
            reservationForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Identifiants ou rôle incorrects.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub




End Class
