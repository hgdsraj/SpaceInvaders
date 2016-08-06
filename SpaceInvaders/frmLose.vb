Public Class frmLose
    Dim splose As System.Media.SoundPlayer = New System.Media.SoundPlayer(SpaceInvaders.My.Resources.benderlaugh) 'soundplayer for lose

    Private Sub frmLose_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        splose.PlayLooping()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class