Imports JKNBridge.VClaimLib

Public Class frmGetRujukan
    Inherits System.Windows.Forms.Form
#Region "FormBuilder"
    Friend WithEvents CmdGo As Button
    Friend WithEvents TxtParameter As TextBox
    Friend WithEvents optNoRujukan As RadioButton
    Friend WithEvents optNoPeserta As RadioButton
    Friend WithEvents lsvReferensi As ListView
    Friend WithEvents optPPK2 As RadioButton
    Friend WithEvents optPPK1 As RadioButton
    Friend WithEvents CmdKeluar As Button
    Friend WithEvents GroupBox1 As GroupBox

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.CmdGo = New System.Windows.Forms.Button()
        Me.TxtParameter = New System.Windows.Forms.TextBox()
        Me.optNoRujukan = New System.Windows.Forms.RadioButton()
        Me.optNoPeserta = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optPPK2 = New System.Windows.Forms.RadioButton()
        Me.optPPK1 = New System.Windows.Forms.RadioButton()
        Me.lsvReferensi = New System.Windows.Forms.ListView()
        Me.CmdKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdGo
        '
        Me.CmdGo.Location = New System.Drawing.Point(548, 10)
        Me.CmdGo.Name = "CmdGo"
        Me.CmdGo.Size = New System.Drawing.Size(75, 23)
        Me.CmdGo.TabIndex = 29
        Me.CmdGo.Text = "Cari"
        Me.CmdGo.UseVisualStyleBackColor = True
        '
        'TxtParameter
        '
        Me.TxtParameter.Location = New System.Drawing.Point(300, 12)
        Me.TxtParameter.Name = "TxtParameter"
        Me.TxtParameter.Size = New System.Drawing.Size(220, 20)
        Me.TxtParameter.TabIndex = 28
        '
        'optNoRujukan
        '
        Me.optNoRujukan.AutoSize = True
        Me.optNoRujukan.Location = New System.Drawing.Point(171, 12)
        Me.optNoRujukan.Name = "optNoRujukan"
        Me.optNoRujukan.Size = New System.Drawing.Size(128, 17)
        Me.optNoRujukan.TabIndex = 26
        Me.optNoRujukan.Text = "Berdasarkan Rujukan"
        Me.optNoRujukan.UseVisualStyleBackColor = True
        '
        'optNoPeserta
        '
        Me.optNoPeserta.AutoSize = True
        Me.optNoPeserta.Checked = True
        Me.optNoPeserta.Location = New System.Drawing.Point(21, 12)
        Me.optNoPeserta.Name = "optNoPeserta"
        Me.optNoPeserta.Size = New System.Drawing.Size(144, 17)
        Me.optNoPeserta.TabIndex = 27
        Me.optNoPeserta.TabStop = True
        Me.optNoPeserta.Text = "Berdasarkan No. Peserta"
        Me.optNoPeserta.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optPPK2)
        Me.GroupBox1.Controls.Add(Me.optPPK1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 34)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'optPPK2
        '
        Me.optPPK2.AutoSize = True
        Me.optPPK2.Location = New System.Drawing.Point(536, 11)
        Me.optPPK2.Name = "optPPK2"
        Me.optPPK2.Size = New System.Drawing.Size(118, 17)
        Me.optPPK2.TabIndex = 0
        Me.optPPK2.Text = "Asal Rujukan PPK2"
        Me.optPPK2.UseVisualStyleBackColor = True
        '
        'optPPK1
        '
        Me.optPPK1.AutoSize = True
        Me.optPPK1.Checked = True
        Me.optPPK1.Location = New System.Drawing.Point(366, 11)
        Me.optPPK1.Name = "optPPK1"
        Me.optPPK1.Size = New System.Drawing.Size(118, 17)
        Me.optPPK1.TabIndex = 0
        Me.optPPK1.TabStop = True
        Me.optPPK1.Text = "Asal Rujukan PPK1"
        Me.optPPK1.UseVisualStyleBackColor = True
        '
        'lsvReferensi
        '
        Me.lsvReferensi.FullRowSelect = True
        Me.lsvReferensi.GridLines = True
        Me.lsvReferensi.Location = New System.Drawing.Point(12, 78)
        Me.lsvReferensi.Name = "lsvReferensi"
        Me.lsvReferensi.Size = New System.Drawing.Size(670, 271)
        Me.lsvReferensi.TabIndex = 30
        Me.lsvReferensi.UseCompatibleStateImageBehavior = False
        Me.lsvReferensi.View = System.Windows.Forms.View.Details
        '
        'CmdKeluar
        '
        Me.CmdKeluar.Location = New System.Drawing.Point(558, 354)
        Me.CmdKeluar.Name = "CmdKeluar"
        Me.CmdKeluar.Size = New System.Drawing.Size(108, 23)
        Me.CmdKeluar.TabIndex = 31
        Me.CmdKeluar.Text = "Keluar"
        Me.CmdKeluar.UseVisualStyleBackColor = True
        '
        'frmGetRujukan
        '
        Me.ClientSize = New System.Drawing.Size(695, 384)
        Me.Controls.Add(Me.CmdKeluar)
        Me.Controls.Add(Me.lsvReferensi)
        Me.Controls.Add(Me.CmdGo)
        Me.Controls.Add(Me.TxtParameter)
        Me.Controls.Add(Me.optNoRujukan)
        Me.Controls.Add(Me.optNoPeserta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGetRujukan"
        Me.Text = "Sample methode GetRujukan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Private Sub CmdGo_Click(sender As Object, e As EventArgs) Handles CmdGo.Click
        Try
            If String.IsNullOrEmpty(TxtParameter.Text.Trim) Then
                MessageBox.Show("Parameter pencarian tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If optNoPeserta.Checked Then
                If optPPK1.Checked Then
                    Rujukan.wsGetRujukanByNoKAMulti(Rujukan.eJenisRujukan.PPK1, TxtParameter.Text.Trim, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
                Else
                    Rujukan.wsGetRujukanByNoKAMulti(Rujukan.eJenisRujukan.PPK2, TxtParameter.Text.Trim, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
                End If

                If Rujukan.rsDataRujukanMultiRecord.MetaData.Code.Equals("200") Then
                    lsvReferensi.Items.Clear()
                    lsvReferensi.Columns.Clear()

                    lsvReferensi.Columns.Clear()
                    lsvReferensi.Columns.Add("No. Rujukan", Integer.Parse(100))
                    lsvReferensi.Columns.Add("No. Peserta", Integer.Parse(100))
                    lsvReferensi.Columns.Add("Nama.", Integer.Parse(250))
                    lsvReferensi.Columns.Add("kode DX", Integer.Parse(100))
                    lsvReferensi.Columns.Add("Diagnosa", Integer.Parse(300))
                    lsvReferensi.Columns.Add("Keluhan", Integer.Parse(200))
                    lsvReferensi.Columns.Add("Tgl. Kunjungan", Integer.Parse(100))
                    lsvReferensi.Columns.Add("Klinik Tujuan", Integer.Parse(100))

                    For nItem As Integer = 0 To Rujukan.rsDataRujukanMultiRecord.Response.Rujukan.Count - 1
                        lsvReferensi.Items.Add(Rujukan.rsDataRujukanMultiRecord.Response.Rujukan(nItem).NoKunjungan)
                        lsvReferensi.Items(nItem).SubItems.Add(Rujukan.rsDataRujukanMultiRecord.Response.Rujukan(nItem).Peserta.NoKartu)
                        lsvReferensi.Items(nItem).SubItems.Add(Rujukan.rsDataRujukanMultiRecord.Response.Rujukan(nItem).Peserta.Nama)
                        lsvReferensi.Items(nItem).SubItems.Add(Rujukan.rsDataRujukanMultiRecord.Response.Rujukan(nItem).Diagnosa.Kode)
                        lsvReferensi.Items(nItem).SubItems.Add(Rujukan.rsDataRujukanMultiRecord.Response.Rujukan(nItem).Diagnosa.Nama)
                        lsvReferensi.Items(nItem).SubItems.Add(Rujukan.rsDataRujukanMultiRecord.Response.Rujukan(nItem).Keluhan)
                        lsvReferensi.Items(nItem).SubItems.Add(Rujukan.rsDataRujukanMultiRecord.Response.Rujukan(nItem).TglKunjungan)
                        lsvReferensi.Items(nItem).SubItems.Add(Rujukan.rsDataRujukanMultiRecord.Response.Rujukan(nItem).Pelayanan.Nama)

                    Next
                End If
            Else
                If optPPK1.Checked Then
                    Rujukan.wsGetRujukanByNoRujukan(Rujukan.eJenisRujukan.PPK1, TxtParameter.Text.Trim, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
                Else
                    Rujukan.wsGetRujukanByNoRujukan(Rujukan.eJenisRujukan.PPK2, TxtParameter.Text.Trim, cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
                End If

                If Rujukan.rsDataRujukan.MetaData.Code.Equals("200") Then
                    lsvReferensi.Items.Clear()
                    lsvReferensi.Columns.Clear()

                    lsvReferensi.Columns.Clear()
                    lsvReferensi.Columns.Add("No. Rujukan", Integer.Parse(100))
                    lsvReferensi.Columns.Add("No. Peserta", Integer.Parse(100))
                    lsvReferensi.Columns.Add("Nama.", Integer.Parse(250))
                    lsvReferensi.Columns.Add("kode DX", Integer.Parse(100))
                    lsvReferensi.Columns.Add("Diagnosa", Integer.Parse(300))
                    lsvReferensi.Columns.Add("Keluhan", Integer.Parse(200))
                    lsvReferensi.Columns.Add("Tgl. Kunjungan", Integer.Parse(100))
                    lsvReferensi.Columns.Add("Klinik Tujuan", Integer.Parse(100))

                    lsvReferensi.Items.Add(Rujukan.rsDataRujukan.Response.Rujukan.NoKunjungan)
                    lsvReferensi.Items(0).SubItems.Add(Rujukan.rsDataRujukan.Response.Rujukan.Peserta.NoKartu)
                    lsvReferensi.Items(0).SubItems.Add(Rujukan.rsDataRujukan.Response.Rujukan.Peserta.Nama)
                    lsvReferensi.Items(0).SubItems.Add(Rujukan.rsDataRujukan.Response.Rujukan.Diagnosa.Kode)
                    lsvReferensi.Items(0).SubItems.Add(Rujukan.rsDataRujukan.Response.Rujukan.Diagnosa.Nama)
                    lsvReferensi.Items(0).SubItems.Add(Rujukan.rsDataRujukan.Response.Rujukan.Keluhan)
                    lsvReferensi.Items(0).SubItems.Add(Rujukan.rsDataRujukan.Response.Rujukan.TglKunjungan)
                    lsvReferensi.Items(0).SubItems.Add(Rujukan.rsDataRujukan.Response.Rujukan.PoliRujukan.Nama)

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CmdKeluar_Click(sender As Object, e As EventArgs) Handles CmdKeluar.Click
        Me.Close()
    End Sub
End Class
