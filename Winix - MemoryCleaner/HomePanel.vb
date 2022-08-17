Imports System.ComponentModel
Imports System.IO
Imports System.Threading
Imports System.Net
Imports Microsoft.Win32

Public Class HomePanel


    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByVal dwMinimumWorkingSetSize As Int32, ByVal dwMaximumWorkingSetSize As Int32) As Int32

    Dim PorcentagemMaior
    Dim PorcentagemMenor
    Dim porcentagemTotal
    Dim Valor
    Dim ValorPorc = 0
    Dim total As Integer
    Dim MemoriaLiberada


    Dim dataDoSistema As String = DateTime.Now.ToString("yyyy-MM-dd")

    Public WithEvents Cliente As New WebClient



    Private Sub ads()
        Dim AdImg As String = Cliente.DownloadString("https://pastebin.com/raw/S53R00mC")
        Dim AdLink As String = Cliente.DownloadString("https://pastebin.com/raw/JNmXuM84")


        If AdImg = "..." Then

        Else
            panelads.ImageLocation = AdImg

        End If


        Dim wClient As New WebClient
        ' wClient.OpenRead("http://50xrrsamd7cwjitqgenaccsserver.96.lt/winixmemorycleaner/userscounter/count.php?action=add")


    End Sub



    Public Sub ChamarPopup()
        If PopUpRam.IsHandleCreated Then
            PopUpRam.Close()
            PopUpRam.Show()
        Else
            PopUpRam.Show()
        End If
        PopUpRam.Left = My.Computer.Screen.WorkingArea.Width - 250
        PopUpRam.Top = My.Computer.Screen.WorkingArea.Height - 100
    End Sub



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




    Private Sub TimerCPU_Tick(sender As Object, e As EventArgs) Handles TimerCPU.Tick
        'SET THE PERFORMANCE VALUE OF THE RAM AND CPU TO THE PROGESSBAR
        ' pb_cpu.Value = pc_CPU.NextValue
        pb_cpu.Value = pc_CPU.NextValue
        'SET THE PROGRESS BAR VALUE TO THE LABEL TO KNOW WHAT IS THE PERCENTAGE OF THE PROCESS.
        lblcpu.Text = pb_cpu.Value & "%"
        formcleaner.lblcpu.Text = pb_cpu.Value & "%"
    End Sub

    Private Sub TimerRAM_Tick(sender As Object, e As EventArgs) Handles TimerRAM.Tick
        'lblram.Text = My.Computer.Info.AvailablePhysicalMemory

        ramprogressbar.Value = ((My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory) * 100
        lblram.Text = ramprogressbar.Value & "%"
        formcleaner.lblram.Text = ramprogressbar.Value & "%"

    End Sub

    Private Sub TimerReleaseMemory_Tick(sender As Object, e As EventArgs) Handles TimerReleaseMemory.Tick
        If My.Settings.chk1 = True Then
            ReleaseMemory()

        ElseIf My.Settings.chk1 = False Then

        End If
    End Sub

    Private Sub HomePanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadAntigo()

        'INITIALIZE THE INTERVAL OF THE TIMER TO 100.
        'ProgressColors.Interval = 10
        'START THE TIMER
        'ProgressColors.Start()
        'progresscolorsCPU.Interval = 10
        'START THE TIMER
        'progresscolorsCPU.Start()


        If My.Computer.Network.IsAvailable = True Then
            Try
                If My.Computer.Network.Ping("www.google.com", 10) Then
                    ads()
                End If
            Catch ex As Exception
                ' MsgBox("Nao ha acesso a internet", MsgBoxStyle.Critical)
            End Try
        End If


        TimerRAM.Interval = 100
        TimerRAM.Start()


        TimerCPU.Start()
        'Iniciar antes do timer
        pb_cpu.Value = pc_CPU.NextValue
        lblcpu.Text = pb_cpu.Value & "%"
        formcleaner.lblcpu.Text = pb_cpu.Value & "%"




        'VERIFICAR ADMINISTRADOR
        'If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
        'Button2.Enabled = True
        'Else
        'Button2.Enabled = False

        'End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PorcentagemMaior = ramprogressbar.Value

        ' Dim num As Double = 000

        'Processos.AddToListView(lwProcs, True)
        'ReleaseMemory()
        BackgroundWorker1.RunWorkerAsync()
        Button1.Enabled = False
        formcleaner.Button1.Enabled = False
        'CleanRAMToolStripMenuItem.Enabled = False
        'formcleaner.CleanRAMToolStripMenuItem.Enabled = False
        'ToolStripMenuItem1.Enabled = False
        'Label4.Text = "[Cleaning...]"
        'Label4.Visible = True
        ProgressBar1.Visible = True
        'formcleaner.ProgressBar1.Visible = True
        'NotifyIcon1.Visible = False


        'num = ((My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory) * 100
        'TextBox1.Text = num
        ' TextBox1.Text = Format(num, "00.0" & " MB")
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
        'Label4.Visible = True
        Button1.Enabled = True
        formcleaner.Button1.Enabled = True
        'CleanRAMToolStripMenuItem.Enabled = True
        'formcleaner.CleanRAMToolStripMenuItem.Enabled = True
        'ToolStripMenuItem1.Enabled = True
        'Label4.Text = "Cleaned: "
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
        formcleaner.ProgressBar1.Value = 0
        formcleaner.ProgressBar1.Visible = False
        ' ReleaseMemory()
        My.Settings.chk1 = True
        ' BackgroundWorker1.CancelAsync()
        'NotifyIcon1.Visible = True


        'Calculo
        PorcentagemMenor = ramprogressbar.Value
        porcentagemTotal = PorcentagemMaior - PorcentagemMenor

        total = Val(My.Computer.Info.TotalPhysicalMemory) / 1024 / 1024

        MemoriaLiberada = (Int(Val(My.Computer.Info.AvailablePhysicalMemory) / 1024 / 1024))

        lblMemoriaDisponivel.Text = (Int(Val(My.Computer.Info.AvailablePhysicalMemory) / 1024 / 1024)) & " MB"
        Valor = FormatNumber(MemoriaLiberada / 100 * porcentagemTotal, 2)
        PopUpRam.Label1.Text = Valor & " MB"

        If Valor <= 0 Then

        Else
            ChamarPopup()
        End If


    End Sub


    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        formcleaner.ProgressBar1.Value = e.ProgressPercentage

    End Sub



    Public Sub DoHeavyWork()

        System.Threading.Thread.Sleep(3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim horadoSistema As String = DateTime.Now.ToString("HH-mm-ss") & ".SavedLog"

        'CODIGO SALVAR REGISTRO================================
        System.IO.Directory.CreateDirectory("c:\WinixMCleaner\SavedLog\" & dataDoSistema)
        System.Diagnostics.Process.Start("Regedit.exe", "/e c:\WinixMCleaner\SavedLog\" & dataDoSistema & "\" & horadoSistema & ".reg" & " HKEY_LOCAL_MACHINE\SOFTWARE\microsoft\Windows\currentversion")
        'Process.Start("explorer.exe", "c:\WinixMCleaner\savesreg\")
        Form1New.Button1.Visible = True
        TimerSpeedWindows.Start()
        '======================================================
    End Sub

    Private Sub TimerSpeedWindows_Tick(sender As Object, e As EventArgs) Handles TimerSpeedWindows.Tick
        'Timer1.Stop()
        Timer2.Start()
        'Label1.Visible = True
        'Label2.Visible = True



        If CheckBox1.Checked = True Then
            Dim itm8 As New ListViewItem("DisablePagingExecutive")
            itm8.SubItems.Add("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management")
            ListView1.Items.Add(itm8)
            itm8.ImageIndex = 1
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management", "DisablePagingExecutive", 1, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        If CheckBox2.Checked = True Then
            Dim itm7 As New ListViewItem("WindowArrangementActive")
            itm7.SubItems.Add("HKEY_CURRENT_USER\Control Panel\Desktop")
            ListView1.Items.Add(itm7)
            itm7.ImageIndex = 1
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop", "WindowArrangementActive", 0, Microsoft.Win32.RegistryValueKind.String)
        End If

        If CheckBox3.Checked = True Then
            Dim itm9 As New ListViewItem("MenuShowDelay")
            itm9.SubItems.Add("HKEY_CURRENT_USER\Control Panel\Desktop")
            ListView1.Items.Add(itm9)
            itm9.ImageIndex = 1
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Desktop\", "MenuShowDelay", 0, Microsoft.Win32.RegistryValueKind.String)
        End If

        If CheckBox4.Checked = True Then
            Dim itm10 As New ListViewItem("AlwaysUnloadDLL")
            itm10.SubItems.Add("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer")
            ListView1.Items.Add(itm10)
            itm10.ImageIndex = 2
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer", "AlwaysUnloadDLL", 1, Microsoft.Win32.RegistryValueKind.String)
        End If

        If CheckBox5.Checked = True Then
            Dim itm53 As New ListViewItem("TCPNoDelay")
            itm53.SubItems.Add("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSMQ\Parameters")
            ListView1.Items.Add(itm53)
            itm53.ImageIndex = 2
            Dim regKey As RegistryKey
            regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\MSMQ", True)
            regKey.CreateSubKey("Parameters")
            regKey.Close()
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSMQ\Parameters", "TCPNoDelay", 1, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        If CheckBox6.Checked = True Then
            Dim itm19 As New ListViewItem("AutoRepeatDelay")
            itm19.SubItems.Add("HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response")
            ListView1.Items.Add(itm19)
            itm19.ImageIndex = 1
            Dim itm20 As New ListViewItem("AutoRepeatRate")
            itm20.SubItems.Add("HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response")
            ListView1.Items.Add(itm20)
            itm20.ImageIndex = 1
            Dim itm21 As New ListViewItem("BounceTime")
            itm21.SubItems.Add("HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response")
            ListView1.Items.Add(itm21)
            itm21.ImageIndex = 1
            Dim itm22 As New ListViewItem("DelayBeforeAcceptance")
            itm22.SubItems.Add("HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response")
            ListView1.Items.Add(itm22)
            itm22.ImageIndex = 1
            Dim itm23 As New ListViewItem("Flags")
            itm23.SubItems.Add("HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response")
            ListView1.Items.Add(itm23)
            itm23.ImageIndex = 1
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response", "AutoRepeatDelay", 200, Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response", "AutoRepeatRate", 15, Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response", "BounceTime", 0, Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response", "DelayBeforeAcceptance", 0, Microsoft.Win32.RegistryValueKind.String)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Control Panel\Accessibility\Keyboard Response", "Flags", 59, Microsoft.Win32.RegistryValueKind.String)
        End If

        If CheckBox7.Checked = True Then
            Dim itm29 As New ListViewItem("MaximumTransferLength")
            itm29.SubItems.Add("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\usbstor")
            ListView1.Items.Add(itm29)
            itm29.ImageIndex = 2
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\usbstor", "MaximumTransferLength", 2097120, Microsoft.Win32.RegistryValueKind.DWord)
        End If

        If CheckBox8.Checked = True Then
            Dim itm34 As New ListViewItem("net stop uxsms")
            itm34.SubItems.Add("CMD")
            ListView1.Items.Add(itm34)
            itm34.ImageIndex = 4
            Shell("net stop uxsms", AppWinStyle.Hide)
        End If

        If CheckBox9.Checked = True Then
            Dim itm30 As New ListViewItem("netsh int tcp set global congestionprovider=ctcp")
            itm30.SubItems.Add("CMD")
            ListView1.Items.Add(itm30)
            itm30.ImageIndex = 4
            Dim itm31 As New ListViewItem("netsh int tcp set global dca=enabled")
            itm31.SubItems.Add("CMD")
            ListView1.Items.Add(itm31)
            itm31.ImageIndex = 4
            Dim itm32 As New ListViewItem("netsh int tcp set global ecncapability=enabled")
            itm32.SubItems.Add("CMD")
            ListView1.Items.Add(itm32)
            itm32.ImageIndex = 4
            Dim itm33 As New ListViewItem("netsh int tcp set global chimney=enabled")
            itm33.SubItems.Add("CMD")
            ListView1.Items.Add(itm33)
        End If

        If CheckBox10.Checked = True Then
            Try
                Dim arrStr As String() = {}
                arrStr = System.IO.Directory.GetFiles("C:\Windows\Temp", "*.*")
                For i As Integer = 0 To arrStr.Length - 1
                    Try
                        System.IO.File.Delete(arrStr(i))
                    Catch ExIO As Exception
                        Debug.Print(ExIO.Message)
                    End Try
                Next i
            Catch ExIO As IOException

                MsgBox(ExIO.Message)
            End Try
        End If

        If CheckBox11.Checked = True Then
            Try
                Dim arrStr As String() = {}
                arrStr = System.IO.Directory.GetFiles("C:\Windows\Prefetch", "*.*")
                For i As Integer = 0 To arrStr.Length - 1
                    Try
                        System.IO.File.Delete(arrStr(i))
                    Catch ExIO As Exception
                        Debug.Print(ExIO.Message)
                    End Try
                Next i
            Catch ExIO As IOException

                MsgBox(ExIO.Message)
            End Try
        End If

        'Advanced Settings===================================================================================

        If chk2.Checked = True Then
            Shell("net stop WinDefend", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk3.Checked = True Then
            Shell("net stop WSearch", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk4.Checked = True Then
            Shell("net stop wuauserv", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk5.Checked = True Then
            Shell("net stop Spooler", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk6.Checked = True Then
            Shell("net stop SCardSvr", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk7.Checked = True Then
            Shell("net stop wscsvc", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk8.Checked = True Then
            Shell("net stop seclogon", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk9.Checked = True Then
            Shell("net stop SensrSvc", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk10.Checked = True Then
            Shell("net stop RemoteAccess", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk11.Checked = True Then
            Shell("net stop CryptSvc", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk12.Checked = True Then
            Shell("net stop WerSvc", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk13.Checked = True Then
            Shell("net stop MpsSvc", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk14.Checked = True Then
            Shell("net stop stisvc", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk15.Checked = True Then
            Shell("net stop SharedAccess", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk16.Checked = True Then
            Shell("net Stop WbioSrvc", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk17.Checked = True Then
            Shell("net Stop ehSched", AppWinStyle.Hide, True)
        End If
        '---------------------
        If chk18.Checked = True Then
            Shell("net stop SysMain", AppWinStyle.Hide, True)
        End If
        If network1.Checked = True Then
            Shell("netsh int ip reset c:\resetlog.txt", AppWinStyle.Hide, True)
        End If
        If network2.Checked = True Then
            Shell("ipconfig /flushdns", AppWinStyle.Hide, True)
        End If
        If network3.Checked = True Then
            Shell("ipconfig -release", AppWinStyle.Hide, True)
            Shell("ipconfig -renew", AppWinStyle.Hide, True)
            Shell("ipconfig -flushdns", AppWinStyle.Hide, True)
        End If

        TimerSpeedWindows.Stop()

    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        ListView1.Items.Clear()
        Button1.Enabled = True
        Form1New.Msgreboot1.BringToFront()
        'GroupBox1.Enabled = True
        'Button1.Visible = True

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblMemoriaDisponivel.Click

    End Sub

    Private Sub lblram_Click(sender As Object, e As EventArgs) Handles lblram.Click

    End Sub



    Private Sub lblcpu_TextChanged(sender As Object, e As EventArgs) Handles lblcpu.TextChanged
        If pb_cpu.Value > 69 Then
            lblcpu.ForeColor = Color.FromArgb(231, 76, 60)
            formcleaner.lblcpu.ForeColor = Color.FromArgb(231, 76, 60)
            pb_cpu.ProgressColour = Color.FromArgb(231, 76, 60)
        ElseIf pb_cpu.Value < 68 Then
            lblcpu.ForeColor = Color.FromArgb(105, 108, 135)
            formcleaner.lblcpu.ForeColor = Color.White()
            pb_cpu.ProgressColour = Color.FromArgb(105, 108, 135)
        End If
    End Sub

    Private Sub lblram_TextChanged(sender As Object, e As EventArgs) Handles lblram.TextChanged
        If ramprogressbar.Value > 69 Then
            lblram.ForeColor = Color.FromArgb(231, 76, 60)
            formcleaner.lblram.ForeColor = Color.FromArgb(231, 76, 60)
            ramprogressbar.ProgressColour = Color.FromArgb(231, 76, 60)
        ElseIf ramprogressbar.Value < 68 Then
            lblram.ForeColor = Color.FromArgb(105, 108, 135)
            formcleaner.lblram.ForeColor = Color.White()
            ramprogressbar.ProgressColour = Color.FromArgb(105, 108, 135)

        End If
    End Sub

    Private Sub adsclick()
        Dim AdLink As String = Cliente.DownloadString("https://pastebin.com/raw/JNmXuM84")
        Dim AdImg As String = Cliente.DownloadString("https://pastebin.com/raw/S53R00mC")

        If AdImg = "..." Then

        Else
            panelads.ImageLocation = AdImg

        End If


        If AdLink = "..." Then

        Else
            System.Diagnostics.Process.Start(AdLink)
        End If
    End Sub


    Private Sub panelads_Click(sender As Object, e As EventArgs) Handles panelads.Click
        ' MsgBox("Could not see update." + vbCrLf + " As soon as possible go to the INFO tab and check for an update!")

        If My.Computer.Network.IsAvailable = True Then
            Try
                If My.Computer.Network.Ping("www.google.com", 10) Then
                    adsclick()
                End If
            Catch ex As Exception
                ' MsgBox("Could not see update." + vbCrLf + " As soon as possible go to the INFO tab and check for an update!")
            End Try
        End If

    End Sub

    Private Sub chk4_CheckedChanged(sender As Object)

    End Sub

    Private Sub chk2_CheckedChanged(sender As Object)

    End Sub

    Private Sub chk3_CheckedChanged(sender As Object)

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub


End Class
