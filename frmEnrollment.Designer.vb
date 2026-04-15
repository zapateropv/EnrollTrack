<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnrollment
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SECTIONidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STUDENTidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENROLLMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnrollmentDBDataSet = New EnrollTrack.EnrollmentDBDataSet()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.txtSectionId = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ENROLLMENTTableAdapter = New EnrollTrack.EnrollmentDBDataSetTableAdapters.ENROLLMENTTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENROLLMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnrollmentDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn, Me.SECTIONidDataGridViewTextBoxColumn, Me.STUDENTidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ENROLLMENTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 290)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1022, 354)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "GRADE"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        '
        'SECTIONidDataGridViewTextBoxColumn
        '
        Me.SECTIONidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SECTIONidDataGridViewTextBoxColumn.DataPropertyName = "SECTION_id"
        Me.SECTIONidDataGridViewTextBoxColumn.HeaderText = "SECTION ID"
        Me.SECTIONidDataGridViewTextBoxColumn.Name = "SECTIONidDataGridViewTextBoxColumn"
        '
        'STUDENTidDataGridViewTextBoxColumn
        '
        Me.STUDENTidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.STUDENTidDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_id"
        Me.STUDENTidDataGridViewTextBoxColumn.HeaderText = "STUDENT ID"
        Me.STUDENTidDataGridViewTextBoxColumn.Name = "STUDENTidDataGridViewTextBoxColumn"
        '
        'ENROLLMENTBindingSource
        '
        Me.ENROLLMENTBindingSource.DataMember = "ENROLLMENT"
        Me.ENROLLMENTBindingSource.DataSource = Me.EnrollmentDBDataSet
        '
        'EnrollmentDBDataSet
        '
        Me.EnrollmentDBDataSet.DataSetName = "EnrollmentDBDataSet"
        Me.EnrollmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(817, 173)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 40)
        Me.btnClear.TabIndex = 21
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
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(577, 173)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(101, 40)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(699, 173)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(101, 40)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Green
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(460, 173)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(101, 40)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(183, 52)
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(214, 30)
        Me.txtId.TabIndex = 22
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGrade
        '
        Me.txtGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade.Location = New System.Drawing.Point(183, 108)
        Me.txtGrade.Multiline = True
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(214, 30)
        Me.txtGrade.TabIndex = 23
        Me.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStudentId
        '
        Me.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentId.Location = New System.Drawing.Point(183, 210)
        Me.txtStudentId.Multiline = True
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(214, 30)
        Me.txtStudentId.TabIndex = 24
        Me.txtStudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSectionId
        '
        Me.txtSectionId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSectionId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSectionId.Location = New System.Drawing.Point(183, 161)
        Me.txtSectionId.Multiline = True
        Me.txtSectionId.Name = "txtSectionId"
        Me.txtSectionId.Size = New System.Drawing.Size(214, 30)
        Me.txtSectionId.TabIndex = 25
        Me.txtSectionId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(48, 62)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(24, 20)
        Me.id.TabIndex = 26
        Me.id.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "GRADE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "SECTION ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "STUDENT ID"
        '
        'ENROLLMENTTableAdapter
        '
        Me.ENROLLMENTTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtGrade)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.txtSectionId)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txtStudentId)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.id)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1022, 263)
        Me.Panel1.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(428, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ENROLLMENT"
        '
        'frmEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1061, 656)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmEnrollment"
        Me.Text = "ENROLLMENT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENROLLMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnrollmentDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents txtSectionId As TextBox
    Friend WithEvents id As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EnrollmentDBDataSet As EnrollmentDBDataSet
    Friend WithEvents ENROLLMENTBindingSource As BindingSource
    Friend WithEvents ENROLLMENTTableAdapter As EnrollmentDBDataSetTableAdapters.ENROLLMENTTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SECTIONidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STUDENTidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
