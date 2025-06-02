Public Class Form1
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Exit the form
        Me.Close()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        'Store message to the output textbox

        OutputTextBox.Text = "My name : " & NameTextBox.Text & ControlChars.NewLine &
                             "Major : " & MajorTextBox.Text & ControlChars.NewLine &
                             "Local Phone : " & PhoneMaskedTextBox.Text

    End Sub

    Private Sub BlackRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlackRadioButton.CheckedChanged
        'Set the form's text color to black
        Me.ForeColor = Color.Black
    End Sub

    Private Sub WhiteRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles WhiteRadioButton.CheckedChanged
        'Set the form's text color to white
        Me.ForeColor = Color.White

    End Sub

    Private Sub GrayRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GrayRadioButton.CheckedChanged
        'Set the background color to gray
        Me.BackColor = Color.Gray
    End Sub

    Private Sub RedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged
        'Set the background color to red
        Me.BackColor = Color.Red
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        'Set the background color to blue
        Me.BackColor = Color.Blue
    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        'Set the background color to green
        Me.BackColor = Color.Green

    End Sub

    Private Sub MessageCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MessageCheckBox.CheckedChanged
        'Make the OutputTextBox and OutputLabel invisible
        OutputTextBox.Visible = MessageCheckBox.Checked
    End Sub

    Private Sub SnowPictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Turn the snow into the sun
        PictureBox1.Visible = False
        PictureBox2.Visible = True
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        'Clear the input and output textbox and the PhoneMaskedTextBox controls-
        NameTextBox.Clear()
        MajorTextBox.Text = String.Empty
        PhoneMaskedTextBox.Clear()
        OutputTextBox.Text = ""
        GrayRadioButton.Checked = True
        BlackRadioButton.Checked = True
        MessageCheckBox.Checked = True
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        NameTextBox.Focus()




    End Sub



End Class

