Public Class frmLookupWilayah
    Inherits System.Windows.Forms.Form
#Region "FormBuilder"
    Friend WithEvents CboProvinsi As ComboBox

    Friend WithEvents Label1 As Label

    Friend WithEvents Label2 As Label
    Friend WithEvents lsvReferensi As ListView
    Friend WithEvents CmdPilih As Button
    Friend WithEvents CmdKeluar As Button
    Friend WithEvents CboKabupaten As ComboBox

    Private Sub InitializeComponent()
        Me.CboProvinsi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboKabupaten = New System.Windows.Forms.ComboBox()
        Me.lsvReferensi = New System.Windows.Forms.ListView()
        Me.CmdPilih = New System.Windows.Forms.Button()
        Me.CmdKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CboProvinsi
        '
        Me.CboProvinsi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProvinsi.FormattingEnabled = True
        Me.CboProvinsi.Location = New System.Drawing.Point(98, 12)
        Me.CboProvinsi.Name = "CboProvinsi"
        Me.CboProvinsi.Size = New System.Drawing.Size(316, 21)
        Me.CboProvinsi.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Provinsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kabupaten"
        '
        'CboKabupaten
        '
        Me.CboKabupaten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboKabupaten.FormattingEnabled = True
        Me.CboKabupaten.Location = New System.Drawing.Point(98, 39)
        Me.CboKabupaten.Name = "CboKabupaten"
        Me.CboKabupaten.Size = New System.Drawing.Size(316, 21)
        Me.CboKabupaten.TabIndex = 2
        '
        'lsvReferensi
        '
        Me.lsvReferensi.FullRowSelect = True
        Me.lsvReferensi.GridLines = True
        Me.lsvReferensi.Location = New System.Drawing.Point(12, 79)
        Me.lsvReferensi.Name = "lsvReferensi"
        Me.lsvReferensi.Size = New System.Drawing.Size(670, 242)
        Me.lsvReferensi.TabIndex = 12
        Me.lsvReferensi.UseCompatibleStateImageBehavior = False
        Me.lsvReferensi.View = System.Windows.Forms.View.Details
        '
        'CmdPilih
        '
        Me.CmdPilih.Location = New System.Drawing.Point(526, 328)
        Me.CmdPilih.Name = "CmdPilih"
        Me.CmdPilih.Size = New System.Drawing.Size(75, 23)
        Me.CmdPilih.TabIndex = 13
        Me.CmdPilih.Text = "Pilih"
        Me.CmdPilih.UseVisualStyleBackColor = True
        '
        'CmdKeluar
        '
        Me.CmdKeluar.Location = New System.Drawing.Point(607, 327)
        Me.CmdKeluar.Name = "CmdKeluar"
        Me.CmdKeluar.Size = New System.Drawing.Size(75, 23)
        Me.CmdKeluar.TabIndex = 14
        Me.CmdKeluar.Text = "Keluar"
        Me.CmdKeluar.UseVisualStyleBackColor = True
        '
        'frmLookupWilayah
        '
        Me.ClientSize = New System.Drawing.Size(698, 357)
        Me.Controls.Add(Me.CmdPilih)
        Me.Controls.Add(Me.CmdKeluar)
        Me.Controls.Add(Me.lsvReferensi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboKabupaten)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboProvinsi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLookupWilayah"
        Me.Text = "Lookup Wilayah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private dtProv As New DataTable("Provinsi")
    Private dtKab As New DataTable("Kabupaten")

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ReferensiProvinsi()
        Dim oDat As New JKNBridge.VClaimLib.clsReferensiPropinsi
        Try
            lsvReferensi.Visible = True
            oDat = JKNBridge.VClaimLib.Referensi.wsRefPropinsi(cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
            If Not oDat.MetaData.Code.Equals("200") Then
                MsgBox(oDat.MetaData.Message)
            Else

                dtProv.Clear()
                For nItem As Integer = 0 To oDat.Response.List.Count - 1
                    dtProv.Rows.Add(New Object() {oDat.Response.List(nItem).Kode, oDat.Response.List(nItem).Nama})
                Next

                CboProvinsi.DataSource = dtProv
                CboProvinsi.DisplayMember = "NamaProvinsi"
                CboProvinsi.ValueMember = "Kode"

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReferensiKabupaten()
        Dim oDat As New JKNBridge.VClaimLib.clsReferensiKabupaten
        Try
            lsvReferensi.Visible = True
            oDat = JKNBridge.VClaimLib.Referensi.wsRefKabupaten(CboProvinsi.SelectedValue, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
            If Not oDat.MetaData.Code.Equals("200") Then
                MsgBox(oDat.MetaData.Message)
            Else

                dtKab.Clear()

                For nItem As Integer = 0 To oDat.Response.List.Count - 1
                    dtKab.Rows.Add(New Object() {oDat.Response.List(nItem).Kode, oDat.Response.List(nItem).Nama})
                Next

                CboKabupaten.DataSource = dtKab
                CboKabupaten.DisplayMember = "NamaKabupaten"
                CboKabupaten.ValueMember = "Kode"
                CboKabupaten.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReferensiKecamatan()
        Dim oDat As New JKNBridge.VClaimLib.clsReferensiKecamatan
        Try
            lsvReferensi.Visible = True
            oDat = JKNBridge.VClaimLib.Referensi.wsRefKecamatan(CboKabupaten.SelectedValue, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
            If Not oDat.MetaData.Code.Equals("200") Then
                MsgBox(oDat.MetaData.Message)
            Else
                lsvReferensi.Items.Clear()
                lsvReferensi.Columns.Clear()

                lsvReferensi.Columns.Clear()
                lsvReferensi.Columns.Add("Kode", 150)
                lsvReferensi.Columns.Add("Nama Kecamatan", lsvReferensi.Width - 180)
                For nItem As Integer = 0 To oDat.Response.List.Count - 1
                    lsvReferensi.Items.Add(oDat.Response.List(nItem).Kode)
                    lsvReferensi.Items(nItem).SubItems.Add(oDat.Response.List(nItem).Nama)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmLookupWilayah_Load(sender As Object, e As EventArgs) Handles Me.Load

        dtProv.Columns.Add("Kode")
        dtProv.Columns.Add("NamaProvinsi")


        dtKab.Columns.Add("Kode")
        dtKab.Columns.Add("NamaKabupaten")


        ReferensiProvinsi()
    End Sub


    'Private Sub CboProvinsi_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboProvinsi.SelectedValueChanged
    '    ReferensiKabupaten()
    'End Sub

    Private Sub CboProvinsi_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboProvinsi.SelectionChangeCommitted
        ReferensiKabupaten()
    End Sub

    Private Sub CboKabupaten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboKabupaten.SelectedIndexChanged

    End Sub

    Private Sub CboKabupaten_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboKabupaten.SelectionChangeCommitted
        ReferensiKecamatan()
    End Sub
End Class
