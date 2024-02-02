Imports System.Globalization

Public Class Main_Menu
    Private mosquitoTimer As New Timer()
    Private delayTimer As New Timer()

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        realclock.Start()

        mosquitoTimer.Interval = 3000 ' 20 seconds
        AddHandler mosquitoTimer.Tick, AddressOf MosquitoTimer_Tick

        delayTimer.Interval = 2000 ' 5 seconds
        AddHandler delayTimer.Tick, AddressOf DelayTimer_Tick
    End Sub

    Private Sub MosquitoTimer_Tick(sender As Object, e As EventArgs)
        Dim randomNumber As Integer = (New Random()).Next(1, 4) ' Generates a random number between 1 and 3

        If randomNumber = 1 Then
            ' Log the motion detection message
            LogRichTextBox.AppendText($"{DateTime.Now.ToString("h:mm:ss tt")} - Motion detected, maybe it's a random mosquito?{vbCrLf}")
            FencePic.Image = My.Resources.FenceWithElectricRealMosquito

            ' Temporarily disable mosquitoTimer during the delay
            mosquitoTimer.Stop()

            ' Start the delay timer
            delayTimer.Start()
        End If
    End Sub

    Private Sub DelayTimer_Tick(sender As Object, e As EventArgs)
        ' Code to execute after the 5-second delay
        ' LogRichTextBox.AppendText($"{DateTime.Now.ToString("HH:mm:ss")} - Something occurs after the delay.{vbCrLf}")

        ' Stop the delay timer
        delayTimer.Stop()
        FencePic.Image = My.Resources.FenceWithElectricReal

        ' Re-enable mosquitoTimer
        mosquitoTimer.Start()
    End Sub


    Private lastScheduleState As Boolean = False 'False represents deactivated, True represents activated
    Private initialParsingFailed As Boolean = False

    Private Sub realclock_Tick(sender As Object, e As EventArgs) Handles realclock.Tick
        Dim currentTime As DateTime = DateTime.Now
        Dim scheduledStartTime As DateTime
        Dim scheduledEndTime As DateTime

        ' Parse the text in ScheduleStartTextbox.Text and ScheduleUntilTextbox.Text to DateTime
        Dim startParsingSuccess = DateTime.TryParseExact(ScheduleStartTextbox.Text, "h:mm:ss tt", Nothing, DateTimeStyles.None, scheduledStartTime)
        Dim endParsingSuccess = DateTime.TryParseExact(ScheduleUntilTextbox.Text, "h:mm:ss tt", Nothing, DateTimeStyles.None, scheduledEndTime)

        ' Check if parsing was successful for both start and end times
        If startParsingSuccess AndAlso endParsingSuccess Then
            ' Check if the current time is within the scheduled start and end times
            Dim isScheduledTime = currentTime >= scheduledStartTime AndAlso currentTime <= scheduledEndTime

            ' Check if the schedule state has changed
            If isScheduledTime AndAlso Not lastScheduleState Then
                ' The fence is activated
                LogRichTextBox.AppendText($"{currentTime.ToString("h:mm:ss tt")} - The electric fence has been activated.{vbCrLf}")
                lastScheduleState = True

                FencePic.Image = My.Resources.FenceWithElectricReal

                mosquitoTimer.Start()
            ElseIf Not isScheduledTime AndAlso lastScheduleState Then
                ' The fence is deactivated
                LogRichTextBox.AppendText($"{currentTime.ToString("h:mm:ss tt")} - The electric fence has been deactivated.{vbCrLf}")
                lastScheduleState = False

                FencePic.Image = My.Resources.FenceWithoutElectricReal
                mosquitoTimer.Stop()
                delayTimer.Stop()
            End If
        ElseIf initialParsingFailed Then
            ' Log an error if parsing fails, but only if the error hasn't been logged before
            LogRichTextBox.AppendText($"{currentTime.ToString("HH:mm:ss")} - Error: Failed to parse scheduled times. Default values used.{vbCrLf}")
            ' Set the flag to indicate that the error has been logged for the current schedule
            initialParsingFailed = True
        End If

        ' Update the UI elements with the current time
        digiclock.Text = Format(currentTime, "h:mm:ss tt")
        current_date.Text = Format(currentTime, "MMMM d, yyyy")
        Dim minsofday As Integer = (Convert.ToInt32(currentTime.Hour) * 60) + Convert.ToInt32(currentTime.Minute)
        timeofday(minsofday)
    End Sub

    Private Sub Main_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        realclock.Stop()
    End Sub

    Private Sub timeofday(minsofday As Integer)
        If (minsofday >= 300 And minsofday < 1050) Then
            tod.Image = My.Resources.ResourceManager.GetObject("day")
        ElseIf (minsofday >= 1050 And minsofday < 1110) Then
            tod.Image = My.Resources.ResourceManager.GetObject("sunriseset")
        Else
            tod.Image = My.Resources.ResourceManager.GetObject("night")
        End If
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If String.IsNullOrEmpty(FromTextbox.Text) And String.IsNullOrEmpty(ToTextbox.Text) Then
            MessageBox.Show("Schedule is empty. Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not String.IsNullOrEmpty(FromTextbox.Text) And String.IsNullOrEmpty(ToTextbox.Text) Then
            MessageBox.Show("The end schedule is empty. Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(FromTextbox.Text) And Not String.IsNullOrEmpty(ToTextbox.Text) Then
            MessageBox.Show("The start schedule is empty. Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ScheduleUntilTextbox.Text = ToTextbox.Text
            ScheduleStartTextbox.Text = FromTextbox.Text

            LogRichTextBox.AppendText($"{DateTime.Now.ToString("h:mm:ss tt")} - The schedule has been set.{vbCrLf}")
        End If


    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        If Not String.IsNullOrEmpty(FromTextbox.Text) Then
            ScheduleStartTextbox.Text = ""
            ScheduleUntilTextbox.Text = ""
            FromTextbox.Text = ""
            ToTextbox.Text = ""
        End If

        LogRichTextBox.AppendText($"{DateTime.Now.ToString("h:mm:ss tt")} - The schedule and/or the electric fence has stopped!{vbCrLf}")
        FencePic.Image = My.Resources.FenceWithoutElectricReal
        mosquitoTimer.Stop()
        delayTimer.Stop()
    End Sub
End Class