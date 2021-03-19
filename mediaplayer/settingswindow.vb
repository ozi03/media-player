Public Class settingswindow


    Private Sub settingswindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles darkmodeon.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Form1.BackColor = Color.Black()
        Form1.ForeColor = Color.White()
        Me.ForeColor = Color.White()
        Me.BackColor = Color.Black()
        Form2.ForeColor = Color.White()
        Form2.BackColor = Color.Black()
        Form1.browsebutton.BackColor = Color.Black()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles darkmodeoff.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Form1.BackColor = Color.WhiteSmoke()
        Form2.BackColor = Color.WhiteSmoke()
        Me.ForeColor = Color.Black()
        Me.BackColor = Color.WhiteSmoke()
        Form2.ForeColor = Color.Black()
        Form1.ForeColor = Color.Black()
        Form1.browsebutton.BackColor = Color.WhiteSmoke()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles themcret.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        themecreator.Show()
    End Sub
End Class