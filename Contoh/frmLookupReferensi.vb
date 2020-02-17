Public Class frmLookupReferensi
    Inherits System.Windows.Forms.Form

    'Note Jenis Referensi
    '1. Referensi Pili
    '2. Referensi Diagnosa
    '3. Referensi Dokter
    '4. Referensi Faskes
    '5. Referensi Kabupaten
#Region "Form builder"
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents lsvReferensi As ListView
    Friend WithEvents CmdKeluar As Button
    Friend WithEvents CmdPilih As Button
    Friend WithEvents CmdGo As Button

    Public Sub New(nJenis As JenisReferensi)
        InitializeComponent()
        nJenisReferensi = nJenis
    End Sub

    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.CmdGo = New System.Windows.Forms.Button()
        Me.lsvReferensi = New System.Windows.Forms.ListView()
        Me.CmdKeluar = New System.Windows.Forms.Button()
        Me.CmdPilih = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cari"
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(71, 25)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(526, 20)
        Me.TxtCari.TabIndex = 8
        '
        'CmdGo
        '
        Me.CmdGo.Location = New System.Drawing.Point(603, 22)
        Me.CmdGo.Name = "CmdGo"
        Me.CmdGo.Size = New System.Drawing.Size(39, 23)
        Me.CmdGo.TabIndex = 10
        Me.CmdGo.Text = "GO"
        Me.CmdGo.UseVisualStyleBackColor = True
        '
        'lsvReferensi
        '
        Me.lsvReferensi.FullRowSelect = True
        Me.lsvReferensi.GridLines = True
        Me.lsvReferensi.Location = New System.Drawing.Point(12, 63)
        Me.lsvReferensi.Name = "lsvReferensi"
        Me.lsvReferensi.Size = New System.Drawing.Size(670, 271)
        Me.lsvReferensi.TabIndex = 11
        Me.lsvReferensi.UseCompatibleStateImageBehavior = False
        Me.lsvReferensi.View = System.Windows.Forms.View.Details
        '
        'CmdKeluar
        '
        Me.CmdKeluar.Location = New System.Drawing.Point(603, 340)
        Me.CmdKeluar.Name = "CmdKeluar"
        Me.CmdKeluar.Size = New System.Drawing.Size(75, 23)
        Me.CmdKeluar.TabIndex = 12
        Me.CmdKeluar.Text = "Keluar"
        Me.CmdKeluar.UseVisualStyleBackColor = True
        '
        'CmdPilih
        '
        Me.CmdPilih.Location = New System.Drawing.Point(522, 341)
        Me.CmdPilih.Name = "CmdPilih"
        Me.CmdPilih.Size = New System.Drawing.Size(75, 23)
        Me.CmdPilih.TabIndex = 12
        Me.CmdPilih.Text = "Pilih"
        Me.CmdPilih.UseVisualStyleBackColor = True
        '
        'frmLookupReferensi
        '
        Me.ClientSize = New System.Drawing.Size(688, 376)
        Me.Controls.Add(Me.CmdPilih)
        Me.Controls.Add(Me.CmdKeluar)
        Me.Controls.Add(Me.lsvReferensi)
        Me.Controls.Add(Me.CmdGo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCari)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLookupReferensi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

