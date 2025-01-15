<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvVols = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNumVol = New TextBox()
        txtDestination = New TextBox()
        txtDateHeure = New TextBox()
        txtPlacesDispo = New TextBox()
        txtPrix = New TextBox()
        btnAjouter = New Button()
        btnModifier = New Button()
        btnSupprimer = New Button()
        Label6 = New Label()
        CType(dgvVols, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvVols
        ' 
        dgvVols.BackgroundColor = SystemColors.Control
        dgvVols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVols.Location = New Point(109, 79)
        dgvVols.Name = "dgvVols"
        dgvVols.Size = New Size(543, 150)
        dgvVols.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 269)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 1
        Label1.Text = "Numéro de vol"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(33, 312)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 2
        Label2.Text = "Destination"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(31, 348)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 3
        Label3.Text = "Date/Heure"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(33, 388)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 20)
        Label4.TabIndex = 4
        Label4.Text = "Places disponibles"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(33, 421)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 20)
        Label5.TabIndex = 5
        Label5.Text = "Prix"
        ' 
        ' txtNumVol
        ' 
        txtNumVol.Location = New Point(171, 266)
        txtNumVol.Name = "txtNumVol"
        txtNumVol.Size = New Size(140, 23)
        txtNumVol.TabIndex = 6
        ' 
        ' txtDestination
        ' 
        txtDestination.Location = New Point(171, 309)
        txtDestination.Name = "txtDestination"
        txtDestination.Size = New Size(140, 23)
        txtDestination.TabIndex = 7
        ' 
        ' txtDateHeure
        ' 
        txtDateHeure.Location = New Point(171, 345)
        txtDateHeure.Name = "txtDateHeure"
        txtDateHeure.Size = New Size(140, 23)
        txtDateHeure.TabIndex = 8
        ' 
        ' txtPlacesDispo
        ' 
        txtPlacesDispo.Location = New Point(171, 385)
        txtPlacesDispo.Name = "txtPlacesDispo"
        txtPlacesDispo.Size = New Size(140, 23)
        txtPlacesDispo.TabIndex = 9
        ' 
        ' txtPrix
        ' 
        txtPrix.Location = New Point(171, 418)
        txtPrix.Name = "txtPrix"
        txtPrix.Size = New Size(140, 23)
        txtPrix.TabIndex = 10
        ' 
        ' btnAjouter
        ' 
        btnAjouter.BackColor = SystemColors.GradientInactiveCaption
        btnAjouter.FlatStyle = FlatStyle.Popup
        btnAjouter.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnAjouter.Location = New Point(485, 282)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(112, 33)
        btnAjouter.TabIndex = 11
        btnAjouter.Text = "Ajouter"
        btnAjouter.UseVisualStyleBackColor = False
        ' 
        ' btnModifier
        ' 
        btnModifier.AccessibleRole = AccessibleRole.Cursor
        btnModifier.BackColor = SystemColors.GradientInactiveCaption
        btnModifier.FlatStyle = FlatStyle.Popup
        btnModifier.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnModifier.Location = New Point(485, 340)
        btnModifier.Name = "btnModifier"
        btnModifier.Size = New Size(112, 36)
        btnModifier.TabIndex = 12
        btnModifier.Text = "Modifier"
        btnModifier.UseVisualStyleBackColor = False
        ' 
        ' btnSupprimer
        ' 
        btnSupprimer.BackColor = SystemColors.GradientInactiveCaption
        btnSupprimer.FlatStyle = FlatStyle.Popup
        btnSupprimer.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnSupprimer.Location = New Point(485, 403)
        btnSupprimer.Name = "btnSupprimer"
        btnSupprimer.Size = New Size(112, 35)
        btnSupprimer.TabIndex = 13
        btnSupprimer.Text = "Supprimer"
        btnSupprimer.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(262, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(195, 37)
        Label6.TabIndex = 14
        Label6.Text = "Espace Admin"
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(btnSupprimer)
        Controls.Add(btnModifier)
        Controls.Add(btnAjouter)
        Controls.Add(txtPrix)
        Controls.Add(txtPlacesDispo)
        Controls.Add(txtDateHeure)
        Controls.Add(txtDestination)
        Controls.Add(txtNumVol)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvVols)
        Name = "AdminForm"
        Text = "Gestion des vols"
        CType(dgvVols, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvVols As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumVol As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents txtDateHeure As TextBox
    Friend WithEvents txtPlacesDispo As TextBox
    Friend WithEvents txtPrix As TextBox
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents Label6 As Label
End Class
