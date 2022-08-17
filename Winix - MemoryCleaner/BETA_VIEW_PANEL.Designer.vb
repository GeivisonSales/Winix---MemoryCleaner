<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BETA_VIEW_PANEL
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
        Me.betaview = New System.Windows.Forms.PictureBox()
        Me.NotificationBetaView = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.betaview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotificationBetaView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'betaview
        '
        Me.betaview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.betaview.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.UI_PATRONS
        Me.betaview.Location = New System.Drawing.Point(0, 0)
        Me.betaview.Name = "betaview"
        Me.betaview.Size = New System.Drawing.Size(434, 473)
        Me.betaview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.betaview.TabIndex = 0
        Me.betaview.TabStop = False
        '
        'NotificationBetaView
        '
        Me.NotificationBetaView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NotificationBetaView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotificationBetaView.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.UI_PATRONS_VIEW_INFORMATION
        Me.NotificationBetaView.Location = New System.Drawing.Point(0, 0)
        Me.NotificationBetaView.Name = "NotificationBetaView"
        Me.NotificationBetaView.Size = New System.Drawing.Size(434, 473)
        Me.NotificationBetaView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NotificationBetaView.TabIndex = 1
        Me.NotificationBetaView.TabStop = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(157, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Send Feedback"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BETA_VIEW_PANEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Controls.Add(Me.NotificationBetaView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.betaview)
        Me.Name = "BETA_VIEW_PANEL"
        Me.Size = New System.Drawing.Size(434, 473)
        CType(Me.betaview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotificationBetaView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents betaview As PictureBox
    Friend WithEvents NotificationBetaView As PictureBox
    Friend WithEvents Button1 As Button
End Class
