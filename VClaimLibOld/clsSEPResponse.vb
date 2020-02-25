Imports Newtonsoft.Json


Public Class ResponseSEP

    <JsonProperty("sep")>
    Public Property Sep As SepProperty
End Class

Public Class clsInsertSEP

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As ResponseSEP
End Class

Public Class SepProperty

    <JsonProperty("catatan")>
    Public Property Catatan As String

    <JsonProperty("diagnosa")>
    Public Property Diagnosa As String

    <JsonProperty("jnsPelayanan")>
    Public Property JnsPelayanan As String

    <JsonProperty("kelasRawat")>
    Public Property KelasRawat As String

    <JsonProperty("noSep")>
    Public Property NoSep As String

    <JsonProperty("penjamin")>
    Public Property Penjamin As String

    <JsonProperty("peserta")>
    Public Property Peserta As PesertaProperty

    <JsonProperty("Informasi")>
    Public Property Informasi As Informasi

    <JsonProperty("poli")>
    Public Property Poli As String

    <JsonProperty("poliEksekutif")>
    Public Property PoliEksekutif As String

    <JsonProperty("tglSep")>
    Public Property TglSep As String
End Class

Public Class PesertaProperty

    <JsonProperty("asuransi")>
    Public Property Asuransi As String

    <JsonProperty("hakKelas")>
    Public Property HakKelas As String

    <JsonProperty("jnsPeserta")>
    Public Property JnsPeserta As String

    <JsonProperty("kelamin")>
    Public Property Kelamin As String

    <JsonProperty("nama")>
    Public Property Nama As String

    <JsonProperty("noKartu")>
    Public Property NoKartu As String

    <JsonProperty("noMr")>
    Public Property NoMr As String

    <JsonProperty("tglLahir")>
    Public Property TglLahir As String
End Class


Public Class clsHapusSEP

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As String
End Class

Public Class clsCariSEP

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As CariSEPResponse
End Class

Public Class CariSEPResponse

    <JsonProperty("catatan")>
    Public Property Catatan As String

    <JsonProperty("diagnosa")>
    Public Property Diagnosa As String

    <JsonProperty("jnsPelayanan")>
    Public Property JnsPelayanan As String

    <JsonProperty("kelasRawat")>
    Public Property KelasRawat As String

    <JsonProperty("noSep")>
    Public Property NoSep As String

    <JsonProperty("noRujukan")>
    Public Property noRujukan As String

    <JsonProperty("penjamin")>
    Public Property Penjamin As Object

    <JsonProperty("peserta")>
    Public Property Peserta As PesertaProperty

    <JsonProperty("poli")>
    Public Property Poli As String

    <JsonProperty("poliEksekutif")>
    Public Property PoliEksekutif As String

    <JsonProperty("tglSep")>
    Public Property TglSep As String
End Class

Public Class clsUpdateTglPulang

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As String
End Class