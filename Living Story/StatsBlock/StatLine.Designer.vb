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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStatName = New System.Windows.Forms.Label()
        Me.lblStatValue = New System.Windows.Forms.Label()
        Me.lblStatMod = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatMod, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatValue, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(253, 26)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblStatName
        '
        Me.lblStatName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatName.Location = New System.Drawing.Point(3, 0)
        Me.lblStatName.Name = "lblStatName"
        Me.lblStatName.Size = New System.Drawing.Size(145, 26)
        Me.lblStatName.TabIndex = 0
        Me.lblStatName.Text = "Label1"
        Me.lblStatName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatValue
        '
        Me.lblStatValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatValue.Location = New System.Drawing.Point(154, 0)
        Me.lblStatValue.Name = "lblStatValue"
        Me.lblStatValue.Size = New System.Drawing.Size(44, 26)
        Me.lblStatValue.TabIndex = 1
        Me.lblStatValue.Text = "Label2"
        Me.lblStatValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatMod
        '
        Me.lblStatMod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatMod.Location = New System.Drawing.Point(204, 0)
        Me.lblStatMod.Name = "lblStatMod"
        Me.lblStatMod.Size = New System.Drawing.Size(46, 26)
        Me.lblStatMod.TabIndex = 2
        Me.lblStatMod.Text = "Label3"
        Me.lblStatMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "StatLine"
        Me.Size = New System.Drawing.Size(253, 26)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblStatMod As System.Windows.Forms.Label
    Friend WithEvents lblStatName As System.Windows.Forms.Label
    Friend WithEvents lblStatValue As System.Windows.Forms.Label

End Class
