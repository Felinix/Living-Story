<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LivingStory
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
        Me.EditorPanel = New System.Windows.Forms.Panel()
        Me.ReaderPanel = New System.Windows.Forms.Panel()
        Me.StatsBlock1 = New StatsBlock.StatsBlock()
        Me.TopMenu1 = New StatsBlock.TopMenu()
        Me.DisplayScreen1 = New StatsBlock.DisplayScreen()
        Me.EditorPanel.SuspendLayout()
        Me.ReaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditorPanel
        '
        Me.EditorPanel.Controls.Add(Me.ReaderPanel)
        Me.EditorPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditorPanel.Location = New System.Drawing.Point(0, 0)
        Me.EditorPanel.Name = "EditorPanel"
        Me.EditorPanel.Size = New System.Drawing.Size(984, 661)
        Me.EditorPanel.TabIndex = 0
        '
        'ReaderPanel
        '
        Me.ReaderPanel.Controls.Add(Me.StatsBlock1)
        Me.ReaderPanel.Controls.Add(Me.TopMenu1)
        Me.ReaderPanel.Controls.Add(Me.DisplayScreen1)
        Me.ReaderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.ReaderPanel.Name = "ReaderPanel"
        Me.ReaderPanel.Size = New System.Drawing.Size(984, 661)
        Me.ReaderPanel.TabIndex = 0
        '
        'StatsBlock1
        '
        Me.StatsBlock1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StatsBlock1.BackColor = System.Drawing.SystemColors.Control
        Me.StatsBlock1.Location = New System.Drawing.Point(12, 67)
        Me.StatsBlock1.Name = "StatsBlock1"
        Me.StatsBlock1.Size = New System.Drawing.Size(196, 492)
        Me.StatsBlock1.TabIndex = 3
        '
        'TopMenu1
        '
        Me.TopMenu1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TopMenu1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TopMenu1.Location = New System.Drawing.Point(3, 3)
        Me.TopMenu1.Name = "TopMenu1"
        Me.TopMenu1.Size = New System.Drawing.Size(974, 58)
        Me.TopMenu1.TabIndex = 2
        '
        'DisplayScreen1
        '
        Me.DisplayScreen1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisplayScreen1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DisplayScreen1.Location = New System.Drawing.Point(210, 67)
        Me.DisplayScreen1.Name = "DisplayScreen1"
        Me.DisplayScreen1.Size = New System.Drawing.Size(767, 591)
        Me.DisplayScreen1.TabIndex = 1
        '
        'LivingStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.EditorPanel)
        Me.Name = "LivingStory"
        Me.Text = "Living Story"
        Me.EditorPanel.ResumeLayout(False)
        Me.ReaderPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EditorPanel As System.Windows.Forms.Panel
    Friend WithEvents ReaderPanel As System.Windows.Forms.Panel
    Friend WithEvents DisplayScreen1 As StatsBlock.DisplayScreen
    Friend WithEvents TopMenu1 As StatsBlock.TopMenu
    Friend WithEvents StatsBlock1 As StatsBlock.StatsBlock

End Class
