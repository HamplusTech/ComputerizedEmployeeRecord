Imports System.Data.SqlClient
Public Class frmAdd

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If txtStaffID.Text <> "" Then
                Dim hampo, johnpaul As New clsConnect
                hampo.Connect()
                johnpaul.DT()
                Dim hamplus As New SqlCommand
                hamplus.Connection = hampo.cn
                hamplus.CommandText = "insert into tblStaffData1 (SysID,StaffID,Surname,Othernames,sex,dob,StateLGA,Nationality,Religion,MaritalStatus,EmailAdd,ResidentAdd,PerAdd,dt)" _
                & "values (@sys,@staff,@s,@o,@sex,@dob,@State,@nat,@rel,@ms,@ea,@ra,@pa,@dt)"
                hamplus.Parameters.AddWithValue("@sys", Label14.Text)
                hamplus.Parameters.AddWithValue("@staff", txtStaffID.Text)
                hamplus.Parameters.AddWithValue("@s", txtSN.Text)
                hamplus.Parameters.AddWithValue("@o", txtON.Text)
                hamplus.Parameters.AddWithValue("@sex", cboSex.Text)
                hamplus.Parameters.AddWithValue("@dob", DateTimePicker1.Text)
                hamplus.Parameters.AddWithValue("@state", txtState.Text)
                hamplus.Parameters.AddWithValue("@nat", txtNationality.Text)
                hamplus.Parameters.AddWithValue("@rel", cboReligion.Text)
                hamplus.Parameters.AddWithValue("@ms", cboMS.Text)
                hamplus.Parameters.AddWithValue("@ea", txtEmail.Text)
                hamplus.Parameters.AddWithValue("ra", txtRA.Text)
                hamplus.Parameters.AddWithValue("@pa", txtPA.Text)
                hamplus.Parameters.AddWithValue("@dt", johnpaul.ServerDate)
                hamplus.ExecuteNonQuery()
                Me.Hide()
                frmAdd2.Show()
            Else
                Label15.Text = "Please type Staff ID"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtEmail.Text = ""
        txtNationality.Text = ""
        txtON.Text = ""
        txtPA.Text = ""
        txtRA.Text = ""
        txtSN.Text = ""
        txtStaffID.Text = ""
        txtState.Text = ""
        cboMS.Text = ""
        cboReligion.Text = ""
        cboSex.Text = ""
        DateTimePicker1.Value = Now.Date
    End Sub

    Private Sub frmAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a, b, c As Integer
        a = 2012
        Randomize()
        b = 2 + Rnd(a) * 858
        b = Mid(b, 1, 3)
        c = b
        Label14.Text = "NNPC " + CStr(c)
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub
End Class