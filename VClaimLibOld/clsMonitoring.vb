Imports System.Data
Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Class Monitoring
    Public Shared Function wsMonitoringDataKunjungan(sTglSEP As String, sJenisPelayanan As String, sURL As String, sConsID As String, sPass As String) As clsMonitorKunjungan
        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(sURL & sTglSEP & "Kunjungan/Tanggal/" & sTglSEP & "/JnsPelayanan/" & sJenisPelayanan), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim iTems As clsMonitorKunjungan = Nothing

        request.Method = "GET"
        request.KeepAlive = True

        request.Credentials = cache
        request.Headers.Add("X-cons-id", sConsID)
        request.Headers.Add("X-timestamp", sTimeStamp)
        request.Headers.Add("X-signature", str2)
        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            response = TryCast(request.GetResponse, HttpWebResponse)

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)

            Dim stext As String = loResponseStream.ReadToEnd()
            iTems = JsonConvert.DeserializeObject(Of clsMonitorKunjungan)(stext)
            Return iTems


        Catch exception As Exception
            Throw New Exception("Kegagalan Proses Untuk   uri " & sURL & vbCrLf & exception.Message)
        End Try

        Return iTems
    End Function
    ''' <summary>
    ''' Digunakan untuk mengambil data klaim berdasarkan jenis pelayanan dan status verifikasi, sesuai Catalog https://dvlp.bpjs-kesehatan.go.id/VClaim-Katalog/Monitoring#mon2
    ''' </summary>
    ''' <param name="sTglPulang">Tanggal pulang pasien</param>
    ''' <param name="sJenisPelayanan">jenis pelayanan, 1. Rawat Inap 2. Rawat jalan</param>
    ''' <param name="sStatusKlaim">Status verifikasi klaim, 1. Proses Verifikasi, 2. Pending Verifikasi, 3 Klaim</param>
    ''' <param name="sBaseURL">URL utama dari BPJS Kesehatan</param>
    ''' <param name="sConsID">ConsID RS yang diberikan oleh BPJS Kesehatan</param>
    ''' <param name="sPass">SecretKey yang diberikan oleh BPJS Kesehatan</param>
    ''' <returns>Data dalam format JSON yang sudah di deserialisasi ke objek Class clsMonitorDataKlaim</returns>
    Public Shared Function wsMonitorDataKlaim(sTglPulang As String, sJenisPelayanan As String, sStatusKlaim As String, sBaseURL As String, sConsID As String, sPass As String) As clsMonitoringDataKlaim
        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(sBaseURL & "Monitoring/Klaim/Tanggal/" & sTglPulang & "/JnsPelayanan/" & sJenisPelayanan & "/Status/" & sStatusKlaim), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim iTems As clsMonitoringDataKlaim = Nothing

        request.Method = "GET"
        request.KeepAlive = True

        request.Credentials = cache
        request.Headers.Add("X-cons-id", sConsID)
        request.Headers.Add("X-timestamp", sTimeStamp)
        request.Headers.Add("X-signature", str2)
        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            response = TryCast(request.GetResponse, HttpWebResponse)

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)

            Dim stext As String = loResponseStream.ReadToEnd()
            iTems = JsonConvert.DeserializeObject(Of clsMonitoringDataKlaim)(stext)

            Return iTems

        Catch exception As Exception
            Throw New Exception("Kegagalan Proses wsDataKlaim Untuk uri " & request.RequestUri.ToString() & vbCrLf & exception.Message)
        End Try

        Return iTems
    End Function

    Public Shared Function wsMonitoringHistoryPelayanan(sNoKartu As String, sTglAwal As String, sTglAkhir As String, sBaseURL As String, sConsID As String, sPass As String) As clsMonitoringHistoriPelayanan

        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(sBaseURL & "monitoring/HistoriPelayanan/NoKartu/" & sNoKartu & "/tglAwal/" & sTglAwal & "/TglAkhir/" & sTglAkhir), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim iTems As clsMonitoringHistoriPelayanan = Nothing

        request.Method = "GET"
        request.KeepAlive = True

        request.Credentials = cache
        request.Headers.Add("X-cons-id", sConsID)
        request.Headers.Add("X-timestamp", sTimeStamp)
        request.Headers.Add("X-signature", str2)
        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            response = TryCast(request.GetResponse, HttpWebResponse)
            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()
            iTems = JsonConvert.DeserializeObject(Of clsMonitoringHistoriPelayanan)(stext)
            Return iTems

        Catch exception As Exception
            Throw New Exception("Kegagalan Proses wshistoripelayanan Untuk uri " & sBaseURL & vbCrLf & exception.Message)
        End Try

        Return iTems
    End Function


End Class
