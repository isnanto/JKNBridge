Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Class CBGLink
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    ''' <summary>
    ''' Methode New_Claim, Membuat klaim baru dan registrasi pasien jika belum ada.
    ''' </summary>
    ''' <param name="sURL"></param>
    ''' <param name="sNoKartu"></param>
    ''' <param name="sNosEP"></param>
    ''' <param name="sNoRM"></param>
    ''' <param name="sNamaPasien"></param>
    ''' <param name="sTglLahir"></param>
    ''' <param name="sGender"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function KlaimBaru(sURL As String, sNoKartu As String, sNosEP As String, sNoRM As String, sNamaPasien As String, sTglLahir As String, sGender As String, sSecureKey As String) As KlaimBaru
        Dim sReturn As String = "InValid"

        Dim request As WebRequest = WebRequest.Create(sURL) ' DirectCast(WebRequest.Create(sURL), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New KlaimBaru

        sReq.Append("{")
        sReq.Append(Chr(34) & "metadata" & Chr(34) & ": {")
        sReq.Append(Chr(34) & "method" & Chr(34) & ":" & Chr(34) & "new_claim" & Chr(34))
        sReq.Append("},")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": {")
        sReq.Append(Chr(34) & "nomor_kartu" & Chr(34) & ":" & Chr(34) & sNoKartu & Chr(34) & ",")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNosEP & Chr(34) & ",")
        sReq.Append(Chr(34) & "nomor_rm" & Chr(34) & ":" & Chr(34) & sNoRM & Chr(34) & ",")
        sReq.Append(Chr(34) & "nama_pasien" & Chr(34) & ":" & Chr(34) & sNamaPasien & Chr(34) & ",")
        sReq.Append(Chr(34) & "tgl_lahir" & Chr(34) & ":" & Chr(34) & sTglLahir & Chr(34) & ",")
        sReq.Append(Chr(34) & "gender" & Chr(34) & ":" & Chr(34) & sGender & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sSecureKey)

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "POST"
        'request.KeepAlive = True
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache


        Try

            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()

            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)  'request.GetResponse()  '
            response = TryCast(request.GetResponse, HttpWebResponse)

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sSecureKey)

            iTems = JsonConvert.DeserializeObject(Of KlaimBaru)(stext)

            Return iTems
        Catch exception As Exception
            Throw New Exception(exception.Message)
        End Try

        Return iTems
    End Function

    Public Shared Function SetKlaimData(surl As String, sNoSEP As String, sNoKartu As String, sTglMasuk As String, sTglPulang As String, sJenisRawat As String, sKelasRawat As String, sadlsubacute As String, sadlChronic As String, sicuIndikator As String, sicuLos As String, sVentilatorhour As String, isNaikkelas As String, NaikKeKelas As String, sLosNaikKelas As String, sPaymentPct As String, sBeratLahir As String, sDischargstatus As String, sdiagnosa As List(Of String), sprosedur As List(Of String), starifrs As List(Of CBGLink.srTarif), starifpolieks As String, snamadokter As String, sKodeTarif As String, sPyorID As String, sPayorCD As String, sCoderNIK As String, sSecureKey As String) As SetKlaimData
        Dim sReturn As String = "InValid"

        'Dim DSet As New DataSet
        Dim request As WebRequest = WebRequest.Create(surl) ' DirectCast(WebRequest.Create(sURL), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New SetKlaimData

        Dim lProsedur As String = ""
        Dim lDiagnosa As String = ""

        For nDx As Byte = 0 To sdiagnosa.Count - 1
            lDiagnosa = lDiagnosa & sdiagnosa(nDx) & "#"
        Next

        For nProc As Byte = 0 To sprosedur.Count - 1
            lProsedur = lProsedur & sprosedur(nProc) & "#"
        Next
        'Dim sData As String

        'sData = ""
        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "set_claim_data" & Chr(34) & ",")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNoSEP & Chr(34) & "},")
        sReq.Append(Chr(34) & "data" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNoSEP & Chr(34) & ",")
        sReq.Append(Chr(34) & "nomor_kartu" & Chr(34) & ":" & Chr(34) & sNoKartu & Chr(34) & ",")
        sReq.Append(Chr(34) & "tgl_masuk" & Chr(34) & ":" & Chr(34) & sTglMasuk & Chr(34) & ",")
        sReq.Append(Chr(34) & "tgl_pulang" & Chr(34) & ":" & Chr(34) & sTglPulang & Chr(34) & ",")
        sReq.Append(Chr(34) & "jenis_rawat" & Chr(34) & ":" & Chr(34) & sJenisRawat & Chr(34) & ",")
        sReq.Append(Chr(34) & "kelas_rawat" & Chr(34) & ":" & Chr(34) & sKelasRawat & Chr(34) & ", ")
        sReq.Append(Chr(34) & "adl_sub_acute" & Chr(34) & ": " & Chr(34) & sadlsubacute & Chr(34) & ",")
        sReq.Append(Chr(34) & "icu_indikator" & Chr(34) & ": " & Chr(34) & sicuIndikator & Chr(34) & ",")
        sReq.Append(Chr(34) & "icu_los" & Chr(34) & ":" & Chr(34) & sicuLos & Chr(34) & ", ")
        sReq.Append(Chr(34) & "ventilator_hour" & Chr(34) & ": " & Chr(34) & sVentilatorhour & Chr(34) & ",")

        sReq.Append(Chr(34) & "upgrade_class_ind" & Chr(34) & ": " & Chr(34) & isNaikkelas & Chr(34) & ",")
        sReq.Append(Chr(34) & "upgrade_class_class" & Chr(34) & ":" & Chr(34) & NaikKeKelas & Chr(34) & ", ")
        sReq.Append(Chr(34) & "upgrade_class_los" & Chr(34) & ": " & Chr(34) & sLosNaikKelas & Chr(34) & ",")
        sReq.Append(Chr(34) & "add_payment_pct" & Chr(34) & ": " & Chr(34) & sPaymentPct & Chr(34) & ",")
        sReq.Append(Chr(34) & "birth_weight" & Chr(34) & ": " & Chr(34) & sBeratLahir & Chr(34) & ",")
        sReq.Append(Chr(34) & "discharge_status" & Chr(34) & ":" & Chr(34) & sDischargstatus & Chr(34) & ", ")
        sReq.Append(Chr(34) & "diagnosa" & Chr(34) & ": " & Chr(34) & lDiagnosa & Chr(34) & ",")
        sReq.Append(Chr(34) & "procedure" & Chr(34) & ":" & Chr(34) & lProsedur & Chr(34) & ", ")
        sReq.Append(Chr(34) & "nama_dokter" & Chr(34) & ":" & Chr(34) & snamadokter & Chr(34) & ", ")
        sReq.Append(Chr(34) & "tarif_rs" & Chr(34) & ": {")


        For Each lTarif As CBGLink.srTarif In starifrs
            sReq.Append(Chr(34) & lTarif.sParameterstring & Chr(34) & ":" & Chr(34) & lTarif.lBiaya.ToString() & Chr(34) & ",")
        Next

        sReq.Remove(sReq.Length - 1, 1)
        sReq.Append("},")
        sReq.Append(Chr(34) & "tarif_poli_eks" & Chr(34) & ": " & Chr(34) & starifpolieks & Chr(34) & ",")
        sReq.Append(Chr(34) & "kode_tarif" & Chr(34) & ":" & Chr(34) & sKodeTarif & Chr(34) & ", ")
        sReq.Append(Chr(34) & "payor_id" & Chr(34) & ": " & Chr(34) & sPyorID & Chr(34) & ",")
        sReq.Append(Chr(34) & "payor_cd" & Chr(34) & ":" & Chr(34) & sPayorCD & Chr(34) & ",")
        sReq.Append(Chr(34) & "coder_nik" & Chr(34) & ":" & Chr(34) & sCoderNIK & Chr(34) & "}}")



        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sSecureKey)

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "POST"
        'request.KeepAlive = True
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache


        Try

            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()

            'MessageBox.Show(sPostData)

            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)  'request.GetResponse()  '
            response = TryCast(request.GetResponse, HttpWebResponse)
            'oStream = response.GetResponseStream()
            'Dim reader As New StreamReader(oStream)
            ' Read the content.
            'Dim stext As String = reader.ReadToEnd()

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sSecureKey)

            iTems = JsonConvert.DeserializeObject(Of SetKlaimData)(stext)
            'Return stext

            Return iTems
        Catch exception As Exception
            'MessageBox.Show("Pembuatan Data Klaim Baru. " & surl & vbCrLf & exception.Message, "SetKlaimData", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Throw New Exception(exception.Message) 'Return False
        End Try
        ' Return sText

        Return iTems
    End Function


    Public Shared Function Grouper1(surl As String, sNoSEP As String, sSecureKey As String) As Grouper1
        Dim sReturn As String = "InValid"

        'Dim DSet As New DataSet
        Dim request As WebRequest = WebRequest.Create(surl) ' DirectCast(WebRequest.Create(sURL), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New Grouper1


        'sData = ""
        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "grouper" & Chr(34) & ",")
        sReq.Append(Chr(34) & "stage" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNoSEP & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sSecureKey)

        'MsgBox(sPostData)
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "POST"
        'request.KeepAlive = True
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache


        Try

            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()

            'MessageBox.Show(sPostData)

            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)  'request.GetResponse()  '
            response = TryCast(request.GetResponse, HttpWebResponse)
            'oStream = response.GetResponseStream()
            'Dim reader As New StreamReader(oStream)
            ' Read the content.
            'Dim stext As String = reader.ReadToEnd()

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sSecureKey)

            iTems = JsonConvert.DeserializeObject(Of Grouper1)(stext)
            'Return stext

            Return iTems
        Catch exception As Exception
            'MessageBox.Show("Pembuatan Data Klaim Baru. " & surl & vbCrLf & exception.Message, "Grouper1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Return False
        End Try
        ' Return sText

        Return iTems
    End Function


    Public Shared Function Grouper2(surl As String, sNoSEP As String, sCMG As String, sSecureKey As String) As Grouper2
        Dim sReturn As String = "InValid"

        'Dim DSet As New DataSet
        Dim request As WebRequest = WebRequest.Create(surl) ' DirectCast(WebRequest.Create(sURL), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New Grouper2

        'sData = ""
        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "grouper" & Chr(34) & ",")
        sReq.Append(Chr(34) & "stage" & Chr(34) & ":" & Chr(34) & "2" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNoSEP & Chr(34) & ",")
        sReq.Append(Chr(34) & "special_cmg" & Chr(34) & ":" & Chr(34) & sCMG & Chr(34))
        sReq.Append("}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sSecureKey)

        My.Computer.Clipboard.SetText(sPostData)

        'MsgBox(sPostData)
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "POST"
        'request.KeepAlive = True
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache

        Try

            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()

            'MessageBox.Show(sPostData)

            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)  'request.GetResponse()  '
            response = TryCast(request.GetResponse, HttpWebResponse)
            'oStream = response.GetResponseStream()
            'Dim reader As New StreamReader(oStream)
            ' Read the content.
            'Dim stext As String = reader.ReadToEnd()

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sSecureKey)

            iTems = JsonConvert.DeserializeObject(Of Grouper2)(stext)
            'Return stext

            Return iTems
        Catch exception As Exception
            'MessageBox.Show("Pembuatan Data Klaim Baru. " & surl & vbCrLf & exception.Message, "Grouper1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Return False
        End Try
        ' Return sText

        Return iTems
    End Function

    Public Shared Function KlaimFinal(surl As String, sNoSEP As String, sNIK As String, sSecureKey As String) As KlaimFinal
        Dim sReturn As String = "InValid"

        Dim request As WebRequest = WebRequest.Create(surl) ' DirectCast(WebRequest.Create(sURL), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New KlaimFinal

        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "claim_final" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNoSEP & Chr(34) & ",")
        sReq.Append(Chr(34) & "coder_nik" & Chr(34) & ":" & Chr(34) & sNIK & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sSecureKey)

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "POST"
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache

        Try
            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()
            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)  'request.GetResponse()  '
            response = TryCast(request.GetResponse, HttpWebResponse)

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sSecureKey)

            iTems = JsonConvert.DeserializeObject(Of KlaimFinal)(stext)
            'Return stext

            Return iTems
        Catch exception As Exception
            'MessageBox.Show("Pembuatan Data Klaim Baru. " & surl & vbCrLf & exception.Message, "Grouper1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Return False
        End Try
        ' Return sText

        Return iTems
    End Function

    Public Shared Function delete_claim(surl As String, sNoSEP As String, sNIK As String, sSecureKey As String) As CBGMetadata
        Dim sReturn As String = "InValid"

        Dim request As WebRequest = WebRequest.Create(surl) ' DirectCast(WebRequest.Create(sURL), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New CBGMetadata

        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "delete_claim" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNoSEP & Chr(34) & ",")
        sReq.Append(Chr(34) & "coder_nik" & Chr(34) & ":" & Chr(34) & sNIK & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sSecureKey)

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "POST"
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache

        Try
            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()
            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)  'request.GetResponse()  '
            response = TryCast(request.GetResponse, HttpWebResponse)

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sSecureKey)

            iTems = JsonConvert.DeserializeObject(Of CBGMetadata)(stext)
            Return iTems
        Catch exception As Exception
            'MessageBox.Show("Penghapusan data klaim gagal. " & surl & vbCrLf & exception.Message, "Grouper1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

        Return iTems
    End Function


    ''' <summary>
    ''' Methode untuk edit klaim yang sudah difinal
    ''' </summary>
    ''' <param name="surl">URL tempat web service</param>
    ''' <param name="sNoSEP">No. SEP yang akan di edit</param>
    ''' <returns></returns>
    Public Shared Function EditKlaim(surl As String, sNoSEP As String, sSecureKey As String) As EditKlaim
        Dim sReturn As String = "InValid"

        'Dim DSet As New DataSet
        Dim request As WebRequest = WebRequest.Create(surl) ' DirectCast(WebRequest.Create(sURL), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New EditKlaim


        'sData = ""
        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "reedit_claim" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNoSEP & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sSecureKey)

        'MsgBox(sPostData)
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "POST"
        'request.KeepAlive = True
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache


        Try

            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()

            'MessageBox.Show(sPostData)

            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)  'request.GetResponse()  '
            response = TryCast(request.GetResponse, HttpWebResponse)
            'oStream = response.GetResponseStream()
            'Dim reader As New StreamReader(oStream)
            ' Read the content.
            'Dim stext As String = reader.ReadToEnd()

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sSecureKey)

            iTems = JsonConvert.DeserializeObject(Of EditKlaim)(stext)
            'Return stext

            Return iTems
        Catch exception As Exception
            'MessageBox.Show("Pembuatan Data Klaim Baru. " & surl & vbCrLf & exception.Message, "Grouper1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Return False
        End Try
        ' Return sText

        Return iTems
    End Function

    '===============
    'Tambahan data
    '================


    'TODO : Belum punya response
    Public Shared Function UpdateDataPasien(surl As String, sNomorRM As String, sNomorKartu As String, sNamaPasien As String, sTglLahir As String, bGender As Byte, sSecureKey As String) As KlaimBaru
        Dim sReturn As String = "InValid"

        'Dim DSet As New DataSet
        Dim request As WebRequest = WebRequest.Create(surl) ' DirectCast(WebRequest.Create(sURL), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New KlaimBaru


        'sData = ""
        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "update_patient" & Chr(34) & ",")
        sReq.Append(Chr(34) & "nomor_rm" & Chr(34) & ":" & Chr(34) & sNomorRM & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "nomor_kartu" & Chr(34) & ":" & Chr(34) & sNomorKartu & Chr(34) & ",")
        sReq.Append(Chr(34) & "nomor_rm" & Chr(34) & ":" & Chr(34) & sNomorRM & Chr(34) & ",")
        sReq.Append(Chr(34) & "nama_pasien" & Chr(34) & ":" & Chr(34) & sNamaPasien & Chr(34) & ",")
        sReq.Append(Chr(34) & "tgl_lahir" & Chr(34) & ":" & Chr(34) & sTglLahir & Chr(34) & ",")
        sReq.Append(Chr(34) & "gender" & Chr(34) & ":" & Chr(34) & bGender & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sSecureKey)

        'MsgBox(sPostData)
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "POST"
        'request.KeepAlive = True
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache


        Try

            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()

            'MessageBox.Show(sPostData)

            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)  'request.GetResponse()  '
            response = TryCast(request.GetResponse, HttpWebResponse)
            'oStream = response.GetResponseStream()
            'Dim reader As New StreamReader(oStream)
            ' Read the content.
            'Dim stext As String = reader.ReadToEnd()

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sSecureKey)

            iTems = JsonConvert.DeserializeObject(Of KlaimBaru)(stext)
            'Return stext

            Return iTems
        Catch exception As Exception
            'MessageBox.Show("Pembuatan Data Klaim Baru. " & surl & vbCrLf & exception.Message, "UpdateDataPasien", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Return False
        End Try
        ' Return sText

        Return iTems
    End Function

    Public Shared Function Send2DataCenterIndividual(surl As String, sNoSEP As String, sSecureKey As String) As SendKlaimDC
        Dim sReturn As String = "InValid"
        Dim request As WebRequest = WebRequest.Create(surl) ' DirectCast(WebRequest.Create(sURL), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New SendKlaimDC


        'sData = ""
        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "send_claim_individual" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNoSEP & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sSecureKey)

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "POST"
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache

        Try
            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()
            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)  'request.GetResponse()  '
            response = TryCast(request.GetResponse, HttpWebResponse)
            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sSecureKey)

            iTems = JsonConvert.DeserializeObject(Of SendKlaimDC)(stext)
            Return iTems
        Catch exception As Exception
            'MessageBox.Show("Pengiriman ke Data Center. " & surl & vbCrLf & exception.Message, "Send2DataCenterIndividual", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        Return iTems
    End Function

    Public Shared Function Send2DataCenter(surl As String, sStartDate As String, sStopDate As String, sjenisRawat As String, sSecureKey As String) As SendKlaimDC
        Dim sReturn As String = "InValid"
        Dim request As WebRequest = WebRequest.Create(surl) ' DirectCast(WebRequest.Create(sURL), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New SendKlaimDC


        'sData = ""
        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "send_claim" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "start_dt" & Chr(34) & ":" & Chr(34) & sStartDate & Chr(34) & ",")
        sReq.Append(Chr(34) & "stop_dt" & Chr(34) & ":" & Chr(34) & sStartDate & Chr(34) & ",")
        sReq.Append(Chr(34) & "jenis_rawat" & Chr(34) & ":" & Chr(34) & sjenisRawat & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sSecureKey)

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "POST"
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache

        Try
            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()
            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)  'request.GetResponse()  '
            response = TryCast(request.GetResponse, HttpWebResponse)
            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sSecureKey)

            iTems = JsonConvert.DeserializeObject(Of SendKlaimDC)(stext)
            Return iTems
        Catch exception As Exception
            'MessageBox.Show("Pengiriman ke Data Center. " & surl & vbCrLf & exception.Message, "Send2DataCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        Return iTems
    End Function

    'mengambil detail data klaim (get_claim_data)
    'Belum ada response
    Public Shared Function get_claim_data(surl As String, sSEP As String, sSecureKey As String) As SendKlaimDC
        Dim sReturn As String = "InValid"
        Dim request As WebRequest = WebRequest.Create(surl) ' DirectCast(WebRequest.Create(sURL), HttpWebRequest)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New SendKlaimDC


        'sData = ""
        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "get_claim_data" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sSEP & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sSecureKey)

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "POST"
        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache

        Try
            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()
            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)  'request.GetResponse()  '
            response = TryCast(request.GetResponse, HttpWebResponse)
            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sSecureKey)

            iTems = JsonConvert.DeserializeObject(Of SendKlaimDC)(stext)
            Return iTems
        Catch exception As Exception
            'MessageBox.Show("Pengiriman ke Data Center. " & surl & vbCrLf & exception.Message, "get_claim_data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        Return iTems
    End Function

    Public Structure srTarif
        Public iKelompok As Integer
        Public sParameterstring As String
        Public lBiaya As Double
    End Structure

End Class

