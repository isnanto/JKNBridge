Imports Newtonsoft.Json

Public Class RefDiagnosaResponse

    <JsonProperty("diagnosa")>
    Public Property Diagnosa As Diagnosa()
End Class

Public Class clsReferensiPropinsi
    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As refWilayahResponse
End Class

Public Class clsReferensiKabupaten

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As refWilayahResponse
End Class

Public Class clsReferensiKecamatan

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As refWilayahResponse
End Class

Public Class clsRefDokterDPJP

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As RefDokterDPJPResponse
End Class

Public Class clsRefDiagnosa

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As RefDiagnosaResponse
End Class

Public Class clsReferensiFaskes

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As RefFaskesResponse
End Class

Public Class clsRefPoli
    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As RefPoliResponse
End Class

Public Class refWilayahResponse

    <JsonProperty("list")>
    Public Property List As refPoli()
End Class

Public Class RefPoliResponse

    <JsonProperty("poli")>
    Public Property Poli As refPoli()
End Class

Public Class RefDokterDPJPResponse
    <JsonProperty("list")>
    Public Property List As refPoli()
End Class


Public Class refPoli

    <JsonProperty("kode")>
    Public Property Kode As String

    <JsonProperty("nama")>
    Public Property Nama As String
End Class

Public Class RefFaskesResponse

    <JsonProperty("faskes")>
    Public Property Faskes As refPoli()
End Class
