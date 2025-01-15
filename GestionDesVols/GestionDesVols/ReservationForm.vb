Public Class ReservationForm


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click


        Dim destination As String = txtSearchDestination.Text.Trim()





        ' Validation de la distination

        If destination = "" Then
            MessageBox.Show("Veuillez saisir une destination pour rechercher.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If





        ' Recherche des vols correspondants

        dgvVolsRecherche.Rows.Clear()


        Dim found As Boolean = False
        For i As Integer = 0 To DataModule.compteurVols - 1
            If DataModule.vols(i, 1).ToLower().Contains(destination.ToLower()) Then
                dgvVolsRecherche.Rows.Add(DataModule.vols(i, 0), DataModule.vols(i, 1), DataModule.vols(i, 2), DataModule.vols(i, 3), DataModule.vols(i, 4))
                found = True
            End If
        Next





        ' Message si aucun vol trouvé

        If Not found Then
            MessageBox.Show("Aucun vol trouvé pour cette destination.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnReserver_Click(sender As Object, e As EventArgs) Handles btnReserver.Click



        ' Validation des champs


        If dgvVolsRecherche.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol pour réserver.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If txtClientNom.Text.Trim() = "" OrElse txtClientPrenom.Text.Trim() = "" OrElse txtClientTel.Text.Trim() = "" Then
            MessageBox.Show("Veuillez saisir toutes les informations du client.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If





        ' Récupération des données

        Dim selectedRowIndex As Integer = dgvVolsRecherche.SelectedRows(0).Index
        Dim numVol As String = dgvVolsRecherche.Rows(selectedRowIndex).Cells(0).Value.ToString()
        Dim placesDisponibles As Integer = Convert.ToInt32(dgvVolsRecherche.Rows(selectedRowIndex).Cells(3).Value)

        If placesDisponibles <= 0 Then
            MessageBox.Show("Aucune place disponible pour ce vol.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If




        ' Mise à jour du nombre de places

        For i As Integer = 0 To DataModule.compteurVols - 1
            If DataModule.vols(i, 0) = numVol Then
                DataModule.vols(i, 3) = (placesDisponibles - 1).ToString()
                Exit For
            End If
        Next




        ' Génération du reçu

        Dim clientNom As String = txtClientNom.Text
        Dim clientPrenom As String = txtClientPrenom.Text
        Dim clientTel As String = txtClientTel.Text

        Dim receipt As String = $"Reçu de réservation :{Environment.NewLine}" &
                            $"Numéro de vol : {numVol}{Environment.NewLine}" &
                            $"Nom du client : {clientNom} {clientPrenom}{Environment.NewLine}" &
                            $"Téléphone : {clientTel}{Environment.NewLine}" &
                            $"Date : {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}{Environment.NewLine}"



        ' Sauvegarder dans un fichier texte

        Using writer As New System.IO.StreamWriter($"Recu_{numVol}_{DateTime.Now.Ticks}.txt")
            writer.Write(receipt)
        End Using

        MessageBox.Show("Réservation confirmée. Le reçu a été généré.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)



        ' Réinitialiser les champs

        txtClientNom.Clear()
        txtClientPrenom.Clear()
        txtClientTel.Clear()
        dgvVolsRecherche.Rows.Clear()
    End Sub
    Private Sub ReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        ' Charger les vols depuis le fichier

        DataModule.ChargerVols()
        dgvVolsRecherche.ColumnCount = 5
        dgvVolsRecherche.Columns(0).Name = "Numéro de Vol"
        dgvVolsRecherche.Columns(1).Name = "Destination"
        dgvVolsRecherche.Columns(2).Name = "Date/Heure"
        dgvVolsRecherche.Columns(3).Name = "Places Disponibles"
        dgvVolsRecherche.Columns(4).Name = "Prix"




        ' Charger les vols existants

        DataModule.ChargerVols()




    End Sub


End Class