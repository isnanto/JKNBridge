Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports System.Text.Json

Public Class SEP

    Public Shared rsInsertSEP As New clsInsertSEP
    Public Shared rsCariSEP As New clsCariSEP
    Public Shared rsHapusSEP As New clsHapusSEP
    Public Shared rsUpdateTglPulang As New clsUpdateTglPulang
    Public Shared rsPurifikasi As New MetaData


    Public Shared Function wsInsertSEP(oReqSEP As TSep, ByVal sURL As String, sConsID As String, sPass As String) As Boolean
        Dim sReturn As String = "InValid"

        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sPass, sTimeStamp)
        Dim request As WebRequest = WebRequest.Create(sURL)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New StringBuilder
        'Dim iTems As New clsInsertSEP

        Dim oDTO As New JKNBridge.VClaimLib.clsSEPdto
        oDTO.Request.TSep = oReqSEP


        sPostData = JsonConvert.SerializeObject(oDTO)
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)
        request.Method = "POST"
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

            rsInsertSEP = JsonConvert.DeserializeObject(Of clsInsertSEP)(stext)

            Return True

        Catch exception As Exception
            Throw New Exception("Pembuatan SEP Gagal. " & sURL & vbCrLf & exception.Message)
        End Try

        Return False
    End Function

    Public Shared Function wsHapusSEP(ByVal sURL As String, sConsID As String, sconsPass As String, dtStamp As Date, sSEP As String, sUser As String) As clsHapusSEP
        Dim sReturn As String = "InValid"

        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(dtStamp).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sconsPass, sTimeStamp)
        Dim request As WebRequest = WebRequest.Create(sURL)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New StringBuilder
        Dim iTems As New clsHapusSEP

        sReq.Append("{" & ChrW(34) & "request" & ChrW(34) & ":{" & ChrW(34) & "t_sep" & ChrW(34) & ":{" & ChrW(34) & "noSep" & ChrW(34) & ":" & ChrW(34) & sSEP & ChrW(34))
        sReq.Append("," & ChrW(34) & "user" & ChrW(34) & ":" & ChrW(34) & sUser & ChrW(34) & "}}}")

        sPostData = sReq.ToString

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "DELETE"
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

            rsHapusSEP = JsonConvert.DeserializeObject(Of clsHapusSEP)(stext)

            Return iTems
        Catch exception As Exception
            Throw New Exception("Penghapusan SEP Gagal. " & sURL & vbCrLf & exception.Message)
        End Try

        Return iTems
    End Function

    Public Shared Function wsCariSEP(ByVal NoSEP As String, ByVal uriStr As String, ByVal consId As String, ByVal consPass As String) As Boolean

        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(consId, consPass, sTimeStamp)
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(uriStr & "SEP/" & NoSEP), HttpWebRequest)
        Dim cache As New CredentialCache

        request.Method = "GET"
        request.KeepAlive = True

        request.Credentials = cache
        request.Headers.Add("X-cons-id", consId)
        request.Headers.Add("X-timestamp", sTimeStamp)
        request.Headers.Add("X-signature", str2)
        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
            response = TryCast(request.GetResponse, HttpWebResponse)

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()
            rsCariSEP = JsonConvert.DeserializeObject(Of clsCariSEP)(stext)

            Return True

        Catch exception As Exception
            Throw New Exception("Pencarian SEP Gagal." & vbCrLf & exception.Message)
        End Try
        Return False
    End Function

    Public Shared Function wsUpdateTglPulang(ByVal sURL As String, sConsID As String, sconsPass As String, sSEP As String, dTglPulang As Date, sUser As String) As clsUpdateTglPulang

        Dim sTimeStamp As String = clsFunction.ConvertToTimeStamp(DateTime.Now).ToString
        Dim str2 As String = clsFunction.GenerateSignature(sConsID, sconsPass, sTimeStamp)
        Dim request As WebRequest = WebRequest.Create(sURL)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New StringBuilder
        'Dim iTems As New clsUpdateTglPulang

        sReq.Append("{" & ChrW(34) & "request" & ChrW(34) & ":{" & ChrW(34) & "t_sep" & ChrW(34) & ":{" & ChrW(34) & "noSep" & ChrW(34) & ":" & ChrW(34) & sSEP & ChrW(34))
        sReq.Append("," & ChrW(34) & "tglpulang" & ChrW(34) & ":" & ChrW(34) & dTglPulang.ToString("yyyy-MM-dd") & ChrW(34))
        sReq.Append("," & ChrW(34) & "user" & ChrW(34) & ":" & ChrW(34) & sUser & ChrW(34) & "}}}")

        sPostData = sReq.ToString

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "PUT"
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

            rsUpdateTglPulang = JsonConvert.DeserializeObject(Of clsUpdateTglPulang)(stext)
            Return rsUpdateTglPulang
        Catch exception As Exception
            Throw New Exception("Update Tgl. Pulang SEP Gagal. " & sURL & vbCrLf & exception.Message)
        End Try

        Return rsUpdateTglPulang
    End Function
    Public Shared Function wsPurifikasi(ByVal sURL As String, sConsID As String, sSecretKey As String, sSEP As String, sNoPeserta As String, sKodeKelas As String, sTglMasuk As String) As MetaData

        rsPurifikasi.Code = "200"
        rsPurifikasi.Message = "Data Valid"
        Try
            wsCariSEP(sSEP, sURL, sConsID, sSecretKey)
            If rsCariSEP.MetaData.Code.Equals("200") Then
                If Not rsCariSEP.Response.Peserta.NoKartu.Equals(sNoPeserta) Then
                    rsPurifikasi.Code = "213"
                    rsPurifikasi.Message = "Nomor Kartu tidak cocok dengan SEP"
                End If

                If Not rsCariSEP.Response.TglSep.Equals(sTglMasuk) Then
                    rsPurifikasi.Code = "214"
                    rsPurifikasi.Message = "Tgl Masuk RS tidak sesuai dengan tanggal SEP"
                End If

                If rsCariSEP.Response.JnsPelayanan = "Rawat INap" Then
                    If Not rsCariSEP.Response.KelasRawat.Trim.Equals(sKodeKelas) Then
                        rsPurifikasi.Code = "215"
                        rsPurifikasi.Message = "Kelas perawatan tidak sesuai dengan SEP"
                    End If
                End If

                Return rsPurifikasi
            Else
                rsPurifikasi.Code = rsCariSEP.MetaData.Code
                rsPurifikasi.Message = rsCariSEP.MetaData.Message
                Return rsPurifikasi

            End If

            Return rsPurifikasi

        Catch ex As Exception
            rsPurifikasi.Code = "9999"
            rsPurifikasi.Message = ex.Message
            Return rsPurifikasi
        End Try
        Return rsPurifikasi
    End Function
End Class
