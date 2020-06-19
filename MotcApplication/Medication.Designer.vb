<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medication))
        Me.saveReciepientBtn = New System.Windows.Forms.Button()
        Me.BloodGroupLbl = New System.Windows.Forms.Label()
        Me.MRNTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FullNameTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.addToListBtn = New System.Windows.Forms.Button()
        Me.routeTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.drugTB = New System.Windows.Forms.TextBox()
        Me.doClinicDT = New System.Windows.Forms.DateTimePicker()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'saveReciepientBtn
        '
        Me.saveReciepientBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.saveReciepientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveReciepientBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.saveReciepientBtn.ForeColor = System.Drawing.Color.White
        Me.saveReciepientBtn.Location = New System.Drawing.Point(317, 605)
        Me.saveReciepientBtn.Name = "saveReciepientBtn"
        Me.saveReciepientBtn.Size = New System.Drawing.Size(166, 40)
        Me.saveReciepientBtn.TabIndex = 41
        Me.saveReciepientBtn.Text = "Save"
        Me.saveReciepientBtn.UseVisualStyleBackColor = False
        '
        'BloodGroupLbl
        '
        Me.BloodGroupLbl.AutoSize = True
        Me.BloodGroupLbl.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodGroupLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BloodGroupLbl.Location = New System.Drawing.Point(135, 385)
        Me.BloodGroupLbl.Name = "BloodGroupLbl"
        Me.BloodGroupLbl.Size = New System.Drawing.Size(122, 23)
        Me.BloodGroupLbl.TabIndex = 25
        Me.BloodGroupLbl.Text = "Date Of Clinic"
        '
        'MRNTB
        '
        Me.MRNTB.Location = New System.Drawing.Point(283, 315)
        Me.MRNTB.Name = "MRNTB"
        Me.MRNTB.Size = New System.Drawing.Size(271, 22)
        Me.MRNTB.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(135, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 23)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "MRN Patient"
        '
        'FullNameTB
        '
        Me.FullNameTB.Location = New System.Drawing.Point(283, 256)
        Me.FullNameTB.Name = "FullNameTB"
        Me.FullNameTB.Size = New System.Drawing.Size(271, 22)
        Me.FullNameTB.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(135, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Full Name"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(1535, 15)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(28, 27)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.Label3)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1508, 49)
        Me.panel1.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(54, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Medication"
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.panel3.Controls.Add(Me.GroupBox4)
        Me.panel3.Controls.Add(Me.doClinicDT)
        Me.panel3.Controls.Add(Me.saveReciepientBtn)
        Me.panel3.Controls.Add(Me.BloodGroupLbl)
        Me.panel3.Controls.Add(Me.MRNTB)
        Me.panel3.Controls.Add(Me.Label7)
        Me.panel3.Controls.Add(Me.FullNameTB)
        Me.panel3.Controls.Add(Me.Label5)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(0, 0)
        Me.panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1508, 749)
        Me.panel3.TabIndex = 22
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(615, 65)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(795, 647)
        Me.GroupBox4.TabIndex = 43
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ListView1)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(40, 284)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(708, 323)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "list"
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(48, 37)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(552, 261)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.addToListBtn)
        Me.GroupBox6.Controls.Add(Me.routeTB)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.drugTB)
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox6.Location = New System.Drawing.Point(40, 60)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(639, 195)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "add medication"
        '
        'addToListBtn
        '
        Me.addToListBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.addToListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addToListBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.addToListBtn.ForeColor = System.Drawing.Color.White
        Me.addToListBtn.Location = New System.Drawing.Point(415, 131)
        Me.addToListBtn.Name = "addToListBtn"
        Me.addToListBtn.Size = New System.Drawing.Size(166, 40)
        Me.addToListBtn.TabIndex = 42
        Me.addToListBtn.Text = "ADD"
        Me.addToListBtn.UseVisualStyleBackColor = False
        '
        'routeTB
        '
        Me.routeTB.Location = New System.Drawing.Point(150, 95)
        Me.routeTB.Name = "routeTB"
        Me.routeTB.Size = New System.Drawing.Size(441, 30)
        Me.routeTB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(22, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Dose"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(22, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Medication "
        '
        'drugTB
        '
        Me.drugTB.Location = New System.Drawing.Point(150, 44)
        Me.drugTB.Name = "drugTB"
        Me.drugTB.Size = New System.Drawing.Size(190, 30)
        Me.drugTB.TabIndex = 29
        '
        'doClinicDT
        '
        Me.doClinicDT.Location = New System.Drawing.Point(283, 386)
        Me.doClinicDT.Name = "doClinicDT"
        Me.doClinicDT.Size = New System.Drawing.Size(271, 22)
        Me.doClinicDT.TabIndex = 42
        '
        'Medication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1508, 749)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Medication"
        Me.Text = "Medication"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents saveReciepientBtn As Button
    Friend WithEvents BloodGroupLbl As Label
    Friend WithEvents MRNTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FullNameTB As TextBox
    Friend WithEvents Label5 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents panel1 As Panel
    Friend WithEvents Label3 As Label
    Private WithEvents panel3 As Panel
    Friend WithEvents doClinicDT As DateTimePicker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents routeTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents drugTB As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents addToListBtn As Button
End Class
