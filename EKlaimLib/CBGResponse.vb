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
Imports Newtonsoft.Json

Public Class KlaimBaru
    <JsonProperty("metadata")>
    Public Property Metadata As CBGMetadata
End Class

Public Class SetKlaimData
    <JsonProperty("metadata")>
    Public Property Metadata As CBGMetadata
End Class

Public Class Grouper1

    <JsonProperty("metadata")>
    Public Metadata As CBGMetadata

    <JsonProperty("response")>
    Public Response As Grouper1Response

    <JsonProperty("special_cmg_option")>
    Public SpecialCmgOption As SpecialCmgOption()

    <JsonProperty("tarif_alt")>
    Public TarifAlt As TarifAlt()
End Class

Public Class Grouper2

    <JsonProperty("metadata")>
    Public Property Metadata As CBGMetadata

    <JsonProperty("response")>
    Public Property Response As Grouper2Response

    <JsonProperty("special_cmg_option")>
    Public Property SpecialCmgOption As SpecialCmgOption()
End Class

Public Class KlaimFinal

    <JsonProperty("metadata")>
    Public Property Metadata As CBGMetadata
End Class

Public Class EditKlaim

    <JsonProperty("metadata")>
    Public Property Metadata As CBGMetadata
End Class

Public Class SendKlaimDC

    <JsonProperty("metadata")>
    Public Property Metadata As CBGMetadata

    <JsonProperty("response")>
    Public Property Response As SendKlaimResponse
End Class

Public Class PullClaimResponse

    <JsonProperty("metadata")>
    Public Property Metadata As CBGMetadata

    <JsonProperty("response")>
    Public Property Response As PullClaimData
End Class

'===============================================================================

Public Class CBGSEP

    <JsonProperty("SEP")>
    Public Property SEP As String

    <JsonProperty("tgl_pulang")>
    Public Property TglPulang As String

    <JsonProperty("KEMENKES_DC_Status")>
    Public Property KEMENKESDCStatus As String

    <JsonProperty("BPJS_DC_Status")>
    Public Property BPJSDCStatus As String
End Class

Public Class SendKlaimResponse

    <JsonProperty("SEP")>
    Public Property SEP As CBGSEP()
End Class

Public Class PullClaimData

    <JsonProperty("Data")>
    Public Property Data As String
End Class
Public Class SpecialCmg

    <JsonProperty("code")>
    Public Property Code As String

    <JsonProperty("description")>
    Public Property Description As String

    <JsonProperty("tariff")>
    Public Property Tariff As Integer

    <JsonProperty("type")>
    Public Property Type As String
End Class

Public Class Grouper2Response

    <JsonProperty("cbg")>
    Public Property Cbg As Cbg

    <JsonProperty("special_cmg")>
    Public Property SpecialCmg As List(Of SpecialCmg)

    <JsonProperty("kelas")>
    Public kelas As String

    <JsonProperty("add_payment_amt")>
    Public add_payment_amt As String

    <JsonProperty("inacbg_version")>
    Public InacbgVersion As String

End Class

Public Class Grouper1Response

    <JsonProperty("cbg")>
    Public Cbg As Cbg

    <JsonProperty("sub_acute")>
    Public SubAcute As SubAcute

    <JsonProperty("chronic")>
    Public Chronic As Chronic

    <JsonProperty("kelas")>
    Public kelas As String

    <JsonProperty("add_payment_amt")>
    Public add_payment_amt As String

    <JsonProperty("inacbg_version")>
    Public InacbgVersion As String
End Class

Public Class SubAcute

    <JsonProperty("code")>
    Public Code As String

    <JsonProperty("description")>
    Public Description As String

    <JsonProperty("tariff")>
    Public Tariff As Integer
End Class

Public Class Chronic

    <JsonProperty("code")>
    Public Code As String

    <JsonProperty("description")>
    Public Description As String

    <JsonProperty("tariff")>
    Public Tariff As Integer
End Class

Public Class SpecialCmgOption

    <JsonProperty("code")>
    Public Property Code As String

    <JsonProperty("description")>
    Public Property Description As String

    <JsonProperty("type")>
    Public Property Type As String
End Class

Public Class CBGMetadata

    <JsonProperty("code")>
    Public Property Code As String

    <JsonProperty("message")>
    Public Property Message As String
End Class

Public Class TarifAlt

    <JsonProperty("kelas")>
    Public Kelas As String

    <JsonProperty("tarif_inacbg")>
    Public TarifInacbg As String
End Class


Public Class Cbg

    <JsonProperty("code")>
    Public Property Code As String

    <JsonProperty("description")>
    Public Property Description As String

    <JsonProperty("tariff")>
    Public Property Tariff As String
End Class


