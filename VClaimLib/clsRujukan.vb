Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json


''' <summary>
''' Menyediakan methode untuk menangani data rujukan peserta JKN
''' </summary>
Public Class Rujukan
    ''' <summary>
    ''' Feedback methode wsGetRujukanByNoKA atau wsCariRujukanByNoRujukan
    ''' </summary>
    Public Shared rsDataRujukan As New clsRujukanResponse
    ''' <summary>
    ''' Feedback Methode wsGetRujukanByNoKAMulti
    ''' </summary>
    Public Shared rsDataRujukanMultiRecord As New clsRujukanMultiRecord
    ''' <summary>
    ''' 
    ''' Feedback methode wsInsertRujukan
    ''' </summary>
    Public Shared rsInsertRujukan As New clsInsertRujukan
    ''' <summary>
    ''' Feedback methode update rujukan
    ''' </summary>
    Public Shared rsUpdateRujukan As New clsUpdateDeleteRujukanResponse

    ''' <summary>
    ''' feedback methode delete rujukan
    ''' </summary>
    Public Shared rsDeleteRujukan As New clsUpdateDeleteRujukanResponse

    Public Enum eJenisRujukan
        PPK1 = 1
        PPK2 = 2
    End Enum

    ''' <summary>
    ''' Mendapatkan data rujukan pasien berdasrkan No. Rujukan dari PPK1
    ''' </summary>
    ''' <param name="sURL">Alamat URL webservice </param>
    ''' <param name="sConsID">Cons ID dari BPJS Kesehatan</param>
    ''' <param name="sPass">SecretKey dari BPJS Kesehatan</param>
    ''' <returns>Class clsRujukanResponse</returns>
    ''' <remarks>Referensi : https://dvlp.bpjs-kesehatan.go.id/VClaim-Katalog/Rujukan#collapseOne</remarks>
    Public Shared Function wsGetRujukanByNoRujukan(eAsalRujukan As eJenisRujukan, sNoRujukan As String, sURL As String, sConsID As String, sPass As String) As Boolean
        Dim sReturn As String = "InValid"

        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest '= DirectCast(WebRequest.Create(sURL & "Rujukan/" & sNoRujukan), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim iTems As New clsRujukanResponse

        If eAsalRujukan = eJenisRujukan.PPK1 Then
            request = DirectCast(WebRequest.Create(sURL & "rujukan/" & sNoRujukan), HttpWebRequest)
        Else
            request = DirectCast(WebRequest.Create(sURL & "rujukan/rs/" & sNoRujukan), HttpWebRequest)
        End If

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
            iTems = JsonConvert.DeserializeObject(Of clsRujukanResponse)(stext)
            rsDataRujukan = JsonConvert.DeserializeObject(Of clsRujukanResponse)(stext)
            Return True

        Catch exception As Exception
            Throw New Exception("Proses pencarian rujukan gagal, pada uri " & sURL & vbCrLf & exception.Message)
            Return Nothing
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Mendapatkan data rujukan pasien berdasrkan No. Peserta JKN
    ''' </summary>
    ''' <param name="sNoPeserta">No. Peserta JKN</param>
    ''' <param name="sURL">Alamat URL webservice (end point)</param>
    ''' <param name="sConsID">Cons ID dari BPJS Kesehatan</param>
    ''' <param name="sPass">SecretKey dari BPJS Kesehatan</param>
    ''' <returns>Class BPJSPeserta</returns>
    ''' <remarks></remarks>
    Public Shared Function wsGetRujukanByNoKA(eAsalRujukan As eJenisRujukan, sNoPeserta As String, sURL As String, sConsID As String, sPass As String) As clsRujukanResponse

        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim sSignature As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest
        Dim cache As New CredentialCache

        Dim iTems As New clsRujukanResponse

        If eAsalRujukan = eJenisRujukan.PPK1 Then
            request = DirectCast(WebRequest.Create(sURL & "Rujukan/Peserta/" & sNoPeserta), HttpWebRequest)
        Else
            request = DirectCast(WebRequest.Create(sURL & "Rujukan/RS/Peserta/" & sNoPeserta), HttpWebRequest)
        End If

        request.Method = "GET"
        request.KeepAlive = True

        request.Credentials = cache
        request.Headers.Add("X-cons-id", sConsID)
        request.Headers.Add("X-timestamp", sTimeStamp)
        request.Headers.Add("X-signature", sSignature)
        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            response = TryCast(request.GetResponse, HttpWebResponse)

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)

            Dim stext As String = loResponseStream.ReadToEnd()
            'Return stext
            iTems = JsonConvert.DeserializeObject(Of clsRujukanResponse)(stext)
            rsDataRujukan = JsonConvert.DeserializeObject(Of clsRujukanResponse)(stext)


            Return iTems

        Catch exception As Exception
            Throw New Exception("Kegagalan Proses Untuk   uri " & sURL & vbCrLf & exception.Message)
            Return Nothing
        End Try
        'Return sText

        Return iTems
    End Function

    ''' <summary>
    ''' Mendapatkan data beberapa rujukan yang dimiliki pasien berdasarkan No Peserta JKN
    ''' </summary>
    ''' <param name="sNoPeserta">No. Peserta JKN</param>
    ''' <param name="sURL">Alamat URL webservice (end point)</param>
    ''' <param name="sConsID">Cons ID dari BPJS Kesehatan</param>
    ''' <param name="sPass">SecretKey dari BPJS Kesehatan</param>
    ''' <returns>Rujukan.rsDataRujukanMultiRecord</returns>
    Public Shared Function wsGetRujukanByNoKAMulti(eAsalRujukan As eJenisRujukan, sNoPeserta As String, sURL As String, sConsID As String, sPass As String) As clsRujukanMultiRecord

        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim sSignature As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As HttpWebRequest '= DirectCast(WebRequest.Create(sBaseURL & "Rujukan/List/Peserta/" & sNoPeserta), HttpWebRequest)
        Dim cache As New CredentialCache

        Dim iTems As New clsRujukanMultiRecord

        If eAsalRujukan = eJenisRujukan.PPK1 Then
            request = DirectCast(WebRequest.Create(sURL & "Rujukan/List/Peserta/" & sNoPeserta), HttpWebRequest)
        Else
            request = DirectCast(WebRequest.Create(sURL & "Rujukan/RS/Peserta/" & sNoPeserta), HttpWebRequest)
        End If

        request.Method = "GET"
        request.KeepAlive = True
        request.Credentials = cache
        request.Headers.Add("X-cons-id", sConsID)
        request.Headers.Add("X-timestamp", sTimeStamp)
        request.Headers.Add("X-signature", sSignature)
        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            response = TryCast(request.GetResponse, HttpWebResponse)
            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()
            iTems = JsonConvert.DeserializeObject(Of clsRujukanMultiRecord)(stext)
            rsDataRujukanMultiRecord = JsonConvert.DeserializeObject(Of clsRujukanMultiRecord)(stext)
            Return iTems

        Catch exception As Exception
            Throw New Exception("Kegagalan Proses Untuk uri " & sURL & vbCrLf & exception.Message)
        End Try
        Return iTems
    End Function


    ''' <summary>
    ''' Membuat rujukan keluar Rumah Sakit
    ''' </summary>
    ''' <param name="sData">Type berisi data rujukan</param>
    ''' <param name="sURL">Alamat URL webservice (end point)</param>
    ''' <param name="sConsID">Cons ID dari BPJS Kesehatan</param>
    ''' <param name="sPass">SecretKey dari BPJS Kesehatan</param>
    ''' <returns>Rujukan.rsInsertRujukan</returns>
    Public Shared Function wsInsertRujukan(sData As TRujukan, sURL As String, sConsID As String, sPass As String) As clsInsertRujukan
        Dim sReturn As String = "InValid"

        Dim request As WebRequest = WebRequest.Create(sURL & "Rujukan/insert")
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New clsInsertRujukan
        Dim oDTO As New clsRujukanDto

        oDTO.Request.TRujukan = sData

        sPostData = JsonConvert.SerializeObject(oDTO)
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)
        request.Method = "POST"
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache

        Try
            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()

            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            response = TryCast(request.GetResponse, HttpWebResponse)
            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()
            iTems = JsonConvert.DeserializeObject(Of clsInsertRujukan)(stext)
            rsInsertRujukan = JsonConvert.DeserializeObject(Of clsInsertRujukan)(stext)

            Return iTems
        Catch exception As Exception
            Throw New Exception("Gagal membuat data rujukan. " & sURL & vbCrLf & exception.Message)

        End Try

        Return iTems
    End Function

    ''' <summary>
    ''' Memperbarui data rujukan yang pernah di buat sebelumnya 
    ''' </summary>
    ''' <param name="oData">Type berisi data rujukan</param>
    ''' <param name="sURL">Alamat URL webservice (end point)</param>
    ''' <param name="ConsID">Cons ID dari BPJS Kesehatan</param>
    ''' <param name="sPass">SecretKey dari BPJS Kesehatan</param>
    ''' <returns>Rujukan.rsUpdateRujukan</returns>
    Public Shared Function wsUpdateRujukan(ByVal oData As TRujukan, ByVal sURL As String, ConsID As String, sPass As String) As clsUpdateDeleteRujukanResponse
        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(ConsID, sPass, sTimeStamp)
        Dim Request As HttpWebRequest = DirectCast(WebRequest.Create(sURL), HttpWebRequest)

        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New clsUpdateDeleteRujukanResponse

        Request.Method = "PUT"
        Request.KeepAlive = True
        Request.Credentials = cache
        Request.Accept = "application/xml"
        Request.Headers.Add("X-cons-id", ConsID)
        Request.Headers.Add("X-timestamp", sTimeStamp)
        Request.Headers.Add("X-signature", str2)

        Dim oDTO As New clsRujukanDto

        oDTO.Request.TRujukan = oData

        sPostData = JsonConvert.SerializeObject(oDTO)
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)


        Try
            Dim response As HttpWebResponse = DirectCast(Request.GetResponse, HttpWebResponse)
            response = TryCast(Request.GetResponse, HttpWebResponse)
            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            iTems = JsonConvert.DeserializeObject(Of clsUpdateDeleteRujukanResponse)(stext)
            rsUpdateRujukan = JsonConvert.DeserializeObject(Of clsUpdateDeleteRujukanResponse)(stext)
            Return iTems

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return Nothing
    End Function

    ''' <summary>
    ''' Menghapus data Rujukan yang dibuat sebelumnya
    ''' </summary>
    ''' <param name="sNoRujukan">Nomor Rujukan yang akan di hapus</param>
    ''' <param name="sUser">User</param>
    ''' <param name="sURL">Alamat URL webservice (end point)</param>
    ''' <param name="sConsID">Cons ID dari BPJS Kesehatan</param>
    ''' <param name="sPass">SecretKey dari BPJS Kesehatan</param>
    ''' <returns>Rujukan.rsDeleteRujukan</returns>
    Public Shared Function wsDeleteRujukan(sNoRujukan As String, sUser As String, sURL As String, sConsID As String, sPass As String) As clsUpdateDeleteRujukanResponse
        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As WebRequest = WebRequest.Create(sURL)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New StringBuilder
        Dim iTems As New clsUpdateDeleteRujukanResponse

        sReq.Append("{" & ChrW(34) & "request" & ChrW(34) & ":{" & ChrW(34) & "t_rujukan" & ChrW(34) & ":{" & ChrW(34) & "noRujukan" & ChrW(34) & ":" & ChrW(34) & sNoRujukan & ChrW(34))
        sReq.Append("," & ChrW(34) & "user" & ChrW(34) & ":" & ChrW(34) & sUser & ChrW(34) & "}}}")

        sPostData = sReq.ToString

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "DELETE"
        'request.KeepAlive = True
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        request.Credentials = cache

        request.Headers.Add("X-cons-id", sConsID)
        request.Headers.Add("X-timestamp", sTimeStamp)
        request.Headers.Add("X-signature", str2)
        Try

            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()

            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            response = TryCast(request.GetResponse, HttpWebResponse)

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            iTems = JsonConvert.DeserializeObject(Of clsUpdateDeleteRujukanResponse)(stext)
            rsDeleteRujukan = JsonConvert.DeserializeObject(Of clsUpdateDeleteRujukanResponse)(stext)

            Return iTems
        Catch exception As Exception
            Throw New Exception("Update Tgl. Pulang SEP Gagal. " & sURL & vbCrLf & exception.Message)

        End Try
        Return iTems
    End Function
End Class
