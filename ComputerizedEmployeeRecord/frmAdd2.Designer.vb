<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdd2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnUpload = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.cboSCR = New System.Windows.Forms.ComboBox
        Me.cboSUB = New System.Windows.Forms.ComboBox
        Me.cboSUD = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSB = New System.Windows.Forms.TextBox
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(241, 82)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 17)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "SysID"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ComputerizedEmployeeRecord.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(413, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Label1"
        '
        'btnUpload
        '
        Me.btnUpload.Image = Global.ComputerizedEmployeeRecord.My.Resources.Resources.add
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpload.Location = New System.Drawing.Point(114, 82)
        Me.btnUpload.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(105, 30)
        Me.btnUpload.TabIndex = 54
        Me.btnUpload.Text = "ADD Pic"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.ComputerizedEmployeeRecord.My.Resources.Resources.NNPC
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox1.Controls.Add(Me.cboSCR)
        Me.GroupBox1.Controls.Add(Me.cboSUB)
        Me.GroupBox1.Controls.Add(Me.cboSUD)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSB)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(0, 219)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 377)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.ComputerizedEmployeeRecord.My.Resources.Resources.add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(312, 340)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 30)
        Me.btnAdd.TabIndex = 70
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(172, 287)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(140, 22)
        Me.DateTimePicker2.TabIndex = 69
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(172, 253)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 22)
        Me.DateTimePicker1.TabIndex = 68
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Bachelor Degree", "Doctorate's Degree", "HND", "Leaving School Cert.", "Masters Degree", "OND", "Post Doctorate", "School Cert"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(172, 200)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 38)
        Me.CheckedListBox1.Sorted = True
        Me.CheckedListBox1.TabIndex = 67
        '
        'cboSCR
        '
        Me.cboSCR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSCR.FormattingEnabled = True
        Me.cboSCR.Items.AddRange(New Object() {"Christianity", "Islam", "Free thinker", "African Traditional"})
        Me.cboSCR.Location = New System.Drawing.Point(172, 22)
        Me.cboSCR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSCR.Name = "cboSCR"
        Me.cboSCR.Size = New System.Drawing.Size(140, 25)
        Me.cboSCR.TabIndex = 66
        '
        'cboSUB
        '
        Me.cboSUB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSUB.FormattingEnabled = True
        Me.cboSUB.Items.AddRange(New Object() {"Married", "Single", "Divorced", "Single Parent", "Widow", "Widower"})
        Me.cboSUB.Location = New System.Drawing.Point(172, 130)
        Me.cboSUB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSUB.Name = "cboSUB"
        Me.cboSUB.Size = New System.Drawing.Size(140, 25)
        Me.cboSUB.TabIndex = 65
        '
        'cboSUD
        '
        Me.cboSUD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSUD.FormattingEnabled = True
        Me.cboSUD.Items.AddRange(New Object() {"Christianity", "Islam", "Free thinker", "African Traditional"})
        Me.cboSUD.Location = New System.Drawing.Point(172, 93)
        Me.cboSUD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboSUD.Name = "cboSUD"
        Me.cboSUD.Size = New System.Drawing.Size(140, 25)
        Me.cboSUD.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Subsidiary"
        '
        'txtSB
        '
        Me.txtSB.Location = New System.Drawing.Point(172, 54)
        Me.txtSB.Multiline = True
        Me.txtSB.Name = "txtSB"
        Me.txtSB.Size = New System.Drawing.Size(140, 34)
        Me.txtSB.TabIndex = 62
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(172, 174)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(64, 22)
        Me.NumericUpDown1.TabIndex = 61
        Me.NumericUpDown1.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 292)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(97, 17)
        Me.Label21.TabIndex = 60
        Me.Label21.Text = "Date Confirmed"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 258)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(155, 17)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Date of First Appiontment"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 219)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(145, 17)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "Acedemic Qualifications"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 174)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 17)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Staff Grade Level"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 93)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 17)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "Staff Unit and Dept"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 17)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Staff Branch"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 17)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Staff Cadre/Rank"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnClear
        '
        Me.btnClear.Image = Global.ComputerizedEmployeeRecord.My.Resources.Resources.arrow_rotate_clockwise
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.Location = New System.Drawing.Point(61, 340)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 30)
        Me.btnClear.TabIndex = 57
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.ComputerizedEmployeeRecord.My.Resources.Resources.closelabel
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.Location = New System.Drawing.Point(191, 340)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 56
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAdd2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ComputerizedEmployeeRecord.My.Resources.Resources.NNPC
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(411, 608)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label14)
        Me.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdd2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff e-File .:: Add Employee Record 2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents cboSCR As System.Windows.Forms.ComboBox
    Friend WithEvents cboSUB As System.Windows.Forms.ComboBox
    Friend WithEvents cboSUD As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSB As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
