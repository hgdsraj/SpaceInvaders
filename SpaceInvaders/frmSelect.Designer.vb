<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelect))
        Me.btnRestoreFromSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblSavedLevel = New System.Windows.Forms.Label()
        Me.lblSavedLvl = New System.Windows.Forms.Label()
        Me.radFarnsworth = New System.Windows.Forms.RadioButton()
        Me.grpCharSelect = New System.Windows.Forms.GroupBox()
        Me.pctFarnsworth = New System.Windows.Forms.PictureBox()
        Me.pctShip = New System.Windows.Forms.PictureBox()
        Me.radShip = New System.Windows.Forms.RadioButton()
        Me.lblHS1 = New System.Windows.Forms.Label()
        Me.lblHS2 = New System.Windows.Forms.Label()
        Me.lblHS3 = New System.Windows.Forms.Label()
        Me.grpCharSelect.SuspendLayout()
        CType(Me.pctFarnsworth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctShip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRestoreFromSave
        '
        Me.btnRestoreFromSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestoreFromSave.Location = New System.Drawing.Point(12, 60)
        Me.btnRestoreFromSave.Name = "btnRestoreFromSave"
        Me.btnRestoreFromSave.Size = New System.Drawing.Size(234, 57)
        Me.btnRestoreFromSave.TabIndex = 1
        Me.btnRestoreFromSave.Text = "Restore From Save"
        Me.btnRestoreFromSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(12, 187)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(234, 57)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New Game"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblSavedLevel
        '
        Me.lblSavedLevel.AutoSize = True
        Me.lblSavedLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblSavedLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSavedLevel.Location = New System.Drawing.Point(31, 18)
        Me.lblSavedLevel.Name = "lblSavedLevel"
        Me.lblSavedLevel.Size = New System.Drawing.Size(79, 13)
        Me.lblSavedLevel.TabIndex = 2
        Me.lblSavedLevel.Text = "Saved Level = "
        '
        'lblSavedLvl
        '
        Me.lblSavedLvl.AutoSize = True
        Me.lblSavedLvl.BackColor = System.Drawing.Color.Transparent
        Me.lblSavedLvl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSavedLvl.Location = New System.Drawing.Point(116, 18)
        Me.lblSavedLvl.Name = "lblSavedLvl"
        Me.lblSavedLvl.Size = New System.Drawing.Size(0, 13)
        Me.lblSavedLvl.TabIndex = 3
        '
        'radFarnsworth
        '
        Me.radFarnsworth.AutoSize = True
        Me.radFarnsworth.Location = New System.Drawing.Point(102, 123)
        Me.radFarnsworth.Name = "radFarnsworth"
        Me.radFarnsworth.Size = New System.Drawing.Size(107, 24)
        Me.radFarnsworth.TabIndex = 4
        Me.radFarnsworth.Text = "Farnsworth"
        Me.radFarnsworth.UseVisualStyleBackColor = True
        '
        'grpCharSelect
        '
        Me.grpCharSelect.Controls.Add(Me.pctFarnsworth)
        Me.grpCharSelect.Controls.Add(Me.pctShip)
        Me.grpCharSelect.Controls.Add(Me.radShip)
        Me.grpCharSelect.Controls.Add(Me.radFarnsworth)
        Me.grpCharSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCharSelect.Location = New System.Drawing.Point(329, 69)
        Me.grpCharSelect.Name = "grpCharSelect"
        Me.grpCharSelect.Size = New System.Drawing.Size(214, 155)
        Me.grpCharSelect.TabIndex = 5
        Me.grpCharSelect.TabStop = False
        Me.grpCharSelect.Text = "Character Select"
        '
        'pctFarnsworth
        '
        Me.pctFarnsworth.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.Farnsworth
        Me.pctFarnsworth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctFarnsworth.Location = New System.Drawing.Point(133, 67)
        Me.pctFarnsworth.Name = "pctFarnsworth"
        Me.pctFarnsworth.Size = New System.Drawing.Size(55, 50)
        Me.pctFarnsworth.TabIndex = 7
        Me.pctFarnsworth.TabStop = False
        '
        'pctShip
        '
        Me.pctShip.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.ship
        Me.pctShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pctShip.Location = New System.Drawing.Point(35, 29)
        Me.pctShip.Name = "pctShip"
        Me.pctShip.Size = New System.Drawing.Size(45, 88)
        Me.pctShip.TabIndex = 6
        Me.pctShip.TabStop = False
        '
        'radShip
        '
        Me.radShip.AutoSize = True
        Me.radShip.Checked = True
        Me.radShip.Location = New System.Drawing.Point(21, 123)
        Me.radShip.Name = "radShip"
        Me.radShip.Size = New System.Drawing.Size(59, 24)
        Me.radShip.TabIndex = 5
        Me.radShip.TabStop = True
        Me.radShip.Text = "Ship"
        Me.radShip.UseVisualStyleBackColor = True
        '
        'lblHS1
        '
        Me.lblHS1.AutoSize = True
        Me.lblHS1.BackColor = System.Drawing.Color.Transparent
        Me.lblHS1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHS1.Location = New System.Drawing.Point(326, 243)
        Me.lblHS1.Name = "lblHS1"
        Me.lblHS1.Size = New System.Drawing.Size(104, 13)
        Me.lblHS1.TabIndex = 2
        Me.lblHS1.Text = "High Score Level 1: "
        '
        'lblHS2
        '
        Me.lblHS2.AutoSize = True
        Me.lblHS2.BackColor = System.Drawing.Color.Transparent
        Me.lblHS2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHS2.Location = New System.Drawing.Point(326, 276)
        Me.lblHS2.Name = "lblHS2"
        Me.lblHS2.Size = New System.Drawing.Size(104, 13)
        Me.lblHS2.TabIndex = 2
        Me.lblHS2.Text = "High Score Level 2: "
        '
        'lblHS3
        '
        Me.lblHS3.AutoSize = True
        Me.lblHS3.BackColor = System.Drawing.Color.Transparent
        Me.lblHS3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHS3.Location = New System.Drawing.Point(326, 310)
        Me.lblHS3.Name = "lblHS3"
        Me.lblHS3.Size = New System.Drawing.Size(101, 13)
        Me.lblHS3.TabIndex = 2
        Me.lblHS3.Text = "High Score Level 3:"
        Me.lblHS3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(640, 382)
        Me.Controls.Add(Me.grpCharSelect)
        Me.Controls.Add(Me.lblSavedLvl)
        Me.Controls.Add(Me.lblHS3)
        Me.Controls.Add(Me.lblHS2)
        Me.Controls.Add(Me.lblHS1)
        Me.Controls.Add(Me.lblSavedLevel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnRestoreFromSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSelect"
        Me.Text = "Futurama Invaders: Select Screen"
        Me.grpCharSelect.ResumeLayout(False)
        Me.grpCharSelect.PerformLayout()
        CType(Me.pctFarnsworth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctShip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRestoreFromSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents lblSavedLevel As System.Windows.Forms.Label
    Friend WithEvents lblSavedLvl As System.Windows.Forms.Label
    Friend WithEvents radFarnsworth As System.Windows.Forms.RadioButton
    Friend WithEvents grpCharSelect As System.Windows.Forms.GroupBox
    Friend WithEvents pctFarnsworth As System.Windows.Forms.PictureBox
    Friend WithEvents pctShip As System.Windows.Forms.PictureBox
    Friend WithEvents radShip As System.Windows.Forms.RadioButton
    Friend WithEvents lblHS1 As System.Windows.Forms.Label
    Friend WithEvents lblHS2 As System.Windows.Forms.Label
    Friend WithEvents lblHS3 As System.Windows.Forms.Label
End Class
