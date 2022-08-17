Imports System.Net
Public NotInheritable Class SplashScreenWinix

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub checkupdate()
        Dim Cliente As New WebClient
        Dim directoryPath As String = My.Application.Info.DirectoryPath
        Dim currentversion As String
        Dim newversion As String = Cliente.DownloadString("https://pastebin.com/raw/PJVDfUrb")
        ' Dim updaterexe As String = Cliente.DownloadString("https://pastebin.com/raw/FVgbrCZB")
        With My.Application.Info.Version

            currentversion = .Major & "." & .Minor & "." & .Build & "." & .Revision
        End With

        If currentversion < newversion Then
            'FALTA ATUALIZAR
            If System.IO.File.Exists(directoryPath + "\wmcUpdater.exe") = True Then
                Process.Start(directoryPath + "\wmcUpdater.exe")
                Close()

            Else
                MsgBox("Missing file to complete the update." + vbCrLf + "Please go back to the download page and reinstall the program!", MsgBoxStyle.Critical, "Error in Update!")
                'Close()

            End If

        End If
    End Sub


    Private Sub SplashScreenWinix_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Me.SuspendLayout()


        If My.Computer.Network.IsAvailable = True Then
            Try
                If My.Computer.Network.Ping("www.google.com", 10) Then
                    checkupdate()

                End If
            Catch ex As Exception
                MsgBox("Could not see update." + vbCrLf + " As soon as possible go to the INFO tab and check for an update!")

            End Try
        End If






        'ATUALIZADO
        '  Me.ResumeLayout(


        ' MsgBox("Could not see update." + vbCrLf + " As soon as possible go to the INFO tab and check for an update!")



        '    Catch ex As Exception
        'SEM ACESSO A INTERNET
        'MsgBox("Could not see update." + vbCrLf + " As soon as possible go to the INFO tab and check for an update!")
        'End Try

        'Else

        'End If







    End Sub


End Class
