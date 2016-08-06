<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.tmrEnemyLocation = New System.Windows.Forms.Timer(Me.components)
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPause = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResume = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHighScore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuDevTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLoseScreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWinScreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLevel1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLevel2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLevel3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.tmrBullet = New System.Windows.Forms.Timer(Me.components)
        Me.lblScoreInfo = New System.Windows.Forms.Label()
        Me.tmrEnemyBullet = New System.Windows.Forms.Timer(Me.components)
        Me.lblBulletsInfo = New System.Windows.Forms.Label()
        Me.lblBullets = New System.Windows.Forms.Label()
        Me.tmrCollision = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.tmrEnemies = New System.Windows.Forms.Timer(Me.components)
        Me.tmrReload = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScore = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeInfo = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblArmor1 = New System.Windows.Forms.Label()
        Me.lblArmor2 = New System.Windows.Forms.Label()
        Me.lblArmor3 = New System.Windows.Forms.Label()
        Me.tmrExplosions = New System.Windows.Forms.Timer(Me.components)
        Me.pctHeart3 = New System.Windows.Forms.PictureBox()
        Me.pctHeart2 = New System.Windows.Forms.PictureBox()
        Me.pctHeart = New System.Windows.Forms.PictureBox()
        Me.pctUser = New System.Windows.Forms.PictureBox()
        Me.mnuMain.SuspendLayout()
        CType(Me.pctHeart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHeart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHeart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrEnemyLocation
        '
        Me.tmrEnemyLocation.Interval = 50
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuQuit, Me.mnuMainMenu, Me.mnuHelp, Me.mnuPause, Me.mnuResume, Me.mnuHighScore})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(40, 20)
        Me.mnuFile.Text = "File "
        '
        'mnuQuit
        '
        Me.mnuQuit.Name = "mnuQuit"
        Me.mnuQuit.Size = New System.Drawing.Size(135, 22)
        Me.mnuQuit.Text = "Quit"
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(135, 22)
        Me.mnuMainMenu.Text = "Main Menu"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(135, 22)
        Me.mnuHelp.Text = "Help"
        '
        'mnuPause
        '
        Me.mnuPause.Name = "mnuPause"
        Me.mnuPause.Size = New System.Drawing.Size(135, 22)
        Me.mnuPause.Text = "Pause"
        '
        'mnuResume
        '
        Me.mnuResume.Name = "mnuResume"
        Me.mnuResume.Size = New System.Drawing.Size(135, 22)
        Me.mnuResume.Text = "Resume"
        '
        'mnuHighScore
        '
        Me.mnuHighScore.Name = "mnuHighScore"
        Me.mnuHighScore.Size = New System.Drawing.Size(135, 22)
        Me.mnuHighScore.Text = "High Score"
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuDevTools})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(640, 24)
        Me.mnuMain.TabIndex = 5
        Me.mnuMain.Text = "mnuMain"
        '
        'mnuDevTools
        '
        Me.mnuDevTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLoseScreen, Me.mnuWinScreen, Me.mnuLevel1, Me.mnuLevel2, Me.mnuLevel3})
        Me.mnuDevTools.Name = "mnuDevTools"
        Me.mnuDevTools.Size = New System.Drawing.Size(71, 20)
        Me.mnuDevTools.Text = "Dev Tools"
        '
        'mnuLoseScreen
        '
        Me.mnuLoseScreen.Name = "mnuLoseScreen"
        Me.mnuLoseScreen.Size = New System.Drawing.Size(136, 22)
        Me.mnuLoseScreen.Text = "Lose Screen"
        '
        'mnuWinScreen
        '
        Me.mnuWinScreen.Name = "mnuWinScreen"
        Me.mnuWinScreen.Size = New System.Drawing.Size(136, 22)
        Me.mnuWinScreen.Text = "Win Screen"
        '
        'mnuLevel1
        '
        Me.mnuLevel1.Name = "mnuLevel1"
        Me.mnuLevel1.Size = New System.Drawing.Size(136, 22)
        Me.mnuLevel1.Text = "Level 1"
        '
        'mnuLevel2
        '
        Me.mnuLevel2.Name = "mnuLevel2"
        Me.mnuLevel2.Size = New System.Drawing.Size(136, 22)
        Me.mnuLevel2.Text = "Level 2"
        '
        'mnuLevel3
        '
        Me.mnuLevel3.Name = "mnuLevel3"
        Me.mnuLevel3.Size = New System.Drawing.Size(136, 22)
        Me.mnuLevel3.Text = "Level 3"
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.BackColor = System.Drawing.Color.Transparent
        Me.lblLives.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLives.Location = New System.Drawing.Point(533, 30)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(35, 13)
        Me.lblLives.TabIndex = 4
        Me.lblLives.Text = "Lives:"
        '
        'tmrBullet
        '
        Me.tmrBullet.Interval = 10
        '
        'lblScoreInfo
        '
        Me.lblScoreInfo.AutoSize = True
        Me.lblScoreInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblScoreInfo.Location = New System.Drawing.Point(12, 27)
        Me.lblScoreInfo.Name = "lblScoreInfo"
        Me.lblScoreInfo.Size = New System.Drawing.Size(47, 16)
        Me.lblScoreInfo.TabIndex = 4
        Me.lblScoreInfo.Text = "Score:"
        '
        'tmrEnemyBullet
        '
        Me.tmrEnemyBullet.Interval = 2500
        '
        'lblBulletsInfo
        '
        Me.lblBulletsInfo.AutoSize = True
        Me.lblBulletsInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblBulletsInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBulletsInfo.Location = New System.Drawing.Point(427, 30)
        Me.lblBulletsInfo.Name = "lblBulletsInfo"
        Me.lblBulletsInfo.Size = New System.Drawing.Size(41, 13)
        Me.lblBulletsInfo.TabIndex = 4
        Me.lblBulletsInfo.Text = "Bullets:"
        '
        'lblBullets
        '
        Me.lblBullets.AutoSize = True
        Me.lblBullets.BackColor = System.Drawing.Color.Transparent
        Me.lblBullets.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBullets.Location = New System.Drawing.Point(474, 30)
        Me.lblBullets.Name = "lblBullets"
        Me.lblBullets.Size = New System.Drawing.Size(19, 13)
        Me.lblBullets.TabIndex = 4
        Me.lblBullets.Text = "10"
        '
        'tmrCollision
        '
        Me.tmrCollision.Interval = 1
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblScore.Location = New System.Drawing.Point(56, 30)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(13, 13)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "0"
        '
        'tmrEnemies
        '
        Me.tmrEnemies.Interval = 1500
        '
        'tmrReload
        '
        Me.tmrReload.Interval = 400
        '
        'tmrScore
        '
        Me.tmrScore.Interval = 1000
        '
        'lblTimeInfo
        '
        Me.lblTimeInfo.AutoSize = True
        Me.lblTimeInfo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTimeInfo.Location = New System.Drawing.Point(115, 30)
        Me.lblTimeInfo.Name = "lblTimeInfo"
        Me.lblTimeInfo.Size = New System.Drawing.Size(33, 13)
        Me.lblTimeInfo.TabIndex = 8
        Me.lblTimeInfo.Text = "Time:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTime.Location = New System.Drawing.Point(154, 30)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(13, 13)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "0"
        '
        'lblArmor1
        '
        Me.lblArmor1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblArmor1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblArmor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArmor1.Location = New System.Drawing.Point(48, 340)
        Me.lblArmor1.Name = "lblArmor1"
        Me.lblArmor1.Size = New System.Drawing.Size(100, 31)
        Me.lblArmor1.TabIndex = 9
        Me.lblArmor1.Text = "10"
        Me.lblArmor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArmor2
        '
        Me.lblArmor2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblArmor2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblArmor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArmor2.Location = New System.Drawing.Point(270, 340)
        Me.lblArmor2.Name = "lblArmor2"
        Me.lblArmor2.Size = New System.Drawing.Size(100, 31)
        Me.lblArmor2.TabIndex = 10
        Me.lblArmor2.Text = "10"
        Me.lblArmor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArmor3
        '
        Me.lblArmor3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblArmor3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblArmor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArmor3.Location = New System.Drawing.Point(492, 339)
        Me.lblArmor3.Name = "lblArmor3"
        Me.lblArmor3.Size = New System.Drawing.Size(100, 32)
        Me.lblArmor3.TabIndex = 11
        Me.lblArmor3.Text = "10"
        Me.lblArmor3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrExplosions
        '
        Me.tmrExplosions.Interval = 1000
        '
        'pctHeart3
        '
        Me.pctHeart3.BackColor = System.Drawing.Color.Transparent
        Me.pctHeart3.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.heart
        Me.pctHeart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctHeart3.Location = New System.Drawing.Point(616, 30)
        Me.pctHeart3.Name = "pctHeart3"
        Me.pctHeart3.Size = New System.Drawing.Size(20, 16)
        Me.pctHeart3.TabIndex = 3
        Me.pctHeart3.TabStop = False
        '
        'pctHeart2
        '
        Me.pctHeart2.BackColor = System.Drawing.Color.Transparent
        Me.pctHeart2.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.heart
        Me.pctHeart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctHeart2.Location = New System.Drawing.Point(595, 30)
        Me.pctHeart2.Name = "pctHeart2"
        Me.pctHeart2.Size = New System.Drawing.Size(20, 16)
        Me.pctHeart2.TabIndex = 3
        Me.pctHeart2.TabStop = False
        '
        'pctHeart
        '
        Me.pctHeart.BackColor = System.Drawing.Color.Transparent
        Me.pctHeart.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.heart
        Me.pctHeart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctHeart.Location = New System.Drawing.Point(572, 30)
        Me.pctHeart.Name = "pctHeart"
        Me.pctHeart.Size = New System.Drawing.Size(20, 16)
        Me.pctHeart.TabIndex = 3
        Me.pctHeart.TabStop = False
        '
        'pctUser
        '
        Me.pctUser.BackColor = System.Drawing.Color.Transparent
        Me.pctUser.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.ship
        Me.pctUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctUser.Location = New System.Drawing.Point(293, 416)
        Me.pctUser.Name = "pctUser"
        Me.pctUser.Size = New System.Drawing.Size(49, 96)
        Me.pctUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctUser.TabIndex = 0
        Me.pctUser.TabStop = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(640, 508)
        Me.Controls.Add(Me.lblArmor3)
        Me.Controls.Add(Me.lblArmor2)
        Me.Controls.Add(Me.lblArmor1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblTimeInfo)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreInfo)
        Me.Controls.Add(Me.lblBullets)
        Me.Controls.Add(Me.lblBulletsInfo)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.pctHeart3)
        Me.Controls.Add(Me.pctHeart2)
        Me.Controls.Add(Me.pctHeart)
        Me.Controls.Add(Me.pctUser)
        Me.Controls.Add(Me.mnuMain)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmGame"
        Me.Text = "Futurama Invaders: Game Level 1"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        CType(Me.pctHeart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctHeart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctHeart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctUser As System.Windows.Forms.PictureBox
    Friend WithEvents tmrEnemyLocation As System.Windows.Forms.Timer
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMainMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents lblLives As System.Windows.Forms.Label
    Friend WithEvents tmrBullet As System.Windows.Forms.Timer
    Friend WithEvents lblScoreInfo As System.Windows.Forms.Label
    Friend WithEvents pctHeart As System.Windows.Forms.PictureBox
    Friend WithEvents pctHeart2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctHeart3 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrEnemyBullet As System.Windows.Forms.Timer
    Friend WithEvents lblBulletsInfo As System.Windows.Forms.Label
    Friend WithEvents lblBullets As System.Windows.Forms.Label
    Friend WithEvents tmrCollision As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents tmrEnemies As System.Windows.Forms.Timer
    Friend WithEvents tmrReload As System.Windows.Forms.Timer
    Friend WithEvents mnuPause As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuResume As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrScore As System.Windows.Forms.Timer
    Friend WithEvents lblTimeInfo As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents mnuDevTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLoseScreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWinScreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHighScore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLevel1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLevel2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLevel3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblArmor1 As System.Windows.Forms.Label
    Friend WithEvents lblArmor2 As System.Windows.Forms.Label
    Friend WithEvents lblArmor3 As System.Windows.Forms.Label
    Friend WithEvents tmrExplosions As System.Windows.Forms.Timer
End Class