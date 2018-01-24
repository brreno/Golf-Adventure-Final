Public Class frmMainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmSettings.Show()
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSettings.Hide()
        Me.Location = New Point(0, 0)
        Form2.Hide()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmLevelSelect.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            My.Computer.Audio.Play(My.Resources.GOLFMUSIC, AudioPlayMode.BackgroundLoop)
        End If
        If CheckBox1.Checked = False Then
            My.Computer.Audio.Stop()
        End If
    End Sub
End Class