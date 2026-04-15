<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSection
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
        Me.DayofweekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StarttimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndtimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COURSEidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSTRUCTORidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SECTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnrollmentDBDataSet = New EnrollTrack.EnrollmentDBDataSet()
        Me.SECTIONTableAdapter = New EnrollTrack.EnrollmentDBDataSetTableAdapters.SECTIONTableAdapter()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.timeStart = New System.Windows.Forms.DateTimePicker()
        Me.timeEnd = New System.Windows.Forms.DateTimePicker()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.txtCourseId = New System.Windows.Forms.TextBox()
        Me.txtInstructorId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbSem = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SECTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnrollmentDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DayofweekDataGridViewTextBoxColumn, Me.StarttimeDataGridViewTextBoxColumn, Me.EndtimeDataGridViewTextBoxColumn, Me.SemesterDataGridViewTextBoxColumn, Me.RoomDataGridViewTextBoxColumn, Me.COURSEidDataGridViewTextBoxColumn, Me.INSTRUCTORidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SECTIONBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 373)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1026, 242)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'DayofweekDataGridViewTextBoxColumn
        '
        Me.DayofweekDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DayofweekDataGridViewTextBoxColumn.DataPropertyName = "day_of_week"
        Me.DayofweekDataGridViewTextBoxColumn.HeaderText = "DAY OF WEEK"
        Me.DayofweekDataGridViewTextBoxColumn.Name = "DayofweekDataGridViewTextBoxColumn"
        '
        'StarttimeDataGridViewTextBoxColumn
        '
        Me.StarttimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StarttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time"
        Me.StarttimeDataGridViewTextBoxColumn.HeaderText = "START TIME"
        Me.StarttimeDataGridViewTextBoxColumn.Name = "StarttimeDataGridViewTextBoxColumn"
        '
        'EndtimeDataGridViewTextBoxColumn
        '
        Me.EndtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EndtimeDataGridViewTextBoxColumn.DataPropertyName = "end_time"
        Me.EndtimeDataGridViewTextBoxColumn.HeaderText = "END TIME"
        Me.EndtimeDataGridViewTextBoxColumn.Name = "EndtimeDataGridViewTextBoxColumn"
        '
        'SemesterDataGridViewTextBoxColumn
        '
        Me.SemesterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SemesterDataGridViewTextBoxColumn.DataPropertyName = "semester"
        Me.SemesterDataGridViewTextBoxColumn.HeaderText = "SEMESTER"
        Me.SemesterDataGridViewTextBoxColumn.Name = "SemesterDataGridViewTextBoxColumn"
        '
        'RoomDataGridViewTextBoxColumn
        '
        Me.RoomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RoomDataGridViewTextBoxColumn.DataPropertyName = "room"
        Me.RoomDataGridViewTextBoxColumn.HeaderText = "ROOM"
        Me.RoomDataGridViewTextBoxColumn.Name = "RoomDataGridViewTextBoxColumn"
        '
        'COURSEidDataGridViewTextBoxColumn
        '
        Me.COURSEidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.COURSEidDataGridViewTextBoxColumn.DataPropertyName = "COURSE_id"
        Me.COURSEidDataGridViewTextBoxColumn.HeaderText = "COURSE"
        Me.COURSEidDataGridViewTextBoxColumn.Name = "COURSEidDataGridViewTextBoxColumn"
        '
        'INSTRUCTORidDataGridViewTextBoxColumn
        '
        Me.INSTRUCTORidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.INSTRUCTORidDataGridViewTextBoxColumn.DataPropertyName = "INSTRUCTOR_id"
        Me.INSTRUCTORidDataGridViewTextBoxColumn.HeaderText = "INSTRUCTOR"
        Me.INSTRUCTORidDataGridViewTextBoxColumn.Name = "INSTRUCTORidDataGridViewTextBoxColumn"
        '
        'SECTIONBindingSource
        '
        Me.SECTIONBindingSource.DataMember = "SECTION"
        Me.SECTIONBindingSource.DataSource = Me.EnrollmentDBDataSet
        '
        'EnrollmentDBDataSet
        '
        Me.EnrollmentDBDataSet.DataSetName = "EnrollmentDBDataSet"
        Me.EnrollmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SECTIONTableAdapter
        '
        Me.SECTIONTableAdapter.ClearBeforeFill = True
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(222, 53)
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(185, 34)
        Me.txtId.TabIndex = 1
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbDay
        '
        Me.cmbDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Items.AddRange(New Object() {"MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY"})
        Me.cmbDay.Location = New System.Drawing.Point(222, 116)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(185, 28)
        Me.cmbDay.TabIndex = 2
        '
        'timeStart
        '
        Me.timeStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeStart.Location = New System.Drawing.Point(222, 169)
        Me.timeStart.Name = "timeStart"
        Me.timeStart.ShowUpDown = True
        Me.timeStart.Size = New System.Drawing.Size(185, 29)
        Me.timeStart.TabIndex = 3
        '
        'timeEnd
        '
        Me.timeEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeEnd.Location = New System.Drawing.Point(222, 226)
        Me.timeEnd.Name = "timeEnd"
        Me.timeEnd.ShowUpDown = True
        Me.timeEnd.Size = New System.Drawing.Size(185, 29)
        Me.timeEnd.TabIndex = 4
        '
        'txtRoom
        '
        Me.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoom.Location = New System.Drawing.Point(772, 170)
        Me.txtRoom.Multiline = True
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(183, 32)
        Me.txtRoom.TabIndex = 6
        Me.txtRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCourseId
        '
        Me.txtCourseId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourseId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseId.Location = New System.Drawing.Point(772, 226)
        Me.txtCourseId.Multiline = True
        Me.txtCourseId.Name = "txtCourseId"
        Me.txtCourseId.Size = New System.Drawing.Size(182, 34)
        Me.txtCourseId.TabIndex = 7
        Me.txtCourseId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInstructorId
        '
        Me.txtInstructorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInstructorId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructorId.Location = New System.Drawing.Point(772, 52)
        Me.txtInstructorId.Multiline = True
        Me.txtInstructorId.Name = "txtInstructorId"
        Me.txtInstructorId.Size = New System.Drawing.Size(184, 32)
        Me.txtInstructorId.TabIndex = 8
        Me.txtInstructorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SECTION ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "DAY OF WEEK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "END TIME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "START TIME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(588, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "SEMESTER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(593, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ROOM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(593, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "COURSE ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(588, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "INSTRUCTOR ID"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(663, 291)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 43)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(522, 291)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 43)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Yellow
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(375, 291)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 43)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Green
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(231, 291)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 43)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cmbSem
        '
        Me.cmbSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSem.FormattingEnabled = True
        Me.cmbSem.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbSem.Location = New System.Drawing.Point(772, 120)
        Me.cmbSem.Name = "cmbSem"
        Me.cmbSem.Size = New System.Drawing.Size(184, 26)
        Me.cmbSem.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.timeStart)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.cmbSem)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.cmbDay)
        Me.Panel1.Controls.Add(Me.timeEnd)
        Me.Panel1.Controls.Add(Me.txtInstructorId)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtCourseId)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtRoom)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1025, 354)
        Me.Panel1.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(439, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 25)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "SECTION"
        '
        'frmSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1061, 624)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmSection"
        Me.Text = "SECTION"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SECTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnrollmentDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EnrollmentDBDataSet As EnrollmentDBDataSet
    Friend WithEvents SECTIONBindingSource As BindingSource
    Friend WithEvents SECTIONTableAdapter As EnrollmentDBDataSetTableAdapters.SECTIONTableAdapter
    Friend WithEvents txtId As TextBox
    Friend WithEvents cmbDay As ComboBox
    Friend WithEvents timeStart As DateTimePicker
    Friend WithEvents timeEnd As DateTimePicker
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents txtCourseId As TextBox
    Friend WithEvents txtInstructorId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbSem As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DayofweekDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StarttimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndtimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemesterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COURSEidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INSTRUCTORidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
End Class
