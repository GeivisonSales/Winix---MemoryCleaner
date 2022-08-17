<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeBugsPanel
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
        Me.PanelRam = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ticketbug = New Winix___MemoryCleaner.WinixTHEMENormalTextBox()
        Me.Combo_Rate = New Winix___MemoryCleaner.WinixTHEMEComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_name = New Winix___MemoryCleaner.WinixTHEMENormalTextBox()
        Me.lbl_youremail = New System.Windows.Forms.Label()
        Me.txt_email = New Winix___MemoryCleaner.WinixTHEMENormalTextBox()
        Me.LabelBug = New System.Windows.Forms.Label()
        Me.PanelRamLine = New System.Windows.Forms.Panel()
        Me.btn_sendticketbug = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelRam.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRam
        '
        Me.PanelRam.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PanelRam.Controls.Add(Me.Label3)
        Me.PanelRam.Controls.Add(Me.Label2)
        Me.PanelRam.Controls.Add(Me.txt_ticketbug)
        Me.PanelRam.Controls.Add(Me.Combo_Rate)
        Me.PanelRam.Controls.Add(Me.Label1)
        Me.PanelRam.Controls.Add(Me.txt_name)
        Me.PanelRam.Controls.Add(Me.lbl_youremail)
        Me.PanelRam.Controls.Add(Me.txt_email)
        Me.PanelRam.Controls.Add(Me.LabelBug)
        Me.PanelRam.Controls.Add(Me.PanelRamLine)
        Me.PanelRam.Location = New System.Drawing.Point(51, 26)
        Me.PanelRam.Name = "PanelRam"
        Me.PanelRam.Size = New System.Drawing.Size(324, 357)
        Me.PanelRam.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Explain the Problem / Bug:*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(162, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Rate Software:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_ticketbug
        '
        Me.txt_ticketbug.BackColor = System.Drawing.Color.Transparent
        Me.txt_ticketbug.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txt_ticketbug.BorderColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ticketbug.Location = New System.Drawing.Point(16, 170)
        Me.txt_ticketbug.MaxLength = 32767
        Me.txt_ticketbug.Multiline = True
        Me.txt_ticketbug.Name = "txt_ticketbug"
        Me.txt_ticketbug.ReadOnly = False
        Me.txt_ticketbug.Size = New System.Drawing.Size(283, 163)
        Me.txt_ticketbug.Style = Winix___MemoryCleaner.WinixTHEMENormalTextBox.Styles.NotRounded
        Me.txt_ticketbug.TabIndex = 9
        Me.txt_ticketbug.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ticketbug.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ticketbug.UseSystemPasswordChar = False
        '
        'Combo_Rate
        '
        Me.Combo_Rate.ArrowColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Combo_Rate.BackColor = System.Drawing.Color.Transparent
        Me.Combo_Rate.BaseColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Combo_Rate.BorderColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Combo_Rate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Combo_Rate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Rate.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Combo_Rate.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Combo_Rate.FormattingEnabled = True
        Me.Combo_Rate.Items.AddRange(New Object() {"I loved it", "Liked it", "Good", "Did not like", "I hated", "Solved my problem"})
        Me.Combo_Rate.LineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Combo_Rate.Location = New System.Drawing.Point(165, 119)
        Me.Combo_Rate.Name = "Combo_Rate"
        Me.Combo_Rate.Size = New System.Drawing.Size(134, 23)
        Me.Combo_Rate.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Combo_Rate.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Combo_Rate.StartIndex = 0
        Me.Combo_Rate.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Your Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.Transparent
        Me.txt_name.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txt_name.BorderColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.Location = New System.Drawing.Point(16, 116)
        Me.txt_name.MaxLength = 32767
        Me.txt_name.Multiline = False
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = False
        Me.txt_name.Size = New System.Drawing.Size(142, 29)
        Me.txt_name.Style = Winix___MemoryCleaner.WinixTHEMENormalTextBox.Styles.NotRounded
        Me.txt_name.TabIndex = 6
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_name.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.UseSystemPasswordChar = False
        '
        'lbl_youremail
        '
        Me.lbl_youremail.AutoSize = True
        Me.lbl_youremail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_youremail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lbl_youremail.Location = New System.Drawing.Point(13, 46)
        Me.lbl_youremail.Name = "lbl_youremail"
        Me.lbl_youremail.Size = New System.Drawing.Size(81, 16)
        Me.lbl_youremail.TabIndex = 5
        Me.lbl_youremail.Text = "Your Email:*"
        Me.lbl_youremail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.Transparent
        Me.txt_email.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.txt_email.BorderColour = System.Drawing.Color.White
        Me.txt_email.Location = New System.Drawing.Point(16, 65)
        Me.txt_email.MaxLength = 32767
        Me.txt_email.Multiline = False
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ReadOnly = False
        Me.txt_email.Size = New System.Drawing.Size(283, 29)
        Me.txt_email.Style = Winix___MemoryCleaner.WinixTHEMENormalTextBox.Styles.NotRounded
        Me.txt_email.TabIndex = 4
        Me.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_email.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.UseSystemPasswordChar = False
        '
        'LabelBug
        '
        Me.LabelBug.AutoSize = True
        Me.LabelBug.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.LabelBug.ForeColor = System.Drawing.Color.White
        Me.LabelBug.Location = New System.Drawing.Point(12, 11)
        Me.LabelBug.Name = "LabelBug"
        Me.LabelBug.Size = New System.Drawing.Size(154, 20)
        Me.LabelBug.TabIndex = 3
        Me.LabelBug.Text = "REPORT A BUG!"
        Me.LabelBug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelRamLine
        '
        Me.PanelRamLine.BackColor = System.Drawing.Color.DarkGray
        Me.PanelRamLine.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelRamLine.Location = New System.Drawing.Point(0, 352)
        Me.PanelRamLine.Name = "PanelRamLine"
        Me.PanelRamLine.Size = New System.Drawing.Size(324, 5)
        Me.PanelRamLine.TabIndex = 1
        '
        'btn_sendticketbug
        '
        Me.btn_sendticketbug.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btn_sendticketbug.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sendticketbug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btn_sendticketbug.FlatAppearance.BorderSize = 0
        Me.btn_sendticketbug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btn_sendticketbug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btn_sendticketbug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sendticketbug.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btn_sendticketbug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btn_sendticketbug.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sendticketbug.Location = New System.Drawing.Point(51, 395)
        Me.btn_sendticketbug.Name = "btn_sendticketbug"
        Me.btn_sendticketbug.Size = New System.Drawing.Size(324, 45)
        Me.btn_sendticketbug.TabIndex = 28
        Me.btn_sendticketbug.Text = "SEND TICKET"
        Me.btn_sendticketbug.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(144, 443)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "support@wmcleaner.site"
        '
        'InformeBugsPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_sendticketbug)
        Me.Controls.Add(Me.PanelRam)
        Me.Name = "InformeBugsPanel"
        Me.Size = New System.Drawing.Size(434, 473)
        Me.PanelRam.ResumeLayout(False)
        Me.PanelRam.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelRam As Panel
    Friend WithEvents PanelRamLine As Panel
    Friend WithEvents txt_email As WinixTHEMENormalTextBox
    Friend WithEvents LabelBug As Label
    Friend WithEvents lbl_youremail As Label
    Friend WithEvents Combo_Rate As WinixTHEMEComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name As WinixTHEMENormalTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ticketbug As WinixTHEMENormalTextBox
    Friend WithEvents btn_sendticketbug As Button
    Friend WithEvents Label4 As Label
End Class
