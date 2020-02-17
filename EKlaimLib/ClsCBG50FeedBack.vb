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

Public Class clsCBG50FeedBack

        Public Property Metadata As New CBGMetadata
        Public Property Response As New CBG5Response
        Public Property spesial_cmg_option As New SpecialCMGProperty
        Public Property Tarif_alt As TarifAlt()
        Public Property TotalTarif As Double = 0



    End Class

    Public Class CBG5Response
        Public Property CBG As New CBGProperty
        Public Property SubAcute As New SubAcute
        Public Property Chronic As New Chronic
        Public Property kelas As String
        Public Property add_payment_amt As String
        Public Property InacbgVersion As String

    End Class

    Public Class MetaFeedCBG
        Public Code As String
        Public Message As String
    End Class

    Public Class CBGProperty
        Public Property Code As String
        Public Property Description As String
        Public Property Tariff As String
    End Class

    Public Class SpecialCMGProperty

        'Spesial Prosedur
        Public Property KodeSP As String
        Public Property DeskripsiSP As String
        Public Property TariffSP As String
        Public Property TypeSP As String

        'Spesial Protesa
        Public Property KodeSR As String
        Public Property DeskripsiSR As String
        Public Property TariffSR As String
        Public Property TypeSR As String

        'Spesial Investigation
        Public Property KodeSI As String
        Public Property DeskripsiSI As String
        Public Property TariffSI As String
        Public Property TypeSI As String

        'Spesial Drug
        Public Property KodeSD As String
        Public Property DeskripsiSD As String
        Public Property TariffSD As String
        Public Property TypeSD As String

    End Class

