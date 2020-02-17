<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CmdReferensiPoli = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtConsID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtURL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSecretKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNoPeserta = New System.Windows.Forms.TextBox()
        Me.lsvReferensi = New System.Windows.Forms.ListView()
        Me.CmdRefDiagnosa = New System.Windows.Forms.Button()
        Me.CmdRefDokter = New System.Windows.Forms.Button()
        Me.cmdRefWilayah = New System.Windows.Forms.Button()
        Me.CmdRefFaskes = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmdPesertabyNIK = New System.Windows.Forms.Button()
        Me.CmdPesertabyKA = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CmdInsertRujukan = New System.Windows.Forms.Button()
        Me.CmdGetRujukan = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CariSEP = New System.Windows.Forms.Button()
        Me.CmdSEP = New System.Windows.Forms.Button()
        Me.TxtResult = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CmdHistoriPelayanan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdReferensiPoli
        '
        Me.CmdReferensiPoli.Location = New System.Drawing.Point(14, 19)
        Me.CmdReferensiPoli.Name = "CmdReferensiPoli"
        Me.CmdReferensiPoli.Size = New System.Drawing.Size(113, 34)
        Me.CmdReferensiPoli.TabIndex = 0
        Me.CmdReferensiPoli.Text = "Referensi Poli"
        Me.CmdReferensiPoli.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(409, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtConsID
        '
        Me.TxtConsID.Location = New System.Drawing.Point(97, 10)
        Me.TxtConsID.Name = "TxtConsID"
        Me.TxtConsID.Size = New System.Drawing.Size(129, 20)
        Me.TxtConsID.TabIndex = 2
        Me.TxtConsID.Text = "1932"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtURL)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtSecretKey)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtConsID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 83)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Referensi Poli"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "URL"
        '
        'TxtURL
        '
        Me.TxtURL.Location = New System.Drawing.Point(97, 57)
        Me.TxtURL.Name = "TxtURL"
        Me.TxtURL.Size = New System.Drawing.Size(556, 20)
        Me.TxtURL.TabIndex = 6
        Me.TxtURL.Text = "https://new-api.bpjs-kesehatan.go.id:8080/new-VClaim-rest/"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Secret Key"
        '
        'TxtSecretKey
        '
        Me.TxtSecretKey.Location = New System.Drawing.Point(97, 36)
        Me.TxtSecretKey.Name = "TxtSecretKey"
        Me.TxtSecretKey.Size = New System.Drawing.Size(129, 20)
        Me.TxtSecretKey.TabIndex = 4
        Me.TxtSecretKey.Text = "rs12ms3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cons ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Parameter Utama"
        '
        'TxtNoPeserta
        '
        Me.TxtNoPeserta.Location = New System.Drawing.Point(109, 100)
        Me.TxtNoPeserta.Name = "TxtNoPeserta"
        Me.TxtNoPeserta.Size = New System.Drawing.Size(573, 20)
        Me.TxtNoPeserta.TabIndex = 6
        '
        'lsvReferensi
        '
        Me.lsvReferensi.FullRowSelect = True
        Me.lsvReferensi.GridLines = True
        Me.lsvReferensi.HideSelection = False
        Me.lsvReferensi.Location = New System.Drawing.Point(388, 191)
        Me.lsvReferensi.Name = "lsvReferensi"
        Me.lsvReferensi.Size = New System.Drawing.Size(304, 77)
        Me.lsvReferensi.TabIndex = 4
        Me.lsvReferensi.UseCompatibleStateImageBehavior = False
        Me.lsvReferensi.View = System.Windows.Forms.View.Details
        Me.lsvReferensi.Visible = False
        '
        'CmdRefDiagnosa
        '
        Me.CmdRefDiagnosa.Location = New System.Drawing.Point(133, 19)
        Me.CmdRefDiagnosa.Name = "CmdRefDiagnosa"
        Me.CmdRefDiagnosa.Size = New System.Drawing.Size(113, 34)
        Me.CmdRefDiagnosa.TabIndex = 0
        Me.CmdRefDiagnosa.Text = "Referensi Diagnosa"
        Me.CmdRefDiagnosa.UseVisualStyleBackColor = True
        '
        'CmdRefDokter
        '
        Me.CmdRefDokter.Location = New System.Drawing.Point(252, 19)
        Me.CmdRefDokter.Name = "CmdRefDokter"
        Me.CmdRefDokter.Size = New System.Drawing.Size(113, 34)
        Me.CmdRefDokter.TabIndex = 0
        Me.CmdRefDokter.Text = "Referensi Dokter"
        Me.CmdRefDokter.UseVisualStyleBackColor = True
        '
        'cmdRefWilayah
        '
        Me.cmdRefWilayah.Location = New System.Drawing.Point(524, 19)
        Me.cmdRefWilayah.Name = "cmdRefWilayah"
        Me.cmdRefWilayah.Size = New System.Drawing.Size(113, 34)
        Me.cmdRefWilayah.TabIndex = 8
        Me.cmdRefWilayah.Text = "Referensi Wilayah"
        Me.cmdRefWilayah.UseVisualStyleBackColor = True
        '
        'CmdRefFaskes
        '
        Me.CmdRefFaskes.Location = New System.Drawing.Point(371, 19)
        Me.CmdRefFaskes.Name = "CmdRefFaskes"
        Me.CmdRefFaskes.Size = New System.Drawing.Size(113, 34)
        Me.CmdRefFaskes.TabIndex = 9
        Me.CmdRefFaskes.Text = "Referensi Faskes"
        Me.CmdRefFaskes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdRefWilayah)
        Me.GroupBox2.Controls.Add(Me.CmdRefFaskes)
        Me.GroupBox2.Controls.Add(Me.CmdReferensiPoli)
        Me.GroupBox2.Controls.Add(Me.CmdRefDiagnosa)
        Me.GroupBox2.Controls.Add(Me.CmdRefDokter)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(665, 67)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Referensi"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmdPesertabyNIK)
        Me.GroupBox3.Controls.Add(Me.CmdPesertabyKA)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 65)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Peserta"
        '
        'CmdPesertabyNIK
        '
        Me.CmdPesertabyNIK.Location = New System.Drawing.Point(142, 19)
        Me.CmdPesertabyNIK.Name = "CmdPesertabyNIK"
        Me.CmdPesertabyNIK.Size = New System.Drawing.Size(113, 30)
        Me.CmdPesertabyNIK.TabIndex = 0
        Me.CmdPesertabyNIK.Text = "Peserta by NIK"
        Me.CmdPesertabyNIK.UseVisualStyleBackColor = True
        '
        'CmdPesertabyKA
        '
        Me.CmdPesertabyKA.Location = New System.Drawing.Point(12, 19)
        Me.CmdPesertabyKA.Name = "CmdPesertabyKA"
        Me.CmdPesertabyKA.Size = New System.Drawing.Size(113, 30)
        Me.CmdPesertabyKA.TabIndex = 0
        Me.CmdPesertabyKA.Text = "Peserta by KA"
        Me.CmdPesertabyKA.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CmdInsertRujukan)
        Me.GroupBox4.Controls.Add(Me.CmdGetRujukan)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 251)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(280, 65)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rujukan"
        '
        'CmdInsertRujukan
        '
        Me.CmdInsertRujukan.Location = New System.Drawing.Point(142, 19)
        Me.CmdInsertRujukan.Name = "CmdInsertRujukan"
        Me.CmdInsertRujukan.Size = New System.Drawing.Size(113, 30)
        Me.CmdInsertRujukan.TabIndex = 0
        Me.CmdInsertRujukan.Text = "Rujukan"
        Me.CmdInsertRujukan.UseVisualStyleBackColor = True
        '
        'CmdGetRujukan
        '
        Me.CmdGetRujukan.Location = New System.Drawing.Point(12, 19)
        Me.CmdGetRujukan.Name = "CmdGetRujukan"
        Me.CmdGetRujukan.Size = New System.Drawing.Size(113, 30)
        Me.CmdGetRujukan.TabIndex = 0
        Me.CmdGetRujukan.Text = "GetRujukan"
        Me.CmdGetRujukan.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.CariSEP)
        Me.GroupBox5.Controls.Add(Me.CmdSEP)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 322)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(665, 65)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SEP"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(497, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(261, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 30)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Rujukan"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CariSEP
        '
        Me.CariSEP.Location = New System.Drawing.Point(133, 19)
        Me.CariSEP.Name = "CariSEP"
        Me.CariSEP.Size = New System.Drawing.Size(113, 30)
        Me.CariSEP.TabIndex = 0
        Me.CariSEP.Text = "Cari SEP"
        Me.CariSEP.UseVisualStyleBackColor = True
        '
        'CmdSEP
        '
        Me.CmdSEP.Location = New System.Drawing.Point(12, 19)
        Me.CmdSEP.Name = "CmdSEP"
        Me.CmdSEP.Size = New System.Drawing.Size(113, 30)
        Me.CmdSEP.TabIndex = 0
        Me.CmdSEP.Text = "Create SEP"
        Me.CmdSEP.UseVisualStyleBackColor = True
        '
        'TxtResult
        '
        Me.TxtResult.Location = New System.Drawing.Point(303, 191)
        Me.TxtResult.Multiline = True
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(362, 125)
        Me.TxtResult.TabIndex = 12
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CmdHistoriPelayanan)
        Me.GroupBox6.Location = New System.Drawing.Point(17, 389)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(665, 77)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Monitoring"
        '
        'CmdHistoriPelayanan
        '
        Me.CmdHistoriPelayanan.Location = New System.Drawing.Point(14, 28)
        Me.CmdHistoriPelayanan.Name = "CmdHistoriPelayanan"
        Me.CmdHistoriPelayanan.Size = New System.Drawing.Size(113, 30)
        Me.CmdHistoriPelayanan.TabIndex = 1
        Me.CmdHistoriPelayanan.Text = "Histori Pelayanan"
        Me.CmdHistoriPelayanan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 478)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.TxtResult)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lsvReferensi)
        Me.Controls.Add(Me.TxtNoPeserta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdReferensiPoli As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtConsID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNoPeserta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSecretKey As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtURL As TextBox
    Friend WithEvents lsvReferensi As ListView
    Friend WithEvents CmdRefDiagnosa As Button
    Friend WithEvents CmdRefDokter As Button
    Friend WithEvents cmdRefWilayah As Button
    Friend WithEvents CmdRefFaskes As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CmdPesertabyNIK As Button
    Friend WithEvents CmdPesertabyKA As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CmdInsertRujukan As Button
    Friend WithEvents CmdGetRujukan As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CariSEP As Button
    Friend WithEvents CmdSEP As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TxtResult As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CmdHistoriPelayanan As Button
End Class
