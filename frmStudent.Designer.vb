<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
        Me.components = New System.ComponentModel.Container()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.bday = New System.Windows.Forms.DateTimePicker()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.EnrollmentDBDataSet = New EnrollTrack.EnrollmentDBDataSet()
        Me.STUDENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STUDENTTableAdapter = New EnrollTrack.EnrollmentDBDataSetTableAdapters.STUDENTTableAdapter()
        Me.ENROLLMENTTableAdapter = New EnrollTrack.EnrollmentDBDataSetTableAdapters.ENROLLMENTTableAdapter()
        Me.STUDENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STUDENTBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FKENROLLMENTSTUDENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.EnrollmentDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKENROLLMENTSTUDENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst.Location = New System.Drawing.Point(136, 143)
        Me.txtFirst.Multiline = True
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(189, 33)
        Me.txtFirst.TabIndex = 1
        Me.txtFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLast
        '
        Me.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast.Location = New System.Drawing.Point(136, 210)
        Me.txtLast.Multiline = True
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(189, 34)
        Me.txtLast.TabIndex = 2
        Me.txtLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(134, 82)
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(191, 33)
        Me.txtId.TabIndex = 3
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbGender
        '
        Me.cmbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cmbGender.Location = New System.Drawing.Point(511, 87)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(121, 28)
        Me.cmbGender.TabIndex = 4
        '
        'bday
        '
        Me.bday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bday.Location = New System.Drawing.Point(511, 152)
        Me.bday.Name = "bday"
        Me.bday.Size = New System.Drawing.Size(317, 26)
        Me.bday.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(136, 283)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(189, 35)
        Me.txtEmail.TabIndex = 6
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "STUDENT ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "FIRST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "LAST NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(394, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "GENDER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(394, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "BIRTH DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "EMAIL"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.bday)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.cmbGender)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtLast)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtFirst)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 355)
        Me.Panel1.TabIndex = 13
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(566, 291)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(141, 38)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Transparent
        Me.btnDelete.Location = New System.Drawing.Point(566, 228)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 38)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Green
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(394, 228)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(141, 38)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(394, 291)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 38)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'EnrollmentDBDataSet
        '
        Me.EnrollmentDBDataSet.DataSetName = "EnrollmentDBDataSet"
        Me.EnrollmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STUDENTBindingSource
        '
        Me.STUDENTBindingSource.DataMember = "STUDENT"
        Me.STUDENTBindingSource.DataSource = Me.EnrollmentDBDataSet
        '
        'STUDENTTableAdapter
        '
        Me.STUDENTTableAdapter.ClearBeforeFill = True
        '
        'ENROLLMENTTableAdapter
        '
        Me.ENROLLMENTTableAdapter.ClearBeforeFill = True
        '
        'STUDENTBindingSource1
        '
        Me.STUDENTBindingSource1.DataMember = "STUDENT"
        Me.STUDENTBindingSource1.DataSource = Me.EnrollmentDBDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.STUDENTBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 373)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1028, 268)
        Me.DataGridView1.TabIndex = 18
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "STUDENT ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "FIRST NAME"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "LAST NAME"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "GENDER"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BirthdateDataGridViewTextBoxColumn
        '
        Me.BirthdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BirthdateDataGridViewTextBoxColumn.DataPropertyName = "birth_date"
        Me.BirthdateDataGridViewTextBoxColumn.HeaderText = "BIRTH DATE"
        Me.BirthdateDataGridViewTextBoxColumn.Name = "BirthdateDataGridViewTextBoxColumn"
        Me.BirthdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'STUDENTBindingSource2
        '
        Me.STUDENTBindingSource2.DataMember = "STUDENT"
        Me.STUDENTBindingSource2.DataSource = Me.EnrollmentDBDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(350, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(282, 28)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "STUDENT INFORMATION"
        '
        'FKENROLLMENTSTUDENTBindingSource
        '
        Me.FKENROLLMENTSTUDENTBindingSource.DataMember = "FK_ENROLLMENT_STUDENT"
        Me.FKENROLLMENTSTUDENTBindingSource.DataSource = Me.STUDENTBindingSource
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1061, 639)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmStudent"
        Me.Text = "STUDENT INFORMATION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EnrollmentDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKENROLLMENTSTUDENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents bday As DateTimePicker
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents EnrollmentDBDataSet As EnrollmentDBDataSet
    Friend WithEvents STUDENTBindingSource As BindingSource
    Friend WithEvents STUDENTTableAdapter As EnrollmentDBDataSetTableAdapters.STUDENTTableAdapter
    Friend WithEvents FKENROLLMENTSTUDENTBindingSource As BindingSource
    Friend WithEvents ENROLLMENTTableAdapter As EnrollmentDBDataSetTableAdapters.ENROLLMENTTableAdapter
    Friend WithEvents STUDENTBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents STUDENTBindingSource2 As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
End Class
