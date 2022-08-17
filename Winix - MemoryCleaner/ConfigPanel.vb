Public Class ConfigPanel



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'chk2------False


        My.Settings.chk1 = chk1.Checked
        My.Settings.chk3 = chk3.Checked
        My.Settings.chk4 = chk4.Checked

        'ativar giftcode
        My.Settings.chk2 = chk2.Checked



        'chk5
        If My.Settings.chk5 = True Then
            My.Settings.chk5 = False
            chk5.Checked = False
            'Form1.btnrefresh.Visible = True
        ElseIf My.Settings.chk5 = False Then
            'Form1.btnrefresh.Visible = False
        End If

        'chk1
        If My.Settings.chk1 = False Then
            chk1.Checked = False

        ElseIf My.Settings.chk1 = True Then
            chk1.Checked = True
        End If
        My.Settings.Save()
        'Form1New.ButtonHome.Image = My.Resources.Button_Home
        Form1New.ConfigPanel1.BringToFront()

    End Sub

    Private Sub chk5_CheckedChanged(sender As Object) Handles chk5.CheckedChanged

    End Sub

    Public Sub chk2_CheckedChanged(sender As Object) Handles chk2.CheckedChanged
        '  Dim infopnl As New InfoPanel
        ' If chk2.Checked = True Then
        'infopnl.giftcodetextbox.Visible = True
        'Else
        'infopnl.giftcodetextbox.Visible = False
        'End If
    End Sub

    Private Sub PanelRam_Paint(sender As Object, e As PaintEventArgs) Handles PanelRam.Paint

    End Sub
End Class
