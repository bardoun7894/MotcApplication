<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Note
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

        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.addnoteTb = New System.Windows.Forms.TextBox()
        Me.saveReciepientBtn = New System.Windows.Forms.Button()
        Me.fullnameTB = New System.Windows.Forms.TextBox()
        Me.MRNTb = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MRNlbl = New System.Windows.Forms.Label()
        Me.CoordinatorNameTB = New System.Windows.Forms.TextBox()
        Me.SHONameTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RegistererNameTB = New System.Windows.Forms.TextBox()
        Me.ConsultantNameTB = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.fullnameLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateDT = New System.Windows.Forms.DateTimePicker()
        Me.panel1.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.panel1.Controls.Add(Me.Label3)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1526, 49)
        Me.panel1.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(54, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Note"
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.panel3.Controls.Add(Me.dateDT)
        Me.panel3.Controls.Add(Me.GroupBox5)
        Me.panel3.Controls.Add(Me.saveReciepientBtn)
        Me.panel3.Controls.Add(Me.fullnameTB)
        Me.panel3.Controls.Add(Me.Label4)
        Me.panel3.Controls.Add(Me.MRNTb)
        Me.panel3.Controls.Add(Me.Label15)
        Me.panel3.Controls.Add(Me.MRNlbl)
        Me.panel3.Controls.Add(Me.CoordinatorNameTB)
        Me.panel3.Controls.Add(Me.SHONameTb)
        Me.panel3.Controls.Add(Me.Label2)
        Me.panel3.Controls.Add(Me.Label1)
        Me.panel3.Controls.Add(Me.RegistererNameTB)
        Me.panel3.Controls.Add(Me.ConsultantNameTB)
        Me.panel3.Controls.Add(Me.Label14)
        Me.panel3.Controls.Add(Me.fullnameLabel)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(0, 0)
        Me.panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1526, 810)
        Me.panel3.TabIndex = 16
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.addnoteTb)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(705, 191)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(654, 402)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Add Note"
        '
        'addnoteTb
        '
        Me.addnoteTb.Location = New System.Drawing.Point(30, 43)
        Me.addnoteTb.Multiline = True
        Me.addnoteTb.Name = "addnoteTb"
        Me.addnoteTb.Size = New System.Drawing.Size(580, 328)
        Me.addnoteTb.TabIndex = 1
        '
        'saveReciepientBtn
        '
        Me.saveReciepientBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.saveReciepientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveReciepientBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.saveReciepientBtn.ForeColor = System.Drawing.Color.White
        Me.saveReciepientBtn.Location = New System.Drawing.Point(460, 705)
        Me.saveReciepientBtn.Name = "saveReciepientBtn"
        Me.saveReciepientBtn.Size = New System.Drawing.Size(166, 40)
        Me.saveReciepientBtn.TabIndex = 10
        Me.saveReciepientBtn.Text = "Save"
        Me.saveReciepientBtn.UseVisualStyleBackColor = False
        '
        'fullnameTB
        '
        Me.fullnameTB.Location = New System.Drawing.Point(404, 250)
        Me.fullnameTB.Name = "fullnameTB"
        Me.fullnameTB.Size = New System.Drawing.Size(222, 22)
        Me.fullnameTB.TabIndex = 1
        '
        'MRNTb
        '
        Me.MRNTb.Location = New System.Drawing.Point(404, 327)
        Me.MRNTb.Name = "MRNTb"
        Me.MRNTb.Size = New System.Drawing.Size(222, 22)
        Me.MRNTb.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(239, 248)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 23)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Full Name"
        '
        'MRNlbl
        '
        Me.MRNlbl.AutoSize = True
        Me.MRNlbl.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRNlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MRNlbl.Location = New System.Drawing.Point(239, 325)
        Me.MRNlbl.Name = "MRNlbl"
        Me.MRNlbl.Size = New System.Drawing.Size(112, 23)
        Me.MRNlbl.TabIndex = 0
        Me.MRNlbl.Text = "MRN Patient"
        '
        'CoordinatorNameTB
        '
        Me.CoordinatorNameTB.Location = New System.Drawing.Point(404, 628)
        Me.CoordinatorNameTB.Name = "CoordinatorNameTB"
        Me.CoordinatorNameTB.Size = New System.Drawing.Size(222, 22)
        Me.CoordinatorNameTB.TabIndex = 1
        '
        'SHONameTb
        '
        Me.SHONameTb.Location = New System.Drawing.Point(404, 556)
        Me.SHONameTb.Name = "SHONameTb"
        Me.SHONameTb.Size = New System.Drawing.Size(222, 22)
        Me.SHONameTb.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(239, 626)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Coordinator Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(239, 554)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SHO Name"
        '
        'RegistererNameTB
        '
        Me.RegistererNameTB.Location = New System.Drawing.Point(404, 480)
        Me.RegistererNameTB.Name = "RegistererNameTB"
        Me.RegistererNameTB.Size = New System.Drawing.Size(222, 22)
        Me.RegistererNameTB.TabIndex = 1
        '
        'ConsultantNameTB
        '
        Me.ConsultantNameTB.Location = New System.Drawing.Point(404, 394)
        Me.ConsultantNameTB.Name = "ConsultantNameTB"
        Me.ConsultantNameTB.Size = New System.Drawing.Size(222, 22)
        Me.ConsultantNameTB.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(239, 480)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 23)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "RegistererName"
        '
        'fullnameLabel
        '
        Me.fullnameLabel.AutoSize = True
        Me.fullnameLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.fullnameLabel.Location = New System.Drawing.Point(239, 394)
        Me.fullnameLabel.Name = "fullnameLabel"
        Me.fullnameLabel.Size = New System.Drawing.Size(148, 23)
        Me.fullnameLabel.TabIndex = 0
        Me.fullnameLabel.Text = "Consultant Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(239, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "DATE"
        '
        'dateDT
        '
        Me.dateDT.Location = New System.Drawing.Point(404, 188)
        Me.dateDT.Name = "dateDT"
        Me.dateDT.Size = New System.Drawing.Size(222, 22)
        Me.dateDT.TabIndex = 6
        '
        'Note
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1526, 810)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Note"
        Me.Text = "Note"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As Panel
    Friend WithEvents Label3 As Label
    Private WithEvents panel3 As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents addnoteTb As TextBox
    Friend WithEvents saveReciepientBtn As Button
    Friend WithEvents fullnameTB As TextBox
    Friend WithEvents MRNTb As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents MRNlbl As Label
    Friend WithEvents CoordinatorNameTB As TextBox
    Friend WithEvents SHONameTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RegistererNameTB As TextBox
    Friend WithEvents ConsultantNameTB As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents fullnameLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dateDT As DateTimePicker
End Class
