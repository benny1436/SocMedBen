<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIGNUP
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TbEmail = New System.Windows.Forms.TextBox()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
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
        Me.TbPassword.PlaceholderText = "Password"
        Me.TbPassword.Size = New System.Drawing.Size(208, 23)
        Me.TbPassword.TabIndex = 1
        '
        'BtnSignUp
        '
        Me.BtnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnSignUp.FlatAppearance.BorderSize = 0
        Me.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignUp.Location = New System.Drawing.Point(104, 280)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(75, 23)
        Me.BtnSignUp.TabIndex = 2
        Me.BtnSignUp.Text = "SIGNUP"
        Me.BtnSignUp.UseVisualStyleBackColor = False
        '
        'TbName
        '
        Me.TbName.Location = New System.Drawing.Point(40, 152)
        Me.TbName.Name = "TbName"
        Me.TbName.PlaceholderText = "Name"
        Me.TbName.Size = New System.Drawing.Size(208, 23)
        Me.TbName.TabIndex = 3
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Location = New System.Drawing.Point(104, 312)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "LOGIN"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'SIGNUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SocMed.My.Resources.Resources.pexels_ekrulila_2255355
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TbName)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.TbPassword)
        Me.Controls.Add(Me.TbEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SIGNUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGNUP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbEmail As TextBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents BtnSignUp As Button
    Friend WithEvents TbName As TextBox
    Friend WithEvents BtnLogin As Button
End Class
