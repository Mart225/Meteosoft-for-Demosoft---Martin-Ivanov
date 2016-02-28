Public Class Outside_data_graps

    Private Sub Outside_data_graps_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        outsideTempGraph.Series("Outside temperature").BorderWidth = 2
        insideTempGraph.Series("Inside temperature").BorderWidth = 2
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

End Class