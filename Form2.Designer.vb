<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnSection = New System.Windows.Forms.Button()
        Me.btnInstructor = New System.Windows.Forms.Button()
        Me.btnEnrollment = New System.Windows.Forms.Button()
        Me.bnCourse = New System.Windows.Forms.Button()
        Me.btnDepartment = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Location = New System.Drawing.Point(213, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1053, 655)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(-9, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1287, 111)
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(383, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(544, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enrollment Management System"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnHome)
        Me.Panel3.Controls.Add(Me.btnStudent)
        Me.Panel3.Controls.Add(Me.btnSection)
        Me.Panel3.Controls.Add(Me.btnInstructor)
        Me.Panel3.Controls.Add(Me.btnEnrollment)
        Me.Panel3.Controls.Add(Me.bnCourse)
        Me.Panel3.Controls.Add(Me.btnDepartment)
        Me.Panel3.Location = New System.Drawing.Point(-9, 113)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(203, 680)
        Me.Panel3.TabIndex = 8
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Green
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.FlatAppearance.BorderSize = 2
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("JetBrains Mono ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = Global.EnrollTrack.My.Resources.Resources.icons8_home_30
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(21, 45)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(163, 48)
        Me.btnHome.TabIndex = 7
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStudent.FlatAppearance.BorderSize = 2
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("JetBrains Mono ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.White
        Me.btnStudent.Image = Global.EnrollTrack.My.Resources.Resources.icons8_user_30
        Me.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudent.Location = New System.Drawing.Point(21, 146)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(163, 48)
        Me.btnStudent.TabIndex = 1
        Me.btnStudent.Text = "STUDENTS"
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'btnSection
        '
        Me.btnSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnSection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSection.FlatAppearance.BorderSize = 2
        Me.btnSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSection.Font = New System.Drawing.Font("JetBrains Mono ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSection.ForeColor = System.Drawing.Color.White
        Me.btnSection.Image = Global.EnrollTrack.My.Resources.Resources.icons8_room_25
        Me.btnSection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSection.Location = New System.Drawing.Point(21, 408)
        Me.btnSection.Name = "btnSection"
        Me.btnSection.Size = New System.Drawing.Size(163, 48)
        Me.btnSection.TabIndex = 5
        Me.btnSection.Text = "SECTION"
        Me.btnSection.UseVisualStyleBackColor = False
        '
        'btnInstructor
        '
        Me.btnInstructor.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnInstructor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInstructor.FlatAppearance.BorderSize = 2
        Me.btnInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstructor.Font = New System.Drawing.Font("JetBrains Mono ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructor.ForeColor = System.Drawing.Color.White
        Me.btnInstructor.Image = Global.EnrollTrack.My.Resources.Resources.icons8_training_25
        Me.btnInstructor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInstructor.Location = New System.Drawing.Point(21, 344)
        Me.btnInstructor.Name = "btnInstructor"
        Me.btnInstructor.Size = New System.Drawing.Size(163, 48)
        Me.btnInstructor.TabIndex = 4
        Me.btnInstructor.Text = "INSTRUCTOR"
        Me.btnInstructor.UseVisualStyleBackColor = False
        '
        'btnEnrollment
        '
        Me.btnEnrollment.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnEnrollment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnrollment.FlatAppearance.BorderSize = 2
        Me.btnEnrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnrollment.Font = New System.Drawing.Font("JetBrains Mono ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnrollment.ForeColor = System.Drawing.Color.White
        Me.btnEnrollment.Image = Global.EnrollTrack.My.Resources.Resources.icons8_school_25
        Me.btnEnrollment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnrollment.Location = New System.Drawing.Point(21, 473)
        Me.btnEnrollment.Name = "btnEnrollment"
        Me.btnEnrollment.Size = New System.Drawing.Size(163, 48)
        Me.btnEnrollment.TabIndex = 6
        Me.btnEnrollment.Text = "ENROLLMENT"
        Me.btnEnrollment.UseVisualStyleBackColor = False
        '
        'bnCourse
        '
        Me.bnCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.bnCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnCourse.FlatAppearance.BorderSize = 2
        Me.bnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnCourse.Font = New System.Drawing.Font("JetBrains Mono ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnCourse.ForeColor = System.Drawing.Color.White
        Me.bnCourse.Image = Global.EnrollTrack.My.Resources.Resources.icons8_books_30
        Me.bnCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bnCourse.Location = New System.Drawing.Point(21, 277)
        Me.bnCourse.Name = "bnCourse"
        Me.bnCourse.Size = New System.Drawing.Size(163, 48)
        Me.bnCourse.TabIndex = 3
        Me.bnCourse.Text = "COURSE"
        Me.bnCourse.UseVisualStyleBackColor = False
        '
        'btnDepartment
        '
        Me.btnDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnDepartment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDepartment.FlatAppearance.BorderSize = 2
        Me.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepartment.Font = New System.Drawing.Font("JetBrains Mono ExtraBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepartment.ForeColor = System.Drawing.Color.White
        Me.btnDepartment.Image = Global.EnrollTrack.My.Resources.Resources.icons8_department_201
        Me.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDepartment.Location = New System.Drawing.Point(21, 212)
        Me.btnDepartment.Name = "btnDepartment"
        Me.btnDepartment.Size = New System.Drawing.Size(163, 48)
        Me.btnDepartment.TabIndex = 2
        Me.btnDepartment.Text = "DEPARTMENT"
        Me.btnDepartment.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.EnrollTrack.My.Resources.Resources.logotrac_removebg_preview2
        Me.PictureBox1.Location = New System.Drawing.Point(-19, -49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1278, 786)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form2"
        Me.Text = "Enrollment Management System"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnDepartment As Button
    Friend WithEvents bnCourse As Button
    Friend WithEvents btnInstructor As Button
    Friend WithEvents btnSection As Button
    Friend WithEvents btnEnrollment As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
