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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.temperatureLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.portComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.commandTextBox = New System.Windows.Forms.TextBox()
        Me.writeToPort = New System.Windows.Forms.Button()
        Me.baduComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.openButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.outputTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RTC = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.speakNowLabel = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.speechInterval = New System.Windows.Forms.Timer(Me.components)
        Me.outsideDataGraphButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.outTemperatureLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.setAlarmButton = New System.Windows.Forms.Button()
        Me.hoursLabel = New System.Windows.Forms.Label()
        Me.minutesLabel = New System.Windows.Forms.Label()
        Me.secondsLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.commandTimer = New System.Windows.Forms.Timer(Me.components)
        Me.at = New System.Windows.Forms.Label()
        Me.commandMSG = New System.Windows.Forms.Label()
        Me.timeDateCaution = New System.Windows.Forms.Label()
        Me.CautionMSG = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.falseAlarmButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'temperatureLabel
        '
        Me.temperatureLabel.BackColor = System.Drawing.Color.Transparent
        Me.temperatureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.temperatureLabel.ForeColor = System.Drawing.Color.GreenYellow
        Me.temperatureLabel.Location = New System.Drawing.Point(378, 136)
        Me.temperatureLabel.Name = "temperatureLabel"
        Me.temperatureLabel.Size = New System.Drawing.Size(116, 46)
        Me.temperatureLabel.TabIndex = 1
        Me.temperatureLabel.Text = "20,00 C "
        Me.temperatureLabel.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 242)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(0, 0)
        Me.TextBox1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(61, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Select baud:"
        '
        'portComboBox
        '
        Me.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.portComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.4!)
        Me.portComboBox.FormattingEnabled = True
        Me.portComboBox.Location = New System.Drawing.Point(41, 43)
        Me.portComboBox.Name = "portComboBox"
        Me.portComboBox.Size = New System.Drawing.Size(121, 21)
        Me.portComboBox.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.commandTextBox)
        Me.GroupBox1.Controls.Add(Me.writeToPort)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.portComboBox)
        Me.GroupBox1.Controls.Add(Me.baduComboBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.openButton)
        Me.GroupBox1.Controls.Add(Me.closeButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SlateBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 205)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serial options:"
        '
        'commandTextBox
        '
        Me.commandTextBox.Enabled = False
        Me.commandTextBox.Location = New System.Drawing.Point(118, 127)
        Me.commandTextBox.Name = "commandTextBox"
        Me.commandTextBox.Size = New System.Drawing.Size(100, 24)
        Me.commandTextBox.TabIndex = 50
        '
        'writeToPort
        '
        Me.writeToPort.BackColor = System.Drawing.Color.Transparent
        Me.writeToPort.Enabled = False
        Me.writeToPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.writeToPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.writeToPort.ForeColor = System.Drawing.Color.Lime
        Me.writeToPort.Location = New System.Drawing.Point(118, 153)
        Me.writeToPort.Name = "writeToPort"
        Me.writeToPort.Size = New System.Drawing.Size(100, 30)
        Me.writeToPort.TabIndex = 49
        Me.writeToPort.Text = "Write to port"
        Me.writeToPort.UseVisualStyleBackColor = False
        '
        'baduComboBox
        '
        Me.baduComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.baduComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.4!)
        Me.baduComboBox.FormattingEnabled = True
        Me.baduComboBox.Items.AddRange(New Object() {"9600", "19200", "38400", "57600", "115200", "230400", "250000"})
        Me.baduComboBox.Location = New System.Drawing.Point(40, 90)
        Me.baduComboBox.Name = "baduComboBox"
        Me.baduComboBox.Size = New System.Drawing.Size(121, 21)
        Me.baduComboBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(49, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Select COM Port:"
        '
        'openButton
        '
        Me.openButton.BackColor = System.Drawing.Color.Transparent
        Me.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.openButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.openButton.ForeColor = System.Drawing.Color.Chartreuse
        Me.openButton.Location = New System.Drawing.Point(195, 31)
        Me.openButton.Name = "openButton"
        Me.openButton.Size = New System.Drawing.Size(100, 40)
        Me.openButton.TabIndex = 0
        Me.openButton.Text = "OPEN PORT"
        Me.openButton.UseVisualStyleBackColor = False
        '
        'closeButton
        '
        Me.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.closeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.closeButton.ForeColor = System.Drawing.Color.Red
        Me.closeButton.Location = New System.Drawing.Point(195, 79)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(100, 40)
        Me.closeButton.TabIndex = 1
        Me.closeButton.Text = "CLOSE PORT"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'outputTextBox
        '
        Me.outputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.outputTextBox.DetectUrls = False
        Me.outputTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.outputTextBox.Location = New System.Drawing.Point(364, 196)
        Me.outputTextBox.Name = "outputTextBox"
        Me.outputTextBox.ReadOnly = True
        Me.outputTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.outputTextBox.Size = New System.Drawing.Size(686, 201)
        Me.outputTextBox.TabIndex = 19
        Me.outputTextBox.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Bisque
        Me.Label2.Location = New System.Drawing.Point(364, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Serial OUTPUT:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.Label13.Location = New System.Drawing.Point(370, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 33)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "RTC:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RTC
        '
        Me.RTC.BackColor = System.Drawing.Color.Transparent
        Me.RTC.Font = New System.Drawing.Font("Trebuchet MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RTC.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.RTC.Location = New System.Drawing.Point(436, 43)
        Me.RTC.Name = "RTC"
        Me.RTC.Size = New System.Drawing.Size(190, 47)
        Me.RTC.TabIndex = 21
        Me.RTC.Text = "00:00:00"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1268, 428)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(366, 42)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(262, 73)
        '
        'speakNowLabel
        '
        Me.speakNowLabel.BackColor = System.Drawing.Color.Transparent
        Me.speakNowLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.speakNowLabel.ForeColor = System.Drawing.Color.Red
        Me.speakNowLabel.Location = New System.Drawing.Point(128, 264)
        Me.speakNowLabel.Name = "speakNowLabel"
        Me.speakNowLabel.Size = New System.Drawing.Size(96, 19)
        Me.speakNowLabel.TabIndex = 25
        Me.speakNowLabel.Text = "Speak NOW!"
        Me.speakNowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.speakNowLabel.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox2.Location = New System.Drawing.Point(96, 242)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(176, 19)
        Me.CheckBox2.TabIndex = 24
        Me.CheckBox2.Text = "Enable Mart225's Sona"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(382, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(360, 29)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Meteosoft for Demosoft DASHBOARD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 250000
        Me.SerialPort1.PortName = "COM3"
        '
        'speechInterval
        '
        Me.speechInterval.Interval = 10000
        '
        'outsideDataGraphButton
        '
        Me.outsideDataGraphButton.BackColor = System.Drawing.Color.Transparent
        Me.outsideDataGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.outsideDataGraphButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.outsideDataGraphButton.ForeColor = System.Drawing.Color.Lime
        Me.outsideDataGraphButton.Location = New System.Drawing.Point(68, 289)
        Me.outsideDataGraphButton.Name = "outsideDataGraphButton"
        Me.outsideDataGraphButton.Size = New System.Drawing.Size(120, 41)
        Me.outsideDataGraphButton.TabIndex = 43
        Me.outsideDataGraphButton.Text = "Temperature data graphs"
        Me.outsideDataGraphButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(198, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 41)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Light data graphs"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'outTemperatureLabel
        '
        Me.outTemperatureLabel.BackColor = System.Drawing.Color.Transparent
        Me.outTemperatureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.outTemperatureLabel.ForeColor = System.Drawing.Color.GreenYellow
        Me.outTemperatureLabel.Location = New System.Drawing.Point(552, 136)
        Me.outTemperatureLabel.Name = "outTemperatureLabel"
        Me.outTemperatureLabel.Size = New System.Drawing.Size(114, 54)
        Me.outTemperatureLabel.TabIndex = 45
        Me.outTemperatureLabel.Text = "20,00 C "
        Me.outTemperatureLabel.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(393, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Indoor temperature:"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(556, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 16)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Outdoor temperature:"
        Me.Label7.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 300
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.ForeColor = System.Drawing.Color.Yellow
        Me.CheckBox1.Location = New System.Drawing.Point(130, 336)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(138, 17)
        Me.CheckBox1.TabIndex = 49
        Me.CheckBox1.Text = "Enable ethernet access"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.MediumTurquoise
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.MediumTurquoise
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ChartArea1.BackImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ChartArea1.BackSecondaryColor = System.Drawing.Color.Black
        ChartArea1.BorderColor = System.Drawing.Color.Gainsboro
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Gray
        Legend1.BorderColor = System.Drawing.Color.White
        Legend1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.0!)
        Legend1.ForeColor = System.Drawing.Color.WhiteSmoke
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.TitleForeColor = System.Drawing.Color.White
        Legend1.TitleSeparatorColor = System.Drawing.Color.White
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(717, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.LabelBorderColor = System.Drawing.Color.White
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Humidity"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[String]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(547, 178)
        Me.Chart1.TabIndex = 50
        Me.Chart1.Text = "Chart1"
        Me.Chart1.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label1.Location = New System.Drawing.Point(479, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 41)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "C"
        Me.Label1.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label8.Location = New System.Drawing.Point(652, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 41)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "C"
        Me.Label8.Visible = False
        '
        'setAlarmButton
        '
        Me.setAlarmButton.BackColor = System.Drawing.Color.Transparent
        Me.setAlarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.setAlarmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.setAlarmButton.ForeColor = System.Drawing.Color.Yellow
        Me.setAlarmButton.Location = New System.Drawing.Point(1121, 196)
        Me.setAlarmButton.Name = "setAlarmButton"
        Me.setAlarmButton.Size = New System.Drawing.Size(90, 32)
        Me.setAlarmButton.TabIndex = 53
        Me.setAlarmButton.Text = "Set alarm"
        Me.setAlarmButton.UseVisualStyleBackColor = False
        '
        'hoursLabel
        '
        Me.hoursLabel.BackColor = System.Drawing.Color.Transparent
        Me.hoursLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.hoursLabel.ForeColor = System.Drawing.Color.GreenYellow
        Me.hoursLabel.Location = New System.Drawing.Point(1091, 231)
        Me.hoursLabel.Name = "hoursLabel"
        Me.hoursLabel.Size = New System.Drawing.Size(45, 32)
        Me.hoursLabel.TabIndex = 54
        Me.hoursLabel.Text = "00"
        Me.hoursLabel.Visible = False
        '
        'minutesLabel
        '
        Me.minutesLabel.BackColor = System.Drawing.Color.Transparent
        Me.minutesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.minutesLabel.ForeColor = System.Drawing.Color.GreenYellow
        Me.minutesLabel.Location = New System.Drawing.Point(1142, 231)
        Me.minutesLabel.Name = "minutesLabel"
        Me.minutesLabel.Size = New System.Drawing.Size(45, 32)
        Me.minutesLabel.TabIndex = 55
        Me.minutesLabel.Text = "00"
        Me.minutesLabel.Visible = False
        '
        'secondsLabel
        '
        Me.secondsLabel.BackColor = System.Drawing.Color.Transparent
        Me.secondsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.secondsLabel.ForeColor = System.Drawing.Color.GreenYellow
        Me.secondsLabel.Location = New System.Drawing.Point(1193, 231)
        Me.secondsLabel.Name = "secondsLabel"
        Me.secondsLabel.Size = New System.Drawing.Size(45, 32)
        Me.secondsLabel.TabIndex = 56
        Me.secondsLabel.Text = "00"
        Me.secondsLabel.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label12.Location = New System.Drawing.Point(1180, 231)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 38)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = ":"
        Me.Label12.Visible = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label14.Location = New System.Drawing.Point(1129, 231)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 38)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = ":"
        Me.Label14.Visible = False
        '
        'commandTimer
        '
        Me.commandTimer.Interval = 5000
        '
        'at
        '
        Me.at.AutoSize = True
        Me.at.BackColor = System.Drawing.Color.Transparent
        Me.at.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.at.ForeColor = System.Drawing.Color.Gold
        Me.at.Location = New System.Drawing.Point(1062, 322)
        Me.at.Name = "at"
        Me.at.Size = New System.Drawing.Size(23, 15)
        Me.at.TabIndex = 62
        Me.at.Text = "at:"
        Me.at.Visible = False
        '
        'commandMSG
        '
        Me.commandMSG.AllowDrop = True
        Me.commandMSG.BackColor = System.Drawing.Color.Transparent
        Me.commandMSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.commandMSG.ForeColor = System.Drawing.Color.Chartreuse
        Me.commandMSG.Location = New System.Drawing.Point(1064, 295)
        Me.commandMSG.Name = "commandMSG"
        Me.commandMSG.Size = New System.Drawing.Size(147, 27)
        Me.commandMSG.TabIndex = 61
        Me.commandMSG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'timeDateCaution
        '
        Me.timeDateCaution.AutoSize = True
        Me.timeDateCaution.BackColor = System.Drawing.Color.Transparent
        Me.timeDateCaution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.timeDateCaution.ForeColor = System.Drawing.Color.Gold
        Me.timeDateCaution.Location = New System.Drawing.Point(1091, 322)
        Me.timeDateCaution.Name = "timeDateCaution"
        Me.timeDateCaution.Size = New System.Drawing.Size(152, 16)
        Me.timeDateCaution.TabIndex = 60
        Me.timeDateCaution.Text = "00:00:00 [00/00/0000]"
        Me.timeDateCaution.Visible = False
        '
        'CautionMSG
        '
        Me.CautionMSG.BackColor = System.Drawing.Color.Transparent
        Me.CautionMSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CautionMSG.ForeColor = System.Drawing.Color.Gold
        Me.CautionMSG.Location = New System.Drawing.Point(1064, 268)
        Me.CautionMSG.Name = "CautionMSG"
        Me.CautionMSG.Size = New System.Drawing.Size(147, 27)
        Me.CautionMSG.TabIndex = 59
        Me.CautionMSG.Text = "CAUTION: Code via WEB WAS EXECUTED:"
        Me.CautionMSG.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(1148, 54)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(102, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 63
        Me.ProgressBar1.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label9.Location = New System.Drawing.Point(1143, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 29)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "0"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label10.Location = New System.Drawing.Point(1181, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 28)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "50"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label11.Location = New System.Drawing.Point(1222, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 24)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "100"
        Me.Label11.Visible = False
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(374, 93)
        Me.ProgressBar2.Maximum = 235960
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(241, 12)
        Me.ProgressBar2.Step = 1
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar2.TabIndex = 67
        '
        'falseAlarmButton
        '
        Me.falseAlarmButton.BackColor = System.Drawing.Color.Transparent
        Me.falseAlarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.falseAlarmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.falseAlarmButton.ForeColor = System.Drawing.Color.Lime
        Me.falseAlarmButton.Location = New System.Drawing.Point(1150, 114)
        Me.falseAlarmButton.Name = "falseAlarmButton"
        Me.falseAlarmButton.Size = New System.Drawing.Size(100, 30)
        Me.falseAlarmButton.TabIndex = 51
        Me.falseAlarmButton.Text = "False alarm"
        Me.falseAlarmButton.UseVisualStyleBackColor = False
        Me.falseAlarmButton.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1268, 428)
        Me.Controls.Add(Me.falseAlarmButton)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.at)
        Me.Controls.Add(Me.commandMSG)
        Me.Controls.Add(Me.timeDateCaution)
        Me.Controls.Add(Me.CautionMSG)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.secondsLabel)
        Me.Controls.Add(Me.minutesLabel)
        Me.Controls.Add(Me.hoursLabel)
        Me.Controls.Add(Me.setAlarmButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.outTemperatureLabel)
        Me.Controls.Add(Me.outsideDataGraphButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.speakNowLabel)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.RTC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.outputTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.temperatureLabel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Meteosoft for Demosoft-DASHBOARD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents temperatureLabel As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents portComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents baduComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents openButton As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents outputTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RTC As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents speakNowLabel As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents speechInterval As System.Windows.Forms.Timer
    Friend WithEvents outsideDataGraphButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents outTemperatureLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents writeToPort As System.Windows.Forms.Button
    Friend WithEvents commandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents setAlarmButton As System.Windows.Forms.Button
    Friend WithEvents hoursLabel As System.Windows.Forms.Label
    Friend WithEvents minutesLabel As System.Windows.Forms.Label
    Friend WithEvents secondsLabel As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents commandTimer As System.Windows.Forms.Timer
    Friend WithEvents at As System.Windows.Forms.Label
    Friend WithEvents commandMSG As System.Windows.Forms.Label
    Friend WithEvents timeDateCaution As System.Windows.Forms.Label
    Friend WithEvents CautionMSG As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents falseAlarmButton As System.Windows.Forms.Button

End Class
