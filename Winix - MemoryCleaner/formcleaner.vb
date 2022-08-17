Imports System.ComponentModel
Public Class formcleaner
    'Public Property Size As Size

    '==========================================
    'Coded by Geivison Sales                 
    'Date: 06/04/2018                        
    'hour: 00:58                             
    'Brazil                                   
    '==========================================



    'mover form
    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Dim mover As MoveForm

    Private Sub formcleaner_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub formcleaner_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub

    Private Sub lblcpu_MouseDown(sender As Object, e As MouseEventArgs) Handles lblcpu.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub lblcpu_MouseMove(sender As Object, e As MouseEventArgs) Handles lblcpu.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub

    Private Sub lblram_MouseDown(sender As Object, e As MouseEventArgs) Handles lblram.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub lblram_MouseMove(sender As Object, e As MouseEventArgs) Handles lblram.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub

    '-------------------------------------------------------------------------------



    Private Sub formcleaner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'form Backcolor = (9; 13; 58)
        'progressbar color = ()
        '
        Me.Opacity = 0.0

        For i = 0.0 To 10.0 Step 0.01
            If Me.Opacity < 1.0 Then
                Me.Opacity += 0.01
                Threading.Thread.Sleep(10)
            End If
        Next

        'Me.SuspendLayout()





        'CODIGO-----------------------------
        'Me.Location = New Point(0, 0)
        Me.Size = New Size(167, 27)

        '-----------------------------------
        ' EnableBlur()
        'Me.ResumeLayout()
        Application.DoEvents()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Processos.AddToListView(Form1.lwProcs, True)
        BackgroundWorker1.RunWorkerAsync()
        Button1.Enabled = False
        'Form1.Button1.Enabled = False
        'CleanRAMToolStripMenuItem.Enabled = False
        'Form1.CleanRAMToolStripMenuItem.Enabled = False
        'Form1.ToolStripMenuItem1.Enabled = False
        'Form1.ProgressBar1.Visible = True
        ProgressBar1.Visible = True
        'Form1.ReleaseMemory()
        'Form1.NotifyIcon1.Visible = False

    End Sub

    Private Sub lblram_Click(sender As Object, e As EventArgs) Handles lblram.Click

    End Sub

    Private Sub ShowMainWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMainWindowToolStripMenuItem.Click
        Form1New.Show()
        Me.Hide()
    End Sub

    Private Sub CleanRAMToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'Processos.AddToListView(Form1.lwProcs, True)
        BackgroundWorker1.RunWorkerAsync()
        'Form1.ReleaseMemory()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'formconfig.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub





    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork


        Processos.AddToListView(Form1.lwProcs, True)
        Form1.ReleaseMemory()

        For i = 0 To 50
            If BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True

                Exit For

            Else

                Form1.DoHeavyWork()
                BackgroundWorker1.ReportProgress(i)

            End If

        Next

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Button1.Enabled = True
        Form1.Button1.Enabled = True
        ' CleanRAMToolStripMenuItem.Enabled = True
        'Form1.CleanRAMToolStripMenuItem.Enabled = True
        'Form1.ToolStripMenuItem1.Enabled = True
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
        Form1.ProgressBar1.Value = 0
        Form1.ProgressBar1.Visible = False
        'BackgroundWorker1.CancelAsync()
        'Form1.NotifyIcon1.Visible = True
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Form1.ProgressBar1.Value = e.ProgressPercentage

    End Sub

    Private Sub formcleaner_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        For i = 0.0 To 10.0 Step 0.01
            If Me.Opacity > 0.0 Then
                Me.Opacity -= 0.05
                Threading.Thread.Sleep(10)
            End If
        Next
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        Form1New.Close()
        Me.Close()
    End Sub
End Class