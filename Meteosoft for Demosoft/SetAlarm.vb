Imports System.Windows.Forms

Public Class SetAlarm

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If hoursTextBox.Text < "00" Or hoursTextBox.Text > "23" Or minutesTextBox.Text < "00" Or minutesTextBox.Text > "59" Or secondsTextBox.Text < "00" Or secondsTextBox.Text > "59" Then
            MsgBox("Invalid time selected!")
        Else
            Form1.hoursLabel.Text = hoursTextBox.Text
            Form1.minutesLabel.Text = minutesTextBox.Text
            Form1.secondsLabel.Text = secondsTextBox.Text

            Form1.hoursLabel.Visible = True
            Form1.minutesLabel.Visible = True
            Form1.secondsLabel.Visible = True

            Form1.Label12.Visible = True
            Form1.Label14.Visible = True

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SetAlarm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
