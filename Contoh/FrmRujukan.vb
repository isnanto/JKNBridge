Public Class FrmRujukan
#Region "Form Builder"
    Inherits Form

    Friend WithEvents Label10 As Label

    Friend WithEvents TxtUmurSekarang As TextBox

    Friend WithEvents Label9 As Label

    Friend WithEvents TxtDeskripsiPoli As TextBox

    Friend WithEvents TxtKodePoli As TextBox

    Friend WithEvents Label5 As Label

    Friend WithEvents TxtDiagnosa As TextBox

    Friend WithEvents TxtKodeDX As TextBox

    Friend WithEvents Label2 As Label

    Friend WithEvents txtNamaPeserta As TextBox

    Friend WithEvents Label1 As Label

    Friend WithEvents TxtNoPeserta As TextBox

    Friend WithEvents Label11 As Label

    Friend WithEvents TxtNoSEP As TextBox

    Friend WithEvents CmdCariDetail As Button

    Friend WithEvents Panel1 As Panel

    Friend WithEvents CmdInsert As Button

    Friend WithEvents CmdUpdate As Button

    Friend WithEvents CmdHapus As Button
    Friend WithEvents TxtKodeFaskes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmdCariFaskes As Button
    Friend WithEvents TxtDirujukKe As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CboJnsPelayanan As ComboBox
    Friend WithEvents CmdCariDiagnosa As Button
    Friend WithEvents CboTipeRujukan As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmdCariPoli As Button
    Friend WithEvents TxtNoRujukan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CmdKeluar As Button

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtUmurSekarang = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDeskripsiPoli = New System.Windows.Forms.TextBox()
        Me.TxtKodePoli = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDiagnosa = New System.Windows.Forms.TextBox()
        Me.TxtKodeDX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaPeserta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNoPeserta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNoSEP = New System.Windows.Forms.TextBox()
        Me.CmdCariDetail = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CmdInsert = New System.Windows.Forms.Button()
        Me.CmdUpdate = New System.Windows.Forms.Button()
        Me.CmdHapus = New System.Windows.Forms.Button()
        Me.CmdKeluar = New System.Windows.Forms.Button()
        Me.TxtKodeFaskes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmdCariFaskes = New System.Windows.Forms.Button()
        Me.TxtDirujukKe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboJnsPelayanan = New System.Windows.Forms.ComboBox()
        Me.CmdCariDiagnosa = New System.Windows.Forms.Button()
        Me.CboTipeRujukan = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmdCariPoli = New System.Windows.Forms.Button()
        Me.TxtNoRujukan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Umur Sekarang"
        '
        'TxtUmurSekarang
        '
        Me.TxtUmurSekarang.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtUmurSekarang.Location = New System.Drawing.Point(133, 261)
        Me.TxtUmurSekarang.Name = "TxtUmurSekarang"
        Me.TxtUmurSekarang.ReadOnly = True
        Me.TxtUmurSekarang.Size = New System.Drawing.Size(254, 20)
        Me.TxtUmurSekarang.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Poli Tujuan"
        '
        'TxtDeskripsiPoli
        '
        Me.TxtDeskripsiPoli.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtDeskripsiPoli.Location = New System.Drawing.Point(246, 221)
        Me.TxtDeskripsiPoli.Name = "TxtDeskripsiPoli"
        Me.TxtDeskripsiPoli.ReadOnly = True
        Me.TxtDeskripsiPoli.Size = New System.Drawing.Size(288, 20)
        Me.TxtDeskripsiPoli.TabIndex = 38
        '
        'TxtKodePoli
        '
        Me.TxtKodePoli.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtKodePoli.Location = New System.Drawing.Point(133, 221)
        Me.TxtKodePoli.Name = "TxtKodePoli"
        Me.TxtKodePoli.ReadOnly = True
        Me.TxtKodePoli.Size = New System.Drawing.Size(61, 20)
        Me.TxtKodePoli.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Diagnosa"
        '
        'TxtDiagnosa
        '
        Me.TxtDiagnosa.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtDiagnosa.Location = New System.Drawing.Point(246, 169)
        Me.TxtDiagnosa.Name = "TxtDiagnosa"
        Me.TxtDiagnosa.ReadOnly = True
        Me.TxtDiagnosa.Size = New System.Drawing.Size(288, 20)
        Me.TxtDiagnosa.TabIndex = 29
        '
        'TxtKodeDX
        '
        Me.TxtKodeDX.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtKodeDX.Location = New System.Drawing.Point(133, 169)
        Me.TxtKodeDX.Name = "TxtKodeDX"
        Me.TxtKodeDX.ReadOnly = True
        Me.TxtKodeDX.Size = New System.Drawing.Size(61, 20)
        Me.TxtKodeDX.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nama Peserta"
        '
        'txtNamaPeserta
        '
        Me.txtNamaPeserta.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtNamaPeserta.Location = New System.Drawing.Point(133, 91)
        Me.txtNamaPeserta.Name = "txtNamaPeserta"
        Me.txtNamaPeserta.Size = New System.Drawing.Size(254, 20)
        Me.txtNamaPeserta.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "No. Peserta"
        '
        'TxtNoPeserta
        '
        Me.TxtNoPeserta.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNoPeserta.Location = New System.Drawing.Point(133, 65)
        Me.TxtNoPeserta.Name = "TxtNoPeserta"
        Me.TxtNoPeserta.Size = New System.Drawing.Size(138, 20)
        Me.TxtNoPeserta.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "No. SEP "
        '
        'TxtNoSEP
        '
        Me.TxtNoSEP.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNoSEP.Location = New System.Drawing.Point(133, 12)
        Me.TxtNoSEP.Name = "TxtNoSEP"
        Me.TxtNoSEP.Size = New System.Drawing.Size(261, 20)
        Me.TxtNoSEP.TabIndex = 42
        '
        'CmdCariDetail
        '
        Me.CmdCariDetail.Location = New System.Drawing.Point(400, 10)
        Me.CmdCariDetail.Name = "CmdCariDetail"
        Me.CmdCariDetail.Size = New System.Drawing.Size(85, 23)
        Me.CmdCariDetail.TabIndex = 44
        Me.CmdCariDetail.Text = "Lihat Detailnya"
        Me.CmdCariDetail.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(16, 295)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 4)
        Me.Panel1.TabIndex = 45
        '
        'CmdInsert
        '
        Me.CmdInsert.Location = New System.Drawing.Point(229, 310)
        Me.CmdInsert.Name = "CmdInsert"
        Me.CmdInsert.Size = New System.Drawing.Size(75, 23)
        Me.CmdInsert.TabIndex = 46
        Me.CmdInsert.Text = "Insert "
        Me.CmdInsert.UseVisualStyleBackColor = True
        '
        'CmdUpdate
        '
        Me.CmdUpdate.Location = New System.Drawing.Point(310, 310)
        Me.CmdUpdate.Name = "CmdUpdate"
        Me.CmdUpdate.Size = New System.Drawing.Size(75, 23)
        Me.CmdUpdate.TabIndex = 46
        Me.CmdUpdate.Text = "Update"
        Me.CmdUpdate.UseVisualStyleBackColor = True
        '
        'CmdHapus
        '
        Me.CmdHapus.Location = New System.Drawing.Point(393, 310)
        Me.CmdHapus.Name = "CmdHapus"
        Me.CmdHapus.Size = New System.Drawing.Size(75, 23)
        Me.CmdHapus.TabIndex = 46
        Me.CmdHapus.Text = "Hapus"
        Me.CmdHapus.UseVisualStyleBackColor = True
        '
        'CmdKeluar
        '
        Me.CmdKeluar.Location = New System.Drawing.Point(482, 310)
        Me.CmdKeluar.Name = "CmdKeluar"
        Me.CmdKeluar.Size = New System.Drawing.Size(75, 23)
        Me.CmdKeluar.TabIndex = 46
        Me.CmdKeluar.Text = "Keluar"
        Me.CmdKeluar.UseVisualStyleBackColor = True
        '
        'TxtKodeFaskes
        '
        Me.TxtKodeFaskes.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtKodeFaskes.Location = New System.Drawing.Point(133, 117)
        Me.TxtKodeFaskes.Name = "TxtKodeFaskes"
        Me.TxtKodeFaskes.ReadOnly = True
        Me.TxtKodeFaskes.Size = New System.Drawing.Size(61, 20)
        Me.TxtKodeFaskes.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Dirujuk Ke"
        '
        'CmdCariFaskes
        '
        Me.CmdCariFaskes.Location = New System.Drawing.Point(200, 115)
        Me.CmdCariFaskes.Name = "CmdCariFaskes"
        Me.CmdCariFaskes.Size = New System.Drawing.Size(40, 23)
        Me.CmdCariFaskes.TabIndex = 47
        Me.CmdCariFaskes.Text = "Cari"
        Me.CmdCariFaskes.UseVisualStyleBackColor = True
        '
        'TxtDirujukKe
        '
        Me.TxtDirujukKe.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtDirujukKe.Location = New System.Drawing.Point(246, 117)
        Me.TxtDirujukKe.Name = "TxtDirujukKe"
        Me.TxtDirujukKe.ReadOnly = True
        Me.TxtDirujukKe.Size = New System.Drawing.Size(288, 20)
        Me.TxtDirujukKe.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Jns. Layanan"
        '
        'CboJnsPelayanan
        '
        Me.CboJnsPelayanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboJnsPelayanan.FormattingEnabled = True
        Me.CboJnsPelayanan.Items.AddRange(New Object() {"Rawat Inap", "Rawat Jalan"})
        Me.CboJnsPelayanan.Location = New System.Drawing.Point(133, 143)
        Me.CboJnsPelayanan.Name = "CboJnsPelayanan"
        Me.CboJnsPelayanan.Size = New System.Drawing.Size(161, 21)
        Me.CboJnsPelayanan.TabIndex = 48
        '
        'CmdCariDiagnosa
        '
        Me.CmdCariDiagnosa.Location = New System.Drawing.Point(200, 167)
        Me.CmdCariDiagnosa.Name = "CmdCariDiagnosa"
        Me.CmdCariDiagnosa.Size = New System.Drawing.Size(40, 23)
        Me.CmdCariDiagnosa.TabIndex = 47
        Me.CmdCariDiagnosa.Text = "Cari"
        Me.CmdCariDiagnosa.UseVisualStyleBackColor = True
        '
        'CboTipeRujukan
        '
        Me.CboTipeRujukan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipeRujukan.FormattingEnabled = True
        Me.CboTipeRujukan.Items.AddRange(New Object() {"Penuh", "Parsial", "Rujuk Balik"})
        Me.CboTipeRujukan.Location = New System.Drawing.Point(133, 194)
        Me.CboTipeRujukan.Name = "CboTipeRujukan"
        Me.CboTipeRujukan.Size = New System.Drawing.Size(161, 21)
        Me.CboTipeRujukan.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Tipe Rujukan"
        '
        'CmdCariPoli
        '
        Me.CmdCariPoli.Location = New System.Drawing.Point(200, 218)
        Me.CmdCariPoli.Name = "CmdCariPoli"
        Me.CmdCariPoli.Size = New System.Drawing.Size(40, 23)
        Me.CmdCariPoli.TabIndex = 47
        Me.CmdCariPoli.Text = "Cari"
        Me.CmdCariPoli.UseVisualStyleBackColor = True
        '
        'TxtNoRujukan
        '
        Me.TxtNoRujukan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNoRujukan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoRujukan.Location = New System.Drawing.Point(133, 35)
        Me.TxtNoRujukan.Name = "TxtNoRujukan"
        Me.TxtNoRujukan.Size = New System.Drawing.Size(358, 29)
        Me.TxtNoRujukan.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "No. Rujukan"
        '
        'FrmRujukan
        '
        Me.ClientSize = New System.Drawing.Size(569, 346)
        Me.Controls.Add(Me.CboTipeRujukan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CboJnsPelayanan)
        Me.Controls.Add(Me.CmdCariPoli)
        Me.Controls.Add(Me.CmdCariDiagnosa)
        Me.Controls.Add(Me.CmdCariFaskes)
        Me.Controls.Add(Me.CmdKeluar)
        Me.Controls.Add(Me.CmdHapus)
        Me.Controls.Add(Me.CmdUpdate)
        Me.Controls.Add(Me.CmdInsert)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmdCariDetail)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtNoSEP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtUmurSekarang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtDeskripsiPoli)
        Me.Controls.Add(Me.TxtKodePoli)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDiagnosa)
        Me.Controls.Add(Me.TxtKodeDX)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtKodeFaskes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDirujukKe)
        Me.Controls.Add(Me.txtNamaPeserta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNoRujukan)
        Me.Controls.Add(Me.TxtNoPeserta)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRujukan"
        Me.Text = "Rujukan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub CmdKeluar_Click(sender As Object, e As EventArgs) Handles CmdKeluar.Click
        Me.Close()
    End Sub

    Private Sub CmdCariFaskes_Click(sender As Object, e As EventArgs) Handles CmdCariFaskes.Click

        Dim sForm As Form = New frmLookupReferensi(frmLookupReferensi.JenisReferensi.Faskes)
        sForm.Text = "Pencarian Faskes"

        sForm.ShowDialog(Me)

        If Not cVariable.LookupResult.Count = 0 Then
            TxtKodeFaskes.Text = cVariable.LookupResult(0)
            TxtDirujukKe.Text = cVariable.LookupResult(1)

        End If
    End Sub

    Private Sub CmdCariDiagnosa_Click(sender As Object, e As EventArgs) Handles CmdCariDiagnosa.Click
        Dim sForm As Form = New frmLookupReferensi(frmLookupReferensi.JenisReferensi.Diagnosa)
        sForm.ShowDialog(Me)

        If Not cVariable.LookupResult.Count = 0 Then
            TxtKodeDX.Text = cVariable.LookupResult(0)
            TxtDiagnosa.Text = cVariable.LookupResult(1)

        End If
    End Sub

    Private Sub CmdCariDetail_Click(sender As Object, e As EventArgs) Handles CmdCariDetail.Click
        If JKNBridge.VClaimLib.SEP.wsCariSEP(TxtNoSEP.Text.Trim, cVariable.URL, cVariable.ConsID, cVariable.SecretKey) Then
            If JKNBridge.VClaimLib.SEP.rsCariSEP.MetaData.Code.Equals("200") Then
                With JKNBridge.VClaimLib.SEP.rsCariSEP.Response
                    TxtNoPeserta.Text = .Peserta.NoKartu
                    txtNamaPeserta.Text = .Peserta.Nama
                End With

            Else
                MessageBox.Show(JKNBridge.VClaimLib.SEP.rsCariSEP.MetaData.Message)
            End If

        End If

    End Sub

    Private Sub CmdCariPoli_Click(sender As Object, e As EventArgs) Handles CmdCariPoli.Click
        Dim sForm As Form = New frmLookupReferensi(frmLookupReferensi.JenisReferensi.Poli)
        sForm.ShowDialog(Me)

        If Not cVariable.LookupResult.Count = 0 Then
            TxtKodePoli.Text = cVariable.LookupResult(0)
            TxtDeskripsiPoli.Text = cVariable.LookupResult(1)

        End If
    End Sub

    Private Sub CmdInsert_Click(sender As Object, e As EventArgs) Handles CmdInsert.Click
        Dim oRDTO As New JKNBridge.VClaimLib.TRujukan
        Try
            oRDTO.Catatan = "Catatan"
            oRDTO.DiagRujukan = TxtKodeDX.Text.Trim
            oRDTO.JnsPelayanan = CboJnsPelayanan.SelectedIndex + 1
            oRDTO.NoSep = TxtNoSEP.Text.Trim
            oRDTO.PoliRujukan = TxtKodePoli.Text.Trim
            oRDTO.PpkDirujuk = TxtKodeFaskes.Text.Trim
            oRDTO.TglRujukan = Date.Today.ToString("yyyy-MM-dd")
            oRDTO.TipeRujukan = CboTipeRujukan.SelectedIndex + 1
            oRDTO.User = "9999"

            JKNBridge.VClaimLib.Rujukan.wsInsertRujukan(oRDTO, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)

            If JKNBridge.VClaimLib.Rujukan.rsInsertRujukan.MetaData.Code.Equals("200") Then
                TxtNoRujukan.Text = JKNBridge.VClaimLib.Rujukan.rsInsertRujukan.Response.Rujukan.NoRujukan
                MessageBox.Show("Berhasil")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CmdUpdate_Click(sender As Object, e As EventArgs) Handles CmdUpdate.Click
        Dim oRDTO As New JKNBridge.VClaimLib.TRujukan

        Try
            oRDTO.Catatan = "Catatan"
            oRDTO.DiagRujukan = TxtKodeDX.Text.Trim
            oRDTO.JnsPelayanan = CboJnsPelayanan.SelectedIndex + 1
            oRDTO.NoSep = TxtNoSEP.Text.Trim
            oRDTO.PoliRujukan = TxtKodePoli.Text.Trim
            oRDTO.PpkDirujuk = TxtKodeFaskes.Text.Trim
            oRDTO.TglRujukan = Date.Today.ToString("yyyy-MM-dd")
            oRDTO.TipeRujukan = CboTipeRujukan.SelectedIndex + 1
            oRDTO.User = "9999"

            JKNBridge.VClaimLib.Rujukan.wsUpdateRujukan(oRDTO, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
            If JKNBridge.VClaimLib.Rujukan.rsUpdateRujukan.MetaData.Code.Equals("200") Then
                MessageBox.Show("Berhasil")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CmdHapus_Click(sender As Object, e As EventArgs) Handles CmdHapus.Click
        Try
            JKNBridge.VClaimLib.Rujukan.wsDeleteRujukan(TxtNoRujukan.Text.Trim, cVariable.UserWS, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
            If JKNBridge.VClaimLib.Rujukan.rsDeleteRujukan.MetaData.Code.Equals("200") Then
                MessageBox.Show("Berhasil")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
