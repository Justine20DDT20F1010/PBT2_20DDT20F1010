<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn_Calculate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tb_Avg = New System.Windows.Forms.TextBox()
        Me.Tb_Test3 = New System.Windows.Forms.TextBox()
        Me.Tb_Test2 = New System.Windows.Forms.TextBox()
        Me.Tb_Test1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Calculate
        '
        Me.Btn_Calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Calculate.Location = New System.Drawing.Point(124, 241)
        Me.Btn_Calculate.Name = "Btn_Calculate"
        Me.Btn_Calculate.Size = New System.Drawing.Size(150, 33)
        Me.Btn_Calculate.TabIndex = 19
        Me.Btn_Calculate.Text = "Calculate Average"
        Me.Btn_Calculate.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(257, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 40)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Average " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mark:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tb_Avg
        '
        Me.Tb_Avg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Avg.Location = New System.Drawing.Point(243, 184)
        Me.Tb_Avg.Name = "Tb_Avg"
        Me.Tb_Avg.ReadOnly = True
        Me.Tb_Avg.Size = New System.Drawing.Size(100, 26)
        Me.Tb_Avg.TabIndex = 17
        Me.Tb_Avg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_Test3
        '
        Me.Tb_Test3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Test3.Location = New System.Drawing.Point(122, 202)
        Me.Tb_Test3.Name = "Tb_Test3"
        Me.Tb_Test3.Size = New System.Drawing.Size(100, 26)
        Me.Tb_Test3.TabIndex = 16
        Me.Tb_Test3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_Test2
        '
        Me.Tb_Test2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Test2.Location = New System.Drawing.Point(122, 169)
        Me.Tb_Test2.Name = "Tb_Test2"
        Me.Tb_Test2.Size = New System.Drawing.Size(100, 26)
        Me.Tb_Test2.TabIndex = 15
        Me.Tb_Test2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tb_Test1
        '
        Me.Tb_Test1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Test1.Location = New System.Drawing.Point(122, 137)
        Me.Tb_Test1.Name = "Tb_Test1"
        Me.Tb_Test1.Size = New System.Drawing.Size(100, 26)
        Me.Tb_Test1.TabIndex = 14
        Me.Tb_Test1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Exam 3:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Exam 2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Exam 1:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Average Mark Calculator"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Name :"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(124, 92)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 26)
        Me.txtname.TabIndex = 21
        Me.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 286)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Btn_Calculate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Tb_Avg)
        Me.Controls.Add(Me.Tb_Test3)
        Me.Controls.Add(Me.Tb_Test2)
        Me.Controls.Add(Me.Tb_Test1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calcualate Mark"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Calculate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Tb_Avg As TextBox
    Friend WithEvents Tb_Test3 As TextBox
    Friend WithEvents Tb_Test2 As TextBox
    Friend WithEvents Tb_Test1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtname As TextBox
End Class
