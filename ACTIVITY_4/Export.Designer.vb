<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Export
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bttnExport = New System.Windows.Forms.Button()
        Me.bttshow = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 312)
        Me.DataGridView1.TabIndex = 0
        '
        'bttnExport
        '
        Me.bttnExport.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnExport.Location = New System.Drawing.Point(300, 347)
        Me.bttnExport.Name = "bttnExport"
        Me.bttnExport.Size = New System.Drawing.Size(266, 53)
        Me.bttnExport.TabIndex = 9
        Me.bttnExport.Text = "Export"
        Me.bttnExport.UseVisualStyleBackColor = True
        '
        'bttshow
        '
        Me.bttshow.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttshow.Location = New System.Drawing.Point(21, 347)
        Me.bttshow.Name = "bttshow"
        Me.bttshow.Size = New System.Drawing.Size(261, 53)
        Me.bttshow.TabIndex = 10
        Me.bttshow.Text = "Show"
        Me.bttshow.UseVisualStyleBackColor = True
        '
        'Export
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 412)
        Me.Controls.Add(Me.bttshow)
        Me.Controls.Add(Me.bttnExport)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Export"
        Me.Text = "Export"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bttnExport As Button
    Friend WithEvents bttshow As Button
End Class
