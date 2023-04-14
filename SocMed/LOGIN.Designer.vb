<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TbEmail = New System.Windows.Forms.TextBox()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnSignup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbEmail
        '
        Me.TbEmail.Location = New System.Drawing.Point(40, 192)
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.PlaceholderText = "Username"
        Me.TbEmail.Size = New System.Drawing.Size(208, 23)
        Me.TbEmail.TabIndex = 0
        '
        'TbPassword
        '
        Me.TbPassword.Location = New System.Drawing.Point(40, 232)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPassword.PlaceholderText = "Password"
        Me.TbPassword.Size = New System.Drawing.Size(208, 23)
        Me.TbPassword.TabIndex = 1
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Location = New System.Drawing.Point(104, 280)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "LOGIN"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnSignup
        '
        Me.BtnSignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnSignup.FlatAppearance.BorderSize = 0
        Me.BtnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignup.Location = New System.Drawing.Point(104, 312)
        Me.BtnSignup.Name = "BtnSignup"
        Me.BtnSignup.Size = New System.Drawing.Size(75, 23)
        Me.BtnSignup.TabIndex = 3
        Me.BtnSignup.Text = "SIGNUP"
        Me.BtnSignup.UseVisualStyleBackColor = False
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SocMed.My.Resources.Resources.plasma_ball
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSignup)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TbPassword)
        Me.Controls.Add(Me.TbEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbEmail As TextBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnSignup As Button
End Class
