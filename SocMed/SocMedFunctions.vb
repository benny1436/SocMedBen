Imports System.IO
Imports ClosedXML.Excel

Module SocMedFunctions
    Public Sub ExportToExcel(ByVal dgv As DataGridView, ByVal templatefilename As String)

        If dgv IsNot Nothing AndAlso dgv.Rows.Count > 0 Then
            Dim workbook As New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add("Sheet1")

            For columnIndex As Integer = 0 To dgv.Columns.Count - 1
                worksheet.Cell(1, columnIndex + 1).Value = dgv.Columns(columnIndex).HeaderText
            Next

            For rowIndex As Integer = 0 To dgv.Rows.Count - 1
                For columnIndex As Integer = 0 To dgv.Columns.Count - 1
                    worksheet.Cell(rowIndex + 2, columnIndex + 1).Value = If(dgv.Rows(rowIndex).Cells(columnIndex).Value IsNot Nothing, dgv.Rows(rowIndex).Cells(columnIndex).Value.ToString(), String.Empty)
                Next
            Next
            Dim filePath As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ExcelTable", templatefilename)
            workbook.SaveAs(filePath)


            MessageBox.Show("Exported to:" & filePath)

        Else
            MessageBox.Show("Empty Data")
        End If

    End Sub


End Module
