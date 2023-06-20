Public Class ToolsAndEuipmentPopUp


    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click


        Dim newItem As New ListViewItem(Environment.NewLine & TextBox1.Text & Environment.NewLine & TextBox2.Text & Environment.NewLine &
        ComboBox1.Text & Environment.NewLine & TextBox3.Text & Environment.NewLine &
        TextBox4.Text & Environment.NewLine & TextBox5.Text & Environment.NewLine &
        TextBox6.Text & Environment.NewLine & TextBox7.Text & Environment.NewLine &
        TextBox8.Text & Environment.NewLine & TextBox9.Text & Environment.NewLine)


        newItem.SubItems.Add(TextBox1.Text)
        newItem.SubItems.Add(TextBox2.Text)
        newItem.SubItems.Add(ComboBox1.Text)
        newItem.SubItems.Add(TextBox3.Text)
        newItem.SubItems.Add(TextBox4.Text)
        newItem.SubItems.Add(TextBox5.Text)
        newItem.SubItems.Add(TextBox6.Text)
        newItem.SubItems.Add(TextBox7.Text)
        newItem.SubItems.Add(TextBox8.Text)
        newItem.SubItems.Add(TextBox9.Text)


        ToolsAndEuipmentMainWindow.ToolsAndEquipmentListView.Items.Add(newItem)


        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""

        ToolsAndEuipmentPopUp.ActiveForm.Close()

    End Sub


End Class