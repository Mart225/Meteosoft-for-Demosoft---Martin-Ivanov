<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inside_data_graphsvb
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.insideLightGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.outsideLightGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.insideLightGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.outsideLightGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(580, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Light values"
        '
        'insideLightGraph
        '
        ChartArea3.AxisY.Maximum = 5.2R
        ChartArea3.AxisY.Minimum = -1.0R
        ChartArea3.BackColor = System.Drawing.Color.Teal
        ChartArea3.BackSecondaryColor = System.Drawing.Color.White
        ChartArea3.Name = "ChartArea1"
        Me.insideLightGraph.ChartAreas.Add(ChartArea3)
        Legend3.BackColor = System.Drawing.Color.White
        Legend3.BorderColor = System.Drawing.Color.White
        Legend3.InterlacedRowsColor = System.Drawing.Color.White
        Legend3.IsTextAutoFit = False
        Legend3.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder
        Legend3.Name = "Legend1"
        Legend3.TitleBackColor = System.Drawing.Color.White
        Me.insideLightGraph.Legends.Add(Legend3)
        Me.insideLightGraph.Location = New System.Drawing.Point(12, 48)
        Me.insideLightGraph.Name = "insideLightGraph"
        Series3.BackImageTransparentColor = System.Drawing.Color.White
        Series3.BorderColor = System.Drawing.Color.DarkGray
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Color = System.Drawing.Color.Chartreuse
        Series3.Legend = "Legend1"
        Series3.Name = "Ammount of light (IN)"
        Series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.insideLightGraph.Series.Add(Series3)
        Me.insideLightGraph.Size = New System.Drawing.Size(1240, 359)
        Me.insideLightGraph.TabIndex = 4
        Me.insideLightGraph.Text = "insideLightGraph"
        '
        'outsideLightGraph
        '
        ChartArea4.AxisY.Maximum = 5.2R
        ChartArea4.AxisY.Minimum = -1.0R
        ChartArea4.BackColor = System.Drawing.Color.Teal
        ChartArea4.BackSecondaryColor = System.Drawing.Color.White
        ChartArea4.Name = "ChartArea1"
        Me.outsideLightGraph.ChartAreas.Add(ChartArea4)
        Legend4.BackColor = System.Drawing.Color.White
        Legend4.BorderColor = System.Drawing.Color.White
        Legend4.InterlacedRowsColor = System.Drawing.Color.White
        Legend4.IsTextAutoFit = False
        Legend4.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder
        Legend4.Name = "Legend1"
        Legend4.TitleBackColor = System.Drawing.Color.White
        Me.outsideLightGraph.Legends.Add(Legend4)
        Me.outsideLightGraph.Location = New System.Drawing.Point(12, 413)
        Me.outsideLightGraph.Name = "outsideLightGraph"
        Series4.BackImageTransparentColor = System.Drawing.Color.White
        Series4.BorderColor = System.Drawing.Color.DarkGray
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Color = System.Drawing.Color.Chartreuse
        Series4.Legend = "Legend1"
        Series4.Name = "Ammount of light (OUT)"
        Series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.outsideLightGraph.Series.Add(Series4)
        Me.outsideLightGraph.Size = New System.Drawing.Size(1240, 336)
        Me.outsideLightGraph.TabIndex = 5
        Me.outsideLightGraph.Text = "outsideLightGraph"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(1148, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Hide"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Inside_data_graphsvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.outsideLightGraph)
        Me.Controls.Add(Me.insideLightGraph)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Inside_data_graphsvb"
        Me.Text = "Light data graphs"
        CType(Me.insideLightGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.outsideLightGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents insideLightGraph As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents outsideLightGraph As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
