<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.WinixTHEMEContextMenu2 = New Winix___MemoryCleaner.WinixTHEMEContextMenu()
        Me.ShowMainWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnconfig = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lwProcs = New System.Windows.Forms.ListView()
        Me.coluna5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblcpu = New System.Windows.Forms.Label()
        Me.pc_CPU = New System.Diagnostics.PerformanceCounter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.imgIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.lblram = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pb_cpu = New Winix___MemoryCleaner.WinixTHEMEProgressBar()
        Me.ramprogressbar = New Winix___MemoryCleaner.WinixTHEMEProgressBar()
        Me.WinixTHEMEContextMenu1 = New Winix___MemoryCleaner.WinixTHEMEContextMenu()
        Me.CleanRAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar1 = New Winix___MemoryCleaner.WinixTHEMEProgressBar()
        Me.lbltest = New System.Windows.Forms.Label()
        Me.WinixTHEMEContextMenu2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pc_CPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WinixTHEMEContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.WinixTHEMEContextMenu2
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Winix | Double click to show program!"
        '
        'WinixTHEMEContextMenu2
        '
        Me.WinixTHEMEContextMenu2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.WinixTHEMEContextMenu2.DropShadowEnabled = False
        Me.WinixTHEMEContextMenu2.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.WinixTHEMEContextMenu2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WinixTHEMEContextMenu2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WinixTHEMEContextMenu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowMainWindowToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator2, Me.ToolStripMenuItem2, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.WinixTHEMEContextMenu2.Name = "WinixTHEMEContextMenu1"
        Me.WinixTHEMEContextMenu2.Size = New System.Drawing.Size(222, 112)
        '
        'ShowMainWindowToolStripMenuItem
        '
        Me.ShowMainWindowToolStripMenuItem.Name = "ShowMainWindowToolStripMenuItem"
        Me.ShowMainWindowToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ShowMainWindowToolStripMenuItem.Text = "Show main window"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.rocket_20_2
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(221, 24)
        Me.ToolStripMenuItem1.Text = "Clean RAM"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(218, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.settings_white
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(221, 24)
        Me.ToolStripMenuItem2.Text = "Options"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(218, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.close
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnconfig)
        Me.Panel1.Controls.Add(Me.btnrefresh)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 32)
        Me.Panel1.TabIndex = 4
        '
        'btnconfig
        '
        Me.btnconfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnconfig.BackgroundImage = Global.Winix___MemoryCleaner.My.Resources.Resources.settings_white
        Me.btnconfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnconfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnconfig.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnconfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnconfig.FlatAppearance.BorderSize = 0
        Me.btnconfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnconfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnconfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfig.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnconfig.ForeColor = System.Drawing.Color.White
        Me.btnconfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnconfig.Location = New System.Drawing.Point(194, 0)
        Me.btnconfig.Name = "btnconfig"
        Me.btnconfig.Size = New System.Drawing.Size(30, 32)
        Me.btnconfig.TabIndex = 16
        Me.btnconfig.UseVisualStyleBackColor = False
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnrefresh.BackgroundImage = Global.Winix___MemoryCleaner.My.Resources.Resources.refresh
        Me.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnrefresh.Enabled = False
        Me.btnrefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnrefresh.FlatAppearance.BorderSize = 0
        Me.btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnrefresh.ForeColor = System.Drawing.Color.White
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.Location = New System.Drawing.Point(224, 0)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(30, 32)
        Me.btnrefresh.TabIndex = 15
        Me.btnrefresh.UseVisualStyleBackColor = False
        Me.btnrefresh.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button3.BackgroundImage = Global.Winix___MemoryCleaner.My.Resources.Resources.close
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(254, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 32)
        Me.Button3.TabIndex = 14
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Winix - MemoryCleaner"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lwProcs
        '
        Me.lwProcs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.coluna5, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lwProcs.Location = New System.Drawing.Point(261, 37)
        Me.lwProcs.Name = "lwProcs"
        Me.lwProcs.Size = New System.Drawing.Size(23, 21)
        Me.lwProcs.TabIndex = 8
        Me.lwProcs.UseCompatibleStateImageBehavior = False
        Me.lwProcs.View = System.Windows.Forms.View.Details
        Me.lwProcs.Visible = False
        '
        'coluna5
        '
        Me.coluna5.DisplayIndex = 4
        Me.coluna5.Text = "ID"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 0
        Me.ColumnHeader1.Text = "Processos"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 1
        Me.ColumnHeader2.Text = "Caption"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 2
        Me.ColumnHeader3.Text = "Memoria"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 3
        Me.ColumnHeader4.Text = "Diferencial"
        '
        'lblcpu
        '
        Me.lblcpu.AutoSize = True
        Me.lblcpu.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblcpu.ForeColor = System.Drawing.Color.White
        Me.lblcpu.Location = New System.Drawing.Point(62, 66)
        Me.lblcpu.Name = "lblcpu"
        Me.lblcpu.Size = New System.Drawing.Size(24, 17)
        Me.lblcpu.TabIndex = 5
        Me.lblcpu.Text = "0%"
        Me.lblcpu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pc_CPU
        '
        Me.pc_CPU.CategoryName = "Processor"
        Me.pc_CPU.CounterName = "% Processor Time"
        Me.pc_CPU.InstanceName = "_Total"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 4000
        '
        'imgIcons
        '
        Me.imgIcons.ImageStream = CType(resources.GetObject("imgIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIcons.Images.SetKeyName(0, "userLogo.png")
        '
        'lblram
        '
        Me.lblram.AutoSize = True
        Me.lblram.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblram.ForeColor = System.Drawing.Color.White
        Me.lblram.Location = New System.Drawing.Point(62, 45)
        Me.lblram.Name = "lblram"
        Me.lblram.Size = New System.Drawing.Size(24, 17)
        Me.lblram.TabIndex = 9
        Me.lblram.Text = "0%"
        Me.lblram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer3
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "RAM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "CPU"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Winix___MemoryCleaner.My.Resources.Resources.ram
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(40, 43)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Winix___MemoryCleaner.My.Resources.Resources.cpu
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(40, 64)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.rocket_52
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(284, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "RAM Booster"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "..."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'pb_cpu
        '
        Me.pb_cpu.BaseColour = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.pb_cpu.BorderColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.pb_cpu.FontColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pb_cpu.Location = New System.Drawing.Point(96, 70)
        Me.pb_cpu.Maximum = 100
        Me.pb_cpu.Name = "pb_cpu"
        Me.pb_cpu.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pb_cpu.SecondColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.pb_cpu.Size = New System.Drawing.Size(164, 9)
        Me.pb_cpu.TabIndex = 21
        Me.pb_cpu.TwoColour = False
        Me.pb_cpu.Value = 0
        '
        'ramprogressbar
        '
        Me.ramprogressbar.BaseColour = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.ramprogressbar.BorderColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ramprogressbar.FontColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ramprogressbar.Location = New System.Drawing.Point(96, 49)
        Me.ramprogressbar.Maximum = 100
        Me.ramprogressbar.Name = "ramprogressbar"
        Me.ramprogressbar.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ramprogressbar.SecondColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ramprogressbar.Size = New System.Drawing.Size(164, 9)
        Me.ramprogressbar.TabIndex = 20
        Me.ramprogressbar.TwoColour = False
        Me.ramprogressbar.Value = 0
        '
        'WinixTHEMEContextMenu1
        '
        Me.WinixTHEMEContextMenu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.WinixTHEMEContextMenu1.DropShadowEnabled = False
        Me.WinixTHEMEContextMenu1.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.WinixTHEMEContextMenu1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WinixTHEMEContextMenu1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WinixTHEMEContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CleanRAMToolStripMenuItem, Me.ToolStripSeparator1, Me.OptionsToolStripMenuItem})
        Me.WinixTHEMEContextMenu1.Name = "WinixTHEMEContextMenu1"
        Me.WinixTHEMEContextMenu1.Size = New System.Drawing.Size(162, 58)
        '
        'CleanRAMToolStripMenuItem
        '
        Me.CleanRAMToolStripMenuItem.Enabled = False
        Me.CleanRAMToolStripMenuItem.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.rocket_20_2
        Me.CleanRAMToolStripMenuItem.Name = "CleanRAMToolStripMenuItem"
        Me.CleanRAMToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.CleanRAMToolStripMenuItem.Text = "Clean RAM"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Image = Global.Winix___MemoryCleaner.My.Resources.Resources.settings_white
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(161, 24)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ProgressBar1.FontColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 27)
        Me.ProgressBar1.Maximum = 50
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProgressBar1.SecondColour = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ProgressBar1.Size = New System.Drawing.Size(284, 9)
        Me.ProgressBar1.TabIndex = 23
        Me.ProgressBar1.TwoColour = False
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Visible = False
        '
        'lbltest
        '
        Me.lbltest.AutoSize = True
        Me.lbltest.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.lbltest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lbltest.Location = New System.Drawing.Point(186, 84)
        Me.lbltest.Name = "lbltest"
        Me.lbltest.Size = New System.Drawing.Size(77, 19)
        Me.lbltest.TabIndex = 24
        Me.lbltest.Text = "1 day Test"
        Me.lbltest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbltest.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 143)
        Me.ContextMenuStrip = Me.WinixTHEMEContextMenu1
        Me.Controls.Add(Me.lbltest)
        Me.Controls.Add(Me.pb_cpu)
        Me.Controls.Add(Me.ramprogressbar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lwProcs)
        Me.Controls.Add(Me.lblram)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblcpu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Winix - MemoryCleaner"
        Me.WinixTHEMEContextMenu2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pc_CPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WinixTHEMEContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblcpu As Label
    Friend WithEvents pc_CPU As PerformanceCounter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lwProcs As ListView
    Friend WithEvents coluna5 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents imgIcons As ImageList
    Friend WithEvents lblram As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btnconfig As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ramprogressbar As WinixTHEMEProgressBar
    Friend WithEvents pb_cpu As WinixTHEMEProgressBar
    Friend WithEvents WinixTHEMEContextMenu1 As WinixTHEMEContextMenu
    Friend WithEvents CleanRAMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WinixTHEMEContextMenu2 As WinixTHEMEContextMenu
    Friend WithEvents ShowMainWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgressBar1 As WinixTHEMEProgressBar
    Friend WithEvents lbltest As Label
End Class
