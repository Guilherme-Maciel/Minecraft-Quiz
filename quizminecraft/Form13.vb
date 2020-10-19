Public Class Form13

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.song, AudioPlayMode.BackgroundLoop)
    End Sub
End Class