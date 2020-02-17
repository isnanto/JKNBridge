Imports Newtonsoft.Json

Public Class clsMonitorKunjungan

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As KunjunganResponse
End Class

Public Class clsMonitoringDataKlaim

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As ResponseDataKlaim
End Class

Public Class clsMonitoringHistoriPelayanan

    <JsonProperty("metaData")>
    Public Property MetaData As MetaData

    <JsonProperty("response")>
    Public Property Response As HistoriResponse
End Class

Public Class HistoriResponse

    <JsonProperty("histori")>
    Public Property Histori As Histori()
End Class

Public Class Histori

    <JsonProperty("diagnosa")>
    Public Property Diagnosa As String

    <JsonProperty("jnsPelayanan")>
    Public Property JnsPelayanan As String

    <JsonProperty("kelasRawat")>
    Public Property KelasRawat As String

    <JsonProperty("namaPeserta")>
    Public Property NamaPeserta As String

    <JsonProperty("noKartu")>
    Public Property NoKartu As String

    <JsonProperty("noSep")>
    Public Property NoSep As String

    <JsonProperty("poli")>
    Public Property Poli As String

    <JsonProperty("ppkPelayanan")>
    Public Property PpkPelayanan As String

    <JsonProperty("tglPlgSep")>
    Public Property TglPlgSep As String

    <JsonProperty("tglSep")>
    Public Property TglSep As String
End Class

Public Class SepKunjungan

    <JsonProperty("diagnosa")>
    Public Property Diagnosa As String

    <JsonProperty("jnsPelayanan")>
    Public Property JnsPelayanan As String

    <JsonProperty("kelasRawat")>
    Public Property KelasRawat As String

    <JsonProperty("nama")>
    Public Property Nama As String

    <JsonProperty("noKartu")>
    Public Property NoKartu As String

    <JsonProperty("noSep")>
    Public Property NoSep As String

    <JsonProperty("poli")>
    Public Property Poli As Object

    <JsonProperty("tglPlgSep")>
    Public Property TglPlgSep As String

    <JsonProperty("tglSep")>
    Public Property TglSep As String
End Class

Public Class KunjunganResponse

    <JsonProperty("sep")>
    Public Property Sep As SepKunjungan()
End Class

Public Class ResponseDataKlaim

    <JsonProperty("klaim")>
    Public Property Klaim As ItemKlaim()
End Class

Public Class ItemKlaim

    <JsonProperty("Inacbg")>
    Public Property Inacbg As Inacbg

    <JsonProperty("biaya")>
    Public Property Biaya As Biaya

    <JsonProperty("kelasRawat")>
    Public Property KelasRawat As String

    <JsonProperty("noFPK")>
    Public Property NoFPK As String

    <JsonProperty("noSEP")>
    Public Property NoSEP As String

    <JsonProperty("peserta")>
    Public Property Peserta As PesertaMonitoring

    <JsonProperty("poli")>
    Public Property Poli As String

    <JsonProperty("status")>
    Public Property Status As String

    <JsonProperty("tglPulang")>
    Public Property TglPulang As String

    <JsonProperty("tglSep")>
    Public Property TglSep As String
End Class

Public Class PesertaMonitoring

    <JsonProperty("nama")>
    Public Property Nama As String

    <JsonProperty("noKartu")>
    Public Property NoKartu As String

    <JsonProperty("noMR")>
    Public Property NoMR As String
End Class

Public Class Inacbg

    <JsonProperty("kode")>
    Public Property Kode As String

    <JsonProperty("nama")>
    Public Property Nama As String
End Class

Public Class Biaya

    <JsonProperty("byPengajuan")>
    Public Property ByPengajuan As String

    <JsonProperty("bySetujui")>
    Public Property BySetujui As String

    <JsonProperty("byTarifGruper")>
    Public Property ByTarifGruper As String

    <JsonProperty("byTarifRS")>
    Public Property ByTarifRS As String

    <JsonProperty("byTopup")>
    Public Property ByTopup As String
End Class

