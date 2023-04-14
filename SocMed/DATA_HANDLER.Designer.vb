<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DATA_HANDLER
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
        dgvCsvData = New DataGridView()
        btnUploadCsv = New Button()
        btnBackupDb = New Button()
        CType(dgvCsvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvCsvData
        ' 
        dgvCsvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCsvData.Location = New Point(0, 0)
        dgvCsvData.Name = "dgvCsvData"
        dgvCsvData.RowTemplate.Height = 25
        dgvCsvData.Size = New Size(800, 400)
        dgvCsvData.TabIndex = 0
        ' 
        ' btnUploadCsv
        ' 
        btnUploadCsv.Location = New Point(10, 410)
        btnUploadCsv.Name = "btnUploadCsv"
        btnUploadCsv.Size = New Size(75, 23)
        btnUploadCsv.TabIndex = 1
        btnUploadCsv.Text = "Upload"
        btnUploadCsv.UseVisualStyleBackColor = True
        ' 
        ' btnBackupDb
        ' 
        btnBackupDb.Location = New Point(120, 410)
        btnBackupDb.Name = "btnBackupDb"
        btnBackupDb.Size = New Size(110, 23)
        btnBackupDb.TabIndex = 2
        btnBackupDb.Text = "Backup Database"
        btnBackupDb.UseVisualStyleBackColor = True
        ' 
        ' DATA_HANDLER
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBackupDb)
        Controls.Add(btnUploadCsv)
        Controls.Add(dgvCsvData)
        Name = "DATA_HANDLER"
        Text = "DATA_HANDLER"
        CType(dgvCsvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvCsvData As DataGridView
    Friend WithEvents btnUploadCsv As Button
    Friend WithEvents btnBackupDb As Button
End Class
