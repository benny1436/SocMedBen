<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class POSTS
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
        BtnAddPost = New Button()
        BtnSignOut = New Button()
        Panel1 = New Panel()
        BtnDataManager = New Button()
        BtnProfile = New Button()
        Panel3 = New Panel()
        TlpHome = New TableLayoutPanel()
        BtnRefresh = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnAddPost
        ' 
        BtnAddPost.AutoSize = True
        BtnAddPost.AutoSizeMode = AutoSizeMode.GrowAndShrink
        BtnAddPost.BackColor = Color.FromArgb(CByte(231), CByte(171), CByte(121))
        BtnAddPost.Dock = DockStyle.Fill
        BtnAddPost.FlatAppearance.BorderSize = 0
        BtnAddPost.FlatStyle = FlatStyle.Flat
        BtnAddPost.Location = New Point(3, 3)
        BtnAddPost.Name = "BtnAddPost"
        BtnAddPost.Size = New Size(790, 25)
        BtnAddPost.TabIndex = 4
        BtnAddPost.Text = "What's on your mind?"
        BtnAddPost.UseVisualStyleBackColor = False
        ' 
        ' BtnSignOut
        ' 
        BtnSignOut.BackColor = Color.FromArgb(CByte(231), CByte(171), CByte(121))
        BtnSignOut.Dock = DockStyle.Bottom
        BtnSignOut.FlatAppearance.BorderColor = Color.RoyalBlue
        BtnSignOut.FlatAppearance.BorderSize = 0
        BtnSignOut.FlatAppearance.MouseDownBackColor = Color.DimGray
        BtnSignOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BtnSignOut.FlatStyle = FlatStyle.Flat
        BtnSignOut.Location = New Point(0, 454)
        BtnSignOut.Margin = New Padding(0)
        BtnSignOut.Name = "BtnSignOut"
        BtnSignOut.Size = New Size(240, 33)
        BtnSignOut.TabIndex = 2
        BtnSignOut.Text = "Signout"
        BtnSignOut.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = Color.FromArgb(CByte(119), CByte(67), CByte(96))
        Panel1.Controls.Add(BtnDataManager)
        Panel1.Controls.Add(BtnProfile)
        Panel1.Controls.Add(BtnSignOut)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(240, 487)
        Panel1.TabIndex = 3
        ' 
        ' BtnDataManager
        ' 
        BtnDataManager.BackColor = Color.FromArgb(CByte(231), CByte(171), CByte(121))
        BtnDataManager.Dock = DockStyle.Top
        BtnDataManager.FlatAppearance.BorderSize = 0
        BtnDataManager.FlatStyle = FlatStyle.Flat
        BtnDataManager.Location = New Point(0, 128)
        BtnDataManager.Name = "BtnDataManager"
        BtnDataManager.Size = New Size(240, 32)
        BtnDataManager.TabIndex = 3
        BtnDataManager.Text = "Data Manager"
        BtnDataManager.UseVisualStyleBackColor = False
        ' 
        ' BtnProfile
        ' 
        BtnProfile.BackColor = Color.FromArgb(CByte(231), CByte(171), CByte(121))
        BtnProfile.Dock = DockStyle.Top
        BtnProfile.FlatAppearance.BorderSize = 0
        BtnProfile.FlatStyle = FlatStyle.Flat
        BtnProfile.Location = New Point(0, 96)
        BtnProfile.Name = "BtnProfile"
        BtnProfile.Size = New Size(240, 32)
        BtnProfile.TabIndex = 2
        BtnProfile.Text = "Profile"
        BtnProfile.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(178), CByte(80), CByte(104))
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(240, 96)
        Panel3.TabIndex = 0
        ' 
        ' TlpHome
        ' 
        TlpHome.AutoSize = True
        TlpHome.BackColor = Color.FromArgb(CByte(76), CByte(58), CByte(81))
        TlpHome.ColumnCount = 1
        TlpHome.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TlpHome.Dock = DockStyle.Fill
        TlpHome.Location = New Point(0, 62)
        TlpHome.Margin = New Padding(0)
        TlpHome.Name = "TlpHome"
        TlpHome.RowCount = 1
        TlpHome.RowStyles.Add(New RowStyle())
        TlpHome.Size = New Size(796, 425)
        TlpHome.TabIndex = 4
        ' 
        ' BtnRefresh
        ' 
        BtnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnRefresh.BackColor = Color.FromArgb(CByte(231), CByte(171), CByte(121))
        BtnRefresh.FlatAppearance.BorderSize = 0
        BtnRefresh.FlatStyle = FlatStyle.Flat
        BtnRefresh.Location = New Point(718, 34)
        BtnRefresh.Name = "BtnRefresh"
        BtnRefresh.RightToLeft = RightToLeft.No
        BtnRefresh.Size = New Size(75, 23)
        BtnRefresh.TabIndex = 5
        BtnRefresh.Text = "Refresh"
        BtnRefresh.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(76), CByte(58), CByte(81))
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Controls.Add(BtnAddPost, 0, 0)
        TableLayoutPanel1.Controls.Add(BtnRefresh, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.Size = New Size(796, 62)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.AutoScroll = True
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel2.Controls.Add(TlpHome, 0, 1)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(240, 0)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.Padding = New Padding(0, 0, 10, 0)
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle())
        TableLayoutPanel2.RowStyles.Add(New RowStyle())
        TableLayoutPanel2.Size = New Size(806, 487)
        TableLayoutPanel2.TabIndex = 5
        ' 
        ' POSTS
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1046, 487)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "POSTS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POSTS"
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnSignOut As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnProfile As Button
    Friend WithEvents BtnAddPost As Button
    Friend WithEvents TlpHome As TableLayoutPanel
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnDataManager As Button
End Class
