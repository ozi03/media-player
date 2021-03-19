Public Class Form1

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopbutton.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playbutton.Click


        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        AxWindowsMediaPlayer1.Ctlcontrols.play()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pausebutton.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Form2.Label1.Text = AxWindowsMediaPlayer1.URL
        AxWindowsMediaPlayer1.URL = urlbox.Text
        Me.Text = "Media Player - Webplaying : " + AxWindowsMediaPlayer1.URL
        NotifyIcon1.BalloonTipText = "Media Player Webplayer is currently playing " + AxWindowsMediaPlayer1.URL
        NotifyIcon1.ShowBalloonTip(300000)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles selectfiledialog1.FileOk
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = System.IO.Path.GetFullPath(selectfiledialog1.FileName)
        Me.Text = "Media Player - " + selectfiledialog1.FileName
        NotifyIcon1.Text = "Media Player - " + selectfiledialog1.FileName
        Form2.Label1.Text = "Currently Playing - " + selectfiledialog1.FileName
        NotifyIcon1.BalloonTipText = "Media Player is currently playing " + selectfiledialog1.FileName
        NotifyIcon1.ShowBalloonTip(300000)
    End Sub




    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hidebutton.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Me.Hide()


    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Form2.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setbutton.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        settingswindow.Show()
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gobutton.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        AxWindowsMediaPlayer1.URL = urlbox.Text()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browsebutton.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        selectfiledialog1.ShowDialog()
    End Sub
End Class
