<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DonorInformation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.donorWeightTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.donorNameTB = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database3DataSet = New MotcApplication.Database3DataSet()
        Me.RecipientinformationtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Recipient_information_tblTableAdapter = New MotcApplication.Database3DataSetTableAdapters.recipient_information_tblTableAdapter()
        Me.PatientMRNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BMIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MELDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OriginalDiseaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfListingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panel1.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecipientinformationtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.panel1.Controls.Add(Me.Label8)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1526, 49)
        Me.panel1.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.2!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(25, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 30)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "get Data"
        '
        'donorWeightTB
        '
        Me.donorWeightTB.Location = New System.Drawing.Point(805, 61)
        Me.donorWeightTB.Name = "donorWeightTB"
        Me.donorWeightTB.Size = New System.Drawing.Size(222, 22)
        Me.donorWeightTB.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(638, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Weight (kgs)"
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.panel3.Controls.Add(Me.TabControl1)
        Me.panel3.Controls.Add(Me.saveBtn)
        Me.panel3.Controls.Add(Me.donorWeightTB)
        Me.panel3.Controls.Add(Me.Label2)
        Me.panel3.Controls.Add(Me.donorNameTB)
        Me.panel3.Controls.Add(Me.Label15)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(0, 0)
        Me.panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1526, 761)
        Me.panel3.TabIndex = 16
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.saveBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.saveBtn.ForeColor = System.Drawing.Color.White
        Me.saveBtn.Location = New System.Drawing.Point(1145, 53)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(166, 40)
        Me.saveBtn.TabIndex = 9
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'donorNameTB
        '
        Me.donorNameTB.Location = New System.Drawing.Point(335, 67)
        Me.donorNameTB.Name = "donorNameTB"
        Me.donorNameTB.Size = New System.Drawing.Size(222, 22)
        Me.donorNameTB.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(134, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 23)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Full Name"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(30, 128)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1484, 599)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1476, 570)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1241, 509)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1241, 509)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientMRNDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.BMIDataGridViewTextBoxColumn, Me.MELDDataGridViewTextBoxColumn, Me.BloodGroupDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.OriginalDiseaseDataGridViewTextBoxColumn, Me.DateOfListingDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RecipientinformationtblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1301, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Database3DataSet
        '
        Me.Database3DataSet.DataSetName = "Database3DataSet"
        Me.Database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecipientinformationtblBindingSource
        '
        Me.RecipientinformationtblBindingSource.DataMember = "recipient_information_tbl"
        Me.RecipientinformationtblBindingSource.DataSource = Me.Database3DataSet
        '
        'Recipient_information_tblTableAdapter
        '
        Me.Recipient_information_tblTableAdapter.ClearBeforeFill = True
        '
        'PatientMRNDataGridViewTextBoxColumn
        '
        Me.PatientMRNDataGridViewTextBoxColumn.DataPropertyName = "Patient MRN"
        Me.PatientMRNDataGridViewTextBoxColumn.HeaderText = "Patient MRN"
        Me.PatientMRNDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientMRNDataGridViewTextBoxColumn.Name = "PatientMRNDataGridViewTextBoxColumn"
        Me.PatientMRNDataGridViewTextBoxColumn.Width = 125
        '
        'PatientNameDataGridViewTextBoxColumn
        '
        Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient Name"
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "Patient Name"
        Me.PatientNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        Me.PatientNameDataGridViewTextBoxColumn.Width = 125
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 125
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        Me.DateOfBirthDataGridViewTextBoxColumn.Width = 125
        '
        'BMIDataGridViewTextBoxColumn
        '
        Me.BMIDataGridViewTextBoxColumn.DataPropertyName = "BMI"
        Me.BMIDataGridViewTextBoxColumn.HeaderText = "BMI"
        Me.BMIDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BMIDataGridViewTextBoxColumn.Name = "BMIDataGridViewTextBoxColumn"
        Me.BMIDataGridViewTextBoxColumn.Width = 125
        '
        'MELDDataGridViewTextBoxColumn
        '
        Me.MELDDataGridViewTextBoxColumn.DataPropertyName = "MELD"
        Me.MELDDataGridViewTextBoxColumn.HeaderText = "MELD"
        Me.MELDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MELDDataGridViewTextBoxColumn.Name = "MELDDataGridViewTextBoxColumn"
        Me.MELDDataGridViewTextBoxColumn.Width = 125
        '
        'BloodGroupDataGridViewTextBoxColumn
        '
        Me.BloodGroupDataGridViewTextBoxColumn.DataPropertyName = "Blood Group"
        Me.BloodGroupDataGridViewTextBoxColumn.HeaderText = "Blood Group"
        Me.BloodGroupDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BloodGroupDataGridViewTextBoxColumn.Name = "BloodGroupDataGridViewTextBoxColumn"
        Me.BloodGroupDataGridViewTextBoxColumn.Width = 125
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.Width = 125
        '
        'OriginalDiseaseDataGridViewTextBoxColumn
        '
        Me.OriginalDiseaseDataGridViewTextBoxColumn.DataPropertyName = "Original Disease"
        Me.OriginalDiseaseDataGridViewTextBoxColumn.HeaderText = "Original Disease"
        Me.OriginalDiseaseDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OriginalDiseaseDataGridViewTextBoxColumn.Name = "OriginalDiseaseDataGridViewTextBoxColumn"
        Me.OriginalDiseaseDataGridViewTextBoxColumn.Width = 125
        '
        'DateOfListingDataGridViewTextBoxColumn
        '
        Me.DateOfListingDataGridViewTextBoxColumn.DataPropertyName = "Date of Listing"
        Me.DateOfListingDataGridViewTextBoxColumn.HeaderText = "Date of Listing"
        Me.DateOfListingDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateOfListingDataGridViewTextBoxColumn.Name = "DateOfListingDataGridViewTextBoxColumn"
        Me.DateOfListingDataGridViewTextBoxColumn.Width = 125
        '
        'DonorInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1526, 761)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DonorInformation"
        Me.ShowIcon = False
        Me.Text = "DonorInformation"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecipientinformationtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As Panel
    Friend WithEvents donorWeightTB As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents panel3 As Panel
    Friend WithEvents donorNameTB As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents saveBtn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Database3DataSet As Database3DataSet
    Friend WithEvents RecipientinformationtblBindingSource As BindingSource
    Friend WithEvents Recipient_information_tblTableAdapter As Database3DataSetTableAdapters.recipient_information_tblTableAdapter
    Friend WithEvents PatientMRNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BMIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MELDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BloodGroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OriginalDiseaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfListingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
