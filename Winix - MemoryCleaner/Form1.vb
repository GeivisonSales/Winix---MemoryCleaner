Imports System.ComponentModel
Imports System.IO
Imports System.Threading
Imports System.Net




Public Class Form1


    Public WithEvents Cliente As New WebClient
    ' Public Dir As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & "\WinixMemoryCleaner\"


    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByVal dwMinimumWorkingSetSize As Int32, ByVal dwMaximumWorkingSetSize As Int32) As Int32
    'mover form
    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Dim mover As MoveForm
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub
    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub


    'LoadAntigo - Ram
    Private Sub LoadAntigo()
        Processos.Icons.Images.Add(0, imgIcons.Images(0))
        'lwProcs.SmallImageList = Processos.Icons
        Processos.AddToListView(lwProcs, False)
        ' RamCPU.CPU_Load()
        'UsoMemoriaFisica_Progress.Maximum = ConverterEmMB(My.Computer.Info.TotalPhysicalMemory)
        '  UsoMemoriaVirtual_Progress.Maximum = ConverterEmMB(My.Computer.Info.TotalVirtualMemory)
        ' RamCPU.MemoriaRamLoad(UsoMemoriaFisica_Progress.Maximum, UsoMemoriaVirtual_Progress.Maximum)
    End Sub




    '----------------------------------------------------------------------------------------------------------------------------------------------------
    ' Public Shared Sub FlushMemory()
    '     GC.Collect()
    '     GC.WaitForPendingFinalizers()
    'If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
    '          SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
    ' End If
    ' End Sub
    '----------------------------------------------------------------------------------------------------------------------------------------------------

    'Optimiza pc





    'DIMINUI CPU E DISCO
    Friend Sub ReleaseMemory()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If Environment.OSVersion.Platform = PlatformID.Win32NT Then
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1)
            End If
        Catch ex As Exception
            IsError(ex.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim num As Double = 000

        'Processos.AddToListView(lwProcs, True)
        'ReleaseMemory()
        BackgroundWorker1.RunWorkerAsync()
        Button1.Enabled = False
        formcleaner.Button1.Enabled = False
        CleanRAMToolStripMenuItem.Enabled = False
        'formcleaner.CleanRAMToolStripMenuItem.Enabled = False
        ToolStripMenuItem1.Enabled = False
        Label4.Text = "[Cleaning...]"
        Label4.Visible = True
        ProgressBar1.Visible = True
        'formcleaner.ProgressBar1.Visible = True
        NotifyIcon1.Visible = False


        'num = ((My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory) * 100
        'TextBox1.Text = num
        ' TextBox1.Text = Format(num, "00.0" & " MB")
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SuspendLayout()

        Application.DoEvents()

        'CODIGO ---------------------------------------------------------------


        LoadAntigo()












        'If My.Computer.Info.OSFullName = "" Then
        'pcinfo.Visible = False
        'Panel2.Visible = False
        'Else
        'pcinfo.Text = My.Computer.Info.OSFullName
        'End If



        Me.ResumeLayout()

        'CONFIGS====================================

        'chk4
        If My.Settings.chk4 = True Then
            formcleaner.Show()

        ElseIf My.Settings.chk4 = False Then
            formcleaner.Hide()

        End If

        'chk5
        If My.Settings.chk5 = True Then
            My.Settings.chk5 = False
            formconfig.chk5.Checked = False
            'Form1.btnrefresh.Visible = True
        ElseIf My.Settings.chk5 = False Then
            'Form1.btnrefresh.Visible = False
        End If



        'Configs
        formconfig.chk1.Checked = My.Settings.chk1
        If My.Settings.chk1 = False Then
            formconfig.chk1.Checked = False

        ElseIf My.Settings.chk1 = True Then
            formconfig.chk1.Checked = True
        End If
        'formconfig.chk2.Checked = My.Settings.chk2
        formconfig.chk3.Checked = My.Settings.chk3
        formconfig.chk4.Checked = My.Settings.chk4
        formconfig.chk5.Checked = My.Settings.chk5

        'chk2------False

        'chk3
        If My.Settings.chk3 = True Then
            formcleaner.TopMost = True
            formcleaner.Close()
            formcleaner.Show()
        ElseIf My.Settings.chk3 = False Then
            formcleaner.TopMost = False
            formcleaner.Close()
            formcleaner.Show()
        End If


        'INITIALIZE THE INTERVAL OF THE TIMER TO 100.
        Timer1.Interval = 600
        'START THE TIMER
        Timer1.Start()


        Timer3.Interval = 100
        Timer3.Start()


        'VERIFICAR ATUALIZAÇÃO


        Try
            Dim Retorna As String = Cliente.DownloadString("https://pastebin.com/raw/RaHdkpdi")
            If (Retorna = Application.ProductVersion) = False Then
                'MsgBox("O programa quer atualização!")
                'Process.Start("wUpdater.exe")

                System.Diagnostics.Process.Start(Application.StartupPath & "\wUpdater.exe")
                Me.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lblcpu_Click(sender As Object, e As EventArgs) Handles lblcpu.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ramprogressbar.Value > 69 Then
            lblram.ForeColor = Color.FromArgb(231, 76, 60)
            formcleaner.lblram.ForeColor = Color.FromArgb(231, 76, 60)
            ramprogressbar.ProgressColour = Color.FromArgb(231, 76, 60)
        ElseIf ramprogressbar.Value < 68 Then
            lblram.ForeColor = Color.White()
            formcleaner.lblram.ForeColor = Color.White()
            ramprogressbar.ProgressColour = Color.FromArgb(1, 3, 47)

        End If

        If pb_cpu.Value > 70 Then
            lblcpu.ForeColor = Color.FromArgb(231, 76, 60)
            formcleaner.lblcpu.ForeColor = Color.FromArgb(231, 76, 60)
            pb_cpu.ProgressColour = Color.FromArgb(231, 76, 60)
        ElseIf pb_cpu.Value < 70 Then
            lblcpu.ForeColor = Color.White()
            formcleaner.lblcpu.ForeColor = Color.White()
            pb_cpu.ProgressColour = Color.FromArgb(1, 3, 47)
        End If

        'SET THE PERFORMANCE VALUE OF THE RAM AND CPU TO THE PROGESSBAR
        ' pb_cpu.Value = pc_CPU.NextValue
        pb_cpu.Value = pc_CPU.NextValue
        'SET THE PROGRESS BAR VALUE TO THE LABEL TO KNOW WHAT IS THE PERCENTAGE OF THE PROCESS.
        lblcpu.Text = pb_cpu.Value & "%"
        formcleaner.lblcpu.Text = pb_cpu.Value & "%"
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If My.Settings.chk1 = True Then
            ReleaseMemory()

        ElseIf My.Settings.chk1 = False Then

        End If


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'lblram.Text = My.Computer.Info.AvailablePhysicalMemory

        ramprogressbar.Value = ((My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory) * 100
        lblram.Text = ramprogressbar.Value & "%"
        formcleaner.lblram.Text = ramprogressbar.Value & "%"

        'TRIAL 1 DAY
        Dim dataDoSistema As String = DateTime.Now.ToString("ddMMyyyy")




        If My.Settings.ativo = True Then
            lbltest.Visible = True

            If dataDoSistema = "08052018" Then
                lbltest.Text = "1 day Ended"
                Me.Close()
            End If

        ElseIf My.Settings.ativo = False Then
            lbltest.Visible = False
            'Me.Close()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Label4.Visible = False
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Processos.AddToListView(lwProcs, False)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnconfig.Click
        formconfig.ShowDialog()
    End Sub

    Private Sub CleanRAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CleanRAMToolStripMenuItem.Click
        BackgroundWorker1.RunWorkerAsync()
        'Processos.AddToListView(lwProcs, True)
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        formconfig.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        formconfig.ShowDialog()
    End Sub

    Private Sub ShowMainWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMainWindowToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        BackgroundWorker1.RunWorkerAsync()
        'Processos.AddToListView(lwProcs, True)
        'ReleaseMemory()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Show()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork



        Processos.AddToListView(lwProcs, True)
        ReleaseMemory()

        For i = 0 To 50
            If BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True

                Exit For

            Else

                DoHeavyWork()
                BackgroundWorker1.ReportProgress(i)

            End If

        Next


    End Sub





    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object,
 ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) _
 Handles BackgroundWorker1.RunWorkerCompleted
        Label4.Visible = True
        Button1.Enabled = True
        formcleaner.Button1.Enabled = True
        CleanRAMToolStripMenuItem.Enabled = True
        'formcleaner.CleanRAMToolStripMenuItem.Enabled = True
        ToolStripMenuItem1.Enabled = True
        Label4.Text = "Cleaned: "
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
        formcleaner.ProgressBar1.Value = 0
        formcleaner.ProgressBar1.Visible = False
        ' ReleaseMemory()
        My.Settings.chk1 = True
        ' BackgroundWorker1.CancelAsync()
        NotifyIcon1.Visible = True
    End Sub



    Protected Overloads Overrides Function ProcessCmdKey(ByRef m As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Control Or Keys.L 'Ctrl + L
                'aqui vai o teu codigo para este atalho
                PremiumForm.Show()
                Hide()

                Return True
            Case Else
                Return False
        End Select
    End Function

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        formcleaner.ProgressBar1.Value = e.ProgressPercentage

    End Sub



    Public Sub DoHeavyWork()

        System.Threading.Thread.Sleep(3)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
