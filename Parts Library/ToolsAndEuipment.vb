Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports System.Windows.Forms
Imports DataTable = System.Data.DataTable

Public Class ToolsAndEuipmentMainWindow


    Private Sub ToolsAndEuipmentMainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolsAndEquipmentListView.SelectedIndexChanged, ToolsAndEquipmentListView.SelectedIndexChanged


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddToolsAndEquipmentButton.Click
        ToolsAndEuipmentPopUp.Visible = True
    End Sub


    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        MessageBox.Show("PalmTree Parts Library 1.0", "PalmTree Library", MessageBoxButtons.OK)
    End Sub 'AboutUsToolStripMenuItem_Click


    Private Sub OpenListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenListToolStripMenuItem.Click


    End Sub


    Private Sub NewSaveListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSaveListToolStripMenuItem.Click


        ' Create a new SaveFileDialog
        Dim saveDialog As New SaveFileDialog()

        ' Set the file filter and default file name
        saveDialog.Filter = "Excel Files (*.xls)|*.xls|Text Files (*.txt)|*.txt"
        saveDialog.FileName = "ListData"

        ' Show the SaveFileDialog to the user
        Dim result As DialogResult = saveDialog.ShowDialog()

        ' Check if the user clicked the Save button
        If result = DialogResult.OK Then
            ' Get the selected file path from the SaveFileDialog
            Dim filePath As String = saveDialog.FileName

            ' Get the file extension from the selected file path
            Dim fileExtension As String = Path.GetExtension(filePath)

            If fileExtension = ".xls" Then
                ' Save data as Excel file
                SaveListViewAsExcel(ToolsAndEquipmentListView, filePath)
            ElseIf fileExtension = ".txt" Then
                ' Save data as text file
                SaveListViewAsText(ToolsAndEquipmentListView, filePath)
            End If

            'MsgBox("Data saved successfully.")
        End If
    End Sub

    Private Sub SaveListViewAsExcel(listView As ListView, filePath As String)
        ' Create a new Excel application
        Dim excelApp As New Excel.Application()

        ' Create a new workbook
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()

        ' Add a new worksheet to the workbook
        Dim worksheet As Excel.Worksheet = workbook.Sheets.Add()

        ' Set the column headers in the first row of the worksheet
        For i As Integer = 1 To listView.Columns.Count
            worksheet.Cells(1, i) = listView.Columns(i - 1).Text
        Next

        ' Copy the ListView data to the worksheet
        For i As Integer = 0 To listView.Items.Count - 1
            For j As Integer = 0 To listView.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1) = listView.Items(i).SubItems(j).Text
            Next
        Next

        ' Save the workbook as an Excel file
        workbook.SaveAs(filePath)

        ' Close the workbook and release resources
        workbook.Close()
        excelApp.Quit()

        ' Clean up
        ReleaseObject(worksheet)
        ReleaseObject(workbook)
        ReleaseObject(excelApp)
    End Sub

    Private Sub SaveListViewAsText(listView As ListView, filePath As String)
        Using writer As New StreamWriter(filePath)
            For Each item As ListViewItem In listView.Items
                Dim subItemTexts As New List(Of String)

                For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                    subItemTexts.Add(subItem.Text)
                Next

                writer.WriteLine(String.Join(ControlChars.Tab, subItemTexts.ToArray()))
            Next
        End Using
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

End Class