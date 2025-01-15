Public Class AdminForm

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click




        ' Validation des champs

        If txtNumVol.Text.Trim() = "" OrElse txtDestination.Text.Trim() = "" OrElse txtDateHeure.Text.Trim() = "" OrElse
           txtPlacesDispo.Text.Trim() = "" OrElse txtPrix.Text.Trim() = "" Then
            MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If




        ' Ajouter le vol dans le tableau

        Dim index As Integer = DataModule.compteurVols
        DataModule.vols(index, 0) = txtNumVol.Text.Trim()
        DataModule.vols(index, 1) = txtDestination.Text.Trim()
        DataModule.vols(index, 2) = txtDateHeure.Text.Trim()
        DataModule.vols(index, 3) = txtPlacesDispo.Text.Trim()
        DataModule.vols(index, 4) = txtPrix.Text.Trim()
        DataModule.compteurVols += 1



        ' Sauvegarder les vols

        DataModule.SauvegarderVols()




        ' Mise à jour du DataGridView

        ActualiserDataGridView()




        ' Réinitialiser les champs
        txtNumVol.Clear()
        txtDestination.Clear()
        txtDateHeure.Clear()
        txtPlacesDispo.Clear()
        txtPrix.Clear()



    End Sub


    'Bouton Modifier
    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        If dgvVols.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim index As Integer = dgvVols.SelectedRows(0).Index
        DataModule.vols(index, 0) = txtNumVol.Text
        DataModule.vols(index, 1) = txtDestination.Text
        DataModule.vols(index, 2) = txtDateHeure.Text
        DataModule.vols(index, 3) = txtPlacesDispo.Text
        DataModule.vols(index, 4) = txtPrix.Text



        ' Sauvegarder les vols

        DataModule.SauvegarderVols()



        ' Mise à jour du DataGridView

        ActualiserDataGridView()
    End Sub



    'bouton Supprimer
    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If dgvVols.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim index As Integer = dgvVols.SelectedRows(0).Index




        ' Supprimer le vol du tableau

        For i As Integer = index To DataModule.compteurVols - 2
            For j As Integer = 0 To 4
                DataModule.vols(i, j) = DataModule.vols(i + 1, j)
            Next
        Next
        DataModule.compteurVols -= 1



        ' Sauvegarder les vols

        DataModule.SauvegarderVols()



        ' Mise à jour du DataGridView

        ActualiserDataGridView()
    End Sub




    '  la méthode Actualiser DataGridView
    Private Sub ActualiserDataGridView()
        dgvVols.Rows.Clear()
        For i As Integer = 0 To DataModule.compteurVols - 1
            dgvVols.Rows.Add(DataModule.vols(i, 0), DataModule.vols(i, 1), DataModule.vols(i, 2), DataModule.vols(i, 3), DataModule.vols(i, 4))
        Next
    End Sub


    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        ' Charger les vols depuis le fichier

        DataModule.ChargerVols()
        dgvVols.ColumnCount = 5
        dgvVols.Columns(0).Name = "Numéro de Vol"
        dgvVols.Columns(1).Name = "Destination"
        dgvVols.Columns(2).Name = "Date/Heure"
        dgvVols.Columns(3).Name = "Places Disponibles"
        dgvVols.Columns(4).Name = "Prix"

        ' Charger les vols existants

        ActualiserDataGridView()

    End Sub

End Class