Imports Newtonsoft.Json

Public Class MetaData

    <JsonProperty("code")>
    Public Property Code As String

    <JsonProperty("message")>
    Public Property Message As String
End Class

Public Class Cob

    <JsonProperty("nmAsuransi")>
    Public Property NmAsuransi As Object

    <JsonProperty("noAsuransi")>
    Public Property NoAsuransi As Object

    <JsonProperty("tglTAT")>
    Public Property TglTAT As Object

    <JsonProperty("tglTMT")>
    Public Property TglTMT As Object
End Class

Public Class HakKelas

    <JsonProperty("keterangan")>
    Public Property Keterangan As String

    <JsonProperty("kode")>
    Public Property Kode As String
End Class

Public Class Informasi

    <JsonProperty("dinsos")>
    Public Property Dinsos As Object

    <JsonProperty("noSKTM")>
    Public Property NoSKTM As Object

    <JsonProperty("prolanisPRB")>
    Public Property ProlanisPRB As Object
End Class

Public Class JenisPeserta

    <JsonProperty("keterangan")>
    Public Property Keterangan As String

    <JsonProperty("kode")>
    Public Property Kode As String
End Class

Public Class Mr

    <JsonProperty("noMR")>
    Public Property NoMR As Object

    <JsonProperty("noTelepon")>
    Public Property NoTelepon As Object
End Class

Public Class ProvUmum

    <JsonProperty("kdProvider")>
    Public Property KdProvider As String

    <JsonProperty("nmProvider")>
    Public Property NmProvider As String
End Class

Public Class StatusPeserta

    <JsonProperty("keterangan")>
    Public Property Keterangan As String

    <JsonProperty("kode")>
    Public Property Kode As String
End Class

Public Class Umur

    <JsonProperty("umurSaatPelayanan")>
    Public Property UmurSaatPelayanan As String

    <JsonProperty("umurSekarang")>
    Public Property UmurSekarang As String
End Class

Public Class PesertaSEPResponse

    <JsonProperty("cob")>
    Public Property Cob As Cob

    <JsonProperty("hakKelas")>
    Public Property HakKelas As HakKelas

    <JsonProperty("informasi")>
    Public Property Informasi As Informasi

    <JsonProperty("jenisPeserta")>
    Public Property JenisPeserta As JenisPeserta

    <JsonProperty("mr")>
    Public Property Mr As Mr

    <JsonProperty("nama")>
    Public Property Nama As String

    <JsonProperty("nik")>
    Public Property Nik As String

    <JsonProperty("noKartu")>
    Public Property NoKartu As String

    <JsonProperty("pisa")>
    Public Property Pisa As String

    <JsonProperty("provUmum")>
    Public Property ProvUmum As ProvUmum

    <JsonProperty("sex")>
    Public Property Sex As String

    <JsonProperty("statusPeserta")>
    Public Property StatusPeserta As StatusPeserta

    <JsonProperty("tglCetakKartu")>
    Public Property TglCetakKartu As String

    <JsonProperty("tglLahir")>
    Public Property TglLahir As String

    <JsonProperty("tglTAT")>
    Public Property TglTAT As String

    <JsonProperty("tglTMT")>
    Public Property TglTMT As String

    <JsonProperty("umur")>
    Public Property Umur As Umur
End Class

Public Class Response

    <JsonProperty("peserta")>
    Public Property Peserta As PesertaSEPResponse
End Class

Public Class clsPesertaResponse

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As Response
End Class
