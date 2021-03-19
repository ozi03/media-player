Public Class themecreator

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bgset.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        backgrocolorpicker.ShowDialog()
        If backgrocolorpicker.ShowDialog <> Windows.Forms.DialogResult.None Then
            Me.BackColor = backgrocolorpicker.Color
            Form1.BackColor = backgrocolorpicker.Color
            Form2.BackColor = backgrocolorpicker.Color
            settingswindow.BackColor = backgrocolorpicker.Color
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btset.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        buttoncolorpicker.ShowDialog()
        If buttoncolorpicker.ShowDialog <> Windows.Forms.DialogResult.None Then
            Me.bgset.BackColor = buttoncolorpicker.Color
            Me.btset.BackColor = buttoncolorpicker.Color
            Me.txset.BackColor = buttoncolorpicker.Color
            Form1.gobutton.BackColor = buttoncolorpicker.Color
            Form1.browsebutton.BackColor = buttoncolorpicker.Color
            Form1.hidebutton.BackColor = buttoncolorpicker.Color
            Form1.setbutton.BackColor = buttoncolorpicker.Color
            Form1.stopbutton.BackColor = buttoncolorpicker.Color
            Form1.pausebutton.BackColor = buttoncolorpicker.Color
            Form1.playbutton.BackColor = buttoncolorpicker.Color

            Form2.playbutton.BackColor = buttoncolorpicker.Color
            Form2.showbutton.BackColor = buttoncolorpicker.Color
            Form2.hidebutton.BackColor = buttoncolorpicker.Color
            Form2.pausebutton.BackColor = buttoncolorpicker.Color

            settingswindow.themcret.BackColor = buttoncolorpicker.Color
            settingswindow.darkmodeon.BackColor = buttoncolorpicker.Color
            settingswindow.darkmodeoff.BackColor = buttoncolorpicker.Color

        End If
    End Sub

    Private Sub txset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txset.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        textcolorpicker.ShowDialog()

        If textcolorpicker.ShowDialog <> Windows.Forms.DialogResult.None Then
            Me.bgset.ForeColor = textcolorpicker.Color
            Me.btset.ForeColor = textcolorpicker.Color
            Me.txset.ForeColor = textcolorpicker.Color
            Form1.gobutton.ForeColor = textcolorpicker.Color
            Form1.browsebutton.ForeColor = textcolorpicker.Color
            Form1.hidebutton.ForeColor = textcolorpicker.Color
            Form1.setbutton.ForeColor = textcolorpicker.Color
            Form1.stopbutton.ForeColor = textcolorpicker.Color
            Form1.pausebutton.ForeColor = textcolorpicker.Color
            Form1.playbutton.ForeColor = textcolorpicker.Color

            Form2.playbutton.ForeColor = textcolorpicker.Color
            Form2.showbutton.ForeColor = textcolorpicker.Color
            Form2.hidebutton.ForeColor = textcolorpicker.Color
            Form2.pausebutton.ForeColor = textcolorpicker.Color

            settingswindow.themcret.ForeColor = textcolorpicker.Color
            settingswindow.darkmodeon.ForeColor = textcolorpicker.Color
            settingswindow.darkmodeoff.ForeColor = textcolorpicker.Color
        End If
    End Sub
End Class