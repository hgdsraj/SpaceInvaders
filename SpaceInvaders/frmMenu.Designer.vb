<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.pctPlay = New System.Windows.Forms.PictureBox()
        Me.pctHelp = New System.Windows.Forms.PictureBox()
        Me.pctQuit = New System.Windows.Forms.PictureBox()
        Me.pctZoidBerg = New System.Windows.Forms.PictureBox()
        Me.pctMute = New System.Windows.Forms.PictureBox()
        Me.pctPlayButton = New System.Windows.Forms.PictureBox()
        CType(Me.pctPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctZoidBerg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctMute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPlayButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctPlay
        '
        Me.pctPlay.Location = New System.Drawing.Point(0, 0)
        Me.pctPlay.Name = "pctPlay"
        Me.pctPlay.Size = New System.Drawing.Size(100, 50)
        Me.pctPlay.TabIndex = 0
        Me.pctPlay.TabStop = False
        '
        'pctHelp
        '
        Me.pctHelp.BackColor = System.Drawing.Color.Transparent
        Me.pctHelp.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.help
        Me.pctHelp.Location = New System.Drawing.Point(247, 24)
        Me.pctHelp.Name = "pctHelp"
        Me.pctHelp.Size = New System.Drawing.Size(138, 76)
        Me.pctHelp.TabIndex = 1
        Me.pctHelp.TabStop = False
        '
        'pctQuit
        '
        Me.pctQuit.BackColor = System.Drawing.Color.Transparent
        Me.pctQuit.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.quit
        Me.pctQuit.Location = New System.Drawing.Point(462, 24)
        Me.pctQuit.Name = "pctQuit"
        Me.pctQuit.Size = New System.Drawing.Size(138, 76)
        Me.pctQuit.TabIndex = 2
        Me.pctQuit.TabStop = False
        '
        'pctZoidBerg
        '
        Me.pctZoidBerg.BackColor = System.Drawing.Color.Transparent
        Me.pctZoidBerg.Location = New System.Drawing.Point(505, 360)
        Me.pctZoidBerg.Name = "pctZoidBerg"
        Me.pctZoidBerg.Size = New System.Drawing.Size(138, 106)
        Me.pctZoidBerg.TabIndex = 3
        Me.pctZoidBerg.TabStop = False
        '
        'pctMute
        '
        Me.pctMute.BackColor = System.Drawing.Color.Transparent
        Me.pctMute.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.sound
        Me.pctMute.Location = New System.Drawing.Point(0, 426)
        Me.pctMute.Name = "pctMute"
        Me.pctMute.Size = New System.Drawing.Size(40, 40)
        Me.pctMute.TabIndex = 4
        Me.pctMute.TabStop = False
        '
        'pctPlayButton
        '
        Me.pctPlayButton.BackColor = System.Drawing.Color.Transparent
        Me.pctPlayButton.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.playbutton
        Me.pctPlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctPlayButton.Location = New System.Drawing.Point(46, 20)
        Me.pctPlayButton.Name = "pctPlayButton"
        Me.pctPlayButton.Size = New System.Drawing.Size(144, 80)
        Me.pctPlayButton.TabIndex = 5
        Me.pctPlayButton.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.Title_Screen
        Me.ClientSize = New System.Drawing.Size(639, 464)
        Me.Controls.Add(Me.pctPlayButton)
        Me.Controls.Add(Me.pctMute)
        Me.Controls.Add(Me.pctZoidBerg)
        Me.Controls.Add(Me.pctQuit)
        Me.Controls.Add(Me.pctHelp)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenu"
        Me.Text = "Futurama Invaders: Menu"
        CType(Me.pctPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctQuit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctZoidBerg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctMute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPlayButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctPlay As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelp As System.Windows.Forms.PictureBox
    Friend WithEvents pctQuit As System.Windows.Forms.PictureBox
    Friend WithEvents pctZoidBerg As System.Windows.Forms.PictureBox
    Friend WithEvents pctMute As System.Windows.Forms.PictureBox
    Friend WithEvents pctPlayButton As System.Windows.Forms.PictureBox

End Class


