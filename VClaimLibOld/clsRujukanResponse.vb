
Imports Newtonsoft.Json

Public Class PesertaRujuk

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
    Public Property Nik As Object

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

Public Class Diagnosa

    <JsonProperty("kode")>
    Public Property Kode As String

    <JsonProperty("nama")>
    Public Property Nama As String
End Class

Public Class Pelayanan

    <JsonProperty("kode")>
    Public Property Kode As String

    <JsonProperty("nama")>
    Public Property Nama As String
End Class

Public Class PoliRujukan

    <JsonProperty("kode")>
    Public Property Kode As String

    <JsonProperty("nama")>
    Public Property Nama As String
End Class

Public Class ProvPerujuk

    <JsonProperty("kode")>
    Public Property Kode As String

    <JsonProperty("nama")>
    Public Property Nama As String
End Class

Public Class RujukanProperty

    <JsonProperty("diagnosa")>
    Public Property Diagnosa As Diagnosa

    <JsonProperty("keluhan")>
    Public Property Keluhan As String

    <JsonProperty("noKunjungan")>
    Public Property NoKunjungan As String

    <JsonProperty("pelayanan")>
    Public Property Pelayanan As Pelayanan

    <JsonProperty("peserta")>
    Public Property Peserta As PesertaRujuk

    <JsonProperty("poliRujukan")>
    Public Property PoliRujukan As PoliRujukan

    <JsonProperty("provPerujuk")>
    Public Property ProvPerujuk As ProvPerujuk

    <JsonProperty("tglKunjungan")>
    Public Property TglKunjungan As String
End Class

Public Class ResponseCariRujukan

    <JsonProperty("rujukan")>
    Public Property Rujukan As RujukanProperty
End Class

Public Class clsRujukanResponse

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As ResponseCariRujukan
End Class
Public Class clsRujukanMultiRecord

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As ResponseCariRujukanMulti
End Class

Public Class ResponseCariRujukanMulti

    <JsonProperty("rujukan")>
    Public Property Rujukan As RujukanProperty()
End Class

Public Class AsalRujukan

    <JsonProperty("kode")>
    Public Property Kode As String

    <JsonProperty("nama")>
    Public Property Nama As String
End Class


Public Class PoliTujuan

    <JsonProperty("kode")>
    Public Property Kode As String

    <JsonProperty("nama")>
    Public Property Nama As String
End Class

Public Class TujuanRujukan

    <JsonProperty("kode")>
    Public Property Kode As String

    <JsonProperty("nama")>
    Public Property Nama As String
End Class

Public Class InsertRujukan

    <JsonProperty("AsalRujukan")>
    Public Property AsalRujukan As AsalRujukan

    <JsonProperty("diagnosa")>
    Public Property Diagnosa As Diagnosa

    <JsonProperty("noRujukan")>
    Public Property NoRujukan As String

    <JsonProperty("peserta")>
    Public Property Peserta As PesertaProperty

    <JsonProperty("poliTujuan")>
    Public Property PoliTujuan As PoliTujuan

    <JsonProperty("tglRujukan")>
    Public Property TglRujukan As String

    <JsonProperty("tujuanRujukan")>
    Public Property TujuanRujukan As TujuanRujukan
End Class

Public Class DetailDataRujuk

    <JsonProperty("rujukan")>
    Public Property Rujukan As InsertRujukan
End Class

Public Class clsInsertRujukan
    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As DetailDataRujuk
End Class

Public Class clsUpdateDeleteRujukanResponse

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As String
End Class

