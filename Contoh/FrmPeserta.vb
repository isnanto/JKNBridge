Imports JKNBridge.VClaimLib
Public Class FrmPeserta
    Inherits System.Windows.Forms.Form

#Region "Form Builder"
    Friend WithEvents TxtNoPeserta As TextBox

    Friend WithEvents Label1 As Label

    Friend WithEvents Label2 As Label

    Friend WithEvents txtNamaPeserta As TextBox

    Friend WithEvents Label3 As Label

    Friend WithEvents txtNIK As TextBox

    Friend WithEvents Label4 As Label

    Friend WithEvents TxtPISA As TextBox

    Friend WithEvents Label5 As Label

    Friend WithEvents TxtKodePPK1 As TextBox

    Friend WithEvents TxtDeskripsiPPK1 As TextBox

    Friend WithEvents Label6 As Label

    Friend WithEvents TxtJenisKelamin As TextBox

    Friend WithEvents Label7 As Label

    Friend WithEvents TxtStatusPeserta As TextBox

    Friend WithEvents Label8 As Label

    Friend WithEvents TxtJnsPeserta As TextBox

    Friend WithEvents Label9 As Label

    Friend WithEvents TxtKodeHakKelas As TextBox

    Friend WithEvents TxtHakKelas As TextBox

    Friend WithEvents Label10 As Label

    Friend WithEvents TxtUmurSekarang As TextBox

    Friend WithEvents GroupBox1 As GroupBox

    Friend WithEvents CmdKeluar As Button

    Friend WithEvents optNoPeserta As RadioButton

    Friend WithEvents optNIK As RadioButton

    Friend WithEvents TxtParameter As TextBox

    Friend WithEvents CmdGo As Button

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.TxtNoPeserta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaPeserta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNIK = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPISA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtKodePPK1 = New System.Windows.Forms.TextBox()
        Me.TxtDeskripsiPPK1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtJenisKelamin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtStatusPeserta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtJnsPeserta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtKodeHakKelas = New System.Windows.Forms.TextBox()
        Me.TxtHakKelas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtUmurSekarang = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmdKeluar = New System.Windows.Forms.Button()
        Me.optNoPeserta = New System.Windows.Forms.RadioButton()
        Me.optNIK = New System.Windows.Forms.RadioButton()
        Me.TxtParameter = New System.Windows.Forms.TextBox()
        Me.CmdGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNoPeserta
        '
        Me.TxtNoPeserta.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNoPeserta.Location = New System.Drawing.Point(132, 79)
        Me.TxtNoPeserta.Name = "TxtNoPeserta"
        Me.TxtNoPeserta.ReadOnly = True
        Me.TxtNoPeserta.Size = New System.Drawing.Size(138, 20)
        Me.TxtNoPeserta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. Peserta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Peserta"
        '
        'txtNamaPeserta
        '
        Me.txtNamaPeserta.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtNamaPeserta.Location = New System.Drawing.Point(132, 105)
        Me.txtNamaPeserta.Name = "txtNamaPeserta"
        Me.txtNamaPeserta.ReadOnly = True
        Me.txtNamaPeserta.Size = New System.Drawing.Size(254, 20)
        Me.txtNamaPeserta.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NIK"
        '
        'txtNIK
        '
        Me.txtNIK.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtNIK.Location = New System.Drawing.Point(132, 131)
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.ReadOnly = True
        Me.txtNIK.Size = New System.Drawing.Size(171, 20)
        Me.txtNIK.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "P/I/S/A"
        '
        'TxtPISA
        '
        Me.TxtPISA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtPISA.Location = New System.Drawing.Point(132, 157)
        Me.TxtPISA.Name = "TxtPISA"
        Me.TxtPISA.ReadOnly = True
        Me.TxtPISA.Size = New System.Drawing.Size(138, 20)
        Me.TxtPISA.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PPK 1"
        '
        'TxtKodePPK1
        '
        Me.TxtKodePPK1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtKodePPK1.Location = New System.Drawing.Point(132, 183)
        Me.TxtKodePPK1.Name = "TxtKodePPK1"
        Me.TxtKodePPK1.ReadOnly = True
        Me.TxtKodePPK1.Size = New System.Drawing.Size(84, 20)
        Me.TxtKodePPK1.TabIndex = 8
        '
        'TxtDeskripsiPPK1
        '
        Me.TxtDeskripsiPPK1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtDeskripsiPPK1.Location = New System.Drawing.Point(222, 183)
        Me.TxtDeskripsiPPK1.Name = "TxtDeskripsiPPK1"
        Me.TxtDeskripsiPPK1.ReadOnly = True
        Me.TxtDeskripsiPPK1.Size = New System.Drawing.Size(262, 20)
        Me.TxtDeskripsiPPK1.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Jenis Kelamin"
        '
        'TxtJenisKelamin
        '
        Me.TxtJenisKelamin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtJenisKelamin.Location = New System.Drawing.Point(132, 209)
        Me.TxtJenisKelamin.Name = "TxtJenisKelamin"
        Me.TxtJenisKelamin.ReadOnly = True
        Me.TxtJenisKelamin.Size = New System.Drawing.Size(138, 20)
        Me.TxtJenisKelamin.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Status Peserta"
        '
        'TxtStatusPeserta
        '
        Me.TxtStatusPeserta.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtStatusPeserta.Location = New System.Drawing.Point(132, 235)
        Me.TxtStatusPeserta.Name = "TxtStatusPeserta"
        Me.TxtStatusPeserta.ReadOnly = True
        Me.TxtStatusPeserta.Size = New System.Drawing.Size(207, 20)
        Me.TxtStatusPeserta.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Jenis Peserta"
        '
        'TxtJnsPeserta
        '
        Me.TxtJnsPeserta.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtJnsPeserta.Location = New System.Drawing.Point(132, 261)
        Me.TxtJnsPeserta.Name = "TxtJnsPeserta"
        Me.TxtJnsPeserta.ReadOnly = True
        Me.TxtJnsPeserta.Size = New System.Drawing.Size(138, 20)
        Me.TxtJnsPeserta.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Hak Kelas"
        '
        'TxtKodeHakKelas
        '
        Me.TxtKodeHakKelas.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtKodeHakKelas.Location = New System.Drawing.Point(132, 287)
        Me.TxtKodeHakKelas.Name = "TxtKodeHakKelas"
        Me.TxtKodeHakKelas.ReadOnly = True
        Me.TxtKodeHakKelas.Size = New System.Drawing.Size(84, 20)
        Me.TxtKodeHakKelas.TabIndex = 16
        '
        'TxtHakKelas
        '
        Me.TxtHakKelas.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtHakKelas.Location = New System.Drawing.Point(222, 287)
        Me.TxtHakKelas.Name = "TxtHakKelas"
        Me.TxtHakKelas.ReadOnly = True
        Me.TxtHakKelas.Size = New System.Drawing.Size(196, 20)
        Me.TxtHakKelas.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 316)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Umur Sekarang"
        '
        'TxtUmurSekarang
        '
        Me.TxtUmurSekarang.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtUmurSekarang.Location = New System.Drawing.Point(132, 313)
        Me.TxtUmurSekarang.Name = "TxtUmurSekarang"
        Me.TxtUmurSekarang.ReadOnly = True
        Me.TxtUmurSekarang.Size = New System.Drawing.Size(254, 20)
        Me.TxtUmurSekarang.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(3, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 10)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'CmdKeluar
        '
        Me.CmdKeluar.Location = New System.Drawing.Point(524, 349)
        Me.CmdKeluar.Name = "CmdKeluar"
        Me.CmdKeluar.Size = New System.Drawing.Size(92, 23)
        Me.CmdKeluar.TabIndex = 21
        Me.CmdKeluar.Text = "Keluar"
        Me.CmdKeluar.UseVisualStyleBackColor = True
        '
        'optNoPeserta
        '
        Me.optNoPeserta.AutoSize = True
        Me.optNoPeserta.Checked = True
        Me.optNoPeserta.Location = New System.Drawing.Point(14, 23)
        Me.optNoPeserta.Name = "optNoPeserta"
        Me.optNoPeserta.Size = New System.Drawing.Size(144, 17)
        Me.optNoPeserta.TabIndex = 22
        Me.optNoPeserta.TabStop = True
        Me.optNoPeserta.Text = "Berdasarkan No. Peserta"
        Me.optNoPeserta.UseVisualStyleBackColor = True
        '
        'optNIK
        '
        Me.optNIK.AutoSize = True
        Me.optNIK.Location = New System.Drawing.Point(164, 23)
        Me.optNIK.Name = "optNIK"
        Me.optNIK.Size = New System.Drawing.Size(106, 17)
        Me.optNIK.TabIndex = 22
        Me.optNIK.Text = "Berdasarkan NIK"
        Me.optNIK.UseVisualStyleBackColor = True
        '
        'TxtParameter
        '
        Me.TxtParameter.Location = New System.Drawing.Point(293, 23)
        Me.TxtParameter.Name = "TxtParameter"
        Me.TxtParameter.Size = New System.Drawing.Size(220, 20)
        Me.TxtParameter.TabIndex = 23
        '
        'CmdGo
        '
        Me.CmdGo.Location = New System.Drawing.Point(541, 21)
        Me.CmdGo.Name = "CmdGo"
        Me.CmdGo.Size = New System.Drawing.Size(75, 23)
        Me.CmdGo.TabIndex = 24
        Me.CmdGo.Text = "Cari"
        Me.CmdGo.UseVisualStyleBackColor = True
        '
        'FrmPeserta
        '
        Me.ClientSize = New System.Drawing.Size(1046, 404)
        Me.Controls.Add(Me.CmdGo)
        Me.Controls.Add(Me.TxtParameter)
        Me.Controls.Add(Me.optNIK)
        Me.Controls.Add(Me.optNoPeserta)
        Me.Controls.Add(Me.CmdKeluar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtUmurSekarang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtHakKelas)
        Me.Controls.Add(Me.TxtKodeHakKelas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtJnsPeserta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtStatusPeserta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtJenisKelamin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDeskripsiPPK1)
        Me.Controls.Add(Me.TxtKodePPK1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPISA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNIK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNamaPeserta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNoPeserta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPeserta"
        Me.Text = "Pencarian Peserta JKN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private Sub ResetForm()
        For Each ocon As Control In Me.Controls
            If TypeOf (ocon) Is TextBox Then
                If ocon.Name.ToUpper = "TxtParameter" Then

                Else
                    ocon.Text = ""
                End If

            End If
        Next
    End Sub

    Private Sub CmdGo_Click(sender As Object, e As EventArgs) Handles CmdGo.Click
        If String.IsNullOrEmpty(TxtParameter.Text.Trim) Then
            MessageBox.Show("Pencarian tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtParameter.Focus()
        Else
            'Dim Peserta As New JKNBridge.VClaimLib.Peserta

            If optNIK.Checked Then
                Peserta.wsGetPesertabyNIK(TxtParameter.Text.Trim, Date.Today.ToString("yyyy-MM-dd"), cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
            Else
                Peserta.wsGetPesertaByKA(TxtParameter.Text.Trim, Date.Today.ToString("yyyy-MM-dd"), cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
            End If

            If Not Peserta.rsGetPeserta.MetaData.Code.Equals("200") Then
                MessageBox.Show(Peserta.rsGetPeserta.MetaData.Code & " - " & Peserta.rsGetPeserta.MetaData.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                With Peserta.rsGetPeserta.Response.Peserta
                    TxtNoPeserta.Text = .NoKartu
                    txtNamaPeserta.Text = .Nama
                    txtNIK.Text = .Nik
                    TxtPISA.Text = .Pisa
                    TxtKodePPK1.Text = .ProvUmum.KdProvider
                    TxtDeskripsiPPK1.Text = .ProvUmum.NmProvider
                    TxtJenisKelamin.Text = .Sex
                    TxtStatusPeserta.Text = .StatusPeserta.Keterangan
                    TxtJnsPeserta.Text = .JenisPeserta.Keterangan
                    TxtKodeHakKelas.Text = .HakKelas.Kode
                    TxtHakKelas.Text = .HakKelas.Keterangan
                    TxtUmurSekarang.Text = .Umur.UmurSekarang
                End With
            End If
        End If
    End Sub

    Private Sub CmdKeluar_Click(sender As Object, e As EventArgs) Handles CmdKeluar.Click
        Me.Close()
    End Sub

    Private Sub FrmPeserta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
    End Sub
End Class
