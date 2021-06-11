Imports System.Data.SqlClient
Public Class frmAdd2

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        With OpenFileDialog1
            .Filter = "All Images |*.jpg;*.gif;*.bmp;*.png"
            .FileName = ""
            .Title = "Blinks Digital Diary | Select Picture"
        End With
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.ToString <> "" Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName.ToString
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub frmAdd2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = frmAdd.Label14.Text
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSB.Text = ""
        cboSCR.Text = ""
        cboSUB.Text = ""
        cboSUD.Text = ""
        DateTimePicker1.Value = Today.Date
        DateTimePicker2.Value = Now.Date
        NumericUpDown1.Value = 4
        GroupBox1.Enabled = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim hampo, johnpaul As New clsConnect
            hampo.Connect()
            johnpaul.DT()
            Dim hamplus As New SqlCommand
            hamplus.Connection = hampo.cn
            hamplus.CommandText = "insert into tblStaffData2 (SysID,StaffCadre,StaffBranch,StaffUnit,Subsi,StaffGL,Acadmic,DOFA,DateComfirmed,pic,dt)" _
            & "values (@sys,@staff,@s,@o,@sex,@dob,@State,@nat,@rel,@pic,@dt)"
            hamplus.Parameters.AddWithValue("@sys", frmAdd.Label14.Text)
            hamplus.Parameters.AddWithValue("@staff", cboSCR.Text)
            hamplus.Parameters.AddWithValue("@s", txtSB.Text)
            hamplus.Parameters.AddWithValue("@o", cboSUD.Text)
            hamplus.Parameters.AddWithValue("@sex", cboSUB.Text)
            hamplus.Parameters.AddWithValue("@dob", NumericUpDown1.Value)
            hamplus.Parameters.AddWithValue("@state", CheckedListBox1.CheckedItems.ToString)
            hamplus.Parameters.AddWithValue("@nat", DateTimePicker1.Text)
            hamplus.Parameters.AddWithValue("@rel", DateTimePicker2.Text)
            hamplus.Parameters.AddWithValue("@pic", OpenFileDialog1.FileName)
            hamplus.Parameters.AddWithValue("@dt", johnpaul.ServerDate)
            hamplus.ExecuteNonQuery()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class