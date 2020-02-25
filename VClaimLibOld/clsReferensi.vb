Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Class Referensi

    Public Enum eJenisPelayanan
        RawatInap = 1
        RawatJalan = 2
    End Enum

    Public Enum eJenisFaskes
        PPK1 = 1
        PPK2 = 2
    End Enum

    Public Shared Function wsRefDiagnosa(sCariDX As String, sURL As String, sConsID As String, sPass As String) As clsRefDiagnosa
        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(sURL & "referensi/diagnosa/" & sCariDX), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim iTems As clsRefDiagnosa = Nothing

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
            iTems = JsonConvert.DeserializeObject(Of clsRefDiagnosa)(stext)

            Return iTems

        Catch exception As Exception
            Throw New Exception(exception.Message & vbCrLf & sURL)
        End Try

        Return iTems
    End Function

    ''' <summary>
    ''' Digunakan untuk mengambil daftar dokter yang terdaftar di BPJS Kesehatan
    ''' </summary>
    ''' <param name="iJenisPelayanan">Jenis Perawatan Pasien 1. Rawat Inap 2. Rawat Jalan. Bisa juga menggunakan numerasi</param>
    ''' <param name="sTglPelayanan">Tanggal Pelayanan dalam format YYYY-MM-DD</param>
    ''' <param name="sKodeSpesial">Kodespesialis atau sub spesialis</param>
    ''' <param name="sURL">URL Utama WS BPJS Kesehatan</param>
    ''' <param name="sConsID">ConsID dari BPJS Kesehatan</param>
    ''' <param name="sPass">SecretKey dari BPJS Kesehatan</param>
    ''' <returns>JKNBridge.clsRefDokterDPJP</returns>
    Public Shared Function wsRefDokterDPJP(iJenisPelayanan As eJenisPelayanan, sTglPelayanan As String, sKodeSpesial As String, sURL As String, sConsID As String, sPass As String) As clsRefDokterDPJP

        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(sURL & "/referensi/dokter/pelayanan/" & iJenisPelayanan & "/tglpelayanan/" & sTglPelayanan & "/Spesialis/" & sKodeSpesial), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim iTems As clsRefDokterDPJP = Nothing

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
            iTems = JsonConvert.DeserializeObject(Of clsRefDokterDPJP)(stext)
            Return iTems

        Catch exception As Exception
            Throw New Exception("Kegagalan Proses Untuk   uri " & sURL & vbCrLf & exception.Message)

        End Try

        Return iTems
    End Function


    Public Shared Function wsRefPoli(sCari As String, sURL As String, sConsID As String, sPass As String) As clsRefPoli
        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(sURL & "referensi/poli/" & sCari.Trim), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim iTems As New clsRefPoli

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
            iTems = JsonConvert.DeserializeObject(Of clsRefPoli)(stext)
        Catch ex As Exception
            Throw New Exception(ex.Message & vbCrLf & request.RequestUri.AbsoluteUri)
        End Try

        Return iTems
    End Function

    Public Shared Function wsRefPropinsi(sURL As String, sConsID As String, sPass As String) As clsReferensiPropinsi
        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(sURL & "referensi/propinsi"), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim iTems As New clsReferensiPropinsi

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
            iTems = JsonConvert.DeserializeObject(Of clsReferensiPropinsi)(stext)
        Catch ex As Exception
            Throw New Exception(ex.Message & vbCrLf & request.RequestUri.AbsoluteUri)
        End Try

        Return iTems
    End Function

    Public Shared Function wsRefKabupaten(sKodeProvinsi As String, sURL As String, sConsID As String, sPass As String) As clsReferensiKabupaten
        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(sURL & "referensi/kabupaten/propinsi/" & sKodeProvinsi), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim iTems As New clsReferensiKabupaten

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
            iTems = JsonConvert.DeserializeObject(Of clsReferensiKabupaten)(stext)
        Catch ex As Exception
            Throw New Exception(ex.Message & vbCrLf & request.RequestUri.AbsoluteUri)
        End Try

        Return iTems
    End Function

    Public Shared Function wsRefKecamatan(skodekabupaten As String, sURL As String, sConsID As String, sPass As String) As clsReferensiKecamatan
        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(sURL & "referensi/kecamatan/kabupaten/" & skodekabupaten), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim iTems As New clsReferensiKecamatan

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
            iTems = JsonConvert.DeserializeObject(Of clsReferensiKecamatan)(stext)
        Catch ex As Exception
            Throw New Exception(ex.Message & vbCrLf & request.RequestUri.AbsoluteUri)
        End Try

        Return iTems
    End Function


    Public Shared Function wsRefFaskes(sCari As String, sJenisFaskes As eJenisFaskes, sURL As String, sConsID As String, sPass As String) As clsReferensiFaskes
        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(sURL & "referensi/faskes/" & sCari.Trim & "/" & sJenisFaskes), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim iTems As clsReferensiFaskes = Nothing

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
            iTems = JsonConvert.DeserializeObject(Of clsReferensiFaskes)(stext)
        Catch ex As Exception
            Throw New Exception(ex.Message & vbCrLf & request.RequestUri.AbsoluteUri)
        End Try

        Return iTems
    End Function

End Class
