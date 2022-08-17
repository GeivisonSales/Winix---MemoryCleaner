Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports System.Net
Public Class InformeBugsPanel

    Private Sub btn_sendticketbug_Click(sender As Object, e As EventArgs) Handles btn_sendticketbug.Click
        Dim Mail As New MailMessage

        If txt_email.Text = "" Then

            txt_email.Text = "Add your email to contact!"
            txt_email.Focus()

        Else

            btn_sendticketbug.Enabled = False

            Mail.Subject = "WM-Cleaner | Ticket Bug"
            Mail.To.Add("geivisonsales4@gmail.com")
            Mail.From = New MailAddress("uswmcleaner@gmail.com")
            Mail.Body = ("Ticket: " & txt_ticketbug.Text & vbCrLf & "Rate Software: " & Combo_Rate.Text & vbCrLf & "Email: " & txt_email.Text & vbCrLf & "Name: " & txt_name.Text)
            Dim SMTP As New SmtpClient("smpt.gmail.com")
            SMTP.Host = "smtp.gmail.com"
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("uswmcleaner@gmail.com", "87036391gs")
            SMTP.Port = "587"
            SMTP.Send(Mail)

            btn_sendticketbug.Enabled = True
            txt_ticketbug.ResetText()
            txt_name.ResetText()

            Me.SendToBack()
            Form1New.InfoPanel1.Button1.Text = "Ticket Sent!"

        End If

    End Sub

End Class
