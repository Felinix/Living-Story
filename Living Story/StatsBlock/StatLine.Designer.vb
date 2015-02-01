<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatLine
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.StatName = New System.Windows.Forms.Label()
        Me.StatValue = New System.Windows.Forms.Label()
        Me.StatModifier = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StatName
        '
        Me.StatName.AutoSize = True
        Me.StatName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatName.Location = New System.Drawing.Point(3, 0)
        Me.StatName.Name = "StatName"
        Me.StatName.Size = New System.Drawing.Size(63, 20)
        Me.StatName.TabIndex = 0
        Me.StatName.Text = "Label1"
        '
        'StatValue
        '
        Me.StatValue.AutoSize = True
        Me.StatValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatValue.Location = New System.Drawing.Point(102, 0)
        Me.StatValue.Name = "StatValue"
        Me.StatValue.Size = New System.Drawing.Size(57, 20)
        Me.StatValue.TabIndex = 1
        Me.StatValue.Text = "Label2"
        '
        'StatModifier
        '
        Me.StatModifier.AutoSize = True
        Me.StatModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatModifier.Location = New System.Drawing.Point(171, 0)
        Me.StatModifier.Name = "StatModifier"
        Me.StatModifier.Size = New System.Drawing.Size(57, 20)
        Me.StatModifier.TabIndex = 2
        Me.StatModifier.Text = "Label2"
        '
        'StatLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.StatModifier)
        Me.Controls.Add(Me.StatValue)
        Me.Controls.Add(Me.StatName)
        Me.Name = "StatLine"
        Me.Size = New System.Drawing.Size(231, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatName As System.Windows.Forms.Label
    Friend WithEvents StatValue As System.Windows.Forms.Label
    Friend WithEvents StatModifier As System.Windows.Forms.Label

End Class
