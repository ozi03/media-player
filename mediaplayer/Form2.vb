Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pausebutton.Click
        Form1.AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playbutton.Click
        Form1.AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Hide()
        Label1.Text = "Currently Playing - " + Form1.AxWindowsMediaPlayer1.URL
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showbutton.Click
        Form1.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hidebutton.Click
        Form1.Hide()
    End Sub
End Class