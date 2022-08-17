<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1New
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1New))
        Me.TitlePanelForm = New System.Windows.Forms.Panel()
        Me.ButtonClose = New System.Windows.Forms.PictureBox()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.WinixIcon = New System.Windows.Forms.PictureBox()
        Me.IconPanelForm = New System.Windows.Forms.Panel()
        Me.betaview_patrons = New System.Windows.Forms.PictureBox()
        Me.ButtonGamer = New System.Windows.Forms.PictureBox()
        Me.ButtonInfo = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.PictureBox()
        Me.ButtonSettings = New System.Windows.Forms.PictureBox()
        Me.ButtonHome = New System.Windows.Forms.PictureBox()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.HomePanel1 = New Winix___MemoryCleaner.HomePanel()
        Me.Msgreboot1 = New Winix___MemoryCleaner.msgreboot()
        Me.ConfigPanel1 = New Winix___MemoryCleaner.ConfigPanel()
        Me.GamerPanel1 = New Winix___MemoryCleaner.GamerPanel()
        Me.InfoPanel1 = New Winix___MemoryCleaner.InfoPanel()
        Me.BetA_VIEW_PANEL1 = New Winix___MemoryCleaner.BETA_VIEW_PANEL()
        Me.InformeBugsPanel1 = New Winix___MemoryCleaner.InformeBugsPanel()
        Me.MinePanel1 = New Winix___MemoryCleaner.MinePanel()
        Me.TitlePanelForm.SuspendLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinixIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IconPanelForm.SuspendLayout()
        CType(Me.betaview_patrons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonGamer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitlePanelForm
        '
        Me.TitlePanelForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.TitlePanelForm.Controls.Add(Me.ButtonClose)
        Me.TitlePanelForm.Controls.Add(Me.LabelVersion)
        Me.TitlePanelForm.Controls.Add(Me.LabelTitle)
        Me.TitlePanelForm.Controls.Add(Me.WinixIcon)
        Me.TitlePanelForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanelForm.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanelForm.Name = "TitlePanelForm"
        Me.TitlePanelForm.Size = New System.Drawing.Size(490, 59)
        Me.TitlePanelForm.TabIndex = 0
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.Button_Close
        Me.ButtonClose.Location = New System.Drawing.Point(447, 8)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(40, 40)
        Me.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ButtonClose.TabIndex = 8
        Me.ButtonClose.TabStop = False
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LabelVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.LabelVersion.Location = New System.Drawing.Point(63, 29)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(108, 17)
        Me.LabelVersion.TabIndex = 7
        Me.LabelVersion.Text = "v0.0 (Build 0. 0)"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LabelTitle.ForeColor = System.Drawing.Color.White
        Me.LabelTitle.Location = New System.Drawing.Point(63, 6)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(184, 20)
        Me.LabelTitle.TabIndex = 6
        Me.LabelTitle.Text = "Winix - MemoryCleaner"
        '
        'WinixIcon
        '
        Me.WinixIcon.BackColor = System.Drawing.Color.Transparent
        Me.WinixIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WinixIcon.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.UI_LOGO_5_40px
        Me.WinixIcon.Location = New System.Drawing.Point(10, 8)
        Me.WinixIcon.Name = "WinixIcon"
        Me.WinixIcon.Size = New System.Drawing.Size(40, 40)
        Me.WinixIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.WinixIcon.TabIndex = 5
        Me.WinixIcon.TabStop = False
        '
        'IconPanelForm
        '
        Me.IconPanelForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.IconPanelForm.Controls.Add(Me.betaview_patrons)
        Me.IconPanelForm.Controls.Add(Me.ButtonGamer)
        Me.IconPanelForm.Controls.Add(Me.ButtonInfo)
        Me.IconPanelForm.Controls.Add(Me.Button1)
        Me.IconPanelForm.Controls.Add(Me.ButtonSettings)
        Me.IconPanelForm.Controls.Add(Me.ButtonHome)
        Me.IconPanelForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.IconPanelForm.Location = New System.Drawing.Point(0, 59)
        Me.IconPanelForm.Name = "IconPanelForm"
        Me.IconPanelForm.Size = New System.Drawing.Size(56, 475)
        Me.IconPanelForm.TabIndex = 1
        '
        'betaview_patrons
        '
        Me.betaview_patrons.BackColor = System.Drawing.Color.Transparent
        Me.betaview_patrons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.betaview_patrons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.betaview_patrons.Enabled = False
        Me.betaview_patrons.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.Button_BETA_VIEW_1x
        Me.betaview_patrons.Location = New System.Drawing.Point(0, 363)
        Me.betaview_patrons.Name = "betaview_patrons"
        Me.betaview_patrons.Size = New System.Drawing.Size(56, 56)
        Me.betaview_patrons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.betaview_patrons.TabIndex = 8
        Me.betaview_patrons.TabStop = False
        '
        'ButtonGamer
        '
        Me.ButtonGamer.BackColor = System.Drawing.Color.White
        Me.ButtonGamer.Cursor = System.Windows.Forms.Cursors.No
        Me.ButtonGamer.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonGamer.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.Button_Gamer_Blocked
        Me.ButtonGamer.Location = New System.Drawing.Point(0, 168)
        Me.ButtonGamer.Name = "ButtonGamer"
        Me.ButtonGamer.Size = New System.Drawing.Size(56, 56)
        Me.ButtonGamer.TabIndex = 7
        Me.ButtonGamer.TabStop = False
        '
        'ButtonInfo
        '
        Me.ButtonInfo.BackColor = System.Drawing.Color.Transparent
        Me.ButtonInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonInfo.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.Button_Info
        Me.ButtonInfo.Location = New System.Drawing.Point(0, 419)
        Me.ButtonInfo.Name = "ButtonInfo"
        Me.ButtonInfo.Size = New System.Drawing.Size(56, 56)
        Me.ButtonInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ButtonInfo.TabIndex = 6
        Me.ButtonInfo.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.Registry_Editor_30px
        Me.Button1.Location = New System.Drawing.Point(0, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 56)
        Me.Button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Button1.TabIndex = 5
        Me.Button1.TabStop = False
        Me.Button1.Visible = False
        '
        'ButtonSettings
        '
        Me.ButtonSettings.BackColor = System.Drawing.Color.White
        Me.ButtonSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonSettings.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.NEW_Button_Settings
        Me.ButtonSettings.Location = New System.Drawing.Point(0, 56)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(56, 56)
        Me.ButtonSettings.TabIndex = 3
        Me.ButtonSettings.TabStop = False
        '
        'ButtonHome
        '
        Me.ButtonHome.BackColor = System.Drawing.Color.White
        Me.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonHome.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.NEW_Button_Home_Clicked
        Me.ButtonHome.Location = New System.Drawing.Point(0, 0)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(56, 56)
        Me.ButtonHome.TabIndex = 2
        Me.ButtonHome.TabStop = False
        '
        'PanelForm
        '
        Me.PanelForm.Controls.Add(Me.HomePanel1)
        Me.PanelForm.Controls.Add(Me.Msgreboot1)
        Me.PanelForm.Controls.Add(Me.ConfigPanel1)
        Me.PanelForm.Controls.Add(Me.GamerPanel1)
        Me.PanelForm.Controls.Add(Me.InfoPanel1)
        Me.PanelForm.Controls.Add(Me.BetA_VIEW_PANEL1)
        Me.PanelForm.Controls.Add(Me.InformeBugsPanel1)
        Me.PanelForm.Controls.Add(Me.MinePanel1)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(56, 59)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(434, 475)
        Me.PanelForm.TabIndex = 2
        '
        'HomePanel1
        '
        Me.HomePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.HomePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomePanel1.Location = New System.Drawing.Point(0, 0)
        Me.HomePanel1.Name = "HomePanel1"
        Me.HomePanel1.Size = New System.Drawing.Size(434, 475)
        Me.HomePanel1.TabIndex = 0
        '
        'Msgreboot1
        '
        Me.Msgreboot1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Msgreboot1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Msgreboot1.Location = New System.Drawing.Point(0, 0)
        Me.Msgreboot1.Name = "Msgreboot1"
        Me.Msgreboot1.Size = New System.Drawing.Size(434, 475)
        Me.Msgreboot1.TabIndex = 2
        '
        'ConfigPanel1
        '
        Me.ConfigPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ConfigPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfigPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ConfigPanel1.Name = "ConfigPanel1"
        Me.ConfigPanel1.Size = New System.Drawing.Size(434, 475)
        Me.ConfigPanel1.TabIndex = 1
        '
        'GamerPanel1
        '
        Me.GamerPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GamerPanel1.BackgroundImage = CType(resources.GetObject("GamerPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GamerPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GamerPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GamerPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GamerPanel1.Name = "GamerPanel1"
        Me.GamerPanel1.Size = New System.Drawing.Size(434, 475)
        Me.GamerPanel1.TabIndex = 5
        '
        'InfoPanel1
        '
        Me.InfoPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.InfoPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoPanel1.Location = New System.Drawing.Point(0, 0)
        Me.InfoPanel1.Name = "InfoPanel1"
        Me.InfoPanel1.Size = New System.Drawing.Size(434, 475)
        Me.InfoPanel1.TabIndex = 4
        '
        'BetA_VIEW_PANEL1
        '
        Me.BetA_VIEW_PANEL1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.BetA_VIEW_PANEL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BetA_VIEW_PANEL1.Location = New System.Drawing.Point(0, 0)
        Me.BetA_VIEW_PANEL1.Name = "BetA_VIEW_PANEL1"
        Me.BetA_VIEW_PANEL1.Size = New System.Drawing.Size(434, 475)
        Me.BetA_VIEW_PANEL1.TabIndex = 6
        '
        'InformeBugsPanel1
        '
        Me.InformeBugsPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.InformeBugsPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InformeBugsPanel1.Location = New System.Drawing.Point(0, 0)
        Me.InformeBugsPanel1.Name = "InformeBugsPanel1"
        Me.InformeBugsPanel1.Size = New System.Drawing.Size(434, 475)
        Me.InformeBugsPanel1.TabIndex = 7
        '
        'MinePanel1
        '
        Me.MinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.MinePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.MinePanel1.Name = "MinePanel1"
        Me.MinePanel1.Size = New System.Drawing.Size(434, 475)
        Me.MinePanel1.TabIndex = 8
        '
        'Form1New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(490, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.IconPanelForm)
        Me.Controls.Add(Me.TitlePanelForm)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1New"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Winix - MemoryCleaner"
        Me.TitlePanelForm.ResumeLayout(False)
        Me.TitlePanelForm.PerformLayout()
        CType(Me.ButtonClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinixIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IconPanelForm.ResumeLayout(False)
        CType(Me.betaview_patrons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonGamer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelForm.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitlePanelForm As Panel
    Friend WithEvents IconPanelForm As Panel
    Friend WithEvents ButtonSettings As PictureBox
    Friend WithEvents ButtonHome As PictureBox
    Friend WithEvents WinixIcon As PictureBox
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents ButtonClose As PictureBox
    Friend WithEvents PanelForm As Panel
    Friend WithEvents HomePanel1 As HomePanel
    Friend WithEvents ConfigPanel1 As ConfigPanel
    Friend WithEvents Msgreboot1 As msgreboot
    Friend WithEvents ButtonInfo As PictureBox
    Friend WithEvents InfoPanel1 As InfoPanel
    Friend WithEvents GamerPanel1 As GamerPanel
    Friend WithEvents ButtonGamer As PictureBox
    Friend WithEvents Button1 As PictureBox
    Friend WithEvents betaview_patrons As PictureBox
    Friend WithEvents BetA_VIEW_PANEL1 As BETA_VIEW_PANEL
    Friend WithEvents InformeBugsPanel1 As InformeBugsPanel
    Friend WithEvents MinePanel1 As MinePanel
End Class
