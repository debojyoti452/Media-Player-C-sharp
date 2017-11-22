Public Class Form1
    Public IsMediaPlaying As Boolean

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If IsMediaPlaying = False Then
            ButtoPlayPause.Image = My.Resources.icon_play_48
        Else
            ButtoPlayPause.Image = My.Resources.icon_pause_48
            LabelPos.Text = MediaElement1.Position.Duration.ToString
        End If
    End Sub

    Private Sub ButtoPlayPause_Click(sender As System.Object, e As System.EventArgs) Handles ButtoPlayPause.Click
        If IsMediaPlaying = False Then
            MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Play
            IsMediaPlaying = True
        Else
            MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Pause
            IsMediaPlaying = False
        End If
    End Sub

    Private Sub ButtonStop_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStop.Click
        MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Stop
        IsMediaPlaying = False
    End Sub

    Private Sub ButtonRew_Click(sender As System.Object, e As System.EventArgs) Handles ButtonRew.Click
        MediaElement1.Position = .MediaElement1.Position - TimeSpan.FromSeconds(10)
    End Sub

    Private Sub ButtonFstFrwrd_Click(sender As System.Object, e As System.EventArgs) Handles ButtonFstFrwrd.Click
        MediaElement1.Position = .MediaElement1.Position + TimeSpan.FromSeconds(10)
    End Sub

    Private Sub ButtonOpen_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOpen.Click
        OpenFile()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Play
        IsMediaPlaying = True
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PauseToolStripMenuItem.Click
        MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Pause
        IsMediaPlaying = False
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StopToolStripMenuItem.Click
        MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Stop
        IsMediaPlaying = False
    End Sub

    Private Sub RewindToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RewindToolStripMenuItem.Click
        MediaElement1.Position = MediaElement1.Position - TimeSpan.FromSeconds(10)
    End Sub

    Private Sub FastforwardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FastforwardToolStripMenuItem.Click
        MediaElement1.Position = MediaElement1.Position + TimeSpan.FromSeconds(10)
    End Sub

    Private Sub ExitMediaPlayerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitMediaPlayerToolStripMenuItem.Click
        End
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenFileToolStripMenuItem.Click
        OpenFile()
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        MediaElement1.SpeedRatio = TrackBar1.Value
        Speedvaluelabel.Text = "x" + TrackBar1.Value.ToString
    End Sub

    Private Sub SpeedSettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpeedSettingsToolStripMenuItem.Click
        SpeedPanel.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        SpeedPanel.Hide()
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub


    Private Sub ElementHost1_ChildChanged(sender As Object, e As Integration.ChildChangedEventArgs) Handles ElementHost1.ChildChanged

    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        MediaElement1.Volume = TrackBar2.Value
    End Sub

    Private Sub LabelPos_Click(sender As Object, e As EventArgs) Handles LabelPos.Click

    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScreenToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


