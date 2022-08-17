<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinePanel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gift_validation = New System.Windows.Forms.Label()
        Me.btn_sobre = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_download = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_sobre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_download, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Winix___MemoryCleaner.My.Resources.Resources.UI_MINE_SOURCE_FORM
        Me.Panel1.Controls.Add(Me.gift_validation)
        Me.Panel1.Controls.Add(Me.btn_sobre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_download)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 473)
        Me.Panel1.TabIndex = 0
        '
        'gift_validation
        '
        Me.gift_validation.AutoSize = True
        Me.gift_validation.BackColor = System.Drawing.Color.Transparent
        Me.gift_validation.Dock = System.Windows.Forms.DockStyle.Top
        Me.gift_validation.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gift_validation.ForeColor = System.Drawing.Color.White
        Me.gift_validation.Location = New System.Drawing.Point(0, 0)
        Me.gift_validation.Name = "gift_validation"
        Me.gift_validation.Size = New System.Drawing.Size(37, 17)
        Me.gift_validation.TabIndex = 3
        Me.gift_validation.Text = "Gift:"
        '
        'btn_sobre
        '
        Me.btn_sobre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sobre.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.UI_MINE_ABOUT_US
        Me.btn_sobre.Location = New System.Drawing.Point(81, 365)
        Me.btn_sobre.Name = "btn_sobre"
        Me.btn_sobre.Size = New System.Drawing.Size(272, 60)
        Me.btn_sobre.TabIndex = 2
        Me.btn_sobre.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(181, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 1
        '
        'btn_download
        '
        Me.btn_download.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_download.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.UI_MINE_DOWNLOAD
        Me.btn_download.Location = New System.Drawing.Point(81, 298)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(272, 60)
        Me.btn_download.TabIndex = 0
        Me.btn_download.TabStop = False
        '
        'MinePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MinePanel"
        Me.Size = New System.Drawing.Size(434, 473)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_sobre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_download, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_sobre As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_download As PictureBox
    Friend WithEvents gift_validation As Label
End Class
