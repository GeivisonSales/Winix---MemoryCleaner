Imports System.Globalization
Imports System.ComponentModel
Public Class formconfig
    'mover form
    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Dim mover As MoveForm

    Private Sub AlteraIdioma(ByVal lang As String)
        For Each c As Control In Me.Controls
            Dim resources As ComponentResourceManager =
                New ComponentResourceManager(GetType(formconfig))
            resources.ApplyResources(c, c.Name, New CultureInfo(lang))
        Next c
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button <> MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        'chk2------False

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

        'chk4
        If My.Settings.chk4 = True Then
            formcleaner.Show()

        ElseIf My.Settings.chk4 = False Then
            formcleaner.Hide()

        End If

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

        Close()
    End Sub


    Private Sub formconfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.SuspendLayout()

        Application.DoEvents()

        'CODIGO-----------------------------

        'version
        lblversion.Text = "v." & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "  -  " & My.Application.Info.Copyright


        chk1.Checked = My.Settings.chk1
        chk2.Checked = My.Settings.chk2
        chk3.Checked = My.Settings.chk3
        chk4.Checked = My.Settings.chk4
        chk5.Checked = My.Settings.chk5

        ' ------------------------------------


        Me.ResumeLayout()
    End Sub

    Private Sub chk4_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chk5_CheckedChanged(sender As Object, e As EventArgs)
        My.Settings.chk5 = chk5.Checked
        My.Settings.Save()
    End Sub

    Private Sub chk2_CheckedChanged(sender As Object, e As EventArgs)
        My.Settings.chk2 = chk2.Checked
        My.Settings.Save()
    End Sub

    Private Sub lblcopyright_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblversion_Click(sender As Object, e As EventArgs) Handles lblversion.Click

    End Sub

    Private Sub chk1_CheckedChanged(sender As Object) Handles chk1.CheckedChanged
        My.Settings.chk1 = chk1.Checked
        My.Settings.Save()
    End Sub

    Private Sub chk3_CheckedChanged(sender As Object) Handles chk3.CheckedChanged
        My.Settings.chk3 = chk3.Checked
        My.Settings.Save()
    End Sub

    Private Sub chk4_CheckedChanged(sender As Object) Handles chk4.CheckedChanged
        My.Settings.chk4 = chk4.Checked
        My.Settings.Save()
    End Sub

    Private Sub bandUSA_Click(sender As Object, e As EventArgs) Handles bandUSA.Click
        My.Settings.idioma = "EN"
        bandUSA.BackColor = Color.FromArgb(231, 76, 60)
        bandBRAZIL.BackColor = Color.FromArgb(1, 3, 47)

        AlteraIdioma("en")


    End Sub

    Private Sub bandBRAZIL_Click(sender As Object, e As EventArgs) Handles bandBRAZIL.Click
        My.Settings.idioma = "BR"
        bandBRAZIL.BackColor = Color.FromArgb(231, 76, 60)
        bandUSA.BackColor = Color.FromArgb(1, 3, 47)

        AlteraIdioma("pt-BR")

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class