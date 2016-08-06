Public Class frmGame2
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Raj Mahey
    'May 29th 2012
    'Wernstrom Invaders
    'Futurama
    'Space Invaders Final Project

    'This is the GAME

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~





    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'All global variables below:
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Dim pctEnemy As New PictureBox 'A picturebox for the enemy
    Dim intRandom As Integer ' Holds random location
    Dim pctBullet As New PictureBox 'Picturebox for bullet
    Dim pctEnemyBullet As New PictureBox 'Enemy bullets picturebox
    Dim cltBullets As New Collection 'collection for bullets
    Dim cltEnemies As New Collection 'collection for enemies themselves
    Dim intScore As Integer  'your score
    Dim intImage As Integer 'ensures image is either clamps, mom, or wernstrom and that its different each time
    Dim intAmountOfEnemies As Integer = -1 'The amount of enemies in the collection
    Dim intMaxTotalAmountOFEnemies As Integer = 21 ' This is the limit for the amount of enemies
    Dim intEnemyBulletAmount As Integer = -1 'Enemy bullet amountfor collection
    Dim cltEnemiesBullets As New Collection 'collection for enemy bullets
    Dim blnSpace As Boolean = False 'bln for no rapid fire
    Dim blnCollision As Boolean = False 'collision boolean
    Dim blnBullets As Boolean = False 'boolean for bullet reload
    Dim intMaxAmountOfBullets As Integer = 10 'max amount of bullets
    Dim intLives As Integer = 4 ' hold amount of lives you have (3)
    Dim intTime As Integer 'int Time for score
    Dim intHighScore As Integer = My.Settings.HighScore3 'high score
    Dim spShot As System.Media.SoundPlayer = New System.Media.SoundPlayer(SpaceInvaders.My.Resources._01_milshot) 'soundplayer for shooting
    Dim spExplode As System.Media.SoundPlayer = New System.Media.SoundPlayer(SpaceInvaders.My.Resources.explosion_02) 'soundplayer for explosion
    Dim intArmor1 As Integer = 10 'global because if local it will keep resetting, armor
    Dim intarmor2 As Integer = 10 'global because if local it will keep resetting, armor2
    Dim intArmor3 As Integer = 10 'global because if local it will keep resetting, armor3
    Dim blnArmor1 As Boolean = True 'booleans for armor, global so it doesnt reset
    Dim blnArmor2 As Boolean = True 'booleans for armor, global so it doesnt reset
    Dim blnArmor3 As Boolean = True 'booleans for armor, global so it doesnt reset
    Dim pctExplosion As New PictureBox 'picturebox for explosion!
    Dim cltExplosions As New Collection 'collection for explosion
    Dim intSeconds As Integer 'intseconds for explosion timer (every 3 seconds all explosions wiped)
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ' CONTROLS 
    '       A and RIGHT to go right
    '       D and LEFT to go Left
    '       W or SPACE to Shoot
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub frmGame_KeyPress(ByVal sender As Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar) 'keyAscii

        'Sees is this is one of keys
        Select Case KeyAscii
            Case Asc("a")
                If Not pctUser.Location.X - 1 < 0 Then 'ensures not off form to right
                    Me.pctUser.Left = Me.pctUser.Left - 10 'will move left if position isnt 0 or less 
                    'Moves ship left (10)
                End If
            Case Asc("d")
                If Not pctUser.Location.X + 1 > 600 Then 'ensures not off form to right 
                    Me.pctUser.Left = Me.pctUser.Left + 10 'will move right if not off screen to right
                    'moves ship right
                End If
            Case Asc("w")
                If blnSpace = False And blnBullets = False Then 'Checks too see if paused or space is already depressed
                    blnSpace = True
                    pctBullet = New Windows.Forms.PictureBox ' pct bullet is created
                    pctBullet.Size = New System.Drawing.Size(12, 38) 'size of pct bullet is defined
                    pctBullet.Location = New System.Drawing.Point(pctUser.Location.X + 7, pctUser.Location.Y - 50) 'pct bullets location is defined
                    pctBullet.BackgroundImage = My.Resources.mylaser 'background image (image) defined as mylaser
                    Controls.Add(pctBullet) 'adds pct bullet to controls
                    cltBullets.Add(pctBullet) 'adds pctbullet to the collection of bullets
                    tmrBullet.Start()
                    intMaxAmountOfBullets = intMaxAmountOfBullets - 1
                    lblBullets.Text = intMaxAmountOfBullets
                    If intMaxAmountOfBullets = 0 Then
                        blnBullets = True
                        tmrReload.Start()
                    End If
                    spShot.Play()
                End If
            Case Asc(" ")
                If blnSpace = False And blnBullets = False Then 'Checks too see if paused or space is already depressed
                    blnSpace = True
                    pctBullet = New Windows.Forms.PictureBox ' pct bullet is created
                    pctBullet.Size = New System.Drawing.Size(12, 38) 'size of pct bullet is defined
                    pctBullet.Location = New System.Drawing.Point(pctUser.Location.X + 7, pctUser.Location.Y - 50) 'pct bullets location is defined
                    pctBullet.BackgroundImage = My.Resources.mylaser 'background image (image) defined as mylaser
                    Controls.Add(pctBullet) 'adds pct bullet to controls
                    cltBullets.Add(pctBullet) 'adds pctbullet to the collection of bullets
                    tmrBullet.Start()
                    intMaxAmountOfBullets = intMaxAmountOfBullets - 1
                    lblBullets.Text = intMaxAmountOfBullets
                    If intMaxAmountOfBullets = 0 Then
                        blnBullets = True
                        tmrReload.Start()
                    End If
                    spShot.Play()
                End If
        End Select
    End Sub

    '~~~~~~~~~~~~~~~~~~~~~
    'Starts timer upon activation of form
    '~~~~~~~~~~~~~~~~~~~
    Private Sub frmGame_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If My.Settings.UserChar = 2 Then
            pctUser.BackgroundImage = My.Resources.Farnsworth 'change to farnsworth if u please
        End If
        tmrEnemies.Start()
        tmrScore.Start()
    End Sub
    '~~~~~~~~~~~~~~~~~~~~~
    'When timer tmrEnemies ticking
    '~~~~~~~~~~~~~~~~~~~

    Private Sub tmrEnemies_Tick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrEnemies.Tick
        If intAmountOfEnemies <= intMaxTotalAmountOFEnemies Then 'ensures less than intMaxTotalAmountOFEnemies enemies
            intRandom = GetRandomNumber(1, 600)
            'random horizontal number between 1 and 600
            pctEnemy = New Windows.Forms.PictureBox() 'picturebox for enemy
            pctEnemy.Size = New System.Drawing.Size(40, 40) ' sets size of enemy
            pctEnemy.Location = New System.Drawing.Point(intRandom, -18) 'location X is random number between 1 and 600, Y is -18 so its just barely off of form
            intImage = GetRandomNumber(1, 3) 'random number between 1 and 3, this works below and ensures that the image is randomized each time
            Select Case intImage 'intImage should be 1 - 3
                Case 1
                    pctEnemy.Image = My.Resources.Wernstrom 'wernstrom is random number was 1
                Case 2
                    pctEnemy.Image = My.Resources.mom 'mom if random number was 2
                Case 3
                    pctEnemy.Image = My.Resources.clamps ' clamps if random number was 3 
            End Select
            pctEnemy.BackColor = Color.Transparent 'transparent BG
            Controls.Add(pctEnemy) 'add to controlls
            cltEnemies.Add(pctEnemy) 'add to the collection
            intAmountOfEnemies = intAmountOfEnemies + 1 'adds 1 too intamount of enemies which was -1 thusfar, to use in next subprocedure that moves enemies
            If intAmountOfEnemies = 0 Then 'if there is one enemy (0) then the tmr that controls movement will begin! :)
                tmrEnemyLocation.Start() 'start the enemy movign timer
                tmrEnemyBullet.Start() 'start enemy bullet timer

            End If
            If intAmountOfEnemies > 0 Then
                tmrCollision.Start() 'start collision timer
            End If
        End If
    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    ' MOVES ENEMY LEFT OR RIGHT 
    '       
    '     Decides whether the enemy should move left or right or down depending on its position
    '       
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub tmrEnemyLocation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemyLocation.Tick
        Static intDirectionHorizontal(intMaxTotalAmountOFEnemies) As Integer 'creates an array which includes a total of intMaxTotalAmountOFEnemies for direction horizontal
        Static intDirectionDown(intMaxTotalAmountOFEnemies) As Integer 'creates an array which includes a total of intMaxTotalAmountOFEnemies for direction down
        Dim intLocalAmtofEnemies As Integer 'Local Amount of enemies used with 



        For intLocalAmtofEnemies = 1 To intAmountOfEnemies - 1 ' acounter for assigning a different characteristic for movement to each enemy in the collection
            If intLocalAmtofEnemies = -1 Then 'to fix errors with numbers becoming negative or 0
                intLocalAmtofEnemies = 0
            ElseIf intAmountOfEnemies = 0 Then
                intLocalAmtofEnemies = 0
            End If


            If intDirectionHorizontal(intLocalAmtofEnemies) = 0 Then 'assigns intDirectionDown to 2 if its currently 0 
                intDirectionHorizontal(intLocalAmtofEnemies) = 2
            ElseIf intDirectionDown(intLocalAmtofEnemies) = 0 Then 'assigns intDirectionDown to 1 if its currently 0
                intDirectionDown(intLocalAmtofEnemies) = 1
            End If
            Select Case intDirectionHorizontal(intLocalAmtofEnemies)
                Case 2
                    Me.cltEnemies(intLocalAmtofEnemies).Left = Me.cltEnemies(intLocalAmtofEnemies).Left + 10 'moves right
                    If Me.cltEnemies(intLocalAmtofEnemies).Left >= 600 Then
                        intDirectionHorizontal(intLocalAmtofEnemies) = 1
                        intDirectionDown(intLocalAmtofEnemies) = 2 'moves down if intersects with the right of form
                    End If

                Case 1
                    Me.cltEnemies(intLocalAmtofEnemies).Left = Me.cltEnemies(intLocalAmtofEnemies).Left - 10 'moves left
                    If Me.cltEnemies(intLocalAmtofEnemies).Left <= 0 Then
                        intDirectionHorizontal(intLocalAmtofEnemies) = 2 'moves right
                        intDirectionDown(intLocalAmtofEnemies) = 2 'moves down if intersects with the left of form
                    End If

            End Select

            If intDirectionDown(intLocalAmtofEnemies) = 2 Then
                Me.cltEnemies(intLocalAmtofEnemies).Top = Me.cltEnemies(intLocalAmtofEnemies).Top + 60 'moves down 60
                intDirectionDown(intLocalAmtofEnemies) = 1

            End If
            If cltEnemies(intLocalAmtofEnemies).top >= 600 Then 'if the enemy is off form, hide him
                Me.cltEnemies(intLocalAmtofEnemies).visible = False
            End If
        Next


    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'This function will get a randomnumber between the optional intLow and optional intHigh,
    ' the random number can be used with any thing, and assigned to any variable, eliminating
    '    the need for many equations throughout the form
    ' Post: Random number between intHigh and intLow
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Public Function GetRandomNumber(Optional ByVal intLow As Integer = 1, Optional ByVal intHigh As Integer = 600) As Integer
        ' Generate random number between optional intLow and intHigh
        Randomize()
        Dim intRandomNumber As Integer = Int((intHigh - intLow + 1) * Rnd()) + intLow 'formula for random number
        Return intRandomNumber
    End Function
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'This timer controlls the bullet
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        End 'quit when clicked
    End Sub

    Private Sub mnuMainMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMainMenu.Click
        frmMenu.Show() 'show menu when clicked
        Me.Hide()
    End Sub

    Private Sub mnuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelp.Click 'show Help when clicked
        frmHelp.Show()
    End Sub


    Private Sub tmrBullet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBullet.Tick
        Dim intLocalAmountofBullets As Integer 'for a counter to call each item in collection
        Dim intLocalAmtOfEnemyBullets As Integer 'for a counter to call each item in collection
        If cltBullets.Count > 0 Then
            If cltBullets(cltBullets.Count).top < 300 Then 'Ensures you cant rapid fire bullets!
                blnSpace = False 'blnSpace is false to tell the keypress you can fire
            End If
        End If
        For intLocalAmountofBullets = 1 To cltBullets.Count
            Me.cltBullets(intLocalAmountofBullets).Top = Me.cltBullets(intLocalAmountofBullets).Top - 5 'moves each of my bullet down 5 
        Next

        For intLocalAmtOfEnemyBullets = 1 To intEnemyBulletAmount
            If intLocalAmtOfEnemyBullets = -1 Then 'fixes glitches that result in intLocalAmtOfEnemyBullets =  -1, 0, or greater than the actual amount of bullets
                intLocalAmtOfEnemyBullets = 1
            ElseIf intLocalAmtOfEnemyBullets = 0 Then
                intLocalAmtOfEnemyBullets = 1
            ElseIf intLocalAmtOfEnemyBullets > intEnemyBulletAmount Then
                intLocalAmtOfEnemyBullets = intEnemyBulletAmount
            End If
            Me.cltEnemiesBullets(intLocalAmtOfEnemyBullets).Top = Me.cltEnemiesBullets(intLocalAmtOfEnemyBullets).Top + 5 'moves each of enemies bullets down 5

        Next

    End Sub

    Private Sub tmrEnemyBullet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemyBullet.Tick
        pctEnemyBullet = New Windows.Forms.PictureBox ' pct bullet is created
        pctEnemyBullet.Size = New System.Drawing.Size(10, 10) 'size of pct bullet is defined
        pctEnemyBullet.Location = New System.Drawing.Point(GetRandomNumber) 'pct bullets location is defined, thought about making them shoot from enemy, but this seemed funner
        pctEnemyBullet.Image = My.Resources.pclaser 'background image (image) defined as mylaser
        Controls.Add(pctEnemyBullet) 'adds pct bullet to controls
        cltEnemiesBullets.Add(pctEnemyBullet) 'adds pctEnemybullet to the collection of bullets
        intEnemyBulletAmount = cltEnemiesBullets.Count
        If intEnemyBulletAmount = 1 Then 'starts bullet timer when bullet fired
            tmrBullet.Start()
        End If

    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Detects collisions
    'Post: blncollision as true or false
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub CollisonDetection()
        Dim intMaxScore As Integer = 2000
        Dim ctlObject As Control
        Dim intLocalAmountofEnemies As Integer 'counter for enemies collection
        Dim intLocalAmtOfBullets As Integer 'counter for bullets collection
        For Each ctlObject In Me.Controls
            If TypeOf ctlObject Is PictureBox Then
                If Not ctlObject.Name = "pctUser" Then 'so pctUser cant collide with pctUser
                    If ctlObject.Bounds.IntersectsWith(pctUser.Bounds) Then 'when something intersects with the user
                        ctlObject.Top = 2000
                        blnCollision = True 'returns true for blncollison
                    End If
                End If
            End If
        Next

        If blnArmor1 = True Then
            For intLocalAmtOfBullets = 1 To cltBullets.Count 'counter for bullets
                If cltBullets(intLocalAmtOfBullets).Bounds.IntersectsWith(lblArmor1.Bounds) Then 'if my bullet intersects
                    intArmor1 = intArmor1 - 1 'intarmor1 gets 1 less
                    lblArmor1.Text = intArmor1 'display that
                    cltBullets(intLocalAmtOfBullets).top = -29 'move bullet

                End If
            Next
            For intLocalAmtOfBullets = 1 To cltEnemiesBullets.Count 'same as above, below you will see repetitive code for the othe two armors
                If cltEnemiesBullets(intLocalAmtOfBullets).bounds.intersectswith(lblArmor1.Bounds) Then
                    intArmor1 = intArmor1 - 1
                    lblArmor1.Text = intArmor1
                    cltEnemiesBullets(intLocalAmtOfBullets).top = 2000

                End If
                If lblArmor1.Text = 0 Then 'if no armor left :(
                    blnArmor1 = False 'make false so cannot collide
                    lblArmor1.Visible = False 'remove lblarmor1
                End If

            Next
        End If
        '**********
        'below is same as above, look above for comments
        '**********
        If blnArmor2 = True Then
            For intLocalAmtOfBullets = 1 To cltBullets.Count
                If cltBullets(intLocalAmtOfBullets).Bounds.IntersectsWith(lblArmor2.Bounds) Then
                    intarmor2 = intarmor2 - 1
                    lblArmor2.Text = intarmor2
                    cltBullets(intLocalAmtOfBullets).top = -29
                End If
            Next
            For intLocalAmtOfBullets = 1 To cltEnemiesBullets.Count
                If cltEnemiesBullets(intLocalAmtOfBullets).bounds.intersectswith(lblArmor2.Bounds) Then
                    intarmor2 = intarmor2 - 1
                    lblArmor2.Text = intarmor2
                    cltEnemiesBullets(intLocalAmtOfBullets).top = 2000

                End If
                If lblArmor2.Text = 0 Then
                    blnArmor2 = False
                    lblArmor2.Visible = False
                End If
            Next
        End If
        '**********
        'below is same as above, look above for comments
        '**********
        If blnArmor3 = True Then
            For intLocalAmtOfBullets = 1 To cltBullets.Count
                If cltBullets(intLocalAmtOfBullets).Bounds.IntersectsWith(lblArmor3.Bounds) Then
                    intArmor3 = intArmor3 - 1
                    lblArmor3.Text = intArmor3
                    cltBullets(intLocalAmtOfBullets).top = -29
                End If
            Next
            For intLocalAmtOfBullets = 1 To cltEnemiesBullets.Count
                If cltEnemiesBullets(intLocalAmtOfBullets).bounds.intersectswith(lblArmor3.Bounds) Then
                    intArmor3 = intArmor3 - 1
                    lblArmor3.Text = intArmor3
                    cltEnemiesBullets(intLocalAmtOfBullets).top = 2000

                End If
                If lblArmor3.Text = 0 Then
                    blnArmor3 = False
                    lblArmor3.Visible = False
                End If
            Next
        End If
        '**********
        If intAmountOfEnemies > 1 And cltBullets.Count > 1 Then
            For intLocalAmountofEnemies = 1 To intAmountOfEnemies 'counter for enemies
                If intLocalAmountofEnemies > intAmountOfEnemies Then 'fixes glitches
                    intLocalAmountofEnemies = intAmountOfEnemies
                End If
                For intLocalAmtOfBullets = 1 To cltBullets.Count 'a counter to ensure every bullet is checked

                    If intLocalAmtOfBullets > cltBullets.Count Then 'ensure that if the local amount of bullets is greater than the total bullets 
                        intLocalAmtOfBullets = cltBullets.Count - 1  'make intlocalamountofbullets the same as the global amount
                    End If
                    If intLocalAmountofEnemies > intAmountOfEnemies Then 'if local amount of enemies is greater than total enemies
                        intLocalAmountofEnemies = intAmountOfEnemies - 1 'make local same as global
                    End If
                    If cltBullets(intLocalAmtOfBullets).Top > 0 Then ' ensure the bullet is on the form


                        If intAmountOfEnemies > 0 And cltBullets.Count > 0 Then 'make sure there are infact more than 0 enemies and bullets
                            If intLocalAmtOfBullets > cltBullets.Count Then 'fixes glitches
                                intLocalAmtOfBullets = cltBullets.Count
                            End If

                            If cltBullets(intLocalAmtOfBullets).Bounds.IntersectsWith(cltEnemies(intLocalAmountofEnemies).Bounds) Then 'bounds intersect for cltbullets and cltenemies
                                pctExplosion = New Windows.Forms.PictureBox ' pct exposion is created
                                pctExplosion.Size = New System.Drawing.Size(50, 63) 'size of explosion is defined
                                pctExplosion.Location = New System.Drawing.Point(cltEnemies(intLocalAmountofEnemies).Location.X, cltEnemies(intLocalAmountofEnemies).Location.Y) 'pct explosion location is defined
                                pctExplosion.Image = My.Resources.explosion 'background image (image) defined as explosion
                                Controls.Add(pctExplosion) 'adds explosion to controls
                                cltExplosions.Add(pctExplosion) 'adds pctExplosion to the collection of explosions
                                tmrExplosion.Start()
                                cltBullets(intLocalAmtOfBullets).top = -29 'moves bullet off form
                                cltEnemies(intLocalAmountofEnemies).top = 1000 'moves enemy off form
                                intScore = intScore + 100 'add 100 to intscore
                                lblScore.Text = intScore 'assigns intscore to score label
                                spExplode.Play()
                                If intScore = intMaxScore Then 'if intScore = intMaxScore then you win
                                    tmrBullet.Stop() 'stops timers
                                    tmrCollision.Stop()
                                    tmrEnemies.Stop()
                                    tmrEnemyBullet.Stop()
                                    tmrEnemyLocation.Stop()
                                    If intTime > intHighScore Then
                                        intHighScore = intTime
                                        My.Settings.HighScore2 = intHighScore
                                        My.Settings.Save1 = 3
                                        My.Settings.Save()
                                        MessageBox.Show("NEW HIGH SCORE, YOU WIN! Your high score: " & intHighScore) 'if your high score is higher than the high score then you get high score
                                    Else
                                        MessageBox.Show("You Win") 'you win if its not, too!
                                    End If
                                    MessageBox.Show("This is level 3, Insanity. Good luck, hit ok when ready!")
                                    Me.Hide() 'hides form
                                    frmGame3.Show()
                                End If
                            End If
                        End If

                    End If
                Next
            Next
        End If
    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'DETECTS COLLISON
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub tmrCollison_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCollision.Tick

        CollisonDetection() 'Call collision detection

        If blnCollision = True Then 'if collision detection returns true
            Me.pctUser.Hide() 'hide the user
            Me.pctUser.Left = 293 'move user to default position
            Me.pctUser.Top = 416 'move user to default position
            intLives = intLives - 1 '1 life less
            Select Case intLives
                Case 4 'if 4 lives
                    pctHeart.Show()
                    pctHeart2.Show()
                    pctHeart3.Show()
                Case 3 'if 3 lives
                    pctHeart2.Show()
                    pctHeart.Show()
                    pctHeart3.Hide()
                Case 2 'if 2 lives
                    pctHeart.Show()
                    pctHeart2.Hide()
                    pctHeart3.Hide()
                Case 1 'if 1 life
                    pctHeart.Hide()
                    pctHeart2.Hide()
                    pctHeart3.Hide()
                Case 0 'if 0 lives u lose
                    frmLose.Show()
                    Me.Hide()
            End Select
            Me.pctUser.Show() 'show user


        End If
        blnCollision = False
    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~
    'RELOADS YOUR WEAPON
    '~~~~~~~~~~~~~~~~~~~~
    Private Sub tmrReload_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrReload.Tick
        Dim spReload As System.Media.SoundPlayer = New System.Media.SoundPlayer(SpaceInvaders.My.Resources._03_clip) 'soundplayer for reload
        Dim spReload2 As System.Media.SoundPlayer = New System.Media.SoundPlayer(SpaceInvaders.My.Resources._04_milaction) 'soundplayer for reload
        If lblBullets.Text = 10 Then 'when 10 shots are in 
            tmrReload.Stop() 'stops reloading
            blnBullets = False 'sets boolean that controlls reloading to false
            spReload.Play()
        End If
        If lblBullets.Text < 10 Then 'as long as you have less than 10 bullets in your clip, it will continue to reload
            intMaxAmountOfBullets = intMaxAmountOfBullets + 1 'adds a bullet to your clip
            lblBullets.Text = intMaxAmountOfBullets
            spReload2.Play()
        End If
    End Sub
    '~~~~~~~~
    'Pause
    '~~~~~~~~~
    Private Sub mnuPause_Click(sender As System.Object, e As System.EventArgs) Handles mnuPause.Click
        tmrBullet.Stop()
        tmrCollision.Stop()
        tmrEnemies.Stop()
        tmrEnemyBullet.Stop() 'stops timers
        tmrEnemyLocation.Stop()
    End Sub
    '~~~~~~~~
    'Resume
    '~~~~~~~~~
    Private Sub mnuResume_Click(sender As System.Object, e As System.EventArgs) Handles mnuResume.Click
        tmrBullet.Start() 'starts the timers
        tmrCollision.Start()
        tmrEnemies.Start()
        tmrEnemyBullet.Start()
        tmrEnemyLocation.Start()
    End Sub
    '~~~~~~~~
    'Adds 1 to your score for each second
    '~~~~~~~~~
    Private Sub tmrScore_Tick(sender As System.Object, e As System.EventArgs) Handles tmrScore.Tick
        intTime = intTime + 1
        lblTime.Text = intTime
    End Sub

    Private Sub mnuLoseScreen_Click(sender As System.Object, e As System.EventArgs) Handles mnuLoseScreen.Click
        Me.Hide()
        frmLose.Show() 'show lose form on the dev tools lose screen button click
    End Sub

    Private Sub mnuWinScreen_Click(sender As System.Object, e As System.EventArgs) Handles mnuWinScreen.Click
        Me.Hide()
        frmWin.Show() 'show win form when win form clicked
    End Sub

    Private Sub mnuHighScore_Click(sender As System.Object, e As System.EventArgs) Handles mnuHighScore.Click 'tell user current high score
        MessageBox.Show("Current High Score = " & My.Settings.HighScore2)
    End Sub


    Private Sub mnuLevel2_Click(sender As System.Object, e As System.EventArgs) Handles mnuLevel2.Click
        Me.Show()
    End Sub

    Private Sub mnuLevel1_Click(sender As System.Object, e As System.EventArgs) Handles mnuLevel1.Click
        frmGame.Show()
    End Sub

    Private Sub mnuLevel3_Click(sender As System.Object, e As System.EventArgs) Handles mnuLevel3.Click
        frmGame3.show()
    End Sub

    Private Sub tmrExplosion_Tick(sender As System.Object, e As System.EventArgs) Handles tmrExplosion.Tick
        Dim intExplosionsCounter As Integer 'counter for below loop

        intSeconds = intSeconds + 1
        If intSeconds = 3 Then
            If cltExplosions.Count > 0 Then
                For intExplosionsCounter = 1 To cltExplosions.Count 'to remove explosions
                    cltExplosions(intExplosionsCounter).visible = False
                Next
            End If
            intSeconds = 0
        End If
    End Sub
End Class
