Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

''' <summary>
''' Class berisi methode untuk pencarian data Pesrta JKN
''' </summary>
Public Class Peserta
    ''' <summary>
    ''' Feedback/hasil pencarian data peserta
    ''' khusus peserta JKN
    ''' </summary>
    Public Shared rsGetPeserta As clsPesertaResponse

    ''' <summary>
    ''' Methode Untuk mendapatkan pesrta berdasarkan Nomor Kartu
    ''' </summary>
    ''' <param name="sNoPeserta">Nomor Kartu Peserta BPJS Kesehatan</param>
    ''' <param name="sTanggal">Masukan tanggal pelayanan dengan format yyyy-MM-dd </param>
    ''' <param name="sURL">URL WebAPI BPJS Kesehatan</param>
    ''' <param name="sConsID">ConsID dari BPJS Kesehatan</param>
    ''' <param name="sPass">Secret Key dari BPJS KEsehatan</param>
    ''' <returns></returns>
    Public Shared Function wsGetPesertaByKA(ByVal sNoPeserta As String, sTanggal As String, sURL As String, sConsID As String, sPass As String) As clsPesertaResponse

        Dim sReturn As String = "InValid"
        'If Not sURL.right(1).Equals("/") Then
        '    print(sURL.right(1))
        '    sURL += "\"
        'End If

        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(sURL & "Peserta/nokartu/" & sNoPeserta & "/tglSEP/" & sTanggal), HttpWebRequest)
        Dim cache As New CredentialCache
        'Dim iTems As List(Of DetailSEP) = Nothing
        Dim iTems As New clsPesertaResponse

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
            iTems = JsonConvert.DeserializeObject(Of clsPesertaResponse)(stext)
            rsGetPeserta = JsonConvert.DeserializeObject(Of clsPesertaResponse)(stext)

            Return iTems

        Catch exception As Exception
            Throw New Exception("Kegagalan Proses Untuk   uri " & sURL & vbCrLf & exception.Message)
            Return Nothing
        End Try

        Return iTems

    End Function

    ''' <summary>
    ''' Mencari detail peserta JKN berdasarkan Nomor Induk Kependudukan (NIK
    ''' </summary>
    ''' <param name="sNIK">Nomor Induk Kependudukan (NIK)</param>
    ''' <param name="sTanggal">Masukan tanggal pelayanan dengan format yyyy-MM-dd </param>
    ''' <param name="sURL">Alamat URL webservice (end point)</param>
    ''' <param name="sConsID">Cons ID dari BPJS Kesehatan</param>
    ''' <param name="sPass">SecretKey dari BPJS Kesehatan</param>
    ''' <returns>Class clsPesertaResponse</returns>
    ''' <remarks></remarks>
    Public Shared Function wsGetPesertabyNIK(sNIK As String, sTanggal As String, sURL As String, sConsID As String, sPass As String) As clsPesertaResponse
        Dim sReturn As String = "InValid"

        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(sURL & "Peserta/nik/" & sNIK & "/tglSEP/" & sTanggal), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim iTems As New clsPesertaResponse

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
            rsGetPeserta = JsonConvert.DeserializeObject(Of clsPesertaResponse)(stext)
            iTems = JsonConvert.DeserializeObject(Of clsPesertaResponse)(stext)

            Return iTems

        Catch exception As Exception
            Throw New Exception("Kegagalan Proses Untuk   uri " & sURL & vbCrLf & exception.Message)
            Return Nothing
        End Try

        Return iTems
    End Function

End Class
