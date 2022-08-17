<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formcleaner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formcleaner))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcpu = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblram = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New Winix___MemoryCleaner.WinixTHEMEProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ShowMainWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinixTHEMEContextMenu1 = New Winix___MemoryCleaner.WinixTHEMEContextMenu()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinixTHEMEContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(97, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CPU:"
        '
        'lblcpu
        '
        Me.lblcpu.AutoSize = True
        Me.lblcpu.BackColor = System.Drawing.Color.Transparent
        Me.lblcpu.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblcpu.ForeColor = System.Drawing.Color.White
        Me.lblcpu.Location = New System.Drawing.Point(129, 5)
        Me.lblcpu.Name = "lblcpu"
        Me.lblcpu.Size = New System.Drawing.Size(24, 17)
        Me.lblcpu.TabIndex = 4
        Me.lblcpu.Text = "0%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(28, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "RAM:"
        '
        'lblram
        '
        Me.lblram.AutoSize = True
        Me.lblram.BackColor = System.Drawing.Color.Transparent
        Me.lblram.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblram.ForeColor = System.Drawing.Color.White
        Me.lblram.Location = New System.Drawing.Point(62, 5)
        Me.lblram.Name = "lblram"
        Me.lblram.Size = New System.Drawing.Size(24, 17)
        Me.lblram.TabIndex = 3
        Me.lblram.Text = "0%"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button1.BackgroundImage = Global.Winix___MemoryCleaner.My.Resources.Resources.rocket_20_1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ProgressBar1.FontColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(23, -6)
        Me.ProgressBar1.Maximum = 50
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProgressBar1.SecondColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ProgressBar1.Size = New System.Drawing.Size(148, 9)
        Me.ProgressBar1.TabIndex = 24
        Me.ProgressBar1.TwoColour = False
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'ShowMainWindowToolStripMenuItem
        '
        Me.ShowMainWindowToolStripMenuItem.Name = "ShowMainWindowToolStripMenuItem"
        Me.ShowMainWindowToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.ShowMainWindowToolStripMenuItem.Text = "Show Main Window"
        '
        'WinixTHEMEContextMenu1
        '
        Me.WinixTHEMEContextMenu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.WinixTHEMEContextMenu1.DropShadowEnabled = False
        Me.WinixTHEMEContextMenu1.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.WinixTHEMEContextMenu1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WinixTHEMEContextMenu1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WinixTHEMEContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowMainWindowToolStripMenuItem, Me.CloseAllToolStripMenuItem})
        Me.WinixTHEMEContextMenu1.Name = "WinixTHEMEContextMenu1"
        Me.WinixTHEMEContextMenu1.Size = New System.Drawing.Size(225, 52)
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.CloseAllToolStripMenuItem.Text = "Close All"
        '
        'formcleaner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(167, 27)
        Me.ContextMenuStrip = Me.WinixTHEMEContextMenu1
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblcpu)
        Me.Controls.Add(Me.lblram)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formcleaner"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Winix - MemoryCleaner"
        Me.WinixTHEMEContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblcpu As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblram As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As WinixTHEMEProgressBar
    Friend WithEvents ShowMainWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WinixTHEMEContextMenu1 As WinixTHEMEContextMenu
    Friend WithEvents CloseAllToolStripMenuItem As ToolStripMenuItem
End Class
