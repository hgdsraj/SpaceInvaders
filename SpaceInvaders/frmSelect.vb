Public Class frmSelect

    Private Sub frmSelect_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated 'show saved level and high scores
        lblSavedLvl.Text = My.Settings.Save1 'show saved level
        lblHS1.Text = "Your Level 1 High Score:  " & My.Settings.HighScore1
        lblHS2.Text = "Your Level 2 High Score:  " & My.Settings.HighScore2 'show high scores
        lblHS3.Text = "Your Level 3 High Score:  " & My.Settings.HighScore3
    End Sub

    Private Sub btnRestoreFromSave_Click(sender As System.Object, e As System.EventArgs) Handles btnRestoreFromSave.Click
        Me.Hide()
        frmStory.Show()
        My.Settings.Restore = True
        If radFarnsworth.Checked = True Then
            My.Settings.UserChar = 2
        Else
            My.Settings.UserChar = 1
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Me.Hide()
        frmStory.Show()
        If radFarnsworth.Checked = True Then 'checks for what character
            My.Settings.UserChar = 2
        Else
            My.Settings.UserChar = 1
        End If
        My.Settings.Restore = False
        My.Settings.Save1 = 0
        My.Settings.HighScore1 = 0 'highscores reset and save reset if new game
        My.Settings.HighScore2 = 0
        My.Settings.HighScore3 = 0
        My.Settings.Save()
    End Sub

End Class