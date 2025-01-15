
Module DataModule



    ' Tableau global pour stocker les vols
    Public vols(,) As String = New String(99, 4) {}
    Public compteurVols As Integer = 0
    Private Const FichierVols As String = "vols.csv"




    ' Méthode pour sauvegarder les vols dans un fichier CSV
    Public Sub SauvegarderVols()
        Try
            Using writer As New System.IO.StreamWriter(FichierVols, False)
                For i As Integer = 0 To compteurVols - 1
                    Dim ligne As String = String.Join(",", vols(i, 0), vols(i, 1), vols(i, 2), vols(i, 3), vols(i, 4))
                    writer.WriteLine(ligne)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la sauvegarde des vols : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    ' Méthode pour charger les vols depuis un fichier CSV
    Public Sub ChargerVols()
        If Not System.IO.File.Exists(FichierVols) Then Return

        Try
            Using reader As New System.IO.StreamReader(FichierVols)
                Dim ligne As String
                compteurVols = 0
                While (reader.Peek() >= 0)
                    ligne = reader.ReadLine()
                    Dim champs() As String = ligne.Split(","c)
                    For j As Integer = 0 To 4
                        vols(compteurVols, j) = champs(j)
                    Next
                    compteurVols += 1
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement des vols : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
