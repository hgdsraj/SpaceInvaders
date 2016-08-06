Public Class frmMenu
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Raj Mahey
    'May 29th 2012
    'Wernstrom Invaders
    'Futurama
    'Space Invaders Final Project

    'This is the MENU
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Dim intMute As Integer = 1
    Dim blnMusicPlaying As Boolean 'boolean for muting
    Dim spStartTheme As System.Media.SoundPlayer = New System.Media.SoundPlayer(SpaceInvaders.My.Resources.FuturamaStartTheme) 'soundplayer for theme
    Dim spZoidberg As System.Media.SoundPlayer = New System.Media.SoundPlayer(SpaceInvaders.My.Resources.Zoidberg_Whoop) 'soundplayer for zoidberg whoop

    Private Sub pctHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctHelp.Click
        frmHelp.Show() 'shows help form when help clicked, keeps this form opened
    End Sub

    Private Sub pctQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctQuit.Click 'Ends program on quit click
        End 'ends program when quit clicked
    End Sub

    Private Sub pctPlayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctPlayButton.Click
        frmSelect.Show() 'shows the story form when play clicked, hides this form
        Me.Hide()
        spStartTheme.Stop()
    End Sub

    Private Sub frmMenu_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If intMute = 1 Then
            spStartTheme.PlayLooping() 'plays the sound player spStartTheme, which contains the theme song.
            blnMusicPlaying = True 'bln for muting
        End If

    End Sub

    Private Sub pctMute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctMute.Click ''Stops music, muting sound when button clicked
        If blnMusicPlaying = True Then
            spStartTheme.Stop() 'stop sounds
            spZoidberg.Stop() 'stop sounds
            Me.pctMute.BackgroundImage = SpaceInvaders.My.Resources.soundmute 'bg changes
            blnMusicPlaying = False
            intMute = 2
        Else
            spStartTheme.Play() 'play theme
            Me.pctMute.BackgroundImage = SpaceInvaders.My.Resources.sound
            blnMusicPlaying = True

        End If
    End Sub

    Private Sub pctZoidBerg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctZoidBerg.Click
        spZoidberg.Play() 'play zoidberg sound
        blnMusicPlaying = True
    End Sub

End Class
