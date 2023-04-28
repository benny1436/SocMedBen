<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOWNLOADPOSTS
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
        postDgv = New DataGridView()
        btnListPosts = New Button()
        btnDownloadPosts = New Button()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        CType(postDgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' postDgv
        ' 
        postDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        postDgv.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        postDgv.Location = New Point(0, 0)
        postDgv.Name = "postDgv"
        postDgv.RowTemplate.Height = 25
        postDgv.Size = New Size(800, 370)
        postDgv.TabIndex = 0
        ' 
        ' btnListPosts
        ' 
        btnListPosts.Location = New Point(160, 400)
        btnListPosts.Name = "btnListPosts"
        btnListPosts.Size = New Size(75, 23)
        btnListPosts.TabIndex = 1
        btnListPosts.Text = "List Posts"
        btnListPosts.UseVisualStyleBackColor = True
        ' 
        ' btnDownloadPosts
        ' 
        btnDownloadPosts.Location = New Point(520, 400)
        btnDownloadPosts.Name = "btnDownloadPosts"
        btnDownloadPosts.Size = New Size(75, 23)
        btnDownloadPosts.TabIndex = 2
        btnDownloadPosts.Text = "Download"
        btnDownloadPosts.UseVisualStyleBackColor = True
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Post ID"
        Column1.Name = "Column1"
        Column1.Resizable = DataGridViewTriState.True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Title"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Content"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Owner ID"
        Column4.Name = "Column4"
        ' 
        ' DOWNLOADPOSTS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDownloadPosts)
        Controls.Add(btnListPosts)
        Controls.Add(postDgv)
        Name = "DOWNLOADPOSTS"
        Text = "DOWNLOADPOSTS"
        CType(postDgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents postDgv As DataGridView
    Friend WithEvents btnListPosts As Button
    Friend WithEvents btnDownloadPosts As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
