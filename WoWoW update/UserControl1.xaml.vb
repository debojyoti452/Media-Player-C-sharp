Public Class UserControl1
    Public opendlg As New OpenFileDialog
    Public Sub OpenFile()
        Form1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Pause
        Form1.IsMediaPlaying = False
        Form1.Refresh()
        If opendlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Form1.Refresh()
            Form1.MediaElement1.Source = New Uri(opendlg.FileName)
            Form1.MediaElement1.LoadedBehavior = Windows.Controls.MediaState.Play
            Form1.IsMediaPlaying = True
            Dim NameSongTxt As String = IO.Path.GetFileNameWithoutExtension(opendlg.FileName)
            Form1.LabelMediaName.Text = NameSongTxt
            Form1.LabelPos.Text = "00:00:00"
        End If
    End Sub

    'Private Sub MediaElement1_BufferingEnded(sender As Object, e As System.Windows.RoutedEventArgs) Handles MediaElement1.BufferingEnded
    'Form1.LabelStatus.Hide()
    'End Sub

    'Private Sub MediaElement1_BufferingStarted(sender As Object, e As System.Windows.RoutedEventArgs) Handles MediaElement1.BufferingStarted
    'Form1.LabelStatus.Text = "Buffering..."
    ' End Sub

    'Private Sub MediaElement1_MediaFailed(sender As Object, e As System.Windows.ExceptionRoutedEventArgs) Handles MediaElement1.MediaFailed
    'Form1.LabelStatus.Text = "Media failed to open..."
    ' Form1.LabelStatus.Show()
    ' End Sub

    'Private Sub MediaElement1_MediaOpened(sender As Object, e As System.Windows.RoutedEventArgs) Handles MediaElement1.MediaOpened
    ' Form1.LabelStatus.Hide()
    'End Sub
End Class
