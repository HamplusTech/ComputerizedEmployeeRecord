Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class clsConnect
    Public cn As New SqlConnection
    Public ServerDate As DateTime
    Public Sub Connect()
        Try
            cn = New SqlConnection("server=localhost;uid=sa;pwd=hamplustech; database=Computerized_Employee_Record_System")
            If cn.State = Data.ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub DT()
        Try
            Connect()
            Dim cmd = New SqlCommand("select GetDate()", cn)
            ServerDate = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
