Imports Newtonsoft.Json

Public Class Form1

    Private Enum eJenisReferensi
        refPoli = 1
        refDiagnosa = 2
        refDokter
    End Enum

    Private Sub fillParameter()
        cVariable.ConsID = TxtConsID.Text.Trim
        cVariable.SecretKey = TxtSecretKey.Text.Trim
        cVariable.URL = TxtURL.Text.Trim
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CmdReferensiPoli.Click
        fillParameter()


        Dim sForm As Form = New frmLookupReferensi(frmLookupReferensi.JenisReferensi.Poli)
        sForm.Text = "Pencarian Poliklinik"
        sForm.ShowDialog(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oDat As New JKNBridge.VClaimLib.clsRujukanMultiRecord

        Try

            oDat = JKNBridge.VClaimLib.Rujukan.wsGetRujukanByNoKAMulti(JKNBridge.VClaimLib.Rujukan.eJenisRujukan.PPK1, TxtNoPeserta.Text.Trim, TxtURL.Text.Trim, TxtConsID.Text.Trim, TxtSecretKey.Text.Trim)
            If Not oDat.MetaData.Code.Equals("200") Then
                MsgBox(oDat.MetaData.Message)
            Else
                MessageBox.Show(oDat.Response.Rujukan.Count)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtConsID_LostFocus(sender As Object, e As EventArgs) Handles TxtConsID.LostFocus
        cVariable.ConsID = TxtConsID.Text.Trim
    End Sub

    Private Sub TxtSecretKey_LostFocus(sender As Object, e As EventArgs) Handles TxtSecretKey.LostFocus
        cVariable.SecretKey = TxtSecretKey.Text.Trim
    End Sub

    Private Sub TxtURL_LostFocus(sender As Object, e As EventArgs) Handles TxtURL.LostFocus
        cVariable.URL = TxtURL.Text.Trim
    End Sub

    Private Sub CmdRefDiagnosa_Click(sender As Object, e As EventArgs) Handles CmdRefDiagnosa.Click
        fillParameter()
        Dim sForm As Form = New frmLookupReferensi(frmLookupReferensi.JenisReferensi.Diagnosa)
        sForm.Text = "Pencarian Diagnosa"
        sForm.ShowDialog(Me)
    End Sub

    Private Sub CmdRefDokter_Click(sender As Object, e As EventArgs) Handles CmdRefDokter.Click
        fillParameter()

        Dim sForm As Form = New frmLookupReferensi(3)
        sForm.Text = "Pencarian Dokter"
        sForm.ShowDialog(Me)

    End Sub

    Private Sub cmdRefWilayah_Click(sender As Object, e As EventArgs) Handles cmdRefWilayah.Click
        fillParameter()

        Dim sForm As Form = New frmLookupWilayah
        sForm.Text = "Pencarian Wilayah"
        sForm.ShowDialog(Me)
    End Sub

    Private Sub CmdRefFaskes_Click(sender As Object, e As EventArgs) Handles CmdRefFaskes.Click
        fillParameter()
        Dim sForm As Form = New frmLookupReferensi(frmLookupReferensi.JenisReferensi.Faskes)
        sForm.Text = "Pencarian Faskes"

        sForm.ShowDialog(Me)
    End Sub

    Private Sub CmdPesertabyKA_Click(sender As Object, e As EventArgs) Handles CmdPesertabyKA.Click
        fillParameter()
        Dim sForm As Form = New FrmPeserta
        sForm.ShowDialog(Me)
    End Sub


    Private Sub CmdGetRujukan_Click(sender As Object, e As EventArgs) Handles CmdGetRujukan.Click
        fillParameter()
        Dim sForm As Form = New frmGetRujukan
        sForm.ShowDialog(Me)
    End Sub

    Private Sub CmdInsertRujukan_Click(sender As Object, e As EventArgs) Handles CmdInsertRujukan.Click
        fillParameter()
        Dim sForm As Form = New FrmRujukan
        sForm.ShowDialog(Me)
    End Sub

    Private Sub CmdSEP_Click(sender As Object, e As EventArgs) Handles CmdSEP.Click
        fillParameter()
        Dim sForm As Form = New FrmSEP
        sForm.ShowDialog(Me)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim opos As New Sisrute.

        'opos.pasien.nama
    End Sub

    Private Sub CariSEP_Click(sender As Object, e As EventArgs) Handles CariSEP.Click
        Dim oCari As New JKNBridge.VClaimLib.clsCariSEP

        If JKNBridge.VClaimLib.SEP.wsCariSEP(TxtNoPeserta.Text.Trim, TxtURL.Text.Trim, TxtConsID.Text, TxtSecretKey.Text) Then

            If JKNBridge.VClaimLib.SEP.rsCariSEP.MetaData.Code.Equals("200") Then

                TxtResult.Text = JsonConvert.SerializeObject(JKNBridge.VClaimLib.SEP.rsCariSEP)

                MessageBox.Show(String.Concat(JKNBridge.VClaimLib.SEP.rsCariSEP.Response.Peserta.NoKartu, " ", JKNBridge.VClaimLib.SEP.rsCariSEP.Response.Peserta.Nama))
            End If
        End If

    End Sub

    Private Sub CmdHistoriPelayanan_Click(sender As Object, e As EventArgs) Handles CmdHistoriPelayanan.Click
        Dim a As New JKNBridge.VClaimLib.clsMonitoringHistoriPelayanan
        Dim sUrl As String = TxtURL.Text.Trim ' = "https://new-api.bpjs-kesehatan.go.id:8080/new-vclaim-rest/" ' clsGlobalFunction.BridgeConfiguration.ServerLayananBPJS & "/SEP/peserta/"

        Dim nRow As Integer = 0
        a = JKNBridge.VClaimLib.Monitoring.wsMonitoringHistoryPelayanan(TxtNoPeserta.Text, DateTime.Now.AddDays(-90).ToString("yyyy-MM-dd"), DateTime.Now.Date().ToString("yyyy-MM-dd"), sUrl, TxtConsID.Text, TxtSecretKey.Text)

        MessageBox.Show(String.Concat(a.Response.Histori(0).NoSep, " ", a.Response.Histori(0).NamaPeserta, " ", a.Response.Histori(0).TglSep))

    End Sub
End Class
