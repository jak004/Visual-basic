<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.MajorTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.MessageCheckBox = New System.Windows.Forms.CheckBox()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GrayRadioButton = New System.Windows.Forms.RadioButton()
        Me.RedRadioButton = New System.Windows.Forms.RadioButton()
        Me.BlueRadioButton = New System.Windows.Forms.RadioButton()
        Me.GreenRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BlackRadioButton = New System.Windows.Forms.RadioButton()
        Me.WhiteRadioButton = New System.Windows.Forms.RadioButton()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PhoneMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.MajorTextBox)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(51, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 161)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(62, 28)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(259, 22)
        Me.NameTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Enter a name to be displayed in the output textbox")
        '
        'MajorTextBox
        '
        Me.MajorTextBox.Location = New System.Drawing.Point(62, 66)
        Me.MajorTextBox.Name = "MajorTextBox"
        Me.MajorTextBox.Size = New System.Drawing.Size(259, 22)
        Me.MajorTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.MajorTextBox, "Enter your major to be displayed in the output textbox")
        '
        'PhoneMaskedTextBox
        '
        Me.PhoneMaskedTextBox.Location = New System.Drawing.Point(62, 108)
        Me.PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox"
        Me.PhoneMaskedTextBox.Size = New System.Drawing.Size(259, 22)
        Me.PhoneMaskedTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.PhoneMaskedTextBox, "Enter a valid phone number")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(7, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Major : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(6, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Phone:"
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Location = New System.Drawing.Point(172, 259)
        Me.OutputTextBox.Multiline = True
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.Size = New System.Drawing.Size(200, 127)
        Me.OutputTextBox.TabIndex = 1
        '
        'MessageCheckBox
        '
        Me.MessageCheckBox.AutoSize = True
        Me.MessageCheckBox.Location = New System.Drawing.Point(172, 195)
        Me.MessageCheckBox.Name = "MessageCheckBox"
        Me.MessageCheckBox.Size = New System.Drawing.Size(130, 20)
        Me.MessageCheckBox.TabIndex = 2
        Me.MessageCheckBox.Text = "Message Visible"
        Me.MessageCheckBox.UseVisualStyleBackColor = True
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Location = New System.Drawing.Point(81, 259)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(51, 16)
        Me.OutputLabel.TabIndex = 3
        Me.OutputLabel.Text = "Output :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GreenRadioButton)
        Me.GroupBox2.Controls.Add(Me.BlueRadioButton)
        Me.GroupBox2.Controls.Add(Me.RedRadioButton)
        Me.GroupBox2.Controls.Add(Me.GrayRadioButton)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(523, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 145)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Background"
        Me.ToolTip1.SetToolTip(Me.GroupBox2, "Click to change background to gray")
        '
        'GrayRadioButton
        '
        Me.GrayRadioButton.AutoSize = True
        Me.GrayRadioButton.Checked = True
        Me.GrayRadioButton.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GrayRadioButton.Location = New System.Drawing.Point(45, 22)
        Me.GrayRadioButton.Name = "GrayRadioButton"
        Me.GrayRadioButton.Size = New System.Drawing.Size(57, 20)
        Me.GrayRadioButton.TabIndex = 0
        Me.GrayRadioButton.TabStop = True
        Me.GrayRadioButton.Text = "Gray"
        Me.ToolTip1.SetToolTip(Me.GrayRadioButton, "This is the default background for the text")
        Me.GrayRadioButton.UseVisualStyleBackColor = True
        '
        'RedRadioButton
        '
        Me.RedRadioButton.AutoSize = True
        Me.RedRadioButton.ForeColor = System.Drawing.SystemColors.Desktop
        Me.RedRadioButton.Location = New System.Drawing.Point(45, 48)
        Me.RedRadioButton.Name = "RedRadioButton"
        Me.RedRadioButton.Size = New System.Drawing.Size(54, 20)
        Me.RedRadioButton.TabIndex = 1
        Me.RedRadioButton.Text = "Red"
        Me.ToolTip1.SetToolTip(Me.RedRadioButton, "Click to change background to red")
        Me.RedRadioButton.UseVisualStyleBackColor = True
        '
        'BlueRadioButton
        '
        Me.BlueRadioButton.AutoSize = True
        Me.BlueRadioButton.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BlueRadioButton.Location = New System.Drawing.Point(45, 74)
        Me.BlueRadioButton.Name = "BlueRadioButton"
        Me.BlueRadioButton.Size = New System.Drawing.Size(55, 20)
        Me.BlueRadioButton.TabIndex = 2
        Me.BlueRadioButton.Text = "Blue"
        Me.ToolTip1.SetToolTip(Me.BlueRadioButton, "Click to change background to blue")
        Me.BlueRadioButton.UseVisualStyleBackColor = True
        '
        'GreenRadioButton
        '
        Me.GreenRadioButton.AutoSize = True
        Me.GreenRadioButton.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GreenRadioButton.Location = New System.Drawing.Point(45, 100)
        Me.GreenRadioButton.Name = "GreenRadioButton"
        Me.GreenRadioButton.Size = New System.Drawing.Size(65, 20)
        Me.GreenRadioButton.TabIndex = 3
        Me.GreenRadioButton.Text = "Green"
        Me.ToolTip1.SetToolTip(Me.GreenRadioButton, "Click to change background to green")
        Me.GreenRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.WhiteRadioButton)
        Me.GroupBox3.Controls.Add(Me.BlackRadioButton)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(523, 231)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Text Color"
        '
        'BlackRadioButton
        '
        Me.BlackRadioButton.AutoSize = True
        Me.BlackRadioButton.Checked = True
        Me.BlackRadioButton.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BlackRadioButton.Location = New System.Drawing.Point(45, 28)
        Me.BlackRadioButton.Name = "BlackRadioButton"
        Me.BlackRadioButton.Size = New System.Drawing.Size(62, 20)
        Me.BlackRadioButton.TabIndex = 0
        Me.BlackRadioButton.TabStop = True
        Me.BlackRadioButton.Text = "Black"
        Me.ToolTip1.SetToolTip(Me.BlackRadioButton, "Click to change text color to black")
        Me.BlackRadioButton.UseVisualStyleBackColor = True
        '
        'WhiteRadioButton
        '
        Me.WhiteRadioButton.AutoSize = True
        Me.WhiteRadioButton.ForeColor = System.Drawing.SystemColors.Desktop
        Me.WhiteRadioButton.Location = New System.Drawing.Point(45, 54)
        Me.WhiteRadioButton.Name = "WhiteRadioButton"
        Me.WhiteRadioButton.Size = New System.Drawing.Size(62, 20)
        Me.WhiteRadioButton.TabIndex = 1
        Me.WhiteRadioButton.Text = "White"
        Me.ToolTip1.SetToolTip(Me.WhiteRadioButton, "Click to change text color to white")
        Me.WhiteRadioButton.UseVisualStyleBackColor = True
        '
        'DisplayButton
        '
        Me.DisplayButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.DisplayButton.Location = New System.Drawing.Point(491, 393)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(75, 45)
        Me.DisplayButton.TabIndex = 5
        Me.DisplayButton.Text = "Display Message"
        Me.ToolTip1.SetToolTip(Me.DisplayButton, "Click to display a message to the output textbox")
        Me.DisplayButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.ResetButton.Location = New System.Drawing.Point(572, 393)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 45)
        Me.ResetButton.TabIndex = 8
        Me.ResetButton.Text = "Reset"
        Me.ToolTip1.SetToolTip(Me.ResetButton, "Click to reset the output textbox")
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.ExitButton.Location = New System.Drawing.Point(653, 393)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 45)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Click to exit the form.")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VB_University__Message_Application.My.Resources.Resources.Screenshot_2025_05_30_134255
        Me.PictureBox2.Location = New System.Drawing.Point(51, 393)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VB_University__Message_Application.My.Resources.Resources.Screenshot_2025_05_30_084853
        Me.PictureBox1.Location = New System.Drawing.Point(51, 393)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.MessageCheckBox)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "VB University- Message Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents MajorTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents MessageCheckBox As CheckBox
    Friend WithEvents OutputLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents RedRadioButton As RadioButton
    Friend WithEvents GrayRadioButton As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents WhiteRadioButton As RadioButton
    Friend WithEvents BlackRadioButton As RadioButton
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
