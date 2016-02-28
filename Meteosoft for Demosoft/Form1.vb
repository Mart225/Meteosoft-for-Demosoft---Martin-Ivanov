'Project started by Martin Ivanov 26.02.16. at 19:52

Imports System
Imports System.Speech


Public Class Form1

    Dim myPort As Array
    Dim graphData As String = "NONE"
    Dim skip As Boolean = 0
    Dim disableSona As Integer
    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine
    Dim synth As New Synthesis.SpeechSynthesizer
    Dim checking As Integer
    Dim TIME As String
    Dim command As String


    Delegate Sub SetTextCallBack(ByVal [text] As String)

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        portComboBox.Items.AddRange(myPort)

        baduComboBox.Enabled = False

        openButton.Enabled = False
        closeButton.Enabled = False

        Inside_data_graphsvb.Activate()
        Outside_data_graps.Activate()

        synth.SelectVoiceByHints(Synthesis.VoiceGender.Female)

    End Sub

    Private Sub portComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles portComboBox.SelectionChangeCommitted
        baduComboBox.Enabled = True
    End Sub

    Private Sub baduComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baduComboBox.SelectionChangeCommitted
        openButton.Enabled = True
    End Sub

    Private Sub openButton_Click(sender As System.Object, e As System.EventArgs) Handles openButton.Click
        portComboBox.Enabled = False
        baduComboBox.Enabled = False

        SerialPort1.PortName = portComboBox.Text
        SerialPort1.BaudRate = baduComboBox.Text

        SerialPort1.Open()

        openButton.Enabled = False
        closeButton.Enabled = True

        CheckBox2.Enabled = True

        writeToPort.Enabled = True
        commandTextBox.Enabled = True
        CheckBox1.Enabled = True

    End Sub

    Private Sub closeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeButton.Click
        SerialPort1.Close()

        portComboBox.Enabled = True
        baduComboBox.Enabled = True

        openButton.Enabled = True
        closeButton.Enabled = False

        CheckBox2.Checked = False
        CheckBox2.Enabled = False

        commandTextBox.Enabled = False
        writeToPort.Enabled = False
        CheckBox1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        RTC.Text = TimeOfDay

        ProgressBar2.Value = TimeOfDay.ToString("HHmmss")

        If hoursLabel.Visible = True Then
            If hoursLabel.Text = TimeOfDay.ToString("HH") Then
                If minutesLabel.Text = TimeOfDay.ToString("mm") Then
                    If secondsLabel.Text = TimeOfDay.ToString("ss") Then
                        My.Computer.Audio.Play("C:\Mart225 Software\AlarmTimeReached.wav", AudioPlayMode.BackgroundLoop)
                        DisableAlarm.Activate()
                        DisableAlarm.Show()
                    End If

                End If

            End If

        End If
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        recievedText(SerialPort1.ReadExisting())
    End Sub

    Private Sub recievedText(ByVal [text] As String)
        If Me.outputTextBox.InvokeRequired Then
            Dim x As New SetTextCallBack(AddressOf recievedText)
            Me.Invoke(x, New Object() {(text)})

            graphData = text

            TIME = DateAndTime.Now.ToString("HH:mm;dd/MM")

            If text.StartsWith("*#") Or text.StartsWith("&$") Or text.StartsWith("^@") Or text.StartsWith("%~") Then
                skip = 1
                text = ""
            Else
                skip = 0
            End If

            If text.StartsWith("*") Or text.StartsWith("&") Or text.StartsWith("^") Or text.StartsWith("%") Then
                skip = 1
                text = ""
            Else
                skip = 0
            End If

            If text.StartsWith("*#") Then
                skip = 1
                text = ""
            Else
                skip = 0
            End If

            If text.StartsWith("&$") Then
                skip = 1
                text = ""
            Else
                skip = 0
            End If

            If text.StartsWith("^@") Then
                skip = 1
                text = ""
            Else
                skip = 0
            End If

            If text.StartsWith("%~") Then
                skip = 1
                text = ""
            Else
                skip = 0
            End If

            If text = ("") Then
                skip = 1
                text = ""
            End If

            If text.StartsWith("*") Then
                skip = 1
                text = ""
            End If

            If text.StartsWith("&") Then
                skip = 1
                text = ""
            End If

            If text.StartsWith("^") Then
                skip = 1
                text = ""
            End If

            If text.StartsWith("%") Then
                skip = 1
                text = ""
            End If

            If skip = 0 Then
                Dim fileDateTime As String = DateTime.Now.ToString("[dd/MM/yyyy") & " AT: " & DateTime.Now.ToString("HH:mm:ss] ")

                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("c:\wamp\logs\SERIAL_LOG.txt", True)
                file.Write(fileDateTime)
                file.WriteLine(text)
                file.Close()
            End If

            skip = 0

        Else

            If text.Contains("POSSIBLE FIRE OR THEAF!") Then
                My.Computer.Audio.Play("C:\Mart225 Software\OUTDOORHOT.wav", AudioPlayMode.BackgroundLoop)
                falseAlarmButton.Visible = True
            End If

            If text.Contains("POSSIBLE FREEZING AND MOISTURING THE SYSTEM!") Then
                My.Computer.Audio.Play("C:\Mart225 Software\FREEZINGWARNING.wav", AudioPlayMode.BackgroundLoop)
                falseAlarmButton.Visible = True
            End If

            If text.Contains("POSSIBE FIRE OR MALFUNCTION!") Then
                My.Computer.Audio.Play("C:\Mart225 Software\FIRE.wav", AudioPlayMode.BackgroundLoop)
                falseAlarmButton.Visible = True
            End If

            If text.StartsWith("*#") Or text.StartsWith("&$") Or text.StartsWith("^@") Or text.StartsWith("%~") Or text = "" Or text.StartsWith(">}") Then
                skip = 1
                text = ""
            Else
                skip = 0
            End If

            If text.StartsWith("*") Or text.StartsWith("&") Or text.StartsWith("^") Or text.StartsWith("%") Or text = "" Or text.StartsWith(">") Then
                skip = 1
                text = ""
            Else
                skip = 0
            End If

            If text.StartsWith("*#") Then
                skip = 1
                text = ""
            Else
                skip = 0
            End If

            If text.StartsWith("&$") Then
                skip = 1
                text = ""
            Else
                skip = 0
            End If

            If text.StartsWith("^@") Then
                skip = 1
                text = ""
            Else
                skip = 0
            End If

            If text.StartsWith("%~") Then
                skip = 1
                text = ""
            Else
                skip = 0
            End If

            If text = ("") Then
                skip = 1
                text = ""
            End If

            If text.StartsWith("*") Then
                skip = 1
                text = ""
            End If

            If text.StartsWith("&") Then
                skip = 1
                text = ""
            End If

            If text.StartsWith("^") Then
                skip = 1
                text = ""
            End If

            If text.StartsWith("%") Then
                skip = 1
                text = ""
            End If

            If text.StartsWith(">") Then
                skip = 1
                text = ""
            End If

            If skip = 0 Then
                outputTextBox.Text &= [text]

                outputTextBox.SelectionStart = outputTextBox.Text.Length
                outputTextBox.ScrollToCaret()
            End If
            skip = 0

        End If
        text = ""

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            disableSona = 0
            reco.SetInputToDefaultAudioDevice()
            Dim gram As New Recognition.SrgsGrammar.SrgsDocument
            Dim commandRule As New Recognition.SrgsGrammar.SrgsRule("command")
            Dim commandList As New Recognition.SrgsGrammar.SrgsOneOf("hey sona", "do you want to tell something to the people", "set an alarm", "make me laugh", "get new data", "enable ethernet access", "disable ethernet access", "what's the time right now", "read all data", "what date is today", "turn on the lights", "turn off the lights", "open temperature graph", "close temperature graph", "open light graph", "close light graph", "turn on blue light", "turn on red light", "turn on green light", "turn off all lights")

            commandRule.Add(commandList)
            gram.Rules.Add(commandRule)
            gram.Root = commandRule
            reco.LoadGrammar(New Recognition.Grammar(gram))
            reco.RecognizeAsync()

        ElseIf CheckBox2.Checked = False Then
            reco.RecognizeAsyncCancel()
            disableSona = 1
            synth.SpeakAsyncCancelAll()
        End If

    End Sub

    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted
        If disableSona = 1 Then
            reco.RecognizeAsyncCancel()

        ElseIf disableSona = 0 Then
            reco.RecognizeAsync()
        End If

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized
        synth.SelectVoiceByHints(Synthesis.VoiceGender.Female)

        Select Case e.Result.Text

            Case "get new data"
                If checking = 225 Then
                    SerialPort1.Write("UUU")
                    My.Computer.Audio.Play("C:\Mart225 Software\acepted.wav",
                    AudioPlayMode.Background)
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "turn on the lights"
                If checking = 225 Then
                    SerialPort1.Write("X")
                    synth.SpeakAsync("L,E,D lights turned on!")
                    My.Computer.Audio.Play("C:\Mart225 Software\acepted.wav",
                     AudioPlayMode.Background)
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "set an alarm"
                If checking = 225 Then
                    setAlarmButton.PerformClick()
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "do you want to tell something to the people"
                If checking = 225 Then
                    My.Computer.Audio.Play("C:\Mart225 Software\sonaSpeaks.wav",
                     AudioPlayMode.Background)
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "turn on red light"
                If checking = 225 Then
                    SerialPort1.Write("RRRR")
                    synth.SpeakAsync("red light turned on")
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If


            Case "turn on blue light"
                If checking = 225 Then
                    SerialPort1.Write("BBBB")
                    synth.SpeakAsync("blue light turned on")
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "turn on green light"
                If checking = 225 Then
                    SerialPort1.Write("TTTT")
                    synth.SpeakAsync("green light turned on")
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If


            Case "turn off all lights"
                If checking = 225 Then
                    SerialPort1.Write("YYYY")
                    synth.SpeakAsync("L,E,D lights turned off!")
                    My.Computer.Audio.Play("C:\Mart225 Software\acepted.wav",
                     AudioPlayMode.Background)
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If


            Case "turn off the lights"
                If checking = 225 Then
                    SerialPort1.Write("Z")
                    synth.SpeakAsync("L,E,D lights turned off!")
                    My.Computer.Audio.Play("C:\Mart225 Software\acepted.wav",
                     AudioPlayMode.Background)
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "enable ethernet access"
                If checking = 225 Then
                    CheckBox1.Checked = True
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "disable ethernet access"
                If checking = 225 Then
                    CheckBox1.Checked = False
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "what's the time right now"
                If checking = 225 Then
                    My.Computer.Audio.Play("C:\Mart225 Software\acepted.wav",
                    AudioPlayMode.Background)
                    Dim time As String = DateTime.Now.ToString("HH:mm:ss")
                    synth.SpeakAsync("It's " + time)
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "read all data"
                If checking = 225 Then
                    My.Computer.Audio.Play("C:\Mart225 Software\acepted.wav",
                    AudioPlayMode.Background)
                    synth.Volume = 100
                    synth.SpeakAsync(outputTextBox.Text)
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "what date is today"
                If checking = 225 Then
                    My.Computer.Audio.Play("C:\Mart225 Software\acepted.wav",
                     AudioPlayMode.Background)
                    Dim date1 As String = DateTime.Now.ToString("MMMM dd,yyyy")
                    synth.SpeakAsync("Today it is " + date1)
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If


            Case "open temperature graph"
                If checking = 225 Then
                    My.Computer.Audio.Play("C:\Mart225 Software\acepted.wav",
                     AudioPlayMode.Background)
                    outsideDataGraphButton.PerformClick()
                    synth.SpeakAsync("Temperature graph window, opened!")
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "close temperature graph"
                If checking = 225 Then
                    My.Computer.Audio.Play("C:\Mart225 Software\acepted.wav",
                     AudioPlayMode.Background)
                    Outside_data_graps.Hide()
                    synth.SpeakAsync("Temperature graph window, closed!")
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If


            Case "open light graph"
                If checking = 225 Then
                    My.Computer.Audio.Play("C:\Mart225 Software\acepted.wav",
                     AudioPlayMode.Background)
                    Button1.PerformClick()
                    synth.SpeakAsync("Light graph window, opened!")
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "close light graph"
                If checking = 225 Then
                    My.Computer.Audio.Play("C:\Mart225 Software\acepted.wav",
                     AudioPlayMode.Background)
                    Inside_data_graphsvb.Hide()
                    synth.SpeakAsync("Light graph window, closed!")
                    speechInterval.Enabled = False
                    checking = 0
                    speakNowLabel.Visible = False
                End If

            Case "make me laugh"
                If checking = 225 Then
                    My.Computer.Audio.Play("C:\Mart225 Software\acepted.wav",
                     AudioPlayMode.Background)
                    speakNowLabel.Visible = False
                    Dim ss As New Random
                    Dim RandomNumberjk As Integer = ss.Next(0, 9)
                    Select Case RandomNumberjk

                        Case 0
                            synth.SpeakAsync("Here is one blondy joke. A blonde rings up an airline. She asks, How long are your flights from America to England? The woman on the other end of the phone says Just a minute. The blonde says Thanks and hangs up the phone.")

                        Case 1
                            synth.SpeakAsync("Little girl asks Why does your son say, Cluck, cluck, cluck?,the Mother replys Because he thinks he's a chicken. the Little girl:, Why don't you tell him he's not a chicken? the Mother:, because We need the eggs.")

                        Case 2
                            synth.SpeakAsync("Tired of constant blonde jokes, a blonde dyes her hair brown. She goes for a drive in the country and sees a shepherd herding his sheep across the road. Hey, shepherd, if I guess how many sheep are here, can I keep one? she asks. The shepherd agrees. She blurts out, 352! The shepherd is stunned but keeps his word and allows her to pick a sheep. I'll take this one, she says proudly. It's the cutest! Hey lady, says the shepherd. If I guess your real hair color, can I have my dog back?")

                        Case 3
                            synth.SpeakAsync("Most people believe that if it ain't broke, don't fix it. Engineers believe that if it ain't broke, it doesn't have enough features yet.")

                        Case 4
                            synth.SpeakAsync("Blonde: I'm on the road a lot, and my clients are complaining that they can never reach me. Psychiatrist: Don 't you have a cell phone? Blonde: They are too expensive, so I did the next best thing: I put a mailbox in my car. Psychiatrist: And do you receive any letters? Blonde: No, but I figure it's because when I'm driving around, my zip code keeps changing.")

                        Case 5
                            synth.SpeakAsync("Math Teacher asks, If I have 5 bottles in one hand and 6 in the other hand, what do I have?,a Student answers:, A drinking problem.")

                        Case 6
                            synth.SpeakAsync("Why did the chicken cross the playground? To get to the other slide!! ")

                        Case 7
                            synth.SpeakAsync("A friend of mine thinks he is smart. He told me that the onion is the only food that makes you cry., so I threw a coconut at his face., No i'm not kidding, Martin still has a bump on his face!")

                        Case 8
                            synth.SpeakAsync("Teacher asks, Which book has helped you the most in your life? the Student reply's, My father's check book!")

                    End Select

                    speechInterval.Enabled = False
                    checking = 0

                End If

            Case "hey sona"
                checking = 225
                My.Computer.Audio.Play("C:\Mart225 Software\speechActive.wav",
    AudioPlayMode.Background)
                speechInterval.Enabled = True
                speakNowLabel.Visible = True

        End Select

    End Sub

    Private Sub speechInterval_Tick(sender As System.Object, e As System.EventArgs) Handles speechInterval.Tick
        checking = 0
        My.Computer.Audio.Play("C:\Mart225 Software\speechDisabled.wav",
        AudioPlayMode.Background)
        speakNowLabel.Visible = False
        speechInterval.Enabled = False

    End Sub


    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If graphData.StartsWith("*#") Or graphData.Contains("*#") Then
            Outside_data_graps.insideTempGraph.Series("Inside temperature").Points.AddXY(TIME, graphData.Remove(0, 2))
            temperatureLabel.Text = graphData.Remove(0, 2)
            temperatureLabel.Visible = True
            Label6.Visible = True
            Label1.Visible = True
            graphData = ""
            skip = 1
        End If

        If graphData.StartsWith("&$") Or graphData.Contains("&$") Then
            Outside_data_graps.outsideTempGraph.Series("Outside temperature").Points.AddXY(TIME, graphData.Remove(0, 2))
            outTemperatureLabel.Text = graphData.Remove(0, 2)
            outTemperatureLabel.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            graphData = ""
            skip = 1
        End If

        If graphData.StartsWith("^@") Or graphData.Contains("^@") Then
            Inside_data_graphsvb.insideLightGraph.Series("Ammount of light (IN)").Points.AddXY(TIME, graphData.Remove(0, 2))
            graphData = ""
            skip = 1
        End If

        If graphData.StartsWith("%") Or graphData.Contains("%") Then
            Inside_data_graphsvb.outsideLightGraph.Series("Ammount of light (OUT)").Points.AddXY(TIME, graphData.Remove(0, 2))
            graphData = ""
            skip = 1
        End If

        If graphData.StartsWith("*") Or graphData.Contains("*") Then
            Outside_data_graps.insideTempGraph.Series("Inside temperature").Points.AddXY(TIME, graphData.Remove(0, 2))
            graphData = ""
            skip = 1
        End If

        If graphData.StartsWith("&") Or graphData.Contains("&") Then
            Outside_data_graps.outsideTempGraph.Series("Outside temperature").Points.AddXY(TIME, graphData.Remove(0, 2))
            graphData = ""
            skip = 1
        End If

        If graphData.StartsWith("^") Or graphData.Contains("^") Then
            Inside_data_graphsvb.insideLightGraph.Series("Ammount of light (IN)").Points.AddXY(TIME, graphData.Remove(0, 2))
            graphData = ""
            skip = 1
        End If

        If graphData.StartsWith("%") Or graphData.Contains("%") Then
            Inside_data_graphsvb.outsideLightGraph.Series("Ammount of light (OUT)").Points.AddXY(TIME, graphData.Remove(0, 2))
            graphData = ""
            skip = 1
        End If

        If graphData.StartsWith(">}") Or graphData.Contains(">}") Then
            Chart1.Series("Humidity").Points.AddXY(TIME, graphData.Remove(0, 2))
            ProgressBar1.Value = graphData.Remove(0, 2)
            graphData = ""
            skip = 1
            Chart1.Visible = True
            ProgressBar1.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
        End If

        If graphData.StartsWith(">") Or graphData.Contains(">") Then
            Chart1.Series("Humidity").Points.AddXY(TIME, graphData.Remove(0, 2))
            ProgressBar1.Value = graphData.Remove(0, 2)
            graphData = ""
            skip = 1
            Chart1.Visible = True
            ProgressBar1.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
        End If
    End Sub

    Private Sub outsideDataGraphButton_Click(sender As System.Object, e As System.EventArgs) Handles outsideDataGraphButton.Click
        Outside_data_graps.Activate()
        Outside_data_graps.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Inside_data_graphsvb.Activate()
        Inside_data_graphsvb.Show()
    End Sub

    Private Sub writeToPort_Click(sender As System.Object, e As System.EventArgs) Handles writeToPort.Click
        command = commandTextBox.Text
        SerialPort1.WriteLine(command)
        commandTextBox.Text = ""

    End Sub

    Private Sub setAlarmButton_Click(sender As System.Object, e As System.EventArgs) Handles setAlarmButton.Click
        SetAlarm.Activate()
        SetAlarm.Show()
    End Sub

    Private Sub commandTimer_Tick(sender As System.Object, e As System.EventArgs) Handles commandTimer.Tick
        Dim webCommand As String
        webCommand = My.Computer.FileSystem.ReadAllText("C:\wamp\www\cmd.txt")

        If webCommand IsNot "" Then
            synth.SpeakAsync("Attention, code via web was executed!")
            Dim MSGDateTime As String = DateTime.Now.ToString("[HH:mm:ss") & " ON " & DateTime.Now.ToString("dd/MM/yyyy] ")
            timeDateCaution.Text = MSGDateTime
            commandMSG.Text = (webCommand)
            CautionMSG.Visible = True
            commandMSG.Visible = True
            at.Visible = True
            timeDateCaution.Visible = True
            SerialPort1.Write(webCommand)
            System.IO.File.WriteAllText("C:\wamp\www\cmd.txt", "")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            commandTimer.Enabled = True
            synth.SpeakAsync("Ethernet access granted!")
        End If

        If CheckBox1.Checked = False Then
            commandTimer.Enabled = False
            synth.SpeakAsync("Ethernet access denied!")
        End If
    End Sub

    Private Sub falseAlarmButton_Click(sender As System.Object, e As System.EventArgs) Handles falseAlarmButton.Click
        My.Computer.Audio.Stop()
        falseAlarmButton.Visible = False
    End Sub
End Class