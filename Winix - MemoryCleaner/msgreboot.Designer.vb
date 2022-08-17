<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class msgreboot
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelads = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(90, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(254, 57)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Reboot"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(155, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 19)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Need Restart PC."
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(90, 306)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(254, 57)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Restart later."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.Restart_100px
        Me.PictureBox1.Location = New System.Drawing.Point(168, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 99)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'panelads
        '
        Me.panelads.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelads.ErrorImage = Global.Winix___MemoryCleaner.My.Resources.Resources.UI_ADS
        Me.panelads.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.UI_ADS
        Me.panelads.InitialImage = Global.Winix___MemoryCleaner.My.Resources.Resources.UI_ADS
        Me.panelads.Location = New System.Drawing.Point(19, 409)
        Me.panelads.Name = "panelads"
        Me.panelads.Size = New System.Drawing.Size(395, 56)
        Me.panelads.TabIndex = 30
        Me.panelads.TabStop = False
        '
        'msgreboot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Controls.Add(Me.panelads)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "msgreboot"
        Me.Size = New System.Drawing.Size(434, 473)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelads As PictureBox
End Class
