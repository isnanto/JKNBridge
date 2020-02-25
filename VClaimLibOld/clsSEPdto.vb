Imports Newtonsoft.Json

Public Class AsalRujukanSEP

        <JsonProperty("asalRujukan")>
        Public Property AsalRujukan As String

        <JsonProperty("tglRujukan")>
        Public Property TglRujukan As String

        <JsonProperty("noRujukan")>
        Public Property NoRujukan As String

        <JsonProperty("ppkRujukan")>
        Public Property PpkRujukan As String
    End Class

Public Class RequestSEP

    <JsonProperty("t_sep")>
    Public Property TSep As TSep
End Class

Public Class clsSEPdto

    <JsonProperty("request")>
    Public Property Request As RequestSEP
End Class

Public Class TSep

    <JsonProperty("noKartu")>
    Public Property NoKartu As String

    <JsonProperty("tglSep")>
    Public Property TglSep As String

    <JsonProperty("ppkPelayanan")>
    Public Property PpkPelayanan As String

    <JsonProperty("jnsPelayanan")>
    Public Property JnsPelayanan As String

    <JsonProperty("klsRawat")>
    Public Property KlsRawat As String

    <JsonProperty("noMR")>
    Public Property NoMR As String

    <JsonProperty("rujukan")>
    Public Property Rujukan As AsalRujukanSEP

    <JsonProperty("catatan")>
    Public Property Catatan As String

    <JsonProperty("diagAwal")>
    Public Property DiagAwal As String

    <JsonProperty("poli")>
    Public Property Poli As PoliSEP

    <JsonProperty("cob")>
    Public Property Cob As CobSEP

    <JsonProperty("Katarak")>
    Public Property Katarak As KatarakSEP

    <JsonProperty("jaminan")>
    Public Property Jaminan As Jaminan

    <JsonProperty("SKDP")>
    Public Property SKDP As SKDP

    <JsonProperty("noTelp")>
    Public Property NoTelp As String

    <JsonProperty("user")>
    Public Property User As String
End Class

Public Class Jaminan

    <JsonProperty("lakaLantas")>
    Public Property LakaLantas As String

    <JsonProperty("penjamin")>
    Public Property Penjamin As DetailPenjamin

End Class

Public Class DetailPenjamin
    <JsonProperty("Penjamin")>
    Public Property Penjamin As String

    <JsonProperty("tglKejadian")>
    Public Property tglKejadian As String

    <JsonProperty("Keterangan")>
    Public Property Keterangan As String

    <JsonProperty("Suplesi")>
    Public Property Suplesi As DetailSuplesi
End Class

Public Class DetailSuplesi
    <JsonProperty("Suplesi")>
    Public Property Suplesi As String

    <JsonProperty("noSuplesi")>
    Public Property noSuplesi As String

    <JsonProperty("LokasiLaka")>
    Public Property LokasiLaka As DetailLokasiLaka

End Class

Public Class DetailLokasiLaka
    <JsonProperty("kodeProvinsi")>
    Public Property kodeProvinsi As String

    <JsonProperty("kodeKabupaten")>
    Public Property kodeKabupaten As String

    <JsonProperty("kdKecamatan")>
    Public Property kdKecamatan As String
End Class
Public Class PoliSEP

    <JsonProperty("tujuan")>
    Public Property Tujuan As String

    <JsonProperty("eksekutif")>
    Public Property Eksekutif As String
End Class

Public Class CobSEP
    <JsonProperty("cob")>
    Public Property Cob As String
End Class

Public Class KatarakSEP
    <JsonProperty("KatarakSEP")>
    Public Property Katarak As String
End Class

Public Class SKDP
    <JsonProperty("NoSurat")>
    Public Property NoSurat As String

    <JsonProperty("KodeDPJP")>
    Public Property KodeDPJP As String
End Class