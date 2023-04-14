<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPLASH
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
        Me.PbProgress = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PbProgress
        '
        Me.PbProgress.BackColor = System.Drawing.SystemColors.Control
        Me.PbProgress.Location = New System.Drawing.Point(72, 384)
        Me.PbProgress.Name = "PbProgress"
        Me.PbProgress.Size = New System.Drawing.Size(656, 16)
        Me.PbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PbProgress.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(240, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 106)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SocMed"
        '
        'SPLASH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SocMed.My.Resources.Resources.koding
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PbProgress)
        Me.Name = "SPLASH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPLASH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbProgress As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
