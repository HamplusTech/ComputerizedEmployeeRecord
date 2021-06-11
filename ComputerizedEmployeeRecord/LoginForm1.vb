Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "Aghahowa" And PasswordTextBox.Text = "joy" Then
            frmMain.Show()
            Me.Hide()
        Else
            Me.Hide()
            Dim b = MsgBox("Invalid Password", MsgBoxStyle.OkOnly, Title:="Computerized Employee Record System")
            If b = MsgBoxResult.Ok Then
                Me.Show()
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Dim a = MsgBox("Exit Application?", MsgBoxStyle.YesNo, Title:="Computerized Employee Record System")
        If a = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            Me.Show()
        End If
    End Sub

End Class
