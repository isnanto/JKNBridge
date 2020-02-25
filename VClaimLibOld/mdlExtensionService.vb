Module mdlExtensionService
    <System.Runtime.CompilerServices.Extension()>
    Public Function Left(ByVal str As String, ByVal length As Integer) As String
        Return str.Substring(0, Math.Min(str.Length, length))
    End Function

    <System.Runtime.CompilerServices.Extension()>
    Public Function Right(ByVal str As String, ByVal length As Integer) As String
        Return str.Substring(Math.Min(str.Length, length), length)
    End Function
End Module
