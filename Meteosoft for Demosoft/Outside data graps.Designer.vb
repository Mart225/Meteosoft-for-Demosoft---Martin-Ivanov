<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Outside_data_graps
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.insideTempGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.outsideTempGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.insideTempGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.outsideTempGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'insideTempGraph
        '
        ChartArea1.BackColor = System.Drawing.Color.Silver
        ChartArea1.Name = "ChartArea1"
        Me.insideTempGraph.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.White
        Legend1.Name = "Legend1"
        Me.insideTempGraph.Legends.Add(Legend1)
        Me.insideTempGraph.Location = New System.Drawing.Point(12, 59)
        Me.insideTempGraph.Name = "insideTempGraph"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.Cyan
        Series1.Legend = "Legend1"
        Series1.Name = "Inside temperature"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.insideTempGraph.Series.Add(Series1)
        Me.insideTempGraph.Size = New System.Drawing.Size(1240, 349)
        Me.insideTempGraph.TabIndex = 0
        Me.insideTempGraph.Text = "insideTempGraph"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(573, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Temperature values"
        '
        'outsideTempGraph
        '
        ChartArea2.BackColor = System.Drawing.Color.Silver
        ChartArea2.Name = "ChartArea1"
        Me.outsideTempGraph.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.White
        Legend2.Name = "Legend1"
        Me.outsideTempGraph.Legends.Add(Legend2)
        Me.outsideTempGraph.Location = New System.Drawing.Point(12, 414)
        Me.outsideTempGraph.Name = "outsideTempGraph"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Color = System.Drawing.Color.Cyan
        Series2.Legend = "Legend1"
        Series2.Name = "Outside temperature"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.outsideTempGraph.Series.Add(Series2)
        Me.outsideTempGraph.Size = New System.Drawing.Size(1240, 335)
        Me.outsideTempGraph.TabIndex = 8
        Me.outsideTempGraph.Text = "Outside temperature"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(1115, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Hide"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Outside_data_graps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 761)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.outsideTempGraph)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.insideTempGraph)
        Me.Name = "Outside_data_graps"
        Me.Text = "Temperature data graps"
        CType(Me.insideTempGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.outsideTempGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents insideTempGraph As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents outsideTempGraph As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
