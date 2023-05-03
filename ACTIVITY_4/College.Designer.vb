<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class college
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
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextCollege = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bttnexport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID"
        '
        'TextID
        '
        Me.TextID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextID.Location = New System.Drawing.Point(163, 79)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(147, 23)
        Me.TextID.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "College Department"
        '
        'TextCollege
        '
        Me.TextCollege.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCollege.Location = New System.Drawing.Point(163, 128)
        Me.TextCollege.Name = "TextCollege"
        Me.TextCollege.Size = New System.Drawing.Size(147, 23)
        Me.TextCollege.TabIndex = 15
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Font = New System.Drawing.Font("Century Gothic", 10.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonAdd.Location = New System.Drawing.Point(56, 173)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(244, 29)
        Me.ButtonAdd.TabIndex = 16
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Font = New System.Drawing.Font("Century Gothic", 10.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonCancel.Location = New System.Drawing.Point(56, 243)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(244, 30)
        Me.ButtonCancel.TabIndex = 17
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 28)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "College"
        '
        'ButtonHome
        '
        Me.ButtonHome.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHome.Location = New System.Drawing.Point(29, 12)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHome.TabIndex = 18
        Me.ButtonHome.Text = "Menu"
        Me.ButtonHome.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(261, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bttnexport
        '
        Me.bttnexport.Font = New System.Drawing.Font("Century Gothic", 10.75!, System.Drawing.FontStyle.Bold)
        Me.bttnexport.Location = New System.Drawing.Point(56, 208)
        Me.bttnexport.Name = "bttnexport"
        Me.bttnexport.Size = New System.Drawing.Size(244, 29)
        Me.bttnexport.TabIndex = 20
        Me.bttnexport.Text = "Export"
        Me.bttnexport.UseVisualStyleBackColor = True
        '
        'college
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(348, 285)
        Me.Controls.Add(Me.bttnexport)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonHome)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextCollege)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "college"
        Me.Text = "College"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextCollege As TextBox
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonHome As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents bttnexport As Button
End Class
