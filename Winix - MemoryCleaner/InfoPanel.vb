Imports System.Net
Public Class InfoPanel
    Public WithEvents Cliente As New WebClient

    Private Sub InfoPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttonUpdate.Enabled = False

        With My.Application.Info.Version
            lblversion.Text = "v" & .Major & "." & .Minor & " (Build " & .Build & "." & .Revision & ")"
        End With

        If My.Computer.Network.IsAvailable = True Then
            Try
                If My.Computer.Network.Ping("www.google.com", 10) Then
                    buttonUpdate.Enabled = True
                End If
            Catch ex As Exception

                buttonUpdate.Enabled = False

            End Try
        End If

    End Sub

    Private Sub updateclick()
        Dim currentversion As String
        Dim newversion As String = Cliente.DownloadString("https://pastebin.com/raw/PJVDfUrb")
        Dim updatesinfo As String
        Dim updaterexe As String = Cliente.DownloadString("https://pastebin.com/raw/FVgbrCZB")
        Dim directoryPath As String = My.Application.Info.DirectoryPath
        'buttonUpdate.Enabled = False


        With My.Application.Info.Version

            currentversion = .Major & "." & .Minor & "." & .Build & "." & .Revision
        End With


        newversion = Cliente.DownloadString("https://pastebin.com/raw/PJVDfUrb")


        If currentversion < newversion Then
            buttonUpdate.Image = My.Resources.ButtonCheckUpdate_Checking
            updatesinfo = "pendente"
        Else
            updatesinfo = "atualizado"
            buttonUpdate.Image = My.Resources.ButtonCheckUpdate_Checking
        End If


        If updatesinfo = "atualizado" Then
            buttonUpdate.Image = My.Resources.ButtonCheckUpdate_Checking
            System.Threading.Thread.Sleep("2000")


            If currentversion < newversion Then
                buttonUpdate.Image = My.Resources.ButtonCheckUpdate_UPDATE
                updatesinfo = "pendente"
                buttonUpdate.Enabled = True
            Else
                buttonUpdate.Image = My.Resources.ButtonCheckUpdate_UPDATED
                updatesinfo = "atualizado"
                buttonUpdate.Enabled = True
            End If

        ElseIf updatesinfo = "pendente" Then
            buttonUpdate.Image = My.Resources.ButtonCheckUpdate_UPDATE
            'MsgBox("Function not yet available in your region!", MsgBoxStyle.Critical, "Error")

            If currentversion < newversion Then
                'FALTA ATUALIZAR
                If System.IO.File.Exists(directoryPath + "\wmcUpdater.exe") = True Then
                    Process.Start(directoryPath + "wmcUpdater.exe")
                    Form1New.Close()

                Else
                    MsgBox("Missing file to complete the update." + vbCrLf + "Please go back to the download page and reinstall the program!", MsgBoxStyle.Critical, "Error in Update!")
                    Form1New.Close()

                End If
            End If
        End If



    End Sub


    Private Sub buttonUpdate_Click(sender As Object, e As EventArgs) Handles buttonUpdate.Click

        updateclick()




    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub giftcodetextbox_TextChanged(sender As Object, e As EventArgs) Handles giftcodetextbox.TextChanged


        If giftcodetextbox.Text.Length = 14 Then
            giftbutton.Enabled = True
        Else
            giftbutton.Enabled = False
        End If

    End Sub

    Private Sub giftbutton_Click(sender As Object, e As EventArgs) Handles giftbutton.Click
        Dim GiftWMC As String = Cliente.DownloadString("https://pastebin.com/raw/wie3qVSH")
        If giftcodetextbox.Text = GiftWMC Then
            Form1New.MinePanel1.BringToFront()
            Form1New.MinePanel1.gift_validation.Text = "Valid: " & GiftWMC
            Form1New.MinePanel1.gift_validation.ForeColor = Color.LawnGreen
            Form1New.MinePanel1.Label1.Text = "SOURCE:"
        Else
            giftcodetextbox.Text = "Invalid Code!"
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1New.InformeBugsPanel1.BringToFront()
    End Sub

    Private Sub giftcodetextbox_Click(sender As Object, e As EventArgs) Handles giftcodetextbox.Click

    End Sub

    Private Sub giftcodetextbox_MouseHover(sender As Object, e As EventArgs) Handles giftcodetextbox.MouseHover
        giftcodetextbox.Text = ""
    End Sub



    ' Private Sub imgSocial_Click(sender As Object, e As EventArgs) Handles imgSocial.Click
    '    System.Diagnostics.Process.Start("https://www.patreon.com/winixcompany")
    'End Sub

    'Private Sub buttonTwitter_Click(sender As Object, e As EventArgs) Handles buttonTwitter.Click
    '    System.Diagnostics.Process.Start("https://twitter.com/Winix_Company")
    'End Sub

    'Private Sub buttonPatreon_Click(sender As Object, e As EventArgs) Handles buttonPatreon.Click
    '   System.Diagnostics.Process.Start("https://www.patreon.com/winixgcompany")
    'End Sub

    'Private Sub buttonYt_Click(sender As Object, e As EventArgs) Handles buttonYt.Click
    '    System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCCeH8IeVzfGWg2CfPrtL_jg?sub_confirmation=1")
    'End Sub






End Class
