Public Class frmStory
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Raj Mahey
    'May 29th 2012
    'Wernstrom Invaders
    'Futurama
    'Space Invaders Final Project

    'This is the SELECT SCREEN

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub PctSTORY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctSkip.Click 'hides this form when skip clicked, shows game
        If My.Settings.Restore = True Then
            If My.Settings.Save1 = 1 Then
                frmGame.Show()
            ElseIf My.Settings.Save1 = 2 Then 'save settings show different forms
                frmGame2.Show()
            ElseIf My.Settings.Save1 = 3 Then
                frmGame3.Show()
            Else
                frmGame.Show()
            End If
        ElseIf My.Settings.Restore = False Then
            frmGame.Show()
        End If
        Me.Hide()
    End Sub
End Class