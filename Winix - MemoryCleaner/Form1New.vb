Imports System.ComponentModel
Imports System.Net
Public Class Form1New

    'Public WithEvents Cliente As New WebClient


    ''WARNING''
    ''QUEM BURLAR O CONFUSER É VIADO :b''
    ''ABOUT BURLING CONFUSER IS GAY :b''
    ''QUIEN BURLAR EL CONFUSER ES GAY :b''

    Dim directoryPath As String = My.Application.Info.DirectoryPath

    Public Structure moverForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Dim mover As moverForm
    Private Sub titlepanelform_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitlePanelForm.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub
    Private Sub titlepanelform_Mousemover(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TitlePanelForm.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub
    Private Sub winixicon_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles WinixIcon.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub
    Private Sub winixicon_Mousemover(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles WinixIcon.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub
    Private Sub labeltitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelTitle.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub
    Private Sub labeltitle_Mousemover(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelTitle.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub
    Private Sub labelversion_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelVersion.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub
    Private Sub labelversion_Mousemover(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LabelVersion.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub



    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        ButtonHome.Image = My.Resources.NEW_Button_Home_Clicked
        ButtonSettings.Image = My.Resources.NEW_Button_Settings
        HomePanel1.BringToFront()
    End Sub

    Private Sub ButtonSettings_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click
        ButtonSettings.Image = My.Resources.NEW_Button_Settings_Clicked
        ButtonHome.Image = My.Resources.NEW_Button_Home
        ConfigPanel1.BringToFront()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click

        'chk4
        If My.Settings.chk4 = True Then
            formcleaner.Show()
            Me.Hide()
        ElseIf My.Settings.chk4 = False Then
            formcleaner.Close()
            Me.Close()
        End If

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

    End Sub

    Private Sub Form1New_Load(sender As Object, e As EventArgs) Handles Me.Load
        'LabelVersion.Text = "v." & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build
        With My.Application.Info.Version
            LabelVersion.Text = "v" & .Major & "." & .Minor & " (Build " & .Build & "." & .Revision & ")"
        End With
        'Dim currentversion As String


        'Me.SuspendLayout()

        Me.Opacity = 0.0
        For i = 0.0 To 10.0 Step 0.01
            If Me.Opacity < 1.0 Then
                Me.Opacity += 0.01
                Threading.Thread.Sleep(10)
            End If
        Next







        Application.DoEvents()

        'CODIGO ---------------------------------------------------------------


        ' loadantigo












        'If My.Computer.Info.OSFullName = "" Then
        'pcinfo.Visible = False
        'Panel2.Visible = False
        'Else
        'pcinfo.Text = My.Computer.Info.OSFullName
        'End If



        'Me.ResumeLayout()

        'CONFIGS====================================

        'chk4



        'If My.Settings.chk4 = True Then
        'formcleaner.Show()

        'ElseIf My.Settings.chk4 = False Then
        'formcleaner.Hide()

        'End If






        'chk5
        If My.Settings.chk5 = True Then
            My.Settings.chk5 = False
            ConfigPanel1.chk5.Checked = False
            'Form1.btnrefresh.Visible = True
        ElseIf My.Settings.chk5 = False Then
            'Form1.btnrefresh.Visible = False
        End If



        'Configs
        ConfigPanel1.chk1.Checked = My.Settings.chk1
        If My.Settings.chk1 = False Then
            ConfigPanel1.chk1.Checked = False

        ElseIf My.Settings.chk1 = True Then
            ConfigPanel1.chk1.Checked = True
        End If
        ConfigPanel1.chk2.Checked = My.Settings.chk2
        ConfigPanel1.chk3.Checked = My.Settings.chk3
        ConfigPanel1.chk4.Checked = My.Settings.chk4
        ConfigPanel1.chk5.Checked = My.Settings.chk5

        'chk2------False

        'chk3
        'If My.Settings.chk3 = True Then
        'formcleaner.TopMost = True
        'formcleaner.Close()
        'formcleaner.Show()
        'ElseIf My.Settings.chk3 = False Then
        'formcleaner.TopMost = False
        'formcleaner.Close()
        'formcleaner.Show()
        'End If


        'INITIALIZE THE INTERVAL OF THE TIMER TO 100.
        'HomePanel1.ProgressColors.Interval = 600
        'START THE TIMER
        'HomePanel1.ProgressColors.Start()


        'With My.Application.Info.Version

        'currentversion = .Major & "." & .Minor & "." & .Build & "." & .Revision
        'End With

        'If currentversion < newversion Then
        'FALTA ATUALIZAR

        'Process.Start(directoryPath + "\wmcUpdater.exe")
        'Close()
        'Else
        'ATUALIZADO
        '  Me.ResumeLayout()
        'End If


        HomePanel1.TimerRAM.Interval = 100
        HomePanel1.TimerRAM.Start()



    End Sub

    Private Sub HomePanel1_Load(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataDoSistema As String = DateTime.Now.ToString("yyyy-MM-dd")
        Process.Start("explorer.exe", "c:\WinixMCleaner\SavedLog\" & dataDoSistema)
    End Sub





    Private Sub TitlePanelForm_MouseUp(sender As Object, e As MouseEventArgs) Handles TitlePanelForm.MouseUp

    End Sub

    Private Sub takeuser()
        Dim wClient As New WebClient
        '' wClient.OpenRead("http://50xrrsamd7cwjitqgenaccsserver.96.lt/winixmemorycleaner/userscounter/count.php?action=take")
    End Sub

    Private Sub Form1New_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Dim wClient As New WebClient
        ''wClient.OpenRead("http://50xrrsamd7cwjitqgenaccsserver.96.lt/winixmemorycleaner/userscounter/count.php?action=add")
        If My.Computer.Network.IsAvailable = True Then
            Try
                If My.Computer.Network.Ping("www.google.com", 10) Then
                    '' takeuser()
                End If
            Catch ex As Exception

            End Try
        End If



        For i = 0.0 To 10.0 Step 0.01
            If Me.Opacity > 0.0 Then
                Me.Opacity -= 0.05
                Threading.Thread.Sleep(10)
            End If
        Next
    End Sub

    Private Sub LabelVersion_Click(sender As Object, e As EventArgs) Handles LabelVersion.Click

    End Sub

    Private Sub ButtonInfo_Click(sender As Object, e As EventArgs) Handles ButtonInfo.Click

        InfoPanel1.BringToFront()
        ButtonHome.Image = My.Resources.NEW_Button_Home
        ButtonSettings.Image = My.Resources.NEW_Button_Settings

        If My.Settings.chk2 = True Then

            InfoPanel1.giftpanel.Visible = True
        Else
            InfoPanel1.giftpanel.Visible = False

        End If


    End Sub

    Private Sub TitlePanelForm_Paint(sender As Object, e As PaintEventArgs) Handles TitlePanelForm.Paint

    End Sub

    Private Sub ButtonGamer_Click_1(sender As Object, e As EventArgs) Handles ButtonGamer.Click
        GamerPanel1.BringToFront()
        ButtonHome.Image = My.Resources.NEW_Button_Home
        ButtonSettings.Image = My.Resources.NEW_Button_Settings
    End Sub


    Private Sub betaview_patrons_Click(sender As Object, e As EventArgs) Handles betaview_patrons.Click
        BetA_VIEW_PANEL1.NotificationBetaView.Visible = True
        BetA_VIEW_PANEL1.BringToFront()
        ButtonHome.Image = My.Resources.NEW_Button_Home
        ButtonSettings.Image = My.Resources.NEW_Button_Settings
    End Sub
End Class
