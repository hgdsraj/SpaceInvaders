<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStory))
        Me.pctSkip = New System.Windows.Forms.PictureBox()
        CType(Me.pctSkip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctSkip
        '
        Me.pctSkip.BackColor = System.Drawing.Color.Transparent
        Me.pctSkip.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.skip
        Me.pctSkip.Location = New System.Drawing.Point(540, 411)
        Me.pctSkip.Name = "pctSkip"
        Me.pctSkip.Size = New System.Drawing.Size(88, 53)
        Me.pctSkip.TabIndex = 0
        Me.pctSkip.TabStop = False
        '
        'frmStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.help1
        Me.ClientSize = New System.Drawing.Size(640, 476)
        Me.Controls.Add(Me.pctSkip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStory"
        Me.Text = "Futurama Invaders: Story"
        CType(Me.pctSkip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctSkip As System.Windows.Forms.PictureBox
End Class
