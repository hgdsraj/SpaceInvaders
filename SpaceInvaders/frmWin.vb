Public Class frmWin
    Dim spWin As System.Media.SoundPlayer = New System.Media.SoundPlayer(SpaceInvaders.My.Resources.Good_News_Everyone_) 'soundplayer for win


    Private Sub frmWin_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        spWin.PlayLooping()
        tmrTitle.Start()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub tmrTitle_Tick(sender As System.Object, e As System.EventArgs) Handles tmrTitle.Tick 'switches title every second
        If Me.Text = "GOOD NEWS!" Then
            Me.Text = "YOU WIN"
        Else
            Me.Text = "GOOD NEWS!"
        End If
    End Sub
End Class