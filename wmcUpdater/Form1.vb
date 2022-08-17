Imports System.Net
Imports System.IO
Imports System.IO.Compression
Imports System.ComponentModel
Public Class Form1
    'Dim exename As String = Cliente.DownloadString("https://pastebin.com/raw/J5FnTZwZ")
    Dim directoryPath As String = My.Application.Info.DirectoryPath
    Dim wClient As New System.Net.WebClient
    Dim tool As String = directoryPath + "\Winix - MemoryCleaner.exe"
    Public WithEvents Cliente As New System.Net.WebClient
    Dim linkfordownload As String = Cliente.DownloadString("https://pastebin.com/raw/dhKH96JA")


    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Dim mover As MoveForm
    Private Sub getupdate()


        System.Threading.Thread.Sleep(2000)

        If System.IO.File.Exists(tool) Then

            System.IO.File.Delete(tool)
            System.Threading.Thread.Sleep(2000)
            wClient.DownloadFile(New Uri(linkfordownload), directoryPath + "\update.zip")

            AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged



            ZipFile.ExtractToDirectory("update.zip", directoryPath)
            System.IO.File.Delete(directoryPath + "\update.zip")
            System.Threading.Thread.Sleep(5000)

            'ABRIR FORM ATUALIZADA
            Process.Start(tool)
            Close()

        Else

            System.IO.File.Delete(tool)
            System.Threading.Thread.Sleep(2000)
            wClient.DownloadFile(New Uri(linkfordownload), directoryPath + "\update.zip")
            AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged


            ZipFile.ExtractToDirectory("update.zip", directoryPath)
            System.IO.File.Delete(directoryPath + "\update.zip")
            System.Threading.Thread.Sleep(5000)

            'ABRIR FORM ATUALIZADA
            Process.Start(tool)
            Close()




        End If
    End Sub







    Private Sub ProgChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        'lblporcentagem.Text = ProgressBar1.Value & "%"
        'Label1.Text = "Updating... | " & String.Format("{0} MB's / {1} MB's", (e.BytesReceived / 1024D / 1024D).ToString("0.00"), (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00"))
        'ProgressBar1.Value = e.ProgressPercentage 'Pegar valor do download

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'ABRIR FORM ATUALIZADA
        Process.Start(tool)
        Close()
    End Sub






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim newversion As String = Cliente.DownloadString("https://pastebin.com/raw/PJVDfUrb")
        lblversion.Text = newversion & " - RELEASE"




    End Sub



    Private Sub atualizar()


    End Sub


    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button <> MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If System.IO.File.Exists(tool) Then

            ' System.IO.File.Delete(tool)
            'System.Threading.Thread.Sleep(2000)
            wClient.DownloadFileTaskAsync(New Uri(linkfordownload), directoryPath + "\Winix - MemoryCleaner.exe")
            AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged

            System.Threading.Thread.Sleep(5000)

            If ProgressBar1.Value >= 100 Then
                Timer2.Start()
                Timer1.Stop()
            Else

            End If

        Else

            'System.IO.File.Delete(tool)
            'System.Threading.Thread.Sleep(2000)
            wClient.DownloadFileTaskAsync(New Uri(linkfordownload), directoryPath + "\Winix - MemoryCleaner.exe")
            AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged

            System.Threading.Thread.Sleep(5000)
            If ProgressBar1.Value >= 100 Then
                Timer2.Start()
                Timer1.Stop()
            Else

            End If




        End If

    End Sub

    Private Sub lblporcentagem_Click(sender As Object, e As EventArgs) Handles lblporcentagem.Click

    End Sub

    Private Sub lblversion_Click(sender As Object, e As EventArgs) Handles lblversion.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ABRIR FORM SEM ATUALIZAR
        Process.Start(tool)
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updaterfree.WorkerReportsProgress = True
        updaterfree.WorkerSupportsCancellation = True
        If Label1.Text = "PENDING UPDATE" Then
            Label1.Text = "INSTALLING..."
            Button1.Enabled = False
            Button1.Cursor = Cursors.WaitCursor
            Button2.Enabled = False
            Button2.Text = "Wait..."
            Button2.Cursor = Cursors.WaitCursor
            Me.Cursor = Cursors.WaitCursor
            Label1.Cursor = Cursors.WaitCursor
            lblversion.Cursor = Cursors.WaitCursor

            'Threading.Thread.Sleep(2000)
        End If

        If Label1.Text = "INSTALLING..." Then
            'atualizar()
            updaterfree.RunWorkerAsync()
            ProgressBar1.Visible = True
        Else
            Label1.Text = "INSTALLING..."
            Button1.Enabled = False
            Button1.Cursor = Cursors.WaitCursor
            Button2.Enabled = False
            Button2.Text = "Wait..."
            Button2.Cursor = Cursors.WaitCursor
            Me.Cursor = Cursors.WaitCursor
            Label1.Cursor = Cursors.WaitCursor
            lblversion.Cursor = Cursors.WaitCursor

            updaterfree.RunWorkerAsync()
        End If


    End Sub

    Private Sub updaterfree_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles updaterfree.DoWork




        Dim Processos() As Process = System.Diagnostics.Process.GetProcessesByName("Winix - MemoryCleaner")

        For Each x As Process In Processos
            x.Kill()
        Next


        ' If My.Computer.Network.IsAvailable = False Then
        'Label1.Text = "NO CONNECTION"

        'Else
        'Label1.Text = "NULL"

        'End If

        System.Threading.Thread.Sleep(4000)

        Try
            Me.ResumeLayout()
            AddHandler wClient.DownloadProgressChanged, AddressOf ProgChanged
            getupdate()
            'Timer1.Start()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub fechar()
        updaterfree.CancelAsync()
        Me.Close()
    End Sub

    Private Sub updaterfree_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles updaterfree.RunWorkerCompleted
        Me.Close()
    End Sub

    Private Sub updaterfree_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles updaterfree.ProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
        Me.lblporcentagem.Text = TryCast(e.UserState, String)
    End Sub
End Class
