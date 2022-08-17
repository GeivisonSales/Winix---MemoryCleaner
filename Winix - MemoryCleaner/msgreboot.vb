Imports System.Net
Public Class msgreboot

    Public WithEvents Cliente As New WebClient
    'Dim AdImg As String = Cliente.DownloadString("https://pastebin.com/raw/S53R00mC")
    'Dim AdLink As String = Cliente.DownloadString("https://pastebin.com/raw/JNmXuM84")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("shutdown", "/r /f /t 00")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.SendToBack()
        'Form1.Show()
        ' Form1.ActiveForm.Location = PremiumForm.Location
        'PremiumForm.Close()
    End Sub


    Private Sub ads()
        Dim AdImg As String = Cliente.DownloadString("https://pastebin.com/raw/S53R00mC")
        Dim AdLink As String = Cliente.DownloadString("https://pastebin.com/raw/JNmXuM84")


        If AdImg = "..." Then

        Else
            panelads.ImageLocation = AdImg

        End If

    End Sub

    Private Sub msgreboot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable = True Then
            Try
                If My.Computer.Network.Ping("www.google.com", 10) Then
                    ads()
                End If
            Catch ex As Exception
                ' MsgBox("Nao ha acesso a internet", MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

    Private Sub panelads_Click(sender As Object, e As EventArgs) Handles panelads.Click
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





End Class
