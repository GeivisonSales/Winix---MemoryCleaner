<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblporcentagem = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblversion = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.updaterfree = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(49, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PENDING UPDATE"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(375, 34)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(105, 15)
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Visible = False
        '
        'lblporcentagem
        '
        Me.lblporcentagem.AutoSize = True
        Me.lblporcentagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblporcentagem.ForeColor = System.Drawing.Color.Silver
        Me.lblporcentagem.Location = New System.Drawing.Point(372, 18)
        Me.lblporcentagem.Name = "lblporcentagem"
        Me.lblporcentagem.Size = New System.Drawing.Size(22, 13)
        Me.lblporcentagem.TabIndex = 2
        Me.lblporcentagem.Text = "0%"
        Me.lblporcentagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblporcentagem.Visible = False
        '
        'Timer1
        '
        '
        'lblversion
        '
        Me.lblversion.AutoSize = True
        Me.lblversion.BackColor = System.Drawing.Color.Transparent
        Me.lblversion.Font = New System.Drawing.Font("Century Gothic", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblversion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblversion.Location = New System.Drawing.Point(111, 135)
        Me.lblversion.Name = "lblversion"
        Me.lblversion.Size = New System.Drawing.Size(0, 16)
        Me.lblversion.TabIndex = 3
        Me.lblversion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer2
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(52, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "DO NOT UPDATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(198, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 29)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "UPDATE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'updaterfree
        '
        Me.updaterfree.WorkerReportsProgress = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.wmcUpdater.My.Resources.Resources.UI_UPDATING_FORM_2
        Me.ClientSize = New System.Drawing.Size(326, 160)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblversion)
        Me.Controls.Add(Me.lblporcentagem)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WMCLEANER - UPDATER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblporcentagem As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblversion As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents updaterfree As System.ComponentModel.BackgroundWorker
End Class
