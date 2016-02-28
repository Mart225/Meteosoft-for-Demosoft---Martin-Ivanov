Imports System.Windows.Forms

Public Class DisableAlarm

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox1.Text = "i am awake" Or TextBox1.Text = "I AM AWAKE" Or TextBox1.Text = "I am awake" Then
            My.Computer.Audio.Stop()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Else
            MsgBox("You are still not awake! LOL! :-)")
        End If
    End Sub


End Class
