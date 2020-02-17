Imports JKNBridge.VClaimLib
Public Class FrmSEP
    Inherits Form
#Region "FormBuilder"
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtKeteranganKLL As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtHakKelas As TextBox
    Friend WithEvents TxtKodeHakKelas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNoPasien As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNoRujukan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamaPeserta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNoPeserta As TextBox
    Friend WithEvents DPTglSEP As DateTimePicker
    Friend WithEvents CboJnsPelayanan As ComboBox
    Friend WithEvents CmdCariPPKAsal As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtKodePPKAsal As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CboAsalRujukan As ComboBox
    Friend WithEvents DPTglRujukan As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CmdCariDiagnosa As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtDiagnosa As TextBox
    Friend WithEvents TxtKodeDX As TextBox
    Friend WithEvents CmdCariPoli As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtDeskripsiPoli As TextBox
    Friend WithEvents TxtKodePoli As TextBox
    Friend WithEvents ChkCOB As CheckBox
    Friend WithEvents ChkKatarak As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtProv As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtKab As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtKec As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNoSuplesi As TextBox
    Friend WithEvents DPTglKejadian As DateTimePicker
    Friend WithEvents ChkSuplesi As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CboPenjamin As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ChkKLL As CheckBox
    Friend WithEvents TxtNoSKDP As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtDPJP As TextBox
    Friend WithEvents TxtNamaDokter As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents CmdCariDPJP As Button
    Friend WithEvents TxtNoTelepon As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents ChkPoliEksekutif As CheckBox
    Friend WithEvents TxtCatatan As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents CmdInsertSEP As Button
    Friend WithEvents CmdCariPeserta As Button
    Friend WithEvents TextBox1 As TextBox

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtKeteranganKLL = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtHakKelas = New System.Windows.Forms.TextBox()
        Me.TxtKodeHakKelas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNoPasien = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNoRujukan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaPeserta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNoPeserta = New System.Windows.Forms.TextBox()
        Me.DPTglSEP = New System.Windows.Forms.DateTimePicker()
        Me.CboJnsPelayanan = New System.Windows.Forms.ComboBox()
        Me.CmdCariPPKAsal = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtKodePPKAsal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboAsalRujukan = New System.Windows.Forms.ComboBox()
        Me.DPTglRujukan = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CmdCariDiagnosa = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtDiagnosa = New System.Windows.Forms.TextBox()
        Me.TxtKodeDX = New System.Windows.Forms.TextBox()
        Me.CmdCariPoli = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtDeskripsiPoli = New System.Windows.Forms.TextBox()
        Me.TxtKodePoli = New System.Windows.Forms.TextBox()
        Me.ChkCOB = New System.Windows.Forms.CheckBox()
        Me.ChkKatarak = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtProv = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtKab = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtKec = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNoSuplesi = New System.Windows.Forms.TextBox()
        Me.DPTglKejadian = New System.Windows.Forms.DateTimePicker()
        Me.ChkSuplesi = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboPenjamin = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChkKLL = New System.Windows.Forms.CheckBox()
        Me.TxtNoSKDP = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtDPJP = New System.Windows.Forms.TextBox()
        Me.TxtNamaDokter = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CmdCariDPJP = New System.Windows.Forms.Button()
        Me.TxtNoTelepon = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ChkPoliEksekutif = New System.Windows.Forms.CheckBox()
        Me.TxtCatatan = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CmdInsertSEP = New System.Windows.Forms.Button()
        Me.CmdCariPeserta = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 384)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 47)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEP "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(37, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(354, 26)
        Me.TextBox1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Keterangan KLL"
        '
        'TxtKeteranganKLL
        '
        Me.TxtKeteranganKLL.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtKeteranganKLL.Location = New System.Drawing.Point(96, 63)
        Me.TxtKeteranganKLL.Name = "TxtKeteranganKLL"
        Me.TxtKeteranganKLL.ReadOnly = True
        Me.TxtKeteranganKLL.Size = New System.Drawing.Size(511, 20)
        Me.TxtKeteranganKLL.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Kelas"
        '
        'TxtHakKelas
        '
        Me.TxtHakKelas.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtHakKelas.Location = New System.Drawing.Point(174, 114)
        Me.TxtHakKelas.Name = "TxtHakKelas"
        Me.TxtHakKelas.ReadOnly = True
        Me.TxtHakKelas.Size = New System.Drawing.Size(183, 20)
        Me.TxtHakKelas.TabIndex = 38
        '
        'TxtKodeHakKelas
        '
        Me.TxtKodeHakKelas.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtKodeHakKelas.Location = New System.Drawing.Point(112, 114)
        Me.TxtKodeHakKelas.Name = "TxtKodeHakKelas"
        Me.TxtKodeHakKelas.ReadOnly = True
        Me.TxtKodeHakKelas.Size = New System.Drawing.Size(56, 20)
        Me.TxtKodeHakKelas.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "No. Pasien"
        '
        'TxtNoPasien
        '
        Me.TxtNoPasien.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNoPasien.Location = New System.Drawing.Point(432, 114)
        Me.TxtNoPasien.Name = "TxtNoPasien"
        Me.TxtNoPasien.ReadOnly = True
        Me.TxtNoPasien.Size = New System.Drawing.Size(143, 20)
        Me.TxtNoPasien.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Tgl. SEP"
        '
        'TxtNoRujukan
        '
        Me.TxtNoRujukan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNoRujukan.Location = New System.Drawing.Point(443, 19)
        Me.TxtNoRujukan.Name = "TxtNoRujukan"
        Me.TxtNoRujukan.ReadOnly = True
        Me.TxtNoRujukan.Size = New System.Drawing.Size(199, 20)
        Me.TxtNoRujukan.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nama Peserta"
        '
        'txtNamaPeserta
        '
        Me.txtNamaPeserta.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtNamaPeserta.Location = New System.Drawing.Point(112, 32)
        Me.txtNamaPeserta.Name = "txtNamaPeserta"
        Me.txtNamaPeserta.ReadOnly = True
        Me.txtNamaPeserta.Size = New System.Drawing.Size(254, 20)
        Me.txtNamaPeserta.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "No. Peserta"
        '
        'TxtNoPeserta
        '
        Me.TxtNoPeserta.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNoPeserta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoPeserta.Location = New System.Drawing.Point(112, 6)
        Me.TxtNoPeserta.Name = "TxtNoPeserta"
        Me.TxtNoPeserta.Size = New System.Drawing.Size(197, 22)
        Me.TxtNoPeserta.TabIndex = 20
        '
        'DPTglSEP
        '
        Me.DPTglSEP.Location = New System.Drawing.Point(112, 61)
        Me.DPTglSEP.Name = "DPTglSEP"
        Me.DPTglSEP.Size = New System.Drawing.Size(200, 20)
        Me.DPTglSEP.TabIndex = 42
        '
        'CboJnsPelayanan
        '
        Me.CboJnsPelayanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboJnsPelayanan.FormattingEnabled = True
        Me.CboJnsPelayanan.Items.AddRange(New Object() {"Rawat Inap", "Rawat Jalan"})
        Me.CboJnsPelayanan.Location = New System.Drawing.Point(112, 87)
        Me.CboJnsPelayanan.Name = "CboJnsPelayanan"
        Me.CboJnsPelayanan.Size = New System.Drawing.Size(161, 21)
        Me.CboJnsPelayanan.TabIndex = 54
        '
        'CmdCariPPKAsal
        '
        Me.CmdCariPPKAsal.Location = New System.Drawing.Point(324, 15)
        Me.CmdCariPPKAsal.Name = "CmdCariPPKAsal"
        Me.CmdCariPPKAsal.Size = New System.Drawing.Size(40, 23)
        Me.CmdCariPPKAsal.TabIndex = 53
        Me.CmdCariPPKAsal.Text = "Cari"
        Me.CmdCariPPKAsal.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Jns. Layanan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(169, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Kode Perujuk"
        '
        'TxtKodePPKAsal
        '
        Me.TxtKodePPKAsal.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtKodePPKAsal.Location = New System.Drawing.Point(257, 17)
        Me.TxtKodePPKAsal.Name = "TxtKodePPKAsal"
        Me.TxtKodePPKAsal.ReadOnly = True
        Me.TxtKodePPKAsal.Size = New System.Drawing.Size(61, 20)
        Me.TxtKodePPKAsal.TabIndex = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboAsalRujukan)
        Me.GroupBox2.Controls.Add(Me.DPTglRujukan)
        Me.GroupBox2.Controls.Add(Me.CmdCariPPKAsal)
        Me.GroupBox2.Controls.Add(Me.TxtKodePPKAsal)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtNoRujukan)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(112, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(648, 67)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rujukan"
        '
        'CboAsalRujukan
        '
        Me.CboAsalRujukan.FormattingEnabled = True
        Me.CboAsalRujukan.Items.AddRange(New Object() {"PPK1", "PPK2"})
        Me.CboAsalRujukan.Location = New System.Drawing.Point(82, 17)
        Me.CboAsalRujukan.Name = "CboAsalRujukan"
        Me.CboAsalRujukan.Size = New System.Drawing.Size(71, 21)
        Me.CboAsalRujukan.TabIndex = 55
        '
        'DPTglRujukan
        '
        Me.DPTglRujukan.Location = New System.Drawing.Point(82, 41)
        Me.DPTglRujukan.Name = "DPTglRujukan"
        Me.DPTglRujukan.Size = New System.Drawing.Size(200, 20)
        Me.DPTglRujukan.TabIndex = 54
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Tgl. Rujukan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Asal Rujukan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(370, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "No. Rujukan"
        '
        'CmdCariDiagnosa
        '
        Me.CmdCariDiagnosa.Location = New System.Drawing.Point(489, 62)
        Me.CmdCariDiagnosa.Name = "CmdCariDiagnosa"
        Me.CmdCariDiagnosa.Size = New System.Drawing.Size(40, 23)
        Me.CmdCariDiagnosa.TabIndex = 59
        Me.CmdCariDiagnosa.Text = "Cari"
        Me.CmdCariDiagnosa.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(366, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Diagnosa"
        '
        'TxtDiagnosa
        '
        Me.TxtDiagnosa.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtDiagnosa.Location = New System.Drawing.Point(535, 64)
        Me.TxtDiagnosa.Name = "TxtDiagnosa"
        Me.TxtDiagnosa.ReadOnly = True
        Me.TxtDiagnosa.Size = New System.Drawing.Size(288, 20)
        Me.TxtDiagnosa.TabIndex = 57
        '
        'TxtKodeDX
        '
        Me.TxtKodeDX.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtKodeDX.Location = New System.Drawing.Point(432, 64)
        Me.TxtKodeDX.Name = "TxtKodeDX"
        Me.TxtKodeDX.ReadOnly = True
        Me.TxtKodeDX.Size = New System.Drawing.Size(51, 20)
        Me.TxtKodeDX.TabIndex = 56
        '
        'CmdCariPoli
        '
        Me.CmdCariPoli.Location = New System.Drawing.Point(489, 87)
        Me.CmdCariPoli.Name = "CmdCariPoli"
        Me.CmdCariPoli.Size = New System.Drawing.Size(40, 23)
        Me.CmdCariPoli.TabIndex = 63
        Me.CmdCariPoli.Text = "Cari"
        Me.CmdCariPoli.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(366, 93)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "Poli Tujuan"
        '
        'TxtDeskripsiPoli
        '
        Me.TxtDeskripsiPoli.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtDeskripsiPoli.Location = New System.Drawing.Point(535, 90)
        Me.TxtDeskripsiPoli.Name = "TxtDeskripsiPoli"
        Me.TxtDeskripsiPoli.ReadOnly = True
        Me.TxtDeskripsiPoli.Size = New System.Drawing.Size(288, 20)
        Me.TxtDeskripsiPoli.TabIndex = 61
        '
        'TxtKodePoli
        '
        Me.TxtKodePoli.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtKodePoli.Location = New System.Drawing.Point(432, 90)
        Me.TxtKodePoli.Name = "TxtKodePoli"
        Me.TxtKodePoli.ReadOnly = True
        Me.TxtKodePoli.Size = New System.Drawing.Size(51, 20)
        Me.TxtKodePoli.TabIndex = 60
        '
        'ChkCOB
        '
        Me.ChkCOB.AutoSize = True
        Me.ChkCOB.Location = New System.Drawing.Point(112, 213)
        Me.ChkCOB.Name = "ChkCOB"
        Me.ChkCOB.Size = New System.Drawing.Size(48, 17)
        Me.ChkCOB.TabIndex = 64
        Me.ChkCOB.Text = "COB"
        Me.ChkCOB.UseVisualStyleBackColor = True
        '
        'ChkKatarak
        '
        Me.ChkKatarak.AutoSize = True
        Me.ChkKatarak.Location = New System.Drawing.Point(183, 213)
        Me.ChkKatarak.Name = "ChkKatarak"
        Me.ChkKatarak.Size = New System.Drawing.Size(63, 17)
        Me.ChkKatarak.TabIndex = 64
        Me.ChkKatarak.Text = "Katarak"
        Me.ChkKatarak.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtProv)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.TxtKab)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.TxtKec)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtNoSuplesi)
        Me.GroupBox3.Controls.Add(Me.DPTglKejadian)
        Me.GroupBox3.Controls.Add(Me.ChkSuplesi)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.CboPenjamin)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtKeteranganKLL)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(112, 236)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(648, 90)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Penjaminan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(259, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Lokasi KLL"
        '
        'TxtProv
        '
        Me.TxtProv.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtProv.Location = New System.Drawing.Point(554, 41)
        Me.TxtProv.Name = "TxtProv"
        Me.TxtProv.ReadOnly = True
        Me.TxtProv.Size = New System.Drawing.Size(53, 20)
        Me.TxtProv.TabIndex = 67
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(522, 44)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 13)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Prov"
        '
        'TxtKab
        '
        Me.TxtKab.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtKab.Location = New System.Drawing.Point(452, 41)
        Me.TxtKab.Name = "TxtKab"
        Me.TxtKab.ReadOnly = True
        Me.TxtKab.Size = New System.Drawing.Size(53, 20)
        Me.TxtKab.TabIndex = 67
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(420, 44)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 13)
        Me.Label19.TabIndex = 66
        Me.Label19.Text = "Kab"
        '
        'TxtKec
        '
        Me.TxtKec.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtKec.Location = New System.Drawing.Point(357, 41)
        Me.TxtKec.Name = "TxtKec"
        Me.TxtKec.ReadOnly = True
        Me.TxtKec.Size = New System.Drawing.Size(53, 20)
        Me.TxtKec.TabIndex = 67
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(325, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 13)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "Kec"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "No. Suplesi"
        '
        'TxtNoSuplesi
        '
        Me.TxtNoSuplesi.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNoSuplesi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoSuplesi.Location = New System.Drawing.Point(410, 13)
        Me.TxtNoSuplesi.Name = "TxtNoSuplesi"
        Me.TxtNoSuplesi.ReadOnly = True
        Me.TxtNoSuplesi.Size = New System.Drawing.Size(197, 22)
        Me.TxtNoSuplesi.TabIndex = 65
        '
        'DPTglKejadian
        '
        Me.DPTglKejadian.Location = New System.Drawing.Point(84, 34)
        Me.DPTglKejadian.Name = "DPTglKejadian"
        Me.DPTglKejadian.Size = New System.Drawing.Size(161, 20)
        Me.DPTglKejadian.TabIndex = 58
        '
        'ChkSuplesi
        '
        Me.ChkSuplesi.AutoSize = True
        Me.ChkSuplesi.Location = New System.Drawing.Point(271, 15)
        Me.ChkSuplesi.Name = "ChkSuplesi"
        Me.ChkSuplesi.Size = New System.Drawing.Size(60, 17)
        Me.ChkSuplesi.TabIndex = 64
        Me.ChkSuplesi.Text = "Suplesi"
        Me.ChkSuplesi.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Tgl. Kejadian"
        '
        'CboPenjamin
        '
        Me.CboPenjamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPenjamin.FormattingEnabled = True
        Me.CboPenjamin.Items.AddRange(New Object() {"Rawat Inap", "Rawat Jalan"})
        Me.CboPenjamin.Location = New System.Drawing.Point(84, 13)
        Me.CboPenjamin.Name = "CboPenjamin"
        Me.CboPenjamin.Size = New System.Drawing.Size(161, 21)
        Me.CboPenjamin.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Penjamin"
        '
        'ChkKLL
        '
        Me.ChkKLL.AutoSize = True
        Me.ChkKLL.Location = New System.Drawing.Point(262, 213)
        Me.ChkKLL.Name = "ChkKLL"
        Me.ChkKLL.Size = New System.Drawing.Size(130, 17)
        Me.ChkKLL.TabIndex = 64
        Me.ChkKLL.Text = "Kecelakaan Lalulintas"
        Me.ChkKLL.UseVisualStyleBackColor = True
        '
        'TxtNoSKDP
        '
        Me.TxtNoSKDP.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNoSKDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoSKDP.Location = New System.Drawing.Point(112, 332)
        Me.TxtNoSKDP.Name = "TxtNoSKDP"
        Me.TxtNoSKDP.ReadOnly = True
        Me.TxtNoSKDP.Size = New System.Drawing.Size(197, 20)
        Me.TxtNoSKDP.TabIndex = 20
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 335)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "No. SKDP"
        '
        'TxtDPJP
        '
        Me.TxtDPJP.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtDPJP.Location = New System.Drawing.Point(386, 335)
        Me.TxtDPJP.Name = "TxtDPJP"
        Me.TxtDPJP.ReadOnly = True
        Me.TxtDPJP.Size = New System.Drawing.Size(51, 20)
        Me.TxtDPJP.TabIndex = 56
        '
        'TxtNamaDokter
        '
        Me.TxtNamaDokter.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNamaDokter.Location = New System.Drawing.Point(489, 335)
        Me.TxtNamaDokter.Name = "TxtNamaDokter"
        Me.TxtNamaDokter.ReadOnly = True
        Me.TxtNamaDokter.Size = New System.Drawing.Size(288, 20)
        Me.TxtNamaDokter.TabIndex = 57
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(346, 338)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(34, 13)
        Me.Label22.TabIndex = 58
        Me.Label22.Text = "DPJP"
        '
        'CmdCariDPJP
        '
        Me.CmdCariDPJP.Location = New System.Drawing.Point(443, 333)
        Me.CmdCariDPJP.Name = "CmdCariDPJP"
        Me.CmdCariDPJP.Size = New System.Drawing.Size(40, 23)
        Me.CmdCariDPJP.TabIndex = 59
        Me.CmdCariDPJP.Text = "Cari"
        Me.CmdCariDPJP.UseVisualStyleBackColor = True
        '
        'TxtNoTelepon
        '
        Me.TxtNoTelepon.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNoTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoTelepon.Location = New System.Drawing.Point(432, 41)
        Me.TxtNoTelepon.Name = "TxtNoTelepon"
        Me.TxtNoTelepon.ReadOnly = True
        Me.TxtNoTelepon.Size = New System.Drawing.Size(197, 20)
        Me.TxtNoTelepon.TabIndex = 20
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(366, 41)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(66, 13)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "No. Telepon"
        '
        'ChkPoliEksekutif
        '
        Me.ChkPoliEksekutif.AutoSize = True
        Me.ChkPoliEksekutif.Location = New System.Drawing.Point(600, 116)
        Me.ChkPoliEksekutif.Name = "ChkPoliEksekutif"
        Me.ChkPoliEksekutif.Size = New System.Drawing.Size(90, 17)
        Me.ChkPoliEksekutif.TabIndex = 64
        Me.ChkPoliEksekutif.Text = "Poli Eksekutif"
        Me.ChkPoliEksekutif.UseVisualStyleBackColor = True
        '
        'TxtCatatan
        '
        Me.TxtCatatan.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtCatatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCatatan.Location = New System.Drawing.Point(112, 358)
        Me.TxtCatatan.Name = "TxtCatatan"
        Me.TxtCatatan.ReadOnly = True
        Me.TxtCatatan.Size = New System.Drawing.Size(665, 20)
        Me.TxtCatatan.TabIndex = 20
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(12, 361)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 13)
        Me.Label24.TabIndex = 21
        Me.Label24.Text = "Catatan"
        '
        'CmdInsertSEP
        '
        Me.CmdInsertSEP.Location = New System.Drawing.Point(454, 398)
        Me.CmdInsertSEP.Name = "CmdInsertSEP"
        Me.CmdInsertSEP.Size = New System.Drawing.Size(95, 23)
        Me.CmdInsertSEP.TabIndex = 66
        Me.CmdInsertSEP.Text = "InsertSEP"
        Me.CmdInsertSEP.UseVisualStyleBackColor = True
        '
        'CmdCariPeserta
        '
        Me.CmdCariPeserta.Location = New System.Drawing.Point(315, 4)
        Me.CmdCariPeserta.Name = "CmdCariPeserta"
        Me.CmdCariPeserta.Size = New System.Drawing.Size(103, 23)
        Me.CmdCariPeserta.TabIndex = 67
        Me.CmdCariPeserta.Text = "Cari Data Peserta"
        Me.CmdCariPeserta.UseVisualStyleBackColor = True
        '
        'FrmSEP
        '
        Me.ClientSize = New System.Drawing.Size(831, 452)
        Me.Controls.Add(Me.CmdCariPeserta)
        Me.Controls.Add(Me.CmdInsertSEP)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ChkKLL)
        Me.Controls.Add(Me.ChkKatarak)
        Me.Controls.Add(Me.ChkPoliEksekutif)
        Me.Controls.Add(Me.ChkCOB)
        Me.Controls.Add(Me.CmdCariPoli)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtDeskripsiPoli)
        Me.Controls.Add(Me.TxtKodePoli)
        Me.Controls.Add(Me.CmdCariDPJP)
        Me.Controls.Add(Me.CmdCariDiagnosa)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtNamaDokter)
        Me.Controls.Add(Me.TxtDPJP)
        Me.Controls.Add(Me.TxtDiagnosa)
        Me.Controls.Add(Me.TxtKodeDX)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CboJnsPelayanan)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DPTglSEP)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtHakKelas)
        Me.Controls.Add(Me.TxtKodeHakKelas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNoPasien)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNamaPeserta)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNoTelepon)
        Me.Controls.Add(Me.TxtCatatan)
        Me.Controls.Add(Me.TxtNoSKDP)
        Me.Controls.Add(Me.TxtNoPeserta)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSEP"
        Me.Text = "SEP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private Sub CmdInsertSEP_Click(sender As Object, e As EventArgs) Handles CmdInsertSEP.Click
        Dim oSEP As New JKNBridge.VClaimLib.TSep

        oSEP.Catatan = TxtCatatan.Text.Trim
        oSEP.Cob.Cob = Integer.Parse(ChkCOB.Checked)
        oSEP.DiagAwal = TxtKodeDX.Text
        oSEP.Jaminan.LakaLantas = Integer.Parse(ChkKLL.Checked)
        oSEP.Jaminan.Penjamin.Penjamin = CboPenjamin.SelectedIndex + 1
        oSEP.Jaminan.Penjamin.Keterangan = TxtKeteranganKLL.Text
        oSEP.Jaminan.Penjamin.Suplesi.Suplesi = Integer.Parse(ChkSuplesi.Checked)
        oSEP.Jaminan.Penjamin.Suplesi.noSuplesi = TxtNoSuplesi.Text.Trim
        oSEP.Jaminan.Penjamin.Suplesi.LokasiLaka.kdKecamatan = TxtKec.Text
        oSEP.Jaminan.Penjamin.Suplesi.LokasiLaka.kodeKabupaten = TxtKab.Text.Trim
        oSEP.Jaminan.Penjamin.Suplesi.LokasiLaka.kodeProvinsi = TxtProv.Text

        oSEP.Jaminan.Penjamin.tglKejadian = DPTglKejadian.Value.ToString("yyyy-MM-dd")
        oSEP.JnsPelayanan = CboJnsPelayanan.SelectedIndex + 1
        oSEP.Katarak.Katarak = Integer.Parse(ChkKatarak.Checked)
        oSEP.KlsRawat = TxtHakKelas.Text
        oSEP.NoKartu = TxtNoPeserta.Text
        oSEP.NoMR = TxtNoPasien.Text
        oSEP.NoTelp = TxtNoTelepon.Text
        oSEP.Poli.Tujuan = TxtKodePoli.Text
        oSEP.Poli.Eksekutif = Integer.Parse(ChkPoliEksekutif.Checked)
        oSEP.PpkPelayanan = ""
        oSEP.Rujukan.AsalRujukan = CboAsalRujukan.SelectedIndex + 1
        oSEP.Rujukan.NoRujukan = TxtNoRujukan.Text
        oSEP.Rujukan.PpkRujukan = TxtKodePPKAsal.Text
        oSEP.Rujukan.TglRujukan = DPTglRujukan.Value.ToString("yyyy-MM-dd")
        oSEP.SKDP.NoSurat = TxtNoSKDP.Text
        oSEP.SKDP.KodeDPJP = TxtDPJP.Text
        oSEP.TglSep = Date.Today.ToString("yyyy-MM-dd")
        oSEP.User = "user ws"

        JKNBridge.VClaimLib.SEP.wsInsertSEP(oSEP, cVariable.UserWS, cVariable.ConsID, cVariable.SecretKey)


    End Sub

    Private Sub CmdCariPeserta_Click(sender As Object, e As EventArgs) Handles CmdCariPeserta.Click
        Peserta.wsGetPesertaByKA(TxtNoPeserta.Text.Trim, Date.Today.ToString("yyyy-MM-dd"), cVariable.URL, cVariable.ConsID, cVariable.SecretKey)
        If Peserta.rsGetPeserta.MetaData.Code.Equals("200") Then
            txtNamaPeserta.Text = Peserta.rsGetPeserta.Response.Peserta.Nama
            TxtNoTelepon.Text = Peserta.rsGetPeserta.Response.Peserta.Mr.NoTelepon
            TxtNoPasien.Text = Peserta.rsGetPeserta.Response.Peserta.Mr.NoMR
            TxtKodeHakKelas.Text = Peserta.rsGetPeserta.Response.Peserta.HakKelas.Kode
            TxtHakKelas.Text = Peserta.rsGetPeserta.Response.Peserta.HakKelas.Keterangan
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

    Private Sub CmdCariPoli_Click(sender As Object, e As EventArgs) Handles CmdCariPoli.Click
        Dim sForm As Form = New frmLookupReferensi(frmLookupReferensi.JenisReferensi.Poli)
        sForm.ShowDialog(Me)

        If Not cVariable.LookupResult.Count = 0 Then
            TxtKodePoli.Text = cVariable.LookupResult(0)
            TxtDeskripsiPoli.Text = cVariable.LookupResult(1)

        End If
    End Sub

    Private Sub CmdCariPPKAsal_Click(sender As Object, e As EventArgs) Handles CmdCariPPKAsal.Click
        Dim sForm As Form = New frmLookupReferensi(frmLookupReferensi.JenisReferensi.Faskes)
        sForm.Text = "Pencarian Faskes"

        sForm.ShowDialog(Me)

        If Not cVariable.LookupResult.Count = 0 Then
            TxtKodePPKAsal.Text = cVariable.LookupResult(0)


        End If
    End Sub

    Private Sub CmdCariDPJP_Click(sender As Object, e As EventArgs) Handles CmdCariDPJP.Click
        Dim sForm As Form = New frmLookupReferensi(frmLookupReferensi.JenisReferensi.Dokter)
        sForm.Text = "Pencarian Dokter"
        sForm.ShowDialog(Me)
        If Not cVariable.LookupResult.Count = 0 Then
            TxtDPJP.Text = cVariable.LookupResult(0)
            TxtNamaDokter.Text = cVariable.LookupResult(1)


        End If

    End Sub

End Class
