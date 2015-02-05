<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReaderModeScreen
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
        Me.TopMenu1 = New StatsBlock.TopMenu()
        Me.StatsBlock1 = New StatsBlock.StatsBlock()
        Me.DisplayScreen1 = New StatsBlock.DisplayScreen()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TopMenu1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StatsBlock1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DisplayScreen1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(900, 616)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TopMenu1
        '
        Me.TopMenu1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.SetColumnSpan(Me.TopMenu1, 2)
        Me.TopMenu1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopMenu1.Location = New System.Drawing.Point(3, 3)
        Me.TopMenu1.Name = "TopMenu1"
        Me.TopMenu1.Size = New System.Drawing.Size(894, 43)
        Me.TopMenu1.TabIndex = 0
        '
        'StatsBlock1
        '
        Me.StatsBlock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StatsBlock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatsBlock1.Location = New System.Drawing.Point(3, 52)
        Me.StatsBlock1.Name = "StatsBlock1"
        Me.StatsBlock1.Size = New System.Drawing.Size(174, 468)
        Me.StatsBlock1.TabIndex = 1
        '
        'DisplayScreen1
        '
        Me.DisplayScreen1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DisplayScreen1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisplayScreen1.Location = New System.Drawing.Point(183, 52)
        Me.DisplayScreen1.Name = "DisplayScreen1"
        Me.TableLayoutPanel1.SetRowSpan(Me.DisplayScreen1, 2)
        Me.DisplayScreen1.Size = New System.Drawing.Size(714, 561)
        Me.DisplayScreen1.TabIndex = 2
        '
        'ReaderModeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ReaderModeScreen"
        Me.Size = New System.Drawing.Size(900, 616)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TopMenu1 As StatsBlock.TopMenu
    Friend WithEvents StatsBlock1 As StatsBlock.StatsBlock
    Friend WithEvents DisplayScreen1 As StatsBlock.DisplayScreen

End Class
