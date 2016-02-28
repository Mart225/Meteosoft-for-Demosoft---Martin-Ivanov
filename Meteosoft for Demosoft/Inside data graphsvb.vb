Public Class Inside_data_graphsvb

    Private Sub Inside_data_graphsvb_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        outsideLightGraph.Series("Ammount of light (OUT)").BorderWidth = 2
        insideLightGraph.Series("Ammount of light (IN)").BorderWidth = 2
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class