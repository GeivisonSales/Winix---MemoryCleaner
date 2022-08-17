Imports Microsoft.Win32
Imports System.IO
Public Class PremiumForm
    Dim mover As Form1.MoveForm
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Form1.ActiveForm.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub PremiumForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Form1.ActiveForm.Location

    End Sub

    Private Sub Msgreboot1_MouseDown(sender As Object, e As MouseEventArgs) Handles Msgreboot1.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub Msgreboot1_MouseMove(sender As Object, e As MouseEventArgs) Handles Msgreboot1.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub


    'CODED

    'Private Sub btnsalvarreg_Click(sender As Object, e As EventArgs) Handles btnsalvarreg.Click
    '   System.IO.Directory.CreateDirectory("c:\winixsaves\")
    '   System.Diagnostics.Process.Start("Regedit.exe", "/e c:\winixsaves\SaveReg.reg HKEY_LOCAL_MACHINE\SOFTWARE\microsoft\Windows\currentversion")
    '   Process.Start("explorer.exe", "c:\winixsaves")
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CODIGO SALVAR REGISTRO================================
        System.IO.Directory.CreateDirectory("c:\WinixMCleaner\savesreg\")
        System.Diagnostics.Process.Start("Regedit.exe", "/e c:\WinixMCleaner\savesreg\SaveReg.reg HKEY_LOCAL_MACHINE\SOFTWARE\microsoft\Windows\currentversion")
        'Process.Start("explorer.exe", "c:\WinixMCleaner\savesreg\")
        Button2.Visible = True
        '======================================================

        Timer1.Start()
        Button1.Enabled = False
        GroupBox1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
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

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        ListView1.Items.Clear()
        Button1.Enabled = True
        GroupBox1.Enabled = True
        Msgreboot1.Visible = True
        Msgreboot1.Location = New Point(0, 0)
        Button2.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then

        Else
            MsgBox("Open the Program Again as Administrator" + vbCrLf + "BETA - v.1.0", MsgBoxStyle.Exclamation, "Winix - MemoryCleanerPremium")
            Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("explorer.exe", "c:\WinixMCleaner\savesreg\")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object) Handles CheckBox4.CheckedChanged

    End Sub
End Class