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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbdep = New System.Windows.Forms.ComboBox()
        Me.cmdid = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.weekend = New System.Windows.Forms.RadioButton()
        Me.extension = New System.Windows.Forms.RadioButton()
        Me.regular = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdclose = New System.Windows.Forms.Button()
        Me.cmdregistred = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Department:"
        '
        'cmbdep
        '
        Me.cmbdep.FormattingEnabled = True
        Me.cmbdep.Items.AddRange(New Object() {"Accounting", "Business Administration", "Computer Science", "Management", "Marketing"})
        Me.cmbdep.Location = New System.Drawing.Point(129, 29)
        Me.cmbdep.Name = "cmbdep"
        Me.cmbdep.Size = New System.Drawing.Size(121, 21)
        Me.cmbdep.TabIndex = 1
        '
        'cmdid
        '
        Me.cmdid.Location = New System.Drawing.Point(387, 27)
        Me.cmdid.Name = "cmdid"
        Me.cmdid.Size = New System.Drawing.Size(155, 23)
        Me.cmdid.TabIndex = 2
        Me.cmdid.Text = "Generate ID"
        Me.cmdid.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID:"
        '
        'weekend
        '
        Me.weekend.AutoSize = True
        Me.weekend.Location = New System.Drawing.Point(33, 169)
        Me.weekend.Name = "weekend"
        Me.weekend.Size = New System.Drawing.Size(72, 17)
        Me.weekend.TabIndex = 4
        Me.weekend.TabStop = True
        Me.weekend.Text = "Weekend"
        Me.weekend.UseVisualStyleBackColor = True
        '
        'extension
        '
        Me.extension.AutoSize = True
        Me.extension.Location = New System.Drawing.Point(33, 146)
        Me.extension.Name = "extension"
        Me.extension.Size = New System.Drawing.Size(71, 17)
        Me.extension.TabIndex = 5
        Me.extension.TabStop = True
        Me.extension.Text = "Extension"
        Me.extension.UseVisualStyleBackColor = True
        '
        'regular
        '
        Me.regular.AutoSize = True
        Me.regular.Location = New System.Drawing.Point(33, 123)
        Me.regular.Name = "regular"
        Me.regular.Size = New System.Drawing.Size(65, 17)
        Me.regular.TabIndex = 6
        Me.regular.TabStop = True
        Me.regular.Text = "Regular "
        Me.regular.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 115)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "               Division"
        '
        'cmdclose
        '
        Me.cmdclose.Location = New System.Drawing.Point(335, 226)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(75, 23)
        Me.cmdclose.TabIndex = 9
        Me.cmdclose.Text = "Exit"
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'cmdregistred
        '
        Me.cmdregistred.Location = New System.Drawing.Point(90, 226)
        Me.cmdregistred.Name = "cmdregistred"
        Me.cmdregistred.Size = New System.Drawing.Size(75, 23)
        Me.cmdregistred.TabIndex = 10
        Me.cmdregistred.Text = "Register "
        Me.cmdregistred.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 261)
        Me.Controls.Add(Me.cmdregistred)
        Me.Controls.Add(Me.cmdclose)
        Me.Controls.Add(Me.regular)
        Me.Controls.Add(Me.extension)
        Me.Controls.Add(Me.weekend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdid)
        Me.Controls.Add(Me.cmbdep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbdep As System.Windows.Forms.ComboBox
    Friend WithEvents cmdid As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents weekend As System.Windows.Forms.RadioButton
    Friend WithEvents extension As System.Windows.Forms.RadioButton
    Friend WithEvents regular As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmdregistred As System.Windows.Forms.Button

End Class