#Region "Private Proc"

    Public Enum JenisReferensi As SByte
        Poli = 1
        Diagnosa = 2
        Dokter = 3
        Faskes = 4
        Kabupaten = 5
    End Enum
    '1. 
    Private Sub ReferensiPoli()
        Dim oDat As New JKNBridge.VClaimLib.clsRefPoli
        Try
            lsvReferensi.Visible = True
            oDat = JKNBridge.VClaimLib.Referensi.wsRefPoli(TxtCari.Text.Trim, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
            If Not oDat.MetaData.Code.Equals("200") Then
                MsgBox(oDat.MetaData.Message)
            Else
                lsvReferensi.Items.Clear()
                lsvReferensi.Columns.Clear()

                lsvReferensi.Columns.Clear()
                lsvReferensi.Columns.Add("Kode", 150)
                lsvReferensi.Columns.Add("Nama Klinik", lsvReferensi.Width - 180)
                For nItem As Integer = 0 To oDat.Response.Poli.Count - 1
                    lsvReferensi.Items.Add(oDat.Response.Poli(nItem).Kode)
                    lsvReferensi.Items(nItem).SubItems.Add(oDat.Response.Poli(nItem).Nama)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '2
    Private Sub ReferensiDiagnosa()
        Dim oDat As New JKNBridge.VClaimLib.clsRefDiagnosa
        Try
            lsvReferensi.Visible = True
            oDat = JKNBridge.VClaimLib.Referensi.wsRefDiagnosa(TxtCari.Text.Trim, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
            If Not oDat.MetaData.Code.Equals("200") Then
                MsgBox(oDat.MetaData.Message)
            Else
                lsvReferensi.Items.Clear()
                lsvReferensi.Columns.Clear()

                lsvReferensi.Columns.Clear()
                lsvReferensi.Columns.Add("Kode", 150)
                lsvReferensi.Columns.Add("Nama Diagnosa", lsvReferensi.Width - 180)
                For nItem As Integer = 0 To oDat.Response.Diagnosa.Count - 1
                    lsvReferensi.Items.Add(oDat.Response.Diagnosa(nItem).Kode)
                    lsvReferensi.Items(nItem).SubItems.Add(oDat.Response.Diagnosa(nItem).Nama)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '3. 
    Private Sub ReferensiDokter()
        Dim oDat As New JKNBridge.VClaimLib.clsRefDokterDPJP
        Try
            lsvReferensi.Visible = True
            oDat = JKNBridge.VClaimLib.Referensi.wsRefDokterDPJP(JKNBridge.VClaimLib.Referensi.eJenisPelayanan.RawatJalan, Today.ToString("yyyy-MM-dd"), TxtCari.Text.Trim, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
            If Not oDat.MetaData.Code.Equals("200") Then
                MsgBox(oDat.MetaData.Message)
            Else
                lsvReferensi.Items.Clear()
                lsvReferensi.Columns.Clear()

                lsvReferensi.Refresh()
                lsvReferensi.Columns.Add("Kode", 150)
                lsvReferensi.Columns.Add("Nama Dokter", lsvReferensi.Width - 180)
                For nItem As Integer = 0 To oDat.Response.List.Count - 1
                    lsvReferensi.Items.Add(oDat.Response.List(nItem).Kode)
                    lsvReferensi.Items(nItem).SubItems.Add(oDat.Response.List(nItem).Nama)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '4
    Private Sub ReferensiFaskes()
        Dim oDat As New JKNBridge.VClaimLib.clsReferensiFaskes
        Try
            lsvReferensi.Visible = True
            oDat = JKNBridge.VClaimLib.Referensi.wsRefFaskes(TxtCari.Text.Trim, JKNBridge.VClaimLib.Referensi.eJenisFaskes.PPK2, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
            If Not oDat.MetaData.Code.Equals("200") Then
                MsgBox(oDat.MetaData.Message)
            Else
                lsvReferensi.Items.Clear()
                lsvReferensi.Columns.Clear()

                lsvReferensi.Columns.Clear()
                lsvReferensi.Columns.Add("Kode", 150)
                lsvReferensi.Columns.Add("Nama Faskes", lsvReferensi.Width - 180)
                For nItem As Integer = 0 To oDat.Response.Faskes.Count - 1
                    lsvReferensi.Items.Add(oDat.Response.Faskes(nItem).Kode)
                    lsvReferensi.Items(nItem).SubItems.Add(oDat.Response.Faskes(nItem).Nama)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



#End Region
    Private nJenisReferensi As SByte = 0
    Private Sub CmdKeluar_Click(sender As Object, e As EventArgs) Handles CmdKeluar.Click
        Me.Close()
    End Sub


    Private Sub CmdGo_Click(sender As Object, e As EventArgs) Handles CmdGo.Click
        If String.IsNullOrEmpty(TxtCari.Text.Trim) Then
            MessageBox.Show("Parameter pencarian tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor
        Select Case nJenisReferensi
            Case JenisReferensi.Poli
                ReferensiPoli()
            Case JenisReferensi.Diagnosa
                ReferensiDiagnosa()
            Case JenisReferensi.Dokter
                ReferensiDokter()
            Case JenisReferensi.Faskes
                ReferensiFaskes()
        End Select
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CmdPilih_Click(sender As Object, e As EventArgs) Handles CmdPilih.Click
        If lsvReferensi.SelectedItems.Count > 0 Then
            cVariable.LookupResult.Add(lsvReferensi.SelectedItems(0).Text)
            cVariable.LookupResult.Add(lsvReferensi.SelectedItems(0).SubItems(1).Text)
        End If
        Me.Close()
    End Sub

    Private Sub frmLookupReferensi_Load(sender As Object, e As EventArgs) Handles Me.Load
        cVariable.LookupResult.Clear()
    End Sub
End Class
