<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
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
        Me.ButtonAddrecord = New System.Windows.Forms.Button()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.backup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonAddrecord
        '
        Me.ButtonAddrecord.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddrecord.Location = New System.Drawing.Point(106, 64)
        Me.ButtonAddrecord.Name = "ButtonAddrecord"
        Me.ButtonAddrecord.Size = New System.Drawing.Size(176, 35)
        Me.ButtonAddrecord.TabIndex = 0
        Me.ButtonAddrecord.Text = "Add Record"
        Me.ButtonAddrecord.UseVisualStyleBackColor = True
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLoad.Location = New System.Drawing.Point(106, 114)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(176, 35)
        Me.ButtonLoad.TabIndex = 1
        Me.ButtonLoad.Text = "Load Record"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(29, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Log out"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'backup
        '
        Me.backup.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backup.Location = New System.Drawing.Point(106, 166)
        Me.backup.Name = "backup"
        Me.backup.Size = New System.Drawing.Size(176, 35)
        Me.backup.TabIndex = 3
        Me.backup.Text = "Backup Data"
        Me.backup.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(405, 265)
        Me.Controls.Add(Me.backup)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonLoad)
        Me.Controls.Add(Me.ButtonAddrecord)
        Me.Name = "MenuForm"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonAddrecord As Button
    Friend WithEvents ButtonLoad As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents backup As Button
End Class
