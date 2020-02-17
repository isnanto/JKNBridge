Imports Newtonsoft.Json

Public Class TRujukan

    <JsonProperty("noSep")>
    Public Property NoSep As String

    <JsonProperty("tglRujukan")>
    Public Property TglRujukan As String

    <JsonProperty("ppkDirujuk")>
    Public Property PpkDirujuk As String

    <JsonProperty("jnsPelayanan")>
    Public Property JnsPelayanan As String

    <JsonProperty("catatan")>
    Public Property Catatan As String

    <JsonProperty("diagRujukan")>
    Public Property DiagRujukan As String

    <JsonProperty("tipeRujukan")>
    Public Property TipeRujukan As String

    <JsonProperty("poliRujukan")>
    Public Property PoliRujukan As String

    <JsonProperty("user")>
    Public Property User As String
End Class

Public Class Request

    <JsonProperty("t_rujukan")>
    Public Property TRujukan As New TRujukan
End Class

Public Class clsRujukanDto

    <JsonProperty("request")>
    Public Property Request As New Request
End Class