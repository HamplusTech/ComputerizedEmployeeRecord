<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdd))
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtStaffID = New System.Windows.Forms.TextBox
        Me.txtSN = New System.Windows.Forms.TextBox
        Me.txtON = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtNationality = New System.Windows.Forms.TextBox
        Me.txtRA = New System.Windows.Forms.TextBox
        Me.txtPA = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboSex = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cboReligion = New System.Windows.Forms.ComboBox
        Me.cboMS = New System.Windows.Forms.ComboBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 17)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Staff ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 443)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Marital Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Religion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Nationality"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 34)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "State of Origin (include" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " LGA before State)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Date of Birth"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Sex"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Othernames"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Surname"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 520)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Resident address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 578)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Permanent Address"
        '
        'txtStaffID
        '
        Me.txtStaffID.Location = New System.Drawing.Point(196, 131)
        Me.txtStaffID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(140, 22)
        Me.txtStaffID.TabIndex = 27
        '
        'txtSN
        '
        Me.txtSN.Location = New System.Drawing.Point(196, 165)
        Me.txtSN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSN.Name = "txtSN"
        Me.txtSN.Size = New System.Drawing.Size(140, 22)
        Me.txtSN.TabIndex = 28
        '
        'txtON
        '
        Me.txtON.Location = New System.Drawing.Point(196, 197)
        Me.txtON.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtON.Name = "txtON"
        Me.txtON.Size = New System.Drawing.Size(140, 22)
        Me.txtON.TabIndex = 29
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(196, 307)
        Me.txtState.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(140, 22)
        Me.txtState.TabIndex = 30
        '
        'txtNationality
        '
        Me.txtNationality.Location = New System.Drawing.Point(196, 358)
        Me.txtNationality.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New System.Drawing.Size(140, 22)
        Me.txtNationality.TabIndex = 31
        '
        'txtRA
        '
        Me.txtRA.Location = New System.Drawing.Point(196, 517)
        Me.txtRA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRA.Multiline = True
        Me.txtRA.Name = "txtRA"
        Me.txtRA.Size = New System.Drawing.Size(140, 44)
        Me.txtRA.TabIndex = 34
        '
        'txtPA
        '
        Me.txtPA.Location = New System.Drawing.Point(196, 575)
        Me.txtPA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPA.Multiline = True
        Me.txtPA.Name = "txtPA"
        Me.txtPA.Size = New System.Drawing.Size(140, 47)
        Me.txtPA.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 17)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Sys ID"
        '
        'cboSex
        '
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboSex.Location = New System.Drawing.Point(196, 233)
        Me.cboSex.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(140, 25)
        Me.cboSex.TabIndex = 37
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(196, 269)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 22)
        Me.DateTimePicker1.TabIndex = 38
        '
        'cboReligion
        '
        Me.cboReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReligion.FormattingEnabled = True
        Me.cboReligion.Items.AddRange(New Object() {"Christianity", "Islam", "Free thinker", "African Traditional"})
        Me.cboReligion.Location = New System.Drawing.Point(196, 398)
        Me.cboReligion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboReligion.Name = "cboReligion"
        Me.cboReligion.Size = New System.Drawing.Size(140, 25)
        Me.cboReligion.TabIndex = 39
        '
        'cboMS
        '
        Me.cboMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMS.FormattingEnabled = True
        Me.cboMS.Items.AddRange(New Object() {"Married", "Single", "Divorced", "Single Parent", "Widow", "Widower"})
        Me.cboMS.Location = New System.Drawing.Point(196, 443)
        Me.cboMS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboMS.Name = "cboMS"
        Me.cboMS.Size = New System.Drawing.Size(140, 25)
        Me.cboMS.TabIndex = 40
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.ComputerizedEmployeeRecord.My.Resources.Resources.add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(293, 642)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ComputerizedEmployeeRecord.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(384, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 487)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 17)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "E-mail Address"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(196, 487)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(140, 22)
        Me.txtEmail.TabIndex = 43
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(193, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 17)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Label14"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.ComputerizedEmployeeRecord.My.Resources.Resources.closelabel
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(168, 642)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Image = Global.ComputerizedEmployeeRecord.My.Resources.Resources.arrow_rotate_clockwise
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.Location = New System.Drawing.Point(38, 642)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 46
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 622)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 17)
        Me.Label15.TabIndex = 47
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ComputerizedEmployeeRecord.My.Resources.Resources.NNPC
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(385, 676)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cboMS)
        Me.Controls.Add(Me.cboReligion)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cboSex)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPA)
        Me.Controls.Add(Me.txtRA)
        Me.Controls.Add(Me.txtNationality)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtON)
        Me.Controls.Add(Me.txtSN)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff e-File .:: Add Employee Record"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtStaffID As System.Windows.Forms.TextBox
    Friend WithEvents txtSN As System.Windows.Forms.TextBox
    Friend WithEvents txtON As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtNationality As System.Windows.Forms.TextBox
    Friend WithEvents txtRA As System.Windows.Forms.TextBox
    Friend WithEvents txtPA As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboReligion As System.Windows.Forms.ComboBox
    Friend WithEvents cboMS As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
