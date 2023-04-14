<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPost
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
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TbTitle = New System.Windows.Forms.TextBox()
        Me.TbContent = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Aqua
        Me.BtnAdd.FlatAppearance.BorderSize = 0
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Location = New System.Drawing.Point(8, 304)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(240, 23)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "Submit"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'TbTitle
        '
        Me.TbTitle.Location = New System.Drawing.Point(8, 96)
        Me.TbTitle.Name = "TbTitle"
        Me.TbTitle.PlaceholderText = "Title"
        Me.TbTitle.Size = New System.Drawing.Size(240, 23)
        Me.TbTitle.TabIndex = 1
        '
        'TbContent
        '
        Me.TbContent.Location = New System.Drawing.Point(8, 144)
        Me.TbContent.Multiline = True
        Me.TbContent.Name = "TbContent"
        Me.TbContent.PlaceholderText = "Content"
        Me.TbContent.Size = New System.Drawing.Size(240, 152)
        Me.TbContent.TabIndex = 2
        '
        'AddPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SocMed.My.Resources.Resources._672238
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(257, 450)
        Me.Controls.Add(Me.TbContent)
        Me.Controls.Add(Me.TbTitle)
        Me.Controls.Add(Me.BtnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddPost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddPost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAdd As Button
    Friend WithEvents TbTitle As TextBox
    Friend WithEvents TbContent As TextBox
End Class
