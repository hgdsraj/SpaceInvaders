<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.pctHome = New System.Windows.Forms.PictureBox()
        CType(Me.pctHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctHome
        '
        Me.pctHome.BackColor = System.Drawing.Color.Transparent
        Me.pctHome.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.back
        Me.pctHome.Location = New System.Drawing.Point(510, -3)
        Me.pctHome.Name = "pctHome"
        Me.pctHome.Size = New System.Drawing.Size(137, 78)
        Me.pctHome.TabIndex = 0
        Me.pctHome.TabStop = False
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SpaceInvaders.My.Resources.Resources.helpbg
        Me.ClientSize = New System.Drawing.Size(647, 481)
        Me.Controls.Add(Me.pctHome)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHelp"
        Me.Text = "Futurama Invaders: Help"
        CType(Me.pctHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctHome As System.Windows.Forms.PictureBox
End Class
