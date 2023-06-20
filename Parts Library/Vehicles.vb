Imports Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Imports System.Data
Imports DataTable = System.Data.DataTable
Imports System.IO
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Drawing
Imports Application = Microsoft.Office.Interop.Excel.Application


Public Class VehiclesMainWindow
    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        MessageBox.Show("PalmTree Parts Library 1.0", "PalmTree Library", MessageBoxButtons.OK)
    End Sub 'AboutUsToolStripMenuItem_Click

    Private Sub NewSaveSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSaveSheetToolStripMenuItem.Click
        ' Create a new SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()

        ' Set the file filter for Excel files
        saveFileDialog.Filter = "Excel Files (*.xls)|*.xls"

        ' Show the SaveFileDialog to the user
        Dim result As DialogResult = saveFileDialog.ShowDialog()

        ' Check if the user clicked the Save button
        If result = DialogResult.OK Then
            ' Get the selected file path from the SaveFileDialog
            Dim filePath As String = saveFileDialog.FileName

            ' Save the data to Excel
            SaveToExcel(filePath)
        End If
    End Sub

    Private Sub SaveToExcel(filePath As String)
        ' Create a new Excel application
        Dim excelApp As New Application()

        ' Create a new workbook
        Dim workbook As Workbook = excelApp.Workbooks.Add()

        ' Get the first worksheet
        Dim worksheet As Worksheet = workbook.Sheets(1)

        ' Loop through each row in the DataGridView
        For row As Integer = 0 To DataGridView1.Rows.Count - 1
            ' Loop through each column in the DataGridView
            For col As Integer = 0 To DataGridView1.Columns.Count - 1
                ' Get the cell value from the DataGridView
                Dim cellValue As String = String.Empty

                If DataGridView1 IsNot Nothing AndAlso
   row >= 0 AndAlso row < DataGridView1.Rows.Count AndAlso
   col >= 0 AndAlso col < DataGridView1.Columns.Count Then

                    Dim cell As DataGridViewCell = DataGridView1.Rows(row).Cells(col)

                    If cell.Value IsNot Nothing Then
                        cellValue = cell.Value.ToString()
                    End If
                End If


                ' Set the cell value in the Excel worksheet
                worksheet.Cells(row + 1, col + 1) = cellValue
            Next
        Next

        ' Save the workbook
        workbook.SaveAs(filePath)

        ' Close the workbook and release resources
        workbook.Close()
        excelApp.Quit()

        ' Clean up
        ReleaseObject(worksheet)
        ReleaseObject(workbook)
        ReleaseObject(excelApp)

        'MessageBox.Show("Data saved to Excel successfully!", "Save to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        ' Release COM objects to avoid memory leaks
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub



    Private Function GetFirstSheetName(connection As OleDbConnection) As String
        ' Get the schema information for the sheets in the Excel file
        Dim schemaTable As Data.DataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

        ' Get the name of the first sheet
        Dim sheetName As String = schemaTable.Rows(0)("TABLE_NAME").ToString()

        Return sheetName
    End Function

    Private Sub OpenSheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenSheetToolStripMenuItem.Click

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Multiselect = False ' Allow only single file selection
        openFileDialog.Filter = "Excel Files|*.xls" ' Set the filter to only allow XLS files

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = openFileDialog.FileName
            LoadExcelFileIntoDataGridView(fileName)
        End If
    End Sub

    Private Sub LoadExcelFileIntoDataGridView(fileName As String)
        Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fileName & ";Extended Properties=""Excel 8.0;HDR=YES;"""
        Dim dataTable As New DataTable()

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Get the sheet name
            Dim schemaTable As DataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            Dim sheetName As String = schemaTable.Rows(0)("TABLE_NAME").ToString()

            ' Read the data from the sheet
            Dim query As String = "SELECT * FROM [" & sheetName & "]"
            Using adapter As New OleDbDataAdapter(query, connection)
                adapter.Fill(dataTable)
            End Using

            connection.Close()
        End Using

        ' Enable editing in the DataGridView
        DataGridView1.ReadOnly = False

        ' Display the data in the DataGridView
        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub VehiclesMainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class