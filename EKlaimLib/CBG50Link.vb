'====================================================================
'  Copyright(C) 2017 Isnanto (http://isnanto.blogspot.com/)
' 
'  Licensed under the Apache License, Version 2.0 (the "License"); you may Not
'  use this file except In compliance With the License. You may obtain a copy Of
'  the License at
'
'  http://www.apache.org/licenses/LICENSE-2.0
' 
'  Unless required by applicable law Or agreed To In writing, software
'  distributed under the License Is distributed On an "AS IS" BASIS, WITHOUT
'  WARRANTIES Or CONDITIONS Of ANY KIND, either express Or implied. See the
'  License for the specific language governing permissions And limitations under
'  the License.
' 
'  The latest version Of this file can be found at https://github.com/isnanto/JKNBridge
'======================================================================

Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Class CBG50Link
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
    Public Shared Function KlaimBaru(sURL As String, sNoKartu As String, sNosEP As String, sNoRM As String, sNamaPasien As String, sTglLahir As String, sGender As String, sEncryptionKey As String) As KlaimBaru
        Dim sReturn As String = "InValid"


        Dim request As WebRequest = WebRequest.Create(sURL)
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
        sPostData = oenc.encrypt(sReq.ToString, sEncryptionKey)

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(sPostData)

        request.Method = "POST"

        request.ContentType = "application/json"
        request.ContentLength = byteArray.Length
        request.Credentials = cache


        Try

            Dim oStream As Stream = request.GetRequestStream()
            oStream.Write(byteArray, 0, byteArray.Length)
            oStream.Close()

            Dim response As WebResponse = DirectCast(request.GetResponse, HttpWebResponse)  ' 

            Dim enc As Encoding = System.Text.Encoding.GetEncoding(1252)
            Dim loResponseStream As New StreamReader(response.GetResponseStream(), enc)
            Dim stext As String = loResponseStream.ReadToEnd()

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sEncryptionKey)

            iTems = JsonConvert.DeserializeObject(Of KlaimBaru)(stext)

            Return iTems
        Catch exception As Exception
            Throw New Exception(exception.Message)
        End Try

        Return iTems
    End Function
    Public Shared Function UpdateDataPasien(surl As String, sNomorRM As String, sNomorKartu As String, sNamaPasien As String, sTglLahir As String, bGender As Byte, sEncryptionKey As String) As KlaimBaru
        Dim sReturn As String = "InValid"

        Dim request As WebRequest = WebRequest.Create(surl)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New KlaimBaru

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
        sPostData = oenc.encrypt(sReq.ToString, sEncryptionKey)

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

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sEncryptionKey)

            iTems = JsonConvert.DeserializeObject(Of KlaimBaru)(stext)

            Return iTems
        Catch exception As Exception
            Throw exception
        End Try

        Return iTems
    End Function



    Public Shared Function SetKlaimData(surl As String, sNoSEP As String, sNoKartu As String, sTglMasuk As String, sTglPulang As String, sJenisRawat As String, sKelasRawat As String, sadlsubacute As String, sadlChronic As String, sicuIndikator As String, sicuLos As String, sVentilatorhour As String, isNaikkelas As String, NaikKeKelas As String, sLosNaikKelas As String, sPaymentPct As String, sBeratLahir As String, sDischargstatus As String, sdiagnosa As List(Of String), sprosedur As List(Of String), starifrs As List(Of ClsCBGSend.srTarif), starifpolieks As String, snamadokter As String, sKodeTarif As String, sPyorID As String, sPayorCD As String, sCoderNIK As String, sEncryptionKey As String) As SetKlaimData
        Dim sReturn As String = "InValid"

        Dim request As WebRequest = WebRequest.Create(surl)
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


        For Each lTarif As ClsCBGSend.srTarif In starifrs
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
        sPostData = oenc.encrypt(sReq.ToString, sEncryptionKey)

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

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sEncryptionKey)

            iTems = JsonConvert.DeserializeObject(Of SetKlaimData)(stext)

            Return iTems
        Catch ex As Exception
            Throw ex
        End Try

        Return iTems
    End Function


    Public Shared Function Grouper1(surl As String, sNoSEP As String, sEncryptionKey As String) As Grouper1
        Dim sReturn As String = "InValid"

        Dim request As WebRequest = WebRequest.Create(surl)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New Grouper1

        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "grouper" & Chr(34) & ",")
        sReq.Append(Chr(34) & "stage" & Chr(34) & ":" & Chr(34) & "1" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNoSEP & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sEncryptionKey)

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

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sEncryptionKey)

            iTems = JsonConvert.DeserializeObject(Of Grouper1)(stext)

            Return iTems
        Catch exception As Exception
            Throw exception
        End Try

        Return iTems
    End Function


    Public Shared Function Grouper2(surl As String, sNoSEP As String, sCMG As String, sEncryptionKey As String) As Grouper2
        Dim sReturn As String = "InValid"


        Dim request As WebRequest = WebRequest.Create(surl)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New Grouper2

        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "grouper" & Chr(34) & ",")
        sReq.Append(Chr(34) & "stage" & Chr(34) & ":" & Chr(34) & "2" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNoSEP & Chr(34) & ",")
        sReq.Append(Chr(34) & "special_cmg" & Chr(34) & ":" & Chr(34) & sCMG & Chr(34))
        sReq.Append("}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sEncryptionKey)

        My.Computer.Clipboard.SetText(sPostData)

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

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sEncryptionKey)

            iTems = JsonConvert.DeserializeObject(Of Grouper2)(stext)

            Return iTems
        Catch exception As Exception
            Throw exception
        End Try

        Return iTems
    End Function

    Public Shared Function KlaimFinal(surl As String, sNoSEP As String, sNIK As String, sEncryptionKey As String) As KlaimFinal
        Dim sReturn As String = "InValid"

        Dim request As WebRequest = WebRequest.Create(surl)
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
        sPostData = oenc.encrypt(sReq.ToString, sEncryptionKey)

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

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sEncryptionKey)

            iTems = JsonConvert.DeserializeObject(Of KlaimFinal)(stext)

            Return iTems
        Catch exception As Exception
            Throw exception
        End Try

        Return iTems
    End Function

    Public Shared Function delete_claim(surl As String, sNoSEP As String, sNIK As String, sEncryptionKey As String) As CBGMetadata
        Dim sReturn As String = "InValid"

        Dim request As WebRequest = WebRequest.Create(surl)
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
        sPostData = oenc.encrypt(sReq.ToString, sEncryptionKey)

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

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sEncryptionKey)

            iTems = JsonConvert.DeserializeObject(Of CBGMetadata)(stext)
            Return iTems
        Catch exception As Exception
            Throw exception

        End Try

        Return iTems
    End Function


    ''' <summary>
    ''' Methode untuk edit klaim yang sudah difinal
    ''' </summary>
    ''' <param name="surl">URL tempat web service</param>
    ''' <param name="sNoSEP">No. SEP yang akan di edit</param>
    ''' <returns></returns>
    Public Shared Function EditKlaim(surl As String, sNoSEP As String, sEncryptionKey As String) As EditKlaim
        Dim sReturn As String = "InValid"

        Dim request As WebRequest = WebRequest.Create(surl)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New EditKlaim

        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "reedit_claim" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNoSEP & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sEncryptionKey)

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

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sEncryptionKey)

            iTems = JsonConvert.DeserializeObject(Of EditKlaim)(stext)
            'Return stext

            Return iTems
        Catch exception As Exception
            Throw exception
        End Try

        Return iTems
    End Function

    Public Shared Function Send2DataCenterIndividual(surl As String, sNoSEP As String, sEncryptionKey As String) As SendKlaimDC
        Dim sReturn As String = "InValid"
        Dim request As WebRequest = WebRequest.Create(surl)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New SendKlaimDC

        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "send_claim_individual" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "nomor_sep" & Chr(34) & ":" & Chr(34) & sNoSEP & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sEncryptionKey)

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

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sEncryptionKey)

            iTems = JsonConvert.DeserializeObject(Of SendKlaimDC)(stext)
            Return iTems
        Catch exception As Exception
            Throw exception
        End Try

        Return iTems
    End Function

    Public Shared Function Send2DataCenter(surl As String, sStartDate As String, sStopDate As String, sjenisRawat As String, sEncryptionKey As String) As SendKlaimDC
        Dim sReturn As String = "InValid"
        Dim request As WebRequest = WebRequest.Create(surl)
        Dim cache As New CredentialCache
        Dim sPostData As String
        Dim sReq As New System.Text.StringBuilder
        Dim iTems As New SendKlaimDC

        sReq.Append("{" & Chr(34) & "metadata" & Chr(34) & ":" & "{")
        sReq.Append(Chr(34) & "method" & Chr(34) & ": " & Chr(34) & "send_claim" & Chr(34) & "}, ")
        sReq.Append(Chr(34) & "data" & Chr(34) & ": " & "{")
        sReq.Append(Chr(34) & "start_dt" & Chr(34) & ":" & Chr(34) & sStartDate & Chr(34) & ",")
        sReq.Append(Chr(34) & "stop_dt" & Chr(34) & ":" & Chr(34) & sStartDate & Chr(34) & ",")
        sReq.Append(Chr(34) & "jenis_rawat" & Chr(34) & ":" & Chr(34) & sjenisRawat & Chr(34) & "}}")

        Dim oenc As New InaCrypto
        sPostData = oenc.encrypt(sReq.ToString, sEncryptionKey)

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

            stext = stext.Replace("----BEGIN ENCRYPTED DATA----", "")
            stext = stext.Replace("----END ENCRYPTED DATA----", "")
            stext = oenc.decrypt(stext, sEncryptionKey)

            iTems = JsonConvert.DeserializeObject(Of SendKlaimDC)(stext)
            Return iTems
        Catch exception As Exception
            Throw exception
        End Try

        Return iTems
    End Function

End Class

