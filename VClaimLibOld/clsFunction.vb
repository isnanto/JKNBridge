Imports System.Data
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Text

Public Class clsFunction
    Public Shared Function ConvertToTimeStamp(ByVal value As DateTime) As Long
        Dim time As DateTime = DateTime.SpecifyKind(New DateTime(&H7B2, 1, 1), DateTimeKind.Utc)
        Dim span As TimeSpan = (value.ToUniversalTime - time)  'DirectCast((value.ToUniversalTime - time), TimeSpan)
        Return CLng(Math.Floor(span.TotalSeconds))
    End Function

    Public Shared Function GenerateSignature(ByVal sConsumerId As String, ByVal sPassword As String, ByVal sTimeStamp As String) As String
        Dim encoding As New ASCIIEncoding
        Dim bytes As Byte() = encoding.GetBytes(sPassword)
        Dim s As String = (sConsumerId & "&" & sTimeStamp)
        Dim buffer As Byte() = encoding.GetBytes(s)
        Using hmacsha As HMACSHA256 = New HMACSHA256(bytes)
            Return Convert.ToBase64String(hmacsha.ComputeHash(buffer))
        End Using
    End Function

    Public Shared Function ToDataTable(Of T)(ByVal items As List(Of T)) As DataTable
        Dim table As New DataTable(GetType(T).Name)
        Dim properties As PropertyInfo() = GetType(T).GetProperties((BindingFlags.Public Or BindingFlags.Instance))
        Dim info As PropertyInfo
        For Each info In properties
            table.Columns.Add(info.Name)
        Next
        Dim local As T
        For Each local In items
            Dim values As Object() = New Object(properties.Length - 1) {}
            Dim i As Integer
            For i = 0 To properties.Length - 1
                values(i) = properties(i).GetValue(local, Nothing)
            Next i
            table.Rows.Add(values)
        Next
        Return table
    End Function

End Class
