



Public Class PalmTreeLibraryMainWindow



    Private Sub PalmTreePartsLibrary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles PalmTreePartsLibraryMonthCalendar.DateChanged

    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        MessageBox.Show("PalmTree Parts Library 1.0", "PalmTree Library", MessageBoxButtons.OK)
    End Sub

    Private Sub ContactsAndSuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactsAndSuppliersToolStripMenuItem.Click
        ContactsandSuppliersMainWindow.Show()
    End Sub

    Private Sub PartsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartsToolStripMenuItem.Click
        PartsMainWindow.Show()
    End Sub

    Private Sub ToolsAndEuipmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolsAndEuipmentToolStripMenuItem.Click
        ToolsAndEuipmentMainWindow.Show()
    End Sub

    Private Sub VehiclesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiclesToolStripMenuItem.Click
        VehiclesMainWindow.Show()
    End Sub

    Private Sub ExitClosesAllApplicationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        PalmTreeLibraryMainWindow.ActiveForm.Close()
    End Sub

    Private Sub PalmTreePartsChecklistAddButton_Click(sender As Object, e As EventArgs) Handles PalmTreePartsChecklistAddButton.Click

    End Sub
End Class
