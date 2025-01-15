<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationForm
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
        Label1 = New Label()
        txtSearchDestination = New TextBox()
        btnSearch = New Button()
        dgvVolsRecherche = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtClientNom = New TextBox()
        txtClientPrenom = New TextBox()
        txtClientTel = New TextBox()
        btnReserver = New Button()
        Label5 = New Label()
        CType(dgvVolsRecherche, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 0
        Label1.Text = "Destination"
        ' 
        ' txtSearchDestination
        ' 
        txtSearchDestination.Location = New Point(137, 105)
        txtSearchDestination.Name = "txtSearchDestination"
        txtSearchDestination.Size = New Size(140, 23)
        txtSearchDestination.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.GradientInactiveCaption
        btnSearch.FlatStyle = FlatStyle.Popup
        btnSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(396, 97)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(117, 34)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Rechercher"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvVolsRecherche
        ' 
        dgvVolsRecherche.BackgroundColor = SystemColors.Control
        dgvVolsRecherche.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVolsRecherche.GridColor = SystemColors.GrayText
        dgvVolsRecherche.Location = New Point(137, 155)
        dgvVolsRecherche.Name = "dgvVolsRecherche"
        dgvVolsRecherche.Size = New Size(547, 150)
        dgvVolsRecherche.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 329)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 20)
        Label2.TabIndex = 4
        Label2.Text = "Nom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(13, 375)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 5
        Label3.Text = "Prenom"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(13, 421)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 20)
        Label4.TabIndex = 6
        Label4.Text = "Telephone"
        ' 
        ' txtClientNom
        ' 
        txtClientNom.Location = New Point(137, 326)
        txtClientNom.Name = "txtClientNom"
        txtClientNom.Size = New Size(140, 23)
        txtClientNom.TabIndex = 7
        ' 
        ' txtClientPrenom
        ' 
        txtClientPrenom.Location = New Point(137, 372)
        txtClientPrenom.Name = "txtClientPrenom"
        txtClientPrenom.Size = New Size(140, 23)
        txtClientPrenom.TabIndex = 8
        ' 
        ' txtClientTel
        ' 
        txtClientTel.Location = New Point(137, 421)
        txtClientTel.Name = "txtClientTel"
        txtClientTel.Size = New Size(140, 23)
        txtClientTel.TabIndex = 9
        ' 
        ' btnReserver
        ' 
        btnReserver.BackColor = SystemColors.GradientInactiveCaption
        btnReserver.FlatStyle = FlatStyle.Popup
        btnReserver.Font = New Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnReserver.Location = New Point(396, 371)
        btnReserver.Name = "btnReserver"
        btnReserver.Size = New Size(212, 29)
        btnReserver.TabIndex = 10
        btnReserver.Text = "Confirmer la réservation"
        btnReserver.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.InactiveCaption
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.OliveDrab
        Label5.Location = New Point(288, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(170, 37)
        Label5.TabIndex = 11
        Label5.Text = "Reservation"
        ' 
        ' ReservationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(btnReserver)
        Controls.Add(txtClientTel)
        Controls.Add(txtClientPrenom)
        Controls.Add(txtClientNom)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(dgvVolsRecherche)
        Controls.Add(btnSearch)
        Controls.Add(txtSearchDestination)
        Controls.Add(Label1)
        Name = "ReservationForm"
        Text = "Réservation de billets"
        CType(dgvVolsRecherche, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchDestination As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvVolsRecherche As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtClientNom As TextBox
    Friend WithEvents txtClientPrenom As TextBox
    Friend WithEvents txtClientTel As TextBox
    Friend WithEvents btnReserver As Button
    Friend WithEvents Label5 As Label
End Class
