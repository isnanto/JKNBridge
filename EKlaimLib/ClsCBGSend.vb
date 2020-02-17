'====================================================================
'  Copyright(C) 2017 Kamarudin (http://isnanto.blogspot.com/)
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

''' <summary>
''' Class berisi methode untuk mengirim data ke Elaim, Ideal untuk digunakan oleh aplikasi simrs. Dengan satu metode ini, Data akan otoatis di kirim ke eklaim sampai dengan pengiriman data ke kemenkes.
''' </summary>
Public Class ClsCBGSend
    ''' <summary>
    ''' Metode untuk mengirim data ke EKlaim dalam satu proses. 
    ''' </summary>
    ''' <param name="sCBGServer"></param>
    ''' <param name="sCBGUser"></param>
    ''' <param name="sCBGPassword"></param>
    ''' <param name="sNoPasien"></param>
    ''' <param name="sNamaPasien"></param>
    ''' <param name="sJenisKelamin"></param>
    ''' <param name="sTglLahir"></param>
    ''' <param name="nJenisPembayaran"></param>
    ''' <param name="nNoPeserta"></param>
    ''' <param name="sNoSEP"></param>
    ''' <param name="sJenisPerawatan"></param>
    ''' <param name="sKlsPerawatn"></param>
    ''' <param name="sTglmasuk"></param>
    ''' <param name="sTglKeluar"></param>
    ''' <param name="sCaraKeluar"></param>
    ''' <param name="sDPJP"></param>
    ''' <param name="sBeratLhir"></param>
    ''' <param name="sTarifRS"></param>
    ''' <param name="sSuratRujukan"></param>
    ''' <param name="sBHP"></param>
    ''' <param name="SeverityLevel3"></param>
    ''' <param name="sADL"></param>
    ''' <param name="sPecProc"></param>
    ''' <param name="sPecDrug"></param>
    ''' <param name="sPecInv"></param>
    ''' <param name="sPecProsth"></param>
    ''' <param name="lDiagnosa"></param>
    ''' <param name="lProcedure"></param>
    ''' <param name="sICUIndikator"></param>
    ''' <param name="sICULos"></param>
    ''' <param name="isNaikKelas"></param>
    ''' <param name="sNaikKeKelas"></param>
    ''' <param name="sLosNaikKelas"></param>
    ''' <param name="sPaymentPct"></param>
    ''' <param name="sNIKCoder"></param>
    ''' <param name="sEncryptionKey"></param>
    ''' <returns></returns>
    Public Function SentToCBG(sCBGServer As String, sCBGUser As String, sCBGPassword As String, sNoPasien As String, sNamaPasien As String, sJenisKelamin As Byte, sTglLahir As String, nJenisPembayaran As String, nNoPeserta As String, sNoSEP As String, sJenisPerawatan As String, sKlsPerawatn As String, sTglmasuk As String, sTglKeluar As String, sCaraKeluar As String, sDPJP As String, sBeratLhir As String, sTarifRS As List(Of srTarif), sSuratRujukan As String, sBHP As String, SeverityLevel3 As String, sADL As String, sPecProc As String, sPecDrug As String, sPecInv As String, sPecProsth As String, lDiagnosa As List(Of String), lProcedure As List(Of String), sICUIndikator As String, sICULos As String, isNaikKelas As String, sNaikKeKelas As String, sLosNaikKelas As String, sPaymentPct As String, sNIKCoder As String, sEncryptionKey As String) As clsCBG50FeedBack

        Dim oFeed As New clsCBG50FeedBack

        Dim NewKlaim As New KlaimBaru
        Dim EditPasien As New KlaimBaru
        Dim IsiKlaim As SetKlaimData
        Dim Group1 As Grouper1
        Dim Group2 As Grouper2
        Dim Final As KlaimFinal
        Dim nTotalTarif As Double = 0

        NewKlaim = CBG50Link.KlaimBaru("http://" & sCBGServer & "/eklaim/ws.php", nNoPeserta, sNoSEP, sNoPasien, sNamaPasien, sTglLahir, sJenisKelamin, sEncryptionKey)

        EditPasien = CBG50Link.UpdateDataPasien("http://" & sCBGServer & "/eklaim/ws.php", sNoPasien, nNoPeserta, sNamaPasien, sTglLahir, sJenisKelamin, sEncryptionKey)

        If NewKlaim.Metadata.Code = 400 Then
            Dim b As EditKlaim = CBG50Link.EditKlaim("http://" & sCBGServer & "/eklaim/ws.php", sNoSEP, sEncryptionKey)
        End If

        IsiKlaim = CBG50Link.SetKlaimData("http://" & sCBGServer & "/eklaim/ws.php", sNoSEP, nNoPeserta, sTglmasuk, sTglKeluar, sJenisPerawatan, sKlsPerawatn, sADL, sADL, "0", "0", "0", isNaikKelas, sNaikKeKelas, sLosNaikKelas, sPaymentPct, sBeratLhir, sCaraKeluar, lDiagnosa, lProcedure, sTarifRS, "15000", sDPJP, "BP", "3", "JKN", sNIKCoder, sEncryptionKey)

        Group1 = CBG50Link.Grouper1("http://" & sCBGServer & "/eklaim/ws.php", sNoSEP, sEncryptionKey)


        If Group1.Metadata.Code = "200" And IsNothing(Group1.Response) Then
            Throw New Exception("Proses grouping gagal, INACBG 50 hanya untuk pasien yang masuk diatas tanggal 26 Oktober 2016")
        ElseIf Not Group1.Metadata.Code.Equals("200") Then
            Throw New Exception(String.Concat("Proses grouping gagal. ", Group1.Metadata.Message))
        ElseIf Group1.Response.Cbg.Code Like "Invalid*" Then
            Group1.Response.Cbg.Code = "X" & Group1.Response.Cbg.Code
            Throw New Exception(Group1.Response.Cbg.Code)
        ElseIf Group1.Response.Cbg.Code Like "X*" Then
            oFeed.Metadata.Code = Group1.Metadata.Code
            oFeed.Metadata.Message = Group1.Metadata.Message
            oFeed.Response.CBG.Code = Group1.Response.Cbg.Code
            oFeed.Response.CBG.Description = Group1.Response.Cbg.Description
            oFeed.Response.CBG.Tariff = "0"
            oFeed.TotalTarif = "0"
            oFeed.Response.kelas = Group1.Response.kelas
            oFeed.Response.add_payment_amt = Group1.Response.add_payment_amt
            oFeed.Response.InacbgVersion = Group1.Response.InacbgVersion


            If IsNothing(oFeed.spesial_cmg_option.DeskripsiSD) Then oFeed.spesial_cmg_option.DeskripsiSD = ""
            If IsNothing(oFeed.spesial_cmg_option.DeskripsiSI) Then oFeed.spesial_cmg_option.DeskripsiSI = ""
            If IsNothing(oFeed.spesial_cmg_option.DeskripsiSP) Then oFeed.spesial_cmg_option.DeskripsiSP = ""
            If IsNothing(oFeed.spesial_cmg_option.DeskripsiSR) Then oFeed.spesial_cmg_option.DeskripsiSR = ""
            If IsNothing(oFeed.spesial_cmg_option.KodeSD) Then oFeed.spesial_cmg_option.KodeSD = ""
            If IsNothing(oFeed.spesial_cmg_option.KodeSI) Then oFeed.spesial_cmg_option.KodeSI = ""
            If IsNothing(oFeed.spesial_cmg_option.KodeSP) Then oFeed.spesial_cmg_option.KodeSP = ""
            If IsNothing(oFeed.spesial_cmg_option.KodeSR) Then oFeed.spesial_cmg_option.KodeSR = ""
            If IsNothing(oFeed.spesial_cmg_option.TariffSD) Then oFeed.spesial_cmg_option.TariffSD = "0"
            If IsNothing(oFeed.spesial_cmg_option.TariffSI) Then oFeed.spesial_cmg_option.TariffSI = "0"
            If IsNothing(oFeed.spesial_cmg_option.TariffSP) Then oFeed.spesial_cmg_option.TariffSP = "0"
            If IsNothing(oFeed.spesial_cmg_option.TariffSR) Then oFeed.spesial_cmg_option.TariffSR = "0"

            Return oFeed
        End If

        oFeed.Tarif_alt = Group1.TarifAlt
        nTotalTarif = Convert.ToDouble(Group1.Response.Cbg.Tariff)
        If Not IsNothing(Group1.SpecialCmgOption) Then
            If Group1.SpecialCmgOption.Length > 0 Then
                Dim sCMG As String = ""

                For nSP As Integer = 0 To Group1.SpecialCmgOption.Count - 1
                    If Group1.SpecialCmgOption(nSP).Code Like "D*" Then

                    Else
                        sCMG = sCMG & Group1.SpecialCmgOption(nSP).Code & "#"
                    End If

                Next
                If Not String.IsNullOrEmpty(sCMG) Then sCMG = Microsoft.VisualBasic.Left(sCMG, sCMG.Length - 1)
                Group2 = CBG50Link.Grouper2("http://" & sCBGServer & "/eklaim/ws.php", sNoSEP, sCMG, sEncryptionKey)

                oFeed.Metadata.Code = Group2.Metadata.Code
                oFeed.Metadata.Message = Group2.Metadata.Message
                oFeed.Response.CBG.Code = Group2.Response.Cbg.Code
                oFeed.Response.CBG.Description = Group2.Response.Cbg.Description
                oFeed.Response.CBG.Tariff = Group2.Response.Cbg.Tariff
                oFeed.Response.kelas = Group2.Response.kelas
                oFeed.Response.add_payment_amt = Group2.Response.add_payment_amt
                oFeed.Response.InacbgVersion = Group2.Response.InacbgVersion

                nTotalTarif = Convert.ToDouble(Group2.Response.Cbg.Tariff)
                If IsNothing(Group2.Response.SpecialCmg) Then

                Else
                    For sSP As Integer = 0 To Group2.Response.SpecialCmg.Count - 1
                        If Group2.Response.SpecialCmg(sSP).Code Like "YY*" Then
                            oFeed.spesial_cmg_option.KodeSP = Group2.Response.SpecialCmg(sSP).Code
                            oFeed.spesial_cmg_option.DeskripsiSP = Group2.Response.SpecialCmg(sSP).Description
                            oFeed.spesial_cmg_option.TariffSP = Group2.Response.SpecialCmg(sSP).Tariff
                            oFeed.spesial_cmg_option.TypeSP = Group2.Response.SpecialCmg(sSP).Type
                            nTotalTarif = nTotalTarif + Convert.ToDouble(Group2.Response.SpecialCmg(sSP).Tariff)

                        ElseIf Group2.Response.SpecialCmg(sSP).Code Like "RR*" Then
                            oFeed.spesial_cmg_option.KodeSR = Group2.Response.SpecialCmg(sSP).Code
                            oFeed.spesial_cmg_option.DeskripsiSR = Group2.Response.SpecialCmg(sSP).Description
                            oFeed.spesial_cmg_option.TariffSR = Group2.Response.SpecialCmg(sSP).Tariff
                            oFeed.spesial_cmg_option.TypeSR = Group2.Response.SpecialCmg(sSP).Type
                            nTotalTarif = nTotalTarif + Convert.ToDouble(Group2.Response.SpecialCmg(sSP).Tariff)

                        ElseIf Group2.Response.SpecialCmg(sSP).Code Like "II*" Then
                            oFeed.spesial_cmg_option.KodeSI = Group2.Response.SpecialCmg(sSP).Code
                            oFeed.spesial_cmg_option.DeskripsiSI = Group2.Response.SpecialCmg(sSP).Description
                            oFeed.spesial_cmg_option.TariffSI = Group2.Response.SpecialCmg(sSP).Tariff
                            oFeed.spesial_cmg_option.TypeSI = Group2.Response.SpecialCmg(sSP).Type
                            nTotalTarif = nTotalTarif + Convert.ToDouble(Group2.Response.SpecialCmg(sSP).Tariff)

                        ElseIf Group2.Response.SpecialCmg(sSP).Code Like "DD*" Then
                            oFeed.spesial_cmg_option.KodeSD = Group2.Response.SpecialCmg(sSP).Code
                            oFeed.spesial_cmg_option.DeskripsiSD = Group2.Response.SpecialCmg(sSP).Description
                            oFeed.spesial_cmg_option.TariffSD = Group2.Response.SpecialCmg(sSP).Tariff
                            oFeed.spesial_cmg_option.TypeSD = Group2.Response.SpecialCmg(sSP).Type
                            nTotalTarif = nTotalTarif + Convert.ToDouble(Group2.Response.SpecialCmg(sSP).Tariff)

                        End If
                    Next
                End If


                If IsNothing(oFeed.spesial_cmg_option.DeskripsiSD) Then oFeed.spesial_cmg_option.DeskripsiSD = ""
                If IsNothing(oFeed.spesial_cmg_option.DeskripsiSI) Then oFeed.spesial_cmg_option.DeskripsiSI = ""
                If IsNothing(oFeed.spesial_cmg_option.DeskripsiSP) Then oFeed.spesial_cmg_option.DeskripsiSP = ""
                If IsNothing(oFeed.spesial_cmg_option.DeskripsiSR) Then oFeed.spesial_cmg_option.DeskripsiSR = ""
                If IsNothing(oFeed.spesial_cmg_option.KodeSD) Then oFeed.spesial_cmg_option.KodeSD = ""
                If IsNothing(oFeed.spesial_cmg_option.KodeSI) Then oFeed.spesial_cmg_option.KodeSI = ""
                If IsNothing(oFeed.spesial_cmg_option.KodeSP) Then oFeed.spesial_cmg_option.KodeSP = ""
                If IsNothing(oFeed.spesial_cmg_option.KodeSR) Then oFeed.spesial_cmg_option.KodeSR = ""
                If IsNothing(oFeed.spesial_cmg_option.TariffSD) Then oFeed.spesial_cmg_option.TariffSD = "0"
                If IsNothing(oFeed.spesial_cmg_option.TariffSI) Then oFeed.spesial_cmg_option.TariffSI = "0"
                If IsNothing(oFeed.spesial_cmg_option.TariffSP) Then oFeed.spesial_cmg_option.TariffSP = "0"
                If IsNothing(oFeed.spesial_cmg_option.TariffSR) Then oFeed.spesial_cmg_option.TariffSR = "0"

                oFeed.TotalTarif = nTotalTarif
            End If
        Else
            oFeed.Metadata.Code = Group1.Metadata.Code
            oFeed.Metadata.Message = Group1.Metadata.Message
            oFeed.Response.CBG.Code = Group1.Response.Cbg.Code
            oFeed.Response.CBG.Description = Group1.Response.Cbg.Description
            oFeed.Response.CBG.Tariff = Group1.Response.Cbg.Tariff
            oFeed.TotalTarif = nTotalTarif
            oFeed.Response.kelas = Group1.Response.kelas
            oFeed.Response.add_payment_amt = Group1.Response.add_payment_amt
            oFeed.Response.InacbgVersion = Group1.Response.InacbgVersion


            If IsNothing(oFeed.spesial_cmg_option.DeskripsiSD) Then oFeed.spesial_cmg_option.DeskripsiSD = ""
            If IsNothing(oFeed.spesial_cmg_option.DeskripsiSI) Then oFeed.spesial_cmg_option.DeskripsiSI = ""
            If IsNothing(oFeed.spesial_cmg_option.DeskripsiSP) Then oFeed.spesial_cmg_option.DeskripsiSP = ""
            If IsNothing(oFeed.spesial_cmg_option.DeskripsiSR) Then oFeed.spesial_cmg_option.DeskripsiSR = ""
            If IsNothing(oFeed.spesial_cmg_option.KodeSD) Then oFeed.spesial_cmg_option.KodeSD = ""
            If IsNothing(oFeed.spesial_cmg_option.KodeSI) Then oFeed.spesial_cmg_option.KodeSI = ""
            If IsNothing(oFeed.spesial_cmg_option.KodeSP) Then oFeed.spesial_cmg_option.KodeSP = ""
            If IsNothing(oFeed.spesial_cmg_option.KodeSR) Then oFeed.spesial_cmg_option.KodeSR = ""
            If IsNothing(oFeed.spesial_cmg_option.TariffSD) Then oFeed.spesial_cmg_option.TariffSD = "0"
            If IsNothing(oFeed.spesial_cmg_option.TariffSI) Then oFeed.spesial_cmg_option.TariffSI = "0"
            If IsNothing(oFeed.spesial_cmg_option.TariffSP) Then oFeed.spesial_cmg_option.TariffSP = "0"
            If IsNothing(oFeed.spesial_cmg_option.TariffSR) Then oFeed.spesial_cmg_option.TariffSR = "0"


        End If

        Final = CBG50Link.KlaimFinal("http://" & sCBGServer & "/eklaim/ws.php", sNoSEP, sNIKCoder, sEncryptionKey)


        Dim oKirimDC As New SendKlaimDC

        oKirimDC = CBG50Link.Send2DataCenterIndividual("http://" & sCBGServer & "/eklaim/ws.php", sNoSEP, sEncryptionKey)
        If oKirimDC.Metadata.Code.Trim <> "200" Then

            Throw New Exception("Pengiriman ke Data Center Kemenkes Gagal, Data belum dapat di klaimkan ke BPJS Kesehatan. Silahkan kirim ke Data Center Kemenkes kemudian.")

        End If

        If oKirimDC.Metadata.Code.Equals("200") Then

        Else
            Throw New Exception("Pengiriman ke Data Center Kemenkes Gagal. Silahkan cek ketersedian jaringan ke http://inacbg.kemkes.go.id. " & vbCrLf & oKirimDC.Metadata.Message)
        End If

        Return oFeed
    End Function


    Public Structure srTarif
        Public iKelompok As Integer
        Public sParameterstring As String
        Public lBiaya As Double
    End Structure


End Class

