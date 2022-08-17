Public Class PopUpRam
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MyBase.Left -= 5
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Left = My.Computer.Screen.WorkingArea.Width - 280 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        MyBase.Left += 9

        If Me.Left = My.Computer.Screen.WorkingArea.Width - 10 Then
            Me.Close()
        End If

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer3.Start()
    End Sub

    Private Sub PopUpRam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class