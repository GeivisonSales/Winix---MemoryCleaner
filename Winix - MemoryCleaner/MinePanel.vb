Imports System.Net
Public Class MinePanel
    Public WithEvents Cliente As New WebClient

    Private Sub btn_sobre_Click(sender As Object, e As EventArgs) Handles btn_sobre.Click
        Process.Start("https://www.nulled.to/topic/382282-vbnet-minecraft-account-generator-professional-source-code/")
    End Sub

    Private Sub gift_validation_ForeColorChanged(sender As Object, e As EventArgs) Handles gift_validation.ForeColorChanged

    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        Dim GiftWMC As String = Cliente.DownloadString("https://pastebin.com/raw/wie3qVSH")


        If Form1New.InfoPanel1.giftcodetextbox.Text = GiftWMC Then

        Else
            gift_validation.ForeColor = Color.Red
            btn_download.Enabled = False
            btn_download.Cursor = Cursors.No
            'btn_sobre.Enabled = False
            'btn_sobre.Cursor = Cursors.No
            gift_validation.Text = "Invalid: " & Form1New.InfoPanel1.giftcodetextbox.Text
        End If

    End Sub

    Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles btn_download.Click
        Dim GiftLink As String = Cliente.DownloadString("https://pastebin.com/raw/Xd92z0J6")
        Process.Start(GiftLink)
        Me.SendToBack()
        Form1New.InfoPanel1.giftcodetextbox.Text = "YOUR GIFT CODE"
    End Sub
End Class
