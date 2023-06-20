Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Excel




Public Class ContactsandSuppliersMainWindow



    Private Sub ContactsandSuppliersMainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        MessageBox.Show("PalmTree Parts Library 1.0", "PalmTree Library", MessageBoxButtons.OK)
    End Sub 'AboutUsToolStripMenuItem_Click


    Private Sub AddContactsAndSuppliersButton_Click(sender As Object, e As EventArgs) Handles AddContactsAndSuppliersButton.Click


        Dim newItem As New ListViewItem(JunkColumnHeader.Text & Environment.NewLine & BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox.Text & Environment.NewLine &
                                        BusinessNameContactsAndSuppliersTextBox.Text & Environment.NewLine &
                                        AddressContactsAndSuppliersTextBox.Text & Environment.NewLine &
                                        PhoneNumber1ContactsAndSuppliersTextBox.Text & Environment.NewLine &
                                        PhoneNumber2ContactsAndSuppliersTextBox.Text & Environment.NewLine &
            Email1ContactsAndSuppliersTextBox.Text & Environment.NewLine &
            Email2ContactsAndSuppliersTextBox.Text & Environment.NewLine &
            WebsiteLinkContactsAndSuppliersTextBox.Text & Environment.NewLine)

        newItem.SubItems.Add(BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox.Text)
        newItem.SubItems.Add(BusinessNameContactsAndSuppliersTextBox.Text)
        newItem.SubItems.Add(AddressContactsAndSuppliersTextBox.Text)
        newItem.SubItems.Add(PhoneNumber1ContactsAndSuppliersTextBox.Text)
        newItem.SubItems.Add(PhoneNumber2ContactsAndSuppliersTextBox.Text)
        newItem.SubItems.Add(Email1ContactsAndSuppliersTextBox.Text)
        newItem.SubItems.Add(Email2ContactsAndSuppliersTextBox.Text)
        newItem.SubItems.Add(WebsiteLinkContactsAndSuppliersTextBox.Text)

        ContactsAndSuppliersListView.Items.Add(newItem)

        BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox.Text = ""
        BusinessNameContactsAndSuppliersTextBox.Text = ""
        AddressContactsAndSuppliersTextBox.Text = ""
        PhoneNumber1ContactsAndSuppliersTextBox.Text = ""
        PhoneNumber2ContactsAndSuppliersTextBox.Text = ""
        Email1ContactsAndSuppliersTextBox.Text = ""
        Email2ContactsAndSuppliersTextBox.Text = ""
        WebsiteLinkContactsAndSuppliersTextBox.Text = ""

    End Sub

    Private Sub ContactsAndSuppliersListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ContactsAndSuppliersListView.SelectedIndexChanged



        If ContactsAndSuppliersListView.SelectedItems.Count > 0 Then
            BusinessOwnerRepresentativeNameContactsAndSuppliersTextBox.Text = ContactsAndSuppliersListView.SelectedItems(0).SubItems(0).Text
            BusinessNameContactsAndSuppliersTextBox.Text = ContactsAndSuppliersListView.SelectedItems(0).SubItems(1).Text
            AddressContactsAndSuppliersTextBox.Text = ContactsAndSuppliersListView.SelectedItems(0).SubItems(2).Text
            PhoneNumber1ContactsAndSuppliersTextBox.Text = ContactsAndSuppliersListView.SelectedItems(0).SubItems(3).Text
            PhoneNumber2ContactsAndSuppliersTextBox.Text = ContactsAndSuppliersListView.SelectedItems(0).SubItems(4).Text
            Email1ContactsAndSuppliersTextBox.Text = ContactsAndSuppliersListView.SelectedItems(0).SubItems(5).Text
            Email2ContactsAndSuppliersTextBox.Text = ContactsAndSuppliersListView.SelectedItems(0).SubItems(6).Text
            WebsiteLinkContactsAndSuppliersTextBox.Text = ContactsAndSuppliersListView.SelectedItems(0).SubItems(7).Text
        End If

    End Sub

    Private Sub SaveContactsAndSuppliersButton_Click(sender As Object, e As EventArgs) Handles SaveContactsAndSuppliersButton.Click



    End Sub

    Private Sub ChangeBackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeBackgroundColorToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ContactsandSuppliersMainWindow.ActiveForm.Close()
    End Sub
End Class